Public Class mec_loggin
    Private MecAUthClose As Boolean = False
    Private Sub mec_loggin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # FORMULARIO TACTIL PARA A ESTACIONES MECANICAS (LOGGIN)
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/form_mecloggin_backform.png")
        Me.mecloggin_pn_loggin.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/form_mecloggin_backpanel.png")
        Me.mecloggin_pic_rut.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/form_mecloggin_wordrut.png")
        Me.mecloggin_pic_pin.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/form_mecloggin_wordpin.png")
        Me.mecloggin_pic_station.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/form_mecloggin_wordestacion.png")
        Me.mecloggin_pic_enter.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/tactil_entrar.png")
        ' # SETEO DE PARAMETROS DE LA APLICACION.
        Me.mecloggin_pic_enter.BackColor = Color.Transparent
        Me.mecloggin_pn_loggin.BackColor = Color.Transparent
        Me.mecloggin_pic_enter.Cursor = Cursors.Hand
        ' # HABILITAMOS CAPTURA DE TECLAS
        Me.KeyPreview = True
    End Sub

    Private Sub mec_loggin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MecAUthClose = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub mecloggin_txt_rut_Click(sender As Object, e As EventArgs) Handles mecloggin_txt_rut.Click
        Call KEYBOARDRC_SHOW(Me.mecloggin_txt_rut, True, Me.mecloggin_pn_loggin, False)
    End Sub
    Private Sub mec_loggin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' # SI EL USUARIO PRESIONA CTRL + ALT + R LA APLICACION SE DESACTIVA.
        If e.Control And e.Alt And e.KeyCode = Keys.R Then
            If MessageBox.Show("¿Desea cerrar la estacion de trabajo.?", Application.ProductName & " - " & Application.ProductVersion, _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MecAUthClose = True
                Me.Close()
                main_loggin.Close()
            End If
        End If
    End Sub
End Class