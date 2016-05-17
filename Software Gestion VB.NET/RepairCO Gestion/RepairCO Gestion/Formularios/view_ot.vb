Public Class view_ot
    Public NumeroOrdenTrabajo As String
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
        Me.viewot_cmb_prioridad.Items.Add("ALTA")
        Me.viewot_cmb_prioridad.Items.Add("MEDIA")
        Me.viewot_cmb_prioridad.Items.Add("BAJA")
        ' # CARGA CONFIGURACION DE CONTROLES DEL FORMULARIO.
        Me.viewot_lbl_ot.ForeColor = ColorTranslator.FromHtml("#b88d00")
        Me.viewot_pic_title.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_save.SizeMode = PictureBoxSizeMode.StretchImage
        Me.viewot_pic_close.Cursor = Cursors.Hand
        Me.viewot_pic_save.Cursor = Cursors.Hand
        Me.viewot_pic_save.Visible = False
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
    End Sub
    Private Sub viewot_pic_close_Click(sender As Object, e As EventArgs) Handles viewot_pic_close.Click
        Me.Close()
    End Sub
End Class