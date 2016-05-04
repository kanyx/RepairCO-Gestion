Imports Npgsql
Module PGSQL_General
    Dim ConextionString As String = "" ' # Cadena de conexion para PostgreSQL.
    Private ConnectorPostgreSQL As NpgsqlConnection
    Function PGSQL_ProbarConexion(ByVal Server As String, ByVal Port As String, ByVal Username As String, _
                                  ByVal Password As String, ByVal NameBD As String) As Boolean
        Try
            ConextionString = "Server=" & Server & ";Port=" & Port & ";User Id=" & Username & ";Password=" & Password & ";Database=" & NameBD

        Catch ex As Exception
            MessageBox.Show("PostgreSQL: Ocurrio un error en la conexion con el servidor PostgreSQL, el mensaje de error " _
                            & " generado por este problema es el siguiente: " & vbNewLine & ex.ToString)
            Return False
        End Try
    End Function
End Module
