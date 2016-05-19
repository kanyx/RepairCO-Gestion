Public Class mec_dashboard
    Public MecUserInfo As ArrayList
    Public MecUserID As String = "4"
    Public MecStation As String = "MC1"
    Public MecStationID As String = ""
    Private MecAuthClose As Boolean = False
    Private Sub mec_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGAMOS VALORES PRINCIPALES DE INFORMACION DESDE LA BASE DE DATOS.
        Me.MecUserInfo = PGSQL_GETPERSONALDATES(MecUserID)
        ' # CARGA IMAGENES A LOS CONTROLES DE LA APLICACION.
        Me.mecdash_pic_header.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/meca/dash_header.png")
        If Me.MecUserInfo(8) <> "" Then
            ' # CARGAMOS LA FOTO DEL USUARIO (SERVIDOR/_profilepics/)***
        Else
            Me.mecdash_pic_user.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/meca/dash_nofoto.png")
        End If
        Me.mecdash_pn_utils.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/meca/dash_header_util.png")
        Me.mecdash_pic_utilhome.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/meca/dash_util_home.png")
        Me.mecdash_pic_utilinspector.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/meca/dash_util_inspector.png")
        Me.mecdash_pic_utildevelop.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/meca/dash_util_develop.png")
        Me.mecdash_pic_utilcuser.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/meca/dash_util_changeuser.png")
        ' # CARGAMOS VALORES DE LOS CONTROLES.
        Me.mecdash_lbl_nombreuser.Text = Me.MecUserInfo(1).ToString.ToUpper & " " & Me.MecUserInfo(2).ToString.ToUpper & " " & Me.MecUserInfo(3).ToString.ToUpper
        Me.mecdash_lbl_rut.Text = Me.MecUserInfo(4).ToString
        Me.mecdash_lbl_station.Text = "ESTACION " & Me.MecStation.ToUpper
        Me.mecdash_lbl_clock.Text = Date.Now
        ' # CARGAMOS PARAMETROS DE LOS CONTROLES.
        Me.mecdash_lbl_nombreuser.Parent = Me.mecdash_pic_header
        Me.mecdash_lbl_rut.Parent = Me.mecdash_pic_header
        Me.mecdash_lbl_station.Parent = Me.mecdash_pic_header
        Me.mecdash_lbl_clock.Parent = Me.mecdash_pic_header
        Me.mecdash_pn_utils.Parent = Me.mecdash_pic_header
        Me.close_hide.Parent = Me.mecdash_pic_header
        Me.mecdash_pic_header.BackColor = Color.Transparent
        Me.mecdash_pic_user.BackColor = Color.Transparent
        Me.mecdash_lbl_nombreuser.BackColor = Color.Transparent
        Me.mecdash_lbl_rut.BackColor = Color.Transparent
        Me.mecdash_lbl_station.BackColor = Color.Transparent
        Me.mecdash_pn_utils.BackColor = Color.Transparent
        Me.mecdash_lbl_clock.BackColor = Color.Transparent
        Me.mecdash_pic_utilhome.BackColor = Color.Transparent
        Me.mecdash_pic_utilinspector.BackColor = Color.Transparent
        Me.mecdash_pic_utildevelop.BackColor = Color.Transparent
        Me.mecdash_pic_utilcuser.BackColor = Color.Transparent
        Me.close_hide.BackColor = Color.Transparent
        Me.mecdash_lbl_nombreuser.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Me.mecdash_lbl_rut.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Me.mecdash_lbl_station.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Me.mecdash_lbl_clock.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Me.mecdash_tm_clock.Interval = 1000
        Me.mecdash_tm_clock.Enabled = True
        ' # CARGAMOS EL FORMULARIO HOME DEL DASHBOARD.
        Dim dasHOME As New mec_home
        dasHOME.TopLevel = False
        dasHOME.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        dasHOME.Dock = DockStyle.Fill
        Me.mecdash_pn_content.Controls.Add(dasHOME)
        dasHOME.Show()
    End Sub
    Private Sub mec_dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' # VERFICACION PARA CERRAR LA APLICACION (DEBE ESTAR EN TRUE LA VARIABLE MECAUTHCLOSE)
        If MecAuthClose = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub mec_dashboard_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' # COMPROBAMOS QUE EL USUARIO PRESIONE CTRL + ALT + R PARA SETEAR LA CORRECTA FINALIZACION DE LA APLICACION.
        If e.Control And e.Alt And e.KeyCode = Keys.R Then
            If MessageBox.Show("¿Desea cerrar la estacion de trabajo.?", Application.ProductName & " - " & Application.ProductVersion, _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MecAuthClose = True
                Me.Close()
                main_loggin.Close()
            End If
        End If
    End Sub
    Private Sub mecdash_tm_clock_Tick(sender As Object, e As EventArgs) Handles mecdash_tm_clock.Tick
        ' # FUNCION QUE ACTUALIZA EL RELOJ CON LA FECHA Y EL TIEMPO ACTUAL. (REAL TIME)
        Me.mecdash_lbl_clock.Text = Date.Now
    End Sub

    Private Sub close_hide_Click(sender As Object, e As EventArgs) Handles close_hide.Click
        Me.MecAuthClose = True
        Me.Close()
        main_loggin.Close()
    End Sub
End Class