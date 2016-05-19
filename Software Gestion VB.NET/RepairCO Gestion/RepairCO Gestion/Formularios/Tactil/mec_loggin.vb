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
        Me.mecloggin_txt_rut.MaxLength = 10
        Me.mecloggin_txt_pass.MaxLength = 6
        Me.mecloggin_txt_pass.PasswordChar = Chr(134)
        Me.mecloggin_pic_enter.BackColor = Color.Transparent
        Me.mecloggin_pn_loggin.BackColor = Color.Transparent
        Me.mecloggin_pic_enter.Cursor = Cursors.Hand
        ' # HABILITAMOS CAPTURA DE TECLAS
        Me.KeyPreview = True
        ' # CARGAMOS LA LISTA DE ESTACIONES DESDE LA BASE DE DATOS.
        Me.mecloggin_cmb_station.DataSource = New BindingSource(PGSQL_TACTIL_GETSTATIONS, Nothing)
        Me.mecloggin_cmb_station.DisplayMember = "Value"
        Me.mecloggin_cmb_station.ValueMember = "Key"
    End Sub

    Private Sub mec_loggin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MecAUthClose = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub mecloggin_txt_rut_Click(sender As Object, e As EventArgs) Handles mecloggin_txt_rut.Click
        Call KEYBOARDRC_SHOW(Me.mecloggin_txt_rut, True, Me.mecloggin_pn_loggin, False, 10)
    End Sub
    Private Sub mecloggin_txt_pass_Click(sender As Object, e As EventArgs) Handles mecloggin_txt_pass.Click
        Call KEYBOARDRC_SHOW(Me.mecloggin_txt_pass, True, Me.mecloggin_pn_loggin, False, 6)
    End Sub
    Private Sub mecloggin_pic_enter_Click(sender As Object, e As EventArgs) Handles mecloggin_pic_enter.Click
        If Me.mecloggin_txt_rut.Text = "" Or Me.mecloggin_txt_rut.TextLength < 6 Then
            Me.mecloggin_txt_rut.BackColor = ColorTranslator.FromHtml("#ba0000")
            Me.mecloggin_txt_rut.ForeColor = ColorTranslator.FromHtml("#ffffff")
            Exit Sub
        ElseIf Me.mecloggin_txt_pass.Text = "" Or Me.mecloggin_txt_pass.TextLength < 4 Then
            Me.mecloggin_txt_pass.BackColor = ColorTranslator.FromHtml("#ba0000")
            Me.mecloggin_txt_pass.ForeColor = ColorTranslator.FromHtml("#ffffff")
            Exit Sub
        End If
        If Me.mecloggin_cmb_station.SelectedValue = "" Then
            Me.mecloggin_cmb_station.BackColor = ColorTranslator.FromHtml("#ba0000")
            Me.mecloggin_cmb_station.ForeColor = ColorTranslator.FromHtml("#ffffff")
            Exit Sub
        End If
        If PGSQL_TACTIL_LOGGIN(Me.mecloggin_txt_rut, Me.mecloggin_txt_pass, Me.mecloggin_cmb_station) = True Then
            ' # SI EL LOGIN DEL MECANICO ESTA CORRECTO. (PROCEDEMOS A MOSTRAR EL DASHBOARD)
            mec_dashboard.Show()
            MecAUthClose = True
            Me.Close()
        End If
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
    Private Sub mecloggin_txt_pass_Leave(sender As Object, e As EventArgs) Handles mecloggin_txt_pass.Leave
        Me.mecloggin_txt_pass.BackColor = ColorTranslator.FromHtml("#ffffff")
        Me.mecloggin_txt_pass.ForeColor = ColorTranslator.FromHtml("#000000")
    End Sub
    Private Sub mecloggin_txt_rut_Leave(sender As Object, e As EventArgs) Handles mecloggin_txt_rut.Leave
        Me.mecloggin_txt_rut.BackColor = ColorTranslator.FromHtml("#ffffff")
        Me.mecloggin_txt_rut.ForeColor = ColorTranslator.FromHtml("#000000")
    End Sub
End Class