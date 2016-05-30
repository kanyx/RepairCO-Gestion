Imports Npgsql
Module PGSQL_General
    ' # Modulo de funciones generales para realizar comprobaciones e interactuar de forma basica con el servidor PostgreSQL
    Dim ConextionString As String = "" ' # Cadena de conexion para PostgreSQL.
    Private ConnectorPGSQL As NpgsqlConnection
    Private CommandPGSQL As NpgsqlCommand
    Function PGSQL_ProbarConexion(ByVal Server As String, ByVal Port As String, ByVal Username As String, _
                                  ByVal Password As String, ByVal NameBD As String) As Boolean
        Try
            Dim Resultado As ArrayList
            ConnectorPGSQL = New NpgsqlConnection("Host=" & Server & ";Port= " & Port & " ;Username=" & Username & ";Password=" & Password & _
                                                  ";Database=" & NameBD)
            ConnectorPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConnectorPGSQL
            CommandPGSQL.CommandText = "SELECT * FROM personal LIMIT 2"
            Dim rd = CommandPGSQL.ExecuteReader()
            Resultado = New ArrayList
            While rd.Read()
                Resultado.Add(rd.Item(1))
            End While
            ConnectorPGSQL.Close()
            If Resultado.Count <= 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("PostgreSQL: Ocurrio un error en la conexion con el servidor PostgreSQL, el mensaje de error " _
                            & " generado por este problema es el siguiente: " & vbNewLine & ex.ToString)
            Return False
        End Try
    End Function
    Public Function PGSQL_ExisteOT(ByVal NumeroOT As String) As Boolean
        ' # FUNCION QUE COMPRUEBA SI EXISTE UNA ORDEN DE TRABAJO
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                               ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                               ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                               ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                               ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim rd As NpgsqlDataReader
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT notrabajo FROM ordenestrabajo WHERE notrabajo=@not"
            PGSQLCommand.Parameters.AddWithValue("@not", NumeroOT)
            rd = PGSQLCommand.ExecuteReader()
            If rd.HasRows = True Then
                PGSQLConex.Close()
                Return True
            Else
                PGSQLConex.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al comprobar la existencia de la OT en la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                         "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function PGSQL_GetNumeroOrdenNueva() As String
        ' # FUNCION PARA OBTENER EL NUMERO DE ORDEN SIGUENTE
        ' # NUMERO ACTUAL + 1
        Try
            Dim NumeroOT As Integer = 0
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                               ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                               ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                               ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                               ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPGSQL.Open()
            Dim CommPGSQL As New NpgsqlCommand
            CommPGSQL.Connection = ConexPGSQL
            CommPGSQL.CommandType = CommandType.Text
            CommPGSQL.CommandText = "SELECT id, notrabajo FROM ordenestrabajo ORDER by id DESC LIMIT 20"
            Dim dr = CommPGSQL.ExecuteReader
            If dr.HasRows = True Then
                dr.Read()
                NumeroOT = Integer.Parse(dr("notrabajo").ToString) + 1
            Else
                NumeroOT = NumeroOT + 1
            End If
            ConexPGSQL.Close()
            Return NumeroOT.ToString
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error inesperado al tratar de obtener el número de orden de trabajo a crear, no es" & _
                            " recomendable que intente ingresar la orden, contacte al equipo de desarrollo de forma inmediata." & vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & ex.ToString,
                            Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Error.!"
        End Try
    End Function
    Public Sub PGSQL_CargaClientes()
        ' # CARGA AL INICIAR MAINAPPLICATION
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                               ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                               ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                               ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                               ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPGSQL.Open()
            Dim CommPGSQL As New NpgsqlCommand
            CommPGSQL.Connection = ConexPGSQL
            CommPGSQL.CommandType = CommandType.Text
            CommPGSQL.CommandText = "SELECT id, razonsocial FROM clientes"
            Dim dr = CommPGSQL.ExecuteReader
            If dr.HasRows = False Then
                ConexPGSQL.Close()
                Exit Sub
            End If
            _globalClientes = New List(Of KeyValuePair(Of String, String))
            While dr.Read
                _globalClientes.Add(New KeyValuePair(Of String, String)(dr.Item("id"), dr.Item("razonsocial").ToString))
            End While
            ConexPGSQL.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al obtener los clientes desde la base de datos, si el problema persiste contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub PGSQL_CargaTipos()
        ' # CARGA AL INICIAR MAINAPPLICATION
        Try
            ConnectorPGSQL = New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                  ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                  ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                  ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                  ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConnectorPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConnectorPGSQL
            CommandPGSQL.CommandText = "SELECT id, nombre FROM tipos_productos ORDER by nombre ASC"
            Dim rd = CommandPGSQL.ExecuteReader
            If rd.HasRows = False Then
                ConnectorPGSQL.Close()
                Exit Sub
            End If
            _globalTipos = New List(Of KeyValuePair(Of String, String))
            While rd.Read
                _globalTipos.Add(New KeyValuePair(Of String, String)(rd.Item("id"), rd.Item("nombre").ToString))
            End While
            ConnectorPGSQL.Close()
        Catch ex As Exception
            ' # CREAR SISTEMA DE LOGEO DE OPERACIONES EN LOCAL (OUTPUT.LOG)
            ConnectorPGSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub PGSQL_CargaMarcas(ByVal IdTipo As String)
        Try
            ' # CARGA CUANDO SE SELECCION UN TIPO
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPGSQL.Open()
            Dim CommPGSQL As New NpgsqlCommand
            CommPGSQL.Connection = ConexPGSQL
            CommPGSQL.CommandType = CommandType.Text
            CommPGSQL.CommandText = "SELECT id, nombre FROM marcas WHERE idtipo=@tipo ORDER by nombre ASC"
            CommPGSQL.Parameters.AddWithValue("@tipo", Integer.Parse(IdTipo))
            Dim rd = CommPGSQL.ExecuteReader
            If rd.HasRows = False Then
                ConexPGSQL.Close()
                Exit Sub
            End If
            _globalMarcas = New List(Of KeyValuePair(Of String, String))
            While rd.Read
                _globalMarcas.Add(New KeyValuePair(Of String, String)(rd.Item("id"), rd.Item("nombre").ToString))
            End While
            ConexPGSQL.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al cargar la lista de marcas desde la base de datos." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub PGSQL_CargaModelos(ByVal idTipo As String, ByVal idMarca As String)
        ' # CARGA CUANDO SE SELECCIONA UNA MARCA
        ' # OBTIENE LOS VALORES POR TIPO Y MARCA DEL PRODUCTO.
        Try
            Dim ConexPostgreSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                 ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                 ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                 ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                 ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPostgreSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPostgreSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT id, nombre, idmarca, idtipo FROM modelos WHERE idmarca=@marca AND idtipo=@tipo ORDER by nombre ASC"
            CommandPGSQL.Parameters.AddWithValue("@marca", Integer.Parse(idMarca))
            CommandPGSQL.Parameters.AddWithValue("@tipo", Integer.Parse(idTipo))
            Dim dr = CommandPGSQL.ExecuteReader
            If dr.HasRows = False Then
                ConexPostgreSQL.Close()
                Exit Sub
            End If
            _globalModelos = New List(Of KeyValuePair(Of String, String))
            While dr.Read
                _globalModelos.Add(New KeyValuePair(Of String, String)(dr.Item("id"), dr.Item("nombre").ToString))
            End While
            ConexPostgreSQL.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al momento de obtener los modelos desde la base de datos." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Public Function PGSQL_CargaIngReparable(ByVal idCliente As String, Optional ByVal ForComboBox As Boolean = False) As Dictionary(Of String, String)
        ' # OBTENEMOS LA LISTA DE INGENIEROS REPARABLES DESDE LA BASE DE DATOS.
        Dim ValueReturn As New Dictionary(Of String, String)()
        Try
            Dim ConexPostgreSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPostgreSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPostgreSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT id, idcliente, nombre FROM ingrepar WHERE idcliente=@clienteid"
            CommandPGSQL.Parameters.AddWithValue("@clienteid", Integer.Parse(idCliente))
            Dim dr As NpgsqlDataReader = CommandPGSQL.ExecuteReader
            If ForComboBox = True Then
                ValueReturn.Add("", "SELECCIONE ING. REPARABLE")
            End If
            If dr.HasRows = False Then
                ValueReturn.Add("0", "SIN ING. REPARABLE")
            End If
            While dr.Read
                ValueReturn.Add(dr(0).ToString, dr(2).ToString.ToUpper)
            End While
            ConexPostgreSQL.Close()
            Return ValueReturn
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al momento de cargar la lista de ing. reparables desde la base de datos." & _
                            vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & ex.ToString, _
                            Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.OK)
            ValueReturn.Add("", "ERROR....")
            Return ValueReturn
        End Try
    End Function
    Public Sub PGSQL_CargaEstados()
        ' # CARGA AL INICIAR MAINAPPLICATION
    End Sub
    Public Sub PGSQL_CargaPais()
        ' # CARGA SOLO ON-DEMAND EN ALGUNOS FORMULARIOS (POR EJEMPLO AÑADIR MARCA).
        Try
            Dim ConexPostgreSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                  ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                  ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                  ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                  ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPostgreSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPostgreSQL
            CommandPGSQL.CommandText = "SELECT id, nombre FROM paises"
            Dim dr = CommandPGSQL.ExecuteReader
            If dr.HasRows = False Then
                ConexPostgreSQL.Close()
                Exit Sub
            End If
            _globalPaises = New List(Of KeyValuePair(Of String, String))
            While dr.Read
                _globalPaises.Add(New KeyValuePair(Of String, String)(dr.Item("id"), dr.Item("nombre").ToString))
            End While
            ConexPostgreSQL.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al momento de cargar la lista de países desde la base de datos." & _
                            vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & ex.ToString, _
                            Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.OK)
        End Try
    End Sub
    Public Function PGSQL_CargaComentariosOT(ByVal NumeroOT As String) As String
        ' # CARGA LOS COMENTARIOS DE LA ORDEN DE TRABAJO DESDE LA BASE DE DATOS.
        Dim Comentario As String = ""
        Try
            Dim ConexPostgreSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPostgreSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPostgreSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT id, iduser, comentario, idot FROM otcomentarios WHERE idot=@numerot"
            CommandPGSQL.Parameters.AddWithValue("@numerot", Integer.Parse(NumeroOT))
            Dim rd = CommandPGSQL.ExecuteReader()
            If rd.HasRows = False Then
                ConexPostgreSQL.Close()
                Return ""
            End If
            rd.Read()
            Comentario = rd(2).ToString
            ConexPostgreSQL.Close()
            Return Comentario
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al tratar de cargar los comentarios desde la base de datos, por favor intente nuevamente. Si el problema persiste contacte al equipo de desarrollo." & _
                            vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "ERROR...."
        End Try
    End Function
    Public Function PGSQL_CargaImagenesOT(ByVal NumeroOrden As String, ByVal MaxImages As Integer) As ArrayList
        ' # CARGA LAS IMAGENES DE LA ORDEN DESDE LA BASE DE DATOS.
        Dim Imagenes As New ArrayList
        Try
            Dim ConexPostgreSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                 ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                 ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                 ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                 ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPostgreSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPostgreSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT id, nimagen, idot FROM otimages WHERE idot=@norden LIMIT @limite"
            CommandPGSQL.Parameters.AddWithValue("@norden", Integer.Parse(NumeroOrden))
            CommandPGSQL.Parameters.AddWithValue("@limite", MaxImages)
            Dim rd = CommandPGSQL.ExecuteReader()
            If rd.HasRows = False Then
                ConexPostgreSQL.Close()
                Return Imagenes
            End If
            While rd.Read
                Imagenes.Add(rd(1).ToString)
            End While
            ConexPostgreSQL.Close()
            Return Imagenes
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al tratar de cargar las imágenes de la orden de trabajo, por favor vuelta a inténtalo, si el problema persiste contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Imagenes.Add("ERROR!")
            Return Imagenes
        End Try
    End Function
    Public Function PGSQL_CargaOT(ByVal NumeroOT As String) As ArrayList
        ' ########################################################################
        ' # CARGAMOS LA ORDEN DE TRABAJO DESDE LA BASE DE DATOS.
        ' # LISTA DE VALORES:
        ' # (0) -> Numero de Orden de Trabajo.
        ' # (1) -> Numero guia de despacho.
        ' # (2) -> Identificador unico de cliente.
        ' # (3) -> Identificador del tipo de producto.
        ' # (4) -> Identificador de la marca del producto.
        ' # (5) -> Identificador del modelo del producto.
        ' # (6) -> Numero de serie equipo.
        ' # (7) -> Prioridad de la orden.
        ' # (8) -> Numero contrato (cliente de la orden de trabajo).
        ' # (9) -> Fecha de ingreso de la orden de trabajo.
        ' # (10) -> Numero de serie de fabricante.
        ' # (11) -> Fecha de cierre de la orden de trabajo.
        ' # (12) -> Identificador de la orden del estado de la orden.
        ' # (13) -> Tipo de orden de trabajo.
        ' # (14) -> Numero de orden de compra.
        ' # (15) -> Numero de agendamiento.
        ' # (16) -> Identificador del responsable del ingreso.
        ' # (17) -> Identificador del equipo / cliente (TAG).
        ' # (18) -> Ingeniero reparable.
        ' ########################################################################
        Dim ReturnArray As New ArrayList
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
            CommandPGSQL.CommandText = "SELECT notrabajo, nguiadespacho, idcliente, idtipo, idmarca, idmodelo, nserie, prioridad, numerocontrato, fecha_ingreso, nseriefabricante, fecha_cierre, idestado, tipo, noc, nagendamiento, idrespingreso, tag, ingrepaid FROM ordenestrabajo WHERE notrabajo=@NumeroOrden LIMIT 1"
            CommandPGSQL.Parameters.AddWithValue("@NumeroOrden", NumeroOT)
            rd = CommandPGSQL.ExecuteReader
            If rd.HasRows = False Then
                ReturnArray.Add("")
                ConexPGSQL.Close()
                Return ReturnArray
            End If
            rd.Read()
            ReturnArray.Add(rd(0).ToString)
            ReturnArray.Add(rd(1).ToString)
            ReturnArray.Add(rd(2).ToString)
            ReturnArray.Add(rd(3).ToString)
            ReturnArray.Add(rd(4).ToString)
            ReturnArray.Add(rd(5).ToString)
            ReturnArray.Add(rd(6).ToString)
            ReturnArray.Add(rd(7).ToString)
            ReturnArray.Add(rd(8).ToString)
            ReturnArray.Add(rd(9).ToString)
            ReturnArray.Add(rd(10).ToString)
            ReturnArray.Add(rd(11).ToString)
            ReturnArray.Add(rd(12).ToString)
            ReturnArray.Add(rd(13).ToString)
            ReturnArray.Add(rd(14).ToString)
            ReturnArray.Add(rd(15).ToString)
            ReturnArray.Add(rd(16).ToString)
            ReturnArray.Add(rd(17).ToString)
            ReturnArray.Add(rd(18).ToString)
            ConexPGSQL.Close()
            Return ReturnArray
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error cargar los datos de la orden de trabajo desde la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("ERROR")
            Return ReturnArray
        End Try
    End Function
    Public Function PGSQL_GETPERSONALDATES(ByVal idPersona As String) As ArrayList
        ' #####################################################
        ' # FUNCION PARA OBTENER DATOS DEL PERSONAL
        ' # VALORES DEL ARRAYLIST:
        ' # (0)  : Identificador unico.[ID]
        ' # (1)  : Nombres.
        ' # (2)  : Apellido paterno.
        ' # (3)  : Apellido materno.
        ' # (4)  : Rut. (DNI/NIF)
        ' # (5)  : ID Cargo.
        ' # (6)  : Direccion.
        ' # (7)  : ID tabla de permisos usuario.
        ' # (8)  : Imagen de perfil del usuario.
        ' # (9) : Nombre de usuario.
        ' # (10) : Contraseña (MD5) String.
        ' #####################################################
        Dim ReturnArray As New ArrayList
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                 ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                 ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                 ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                 ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLCommand As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, nombres, apellido_p, apellido_m, rut, idcargo, direccion, idpermiso, imagenperfil, username, password FROM personal WHERE id=@idpersona LIMIT 1"
            PGSQLCommand.Parameters.AddWithValue("@idpersona", Integer.Parse(idPersona.ToString))
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                ReturnArray.Add("")
                PGSQLConex.Close()
                Return ReturnArray
            End If
            rd.Read()
            ReturnArray.Add(rd(0).ToString)
            ReturnArray.Add(rd(1).ToString)
            ReturnArray.Add(rd(2).ToString)
            ReturnArray.Add(rd(3).ToString)
            ReturnArray.Add(rd(4).ToString)
            ReturnArray.Add(rd(5).ToString)
            ReturnArray.Add(rd(6).ToString)
            ReturnArray.Add(rd(7).ToString)
            ReturnArray.Add(rd(8).ToString)
            ReturnArray.Add(rd(9).ToString)
            ReturnArray.Add(rd(10).ToString)
            PGSQLConex.Close()
            Return ReturnArray
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al intentar obtener datos del personal desde la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("ERROR..")
            Return ReturnArray
        End Try
    End Function
    Public Function PGSQL_GETCLIENTINFO(ByVal idCliente As String) As ArrayList
        ' ########################################################
        ' # FUNCION PARA OBTENER INFORMACION DEL CLIENTE
        ' # DESC: ESTA FUNCION OBTIENE TODOS LOS PARAMETROS DE
        ' #       LA TABLA CLIENTES DE LA BASE DE DATOS.
        ' # DESC. PARAMETROS:
        ' # (0)  : Identificador del cliente.
        ' # (1)  : Razon social.
        ' # (2)  : Nombre contacto.
        ' # (3)  : Apellidos contacto.
        ' # (4)  : Fono contacto.
        ' # (5)  : M@il contacto.
        ' # (6)  : Fono empresa.
        ' # (7)  : M@il empresa.
        ' # (8)  : Direccion empresa.
        ' # (9)  : Identificador unico ciudad.
        ' # (10) : Apellido Materno cotacto.
        ' # (11) : Giro.
        ' # (12) : Rut.
        ' ########################################################
        Dim ReturnArray As New ArrayList
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                 ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                 ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                 ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                 ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLCommand As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, razonsocial, ncontacto, apcontacto, fcontacto, mcontacto, fempresa, mempresa, dempresa, idciudad, amcontacto, giroempresa, rut FROM clientes WHERE id=@idcliente LIMIT 1"
            PGSQLCommand.Parameters.AddWithValue("@idcliente", Integer.Parse(idCliente))
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                ReturnArray.Add("")
                PGSQLConex.Close()
                Return ReturnArray
            End If
            rd.Read()
            ReturnArray.Add(rd(0).ToString)
            ReturnArray.Add(rd(1).ToString)
            ReturnArray.Add(rd(2).ToString)
            ReturnArray.Add(rd(3).ToString)
            ReturnArray.Add(rd(4).ToString)
            ReturnArray.Add(rd(5).ToString)
            ReturnArray.Add(rd(6).ToString)
            ReturnArray.Add(rd(7).ToString)
            ReturnArray.Add(rd(8).ToString)
            ReturnArray.Add(rd(9).ToString)
            ReturnArray.Add(rd(10).ToString)
            ReturnArray.Add(rd(11).ToString)
            ReturnArray.Add(rd(12).ToString)
            PGSQLConex.Close()
            Return ReturnArray
        Catch exe As Exception
            MessageBox.Show("Ocurrió un error al cargar la información del cliente desde la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("ERROR...")
            Return ReturnArray
        End Try
    End Function
    Public Function PGSQL_GETTIPOINFO(ByVal idTipo As String) As ArrayList
        ' ############################################################
        ' # FUNCION QUE OBTIENE INFORMACION DE LOS TIPOS DESDE LA BD
        ' # DESC. VALORES ARRAY:
        ' # (0) : Identificador unico del tipo.
        ' # (1) : Nombre.
        ' # (2) : Comentario.
        ' # (3) : Identificador del usuario que ingreso el tipo.
        ' #############################################################
        Dim ReturnArray As New ArrayList
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLCommand As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, nombre, comentario, iduseradd FROM tipos_productos WHERE id=@idproducto LIMIT 1"
            PGSQLCommand.Parameters.AddWithValue("@idproducto", Integer.Parse(idTipo))
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                ReturnArray.Add("")
                PGSQLConex.Close()
                Return ReturnArray
            End If
            rd.Read()
            ReturnArray.Add(rd(0).ToString)
            ReturnArray.Add(rd(1).ToString)
            ReturnArray.Add(rd(2).ToString)
            ReturnArray.Add(rd(3).ToString)
            PGSQLConex.Close()
            Return ReturnArray
        Catch exe As Exception
            MessageBox.Show("Ocurrió un error al cargar la información del tipo de producto desde la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("ERROR..")
            Return ReturnArray
        End Try
    End Function
    Public Function PGSQL_GETMARCAINFO(ByVal idMarca As String) As ArrayList
        ' ###########################################################
        ' # FUNCION QUE OBTIENE LA INFORMACION ACERCA DE LA MARCA
        ' # DESC. VALORES ARRAY:
        ' # (0) : Identificador unico.
        ' # (1) : Nombre.
        ' # (2) : Identificador del pais.
        ' # (3) : Identificador del proovedor.
        ' # (4) : Identificador del usuario que agrego la marca.
        ' ###########################################################
        Dim ReturnArray As New ArrayList
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                               ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                               ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                               ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                               ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLCommand As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, nombre, idtipo, idpais, idproovedor, iduseradd FROM marcas WHERE id=@idMarca LIMIT 1"
            PGSQLCommand.Parameters.AddWithValue("@idMarca", Integer.Parse(idMarca))
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                ReturnArray.Add("")
                PGSQLConex.Close()
                Return ReturnArray
            End If
            rd.Read()
            ReturnArray.Add(rd(0).ToString)
            ReturnArray.Add(rd(1).ToString)
            ReturnArray.Add(rd(2).ToString)
            ReturnArray.Add(rd(3).ToString)
            ReturnArray.Add(rd(4).ToString)
            PGSQLConex.Close()
            Return ReturnArray
        Catch exe As Exception
            MessageBox.Show("Ocurrió un error al cargar la información de la marca del producto desde la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                           "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("ERROR..")
            Return ReturnArray
        End Try
    End Function
    Public Function PGSQL_GETMODELOINFO(ByVal idModelo As String) As ArrayList
        ' ########################################################
        ' # FUNCION QUE OBTIENE INFORMACION SOBRE UN MODELO
        ' # DESC. DE VALORES DEL ARRAY.
        ' # (0) : Identificador unico.
        ' # (1) : Nombre.
        ' # (2) : Identificador de la marca.
        ' # (3) : Identificador del tipo.
        ' # (4) : Identificador del usuario que agrego el registro.
        ' #########################################################
        Dim ReturnArray As New ArrayList
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                               ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                               ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                               ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                               ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLCommand As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, nombre, idmarca, idtipo, iduseradd FROM modelos WHERE id=@idModelo LIMIT 1"
            PGSQLCommand.Parameters.AddWithValue("@idModelo", Integer.Parse(idModelo))
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                ReturnArray.Add("")
                PGSQLConex.Close()
                Return ReturnArray
            End If
            rd.Read()
            ReturnArray.Add(rd(0).ToString)
            ReturnArray.Add(rd(1).ToString)
            ReturnArray.Add(rd(2).ToString)
            ReturnArray.Add(rd(3).ToString)
            ReturnArray.Add(rd(4).ToString)
            PGSQLConex.Close()
            Return ReturnArray
        Catch exe As Exception
            MessageBox.Show("Ocurrió un error al cargar la información del modelo del producto desde la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                           "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("ERROR..")
            Return ReturnArray
        End Try
    End Function
    Public Function PGSQL_GETINGREPAINFO(ByVal idIngeniero As String) As ArrayList
        ' #######################################################
        ' # FUNCION QYE OBTIENE LOS DATOS DEL ING. REPARABLE
        ' # DESC. VALORES DEL ARRAY.
        ' # (0) : Identificador unico.
        ' # (1) : Nombre.
        ' # (2) : Identificador del cliente.
        ' #######################################################
        Dim ReturnArray As New ArrayList
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                              ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                              ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                              ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                              ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLCommand As NpgsqlCommand
            Dim rd As NpgsqlDataReader
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, nombre, idcliente FROM ingrepar WHERE id=@idING LIMIT 1"
            PGSQLCommand.Parameters.AddWithValue("@idING", Integer.Parse(idIngeniero))
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                ReturnArray.Add("")
                PGSQLConex.Close()
                Return ReturnArray
            End If
            rd.Read()
            ReturnArray.Add(rd(0).ToString)
            ReturnArray.Add(rd(1).ToString)
            ReturnArray.Add(rd(2).ToString)
            PGSQLConex.Close()
            Return ReturnArray
        Catch exe As Exception
            MessageBox.Show("Ocurrió un error al cargar la información del ingeniero reparable desde la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                          "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("ERROR..")
            Return ReturnArray
        End Try
    End Function
    Public Sub PGSQL_CargarOTDataView(ByVal DTGW As DataGridView, Optional ByVal Filtros As Boolean = False)
        Try
            ' # MOSTRAR LA INFORMACION EN EL DATAGRID.
            ' # DTGW : CONTROL DATAGRID QUE MUESTRA EL RECUADRO PAA CARGAR LA INFORMACION.
            Dim PGSQLConex As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                 ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                 ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                 ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                 ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim PGSQLrd As NpgsqlDataReader
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            If Filtros = False Then
                PGSQLCommand.CommandText = "SELECT notrabajo, fecha_ingreso, razonsocial, nombretipo, nombremarca, nombremodelo, nestado FROM vista_otreporte ORDER BY notrabajo DESC"
            End If
            PGSQLrd = PGSQLCommand.ExecuteReader
            PGSQLDataTable.Load(PGSQLrd)
            DTGW.DataSource = PGSQLDataTable
            PGSQLConex.Close()
        Catch ex As Exception
            ' # EN CASO DE ERROR AL GUARDAR LA INFORMACION.
            MessageBox.Show("Ocurrió un error al cargar las ordenes de trabajo desde la base de datos, por favor contacte al equipo de desarrollo.", _
                            Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Sub PGSQL_GETCOMENTARIOSOT(ByVal NumeroOrden As String, ByVal DGW As DataGridView)
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim rd As NpgsqlDataReader
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, fecha, hora, comentario, idot, concat(nombres, ' ', apellido_p, ' ', apellido_m) AS USUARIO FROM view_comentarios WHERE idot=@OT ORDER BY ID DESC"
            PGSQLCommand.Parameters.AddWithValue("@OT", Integer.Parse(NumeroOrden))
            rd = PGSQLCommand.ExecuteReader
            PGSQLDataTable.Load(rd)
            DGW.DataSource = PGSQLDataTable
            ' # MODIFICACION DATAGRID
            DGW.Columns("idot").Visible = False
            DGW.Columns("id").HeaderText = "ID"
            DGW.Columns("fecha").HeaderText = "FECHA"
            DGW.Columns("hora").HeaderText = "HORA"
            DGW.Columns("comentario").HeaderText = "COMENTARIO"
            DGW.Columns("usuario").HeaderText = "USUARIO"
            PGSQLConex.Close()
        Catch exe As Exception
            MessageBox.Show("Ocurrió un error al cargar la información del ingeniero reparable desde la base de datos, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                         "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
