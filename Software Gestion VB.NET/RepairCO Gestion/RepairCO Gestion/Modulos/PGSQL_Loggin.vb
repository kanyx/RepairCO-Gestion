Imports System.Security.Cryptography
Imports Npgsql
Module PGSQL_Loggin
    Private Login_ConnectorPGSQL As NpgsqlConnection
    Private Login_CommandPGSQL As NpgsqlCommand
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
            Login_ConnectorPGSQL = New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                  ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                  ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                  ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                  ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Login_ConnectorPGSQL.Open()
            Login_CommandPGSQL = New NpgsqlCommand
            Login_CommandPGSQL.Connection = Login_ConnectorPGSQL
            Login_CommandPGSQL.CommandText = "SELECT * FROM personal WHERE username=@usuario LIMIT 1"
            Login_CommandPGSQL.Parameters.AddWithValue("@usuario", Usuario.Text)
            Dim rd = Login_CommandPGSQL.ExecuteReader()
            If rd.HasRows = False Then
                Usuario.Focus()
                Usuario.BackColor = Color.Red
                Usuario.ForeColor = Color.WhiteSmoke
                Login_ConnectorPGSQL.Close()
                Return False
            End If
            ' # Comprobacion de contraseña.
            Login_ConnectorPGSQL.Close()
            Login_ConnectorPGSQL.Open()
            Login_CommandPGSQL = New NpgsqlCommand
            Login_CommandPGSQL.Connection = Login_ConnectorPGSQL
            Login_CommandPGSQL.CommandText = "SELECT * FROM personal WHERE username=@usuario AND password=@password LIMIT 1"
            Login_CommandPGSQL.Parameters.AddWithValue("@usuario", Usuario.Text)
            Login_CommandPGSQL.Parameters.AddWithValue("@password", Login_Md5Encrypt(Password.Text))
            Dim rs = Login_CommandPGSQL.ExecuteReader
            If rs.HasRows = False Then
                Password.Focus()
                Password.BackColor = Color.Red
                Password.ForeColor = Color.WhiteSmoke
                Login_ConnectorPGSQL.Close()
                Return False
            End If
            main_loggin.Hide()
            main_application.Show()
            Login_ConnectorPGSQL.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al momento de comprobar el acceso de usuario, compruebe su conexión a internet " & _
                        "si el problema persiste contacte al equipo de desarrollo." & ex.ToString, Application.ProductName, _
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Sub Login_CargarUserData(ByVal UserName As String)
        ' # FUNCION QUE CARGA LOS DATOS DEL USUARIO DESDE LA BASE DE DATOS.
        ' # [DESCRIPCION GENERAL DE INDICE DEL ARREGLO]
        ' # _globalUserData(0) : ID (Identificador unico usuario)
        ' # _globalUserData(1) : Nombres.
        ' # _globalUserData(2) : Apellido paterno.
        ' # _globalUserData(3) : Apellido materno.
        ' # _globalUserData(4) : RUT.
        ' # _globalUserData(5) : Identificador del cargo.
        ' # _globalUserData(6) : Direccion.
        ' # _globalUserData(7) : Identificador de la tabla de permisos.
        ' # _globalUserData(8) : Imagen de perfil de la aplicacion.
        ' # _globalUserData(9) : Nombre de usuario.
        ' # _globalUserData(10) : Contraseña.
        Try
            Login_ConnectorPGSQL = New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                  ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                  ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                  ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                  ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Login_ConnectorPGSQL.Open()
            Login_CommandPGSQL = New NpgsqlCommand
            Login_CommandPGSQL.Connection = Login_ConnectorPGSQL
            Login_CommandPGSQL.CommandText = "SELECT * FROM personal WHERE username=@usuario LIMIT 1"
            Login_CommandPGSQL.Parameters.AddWithValue("@usuario", UserName)
            Dim rd = Login_CommandPGSQL.ExecuteReader
            While rd.Read
            End While
            Login_ConnectorPGSQL.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error inesperado al obtener los datos del usuario, por favor reinicie la aplicación" & _
                            " y vuelva intentarlo, si el problema persiste contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine, Application.ProductName & " - " & _
                            Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
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
