Public Class add_modelo
    Private Sub add_modelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS DEL FORMULARIO
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_addmodelo_background.png")
        Me.addmodelo_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_addmodelo_title.png")
        Me.addmodelo_pic_close.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/close.png")
        Me.addmodelo_pic_ico.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/modelo.png")
        Me.addmodelo_pic_add.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
        Me.addmodelo_pic_close.Cursor = Cursors.Hand
        Me.addmodelo_pic_add.Cursor = Cursors.Hand
        Me.addmodelo_pic_title.BackColor = Color.Transparent
        Me.addmodelo_pic_ico.BackColor = Color.Transparent
        Me.addmodelo_pic_close.BackColor = Color.Transparent
        Me.addmodelo_pic_add.BackColor = Color.Transparent
        Me.addmodelo_pic_add.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addmodelo_pic_title.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addmodelo_pic_ico.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addmodelo_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addmodelo_tp_help.SetToolTip(Me.addmodelo_pic_close, "Presione aquí para cancelar la operación.")
        Me.addmodelo_tp_help.SetToolTip(Me.addmodelo_pic_add, "Presione aquí para agregar el modelo a la base de datos.")
    End Sub
    Private Sub addmodelo_pic_close_Click(sender As Object, e As EventArgs) Handles addmodelo_pic_close.Click
        Me.Close()
    End Sub
    Private Sub addmodelo_pic_add_MouseHover(sender As Object, e As EventArgs) Handles addmodelo_pic_add.MouseHover
        Me.addmodelo_pic_add.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_hover.png")
    End Sub
    Private Sub addmodelo_pic_add_MouseLeave(sender As Object, e As EventArgs) Handles addmodelo_pic_add.MouseLeave
        Me.addmodelo_pic_add.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
    End Sub

    Private Sub addmodelo_pic_add_Click(sender As Object, e As EventArgs) Handles addmodelo_pic_add.Click

    End Sub
End Class