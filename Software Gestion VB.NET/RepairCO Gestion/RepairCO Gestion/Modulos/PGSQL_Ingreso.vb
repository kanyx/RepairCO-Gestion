﻿Imports Npgsql
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
                                        ByVal ModeloProducto As Integer, ByVal NumeroOrdenTrabajo As Integer) As Boolean
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
            CommandPGSQL.CommandText = "INSERT INTO ordenestrabajo (not, nguiadespacho, idcliente, idtipo, idmarca, idmodelo, idrespingreso, nserie, prioridad, numerocontrato, fecha_ingreso, nseriefabricante, idestado, tipo, noc) VALUES (@notrabajo, @guiadespacho, @idcliente, @idtipo, @idmarca, @idmodelo, @iduseringreso, @nserie, @prioridad, @ncontrato, @fechaingreso, @nseriefab, @estado, @tipot, @noc)"
            CommandPGSQL.Parameters.AddWithValue("@notrabajo", NumeroOrdenTrabajo)
            CommandPGSQL.Parameters.AddWithValue("@guiadespacho", GuiaDespacho)
            CommandPGSQL.Parameters.AddWithValue("@idcliente", Cliente)
            CommandPGSQL.Parameters.AddWithValue("@idtipo", TipoProducto)
            CommandPGSQL.Parameters.AddWithValue("@idmarca", MarcaProducto)
            CommandPGSQL.Parameters.AddWithValue("@idmodelo", ModeloProducto)
            CommandPGSQL.Parameters.AddWithValue("@iduseringreso", _globalClientes(0).ToString)
            CommandPGSQL.Parameters.AddWithValue("@nserie", NumeroSerie)
            CommandPGSQL.Parameters.AddWithValue("@prioridad", Prioridad)
            CommandPGSQL.Parameters.AddWithValue("@ncontrato", NumeroContrato)
            CommandPGSQL.Parameters.AddWithValue("@fechaingreso", FechaIngreso)
            CommandPGSQL.Parameters.AddWithValue("@nseriefab", NumeroSerieFabrica)
            CommandPGSQL.Parameters.AddWithValue("@estado", 1)
            CommandPGSQL.Parameters.AddWithValue("@tipot", TipoOT)
            CommandPGSQL.Parameters.AddWithValue("@noc", nOrdenCompra)
            CommandPGSQL.ExecuteNonQuery()
            ConexPGSQL.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al ingresar la orden de trabajo en la base de datos, por favor contacte al equipo de desarrollo de la aplicación." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
