Public Class main_configuration
    Private Sub main_configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # Carga de parametros a los controles.
        Me.configuration_lbl_appversion.Text = "Version: " & Application.ProductVersion
        Me.configuration_pic_logo.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/postgresql-logo.png")
        ' #  Carga de textos de ayuda del formulario.
        Me.configuration_tooltip.SetToolTip(Me.configuration_txt_dbserver, "Servidor donde está alojada la base de datos PostgreSQL.")
        Me.configuration_tooltip.SetToolTip(Me.configuration_txt_dbport, "Puerto de escucha del servidor PostgreSQL.")
        Me.configuration_tooltip.SetToolTip(Me.configuration_txt_dbuser, "Nombre de usuario para la base de datos PostgreSQL.")
        Me.configuration_tooltip.SetToolTip(Me.configuration_txt_dbpass, "Contraseña para el usuario de la base de datos PostgreSQL.")
        Me.configuration_tooltip.SetToolTip(Me.configuration_txt_dbname, "Nombre de la base de datos PostgreSQL de la aplicación.")
        Me.configuration_tooltip.SetToolTip(Me.configuration_btn_testconex, "Probar los parámetros de conexión con el servidor PostgreSQL.")
        Me.configuration_tooltip.SetToolTip(Me.configuration_btn_cancel, "Cancelar el cambio de configuración de la aplicación.")
        Me.configuration_tooltip.SetToolTip(Me.configuration_btn_save, "Guardar los cambios realizados a la aplicación.")
    End Sub
    Private Sub configuration_btn_testconex_Click(sender As Object, e As EventArgs) Handles configuration_btn_testconex.Click
        If MessageBox.Show("Recuerde! Debe tener conexión a internet o intranet para poder realizar la prueba de conexión de lo contrario esta saldrá incorrecta. ¿Desea continuar con la prueba de conectividad?.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        End If
    End Sub
    Private Sub configuration_btn_cancel_Click(sender As Object, e As EventArgs) Handles configuration_btn_cancel.Click
        If MessageBox.Show("¿Seguro que desea salir de la configuracion de " & Application.ProductName & "?", _
                           Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            main_loggin.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub main_configuration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Seguro que desea salir de la configuracion de " & Application.ProductName & "?", _
                           Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            main_loggin.Show()
        End If
    End Sub
End Class