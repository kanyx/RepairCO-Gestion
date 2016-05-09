Imports System.Windows.Forms

Public Class main_application
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
    Private Sub mainapp_help_aboutme_Click(sender As Object, e As EventArgs) Handles mainapp_help_aboutme.Click
        aboutme.ShowDialog()
    End Sub
    Private Sub main_application_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Está a punto de cerrar la aplicación. ¿Está seguro que desea continuar?", _
                           Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub mainapp_help_aboutme_MouseMove(sender As Object, e As MouseEventArgs) Handles mainapp_help_aboutme.MouseMove
        mainapp_status_text.Text = "Información sobre la aplicación."
    End Sub
    Private Sub main_application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Login_CargarUserData(main_loggin.loggin_username_txt.Text)
        Call PGSQL_CargaTipos()
        Call PGSQL_CargaClientes()
        Dim Form_MidiMenu As New main_menu_lateral
        Form_MidiMenu.MdiParent = Me
        ' # Redimencionamos el formulario.
        Form_MidiMenu.Height = Me.ClientSize.Height * 0.92
        'test.Width = Me.ClientSize.Width * 0.1     ' 10% of parent
        'test.Height = Me.ClientSize.Height * 0.99  '  25% of parent
        Form_MidiMenu.Show()
        ' # Cargamos los controles basicos de la aplicacion
        mainapp_status_text.Text = Application.ProductName & " - " & Application.ProductVersion
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/main_background.png")
        Me.BackgroundImageLayout = ImageLayout.Stretch
        ' # ESTABLECEMOS LOS VAORES DEL TIMMER QUE CONTROLA EL RELOJ DE LA PANTALLA PRINCIPAL DE LA APLICACION.
        Me.mainapp_tm_clock.Interval = 1000
        Me.mainapp_lbl_clock.Text = Date.Now
        Me.mainapp_tm_clock.Enabled = True
    End Sub
    Private Sub mainapp_help_aboutme_MouseLeave(sender As Object, e As EventArgs) Handles mainapp_help_aboutme.MouseLeave
        mainapp_status_text.Text = Application.ProductName & " - " & Application.ProductVersion
    End Sub
    Private Sub mainapp_tm_clock_Tick(sender As Object, e As EventArgs) Handles mainapp_tm_clock.Tick
        Me.mainapp_lbl_clock.Text = Date.Now
    End Sub
End Class
