<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_ot
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.viewot_tab_ot = New System.Windows.Forms.TabControl()
        Me.viewot_tabpage_foto = New System.Windows.Forms.TabPage()
        Me.viewot_lw_imagenes = New System.Windows.Forms.ListView()
        Me.viewot_tabpage_comentarios = New System.Windows.Forms.TabPage()
        Me.viewot_dg_comentarios = New System.Windows.Forms.DataGridView()
        Me.viewot_tabpage_historic = New System.Windows.Forms.TabPage()
        Me.viewot_gb_datos = New System.Windows.Forms.GroupBox()
        Me.viewot_txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.viewot_pic_save = New System.Windows.Forms.PictureBox()
        Me.viewot_cmb_ireparable = New System.Windows.Forms.ComboBox()
        Me.viewot_lbl_ireparable = New System.Windows.Forms.Label()
        Me.viewot_cmb_modelo = New System.Windows.Forms.ComboBox()
        Me.viewot_lbl_modelo = New System.Windows.Forms.Label()
        Me.viewot_cmb_marca = New System.Windows.Forms.ComboBox()
        Me.viewot_lbl_marca = New System.Windows.Forms.Label()
        Me.viewot_cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.viewot_lbl_tipo = New System.Windows.Forms.Label()
        Me.viewot_txt_ncontrato = New System.Windows.Forms.TextBox()
        Me.viewot_lbl_ncontrato = New System.Windows.Forms.Label()
        Me.viewot_txt_nserief = New System.Windows.Forms.TextBox()
        Me.viewot_lbl_nserief = New System.Windows.Forms.Label()
        Me.viewot_txt_nserie = New System.Windows.Forms.TextBox()
        Me.viewot_lbl_nserie = New System.Windows.Forms.Label()
        Me.viewot_txt_tag = New System.Windows.Forms.TextBox()
        Me.viewot_lbl_tag = New System.Windows.Forms.Label()
        Me.viewot_txt_agenda = New System.Windows.Forms.TextBox()
        Me.viewot_lbl_agenda = New System.Windows.Forms.Label()
        Me.viewot_txt_oc = New System.Windows.Forms.TextBox()
        Me.viewot_lbl_oc = New System.Windows.Forms.Label()
        Me.viewot_txt_gdespacho = New System.Windows.Forms.TextBox()
        Me.viewot_lbl_gdespacho = New System.Windows.Forms.Label()
        Me.viewot_cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.viewot_lbl_cliente = New System.Windows.Forms.Label()
        Me.viewot_gb_tipoot = New System.Windows.Forms.GroupBox()
        Me.viewot_rb_garantia = New System.Windows.Forms.RadioButton()
        Me.viewot_rb_reparacion = New System.Windows.Forms.RadioButton()
        Me.viewot_cmb_prioridad = New System.Windows.Forms.ComboBox()
        Me.viewot_lbl_prioridad = New System.Windows.Forms.Label()
        Me.viewot_lbl_fecha = New System.Windows.Forms.Label()
        Me.viewot_txt_ringreso = New System.Windows.Forms.TextBox()
        Me.viewot_lbl_ringreso = New System.Windows.Forms.Label()
        Me.viewot_pic_ot = New System.Windows.Forms.PictureBox()
        Me.viewot_lbl_ot = New System.Windows.Forms.Label()
        Me.viewot_pic_title = New System.Windows.Forms.PictureBox()
        Me.viewot_pic_close = New System.Windows.Forms.PictureBox()
        Me.viewot_il_imagelist = New System.Windows.Forms.ImageList(Me.components)
        Me.viewot_pic_edit = New System.Windows.Forms.PictureBox()
        Me.viewot_pic_pdf = New System.Windows.Forms.PictureBox()
        Me.viewot_tab_ot.SuspendLayout()
        Me.viewot_tabpage_foto.SuspendLayout()
        Me.viewot_tabpage_comentarios.SuspendLayout()
        CType(Me.viewot_dg_comentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.viewot_gb_datos.SuspendLayout()
        CType(Me.viewot_pic_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.viewot_gb_tipoot.SuspendLayout()
        CType(Me.viewot_pic_ot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewot_pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewot_pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewot_pic_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewot_pic_pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewot_tab_ot
        '
        Me.viewot_tab_ot.Controls.Add(Me.viewot_tabpage_foto)
        Me.viewot_tab_ot.Controls.Add(Me.viewot_tabpage_comentarios)
        Me.viewot_tab_ot.Controls.Add(Me.viewot_tabpage_historic)
        Me.viewot_tab_ot.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_tab_ot.Location = New System.Drawing.Point(12, 292)
        Me.viewot_tab_ot.Name = "viewot_tab_ot"
        Me.viewot_tab_ot.SelectedIndex = 0
        Me.viewot_tab_ot.Size = New System.Drawing.Size(817, 262)
        Me.viewot_tab_ot.TabIndex = 0
        '
        'viewot_tabpage_foto
        '
        Me.viewot_tabpage_foto.Controls.Add(Me.viewot_lw_imagenes)
        Me.viewot_tabpage_foto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_tabpage_foto.Location = New System.Drawing.Point(4, 21)
        Me.viewot_tabpage_foto.Name = "viewot_tabpage_foto"
        Me.viewot_tabpage_foto.Padding = New System.Windows.Forms.Padding(3)
        Me.viewot_tabpage_foto.Size = New System.Drawing.Size(809, 237)
        Me.viewot_tabpage_foto.TabIndex = 0
        Me.viewot_tabpage_foto.Text = "FOTOGRAFIAS"
        Me.viewot_tabpage_foto.UseVisualStyleBackColor = True
        '
        'viewot_lw_imagenes
        '
        Me.viewot_lw_imagenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewot_lw_imagenes.Location = New System.Drawing.Point(3, 3)
        Me.viewot_lw_imagenes.Name = "viewot_lw_imagenes"
        Me.viewot_lw_imagenes.Size = New System.Drawing.Size(803, 231)
        Me.viewot_lw_imagenes.TabIndex = 0
        Me.viewot_lw_imagenes.UseCompatibleStateImageBehavior = False
        '
        'viewot_tabpage_comentarios
        '
        Me.viewot_tabpage_comentarios.Controls.Add(Me.viewot_dg_comentarios)
        Me.viewot_tabpage_comentarios.Location = New System.Drawing.Point(4, 21)
        Me.viewot_tabpage_comentarios.Name = "viewot_tabpage_comentarios"
        Me.viewot_tabpage_comentarios.Padding = New System.Windows.Forms.Padding(3)
        Me.viewot_tabpage_comentarios.Size = New System.Drawing.Size(809, 237)
        Me.viewot_tabpage_comentarios.TabIndex = 1
        Me.viewot_tabpage_comentarios.Text = "COMENTARIOS"
        Me.viewot_tabpage_comentarios.UseVisualStyleBackColor = True
        '
        'viewot_dg_comentarios
        '
        Me.viewot_dg_comentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewot_dg_comentarios.Location = New System.Drawing.Point(3, 25)
        Me.viewot_dg_comentarios.Name = "viewot_dg_comentarios"
        Me.viewot_dg_comentarios.Size = New System.Drawing.Size(803, 209)
        Me.viewot_dg_comentarios.TabIndex = 0
        '
        'viewot_tabpage_historic
        '
        Me.viewot_tabpage_historic.Location = New System.Drawing.Point(4, 21)
        Me.viewot_tabpage_historic.Name = "viewot_tabpage_historic"
        Me.viewot_tabpage_historic.Padding = New System.Windows.Forms.Padding(3)
        Me.viewot_tabpage_historic.Size = New System.Drawing.Size(809, 237)
        Me.viewot_tabpage_historic.TabIndex = 2
        Me.viewot_tabpage_historic.Text = "HISTORICO"
        Me.viewot_tabpage_historic.UseVisualStyleBackColor = True
        '
        'viewot_gb_datos
        '
        Me.viewot_gb_datos.Controls.Add(Me.viewot_txt_fecha)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_pic_save)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_cmb_ireparable)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_ireparable)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_cmb_modelo)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_modelo)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_cmb_marca)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_marca)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_cmb_tipo)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_tipo)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_txt_ncontrato)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_ncontrato)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_txt_nserief)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_nserief)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_txt_nserie)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_nserie)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_txt_tag)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_tag)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_txt_agenda)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_agenda)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_txt_oc)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_oc)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_txt_gdespacho)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_gdespacho)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_cmb_cliente)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_cliente)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_gb_tipoot)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_cmb_prioridad)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_prioridad)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_fecha)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_txt_ringreso)
        Me.viewot_gb_datos.Controls.Add(Me.viewot_lbl_ringreso)
        Me.viewot_gb_datos.Location = New System.Drawing.Point(12, 51)
        Me.viewot_gb_datos.Name = "viewot_gb_datos"
        Me.viewot_gb_datos.Size = New System.Drawing.Size(817, 235)
        Me.viewot_gb_datos.TabIndex = 1
        Me.viewot_gb_datos.TabStop = False
        '
        'viewot_txt_fecha
        '
        Me.viewot_txt_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_txt_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.viewot_txt_fecha.Location = New System.Drawing.Point(273, 34)
        Me.viewot_txt_fecha.Name = "viewot_txt_fecha"
        Me.viewot_txt_fecha.Size = New System.Drawing.Size(126, 18)
        Me.viewot_txt_fecha.TabIndex = 32
        '
        'viewot_pic_save
        '
        Me.viewot_pic_save.Location = New System.Drawing.Point(661, 185)
        Me.viewot_pic_save.Name = "viewot_pic_save"
        Me.viewot_pic_save.Size = New System.Drawing.Size(137, 36)
        Me.viewot_pic_save.TabIndex = 31
        Me.viewot_pic_save.TabStop = False
        '
        'viewot_cmb_ireparable
        '
        Me.viewot_cmb_ireparable.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_cmb_ireparable.FormattingEnabled = True
        Me.viewot_cmb_ireparable.ItemHeight = 12
        Me.viewot_cmb_ireparable.Location = New System.Drawing.Point(8, 197)
        Me.viewot_cmb_ireparable.Name = "viewot_cmb_ireparable"
        Me.viewot_cmb_ireparable.Size = New System.Drawing.Size(205, 20)
        Me.viewot_cmb_ireparable.TabIndex = 30
        '
        'viewot_lbl_ireparable
        '
        Me.viewot_lbl_ireparable.AutoSize = True
        Me.viewot_lbl_ireparable.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_ireparable.Location = New System.Drawing.Point(6, 182)
        Me.viewot_lbl_ireparable.Name = "viewot_lbl_ireparable"
        Me.viewot_lbl_ireparable.Size = New System.Drawing.Size(98, 12)
        Me.viewot_lbl_ireparable.TabIndex = 29
        Me.viewot_lbl_ireparable.Text = "ING. REPARABLE"
        '
        'viewot_cmb_modelo
        '
        Me.viewot_cmb_modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_cmb_modelo.FormattingEnabled = True
        Me.viewot_cmb_modelo.ItemHeight = 12
        Me.viewot_cmb_modelo.Location = New System.Drawing.Point(446, 159)
        Me.viewot_cmb_modelo.Name = "viewot_cmb_modelo"
        Me.viewot_cmb_modelo.Size = New System.Drawing.Size(252, 20)
        Me.viewot_cmb_modelo.TabIndex = 28
        '
        'viewot_lbl_modelo
        '
        Me.viewot_lbl_modelo.AutoSize = True
        Me.viewot_lbl_modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_modelo.Location = New System.Drawing.Point(446, 144)
        Me.viewot_lbl_modelo.Name = "viewot_lbl_modelo"
        Me.viewot_lbl_modelo.Size = New System.Drawing.Size(52, 12)
        Me.viewot_lbl_modelo.TabIndex = 27
        Me.viewot_lbl_modelo.Text = "MODELO"
        '
        'viewot_cmb_marca
        '
        Me.viewot_cmb_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_cmb_marca.FormattingEnabled = True
        Me.viewot_cmb_marca.ItemHeight = 12
        Me.viewot_cmb_marca.Location = New System.Drawing.Point(228, 159)
        Me.viewot_cmb_marca.Name = "viewot_cmb_marca"
        Me.viewot_cmb_marca.Size = New System.Drawing.Size(205, 20)
        Me.viewot_cmb_marca.TabIndex = 26
        '
        'viewot_lbl_marca
        '
        Me.viewot_lbl_marca.AutoSize = True
        Me.viewot_lbl_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_marca.Location = New System.Drawing.Point(226, 144)
        Me.viewot_lbl_marca.Name = "viewot_lbl_marca"
        Me.viewot_lbl_marca.Size = New System.Drawing.Size(47, 12)
        Me.viewot_lbl_marca.TabIndex = 25
        Me.viewot_lbl_marca.Text = "MARCA"
        '
        'viewot_cmb_tipo
        '
        Me.viewot_cmb_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_cmb_tipo.FormattingEnabled = True
        Me.viewot_cmb_tipo.ItemHeight = 12
        Me.viewot_cmb_tipo.Location = New System.Drawing.Point(8, 159)
        Me.viewot_cmb_tipo.Name = "viewot_cmb_tipo"
        Me.viewot_cmb_tipo.Size = New System.Drawing.Size(205, 20)
        Me.viewot_cmb_tipo.TabIndex = 24
        '
        'viewot_lbl_tipo
        '
        Me.viewot_lbl_tipo.AutoSize = True
        Me.viewot_lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_tipo.Location = New System.Drawing.Point(6, 144)
        Me.viewot_lbl_tipo.Name = "viewot_lbl_tipo"
        Me.viewot_lbl_tipo.Size = New System.Drawing.Size(30, 12)
        Me.viewot_lbl_tipo.TabIndex = 23
        Me.viewot_lbl_tipo.Text = "TIPO"
        '
        'viewot_txt_ncontrato
        '
        Me.viewot_txt_ncontrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_txt_ncontrato.Location = New System.Drawing.Point(572, 121)
        Me.viewot_txt_ncontrato.Name = "viewot_txt_ncontrato"
        Me.viewot_txt_ncontrato.Size = New System.Drawing.Size(126, 18)
        Me.viewot_txt_ncontrato.TabIndex = 22
        '
        'viewot_lbl_ncontrato
        '
        Me.viewot_lbl_ncontrato.AutoSize = True
        Me.viewot_lbl_ncontrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_ncontrato.Location = New System.Drawing.Point(570, 106)
        Me.viewot_lbl_ncontrato.Name = "viewot_lbl_ncontrato"
        Me.viewot_lbl_ncontrato.Size = New System.Drawing.Size(81, 12)
        Me.viewot_lbl_ncontrato.TabIndex = 21
        Me.viewot_lbl_ncontrato.Text = "N° CONTRATO"
        '
        'viewot_txt_nserief
        '
        Me.viewot_txt_nserief.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_txt_nserief.Location = New System.Drawing.Point(427, 121)
        Me.viewot_txt_nserief.Name = "viewot_txt_nserief"
        Me.viewot_txt_nserief.Size = New System.Drawing.Size(126, 18)
        Me.viewot_txt_nserief.TabIndex = 20
        '
        'viewot_lbl_nserief
        '
        Me.viewot_lbl_nserief.AutoSize = True
        Me.viewot_lbl_nserief.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_nserief.Location = New System.Drawing.Point(425, 106)
        Me.viewot_lbl_nserief.Name = "viewot_lbl_nserief"
        Me.viewot_lbl_nserief.Size = New System.Drawing.Size(128, 12)
        Me.viewot_lbl_nserief.TabIndex = 19
        Me.viewot_lbl_nserief.Text = "N° SERIE FABRICANTE"
        '
        'viewot_txt_nserie
        '
        Me.viewot_txt_nserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_txt_nserie.Location = New System.Drawing.Point(273, 121)
        Me.viewot_txt_nserie.Name = "viewot_txt_nserie"
        Me.viewot_txt_nserie.Size = New System.Drawing.Size(126, 18)
        Me.viewot_txt_nserie.TabIndex = 18
        '
        'viewot_lbl_nserie
        '
        Me.viewot_lbl_nserie.AutoSize = True
        Me.viewot_lbl_nserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_nserie.Location = New System.Drawing.Point(271, 106)
        Me.viewot_lbl_nserie.Name = "viewot_lbl_nserie"
        Me.viewot_lbl_nserie.Size = New System.Drawing.Size(54, 12)
        Me.viewot_lbl_nserie.TabIndex = 17
        Me.viewot_lbl_nserie.Text = "N° SERIE"
        '
        'viewot_txt_tag
        '
        Me.viewot_txt_tag.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_txt_tag.Location = New System.Drawing.Point(8, 121)
        Me.viewot_txt_tag.Name = "viewot_txt_tag"
        Me.viewot_txt_tag.Size = New System.Drawing.Size(236, 18)
        Me.viewot_txt_tag.TabIndex = 16
        '
        'viewot_lbl_tag
        '
        Me.viewot_lbl_tag.AutoSize = True
        Me.viewot_lbl_tag.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_tag.Location = New System.Drawing.Point(6, 106)
        Me.viewot_lbl_tag.Name = "viewot_lbl_tag"
        Me.viewot_lbl_tag.Size = New System.Drawing.Size(199, 12)
        Me.viewot_lbl_tag.TabIndex = 15
        Me.viewot_lbl_tag.Text = "IDENTIFICACION DEL EQUIPO (TAG)"
        '
        'viewot_txt_agenda
        '
        Me.viewot_txt_agenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_txt_agenda.Location = New System.Drawing.Point(572, 78)
        Me.viewot_txt_agenda.Name = "viewot_txt_agenda"
        Me.viewot_txt_agenda.Size = New System.Drawing.Size(126, 18)
        Me.viewot_txt_agenda.TabIndex = 14
        '
        'viewot_lbl_agenda
        '
        Me.viewot_lbl_agenda.AutoSize = True
        Me.viewot_lbl_agenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_agenda.Location = New System.Drawing.Point(570, 63)
        Me.viewot_lbl_agenda.Name = "viewot_lbl_agenda"
        Me.viewot_lbl_agenda.Size = New System.Drawing.Size(95, 12)
        Me.viewot_lbl_agenda.TabIndex = 13
        Me.viewot_lbl_agenda.Text = "AGENDAMIENTO"
        '
        'viewot_txt_oc
        '
        Me.viewot_txt_oc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_txt_oc.Location = New System.Drawing.Point(427, 78)
        Me.viewot_txt_oc.Name = "viewot_txt_oc"
        Me.viewot_txt_oc.Size = New System.Drawing.Size(126, 18)
        Me.viewot_txt_oc.TabIndex = 12
        '
        'viewot_lbl_oc
        '
        Me.viewot_lbl_oc.AutoSize = True
        Me.viewot_lbl_oc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_oc.Location = New System.Drawing.Point(425, 63)
        Me.viewot_lbl_oc.Name = "viewot_lbl_oc"
        Me.viewot_lbl_oc.Size = New System.Drawing.Size(130, 12)
        Me.viewot_lbl_oc.TabIndex = 11
        Me.viewot_lbl_oc.Text = "N° ORDEN DE COMPRA"
        '
        'viewot_txt_gdespacho
        '
        Me.viewot_txt_gdespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_txt_gdespacho.Location = New System.Drawing.Point(273, 78)
        Me.viewot_txt_gdespacho.Name = "viewot_txt_gdespacho"
        Me.viewot_txt_gdespacho.Size = New System.Drawing.Size(126, 18)
        Me.viewot_txt_gdespacho.TabIndex = 10
        '
        'viewot_lbl_gdespacho
        '
        Me.viewot_lbl_gdespacho.AutoSize = True
        Me.viewot_lbl_gdespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_gdespacho.Location = New System.Drawing.Point(271, 63)
        Me.viewot_lbl_gdespacho.Name = "viewot_lbl_gdespacho"
        Me.viewot_lbl_gdespacho.Size = New System.Drawing.Size(113, 12)
        Me.viewot_lbl_gdespacho.TabIndex = 9
        Me.viewot_lbl_gdespacho.Text = "N° GUIA DESPACHO"
        '
        'viewot_cmb_cliente
        '
        Me.viewot_cmb_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_cmb_cliente.FormattingEnabled = True
        Me.viewot_cmb_cliente.ItemHeight = 12
        Me.viewot_cmb_cliente.Location = New System.Drawing.Point(8, 76)
        Me.viewot_cmb_cliente.Name = "viewot_cmb_cliente"
        Me.viewot_cmb_cliente.Size = New System.Drawing.Size(236, 20)
        Me.viewot_cmb_cliente.TabIndex = 8
        '
        'viewot_lbl_cliente
        '
        Me.viewot_lbl_cliente.AutoSize = True
        Me.viewot_lbl_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_cliente.Location = New System.Drawing.Point(6, 63)
        Me.viewot_lbl_cliente.Name = "viewot_lbl_cliente"
        Me.viewot_lbl_cliente.Size = New System.Drawing.Size(51, 12)
        Me.viewot_lbl_cliente.TabIndex = 7
        Me.viewot_lbl_cliente.Text = "CLIENTE"
        '
        'viewot_gb_tipoot
        '
        Me.viewot_gb_tipoot.Controls.Add(Me.viewot_rb_garantia)
        Me.viewot_gb_tipoot.Controls.Add(Me.viewot_rb_reparacion)
        Me.viewot_gb_tipoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_gb_tipoot.Location = New System.Drawing.Point(593, 12)
        Me.viewot_gb_tipoot.Name = "viewot_gb_tipoot"
        Me.viewot_gb_tipoot.Size = New System.Drawing.Size(205, 44)
        Me.viewot_gb_tipoot.TabIndex = 6
        Me.viewot_gb_tipoot.TabStop = False
        Me.viewot_gb_tipoot.Text = "TIPO PROCESO"
        '
        'viewot_rb_garantia
        '
        Me.viewot_rb_garantia.AutoSize = True
        Me.viewot_rb_garantia.Location = New System.Drawing.Point(108, 19)
        Me.viewot_rb_garantia.Name = "viewot_rb_garantia"
        Me.viewot_rb_garantia.Size = New System.Drawing.Size(81, 16)
        Me.viewot_rb_garantia.TabIndex = 1
        Me.viewot_rb_garantia.TabStop = True
        Me.viewot_rb_garantia.Text = "GARANTIA"
        Me.viewot_rb_garantia.UseVisualStyleBackColor = True
        '
        'viewot_rb_reparacion
        '
        Me.viewot_rb_reparacion.AutoSize = True
        Me.viewot_rb_reparacion.Location = New System.Drawing.Point(6, 19)
        Me.viewot_rb_reparacion.Name = "viewot_rb_reparacion"
        Me.viewot_rb_reparacion.Size = New System.Drawing.Size(97, 16)
        Me.viewot_rb_reparacion.TabIndex = 0
        Me.viewot_rb_reparacion.TabStop = True
        Me.viewot_rb_reparacion.Text = "REPARACION"
        Me.viewot_rb_reparacion.UseVisualStyleBackColor = True
        '
        'viewot_cmb_prioridad
        '
        Me.viewot_cmb_prioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_cmb_prioridad.FormattingEnabled = True
        Me.viewot_cmb_prioridad.ItemHeight = 12
        Me.viewot_cmb_prioridad.Location = New System.Drawing.Point(427, 34)
        Me.viewot_cmb_prioridad.Name = "viewot_cmb_prioridad"
        Me.viewot_cmb_prioridad.Size = New System.Drawing.Size(131, 20)
        Me.viewot_cmb_prioridad.TabIndex = 5
        '
        'viewot_lbl_prioridad
        '
        Me.viewot_lbl_prioridad.AutoSize = True
        Me.viewot_lbl_prioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_prioridad.Location = New System.Drawing.Point(425, 19)
        Me.viewot_lbl_prioridad.Name = "viewot_lbl_prioridad"
        Me.viewot_lbl_prioridad.Size = New System.Drawing.Size(68, 12)
        Me.viewot_lbl_prioridad.TabIndex = 4
        Me.viewot_lbl_prioridad.Text = "PRIORIDAD"
        '
        'viewot_lbl_fecha
        '
        Me.viewot_lbl_fecha.AutoSize = True
        Me.viewot_lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_fecha.Location = New System.Drawing.Point(271, 19)
        Me.viewot_lbl_fecha.Name = "viewot_lbl_fecha"
        Me.viewot_lbl_fecha.Size = New System.Drawing.Size(111, 12)
        Me.viewot_lbl_fecha.TabIndex = 2
        Me.viewot_lbl_fecha.Text = "FECHA RECEPCION"
        '
        'viewot_txt_ringreso
        '
        Me.viewot_txt_ringreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_txt_ringreso.Location = New System.Drawing.Point(8, 34)
        Me.viewot_txt_ringreso.Name = "viewot_txt_ringreso"
        Me.viewot_txt_ringreso.Size = New System.Drawing.Size(236, 18)
        Me.viewot_txt_ringreso.TabIndex = 1
        '
        'viewot_lbl_ringreso
        '
        Me.viewot_lbl_ringreso.AutoSize = True
        Me.viewot_lbl_ringreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_ringreso.Location = New System.Drawing.Point(6, 19)
        Me.viewot_lbl_ringreso.Name = "viewot_lbl_ringreso"
        Me.viewot_lbl_ringreso.Size = New System.Drawing.Size(156, 12)
        Me.viewot_lbl_ringreso.TabIndex = 0
        Me.viewot_lbl_ringreso.Text = "RESPONSABLE DE INGRESO"
        '
        'viewot_pic_ot
        '
        Me.viewot_pic_ot.Location = New System.Drawing.Point(597, 14)
        Me.viewot_pic_ot.Name = "viewot_pic_ot"
        Me.viewot_pic_ot.Size = New System.Drawing.Size(84, 33)
        Me.viewot_pic_ot.TabIndex = 3
        Me.viewot_pic_ot.TabStop = False
        '
        'viewot_lbl_ot
        '
        Me.viewot_lbl_ot.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewot_lbl_ot.Location = New System.Drawing.Point(687, 11)
        Me.viewot_lbl_ot.Name = "viewot_lbl_ot"
        Me.viewot_lbl_ot.Size = New System.Drawing.Size(100, 36)
        Me.viewot_lbl_ot.TabIndex = 4
        Me.viewot_lbl_ot.Text = "999"
        '
        'viewot_pic_title
        '
        Me.viewot_pic_title.Location = New System.Drawing.Point(12, 18)
        Me.viewot_pic_title.Name = "viewot_pic_title"
        Me.viewot_pic_title.Size = New System.Drawing.Size(112, 27)
        Me.viewot_pic_title.TabIndex = 5
        Me.viewot_pic_title.TabStop = False
        '
        'viewot_pic_close
        '
        Me.viewot_pic_close.Location = New System.Drawing.Point(793, 12)
        Me.viewot_pic_close.Name = "viewot_pic_close"
        Me.viewot_pic_close.Size = New System.Drawing.Size(32, 32)
        Me.viewot_pic_close.TabIndex = 6
        Me.viewot_pic_close.TabStop = False
        '
        'viewot_il_imagelist
        '
        Me.viewot_il_imagelist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.viewot_il_imagelist.ImageSize = New System.Drawing.Size(16, 16)
        Me.viewot_il_imagelist.TransparentColor = System.Drawing.Color.Transparent
        '
        'viewot_pic_edit
        '
        Me.viewot_pic_edit.Location = New System.Drawing.Point(140, 5)
        Me.viewot_pic_edit.Name = "viewot_pic_edit"
        Me.viewot_pic_edit.Size = New System.Drawing.Size(48, 48)
        Me.viewot_pic_edit.TabIndex = 7
        Me.viewot_pic_edit.TabStop = False
        '
        'viewot_pic_pdf
        '
        Me.viewot_pic_pdf.Location = New System.Drawing.Point(194, 5)
        Me.viewot_pic_pdf.Name = "viewot_pic_pdf"
        Me.viewot_pic_pdf.Size = New System.Drawing.Size(48, 48)
        Me.viewot_pic_pdf.TabIndex = 8
        Me.viewot_pic_pdf.TabStop = False
        '
        'view_ot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(842, 566)
        Me.Controls.Add(Me.viewot_pic_pdf)
        Me.Controls.Add(Me.viewot_pic_edit)
        Me.Controls.Add(Me.viewot_pic_close)
        Me.Controls.Add(Me.viewot_pic_title)
        Me.Controls.Add(Me.viewot_lbl_ot)
        Me.Controls.Add(Me.viewot_pic_ot)
        Me.Controls.Add(Me.viewot_gb_datos)
        Me.Controls.Add(Me.viewot_tab_ot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "view_ot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "view_ot"
        Me.viewot_tab_ot.ResumeLayout(False)
        Me.viewot_tabpage_foto.ResumeLayout(False)
        Me.viewot_tabpage_comentarios.ResumeLayout(False)
        CType(Me.viewot_dg_comentarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.viewot_gb_datos.ResumeLayout(False)
        Me.viewot_gb_datos.PerformLayout()
        CType(Me.viewot_pic_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.viewot_gb_tipoot.ResumeLayout(False)
        Me.viewot_gb_tipoot.PerformLayout()
        CType(Me.viewot_pic_ot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewot_pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewot_pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewot_pic_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewot_pic_pdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewot_tab_ot As System.Windows.Forms.TabControl
    Friend WithEvents viewot_tabpage_foto As System.Windows.Forms.TabPage
    Friend WithEvents viewot_tabpage_comentarios As System.Windows.Forms.TabPage
    Friend WithEvents viewot_tabpage_historic As System.Windows.Forms.TabPage
    Friend WithEvents viewot_gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents viewot_txt_ringreso As System.Windows.Forms.TextBox
    Friend WithEvents viewot_lbl_ringreso As System.Windows.Forms.Label
    Friend WithEvents viewot_pic_ot As System.Windows.Forms.PictureBox
    Friend WithEvents viewot_lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents viewot_cmb_prioridad As System.Windows.Forms.ComboBox
    Friend WithEvents viewot_lbl_prioridad As System.Windows.Forms.Label
    Friend WithEvents viewot_gb_tipoot As System.Windows.Forms.GroupBox
    Friend WithEvents viewot_rb_garantia As System.Windows.Forms.RadioButton
    Friend WithEvents viewot_rb_reparacion As System.Windows.Forms.RadioButton
    Friend WithEvents viewot_cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents viewot_lbl_cliente As System.Windows.Forms.Label
    Friend WithEvents viewot_txt_gdespacho As System.Windows.Forms.TextBox
    Friend WithEvents viewot_lbl_gdespacho As System.Windows.Forms.Label
    Friend WithEvents viewot_txt_oc As System.Windows.Forms.TextBox
    Friend WithEvents viewot_lbl_oc As System.Windows.Forms.Label
    Friend WithEvents viewot_txt_agenda As System.Windows.Forms.TextBox
    Friend WithEvents viewot_lbl_agenda As System.Windows.Forms.Label
    Friend WithEvents viewot_lbl_tag As System.Windows.Forms.Label
    Friend WithEvents viewot_txt_tag As System.Windows.Forms.TextBox
    Friend WithEvents viewot_txt_nserie As System.Windows.Forms.TextBox
    Friend WithEvents viewot_lbl_nserie As System.Windows.Forms.Label
    Friend WithEvents viewot_txt_nserief As System.Windows.Forms.TextBox
    Friend WithEvents viewot_lbl_nserief As System.Windows.Forms.Label
    Friend WithEvents viewot_txt_ncontrato As System.Windows.Forms.TextBox
    Friend WithEvents viewot_lbl_ncontrato As System.Windows.Forms.Label
    Friend WithEvents viewot_lbl_ot As System.Windows.Forms.Label
    Friend WithEvents viewot_cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents viewot_lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents viewot_lbl_marca As System.Windows.Forms.Label
    Friend WithEvents viewot_cmb_modelo As System.Windows.Forms.ComboBox
    Friend WithEvents viewot_lbl_modelo As System.Windows.Forms.Label
    Friend WithEvents viewot_cmb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents viewot_lbl_ireparable As System.Windows.Forms.Label
    Friend WithEvents viewot_cmb_ireparable As System.Windows.Forms.ComboBox
    Friend WithEvents viewot_pic_title As System.Windows.Forms.PictureBox
    Friend WithEvents viewot_pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents viewot_pic_save As System.Windows.Forms.PictureBox
    Friend WithEvents viewot_txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents viewot_lw_imagenes As System.Windows.Forms.ListView
    Friend WithEvents viewot_il_imagelist As System.Windows.Forms.ImageList
    Friend WithEvents viewot_dg_comentarios As System.Windows.Forms.DataGridView
    Friend WithEvents viewot_pic_edit As System.Windows.Forms.PictureBox
    Friend WithEvents viewot_pic_pdf As System.Windows.Forms.PictureBox
End Class
