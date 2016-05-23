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
            CommandPGSQL.CommandText = "INSERT INTO med_ots (notrabajo, idcomponente, g45, g90, g135, g180, apromedio, pos, zona) VALUES (@ot, @componente, @g45, @g90, @g135, @g180, @promedio, @pos, @zona)"
            CommandPGSQL.Parameters.AddWithValue("@ot", Integer.Parse(NumeroOT))
            CommandPGSQL.Parameters.AddWithValue("@componente", Integer.Parse(idComponente))
            CommandPGSQL.Parameters.AddWithValue("@g45", Val(g45))
            CommandPGSQL.Parameters.AddWithValue("@g90", Val(g90))
            CommandPGSQL.Parameters.AddWithValue("@g135", Val(g135))
            CommandPGSQL.Parameters.AddWithValue("@g180", Val(g180))
            CommandPGSQL.Parameters.AddWithValue("@promedio", Val(Promedio))
            CommandPGSQL.Parameters.AddWithValue("@pos", Val(Pos))
            CommandPGSQL.Parameters.AddWithValue("@zona", Val(Zona))
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
End Module
