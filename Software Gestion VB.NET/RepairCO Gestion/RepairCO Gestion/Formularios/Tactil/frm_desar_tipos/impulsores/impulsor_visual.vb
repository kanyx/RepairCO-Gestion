Public Class impulsor_visual
    Public VisualComponente As Integer = 0
    Public VisualOT As Integer = 0
    Public PanelCarga As Panel
    Private Status As New Dictionary(Of Integer, String)
    Private Sub impulsor_visual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS VISUALES DEL FORMULARIO
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Data\grafica\meca\ins_visual_impulsor_background.png")
        Me.visual_pic_save.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\botones\guardar_normal.png")
        ' # ESTABLECEMOS PARAMETROS AL FORMULARIO.
        Status.Add(0, "SELEC..")
        Status.Add(1, "LIMPIEZA")
        Status.Add(2, "RECUPERAR")
        Status.Add(3, "CAMBIAR")
        Me.visual_cmb_z6.DataSource = New BindingSource(Status, Nothing)
        Me.visual_cmb_z6.DisplayMember = "Value"
        Me.visual_cmb_z6.ValueMember = "Key"
        Me.visual_cmb_z7.DataSource = New BindingSource(Status, Nothing)
        Me.visual_cmb_z7.DisplayMember = "Value"
        Me.visual_cmb_z7.ValueMember = "Key"
        Me.visual_cmb_z8.DataSource = New BindingSource(Status, Nothing)
        Me.visual_cmb_z8.DisplayMember = "Value"
        Me.visual_cmb_z8.ValueMember = "Key"
        Me.BackColor = Color.White
        Me.visual_lbl_z6.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.visual_lbl_z7.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.visual_lbl_z8.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.visual_lbl_obs.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.visual_cmb_z6.DropDownStyle = ComboBoxStyle.DropDownList
        Me.visual_cmb_z7.DropDownStyle = ComboBoxStyle.DropDownList
        Me.visual_cmb_z8.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub visual_pic_save_Click(sender As Object, e As EventArgs) Handles visual_pic_save.Click
        ' # RUTINA QUE GUARDA LOS CAMBIOS INGRESADOS EN LA INSPECCION VISUAL.
        PanelCarga.Visible = False
        Me.Close()
    End Sub
End Class