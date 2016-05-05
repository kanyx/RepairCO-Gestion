Imports System.Security.Cryptography
Imports Npgsql
Module PGSQL_Loggin
    Private ConnectorPGSQL As NpgsqlConnection
    Private CommandPGSQL As NpgsqlCommand
    Function Login_ExecuteLogin(ByVal Usuario As TextBox, ByVal Password As TextBox) As Boolean
        ' # Funcion encargada de comprobar el nombre de usuario y contraseña.
        ' # Es importante tener en consideracion que las claves tienen que ser comparadas en MD5.
        If Usuario.Text = "" Then
            Usuario.Focus()
            Usuario.BackColor = Color.Red
            Usuario.ForeColor = Color.WhiteSmoke
            Return False
        Else
            Usuario.BackColor = Color.White
            Usuario.ForeColor = Color.DarkOrange
        End If
        If Password.Text = "" Then
            Password.Focus()
            Password.BackColor = Color.Red
            Password.ForeColor = Color.WhiteSmoke
            Return False
        Else
            Password.BackColor = Color.White
            Password.ForeColor = Color.DarkOrange
        End If
        Try
            ConnectorPGSQL = New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                  ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                  ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                  ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                  ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConnectorPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConnectorPGSQL
            CommandPGSQL.CommandText = "SELECT * FROM personal WHERE username=@usuario LIMIT 1"
            CommandPGSQL.Parameters.AddWithValue("@usuario", Usuario.Text)
            Dim rd = CommandPGSQL.ExecuteReader()
            If rd.HasRows = False Then
                Usuario.Focus()
                Usuario.BackColor = Color.Red
                Usuario.ForeColor = Color.WhiteSmoke
                ConnectorPGSQL.Close()
                Return False
            End If
            ' # Comprobacion de contraseña.
            ConnectorPGSQL.Close()
            ConnectorPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConnectorPGSQL
            CommandPGSQL.CommandText = "SELECT * FROM personal WHERE username=@usuario AND password=@password LIMIT 1"
            CommandPGSQL.Parameters.AddWithValue("@usuario", Usuario.Text)
            CommandPGSQL.Parameters.AddWithValue("@password", Login_Md5Encrypt(Password.Text))
            Dim rs = CommandPGSQL.ExecuteReader
            If rs.HasRows = False Then
                Password.Focus()
                Password.BackColor = Color.Red
                Password.ForeColor = Color.WhiteSmoke
                ConnectorPGSQL.Close()
                Return False
            End If
            main_loggin.Hide()
            main_application.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al momento de comprobar el acceso de usuario, compruebe su conexión a internet " & _
                        "si el problema persiste contacte al equipo de desarrollo." & ex.ToString, Application.ProductName, _
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function Login_Md5Encrypt(ByVal Password As String) As String
        Dim PassEncrypt As String = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer
        Try
            bytValue = System.Text.Encoding.UTF8.GetBytes(Password)
            bytHash = md5.ComputeHash(bytValue)
            md5.Clear()
            For i = 0 To bytHash.Length - 1
                PassEncrypt &= bytHash(i).ToString("x").PadLeft(2, "0")
            Next
            Return PassEncrypt
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error con la rutina de Criptografía de la aplicación, muy probablemente no pueda iniciar " & _
                            "sección en la aplicación contacte al equipo de desarrollo.", Application.ProductName, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "error"
        End Try
    End Function
End Module
