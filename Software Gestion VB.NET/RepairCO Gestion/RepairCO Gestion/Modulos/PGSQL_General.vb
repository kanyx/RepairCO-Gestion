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
            ConnectorPGSQL = New NpgsqlConnection("Host=" & Server & ";Username=" & Username & ";Password=" & Password & _
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
End Module
