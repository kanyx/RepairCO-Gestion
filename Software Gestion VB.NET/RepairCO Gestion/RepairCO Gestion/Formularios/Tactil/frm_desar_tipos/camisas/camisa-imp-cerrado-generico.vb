Public Class camisa_imp_cerrado_generico
    Public MecOT As String = "" ' # NUMERO DE ORDEN DE TRABAJO ACTIVA.
    Public MecTipoProducto As String = "" ' # TIPO DE PRODUCTO (TIP. NECESARIO PARA PODER CARGAR LA INFORMACION A LA BASE DE DATOS)
    Private ValoresAnteriores As New Dictionary(Of String, String) ' # ARRAY QUE CONTIENE LOS VALORES DE LAS MEDICIONES ANTERIORES.
    Private Sub camisa_imp_cerrado_generico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGAMOS ELEMENTOS GRAFICOS DEL FORMULARIO.
        Me.camisa_pn_vector.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/vector.png")
        Me.camisa_pn_z1.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z1_normal.png")
        Me.camisa_pn_z2.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z2_normal.png")
        Me.camisa_pn_z3.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z3_normal.png")
        Me.camisa_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/camisa_impulsorcerrado_generic_title.png")
        ' # PARAMETROS CONTROLES DEL FORMULARIO.
        Me.camisa_pn_med.Visible = False
        Me.camisa_pn_z1.Location = New Point(47, 47)
        Me.camisa_pn_z2.Location = New Point(508, 63)
        Me.camisa_pn_z3.Location = New Point(46, -15)
        Me.camisa_txt_z1.ReadOnly = True
        Me.camisa_txt_z2.ReadOnly = True
        Me.camisa_txt_z3.ReadOnly = True
        Me.camisa_pn_z1.BackColor = Color.Transparent
        Me.camisa_pn_z2.BackColor = Color.Transparent
        Me.camisa_pn_z3.BackColor = Color.Transparent
        Me.camisa_pic_title.BackColor = Color.Transparent
        Me.camisa_lbl_z1.BackColor = Color.Transparent
        Me.camisa_lbl_z2.BackColor = Color.Transparent
        Me.camisa_lbl_z3.BackColor = Color.Transparent
        Me.camisa_lbl_z1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.camisa_lbl_z2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.camisa_lbl_z3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.camisa_txt_z1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.camisa_txt_z2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.camisa_txt_z3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        ' # CARGAMOS VALORES DE MEDICIONES ANTERIORES.
        ValoresAnteriores = PGSQL_TACTIL_MEDPROMLOAD(MecOT, "3") ' # COMPONENTE ESTABLECIDO MANUALMENTE DEACUERDO L FORMULARIO.
        If ValoresAnteriores.ContainsKey("0") = False Then
            For Each Valor In ValoresAnteriores
                If Valor.Key = "1" And Valor.Value <> "" Then
                    Me.camisa_pn_z1.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z1_sucess.png")
                    Me.camisa_txt_z1.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf (Valor.Key = "2" And Valor.Value) Then
                    Me.camisa_pn_z2.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z2_sucess.png")
                    Me.camisa_txt_z2.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf (Valor.Key = "3" And Valor.Value) Then
                    Me.camisa_pn_z3.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z3_sucess.png")
                    Me.camisa_txt_z3.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                End If
            Next
        End If
    End Sub
    Private Sub camisa_pn_z1_Click(sender As Object, e As EventArgs) Handles camisa_pn_z1.Click
        Me.camisa_pn_z1.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z1_active.png")
        Me.camisa_pn_med.Visible = True
        Me.camisa_pn_med.Size = New Size(518, 229)
        Dim frm_med_z1 As New mec_med_form
        frm_med_z1.TopLevel = False
        frm_med_z1.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z1.Dock = DockStyle.Fill
        frm_med_z1.MedComponente = "3"
        frm_med_z1.MedZona = "1"
        frm_med_z1.MedOT = MecOT
        frm_med_z1.ControlReturn = Me.camisa_txt_z1
        frm_med_z1.PanelCarga = Me.camisa_pn_med
        frm_med_z1.ZoneControlPanel = Me.camisa_pn_z1
        frm_med_z1.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z1_normal.png")
        frm_med_z1.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z1_sucess.png")
        frm_med_z1.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z1_active.png")
        Me.camisa_pn_med.Controls.Add(frm_med_z1)
        frm_med_z1.Show()
    End Sub
    Private Sub camisa_pn_z2_Click(sender As Object, e As EventArgs) Handles camisa_pn_z2.Click
        Me.camisa_pn_z2.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z2_active.png")
        Me.camisa_pn_med.Visible = True
        Me.camisa_pn_med.Size = New Size(518, 229)
        Dim frm_med_z2 As New mec_med_form
        frm_med_z2.TopLevel = False
        frm_med_z2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z2.Dock = DockStyle.Fill
        frm_med_z2.MedComponente = "3"
        frm_med_z2.MedZona = "2"
        frm_med_z2.MedOT = MecOT
        frm_med_z2.ControlReturn = Me.camisa_txt_z2
        frm_med_z2.PanelCarga = Me.camisa_pn_med
        frm_med_z2.ZoneControlPanel = Me.camisa_pn_z2
        frm_med_z2.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z2_normal.png")
        frm_med_z2.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z2_sucess.png")
        frm_med_z2.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z2_active.png")
        Me.camisa_pn_med.Controls.Add(frm_med_z2)
        frm_med_z2.Show()
    End Sub
    Private Sub camisa_pn_z3_Click(sender As Object, e As EventArgs) Handles camisa_pn_z3.Click
        Me.camisa_pn_z3.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z3_active.png")
        Me.camisa_pn_med.Visible = True
        Me.camisa_pn_med.Size = New Size(518, 229)
        Dim frm_med_z3 As New mec_med_form
        frm_med_z3.TopLevel = False
        frm_med_z3.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z3.Dock = DockStyle.Fill
        frm_med_z3.MedComponente = "3"
        frm_med_z3.MedZona = "3"
        frm_med_z3.MedOT = MecOT
        frm_med_z3.ControlReturn = Me.camisa_txt_z3
        frm_med_z3.PanelCarga = Me.camisa_pn_med
        frm_med_z3.ZoneControlPanel = Me.camisa_pn_z3
        frm_med_z3.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z3_normal.png")
        frm_med_z3.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z3_sucess.png")
        frm_med_z3.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/camisas/generico_imp_cerrado/z3_active.png")
        Me.camisa_pn_med.Controls.Add(frm_med_z3)
        frm_med_z3.Show()
    End Sub
End Class