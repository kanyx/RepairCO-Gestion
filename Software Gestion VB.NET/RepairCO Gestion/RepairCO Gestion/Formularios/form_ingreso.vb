Imports System.IO
Imports System.Drawing.Printing

Public Class form_ingreso
    Public imagenes_cargar As New ArrayList
    Private OTguardada As Boolean = False
    Private ValueSource_Prioridad As New Dictionary(Of String, String)()
    Private ValueSource_Tipo As New Dictionary(Of String, String)()
    Private ArchivosLista As New ArrayList
    Private BarCodeString As String = "hola mundo"
    Private Sub form_ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ValueSource_Clientes As New Dictionary(Of String, String)()
        ' # CARGA DE ELEMENTOS FORMULARIO PRINCIPAL
        Me.ingreso_txt_not.Text = PGSQL_GetNumeroOrdenNueva()
        Me.ingresot_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ingreso_ot_title.png")
        Me.ingresot_pic_ot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/not.png")
        Me.ingresot_pn_imgcontainer.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_ingreso_images_background_locked.png")
        Me.ingresot_pic_saveot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_normal.png")
        Me.ingresot_pic_saveimages.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_normal.png")
        Me.ingreso_pic_comentarios.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/comentarios_normal.png")
        Me.ingreso_pic_commenotitle.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_ingreso_commenot.png")
        Me.ingreso_pn_comentarios.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_ingresocommentario_background.png")
        Me.ingreso_pic_commenotclose.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/close.png")
        Me.ingreso_pic_commenotaccept.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
        Me.ingreso_pic_docadd.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_ingreso_atachpdf_background.png")
        Me.ingreso_il_docuico.ImageSize = New Size(48, 48)
        Me.ingreso_il_docuico.Images.Add(0, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/pdf.png"))
        Me.ingreso_il_docuico.ColorDepth = ColorDepth.Depth32Bit
        Me.ingreso_txt_fecha.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        Me.ingreso_lbl_addcliente.Cursor = Cursors.Hand
        Me.ingreso_lbl_addtipo.Cursor = Cursors.Hand
        Me.ingreso_lbl_addmarca.Cursor = Cursors.Hand
        Me.ingreso_lbl_addmodelo.Cursor = Cursors.Hand
        Me.ingresot_pic_saveot.Cursor = Cursors.Hand
        Me.ingresot_pic_saveimages.Cursor = Cursors.Hand
        Me.ingreso_pic_comentarios.Cursor = Cursors.Hand
        Me.ingreso_pic_commenotclose.Cursor = Cursors.Hand
        Me.ingreso_pic_commenotaccept.Cursor = Cursors.Hand
        Me.ingreso_pic_codebar.Cursor = Cursors.Hand
        Me.ingreso_txt_not.ReadOnly = True
        Me.ingresot_pn_imgcontainer.Cursor = Cursors.No
        Me.ingresot_pic_saveot.BackColor = Color.Transparent
        Me.ingresot_pic_saveimages.BackColor = Color.Transparent
        Me.ingreso_pic_commenotclose.BackColor = Color.Transparent
        Me.ingreso_pic_commenotaccept.BackColor = Color.Transparent
        Me.ingreso_pic_docadd.BackColor = Color.Transparent
        Me.ingresot_pic_saveot.SizeMode = PictureBoxSizeMode.StretchImage
        Me.ingreso_pic_commenotitle.BackColor = Color.Transparent
        Me.ingresot_pic_saveimages.SizeMode = PictureBoxSizeMode.StretchImage
        Me.ingreso_pic_comentarios.SizeMode = PictureBoxSizeMode.StretchImage
        Me.ingreso_pic_commenotclose.SizeMode = PictureBoxSizeMode.StretchImage
        Me.ingreso_pic_commenotitle.SizeMode = PictureBoxSizeMode.StretchImage
        Me.ingreso_pic_commenotaccept.SizeMode = PictureBoxSizeMode.StretchImage
        Me.ingresot_pic_saveimages.Visible = False
        Me.ingresot_lv_imagenes.Visible = False
        Me.ingreso_cmb_marca.Enabled = False
        Me.ingreso_cmb_modelo.Enabled = False
        Me.ingreso_pn_comentarios.Visible = False
        Me.ingreso_cmb_ireparable.Enabled = False
        Me.ingreso_tp_atach.Enabled = False
        Me.ingresot_il_fotos.ColorDepth = ColorDepth.Depth32Bit
        ' # SETEAMOS VALORES DEL TOOLTIP
        Me.ingreso_tp_help.SetToolTip(Me.ingreso_lbl_addcliente, "Presione aquí para agregar un nuevo cliente.")
        Me.ingreso_tp_help.SetToolTip(Me.ingreso_lbl_addmarca, "Presione aquí para ingresar una nueva marca.")
        Me.ingreso_tp_help.SetToolTip(Me.ingreso_lbl_addmodelo, "Presione aquí para agregar un nuevo modelo.")
        Me.ingreso_tp_help.SetToolTip(Me.ingreso_pic_comentarios, "Presione aquí para poder añadir un comentario a la orden de trabajo.")
        ' # SETEO DE VALORES Y PARAMETROS DE BASE DE DATOS.
        Me.ingreso_txt_rservicio.Text = _globalUserData(1).ToString.ToUpper & " " & _globalUserData(2).ToString.ToUpper & _
            " " & _globalUserData(3).ToString.ToUpper
        ' # SETEO DE RELLENO DE COMBOBOX.
        ' # -> COMBO BOX PRIORIDAD
        ValueSource_Prioridad.Add("", "ESTABLECER PRIORIDAD")
        ValueSource_Prioridad.Add("1", "BAJA")
        ValueSource_Prioridad.Add("2", "MEDIA")
        ValueSource_Prioridad.Add("3", "ALTA")
        Me.ingresot_cmb_prioridad.DataSource = New BindingSource(ValueSource_Prioridad, Nothing)
        Me.ingresot_cmb_prioridad.DisplayMember = "Value"
        Me.ingresot_cmb_prioridad.ValueMember = "Key"
        ' # -> COMBO BOX TIPO DE PRODUCTO
        ValueSource_Tipo.Add("", "SELECCIONE TIPO")
        If _globalTipos.Count > 0 Then
            For Each TipoValue As KeyValuePair(Of String, String) In _globalTipos
                ValueSource_Tipo.Add(TipoValue.Key, TipoValue.Value.ToUpper)
            Next
        End If
        Me.ingreso_cmb_tipo.DataSource = New BindingSource(ValueSource_Tipo, Nothing)
        Me.ingreso_cmb_tipo.DisplayMember = "Value"
        Me.ingreso_cmb_tipo.ValueMember = "Key"
        ' # COMBOBOX CLIENTES
        Call PGSQL_CargaClientes()
        ValueSource_Clientes.Add("", "SELECCIONE CLIENTE")
        If _globalClientes.Count > 0 Then
            For Each TipoValue As KeyValuePair(Of String, String) In _globalClientes
                ValueSource_Clientes.Add(TipoValue.Key, TipoValue.Value.ToUpper)
            Next
        End If
        Me.ingreso_cmb_cliente.DataSource = New BindingSource(ValueSource_Clientes, Nothing)
        Me.ingreso_cmb_cliente.DisplayMember = "Value"
        Me.ingreso_cmb_cliente.ValueMember = "Key"
        Me.ingreso_cmb_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.ingreso_cmb_cliente.AutoCompleteSource = AutoCompleteSource.ListItems
        ' # GENERACION DE CODIGO DE BARRA.
        Dim CodeBar As Bitmap = Nothing
        CodeBar = BarCode.Code128("OT-000" & Me.ingreso_txt_not.Text, BarCode.Code128SubTypes.CODE128_UCC, True, Convert.ToSingle(38))
        If Not IsNothing(CodeBar) Then
            Me.ingreso_pic_codebar.Image = CodeBar
        End If
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
        ' # CONTINUAMOS CON EL PROCEDIMIENTO DE CARGA DE LA APLICACION.
        Dim TipoOT As Integer
        If Me.ingreso_rb_presupuesto.Checked = False And Me.ingreso_rb_garantia.Checked = False Then
            OTguardada = False
            Exit Sub
        End If
        If Me.ingreso_cmb_cliente.SelectedValue = "" Then
            Me.ingreso_cmb_cliente.BackColor = Color.Red
            Me.ingreso_cmb_cliente.ForeColor = Color.White
            Exit Sub
        Else
            Me.ingreso_cmb_cliente.BackColor = Color.Green
            Me.ingreso_cmb_cliente.ForeColor = Color.White
        End If
        If Me.ingreso_txt_guia.Text = "" Or Me.ingreso_txt_guia.TextLength < 3 Then
            Me.ingreso_txt_guia.BackColor = Color.Red
            Me.ingreso_txt_guia.ForeColor = Color.White
            Exit Sub
        Else
            Me.ingreso_txt_guia.BackColor = Color.Green
            Me.ingreso_txt_guia.ForeColor = Color.White
        End If
        If Me.ingreso_txt_iequipo.Text = "" Or Me.ingreso_txt_iequipo.TextLength < 4 Then
            Me.ingreso_txt_iequipo.BackColor = Color.Red
            Me.ingreso_txt_iequipo.ForeColor = Color.White
            Exit Sub
        Else
            Me.ingreso_txt_iequipo.BackColor = Color.Green
            Me.ingreso_txt_iequipo.ForeColor = Color.White
        End If
        If Me.ingreso_cmb_tipo.SelectedValue = "" Then
            Me.ingreso_cmb_tipo.BackColor = Color.Red
            Me.ingreso_cmb_tipo.ForeColor = Color.White
            Exit Sub
        Else
            Me.ingreso_cmb_tipo.BackColor = Color.Green
            Me.ingreso_cmb_tipo.ForeColor = Color.White
        End If
        If Me.ingreso_cmb_cliente.SelectedValue = 21 Then
            If Me.ingreso_txt_agendamiento.Text = "" Or Me.ingreso_txt_agendamiento.TextLength < 3 Then
                Me.ingreso_txt_agendamiento.BackColor = Color.Red
                Me.ingreso_txt_agendamiento.ForeColor = Color.White
                Exit Sub
            Else
                Me.ingreso_txt_agendamiento.BackColor = Color.Green
                Me.ingreso_txt_agendamiento.ForeColor = Color.White
            End If
        End If
        If Trim(Me.ingreso_cmb_tipo.SelectedText.ToLower) <> "valvula" Then
            ' # COMPROBAMOS LOS CAMPOS MARCA Y MODELO EN CASO DE NO SER VALVULA
            ' # SEGUN INTSTRUCCIONES EN CASO DE SELECCIONAR VALVULA ESTOS CAMPOS NO SON NECESARIOS.
            If Me.ingreso_cmb_marca.SelectedValue = "" Then
                Me.ingreso_cmb_marca.BackColor = Color.Red
                Me.ingreso_cmb_marca.ForeColor = Color.White
                Exit Sub
            Else
                Me.ingreso_cmb_marca.BackColor = Color.Green
                Me.ingreso_cmb_marca.ForeColor = Color.White
            End If
            If Me.ingreso_cmb_modelo.SelectedValue = "" Then
                Me.ingreso_cmb_modelo.BackColor = Color.Red
                Me.ingreso_cmb_modelo.ForeColor = Color.White
                Exit Sub
            Else
                Me.ingreso_cmb_modelo.BackColor = Color.Green
                Me.ingreso_cmb_modelo.ForeColor = Color.White
            End If
            If Me.ingreso_txt_nserie.Text = "" Then
                Me.ingreso_txt_nserie.BackColor = Color.Red
                Me.ingreso_txt_nserie.ForeColor = Color.White
                Exit Sub
            Else
                Me.ingreso_txt_nserie.BackColor = Color.Green
                Me.ingreso_txt_nserie.ForeColor = Color.White
            End If
        End If
        If Me.ingresot_cmb_prioridad.SelectedValue = "" Then
            Me.ingresot_cmb_prioridad.BackColor = Color.Red
            Me.ingresot_cmb_prioridad.ForeColor = Color.White
            Exit Sub
        Else
            Me.ingresot_cmb_prioridad.BackColor = Color.Green
            Me.ingresot_cmb_prioridad.ForeColor = Color.White
        End If
        If Me.ingreso_rb_garantia.Checked = True Then
            TipoOT = 2
        ElseIf Me.ingreso_rb_presupuesto.Checked = True Then
            TipoOT = 1
        End If
        If Me.ingreso_txt_commenotcomm.Text = "" Or Me.ingreso_txt_commenotcomm.TextLength < 3 Then
            If MessageBox.Show("¿Está seguro que desea generar la orden de trabajo sin ningún tipo de comentario adicional?", _
                            Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Me.ingreso_txt_commenotrc.ReadOnly = True
                Me.ingreso_txt_commenotrc.Text = Me.ingreso_txt_rservicio.Text
                Me.ingreso_pn_comentarios.Location = New Point(110, 90)
                Me.ingreso_pn_comentarios.Visible = True
                Exit Sub
            End If
        End If
        If Me.ingreso_cmb_ireparable.SelectedValue = "" Then
            Me.ingreso_cmb_ireparable.BackColor = Color.Red
            Me.ingreso_cmb_ireparable.ForeColor = Color.White
            Exit Sub
        Else
            Me.ingreso_cmb_ireparable.BackColor = Color.Green
            Me.ingreso_cmb_ireparable.ForeColor = Color.White
        End If
        If PGSQL_INGRESO_ADDOT(Date.Parse(Me.ingreso_txt_fecha.Text), Me.ingresot_cmb_prioridad.SelectedText, TipoOT, Me.ingreso_cmb_cliente.SelectedValue.ToString, Me.ingreso_txt_guia.Text, _
                               Me.ingreso_txt_oc.Text, Me.ingreso_txt_iequipo.Text, Me.ingreso_txt_nserie.Text, Me.ingresot_txt_nseriefat.Text, Me.ingresot_txt_ncontrato.Text, _
                               Integer.Parse(Me.ingreso_cmb_tipo.SelectedValue), Integer.Parse(Me.ingreso_cmb_marca.SelectedValue), Integer.Parse(Me.ingreso_cmb_modelo.SelectedValue), _
                               Integer.Parse(Me.ingreso_txt_not.Text), Me.ingreso_txt_agendamiento.Text, Me.ingreso_txt_commenotcomm.Text, Me.ingreso_txt_iequipo.Text, Me.ingreso_cmb_ireparable.SelectedValue) = True Then
            OTguardada = True
            Me.ingreso_tp_atach.Enabled = True
            Me.ingresot_pn_imgcontainer.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_ingreso_images_background_normal.png")
            Me.ingresot_pn_imgcontainer.Cursor = Cursors.Default
            Me.ingresot_pic_saveot.Enabled = False
            Me.ingresot_pic_saveot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardado.png")
            MessageBox.Show("Orden de trabajo ingresada al sistema exitosamente.", Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Exit Sub
        End If
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
    Private Sub NewFormulario()
        ' # CUANDO SE TERMINA DE INGRESAR UNA ORDEN DE TRABAJO LIMPIA EL FORMULARIO.
        Dim Frm_RecepcionIngreso As New form_ingreso
        Frm_RecepcionIngreso.MdiParent = main_application
        Frm_RecepcionIngreso.ShowInTaskbar = False
        Frm_RecepcionIngreso.StartPosition = FormStartPosition.Manual
        Frm_RecepcionIngreso.Left += 260
        Frm_RecepcionIngreso.Height = main_application.ClientSize.Height * 0.929
        Frm_RecepcionIngreso.Width = main_application.ClientSize.Width * 0.8
        Frm_RecepcionIngreso.Show()
        Me.Close()
    End Sub
    Public Sub RefreshTipos()
        ' # ACTUALIZAR LA LISTA DE TIPOS DE PRODUCTOS
    End Sub
    Private Sub ingresot_cmb_prioridad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ingresot_cmb_prioridad.SelectedIndexChanged
        'Dim key As String = DirectCast(Me.ingresot_cmb_prioridad.SelectedItem, KeyValuePair(Of String, String)).Key
        'Dim value As String = DirectCast(Me.ingresot_cmb_prioridad.SelectedItem, KeyValuePair(Of String, String)).Value
        'MessageBox.Show(key & "   " & value)
    End Sub
    Private Sub ingreso_cmb_tipo_SelectedValueChanged(sender As Object, e As EventArgs) Handles ingreso_cmb_tipo.SelectedValueChanged
        ' # AL CAMBIAR EL TIPO DE PRODUCTO HABILITAMOS LA SECCION DE MARCAS DEL FORMULARIO.
        If Me.ingreso_cmb_tipo.SelectedIndex > 0 Then
            Me.ingreso_cmb_marca.Enabled = True
            Call PGSQL_CargaMarcas(Me.ingreso_cmb_tipo.SelectedValue)
            Dim ValueSource_Marcas As New Dictionary(Of String, String)()
            ValueSource_Marcas.Add("", "SELECCIONE MARCA")
            If _globalMarcas Is Nothing Then
                Me.ingreso_cmb_marca.Enabled = False
                Exit Sub
            End If
            If _globalMarcas.Count > 0 Then
                For Each TipoValue As KeyValuePair(Of String, String) In _globalMarcas
                    ValueSource_Marcas.Add(TipoValue.Key, TipoValue.Value.ToUpper)
                Next
            End If
            Me.ingreso_cmb_marca.DataSource = New BindingSource(ValueSource_Marcas, Nothing)
            Me.ingreso_cmb_marca.DisplayMember = "Value"
            Me.ingreso_cmb_marca.ValueMember = "Key"
            Me.ingreso_cmb_marca.AutoCompleteMode = AutoCompleteMode.Suggest
            Me.ingreso_cmb_marca.AutoCompleteSource = AutoCompleteSource.ListItems
        End If
    End Sub
    Private Sub ingreso_cmb_marca_SelectedValueChanged(sender As Object, e As EventArgs) Handles ingreso_cmb_marca.SelectedValueChanged
        ' # AL SELECCIONAR UNA MARCA DE UN PRODUCTO PROCEDEMOS A CARGAR LOS MODELOS ASOCIADOS AL PRODUCTO.
        If Me.ingreso_cmb_marca.SelectedIndex > 0 Then
            Me.ingreso_cmb_modelo.Enabled = True
            Call PGSQL_CargaModelos(Me.ingreso_cmb_tipo.SelectedValue, Me.ingreso_cmb_marca.SelectedValue)
            Dim ValueSource_Modelos As New Dictionary(Of String, String)()
            ValueSource_Modelos.Add("", "SELECCIONE MODELO")
            If _globalModelos Is Nothing Then
                Me.ingreso_cmb_modelo.Enabled = False
                Exit Sub
            End If
            If _globalModelos.Count > 0 Then
                For Each TipoValue As KeyValuePair(Of String, String) In _globalModelos
                    ValueSource_Modelos.Add(TipoValue.Key, TipoValue.Value.ToUpper)
                Next
            End If
            Me.ingreso_cmb_modelo.DataSource = New BindingSource(ValueSource_Modelos, Nothing)
            Me.ingreso_cmb_modelo.DisplayMember = "Value"
            Me.ingreso_cmb_modelo.ValueMember = "Key"
            Me.ingreso_cmb_modelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.ingreso_cmb_modelo.AutoCompleteSource = AutoCompleteSource.ListItems
        End If
    End Sub
    Private Sub ingreso_cmb_cliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles ingreso_cmb_cliente.SelectedValueChanged
        ' # ING. REPARABLE, AQUI SE CARGARAN LOS VALORES CORRESPONDIENTES AL INGENIERO REPARABLE UMA VEZ QUE SE HA 
        ' # SELECCIONADO EL CLIENTE.
        If Me.ingreso_cmb_cliente.SelectedIndex > 0 Then
            Me.ingreso_cmb_ireparable.Enabled = True
            Dim ValueSource_IngReparable As New Dictionary(Of String, String)()
            ValueSource_IngReparable = PGSQL_CargaIngReparable(Me.ingreso_cmb_cliente.SelectedValue.ToString, True)
            If ValueSource_IngReparable Is Nothing Then
                Me.ingreso_cmb_ireparable.Enabled = False
                Exit Sub
            End If
            Me.ingreso_cmb_ireparable.DataSource = New BindingSource(ValueSource_IngReparable, Nothing)
            Me.ingreso_cmb_ireparable.DisplayMember = "Value"
            Me.ingreso_cmb_ireparable.ValueMember = "Key"
        End If
    End Sub
    Private Sub ingreso_pic_comentarios_MouseMove(sender As Object, e As MouseEventArgs) Handles ingreso_pic_comentarios.MouseMove
        Me.ingreso_pic_comentarios.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/comentarios_hover.png")
    End Sub
    Private Sub ingreso_pic_comentarios_MouseLeave(sender As Object, e As EventArgs) Handles ingreso_pic_comentarios.MouseLeave
        Me.ingreso_pic_comentarios.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/comentarios_normal.png")
    End Sub
    Private Sub ingreso_pic_comentarios_Click(sender As Object, e As EventArgs) Handles ingreso_pic_comentarios.Click
        Me.ingreso_txt_commenotrc.ReadOnly = True
        Me.ingreso_txt_commenotrc.Text = Me.ingreso_txt_rservicio.Text
        Me.ingreso_pn_comentarios.Location = New Point(110, 90)
        Me.ingreso_pn_comentarios.Visible = True
    End Sub
    Private Sub ingreso_pic_commenotclose_Click(sender As Object, e As EventArgs) Handles ingreso_pic_commenotclose.Click
        Me.ingreso_pn_comentarios.Visible = False
    End Sub
    Private Sub ingreso_pic_commenotaccept_MouseHover(sender As Object, e As EventArgs) Handles ingreso_pic_commenotaccept.MouseHover
        Me.ingreso_pic_commenotaccept.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_hover.png")
    End Sub
    Private Sub ingreso_pic_commenotaccept_MouseLeave(sender As Object, e As EventArgs) Handles ingreso_pic_commenotaccept.MouseLeave
        Me.ingreso_pic_commenotaccept.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
    End Sub
    Private Sub ingreso_pic_commenotaccept_Click(sender As Object, e As EventArgs) Handles ingreso_pic_commenotaccept.Click
        If ingreso_txt_commenotcomm.Text = "" Or Me.ingreso_txt_commenotcomm.TextLength < 7 Then
            Me.ingreso_txt_commenotcomm.BackColor = Color.Red
            Me.ingreso_txt_commenotcomm.ForeColor = Color.White
            Exit Sub
        Else
            Me.ingreso_txt_commenotcomm.BackColor = Color.Green
            Me.ingreso_txt_commenotcomm.ForeColor = Color.White
        End If
        If PGSQL_CargaComentariosOT(Me.ingreso_txt_not.Text) = "" And PGSQL_ExisteOT(Me.ingreso_txt_not.Text) = True Then

        End If
        Me.ingreso_pn_comentarios.Visible = False
    End Sub
    Private Sub ingresot_pic_saveimages_Click(sender As Object, e As EventArgs) Handles ingresot_pic_saveimages.Click
        ' # FUNCION PARA GUARDAR LAS IMAGENES DE LA ORDEN DE TRABAJO
        ' # IMPORTANTE: ES IMPORTANTE COMPROBAR QUE EXISTA LA IMAGEN Y VERIFICAR BIEN EL CONTENIDO DEL ARRAYLIST ANTES DE 
        ' # PROCEDER A LAS FUNCIONES DE TRATAMIENTO DE IMAGENES PARA PODER EVITAR UNA FALLA EN LA EJECUCION DEL SOFTWARE.
        If imagenes_cargar.Count <> 0 Then
            If IMAGE_SAVEOT(imagenes_cargar, Me.ingreso_txt_not.Text) = True Then
                ' # MENSAJE CUANDO LAS FOTOS SE CARGAN EXITOSAMENTE
                If MessageBox.Show("Fotografías de la orden de trabajo ingresadas exitosamente, finalizo el proceso de ingreso de orden de trabajo." & vbNewLine & "¿Desea la orden de trabajo en PDF para su impresión?", _
                                Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                    If REPORTES_GENERAOT(Me.ingreso_txt_not.Text) = True Then
                        ' # COMPROBAMOS QUE EL ARCHIVO HAYA SIDO CREADO Y PROCEDEMOS A ABRIRLO
                        If File.Exists(Application.StartupPath & "/Data/_temp/" & Me.ingreso_txt_not.Text & ".pdf") Then
                            Process.Start(Application.StartupPath & "/Data/_temp/" & Me.ingreso_txt_not.Text & ".pdf")
                        End If
                    End If
                    NewFormulario()
                Else
                    NewFormulario()
                End If
            End If
        End If
    End Sub
    Private Sub ingreso_rb_presupuesto_CheckedChanged(sender As Object, e As EventArgs) Handles ingreso_rb_presupuesto.CheckedChanged
        ' # EN CASO QUE EL USUARIO MARQUE EL USUARIO MARQUE LA OPCION DE REPARACION AUTOMATICAMENTE SE PROCEDE
        ' # A COMPLETAR EL CAMPO N° SERIE REPAIRCO CON OT - AÑO ACTUAL.
        Me.ingreso_txt_nserie.Text = ingreso_txt_not.Text & "-" & Date.Now.Year
    End Sub
    ' ##############################################################################################################
    ' # ~~~~~~~~~~~~~~~~~~~~~~~~~~~~ FUNCION PARA EL MANEJO DE DOCUMENTOS ADJUNTOS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ #
    ' ##############################################################################################################
    ' # FUNCIONES ENCARGADAS DE GESTIONAR EL ADJUNTAMIENTO DE ARCHIVOS A LA ORDEN DE TRABAJO.                      #
    ' ##############################################################################################################
    Private Sub ingreso_pic_docadd_Click(sender As Object, e As EventArgs) Handles ingreso_pic_docadd.Click
        ' # ESTE PICTUREBOX SOLO ESTA PARA QUE EL USUARIO PUEDA HACER CLICK Y SE LE HABRA EL CUADRO DE DIALOGO DE ARCHIVOS.
        Dim DialogoArchivos As New System.Windows.Forms.OpenFileDialog
        Dim Archivos As String()
        DialogoArchivos.Filter = "Documentos PDF (*.pdf)|*.pdf"
        DialogoArchivos.Multiselect = True
        DialogoArchivos.Title = "Adjuntar archivos a la OT!"
        DialogoArchivos.ShowDialog()
        If DialogoArchivos.FileName <> "" Then
            ' # SI AGREGO ARCHIVOS PROCEDEMOS A OCULTAR EL PICTUREBOX INTERACTIVO.
            Me.ingreso_pic_docadd.Visible = False
            Archivos = DialogoArchivos.FileNames
            For Each Archivo In Archivos
                Dim infoFile As FileInfo = New FileInfo(Archivo)
                If infoFile.Extension = ".pdf" Or infoFile.Extension = ".PDF" Then
                    If ArchivosLista.Contains(main_loggin.ParametrosConfiguracion(5).ToString & Me.ingreso_txt_not.Text & "\" & infoFile.Name) = False Then
                        If MISC_FILECOPY(Archivo, main_loggin.ParametrosConfiguracion(5).ToString & Me.ingreso_txt_not.Text & "\" & infoFile.Name, Me.ingreso_txt_not.Text) Then
                            ArchivosLista.Add(main_loggin.ParametrosConfiguracion(5).ToString & Me.ingreso_txt_not.Text & "\" & infoFile.Name)
                        End If
                    End If
                End If
            Next
            Dim Elevacion As New UserImpersonation
            Elevacion.impersonateUser(_globalSAMBAU, "", _globalSAMBAP)
            ' # PREPARAMOS EL LISTVIEW
            Me.ingreso_lv_documentos.LargeImageList = Me.ingreso_il_docuico
            Me.ingreso_lv_documentos.View = View.LargeIcon
            If ArchivosLista.Count > 0 Then
                ' # AÑADIMOS NUEVOS ARCHIVOS EN CASO QUE NO EXISTAN.
                For Each pdf In ArchivosLista
                    Dim infoFile As FileInfo = New FileInfo(pdf)
                    Me.ingreso_lv_documentos.Items.Add(infoFile.Name, 0)
                Next
                Me.ingreso_lv_documentos.Refresh()
            End If
            Elevacion.undoimpersonateUser()
        End If
    End Sub
    Private Sub ingreso_lv_documentos_DoubleClick(sender As Object, e As EventArgs) Handles ingreso_lv_documentos.DoubleClick
        Call MISC_EXECUTEFILE(main_loggin.ParametrosConfiguracion(5).ToString & Me.ingreso_txt_not.Text & "/" & ingreso_lv_documentos.SelectedItems(0).Text)
    End Sub
    Private Sub ingreso_pic_codebar_Click(sender As Object, e As EventArgs) Handles ingreso_pic_codebar.Click
        ' # AL PRESIONAR ESTE BOTON IMPRIMIR LA ETIQUETA Y ABRIR LOS CUADROS DE DIALOGOS.
        If Me.ingreso_cmb_tipo.SelectedValue = "" Or Me.ingreso_cmb_marca.SelectedValue = "" Or Me.ingreso_cmb_modelo.SelectedValue = "" Then
            MessageBox.Show("Para poder generar el código de barras debe seleccionar Tipo, marca y modelo del equipo.", Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        BarCodeString = Me.ingreso_cmb_tipo.Text & " " & Me.ingreso_cmb_marca.Text & " - " & Me.ingreso_cmb_modelo.Text
        If MessageBox.Show("¿Desea imprimir el código de barra generado para esta orden de trabajo?", Application.ProductName & " - " & _
                           Application.ProductVersion, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim xCustomSize As New PaperSize("CodeBar", 390, 188)
            Me.ingreso_print_dialogo.Document = Me.ingreso_print_documento
            If Me.ingreso_print_dialogo.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.ingreso_print_documento.DefaultPageSettings.PaperSize = xCustomSize
                Me.ingreso_print_documento.Print()
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub
    Private Sub ingreso_print_documento_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles ingreso_print_documento.PrintPage
        ' # CONFIGURACION DE HOJA DE IMPRESION PARA EL CODIGO DE BARRAS.
        Dim drawFont As New Font("Arial", 8, FontStyle.Bold)
        Dim Lapiz As New Pen(Color.Black, 3)
        Dim l1p1 As New Point(10, 43)
        Dim l1p2 As New Point(380, 43)
        Dim LogoRepairco As New PictureBox
        LogoRepairco.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\logo_barcode.png")
        LogoRepairco.Size = New Size(120, 30)
        LogoRepairco.SizeMode = PictureBoxSizeMode.StretchImage
        e.Graphics.DrawImage(LogoRepairco.Image, 10, 10)
        e.Graphics.DrawLine(Lapiz, l1p1, l1p2)
        If BarCodeString.Length < 35 Then
            e.Graphics.DrawString(BarCodeString, drawFont, Brushes.Black, 80, 75)
        ElseIf BarCodeString.Length > 34 And BarCodeString.Length < 60 Then
            e.Graphics.DrawString(BarCodeString, drawFont, Brushes.Black, 60, 75)
        Else
            e.Graphics.DrawString(BarCodeString, drawFont, Brushes.Black, 10, 75)
        End If
        e.Graphics.DrawImage(Me.ingreso_pic_codebar.Image, 120, 90)
    End Sub
End Class