Imports Npgsql
Module PGSQL_MECSTA
    ' # MODULO DE FUNCIONES PGSQL PARA LA INTERFACE DE ESTACIONES MECANICAS DE LA APLICACION.
    Function PGSQL_TACTIL_LOGGIN(ByVal Rut As TextBox, ByVal Pass As TextBox, ByVal Station As ComboBox) As Boolean
        ' # FUNCION QUE REALIZA EL LOGEO DEL USUARIO MECANICO EN LA ESTACION.
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim CommandPGSQL As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            ConexPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT id, rut, password FROM personal WHERE rut=@RUT LIMIT 1"
            CommandPGSQL.Parameters.AddWithValue("@RUT", Trim(Rut.Text))
            rd = CommandPGSQL.ExecuteReader
            If rd.HasRows = False Then
                Rut.BackColor = ColorTranslator.FromHtml("#ba0000")
                Rut.ForeColor = ColorTranslator.FromHtml("#ffffff")
                ConexPGSQL.Close()
                Return False
            End If
            rd.Read()
            If rd(2).ToString = Login_Md5Encrypt(Pass.Text) Then
                mec_dashboard.MecUserID = rd(0).ToString
                mec_dashboard.MecStation = Station.Text
                mec_dashboard.MecStationID = Station.SelectedValue
                ConexPGSQL.Close()
                Return True
            Else
                Pass.BackColor = ColorTranslator.FromHtml("#ba0000")
                Pass.ForeColor = ColorTranslator.FromHtml("#ffffff")
                ConexPGSQL.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error mientras se trataba de realizar el inicio de sesión por favor contacte al equipo de desarrollo.", Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function PGSQL_TACTIL_GETSTATIONS() As Dictionary(Of String, String)
        ' ########################################################
        ' # FUNCION QUE OBTENE LA LISTA DE ESTACIONES DE TRABAJO.
        ' # MODO DE VOLCADO: var(Key)(Value)
        ' ########################################################
        Dim ReturnArray As New Dictionary(Of String, String)
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                              ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                              ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                              ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                              ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim CommandPGSQL As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            ConexPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT id, nombre FROM estacionesmecanicas ORDER BY nombre ASC"
            rd = CommandPGSQL.ExecuteReader
            If rd.HasRows = False Then
                ReturnArray.Add("", "SIN ESTACIONES.")
                ConexPGSQL.Close()
                Return ReturnArray
            End If
            ReturnArray.Add("", "ESCOJA.")
            While rd.Read
                ReturnArray.Add(rd(0).ToString, rd(1).ToString.ToUpper)
            End While
            ConexPGSQL.Close()
            Return ReturnArray
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al obtener la lista de estaciones desde la base de datos.", Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("", "")
            Return ReturnArray
        End Try
    End Function
    Public Sub PGSQL_TACTIL_LOADOT(ByVal idEstacion As String, ByVal DGV As DataGridView)
        ' # FUNNCION QUE CARGA LAS ORDENES DE TRABAJO ASIGANADAS A LA ESTACION.
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                             ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                             ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                             ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                             ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim CommandPGSQL As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            ConexPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT notrabajo, nombretipo, concat(nombremarca, ' ', nombremodelo) AS equipo, idmechanicstation, estsadoid, estadonombre, idtipo FROM vista_lista_mechstation WHERE idmechanicstation=@NumStation AND estsadoid !=8"
            CommandPGSQL.Parameters.AddWithValue("@NumStation", Integer.Parse(idEstacion))
            rd = CommandPGSQL.ExecuteReader
            PGSQLDataTable.Load(rd)
            DGV.DataSource = PGSQLDataTable
            ConexPGSQL.Close()
        Catch exe As Exception
            MessageBox.Show("Ocurrió un error al cargar las órdenes de trabajo de la estación desde la base de datos, por favor contacte al equipo de desarrollo." & _
                            vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Function PGSQL_TACTIL_MEDSAVE(ByVal NumeroOT As String, ByVal idComponente As String, ByVal Zona As String, ByVal Pos As Integer, ByVal g45 As String, _
                                         ByVal g90 As String, ByVal g135 As String, ByVal g180 As String, ByVal Promedio As String) As Boolean
        ' ############################################################################
        ' # FUNCION QUE ALMACENA LAS MEDICIONES EN LA BASE DE DATOS.
        ' # ES IMPORTANTE ACLARAR QUE CUANDO EL VALOR YA EXISTE 
        ' # (COMPROBADO POR LA POSICION 1,2,3) DEBE ACTUALIZARLO NO INSERTAR UNO NUEVO.
        ' #############################################################################
        Dim ValoresAnteriores As New Dictionary(Of String, String)
        ValoresAnteriores = PGSQL_TACTIL_MEDLOAD(NumeroOT, idComponente, Zona)
        Try

            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim CommandPGSQL As NpgsqlCommand
            ConexPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            ' # SI EXISTE EL PARAMETRO DE MEDICION ACTUALIZAR LOS VALORES.
            If ValoresAnteriores.ContainsKey(Pos) = True Then
                CommandPGSQL.CommandText = "UPDATE med_ots SET g45=@g45, g90=@g90, g135=@g135, g180=@g180, apromedio=@promedio WHERE pos=@pos AND zona=@zona"
                CommandPGSQL.Parameters.AddWithValue("@g45", Single.Parse(Trim(g45)))
                CommandPGSQL.Parameters.AddWithValue("@g90", Single.Parse(Trim(g90)))
                CommandPGSQL.Parameters.AddWithValue("@g135", Single.Parse(Trim(g135)))
                CommandPGSQL.Parameters.AddWithValue("@g180", Single.Parse(Trim(g180)))
                CommandPGSQL.Parameters.AddWithValue("@promedio", Single.Parse(Trim(Promedio)))
                CommandPGSQL.Parameters.AddWithValue("@pos", Integer.Parse(Pos))
                CommandPGSQL.Parameters.AddWithValue("@zona", Integer.Parse(Zona))
            Else
                CommandPGSQL.CommandText = "INSERT INTO med_ots (notrabajo, idcomponente, g45, g90, g135, g180, apromedio, pos, zona) VALUES (@ot, @componente, @g45, @g90, @g135, @g180, @promedio, @pos, @zona)"
                CommandPGSQL.Parameters.AddWithValue("@ot", Integer.Parse(NumeroOT))
                CommandPGSQL.Parameters.AddWithValue("@componente", Integer.Parse(idComponente))
                CommandPGSQL.Parameters.AddWithValue("@g45", Single.Parse(Trim(g45)))
                CommandPGSQL.Parameters.AddWithValue("@g90", Single.Parse(Trim(g90)))
                CommandPGSQL.Parameters.AddWithValue("@g135", Single.Parse(Trim(g135)))
                CommandPGSQL.Parameters.AddWithValue("@g180", Single.Parse(Trim(g180)))
                CommandPGSQL.Parameters.AddWithValue("@promedio", Single.Parse(Trim(Promedio)))
                CommandPGSQL.Parameters.AddWithValue("@pos", Integer.Parse(Pos))
                CommandPGSQL.Parameters.AddWithValue("@zona", Integer.Parse(Zona))
            End If
            CommandPGSQL.ExecuteNonQuery()
            ConexPGSQL.Close()
            Return True
        Catch exe As Exception
            MessageBox.Show("Ocurrió un error al grabar las medidas del componente en la base de datos, por favor contacte al equipo de desarrollo." & _
                           vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function PGSQL_TACTIL_MEDLOAD(ByVal NumeroOT As String, ByVal idComponente As String, ByVal ZonaMed As String) As Dictionary(Of String, String)
        ' ###############################################################################
        ' # FUNCION ENCARGADA DE DEVOLVER LAS MEDICIONES QUE SE HAN REALIZADO AL CAMPO. #
        ' ###############################################################################
        ' # DEFINICION DE VALORES ARRAY:
        ' # ReturnArray() Dictionary Key, Value
        ' # Key: Zona (Zona de medicion a la cual estan ingresados las mediciones)
        ' # Vaues: (Posicion, 45°, 90°, 135°, 180°) Separador #
        ' ###############################################################################
        Dim ReturnArray As New Dictionary(Of String, String)
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                            ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                            ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                            ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                            ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim CommandPGSQL As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            ConexPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT id, notrabajo, idcomponente, g45, g90, g135, g180, apromedio, pos, zona FROM med_ots WHERE notrabajo=@OT AND idcomponente=@componente AND zona=@zonamed"
            CommandPGSQL.Parameters.AddWithValue("@OT", Integer.Parse(NumeroOT))
            CommandPGSQL.Parameters.AddWithValue("@componente", Integer.Parse(idComponente))
            CommandPGSQL.Parameters.AddWithValue("@zonamed", Integer.Parse(ZonaMed))
            rd = CommandPGSQL.ExecuteReader()
            If rd.HasRows = False Then
                ReturnArray.Add("0", "ERROR")
                ConexPGSQL.Close()
                Return ReturnArray
            End If
            While rd.Read()
                ReturnArray.Add(rd(8).ToString, rd(3).ToString & "#" & rd(4).ToString & "#" & rd(5).ToString & "#" & rd(6).ToString)
            End While
            ConexPGSQL.Close()
            Return ReturnArray
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al obtener las mediciones desde la base de datos, contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("0", "ERROR")
            Return ReturnArray
        End Try
    End Function
    Public Function PGSQL_TACTIL_MEDPROMLOAD(ByVal NumeroOT As String, ByVal idComponente As String) As Dictionary(Of String, String)
        ' ######################################################################
        ' # FUNCION QUE CARGA LOS PROMEDIOS GENERALES DE TODAS LAS ZONAS.
        ' ######################################################################
        ' # RETORNO FUNCION DICTIONARY(KEY, VALUE)
        ' # KEY = ZONA | VALUE=PROMEDIO
        ' ######################################################################
        Dim ReturnArray As New Dictionary(Of String, String)
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                            ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                            ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                            ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                            ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim CommandPGSQL As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            ConexPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "select zona, sum(apromedio), count(*) AS pos FROM med_ots WHERE  notrabajo=@OT AND idcomponente=@idcomponente GROUP BY zona"
            CommandPGSQL.Parameters.AddWithValue("@OT", Integer.Parse(NumeroOT))
            CommandPGSQL.Parameters.AddWithValue("@idcomponente", Integer.Parse(idComponente))
            rd = CommandPGSQL.ExecuteReader
            If rd.HasRows = False Then
                ReturnArray.Add("0", "0")
                ConexPGSQL.Close()
                Return ReturnArray
            End If
            While rd.Read
                Dim Promedio As Long = Val(rd(1)) / Val(rd(2))
                ReturnArray.Add(rd(0), Promedio)
            End While
            ConexPGSQL.Close()
            Return ReturnArray
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al obtener las mediciones desde la base de datos, contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("0", "ERROR")
            Return ReturnArray
        End Try
    End Function
    Public Function PGSQL_TACTIL_FLEXSAVE(ByVal NumeroOT As Integer, ByVal idComponente As Integer, ByVal Pos As Integer, _
                                          ByVal g0 As Single, ByVal g45 As Single, ByVal g90 As Single, ByVal g135 As Single) As Boolean
        ' ################################################################################
        ' # FUNCION ENCARGADA DE GUARDAR LOS PARAMETROS DE FLEXION EN LA BASE DE DATOS.  #
        ' ################################################################################
        ' # Desc. FUNC: La funcion guarda la informacion en la tabla "flex_ots", en caso #
        ' # que ya exista el registro en la base de datos este debe actualizarle con la  #
        ' # Func. UPDATE() de PGSQL.(impedir duplicados).                                #
        ' ################################################################################
        Dim ValoresAnteriores As New Dictionary(Of Integer, String)
        ValoresAnteriores = PGSQL_TACTIL_FLEXLOAD(NumeroOT, idComponente)
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                           ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                           ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                           ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                           ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim CommandPGSQL As NpgsqlCommand
            ConexPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            If ValoresAnteriores.ContainsKey(Integer.Parse(Pos)) = True Then
                CommandPGSQL.CommandText = "UPDATE flex_ots SET g0=@g0, g45=@g45, g90=@g90, g135=@g135 WHERE notrabajo=@OT AND idcomponente=@componente AND pos=@pos"
            Else
                CommandPGSQL.CommandText = "INSERT INTO flex_ots (notrabajo, idcomponente, g0, g45, g90, g135, pos) VALUES (@OT, @componente, @g0, @g45, @g90, @g135, @pos)"
            End If
            CommandPGSQL.Parameters.AddWithValue("@OT", NumeroOT)
            CommandPGSQL.Parameters.AddWithValue("@componente", idComponente)
            CommandPGSQL.Parameters.AddWithValue("@g0", Val(g0))
            CommandPGSQL.Parameters.AddWithValue("@g45", Val(g45))
            CommandPGSQL.Parameters.AddWithValue("@g90", Val(g90))
            CommandPGSQL.Parameters.AddWithValue("@g135", Val(g135))
            CommandPGSQL.Parameters.AddWithValue("@pos", Val(Pos))
            CommandPGSQL.ExecuteNonQuery()
            ConexPGSQL.Close()
            Return True
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al guardar los registros de flexion en la base de datos, contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                           "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function PGSQL_TACTIL_FLEXLOAD(ByVal NumeroOT As Integer, ByVal idComponente As Integer) _
        As Dictionary(Of Integer, String)
        ' ############################################################################# '
        ' # FUNCION QUE OBTIENE LOS DATOS DE LAS MEDICIONES DE FLEXION                # '
        ' ############################################################################# '
        ' # Desc. Func: Funcion que obtiene las mediciones ya guardadas en la base de # '
        ' # datos, tipo de funcion Dictionary(int, string):                           # '
        ' # int : Posicion (Pos) de la medicion en la tabla.                          # '
        ' # string : valores desde los 0° hasta los 135° con el delimitador (#)       # '
        ' ############################################################################# '
        Dim ReturnArray As New Dictionary(Of Integer, String)
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                          ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                          ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                          ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                          ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim CommandPGSQL As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            ConexPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT notrabajo, idcomponente, g0, g45, g90, g135, pos FROM flex_ots WHERE notrabajo=@OT AND idcomponente=@componente"
            CommandPGSQL.Parameters.AddWithValue("@OT", Integer.Parse(NumeroOT))
            CommandPGSQL.Parameters.AddWithValue("@componente", Integer.Parse(idComponente))
            rd = CommandPGSQL.ExecuteReader()
            If rd.HasRows = False Then
                ReturnArray.Add(0, 0)
                ConexPGSQL.Close()
                Return ReturnArray
            End If
            While rd.Read
                ReturnArray.Add(Integer.Parse(rd(6)), rd(2).ToString & "#" & rd(3).ToString & "#" & rd(4).ToString & "#" & rd(5).ToString)
            End While
            ConexPGSQL.Close()
            Return ReturnArray
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al cargar los registros de flexion desde base de datos, contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                          "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add(0, "ERROR")
            Return ReturnArray
        End Try
    End Function
End Module
