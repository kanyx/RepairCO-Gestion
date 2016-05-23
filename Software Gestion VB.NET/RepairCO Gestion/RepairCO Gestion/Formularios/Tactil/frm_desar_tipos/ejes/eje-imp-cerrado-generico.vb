Public Class eje_imp_cerrado_generico
    Public MecOT As String = "" ' # NUMERO DE ORDEN DE TRABAJO ACTIVA.
    Public MecTipoProducto As String = "" ' # TIPO DE PRODUCTO (TIP. NECESARIO PARA PODER CARGAR LA INFORMACION A LA BASE DE DATOS)
    Private Sub imp_cerrado_generico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGAMOS GRAFICA DE LOS FORMULARIOS.
        Me.eje_pn_vector.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/eje_impulsor_cerrado_generic.png")
        Me.eje_pic_z1.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z1.png")
        Me.eje_pic_z2.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z2.png")
        Me.eje_pic_z3.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z3.png")
        Me.eje_pic_z4.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z4.png")
        Me.eje_pic_z5.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z5.png")
        Me.eje_pic_z6.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/btn_flex.png")
        Me.eje_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/eje_impulsorcerrado_generic_title.png")
        ' # ESTABLECEMOS PARAMETROS A LOS CONTROLES
        Me.eje_pn_vector.BackColor = Color.Transparent
        Me.eje_pic_z1.BackColor = Color.Transparent
        Me.eje_pic_z2.BackColor = Color.Transparent
        Me.eje_pic_z3.BackColor = Color.Transparent
        Me.eje_pic_z4.BackColor = Color.Transparent
        Me.eje_pic_z5.BackColor = Color.Transparent
        Me.eje_pic_z6.BackColor = Color.Transparent
        Me.eje_pic_z1.Parent = Me.eje_pn_vector
        Me.eje_pic_z2.Parent = Me.eje_pn_vector
        Me.eje_pic_z3.Parent = Me.eje_pn_vector
        Me.eje_pic_z4.Parent = Me.eje_pn_vector
        Me.eje_pic_z5.Parent = Me.eje_pn_vector
        Me.eje_pic_z1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.eje_pic_z2.SizeMode = PictureBoxSizeMode.StretchImage
        Me.eje_pic_z3.SizeMode = PictureBoxSizeMode.StretchImage
        Me.eje_pic_z4.SizeMode = PictureBoxSizeMode.StretchImage
        Me.eje_pic_z5.SizeMode = PictureBoxSizeMode.StretchImage
        Me.eje_pic_z6.SizeMode = PictureBoxSizeMode.StretchImage
        Me.eje_lbl_z1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_txt_z1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_lbl_z2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_txt_z2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_lbl_z3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_txt_z3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_lbl_z4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_txt_z4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_lbl_z5.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_txt_z5.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_lbl_z6.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_txt_z6.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.eje_txt_z1.ReadOnly = True
        Me.eje_txt_z2.ReadOnly = True
        Me.eje_txt_z3.ReadOnly = True
        Me.eje_txt_z4.ReadOnly = True
        Me.eje_txt_z5.ReadOnly = True
        Me.eje_txt_z6.ReadOnly = True
        Me.eje_pn_med.Visible = False
    End Sub
    Private Sub eje_pic_z1_Click(sender As Object, e As EventArgs) Handles eje_pic_z1.Click
        ' # ZONA 1 - Ø EXT. EJE ZONA ACOPLAMIENTO.
        Me.eje_pic_z1.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z1_active.png")
        Me.eje_pn_med.Visible = True
        Dim frm_med_z1 As New mec_med_form
        frm_med_z1.TopLevel = False
        frm_med_z1.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z1.Dock = DockStyle.Fill
        frm_med_z1.MedComponente = "1"
        frm_med_z1.MedZona = "1"
        frm_med_z1.MedOT = MecOT
        frm_med_z1.ControlReturn = Me.eje_txt_z1
        frm_med_z1.PanelCarga = Me.eje_pn_med
        frm_med_z1.ZoneControl = Me.eje_pic_z1
        Me.eje_pn_med.Controls.Add(frm_med_z1)
        frm_med_z1.Show()
    End Sub
    Private Sub eje_pic_z2_Click(sender As Object, e As EventArgs) Handles eje_pic_z2.Click
        ' # ZONA 2 - Ø EXT. EJE ZONA ROD. LADO ACOPLAMIENTO.
        Me.eje_pic_z2.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z2_active.png")
    End Sub
    Private Sub eje_pic_z3_Click(sender As Object, e As EventArgs) Handles eje_pic_z3.Click
        ' # ZONA 3 - Ø EXT. EJE ZONA ROD. LADO LIBRE.
        Me.eje_pic_z3.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z3_active.png")
    End Sub
    Private Sub eje_pic_z4_Click(sender As Object, e As EventArgs) Handles eje_pic_z4.Click
        ' # ZONA 4 - Ø EXT. EJE ZONA CAMISA DESGASTE.
        Me.eje_pic_z4.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z4_active.png")
    End Sub
    Private Sub eje_pic_z5_Click(sender As Object, e As EventArgs) Handles eje_pic_z5.Click
        ' # ZONA 5 - Ø EXT. EJE ZONA IMPULSOR.
        Me.eje_pic_z5.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z5_active.png")
    End Sub
End Class