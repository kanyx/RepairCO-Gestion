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
    Private Sub addtipo_pic_add_Click(sender As Object, e As EventArgs) Handles addtipo_pic_add.Click
        ' # FUNCION QUE AGREGA UN TIPO DE PRODUCTO A LA BASE DE DATOS.
        If Me.addtipo_txt_tipo.Text = "" Or Me.addtipo_txt_tipo.TextLength < 4 Then
            Me.addtipo_txt_tipo.BackColor = Color.DarkRed
            Me.addtipo_txt_tipo.ForeColor = Color.White
            Exit Sub
        Else
            Me.addtipo_txt_tipo.BackColor = Color.DarkGreen
            Me.addtipo_txt_tipo.ForeColor = Color.White
        End If
        If PGSQL_INGRESO_TIPO(Me.addtipo_txt_tipo.Text) = True Then
            MessageBox.Show("Tipo de producto agregado exitosamente.", Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            ' # EN CASO QUE OCURRA UN ERROR AL INGRESAR EL TIPO DE PRODUCTO.
        End If
    End Sub
End Class