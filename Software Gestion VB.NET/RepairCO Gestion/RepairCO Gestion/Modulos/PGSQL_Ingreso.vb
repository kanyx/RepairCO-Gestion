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
End Module
