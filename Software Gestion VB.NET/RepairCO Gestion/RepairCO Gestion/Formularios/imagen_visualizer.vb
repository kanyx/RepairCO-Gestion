Public Class imagen_visualizer
    Private Sub imagen_visualizer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # VISUALIZADOR DE IMAGENES
        ' # CARGA DE ELEMENTOS DEL VISUALIZADOR DE IMAGENES
        Me.visorimagen_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_imagevisualizer_title.png")
        Me.visorimagen_pic_ico.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/imagen.png")
        Me.visorimagen_pic_close.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/close.png")
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_visorimagen_background.png")
        Me.visorimagen_pic_close.Cursor = Cursors.Hand
        Me.visorimagen_pic_close.BackColor = Color.Transparent
        Me.visorimagen_pic_ico.BackColor = Color.Transparent
        Me.visorimagen_pic_title.BackColor = Color.Transparent
        Me.visorimagen_pic_title.SizeMode = PictureBoxSizeMode.StretchImage
        Me.visorimagen_pic_ico.SizeMode = PictureBoxSizeMode.StretchImage
        Me.visorimagen_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.visorimagen_pic_image.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Sub visorimagen_pic_close_Click(sender As Object, e As EventArgs) Handles visorimagen_pic_close.Click
        Me.Close()
    End Sub

    Private Sub imagen_visualizer_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class