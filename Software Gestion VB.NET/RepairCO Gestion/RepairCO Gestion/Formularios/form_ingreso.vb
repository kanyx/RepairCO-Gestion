Public Class form_ingreso
    Private imagenes_carga As ArrayList
    Private OTguardada As Boolean = False
    Private Sub form_ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS FORMULARIO PRINCIPAL
        Me.ingresot_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ingreso_ot_title.png")
        Me.ingresot_pic_ot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/not.png")
        Me.ingresot_pn_imgcontainer.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_ingreso_images_background_locked.png")
        Me.ingresot_pic_saveot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_normal.png")
        Me.ingresot_pic_saveimages.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_normal.png")
        Me.ingreso_lbl_addcliente.Cursor = Cursors.Hand
        Me.ingreso_lbl_addtipo.Cursor = Cursors.Hand
        Me.ingreso_lbl_addmarca.Cursor = Cursors.Hand
        Me.ingreso_lbl_addmodelo.Cursor = Cursors.Hand
        Me.ingresot_pic_saveot.Cursor = Cursors.Hand
        Me.ingresot_pic_saveimages.Cursor = Cursors.Hand
        Me.ingreso_txt_not.ReadOnly = True
        Me.ingresot_pn_imgcontainer.Cursor = Cursors.No
        Me.ingresot_pic_saveot.BackColor = Color.Transparent
        Me.ingresot_pic_saveimages.BackColor = Color.Transparent
        Me.ingresot_pic_saveot.SizeMode = PictureBoxSizeMode.StretchImage
        Me.ingresot_pic_saveimages.SizeMode = PictureBoxSizeMode.StretchImage
        Me.ingresot_pic_saveimages.Visible = False
        ' # SETEAMOS VALORES DEL TOOLTIP
        Me.ingreso_tp_help.SetToolTip(Me.ingreso_lbl_addcliente, "Presione aquí para agregar un nuevo cliente.")
        Me.ingreso_tp_help.SetToolTip(Me.ingreso_lbl_addmarca, "Presione aquí para ingresar una nueva marca.")
        Me.ingreso_tp_help.SetToolTip(Me.ingreso_lbl_addmodelo, "Presione aquí para agregar un nuevo modelo.")
    End Sub
    Private Sub ingreso_lbl_addcliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ingreso_lbl_addcliente.LinkClicked
        add_cliente.ShowDialog()
    End Sub
    Private Sub ingreso_lbl_addmarca_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ingreso_lbl_addmarca.LinkClicked
        add_marca.ShowDialog()
    End Sub
    Private Sub ingreso_lbl_addtipo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ingreso_lbl_addtipo.LinkClicked
        add_tipo.ShowDialog()
    End Sub
    Private Sub ingreso_lbl_addmodelo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ingreso_lbl_addmodelo.LinkClicked
        add_modelo.ShowDialog()
    End Sub
    Private Sub ingresot_pic_saveot_MouseHover(sender As Object, e As EventArgs) Handles ingresot_pic_saveot.MouseHover
        Me.ingresot_pic_saveot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_hover.png")
    End Sub
    Private Sub ingresot_pic_saveot_MouseLeave(sender As Object, e As EventArgs) Handles ingresot_pic_saveot.MouseLeave
        Me.ingresot_pic_saveot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_normal.png")
    End Sub
    Private Sub ingresot_pic_saveimages_MouseHover(sender As Object, e As EventArgs) Handles ingresot_pic_saveimages.MouseHover
        Me.ingresot_pic_saveimages.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_hover.png")
    End Sub
    Private Sub ingresot_pic_saveimages_MouseLeave(sender As Object, e As EventArgs) Handles ingresot_pic_saveimages.MouseLeave
        Me.ingresot_pic_saveimages.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_normal.png")
    End Sub
    Private Sub ingresot_pn_imgcontainer_Click(sender As Object, e As EventArgs) Handles ingresot_pn_imgcontainer.Click
        ' # FUNCION QUE ABRE EL DIALOGO DE ARCHIVOS PARA LA CARGA DE IMAGENES
        If OTguardada = True Then
            Dim DialogoImagenes As New System.Windows.Forms.OpenFileDialog
            DialogoImagenes.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            DialogoImagenes.Multiselect = True
            DialogoImagenes.Title = "Adjuntar imagenes a la OT!"
            DialogoImagenes.ShowDialog()
        End If
    End Sub
End Class