Imports Npgsql
Module PGSQL_MECSTA
    ' # MODULO DE FUNCIONES PGSQL PARA LA INTERFACE DE ESTACIONES MECANICAS DE LA APLICACION.
    Function PGSQL_TACTIL_LOGGIN(ByVal Rut As TextBox, ByVal Pass As TextBox, ByVal Station As ComboBox) As Boolean
        ' # FUNCION QUE REALIZA EL LOGEO DEL USUARIO MECANICO EN LA ESTACION.
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
                Rut.BackColor = ColorTranslator.FromHtml("#ba0000")
                Rut.ForeColor = ColorTranslator.FromHtml("#ffffff")
                ConexPGSQL.Close()
                Return False
            End If
            rd.Read()
            If rd(2).ToString = Login_Md5Encrypt(Pass.Text) Then
                mec_dashboard.MecUserID = rd(0).ToString
                mec_dashboard.MecStation = Station.Text
                mec_dashboard.MecStationID = Station.SelectedValue
                ConexPGSQL.Close()
                Return True
            Else
                Pass.BackColor = ColorTranslator.FromHtml("#ba0000")
                Pass.ForeColor = ColorTranslator.FromHtml("#ffffff")
                ConexPGSQL.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error mientras se trataba de realizar el inicio de sesión por favor contacte al equipo de desarrollo.", Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function PGSQL_TACTIL_GETSTATIONS() As Dictionary(Of String, String)
        ' ########################################################
        ' # FUNCION QUE OBTENE LA LISTA DE ESTACIONES DE TRABAJO.
        ' # MODO DE VOLCADO: var(Key)(Value)
        ' ########################################################
        Dim ReturnArray As New Dictionary(Of String, String)
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
            CommandPGSQL.CommandText = "SELECT id, nombre FROM estacionesmecanicas ORDER BY nombre ASC"
            rd = CommandPGSQL.ExecuteReader
            If rd.HasRows = False Then
                ReturnArray.Add("", "SIN ESTACIONES.")
                ConexPGSQL.Close()
                Return ReturnArray
            End If
            ReturnArray.Add("", "ESCOJA.")
            While rd.Read
                ReturnArray.Add(rd(0).ToString, rd(1).ToString.ToUpper)
            End While
            ConexPGSQL.Close()
            Return ReturnArray
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al obtener la lista de estaciones desde la base de datos.", Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ReturnArray.Add("", "")
            Return ReturnArray
        End Try
    End Function
    Public Sub PGSQL_TACTIL_LOADOT(ByVal idEstacion As String)
        ' # CARGA LAS ORDENES DE TRABAJO.
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
            CommandPGSQL.CommandText = "notrabajo, nombretipo, nombremarca, nombremodelo, idmechanicstation FROM vista_lista_mechstation WHERE idmechanicstation=@NumStation"
            CommandPGSQL.Parameters.AddWithValue("@NumStation", Integer.Parse(idEstacion))
        Catch exe As Exception
            Exit Sub
        End Try
    End Sub
End Module
