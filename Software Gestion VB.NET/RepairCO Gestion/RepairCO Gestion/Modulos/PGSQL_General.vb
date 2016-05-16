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
        Catch ex As Exception
            ' # EN CASO DE ERROR AL GUARDAR LA INFORMACION.
            MessageBox.Show("Ocurrió un error al cargar las ordenes de trabajo desde la base de datos, por favor contacte al equipo de desarrollo.", _
                            Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
End Module
