Public Class eje_imp_cerrado_generico
    Public MecOT As String = "" ' # NUMERO DE ORDEN DE TRABAJO ACTIVA.
    Public MecTipoProducto As String = "" ' # TIPO DE PRODUCTO (TIP. NECESARIO PARA PODER CARGAR LA INFORMACION A LA BASE DE DATOS)
    Private ValoresAnteriores As New Dictionary(Of String, String) ' # ARRAY QUE CONTIENE LOS VALORES DE LAS MEDICIONES ANTERIORES.
    Private FlexionAnterior As New Dictionary(Of Integer, String) ' # ARRAY QUE CONTIENE LA FLEXION ANTERIOR DE LA ORDEN.
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
        Me.eje_pic_visual.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/insvisual_normal.png")
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
        ' # CARGAMOS VALORES A LOS CAMPOS PROMEDIADOS EN CASO QUE EXISTAN. (CALCULAR CUANTAS ZONAS POSEE EL ELEMENTO PARA PODER CARGAR CORRECTAMENTE LOS DATOS)
        ValoresAnteriores = PGSQL_TACTIL_MEDPROMLOAD(MecOT, "1") ' # COMPONENTE ESTABLECIDO MANUALMENTE DEACUERDO L FORMULARIO.
        If ValoresAnteriores.ContainsKey("0") = False Then
            For Each Valor In ValoresAnteriores
                If Valor.Key = "1" And Valor.Value <> "" Then
                    Me.eje_pic_z1.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z1_sucess.png")
                    Me.eje_txt_z1.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf Valor.Key = "2" And Valor.Value <> "" Then
                    Me.eje_pic_z2.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z2_sucess.png")
                    Me.eje_txt_z2.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf Valor.Key = "3" And Valor.Value <> "" Then
                    Me.eje_pic_z3.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z3_sucess.png")
                    Me.eje_txt_z3.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf Valor.Key = "4" And Valor.Value <> "" Then
                    Me.eje_pic_z4.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z4_sucess.png")
                    Me.eje_txt_z4.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                ElseIf Valor.Key = "5" And Valor.Value <> "" Then
                    Me.eje_pic_z5.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z5_sucess.png")
                    Me.eje_txt_z5.Text = Format(Single.Parse(Valor.Value), "##,##0.0")
                End If
            Next
        End If
        ' # CARGAMOS LOS VALORES ANTERIORES DE LA MEDICION DE FLEXION.
        FlexionAnterior = PGSQL_TACTIL_FLEXLOAD(MecOT, 1)
        Dim OrdenArray As New ArrayList
        If FlexionAnterior.Count > 0 Then
            For Each Valor In FlexionAnterior
                Dim splitValor As String() = Valor.Value.Split("#")
                For Each Med In splitValor
                    OrdenArray.Add(Med)
                Next
            Next
            OrdenArray.Sort()
            Me.eje_txt_z6.Text = Format(Single.Parse(OrdenArray(OrdenArray.Count - 1)), "##,##0.0")
        End If
    End Sub
    Private Sub eje_pic_z1_Click(sender As Object, e As EventArgs) Handles eje_pic_z1.Click
        ' # ZONA 1 - Ø EXT. EJE ZONA ACOPLAMIENTO.
        Me.eje_pic_z1.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z1_active.png")
        Me.eje_pn_med.Visible = True
        Me.eje_pn_med.Size = New Size(518, 229)
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
        frm_med_z1.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z1.png")
        frm_med_z1.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z1_sucess.png")
        frm_med_z1.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z1_active.png")
        Me.eje_pn_med.Controls.Add(frm_med_z1)
        frm_med_z1.Show()
    End Sub
    Private Sub eje_pic_z2_Click(sender As Object, e As EventArgs) Handles eje_pic_z2.Click
        ' # ZONA 2 - Ø EXT. EJE ZONA ROD. LADO ACOPLAMIENTO.
        Me.eje_pic_z2.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z2_active.png")
        Me.eje_pn_med.Visible = True
        Me.eje_pn_med.Size = New Size(518, 229)
        Dim frm_med_z2 As New mec_med_form
        frm_med_z2.TopLevel = False
        frm_med_z2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z2.Dock = DockStyle.Fill
        frm_med_z2.MedComponente = "1"
        frm_med_z2.MedZona = "2"
        frm_med_z2.MedOT = MecOT
        frm_med_z2.ControlReturn = Me.eje_txt_z2
        frm_med_z2.PanelCarga = Me.eje_pn_med
        frm_med_z2.ZoneControl = Me.eje_pic_z2
        frm_med_z2.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z2.png")
        frm_med_z2.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z2_sucess.png")
        frm_med_z2.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z2_active.png")
        Me.eje_pn_med.Controls.Add(frm_med_z2)
        frm_med_z2.Show()
    End Sub
    Private Sub eje_pic_z3_Click(sender As Object, e As EventArgs) Handles eje_pic_z3.Click
        ' # ZONA 3 - Ø EXT. EJE ZONA ROD. LADO LIBRE.
        Me.eje_pic_z3.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z3_active.png")
        Me.eje_pn_med.Visible = True
        Me.eje_pn_med.Size = New Size(518, 229)
        Dim frm_med_z3 As New mec_med_form
        frm_med_z3.TopLevel = False
        frm_med_z3.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z3.Dock = DockStyle.Fill
        frm_med_z3.MedComponente = "1"
        frm_med_z3.MedZona = "3"
        frm_med_z3.MedOT = MecOT
        frm_med_z3.ControlReturn = Me.eje_txt_z3
        frm_med_z3.PanelCarga = Me.eje_pn_med
        frm_med_z3.ZoneControl = Me.eje_pic_z3
        frm_med_z3.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z3.png")
        frm_med_z3.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z3_sucess.png")
        frm_med_z3.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z3_active.png")
        Me.eje_pn_med.Controls.Add(frm_med_z3)
        frm_med_z3.Show()
    End Sub
    Private Sub eje_pic_z4_Click(sender As Object, e As EventArgs) Handles eje_pic_z4.Click
        ' # ZONA 4 - Ø EXT. EJE ZONA CAMISA DESGASTE.
        Me.eje_pic_z4.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z4_active.png")
        Me.eje_pn_med.Visible = True
        Me.eje_pn_med.Size = New Size(518, 229)
        Dim frm_med_z4 As New mec_med_form
        frm_med_z4.TopLevel = False
        frm_med_z4.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z4.Dock = DockStyle.Fill
        frm_med_z4.MedComponente = "1"
        frm_med_z4.MedZona = "4"
        frm_med_z4.MedOT = MecOT
        frm_med_z4.ControlReturn = Me.eje_txt_z4
        frm_med_z4.PanelCarga = Me.eje_pn_med
        frm_med_z4.ZoneControl = Me.eje_pic_z4
        frm_med_z4.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z4.png")
        frm_med_z4.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z4_sucess.png")
        frm_med_z4.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z4_active.png")
        Me.eje_pn_med.Controls.Add(frm_med_z4)
        frm_med_z4.Show()
    End Sub
    Private Sub eje_pic_z5_Click(sender As Object, e As EventArgs) Handles eje_pic_z5.Click
        ' # ZONA 5 - Ø EXT. EJE ZONA IMPULSOR.
        Me.eje_pic_z5.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z5_active.png")
        Me.eje_pn_med.Visible = True
        Me.eje_pn_med.Size = New Size(518, 229)
        Dim frm_med_z5 As New mec_med_form
        frm_med_z5.TopLevel = False
        frm_med_z5.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_z5.Dock = DockStyle.Fill
        frm_med_z5.MedComponente = "1"
        frm_med_z5.MedZona = "5"
        frm_med_z5.MedOT = MecOT
        frm_med_z5.ControlReturn = Me.eje_txt_z5
        frm_med_z5.PanelCarga = Me.eje_pn_med
        frm_med_z5.ZoneControl = Me.eje_pic_z5
        frm_med_z5.ZoneImage = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z5.png")
        frm_med_z5.ZoneImageSucces = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z5_sucess.png")
        frm_med_z5.ZoneImageError = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z5_active.png")
        Me.eje_pn_med.Controls.Add(frm_med_z5)
        frm_med_z5.Show()
    End Sub
    Private Sub eje_pic_z6_Click(sender As Object, e As EventArgs) Handles eje_pic_z6.Click
        Me.eje_pn_med.Visible = True
        Me.eje_pn_med.Size = New Size(504, 319)
        Dim frm_med_flex As New mec_med_flexion
        frm_med_flex.TopLevel = False
        frm_med_flex.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_med_flex.Dock = DockStyle.Fill
        frm_med_flex.FlexComponente = "1"
        frm_med_flex.FlexOT = MecOT
        frm_med_flex.ControlReturn = Me.eje_txt_z6
        frm_med_flex.PanelCarga = Me.eje_pn_med
        Me.eje_pn_med.Controls.Add(frm_med_flex)
        frm_med_flex.Show()
    End Sub
End Class