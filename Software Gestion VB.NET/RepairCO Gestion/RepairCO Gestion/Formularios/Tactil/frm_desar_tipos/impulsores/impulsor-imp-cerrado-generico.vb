Public Class impulsor_imp_cerrado_generico
    Public MecOT As String = "" ' # NUMERO DE ORDEN DE TRABAJO ACTIVA.
    Public MecTipoProducto As String = "" ' # TIPO DE PRODUCTO (TIP. NECESARIO PARA PODER CARGAR LA INFORMACION A LA BASE DE DATOS)
    Private ValoresAnteriores As New Dictionary(Of String, String) ' # ARRAY QUE CONTIENE LOS VALORES DE LAS MEDICIONES ANTERIORES.
    Private Sub impulsor_imp_cerrado_generico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS GRAFICOS DEL FORMULARIO.
        Me.impulsor_pn_vector.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/vector.png")
        Me.impulsor_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/impulsor_impulsorcerrado_generic_title.png")
        Me.impulsor_pn_z1.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z1_normal.png")
        Me.impulsor_pn_z2.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z2_normal.png")
        Me.impulsor_pn_z3.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z3_normal.png")
        Me.impulsor_pn_z4.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z4_normal.png")
        Me.impulsor_pic_visual.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/insvisual_normal.png")
        ' # CARGA PARAMETROS DE LOS CONTROLES.
        Me.impulsor_pn_med.Location = New Point(408, 43)
        Me.impulsor_pn_med.Visible = False
        Me.impulsor_lbl_z1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.impulsor_lbl_z2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.impulsor_lbl_z3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.impulsor_lbl_z4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.impulsor_txt_z1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.impulsor_txt_z2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.impulsor_txt_z3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.impulsor_txt_z4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.impulsor_txt_z1.ReadOnly = True
        Me.impulsor_txt_z2.ReadOnly = True
        Me.impulsor_txt_z3.ReadOnly = True
        Me.impulsor_txt_z4.ReadOnly = True
        Me.impulsor_pn_visual.Visible = False
        Me.impulsor_pn_z1.BackColor = Color.Transparent
        Me.impulsor_pn_z2.BackColor = Color.Transparent
        Me.impulsor_pn_z3.BackColor = Color.Transparent
        Me.impulsor_pn_z4.BackColor = Color.Transparent
        ' # CARGAMOS VALORES DE MEDICIONES ANTERIORES.
        ValoresAnteriores = PGSQL_TACTIL_MEDPROMLOAD(MecOT, "5") ' # COMPONENTE ESTABLECIDO MANUALMENTE DEACUERDO L FORMULARIO.
        If ValoresAnteriores.ContainsKey("0") = False Then
            For Each Valor In ValoresAnteriores
                If Valor.Key = "1" And Valor.Value <> "" Then
                    Me.impulsor_pn_z1.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z1_sucess.png")
                    Me.impulsor_txt_z1.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf (Valor.Key = "2" And Valor.Value) Then
                    Me.impulsor_pn_z2.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z2_sucess.png")
                    Me.impulsor_txt_z2.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf (Valor.Key = "3" And Valor.Value) Then
                    Me.impulsor_pn_z3.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z3_sucess.png")
                    Me.impulsor_txt_z3.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf (Valor.Key = "4" And Valor.Value) Then
                    Me.impulsor_pn_z4.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z4_sucess.png")
                    Me.impulsor_txt_z4.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                End If
            Next
        End If
    End Sub
    Private Sub impulsor_pn_z1_Click(sender As Object, e As EventArgs) Handles impulsor_pn_z1.Click
        Me.impulsor_pn_z1.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z1_active.png")
        Me.impulsor_pn_med.Visible = True
        Me.impulsor_pn_med.Size = New Size(518, 229)
        Dim frm_med_z1 As New mec_med_form
        frm_med_z1.TopLevel = False
        frm_med_z1.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z1.Dock = DockStyle.Fill
        frm_med_z1.MedComponente = "5"
        frm_med_z1.MedZona = "1"
        frm_med_z1.MedOT = MecOT
        frm_med_z1.ControlReturn = Me.impulsor_txt_z1
        frm_med_z1.PanelCarga = Me.impulsor_pn_med
        frm_med_z1.ZoneControlPanel = Me.impulsor_pn_z1
        frm_med_z1.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z1_normal.png")
        frm_med_z1.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z1_sucess.png")
        frm_med_z1.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z1_active.png")
        Me.impulsor_pn_med.Controls.Add(frm_med_z1)
        frm_med_z1.Show()
    End Sub
    Private Sub impulsor_pn_z2_Click(sender As Object, e As EventArgs) Handles impulsor_pn_z2.Click
        Me.impulsor_pn_z2.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z2_active.png")
        Me.impulsor_pn_med.Visible = True
        Me.impulsor_pn_med.Size = New Size(518, 229)
        Dim frm_med_z2 As New mec_med_form
        frm_med_z2.TopLevel = False
        frm_med_z2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z2.Dock = DockStyle.Fill
        frm_med_z2.MedComponente = "5"
        frm_med_z2.MedZona = "2"
        frm_med_z2.MedOT = MecOT
        frm_med_z2.ControlReturn = Me.impulsor_txt_z2
        frm_med_z2.PanelCarga = Me.impulsor_pn_med
        frm_med_z2.ZoneControlPanel = Me.impulsor_pn_z2
        frm_med_z2.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z2_normal.png")
        frm_med_z2.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z2_sucess.png")
        frm_med_z2.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z2_active.png")
        Me.impulsor_pn_med.Controls.Add(frm_med_z2)
        frm_med_z2.Show()
    End Sub
    Private Sub impulsor_pn_z3_Click(sender As Object, e As EventArgs) Handles impulsor_pn_z3.Click
        Me.impulsor_pn_z3.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z3_active.png")
        Me.impulsor_pn_med.Visible = True
        Me.impulsor_pn_med.Size = New Size(518, 229)
        Dim frm_med_z3 As New mec_med_form
        frm_med_z3.TopLevel = False
        frm_med_z3.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z3.Dock = DockStyle.Fill
        frm_med_z3.MedComponente = "5"
        frm_med_z3.MedZona = "3"
        frm_med_z3.MedOT = MecOT
        frm_med_z3.ControlReturn = Me.impulsor_txt_z3
        frm_med_z3.PanelCarga = Me.impulsor_pn_med
        frm_med_z3.ZoneControlPanel = Me.impulsor_pn_z3
        frm_med_z3.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z3_normal.png")
        frm_med_z3.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z3_sucess.png")
        frm_med_z3.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z3_active.png")
        Me.impulsor_pn_med.Controls.Add(frm_med_z3)
        frm_med_z3.Show()
    End Sub
    Private Sub impulsor_pn_z4_Click(sender As Object, e As EventArgs) Handles impulsor_pn_z4.Click
        Me.impulsor_pn_z4.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z4_active.png")
        Me.impulsor_pn_med.Visible = True
        Me.impulsor_pn_med.Size = New Size(518, 229)
        Dim frm_med_z4 As New mec_med_form
        frm_med_z4.TopLevel = False
        frm_med_z4.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z4.Dock = DockStyle.Fill
        frm_med_z4.MedComponente = "5"
        frm_med_z4.MedZona = "4"
        frm_med_z4.MedOT = MecOT
        frm_med_z4.ControlReturn = Me.impulsor_txt_z4
        frm_med_z4.PanelCarga = Me.impulsor_pn_med
        frm_med_z4.ZoneControlPanel = Me.impulsor_pn_z4
        frm_med_z4.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z4_normal.png")
        frm_med_z4.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z4_sucess.png")
        frm_med_z4.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/impulsores/generico_imp_cerrado/z4_active.png")
        Me.impulsor_pn_med.Controls.Add(frm_med_z4)
        frm_med_z4.Show()
    End Sub
    Private Sub impulsor_pic_visual_Click(sender As Object, e As EventArgs) Handles impulsor_pic_visual.Click
        Me.impulsor_pn_visual.Visible = True
        Me.impulsor_pn_visual.Size = New Size(541, 409)
        Me.impulsor_pn_visual.Location = New Point(378, 10)
        Dim frm_med_visual As New impulsor_visual
        frm_med_visual.TopLevel = False
        frm_med_visual.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_visual.Dock = DockStyle.Fill
        frm_med_visual.VisualComponente = 5
        frm_med_visual.VisualOT = Integer.Parse(MecOT)
        frm_med_visual.PanelCarga = Me.impulsor_pn_visual
        Me.impulsor_pn_visual.Controls.Add(frm_med_visual)
        frm_med_visual.Show()
    End Sub
End Class