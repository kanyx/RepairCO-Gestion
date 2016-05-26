Imports GestorXML
Public Class main_loggin
    Private LectorXML As RepairCoXml
    Public ParametrosConfiguracion As ArrayList
    Public VersionPrefix As String = "Trunk"
    Public MechanicStation As String = ""
    Private Sub main_loggin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CleanTempFiles()
        ' # --> CODIGO PARA GENERAR PRUEBAS
        'REPORTES_GENERAOT("1000000")
        'Dim TestImage As New ArrayList
        ' TestImage.Add("C:\Users\Public\Pictures\Sample Pictures\Crisantemo.jpg")
        'IMAGE_SAVEOT(TestImage, "1000")
        ' # FIN CODIGO GENERADOR DE PRUEBAS <--
        ' # ACCESO A LA CARPETA EN RED DE USO ESPECIAL DEL PROGRAMA.
        '("Net Use \\192.168.0.10\Servidor\Desarrollo\ /user:software gestion2016", AppWinStyle.Hide, True, 10000) (COD. SOMETIDO A INVESTIGACION POSIBLE BUG 15/05/2016)
        ' # Proceso de carga del formulario principal.
        Me.loggin_logo.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\logo.jpg")
        Me.loggin_username_txt.ForeColor = Color.DarkOrange
        Me.loggin_password_txt.ForeColor = Color.DarkOrange
        ' # Sentencias de texto de ayuda.
        Me.loggin_help_tip.SetToolTip(loggin_username_txt, "Por favor ingrese su nombre de usuario!")
        Me.loggin_help_tip.SetToolTip(loggin_password_txt, "Por favor ingrese su contraseña!")
        Me.loggin_help_tip.SetToolTip(loggin_enter_btn, "Ingresar al sistema de gestion!")
        Me.loggin_help_tip.SetToolTip(loggin_config_btn, "Configuracion del sistema!")
        LectorXML = New RepairCoXml(Application.StartupPath & "/Data/configuracion.xml")
        ParametrosConfiguracion = New ArrayList()
        ParametrosConfiguracion = LectorXML.LeerDocumentoConfiguration(True)
        'MsgBox(ParametrosConfiguracion(5).ToString)
        ' # Prueba de la conexion con el servidor postgresql
        If PGSQL_ProbarConexion(ParametrosConfiguracion(0).ToString, ParametrosConfiguracion(1).ToString, _
                                ParametrosConfiguracion(2).ToString, ParametrosConfiguracion(3).ToString, _
                                ParametrosConfiguracion(4).ToString) = False Then
            MessageBox.Show("Error al conectar al servidor PostgreSQL (" & ParametrosConfiguracion(0) & _
                            "), por favor verifique su conexión a internet si el problema persiste contacte" & _
                            " al equipo de desarrollo para resolver esta situación.", Application.ProductName, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.loggin_enter_btn.Enabled = False
        Else
            Me.loggin_enter_btn.Enabled = True
        End If
        ' # LLAMAMOS PARAMETROS EXTERNOS DE LA APLICACION.
        ' # PARAM: MECHANICSTATION
        If My.Application.CommandLineArgs.Count > 0 Then
            MechanicStation = My.Application.CommandLineArgs(0)
        End If
    End Sub
    Private Sub loggin_enter_btn_MouseMove(sender As Object, e As MouseEventArgs) Handles loggin_enter_btn.MouseMove
        Me.loggin_enter_btn.Cursor = Cursors.Hand
    End Sub
    Private Sub loggin_config_btn_MouseMove(sender As Object, e As MouseEventArgs) Handles loggin_config_btn.MouseMove
        Me.loggin_config_btn.Cursor = Cursors.Hand
    End Sub
    Private Sub loggin_config_btn_Click(sender As Object, e As EventArgs) Handles loggin_config_btn.Click
        main_configuration.Show()
        Me.Hide()
    End Sub
    Private Sub loggin_enter_btn_Click(sender As Object, e As EventArgs) Handles loggin_enter_btn.Click
        Login_ExecuteLogin(loggin_username_txt, loggin_password_txt)
    End Sub
    Private Sub main_loggin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If MechanicStation = "mechanicstation" Then
            ' CARGAMOS INTERFACE PARA ESTACION MECANICA.
            Me.Hide()
            Dim frm_mecloggin As New mec_loggin
            'frm_mecloggin.Show()
            mec_dashboard.Show()
        End If
    End Sub
End Class
