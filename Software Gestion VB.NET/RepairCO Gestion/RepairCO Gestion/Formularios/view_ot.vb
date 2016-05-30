Public Class view_ot
    Dim ImagesOrdenes As New ArrayList
    Public NumeroOrdenTrabajo As String
    Private ArchivosLista As New Dictionary(Of String, String)
    Private Sub view_ot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DatosOT As New ArrayList
        Dim DatosPersonal As New ArrayList
        Dim DatosCliente As New ArrayList
        Dim DatosTipo As New ArrayList
        Dim DatosMarca As New ArrayList
        Dim DatosModelo As New ArrayList
        Dim DatosIngeniero As New ArrayList
        Dim ValueSource_Tipo As New Dictionary(Of String, String)()
        ' # CARGA PRINCIPAL DEL VISOR DE ORDENES DE TRABAJO
        ' # RECORDAR QUE TODOS LOS CONTROLES EN PRIMERA INSTANCIA TIENES QUE ESTAR DESABILITADOS.
        Me.viewot_gb_datos.Enabled = False
        Me.viewot_gb_tipoot.Enabled = False
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_viewerot_background.png")
        Me.viewot_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_visorot_title.png")
        Me.viewot_pic_close.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/close.png")
        Me.viewot_pic_ot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/not.png")
        Me.viewot_pic_save.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_normal.png")
        Me.viewot_pic_edit.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/editar.png")
        Me.viewot_pic_pdf.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/pdf.png")
        Me.viewot_cmb_prioridad.Items.Add("ALTA")
        Me.viewot_cmb_prioridad.Items.Add("MEDIA")
        Me.viewot_cmb_prioridad.Items.Add("BAJA")
        ' # CARGA CONFIGURACION DE CONTROLES DEL FORMULARIO.
        Me.viewot_il_documentos.ImageSize = New Size(48, 48)
        Me.viewot_lbl_ot.ForeColor = ColorTranslator.FromHtml("#b88d00")
        Me.viewot_pic_title.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_save.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_pdf.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_edit.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_close.Cursor = Cursors.Hand
        Me.viewot_pic_save.Cursor = Cursors.Hand
        Me.viewot_pic_pdf.Cursor = Cursors.Hand
        Me.viewot_pic_edit.Cursor = Cursors.Hand
        Me.viewot_pic_save.Visible = False
        Me.viewot_lw_imagenes.Visible = False
        Me.viewot_dg_comentarios.EnableHeadersVisualStyles = False
        Me.viewot_pic_edit.BackColor = Color.Transparent
        Me.viewot_pic_pdf.BackColor = Color.Transparent
        ' # LLAMAMOS LOS DATOS DE LA ORDEN LA INTRODUCIMOS A UN ARRAY Y LLENAMOS LOS VALORES DEL FORMULARIO.
        DatosOT = PGSQL_CargaOT(NumeroOrdenTrabajo)
        DatosPersonal = PGSQL_GETPERSONALDATES(DatosOT(16).ToString)
        DatosCliente = PGSQL_GETCLIENTINFO(DatosOT(2).ToString)
        DatosTipo = PGSQL_GETTIPOINFO(DatosOT(3).ToString)
        DatosMarca = PGSQL_GETMARCAINFO(DatosOT(4).ToString)
        DatosModelo = PGSQL_GETMODELOINFO(DatosOT(5).ToString)
        DatosIngeniero = PGSQL_GETINGREPAINFO(DatosOT(18).ToString)
        Me.viewot_lbl_ot.Text = DatosOT(0)
        Me.viewot_txt_ringreso.Text = DatosPersonal(1).ToString.ToUpper & " " & DatosPersonal(2).ToString.ToUpper & " " & DatosPersonal(3).ToString.ToUpper
        Me.viewot_txt_fecha.Value = DatosOT(9)
        Me.viewot_txt_gdespacho.Text = DatosOT(1)
        Me.viewot_txt_oc.Text = DatosOT(14)
        Me.viewot_txt_agenda.Text = DatosOT(15)
        Me.viewot_txt_tag.Text = DatosOT(17)
        Me.viewot_txt_nserie.Text = DatosOT(6)
        Me.viewot_txt_nserief.Text = DatosOT(10)
        Me.viewot_txt_ncontrato.Text = DatosOT(8)
        Dim ValueSource_Clientes As New Dictionary(Of String, String)()
        Call PGSQL_CargaClientes()
        If _globalClientes.Count > 0 Then
            For Each TipoValue As KeyValuePair(Of String, String) In _globalClientes
                ValueSource_Clientes.Add(TipoValue.Key, TipoValue.Value.ToUpper)
            Next
        End If
        If DatosOT(7).ToString <> "" Then
            Dim SelecIndPrioridad As Integer = Me.viewot_cmb_prioridad.FindString(DatosOT(7).ToString)
            Me.viewot_cmb_prioridad.SelectedIndex = SelecIndPrioridad
        Else
            Me.viewot_cmb_prioridad.Text = "SELECCIONE PRIORIDAD."
        End If
        If DatosOT(13) = "1" Then
            Me.viewot_rb_reparacion.Checked = True
        ElseIf DatosOT(13) = "2" Then
            Me.viewot_rb_garantia.Checked = True
        End If
        Me.viewot_cmb_cliente.DataSource = New BindingSource(ValueSource_Clientes, Nothing)
        Me.viewot_cmb_cliente.DisplayMember = "Value"
        Me.viewot_cmb_cliente.ValueMember = "Key"
        If DatosOT(2).ToString <> "" Then
            Dim SelecIndCliente As Integer = Me.viewot_cmb_cliente.FindString(DatosCliente(1).ToString)
            Me.viewot_cmb_cliente.SelectedIndex = SelecIndCliente
        Else
            Me.viewot_cmb_cliente.Text = "SELECCIONE CLIENTE."
        End If
        If _globalTipos.Count > 0 Then
            For Each TipoValue As KeyValuePair(Of String, String) In _globalTipos
                ValueSource_Tipo.Add(TipoValue.Key, TipoValue.Value.ToUpper)
            Next
        End If
        Me.viewot_cmb_tipo.DataSource = New BindingSource(ValueSource_Tipo, Nothing)
        Me.viewot_cmb_tipo.DisplayMember = "Value"
        Me.viewot_cmb_tipo.ValueMember = "Key"
        If DatosOT(3) <> "" Then
            Dim SelectIndTipo As Integer = Me.viewot_cmb_tipo.FindString(DatosTipo(1).ToString)
            Me.viewot_cmb_tipo.SelectedIndex = SelectIndTipo
        Else
            Me.viewot_cmb_tipo.Text = "SELECCIONE TIPO."
        End If
        Call PGSQL_CargaMarcas(DatosOT(3).ToString)
        Dim ValueSource_Marcas As New Dictionary(Of String, String)()
        If _globalMarcas.Count > 0 Then
            For Each TipoValue As KeyValuePair(Of String, String) In _globalMarcas
                ValueSource_Marcas.Add(TipoValue.Key, TipoValue.Value.ToUpper)
            Next
        End If
        Me.viewot_cmb_marca.DataSource = New BindingSource(ValueSource_Marcas, Nothing)
        Me.viewot_cmb_marca.DisplayMember = "Value"
        Me.viewot_cmb_marca.ValueMember = "Key"
        If DatosOT(4) <> "" Then
            Dim SelectIndMarca As Integer = Me.viewot_cmb_marca.FindString(DatosMarca(1).ToString)
            Me.viewot_cmb_marca.SelectedIndex = SelectIndMarca
        Else
            Me.viewot_cmb_marca.Text = "SELECCIONE MARCA."
        End If
        Call PGSQL_CargaModelos(DatosOT(3).ToString, DatosOT(4).ToString)
        Dim ValueSource_Modelos As New Dictionary(Of String, String)()
        If _globalModelos.Count > 0 Then
            For Each TipoValue As KeyValuePair(Of String, String) In _globalModelos
                ValueSource_Modelos.Add(TipoValue.Key, TipoValue.Value.ToUpper)
            Next
        End If
        Me.viewot_cmb_modelo.DataSource = New BindingSource(ValueSource_Modelos, Nothing)
        Me.viewot_cmb_modelo.DisplayMember = "Value"
        Me.viewot_cmb_modelo.ValueMember = "Key"
        If DatosOT(5) <> "" Then
            Dim SelecIndModelo As Integer = Me.viewot_cmb_modelo.FindString(DatosModelo(1).ToString)
            Me.viewot_cmb_modelo.SelectedIndex = SelecIndModelo
        Else
            Me.viewot_cmb_modelo.Text = "SELECCIONE MODELO."
        End If
        Dim ValueSource_IngReparable As New Dictionary(Of String, String)()
        ValueSource_IngReparable = PGSQL_CargaIngReparable(DatosOT(2).ToString, True)
        Me.viewot_cmb_ireparable.DataSource = New BindingSource(ValueSource_IngReparable, Nothing)
        Me.viewot_cmb_ireparable.DisplayMember = "Value"
        Me.viewot_cmb_ireparable.ValueMember = "Key"
        If DatosOT(18) <> "" Then
            Dim SelecIndIngeniero As Integer = Me.viewot_cmb_ireparable.FindString(DatosIngeniero(1).ToString)
            Me.viewot_cmb_ireparable.SelectedIndex = SelecIndIngeniero
        Else
            Me.viewot_cmb_ireparable.Text = "SELECCIONE ING. REPARABLE."
        End If
        ' # VERIFICAMOS SI LA ORDEN DE TRABAJO INCLUYE IMAGENES, SI ES ASI CARAGMOS EL MODULO DE IMAGENES.
        ' # EN CASO CONTRARIO DESPLEGAMOS UN AVISO DE NO EXISTENCIA DE IMAGENES.
        ImagesOrdenes = PGSQL_CargaImagenesOT(NumeroOrdenTrabajo, 100)
        If ImagesOrdenes.Count > 0 Then
            ' # SI EXISTEN IMAGENES.
            Dim impersonateUser As New UserImpersonation
            impersonateUser.impersonateUser("software", "", "gestion2016")
            Me.viewot_lw_imagenes.Visible = True
            Dim i As Integer = 0
            Me.viewot_il_imagelist.ColorDepth = ColorDepth.Depth32Bit
            For Each foto In ImagesOrdenes
                Me.viewot_il_imagelist.Images.Add(i, Image.FromFile(main_loggin.ParametrosConfiguracion(5).ToString & NumeroOrdenTrabajo & "\" & foto))
                Me.viewot_lw_imagenes.Items.Add("", "", i)
                i += 1
            Next
            Me.viewot_il_imagelist.ImageSize = New Size(70, 70)
            Me.viewot_lw_imagenes.LargeImageList = Me.viewot_il_imagelist
            Me.viewot_lw_imagenes.View = View.LargeIcon
            Me.viewot_lw_imagenes.Refresh()
            impersonateUser.undoimpersonateUser()
        Else
            ' # SI NO EXISTEN IMAGENES.
            Me.viewot_tabpage_foto.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/viewot_nofoto.png")
        End If
        ' # CARGAMOS LOS COMENTARIOS DE LA ORDEN DE TRABAJO.
        Call PGSQL_GETCOMENTARIOSOT(NumeroOrdenTrabajo, Me.viewot_dg_comentarios)
        Me.viewot_dg_comentarios.Columns("id").Width = 30
        Me.viewot_dg_comentarios.Columns("fecha").Width = 60
        Me.viewot_dg_comentarios.Columns("hora").Width = 60
        Me.viewot_dg_comentarios.Columns("comentario").Width = 360
        Me.viewot_dg_comentarios.Columns("usuario").Width = 240
        ' # CARGAMOS ICONOS AL IL DEL LECTOR DE DOCUMENTOS.
        Me.viewot_il_documentos.Images.Add(0, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/pdf.png"))
        ' # CARGAMOS LOS ARCHIVOS ADJUNTADOS A LA CARPETA DE TRABAJO.
        ArchivosLista = MISC_READFOLDER_DOCUMENTOS(NumeroOrdenTrabajo, main_loggin.ParametrosConfiguracion(5).ToString & NumeroOrdenTrabajo & "/", "pdf")
        If ArchivosLista.Count > 0 Then
            Me.viewot_lv_documentos.View = View.LargeIcon
            Me.viewot_lv_documentos.LargeImageList = Me.viewot_il_documentos
            For Each Archivo In ArchivosLista
                Dim ExNameFile As String() = Archivo.Value.Split("\")
                Me.viewot_lv_documentos.Items.Add(ExNameFile.Last, 0)
            Next
            Me.viewot_lv_documentos.Refresh()
        End If
    End Sub
    Private Sub viewot_pic_close_Click(sender As Object, e As EventArgs) Handles viewot_pic_close.Click
        Me.Close()
    End Sub
    Private Sub viewot_lw_imagenes_DoubleClick(sender As Object, e As EventArgs) Handles viewot_lw_imagenes.DoubleClick
        If IO.File.Exists(main_loggin.ParametrosConfiguracion(5).ToString & NumeroOrdenTrabajo & "\" & ImagesOrdenes(Me.viewot_lw_imagenes.SelectedItems(0).Index).ToString) Then
            Dim VisualizadorImagenes As New imagen_visualizer
            VisualizadorImagenes.visorimagen_pic_image.Image = Image.FromFile(main_loggin.ParametrosConfiguracion(5).ToString & NumeroOrdenTrabajo & "\" & ImagesOrdenes(Me.viewot_lw_imagenes.SelectedItems(0).Index).ToString)
            VisualizadorImagenes.ShowDialog()
        Else
            MessageBox.Show("No se puede encontrar el archivo de imagen en la ruta especificada.", Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub viewot_pic_pdf_Click(sender As Object, e As EventArgs) Handles viewot_pic_pdf.Click
        Call REPORTES_OPENOT(NumeroOrdenTrabajo)
    End Sub
    Private Sub viewot_pic_edit_Click(sender As Object, e As EventArgs) Handles viewot_pic_edit.Click
        ' # HABILITAMOS EL FORMULARIO PARA SU EDICION.
        Me.viewot_gb_datos.Enabled = True
        Me.viewot_gb_tipoot.Enabled = True
        viewot_txt_ringreso.ReadOnly = True

    End Sub
    Private Sub viewot_lv_documentos_DoubleClick(sender As Object, e As EventArgs) Handles viewot_lv_documentos.DoubleClick
        Call MISC_EXECUTEFILE(main_loggin.ParametrosConfiguracion(5).ToString & NumeroOrdenTrabajo & "\" & Me.viewot_lv_documentos.SelectedItems(0).Text)
    End Sub
End Class