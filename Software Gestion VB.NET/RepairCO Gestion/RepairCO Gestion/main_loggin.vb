Imports GestorXML
Public Class main_loggin
    Private LectorXML As RepairCoXml
    Public ParametrosConfiguracion As ArrayList
    Private Sub main_loggin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class
