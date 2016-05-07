Public Class add_tipo
    Private Sub add_tipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS DE LA APLICACION.
        Me.addtipo_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_addtipo_title.png")
        Me.addtipo_pic_close.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/close.png")
        Me.addtipo_pic_add.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_addtipo_background.png")
        Me.addtipo_pic_ico.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/tipo.png")
        Me.addtipo_pic_close.Cursor = Cursors.Hand
        Me.addtipo_pic_add.Cursor = Cursors.Hand
        Me.addtipo_pic_title.BackColor = Color.Transparent
        Me.addtipo_pic_close.BackColor = Color.Transparent
        Me.addtipo_pic_add.BackColor = Color.Transparent
        Me.addtipo_pic_ico.BackColor = Color.Transparent
        Me.addtipo_pic_add.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addtipo_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addtipo_pic_ico.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addtipo_tp_help.SetToolTip(Me.addtipo_pic_close, "Presione squi para cancelar la operación.")
        Me.addtipo_tp_help.SetToolTip(Me.addtipo_pic_add, "Presione aquí para agregar el tipo a la base de datos.")
    End Sub
    Private Sub addtipo_pic_close_Click(sender As Object, e As EventArgs) Handles addtipo_pic_close.Click
        Me.Close()
    End Sub
    Private Sub addtipo_pic_add_MouseHover(sender As Object, e As EventArgs) Handles addtipo_pic_add.MouseHover
        Me.addtipo_pic_add.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_hover.png")
    End Sub
    Private Sub addtipo_pic_add_MouseLeave(sender As Object, e As EventArgs) Handles addtipo_pic_add.MouseLeave
        Me.addtipo_pic_add.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
    End Sub
End Class