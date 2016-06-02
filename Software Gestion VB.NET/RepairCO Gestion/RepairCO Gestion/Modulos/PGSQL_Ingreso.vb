Imports Npgsql
Module PGSQL_Ingreso
    ' # RUTINAS DE ALIMENTACION DE LA BASE DE DATOS.
    ' # IMPORTANTE: TODOS LOS VALORES QUE SE VAN A ALMACENAR EN LA BASE DE DATOS TIENEN QUE SER INGRESADO EN LOWERCASE (MINUSCULAS)
    Private Ingreso_ConnectorPGSQL As NpgsqlConnection
    Private Ingreso_CommandPGSQL As NpgsqlCommand
    Public Function PGSQL_INGRESO_TIPO(ByVal NombreTipo As String) As Boolean
        Try
            Ingreso_ConnectorPGSQL = New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                  ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                  ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                  ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                  ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Ingreso_ConnectorPGSQL.Open()
            Ingreso_CommandPGSQL = New NpgsqlCommand
            Ingreso_CommandPGSQL.Connection = Ingreso_ConnectorPGSQL
            Ingreso_CommandPGSQL.CommandText = "INSERT INTO tipos_productos (nombre, iduseradd) VALUES (@nombre, @iduseragrega)"
            Ingreso_CommandPGSQL.Parameters.AddWithValue("@nombre", Trim(NombreTipo.ToLower))
            Ingreso_CommandPGSQL.Parameters.AddWithValue("@iduseragrega", Integer.Parse(_globalUserData(0).ToString))
            Ingreso_CommandPGSQL.ExecuteNonQuery()
            Ingreso_ConnectorPGSQL.Close()
            Return True
        Catch ex As Exception
            Ingreso_ConnectorPGSQL.Close()
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Public Function PGSQL_INGRESO_MARCA(ByVal idTipo As String, ByVal Marca As String, ByVal idPais As String) As Boolean
        Try
            Ingreso_ConnectorPGSQL = New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                        ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                        ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                        ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                        ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Ingreso_ConnectorPGSQL.Open()
            Ingreso_CommandPGSQL = New NpgsqlCommand
            Ingreso_CommandPGSQL.Connection = Ingreso_ConnectorPGSQL
            Ingreso_CommandPGSQL.CommandText = "INSERT INTO marcas (nombre, idtipo, idpais, iduseradd) VALUES (@nombre, @tipoid, @paisid, @useradd)"
            Ingreso_CommandPGSQL.Parameters.AddWithValue("@nombre", Trim(Marca.ToLower))
            Ingreso_CommandPGSQL.Parameters.AddWithValue("@tipoid", Integer.Parse(idTipo))
            Ingreso_CommandPGSQL.Parameters.AddWithValue("@paisid", Integer.Parse(idPais))
            Ingreso_CommandPGSQL.Parameters.AddWithValue("@useradd", Integer.Parse(_globalUserData(0)))
            Ingreso_CommandPGSQL.ExecuteNonQuery()
            Ingreso_ConnectorPGSQL.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Ingreso_ConnectorPGSQL.Close()
            Return False
        End Try
    End Function
    Public Function PGSQL_INGRESO_ADDOT(ByVal FechaIngreso As Date, ByVal Prioridad As String, ByVal TipoOT As Integer, _
                                        ByVal Cliente As String, ByVal GuiaDespacho As String, ByVal nOrdenCompra As String, _
                                        ByVal IdentificaEquipo As String, ByVal NumeroSerie As String, ByVal NumeroSerieFabrica As String, _
                                        ByVal NumeroContrato As String, ByVal TipoProducto As Integer, ByVal MarcaProducto As Integer, _
                                        ByVal ModeloProducto As Integer, ByVal NumeroOrdenTrabajo As Integer, ByVal Agendamiento As String, _
                                        ByVal Comentario As String, ByVal TAG As String, ByVal IngReparableID As Integer) As Boolean
        Try
            ' # AGREGAMOS NUEVA ORDEN AL SISTEMAS
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                               ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                               ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                               ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                               ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPGSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "INSERT INTO ordenestrabajo (notrabajo, nguiadespacho, idcliente, idtipo, idmarca, idmodelo, idrespingreso, nserie, prioridad, numerocontrato, fecha_ingreso, nseriefabricante, idestado, tipo, noc, nagendamiento, tag, ingrepaid) VALUES (@notrabajo, @guiadespacho, @idcliente, @idtipo, @idmarca, @idmodelo, @iduseringreso, @nserie, @prioridad, @ncontrato, @fechaingreso, @nseriefab, @estado, @tipot, @noc, @agendamiento, @tag, @ingreparable)"
            CommandPGSQL.Parameters.AddWithValue("@notrabajo", NumeroOrdenTrabajo)
            CommandPGSQL.Parameters.AddWithValue("@guiadespacho", GuiaDespacho.ToLower)
            CommandPGSQL.Parameters.AddWithValue("@idcliente", Integer.Parse(Cliente))
            CommandPGSQL.Parameters.AddWithValue("@idtipo", TipoProducto)
            CommandPGSQL.Parameters.AddWithValue("@idmarca", MarcaProducto)
            CommandPGSQL.Parameters.AddWithValue("@idmodelo", ModeloProducto)
            CommandPGSQL.Parameters.AddWithValue("@iduseringreso", Integer.Parse(_globalUserData(0).ToString))
            CommandPGSQL.Parameters.AddWithValue("@nserie", NumeroSerie.ToLower)
            CommandPGSQL.Parameters.AddWithValue("@prioridad", Prioridad.ToLower)
            CommandPGSQL.Parameters.AddWithValue("@ncontrato", NumeroContrato.ToLower)
            CommandPGSQL.Parameters.AddWithValue("@fechaingreso", FechaIngreso)
            CommandPGSQL.Parameters.AddWithValue("@nseriefab", NumeroSerieFabrica.ToLower)
            CommandPGSQL.Parameters.AddWithValue("@estado", 1)
            CommandPGSQL.Parameters.AddWithValue("@tipot", TipoOT)
            CommandPGSQL.Parameters.AddWithValue("@noc", nOrdenCompra)
            CommandPGSQL.Parameters.AddWithValue("@agendamiento", Agendamiento.ToLower)
            CommandPGSQL.Parameters.AddWithValue("@tag", TAG)
            CommandPGSQL.Parameters.AddWithValue("@ingreparable", Integer.Parse(IngReparableID))
            CommandPGSQL.ExecuteNonQuery()
            ConexPGSQL.Close()
            ' # AGREGAMOS COMENTARIO A LA BASE DE DATOS.
            If Comentario <> "" Or Comentario.Length > 3 Then
                ConexPGSQL = New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                               ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                               ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                               ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                               ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
                ConexPGSQL.Open()
                CommandPGSQL = New NpgsqlCommand
                CommandPGSQL.Connection = ConexPGSQL
                CommandPGSQL.CommandType = CommandType.Text
                CommandPGSQL.CommandText = "INSERT INTO otcomentarios (iduser, comentario, idot) VALUES (@useradd, @comment, @numerot)"
                CommandPGSQL.Parameters.AddWithValue("@useradd", Integer.Parse(_globalUserData(0)))
                CommandPGSQL.Parameters.AddWithValue("@comment", Comentario)
                CommandPGSQL.Parameters.AddWithValue("@numerot", Integer.Parse(NumeroOrdenTrabajo))
                CommandPGSQL.ExecuteNonQuery()
                ConexPGSQL.Close()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al ingresar la orden de trabajo en la base de datos, por favor contacte al equipo de desarrollo de la aplicación." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function PGSQL_ADDCOMENTARIO(ByVal NumeroOT As String, ByVal Comentario As String) As Boolean
        ' # FUNCION QUE GUARDA LOS COMENTARIOS EN LA BASE DE DATOS.
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                              ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                              ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                              ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                              ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPGSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "INSERT INTO otcomentarios (idot, comentario, iduser) VALUES (@idot, @comentario, @user)"
            CommandPGSQL.Parameters.AddWithValue("@idot", Integer.Parse(NumeroOT))
            CommandPGSQL.Parameters.AddWithValue("@comentario", Comentario)
            CommandPGSQL.Parameters.AddWithValue("@user", Integer.Parse(_globalUserData(0)))
            CommandPGSQL.ExecuteNonQuery()
            ConexPGSQL.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al ingresar las imágenes a la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                           "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function PGSQL_ADDIMGOT(ByVal NumeroOrden As String, ByVal NombreImagen As String) As Boolean
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                               ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                               ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                               ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                               ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPGSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "INSERT INTO otimages (nimagen, idot) VALUES (@imagen, @otnumber)"
            CommandPGSQL.Parameters.AddWithValue("@imagen", NombreImagen)
            CommandPGSQL.Parameters.AddWithValue("@otnumber", Integer.Parse(NumeroOrden))
            CommandPGSQL.ExecuteNonQuery()
            ConexPGSQL.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al ingresar las imágenes a la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function PGSQL_ADDIVISUAL(ByVal OT As Integer, ByVal idComponente As Integer, ByVal Parametros As Dictionary(Of Integer, String)) As Boolean
        ' ######################################################################### '
        ' # FUNCION QUE AÑADE LAS INPECCIONES VISUALES AL SERVIDOR POSTGRESQL.    # '
        ' # LA TABLA UTILIZADA PARA ESTA LABOR ES: ot_inspvisual.                 # '
        ' ######################################################################### '
        ' # DESCRIPCION Parametros generales.                                     # '
        ' # 0= Limpieza | 1= Recuperar | 2= Cambiar.                              # '
        ' ######################################################################### '
        ' # DESCRIPCION DE ZONAS.                                                 # '
        ' # z1 = EJE: cond. hilo de tuerca fijacion de rodamiento.                # '
        ' # z2 = EJE: cond. chaveta y chavetero.                                  # '
        ' # z3 = CARCASA: cond. de zona ajuste.                                   # '
        ' # z4 = CARCASA: cond. de flange.                                        # '
        ' # z5 = CARCASA: cond. patas de apoyo.                                   # '
        ' # z6 = IMPULSOR: cond. Ø hilo interior                                  # '
        ' # z7 = IMPULSOR: cond. chavetero impulsor.                              # '
        ' # z8 = IMPULSOR: cond. alabes.                                          # '
        ' # z9 = FRAME ADAPTER: cond. de caras frontales.                         # '
        ' # z10 = FRAME ADAPTER: cond. de hilos y agujeros.                       # '
        ' # z11 = FRAME ADAPTER: cond. de pestaña ajuste.                         # '
        ' # z12 = FRAME ADAPTER: cond. de alojamiento laberinto.                  # '
        ' # z13 = STAFIN BOX: cond. cara frontal.                                 # '
        ' # z14 = STAFIN BOX: cond. de esparragos.                                # '
        ' # z15 = STAFIN BOX: cond. de lineas de refrigeracion.                   # '
        ' # z16 = CPO. ROD: cond. de hilo de amarre de frame.                     # '
        ' # z17 = CPO. ROD: cond. de seguro rod. axial.                           # '
        ' # z18 = CPO. ROD: cond. de seguro radia.                                # '
        ' # z19 = SELLO MECANICO: cond. de caras de contacto.                     # '
        ' # z20 = SELLO MECANICO: cond. de collarin.                              # '
        ' # z21 = SELLO MECANICO: cond. de o'ring.                                # '
        ' # z22 = SELLO MECANICO: tipo de sello.                                  # '
        ' ######################################################################### '
        Dim z1 As Integer = 0
        Dim z2 As Integer = 0
        Dim z3 As Integer = 0
        Dim z4 As Integer = 0
        Dim z5 As Integer = 0
        Dim z6 As Integer = 0
        Dim z7 As Integer = 0
        Dim z8 As Integer = 0
        Dim z9 As Integer = 0
        Dim z10 As Integer = 0
        Dim z11 As Integer = 0
        Dim z12 As Integer = 0
        Dim z13 As Integer = 0
        Dim z14 As Integer = 0
        Dim z15 As Integer = 0
        Dim z16 As Integer = 0
        Dim z17 As Integer = 0
        Dim z18 As Integer = 0
        Dim z19 As Integer = 0
        Dim z20 As Integer = 0
        Dim z21 As Integer = 0
        Dim z22 As Integer = 0
        If Parametros.ContainsKey(1) = True Then
            z1 = 1
        ElseIf Parametros.ContainsKey(2) = True Then
            z2 = 1
        ElseIf Parametros.ContainsKey(3) = True Then
            z3 = 1
        ElseIf Parametros.ContainsKey(4) = True Then
            z4 = 1
        ElseIf Parametros.ContainsKey(5) = True Then
            z5 = 1
        ElseIf Parametros.ContainsKey(6) = True Then
            z6 = 1
        ElseIf Parametros.ContainsKey(7) = True Then
            z7 = 1
        ElseIf Parametros.ContainsKey(8) = True Then
            z8 = 1
        ElseIf Parametros.ContainsKey(9) = True Then
            z9 = 1
        ElseIf Parametros.ContainsKey(10) = True Then
            z10 = 1
        ElseIf Parametros.ContainsKey(11) = True Then
            z11 = 1
        ElseIf Parametros.ContainsKey(12) = True Then
            z12 = 1
        ElseIf Parametros.ContainsKey(13) = True Then
            z13 = 1
        ElseIf Parametros.ContainsKey(14) = True Then
            z14 = 1
        ElseIf Parametros.ContainsKey(15) = True Then
            z15 = 1
        ElseIf Parametros.ContainsKey(16) = True Then
            z16 = 1
        ElseIf Parametros.ContainsKey(17) = True Then
            z17 = 1
        ElseIf Parametros.ContainsKey(18) = True Then
            z18 = 1
        ElseIf Parametros.ContainsKey(19) = True Then
            z19 = 1
        ElseIf Parametros.ContainsKey(20) = True Then
            z20 = 1
        ElseIf Parametros.ContainsKey(21) = True Then
            z21 = 1
        ElseIf Parametros.ContainsKey(22) = True Then
            z22 = 1
        End If
        Try
            ' # ORDEN DEL DICTIONARY (VALOR DE CADA CAMPO)

            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                              ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                              ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                              ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                              ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPGSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "INSERT INTO ot_inspvisual (idot, idcomponente, z1, z2, z3, z4, z5, z6, z7, z8, z9, z10, z11, z12, z13, z14, z15, z16, z17, z18, z19, z20, z21, z22) VALUES (@OT, @Componente, @z1, @z2, @z3, @z4, @z5, @z6, @z7, @z8, @z9, @z10, @z11, @z12, @z13, @z14, @z15, @z16, @z17, @z18, @z19, @z20, @z21, @z22)"
            CommandPGSQL.Parameters.AddWithValue("@OT", Integer.Parse(OT))
            CommandPGSQL.Parameters.AddWithValue("@Componente", Integer.Parse(idComponente))
            CommandPGSQL.Parameters.AddWithValue("@z1", Integer.Parse(z1))
            CommandPGSQL.Parameters.AddWithValue("@z2", Integer.Parse(z2))
            CommandPGSQL.Parameters.AddWithValue("@z3", Integer.Parse(z3))
            CommandPGSQL.Parameters.AddWithValue("@z4", Integer.Parse(z4))
            CommandPGSQL.Parameters.AddWithValue("@z5", Integer.Parse(z5))
            CommandPGSQL.Parameters.AddWithValue("@z6", Integer.Parse(z6))
            CommandPGSQL.Parameters.AddWithValue("@z7", Integer.Parse(z7))
            CommandPGSQL.Parameters.AddWithValue("@z8", Integer.Parse(z8))
            CommandPGSQL.Parameters.AddWithValue("@z9", Integer.Parse(z9))
            CommandPGSQL.Parameters.AddWithValue("@z10", Integer.Parse(z10))
            CommandPGSQL.Parameters.AddWithValue("@z11", Integer.Parse(z11))
            CommandPGSQL.Parameters.AddWithValue("@z12", Integer.Parse(z12))
            CommandPGSQL.Parameters.AddWithValue("@z13", Integer.Parse(z13))
            CommandPGSQL.Parameters.AddWithValue("@z14", Integer.Parse(z14))
            CommandPGSQL.Parameters.AddWithValue("@z15", Integer.Parse(z15))
            CommandPGSQL.Parameters.AddWithValue("@z16", Integer.Parse(z16))
            CommandPGSQL.Parameters.AddWithValue("@z17", Integer.Parse(z17))
            CommandPGSQL.Parameters.AddWithValue("@z18", Integer.Parse(z18))
            CommandPGSQL.Parameters.AddWithValue("@z19", Integer.Parse(z19))
            CommandPGSQL.Parameters.AddWithValue("@z20", Integer.Parse(z20))
            CommandPGSQL.Parameters.AddWithValue("@z21", Integer.Parse(z21))
            CommandPGSQL.Parameters.AddWithValue("@z22", Integer.Parse(z22))
            CommandPGSQL.ExecuteNonQuery()
            ConexPGSQL.Close()
            Return True
        Catch exex As Exception
            MessageBox.Show("Ocurrió un error al ingresar la inspección visual del componente a la base de datos, contacte al equipo de desarrollo." & _
                            vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & exex.ToString, Application.ProductName & _
                            " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
