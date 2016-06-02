Public Class cporod_imp_cerrado_generico
    Public MecOT As String = "" ' # ORDEN DE TRABAJO POR LA CUAL SE ESTA REALIZANDO LA MEDICION DE CARCASA.
    Public MecTipoProducto As String = "" ' # TIPO DE PRODUCTO EN ESTE CASO (2) QUE ES CARCASA (PARA USO. DB)
    Private ValoresAnteriores As New Dictionary(Of String, String) ' # ARRAY QUE CONTIENE LOS VALORES DE LAS MEDICIONES ANTERIORES.
    Private Sub cporod_imp_cerrado_generico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA ELEMENTOS GRAFICOS DEL FORMULARIO.
        Me.cporod_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/cporod_impulsorcerrado_generic_title.png")
        Me.cporod_pn_vector.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/vector.png")
        Me.cporod_pn_z1.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z1_normal.png")
        Me.cporod_pn_z2.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z2_normal.png")
        Me.cporod_pic_visual.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/insvisual_normal.png")
        ' # ESTABLECEMOS PARAMETROS A LOS CONTROLES.
        Me.cporod_pn_med.Visible = False
        Me.cporod_lbl_z1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.cporod_lbl_z2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.cporod_txt_z1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.cporod_txt_z2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.cporod_pn_z1.BackColor = Color.Transparent
        Me.cporod_pn_z2.BackColor = Color.Transparent
        Me.cporod_pn_z1.Location = New Point(182, -31)
        Me.cporod_pn_z2.Location = New Point(300, -31)
        Me.cporod_txt_z1.ReadOnly = True
        Me.cporod_txt_z2.ReadOnly = True
        Me.cporod_pn_visual.Visible = False
        ' # CARGAMOS LOS VALORES DESDE LA BASE DE DATOS.
        ValoresAnteriores = PGSQL_TACTIL_MEDPROMLOAD(MecOT, "4") ' # COMPONENTE ESTABLECIDO MANUALMENTE DEACUERDO L FORMULARIO.
        If ValoresAnteriores.ContainsKey("0") = False Then
            For Each Valor In ValoresAnteriores
                If Valor.Key = "1" And Valor.Value <> "" Then
                    Me.cporod_pn_z1.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z1_sucess.png")
                    Me.cporod_txt_z1.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf (Valor.Key = "2" And Valor.Value) Then
                    Me.cporod_pn_z2.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z2_sucess.png")
                    Me.cporod_txt_z2.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                End If
            Next
        End If
    End Sub
    Private Sub cporod_pn_z1_Click(sender As Object, e As EventArgs) Handles cporod_pn_z1.Click
        Me.cporod_pn_z1.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z1_active.png")
        Me.cporod_pn_med.Visible = True
        Me.cporod_pn_med.Size = New Size(518, 229)
        Dim frm_med_z1 As New mec_med_form
        frm_med_z1.TopLevel = False
        frm_med_z1.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z1.Dock = DockStyle.Fill
        frm_med_z1.MedComponente = "4"
        frm_med_z1.MedZona = "1"
        frm_med_z1.MedOT = MecOT
        frm_med_z1.ControlReturn = Me.cporod_txt_z1
        frm_med_z1.PanelCarga = Me.cporod_pn_med
        frm_med_z1.ZoneControlPanel = Me.cporod_pn_z1
        frm_med_z1.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z1_normal.png")
        frm_med_z1.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z1_sucess.png")
        frm_med_z1.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z1_active.png")
        Me.cporod_pn_med.Controls.Add(frm_med_z1)
        frm_med_z1.Show()
    End Sub
    Private Sub cporod_pn_z2_Click(sender As Object, e As EventArgs) Handles cporod_pn_z2.Click
        Me.cporod_pn_z2.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z2_active.png")
        Me.cporod_pn_med.Visible = True
        Me.cporod_pn_med.Size = New Size(518, 229)
        Dim frm_med_z2 As New mec_med_form
        frm_med_z2.TopLevel = False
        frm_med_z2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z2.Dock = DockStyle.Fill
        frm_med_z2.MedComponente = "4"
        frm_med_z2.MedZona = "2"
        frm_med_z2.MedOT = MecOT
        frm_med_z2.ControlReturn = Me.cporod_txt_z2
        frm_med_z2.PanelCarga = Me.cporod_pn_med
        frm_med_z2.ZoneControlPanel = Me.cporod_pn_z2
        frm_med_z2.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z2_normal.png")
        frm_med_z2.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z2_sucess.png")
        frm_med_z2.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/cpos_rods/generico_imp_cerrado/z2_active.png")
        Me.cporod_pn_med.Controls.Add(frm_med_z2)
        frm_med_z2.Show()
    End Sub
    Private Sub cporod_pic_visual_Click(sender As Object, e As EventArgs) Handles cporod_pic_visual.Click
        Me.cporod_pn_visual.Visible = True
        Me.cporod_pn_visual.Size = New Size(541, 409)
        Me.cporod_pn_visual.Location = New Point(378, 10)
        Dim frm_med_visual As New cporod_visual
        frm_med_visual.TopLevel = False
        frm_med_visual.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_visual.Dock = DockStyle.Fill
        frm_med_visual.VisualComponente = 4
        frm_med_visual.VisualOT = Integer.Parse(MecOT)
        frm_med_visual.PanelCarga = Me.cporod_pn_visual
        Me.cporod_pn_visual.Controls.Add(frm_med_visual)
        frm_med_visual.Show()
    End Sub
End Class