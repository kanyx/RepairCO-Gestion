Imports Npgsql
Module PGSQL_MECSTA
    ' # MODULO DE FUNCIONES PGSQL PARA LA INTERFACE DE ESTACIONES MECANICAS DE LA APLICACION.
    Function PGSQL_TACTIL_LOGGIN(ByVal Rut As TextBox, ByVal Pass As TextBox) As Boolean
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
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error mientras se trataba de realizar el inicio de sesión por favor contacte al equipo de desarrollo.", Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
