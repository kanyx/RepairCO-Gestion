Public Class view_ot
    Private Sub view_ot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA PRINCIPAL DEL VISOR DE ORDENES DE TRABAJO
        ' # RECORDAR QUE TODOS LOS CONTROLES EN PRIMERA INSTANCIA TIENES QUE ESTAR DESABILITADOS.
        Me.viewot_gb_datos.Enabled = False
        Me.viewot_gb_tipoot.Enabled = False
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_viewerot_background.png")
        Me.viewot_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_visorot_title.png")
        Me.viewot_pic_close.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/close.png")
        Me.viewot_pic_ot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/not.png")
        Me.viewot_pic_save.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_normal.png")
        ' # CARGA CONFIGURACION DE CONTROLES DEL FORMULARIO.
        Me.viewot_lbl_ot.ForeColor = ColorTranslator.FromHtml("#b88d00")
        Me.viewot_pic_title.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_save.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_close.Cursor = Cursors.Hand
        Me.viewot_pic_save.Cursor = Cursors.Hand
        Me.viewot_pic_save.Visible = False
        ' # LLAMAMOS LOS DATOS DE LA ORDEN LA INTRODUCIMOS A UN ARRAY Y LLENAMOS LOS VALORES DEL FORMULARIO.

    End Sub
    Private Sub viewot_pic_close_Click(sender As Object, e As EventArgs) Handles viewot_pic_close.Click
        Me.Close()
    End Sub
End Class