Imports System.IO
Public Class form_ingreso
    Public imagenes_cargar As New ArrayList
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
        Me.ingresot_lv_imagenes.Visible = False
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
        If Me.ingresot_pic_saveot.Enabled = True Then
            Me.ingresot_pic_saveot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_normal.png")
        Else
            Me.ingresot_pic_saveot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardado.png")
        End If
    End Sub
    Private Sub ingresot_pic_saveimages_MouseHover(sender As Object, e As EventArgs) Handles ingresot_pic_saveimages.MouseHover
        Me.ingresot_pic_saveimages.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_hover.png")
    End Sub
    Private Sub ingresot_pic_saveimages_MouseLeave(sender As Object, e As EventArgs) Handles ingresot_pic_saveimages.MouseLeave
        Me.ingresot_pic_saveimages.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_normal.png")
    End Sub
    Private Sub ingresot_pic_saveot_Click(sender As Object, e As EventArgs) Handles ingresot_pic_saveot.Click
        OTguardada = True
        Me.ingresot_pn_imgcontainer.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_ingreso_images_background_normal.png")
        Me.ingresot_pn_imgcontainer.Cursor = Cursors.Default
        Me.ingresot_pic_saveot.Enabled = False
        Me.ingresot_pic_saveot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardado.png")
    End Sub
    Private Sub ingresot_pn_imgcontainer_Click(sender As Object, e As EventArgs) Handles ingresot_pn_imgcontainer.Click
        ' # FUNCION QUE ABRE EL DIALOGO DE ARCHIVOS PARA LA CARGA DE IMAGENES
        If OTguardada = True Then
            Call CargarImagenes()
        End If
    End Sub
    Private Sub ingresot_lv_imagenes_Click(sender As Object, e As EventArgs)
        If OTguardada = True Then
            Call CargarImagenes()
        End If
    End Sub
    Private Sub ingresot_lv_imagenes_MouseDown(sender As Object, e As MouseEventArgs) Handles ingresot_lv_imagenes.MouseDown
        Dim info As ListViewHitTestInfo = Me.ingresot_lv_imagenes.HitTest(e.X, e.Y)
        ' # OBTENER EL IDENTIFICADOR DEL ITEM ACTIVE info.Item.Index
        If info.Location = 1 Then
            Exit Sub
        End If
        If info.Item.Index = imagenes_cargar.Count - 1 Then
            Call CargarImagenes()
        End If
    End Sub
    Private Sub ingresot_lv_imagenes_MouseHover(sender As Object, e As EventArgs) Handles ingresot_lv_imagenes.MouseHover
        Me.ingresot_lv_imagenes.Cursor = Cursors.Hand
    End Sub
    Private Sub ingresot_lv_imagenes_KeyDown(sender As Object, e As KeyEventArgs) Handles ingresot_lv_imagenes.KeyDown
        MsgBox(Me.ingresot_lv_imagenes.SelectedItems(0).Index)
        If e.KeyCode = Keys.Delete Then
            imagenes_cargar.Remove(imagenes_cargar(Me.ingresot_lv_imagenes.SelectedItems(0).Index))
            Call RefreshImageVisualizer()
        End If
    End Sub
    Private Sub ingresot_lv_imagenes_DoubleClick(sender As Object, e As EventArgs) Handles ingresot_lv_imagenes.DoubleClick
        ' # AL HACER DOBLE CLICK MOSTRAR LA IMAGEN EN GRANDE
        ' # COMPROBAMOS QUE EXISTA EL ARCHIVO ANTES DE HACER LA CARGA
        If File.Exists(imagenes_cargar(Me.ingresot_lv_imagenes.SelectedItems(0).Index).ToString) Then
            Dim VisualizadorImagenes As New imagen_visualizer
            VisualizadorImagenes.visorimagen_pic_image.Image = Image.FromFile(imagenes_cargar(Me.ingresot_lv_imagenes.SelectedItems(0).Index).ToString)
            VisualizadorImagenes.ShowDialog()
        Else
            ' # MOSTRAMOS MENSAJE EN CASO QUE EL LA IMAGEN NO EXISTA
        End If
    End Sub
    Private Sub CargarImagenes()
        Dim Imagenes() As String
        Dim DialogoImagenes As New System.Windows.Forms.OpenFileDialog
        DialogoImagenes.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
        DialogoImagenes.Multiselect = True
        DialogoImagenes.Title = "Adjuntar imagenes a la OT!"
        DialogoImagenes.ShowDialog()
        If DialogoImagenes.FileName <> "" Then
            Imagenes = DialogoImagenes.FileNames
            For Each imagen In Imagenes
                If imagenes_cargar.Contains(imagen) = False Then
                    imagenes_cargar.Add(imagen)
                End If
            Next
            ' # DESPLEGAMOS LISTA DE IMAGENES EN UN LIST VIEW
            Me.ingresot_il_fotos.Images.Clear()
            Me.ingresot_lv_imagenes.Clear()
            Dim MoreFotoObject As String = Application.StartupPath & "/Data/grafica/ingresoot_add_foto.png"
            If imagenes_cargar.Contains(MoreFotoObject) = True Then
                imagenes_cargar.Remove(MoreFotoObject)
            End If
            imagenes_cargar.Add(MoreFotoObject)
            Dim i As Integer = 0
            For Each foto In imagenes_cargar
                Me.ingresot_il_fotos.Images.Add(i, Image.FromFile(foto))
                Me.ingresot_lv_imagenes.Items.Add("", "", i)
                i += 1
            Next
            Me.ingresot_il_fotos.ImageSize = New Size(70, 70)
            Me.ingresot_lv_imagenes.LargeImageList = Me.ingresot_il_fotos
            Me.ingresot_lv_imagenes.View = View.LargeIcon
            Me.ingresot_lv_imagenes.Refresh()
            Me.ingresot_lv_imagenes.Visible = True
            Me.ingresot_pic_saveimages.Visible = True
        End If
    End Sub
    Public Sub RefreshImageVisualizer()
        Me.ingresot_il_fotos.Images.Clear()
        Me.ingresot_lv_imagenes.Clear()
        Dim MoreFotoObject As String = Application.StartupPath & "/Data/grafica/ingresoot_add_foto.png"
        If imagenes_cargar.Contains(MoreFotoObject) = True Then
            imagenes_cargar.Remove(MoreFotoObject)
        End If
        imagenes_cargar.Add(MoreFotoObject)
        Dim i As Integer = 0
        For Each foto In imagenes_cargar
            Me.ingresot_il_fotos.Images.Add(i, Image.FromFile(foto))
            Me.ingresot_lv_imagenes.Items.Add("", "", i)
            i += 1
        Next
    End Sub
End Class