Public Class carcasa_imp_cerrado_generico
    Public MecOT As String = "" ' # ORDEN DE TRABAJO POR LA CUAL SE ESTA REALIZANDO LA MEDICION DE CARCASA.
    Public MecTipoProducto As String = "" ' # TIPO DE PRODUCTO EN ESTE CASO (2) QUE ES CARCASA (PARA USO. DB)
    Private ValoresAnteriores As New Dictionary(Of String, String) ' # ARRAY QUE CONTIENE LOS VALORES DE LAS MEDICIONES ANTERIORES.
    Private Sub carcasa_imp_cerrado_generico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA ELEMENTOS GRAFICOS DE LA APLICACION.
        Me.carcasa_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/carcasas/carcasa_impulsorcerrado_generic_title.png")
        Me.carcasa_pic_vector.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/carcasas/generico_imp_cerrado/vector_paint.png")
        Me.carcasa_pic_visual.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/insvisual_normal.png")
        ' # ESTABLECEMOS PARAMETROS DE LA APLICACION.
        Me.carcasa_pn_med.Visible = False
        Me.carcasa_pic_vector.BackColor = Color.Transparent
        Me.carcasa_pic_title.BackColor = Color.Transparent
        Me.carcasa_txt_z1.ReadOnly = True
        Me.carcasa_txt_z2.ReadOnly = True
        Me.carcasa_pn_med.Visible = False
        Me.carcasa_pn_visual.Visible = False
        Me.carcasa_lbl_z1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.carcasa_lbl_z2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.carcasa_txt_z1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.carcasa_txt_z2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        ' # CARGAMOS VALORES DE LOS DATOS.
        ValoresAnteriores = PGSQL_TACTIL_MEDPROMLOAD(MecOT, "2") ' # COMPONENTE ESTABLECIDO MANUALMENTE DEACUERDO L FORMULARIO.
        If ValoresAnteriores.ContainsKey("0") = False Then
            For Each Valor In ValoresAnteriores
                If Valor.Key = "1" And Valor.Value <> "" Then
                    Me.carcasa_txt_z1.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf (Valor.Key = "2" And Valor.Value) Then
                    Me.carcasa_txt_z2.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                End If
            Next
        End If
    End Sub
    Private Sub carcasa_txt_z1_Click(sender As Object, e As EventArgs) Handles carcasa_txt_z1.Click
        Me.carcasa_pn_med.Visible = True
        Me.carcasa_pn_med.Size = New Size(518, 229)
        Me.carcasa_pn_med.Location = New Point(382, 12)
        Dim frm_med_z1 As New mec_med_form
        frm_med_z1.TopLevel = False
        frm_med_z1.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z1.Dock = DockStyle.Fill
        frm_med_z1.MedComponente = "2"
        frm_med_z1.MedZona = "1"
        frm_med_z1.MedOT = MecOT
        frm_med_z1.ControlReturn = Me.carcasa_txt_z1
        frm_med_z1.PanelCarga = Me.carcasa_pn_med
        Me.carcasa_pn_med.Controls.Add(frm_med_z1)
        frm_med_z1.Show()
    End Sub
    Private Sub carcasa_txt_z2_Click(sender As Object, e As EventArgs) Handles carcasa_txt_z2.Click
        Me.carcasa_pn_med.Visible = True
        Me.carcasa_pn_med.Size = New Size(518, 229)
        Me.carcasa_pn_med.Location = New Point(382, 12)
        Dim frm_med_z2 As New mec_med_form
        frm_med_z2.TopLevel = False
        frm_med_z2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z2.Dock = DockStyle.Fill
        frm_med_z2.MedComponente = "2"
        frm_med_z2.MedZona = "2"
        frm_med_z2.MedOT = MecOT
        frm_med_z2.ControlReturn = Me.carcasa_txt_z2
        frm_med_z2.PanelCarga = Me.carcasa_pn_med
        Me.carcasa_pn_med.Controls.Add(frm_med_z2)
        frm_med_z2.Show()
    End Sub

    Private Sub carcasa_pic_visual_Click(sender As Object, e As EventArgs) Handles carcasa_pic_visual.Click
        Me.carcasa_pn_visual.Visible = True
        Me.carcasa_pn_visual.Size = New Size(541, 409)
        Me.carcasa_pn_visual.Location = New Point(378, 10)
        Dim frm_med_visual As New carcasa_visual
        frm_med_visual.TopLevel = False
        frm_med_visual.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_visual.Dock = DockStyle.Fill
        frm_med_visual.VisualComponente = 2
        frm_med_visual.VisualOT = Integer.Parse(MecOT)
        frm_med_visual.PanelCarga = Me.carcasa_pn_visual
        Me.carcasa_pn_visual.Controls.Add(frm_med_visual)
        frm_med_visual.Show()
    End Sub
End Class