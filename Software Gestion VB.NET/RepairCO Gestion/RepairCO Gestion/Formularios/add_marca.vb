Public Class add_marca
    Private Sub add_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # PROCESO DE CARGA DE LOS ELEMENTOS DEL FORMULARIO
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_addmarca_background.png")
        Me.addmarca_pic_close.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/close.png")
        Me.addmarca_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_addmarca_title.png")
        Me.addmarca_pic_btnadd.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
        Me.addmarca_pic_ico.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/marca.png")
        Me.addmarca_pic_btnadd.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addmarca_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addmarca_pic_ico.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addmarca_pic_close.BackColor = Color.Transparent
        Me.addmarca_gb_datos.BackColor = Color.White
        Me.addmarca_pic_btnadd.BackColor = Color.Transparent
        Me.addmarca_pic_title.BackColor = Color.Transparent
        Me.addmarca_pic_ico.BackColor = Color.Transparent
        Me.addmarca_pic_close.Cursor = Cursors.Hand
        Me.addmarca_pic_btnadd.Cursor = Cursors.Hand
        Me.addmarca_tp_help.SetToolTip(Me.addmarca_cmb_tipo, "Seleccione  el tipo de producto al cual se asociara la marca.")
        Me.addmarca_tp_help.SetToolTip(Me.addmarca_txt_nombre, "Ingrese el nombre de la marca.")
        Me.addmarca_tp_help.SetToolTip(Me.addmarca_cmb_pais, "Seleccione el país de procedencia de la marca.")
        Me.addmarca_tp_help.SetToolTip(Me.addmarca_pic_close, "Cancelar el proceso de adición de una marca.")
        Me.addmarca_tp_help.SetToolTip(Me.addmarca_pic_btnadd, "Añadir la nueva marca a la base de datos.")
    End Sub
    Private Sub addmarca_pic_close_Click(sender As Object, e As EventArgs) Handles addmarca_pic_close.Click
        Me.Close()
    End Sub
    Private Sub addmarca_pic_btnadd_MouseHover(sender As Object, e As EventArgs) Handles addmarca_pic_btnadd.MouseHover
        Me.addmarca_pic_btnadd.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_hover.png")
    End Sub
    Private Sub addmarca_pic_btnadd_MouseLeave(sender As Object, e As EventArgs) Handles addmarca_pic_btnadd.MouseLeave
        Me.addmarca_pic_btnadd.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
    End Sub
End Class