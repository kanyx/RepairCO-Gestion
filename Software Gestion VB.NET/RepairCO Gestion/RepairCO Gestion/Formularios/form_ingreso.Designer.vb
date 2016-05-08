<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_ingreso
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
        Me.ingreso_gp_datos = New System.Windows.Forms.GroupBox()
        Me.ingresot_pic_saveot = New System.Windows.Forms.PictureBox()
        Me.ingreso_txt_nserie = New System.Windows.Forms.TextBox()
        Me.ingreso_lbl_nserie = New System.Windows.Forms.Label()
        Me.ingreso_lbl_addmodelo = New System.Windows.Forms.LinkLabel()
        Me.ingreso_lbl_addmarca = New System.Windows.Forms.LinkLabel()
        Me.ingreso_lbl_addtipo = New System.Windows.Forms.LinkLabel()
        Me.ingreso_lbl_addcliente = New System.Windows.Forms.LinkLabel()
        Me.ingreso_cmb_modelo = New System.Windows.Forms.ComboBox()
        Me.ingreso_lbl_modelo = New System.Windows.Forms.Label()
        Me.ingreso_cmb_marca = New System.Windows.Forms.ComboBox()
        Me.ingreso_lbl_marca = New System.Windows.Forms.Label()
        Me.ingreso_cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.ingreso_lbl_tipo = New System.Windows.Forms.Label()
        Me.ingreso_txt_iequipo = New System.Windows.Forms.TextBox()
        Me.ingreso_lbl_iequipo = New System.Windows.Forms.Label()
        Me.ingreso_txt_guia = New System.Windows.Forms.TextBox()
        Me.ingreso_lbl_nguia = New System.Windows.Forms.Label()
        Me.ingreso_cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.ingreso_lbl_cliente = New System.Windows.Forms.Label()
        Me.ingreso_txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.ingreso_lbl_fecha = New System.Windows.Forms.Label()
        Me.ingreso_txt_rservicio = New System.Windows.Forms.TextBox()
        Me.ingreso_lbl_rservicio = New System.Windows.Forms.Label()
        Me.ingreso_gp_tproceso = New System.Windows.Forms.GroupBox()
        Me.ingreso_rb_garantia = New System.Windows.Forms.RadioButton()
        Me.ingreso_rb_presupuesto = New System.Windows.Forms.RadioButton()
        Me.ingresot_pic_title = New System.Windows.Forms.PictureBox()
        Me.ingresot_pic_ot = New System.Windows.Forms.PictureBox()
        Me.ingreso_txt_not = New System.Windows.Forms.TextBox()
        Me.ingreso_tp_help = New System.Windows.Forms.ToolTip(Me.components)
        Me.ingresot_pn_imgcontainer = New System.Windows.Forms.Panel()
        Me.ingresot_lv_imagenes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ingresot_pic_saveimages = New System.Windows.Forms.PictureBox()
        Me.ingresot_il_fotos = New System.Windows.Forms.ImageList(Me.components)
        Me.ingreso_gp_datos.SuspendLayout()
        CType(Me.ingresot_pic_saveot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ingreso_gp_tproceso.SuspendLayout()
        CType(Me.ingresot_pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ingresot_pic_ot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ingresot_pn_imgcontainer.SuspendLayout()
        CType(Me.ingresot_pic_saveimages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ingreso_gp_datos
        '
        Me.ingreso_gp_datos.Controls.Add(Me.ingresot_pic_saveot)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_txt_nserie)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_nserie)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_addmodelo)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_addmarca)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_addtipo)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_addcliente)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_cmb_modelo)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_modelo)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_cmb_marca)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_marca)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_cmb_tipo)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_tipo)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_txt_iequipo)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_iequipo)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_txt_guia)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_nguia)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_cmb_cliente)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_cliente)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_txt_fecha)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_fecha)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_txt_rservicio)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_lbl_rservicio)
        Me.ingreso_gp_datos.Controls.Add(Me.ingreso_gp_tproceso)
        Me.ingreso_gp_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_gp_datos.ForeColor = System.Drawing.Color.DarkOrange
        Me.ingreso_gp_datos.Location = New System.Drawing.Point(31, 56)
        Me.ingreso_gp_datos.Name = "ingreso_gp_datos"
        Me.ingreso_gp_datos.Size = New System.Drawing.Size(805, 225)
        Me.ingreso_gp_datos.TabIndex = 0
        Me.ingreso_gp_datos.TabStop = False
        Me.ingreso_gp_datos.Text = "DATOS OT"
        '
        'ingresot_pic_saveot
        '
        Me.ingresot_pic_saveot.Location = New System.Drawing.Point(571, 175)
        Me.ingresot_pic_saveot.Name = "ingresot_pic_saveot"
        Me.ingresot_pic_saveot.Size = New System.Drawing.Size(137, 36)
        Me.ingresot_pic_saveot.TabIndex = 23
        Me.ingresot_pic_saveot.TabStop = False
        '
        'ingreso_txt_nserie
        '
        Me.ingreso_txt_nserie.Location = New System.Drawing.Point(8, 190)
        Me.ingreso_txt_nserie.Name = "ingreso_txt_nserie"
        Me.ingreso_txt_nserie.Size = New System.Drawing.Size(200, 20)
        Me.ingreso_txt_nserie.TabIndex = 22
        '
        'ingreso_lbl_nserie
        '
        Me.ingreso_lbl_nserie.AutoSize = True
        Me.ingreso_lbl_nserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_nserie.ForeColor = System.Drawing.Color.Black
        Me.ingreso_lbl_nserie.Location = New System.Drawing.Point(6, 175)
        Me.ingreso_lbl_nserie.Name = "ingreso_lbl_nserie"
        Me.ingreso_lbl_nserie.Size = New System.Drawing.Size(54, 12)
        Me.ingreso_lbl_nserie.TabIndex = 21
        Me.ingreso_lbl_nserie.Text = "N° SERIE"
        '
        'ingreso_lbl_addmodelo
        '
        Me.ingreso_lbl_addmodelo.AutoSize = True
        Me.ingreso_lbl_addmodelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_addmodelo.Location = New System.Drawing.Point(612, 126)
        Me.ingreso_lbl_addmodelo.Name = "ingreso_lbl_addmodelo"
        Me.ingreso_lbl_addmodelo.Size = New System.Drawing.Size(96, 12)
        Me.ingreso_lbl_addmodelo.TabIndex = 20
        Me.ingreso_lbl_addmodelo.TabStop = True
        Me.ingreso_lbl_addmodelo.Text = "AGREGAR MODELO"
        '
        'ingreso_lbl_addmarca
        '
        Me.ingreso_lbl_addmarca.AutoSize = True
        Me.ingreso_lbl_addmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_addmarca.Location = New System.Drawing.Point(383, 126)
        Me.ingreso_lbl_addmarca.Name = "ingreso_lbl_addmarca"
        Me.ingreso_lbl_addmarca.Size = New System.Drawing.Size(92, 12)
        Me.ingreso_lbl_addmarca.TabIndex = 19
        Me.ingreso_lbl_addmarca.TabStop = True
        Me.ingreso_lbl_addmarca.Text = "AGREGAR MARCA"
        '
        'ingreso_lbl_addtipo
        '
        Me.ingreso_lbl_addtipo.AutoSize = True
        Me.ingreso_lbl_addtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_addtipo.Location = New System.Drawing.Point(163, 126)
        Me.ingreso_lbl_addtipo.Name = "ingreso_lbl_addtipo"
        Me.ingreso_lbl_addtipo.Size = New System.Drawing.Size(76, 12)
        Me.ingreso_lbl_addtipo.TabIndex = 18
        Me.ingreso_lbl_addtipo.TabStop = True
        Me.ingreso_lbl_addtipo.Text = "AGREGAR TIPO"
        '
        'ingreso_lbl_addcliente
        '
        Me.ingreso_lbl_addcliente.AutoSize = True
        Me.ingreso_lbl_addcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_addcliente.Location = New System.Drawing.Point(145, 76)
        Me.ingreso_lbl_addcliente.Name = "ingreso_lbl_addcliente"
        Me.ingreso_lbl_addcliente.Size = New System.Drawing.Size(94, 12)
        Me.ingreso_lbl_addcliente.TabIndex = 17
        Me.ingreso_lbl_addcliente.TabStop = True
        Me.ingreso_lbl_addcliente.Text = "AGREGAR CLIENTE"
        '
        'ingreso_cmb_modelo
        '
        Me.ingreso_cmb_modelo.FormattingEnabled = True
        Me.ingreso_cmb_modelo.Location = New System.Drawing.Point(508, 141)
        Me.ingreso_cmb_modelo.Name = "ingreso_cmb_modelo"
        Me.ingreso_cmb_modelo.Size = New System.Drawing.Size(200, 21)
        Me.ingreso_cmb_modelo.TabIndex = 16
        '
        'ingreso_lbl_modelo
        '
        Me.ingreso_lbl_modelo.AutoSize = True
        Me.ingreso_lbl_modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_modelo.ForeColor = System.Drawing.Color.Black
        Me.ingreso_lbl_modelo.Location = New System.Drawing.Point(506, 126)
        Me.ingreso_lbl_modelo.Name = "ingreso_lbl_modelo"
        Me.ingreso_lbl_modelo.Size = New System.Drawing.Size(52, 12)
        Me.ingreso_lbl_modelo.TabIndex = 15
        Me.ingreso_lbl_modelo.Text = "MODELO"
        '
        'ingreso_cmb_marca
        '
        Me.ingreso_cmb_marca.FormattingEnabled = True
        Me.ingreso_cmb_marca.Location = New System.Drawing.Point(275, 141)
        Me.ingreso_cmb_marca.Name = "ingreso_cmb_marca"
        Me.ingreso_cmb_marca.Size = New System.Drawing.Size(200, 21)
        Me.ingreso_cmb_marca.TabIndex = 14
        '
        'ingreso_lbl_marca
        '
        Me.ingreso_lbl_marca.AutoSize = True
        Me.ingreso_lbl_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_marca.ForeColor = System.Drawing.Color.Black
        Me.ingreso_lbl_marca.Location = New System.Drawing.Point(273, 126)
        Me.ingreso_lbl_marca.Name = "ingreso_lbl_marca"
        Me.ingreso_lbl_marca.Size = New System.Drawing.Size(47, 12)
        Me.ingreso_lbl_marca.TabIndex = 13
        Me.ingreso_lbl_marca.Text = "MARCA"
        '
        'ingreso_cmb_tipo
        '
        Me.ingreso_cmb_tipo.FormattingEnabled = True
        Me.ingreso_cmb_tipo.Location = New System.Drawing.Point(8, 141)
        Me.ingreso_cmb_tipo.Name = "ingreso_cmb_tipo"
        Me.ingreso_cmb_tipo.Size = New System.Drawing.Size(231, 21)
        Me.ingreso_cmb_tipo.TabIndex = 12
        '
        'ingreso_lbl_tipo
        '
        Me.ingreso_lbl_tipo.AutoSize = True
        Me.ingreso_lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_tipo.ForeColor = System.Drawing.Color.Black
        Me.ingreso_lbl_tipo.Location = New System.Drawing.Point(6, 126)
        Me.ingreso_lbl_tipo.Name = "ingreso_lbl_tipo"
        Me.ingreso_lbl_tipo.Size = New System.Drawing.Size(30, 12)
        Me.ingreso_lbl_tipo.TabIndex = 11
        Me.ingreso_lbl_tipo.Text = "TIPO"
        '
        'ingreso_txt_iequipo
        '
        Me.ingreso_txt_iequipo.Location = New System.Drawing.Point(508, 91)
        Me.ingreso_txt_iequipo.Name = "ingreso_txt_iequipo"
        Me.ingreso_txt_iequipo.Size = New System.Drawing.Size(200, 20)
        Me.ingreso_txt_iequipo.TabIndex = 10
        '
        'ingreso_lbl_iequipo
        '
        Me.ingreso_lbl_iequipo.AutoSize = True
        Me.ingreso_lbl_iequipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_iequipo.ForeColor = System.Drawing.Color.Black
        Me.ingreso_lbl_iequipo.Location = New System.Drawing.Point(506, 76)
        Me.ingreso_lbl_iequipo.Name = "ingreso_lbl_iequipo"
        Me.ingreso_lbl_iequipo.Size = New System.Drawing.Size(166, 12)
        Me.ingreso_lbl_iequipo.TabIndex = 9
        Me.ingreso_lbl_iequipo.Text = "IDENTIFICACION DEL EQUIPO"
        '
        'ingreso_txt_guia
        '
        Me.ingreso_txt_guia.Location = New System.Drawing.Point(275, 92)
        Me.ingreso_txt_guia.Name = "ingreso_txt_guia"
        Me.ingreso_txt_guia.Size = New System.Drawing.Size(200, 20)
        Me.ingreso_txt_guia.TabIndex = 8
        '
        'ingreso_lbl_nguia
        '
        Me.ingreso_lbl_nguia.AutoSize = True
        Me.ingreso_lbl_nguia.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_nguia.ForeColor = System.Drawing.Color.Black
        Me.ingreso_lbl_nguia.Location = New System.Drawing.Point(273, 76)
        Me.ingreso_lbl_nguia.Name = "ingreso_lbl_nguia"
        Me.ingreso_lbl_nguia.Size = New System.Drawing.Size(113, 12)
        Me.ingreso_lbl_nguia.TabIndex = 7
        Me.ingreso_lbl_nguia.Text = "N° GUIA DESPACHO"
        '
        'ingreso_cmb_cliente
        '
        Me.ingreso_cmb_cliente.FormattingEnabled = True
        Me.ingreso_cmb_cliente.Location = New System.Drawing.Point(8, 91)
        Me.ingreso_cmb_cliente.Name = "ingreso_cmb_cliente"
        Me.ingreso_cmb_cliente.Size = New System.Drawing.Size(231, 21)
        Me.ingreso_cmb_cliente.TabIndex = 6
        '
        'ingreso_lbl_cliente
        '
        Me.ingreso_lbl_cliente.AutoSize = True
        Me.ingreso_lbl_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_cliente.ForeColor = System.Drawing.Color.Black
        Me.ingreso_lbl_cliente.Location = New System.Drawing.Point(6, 76)
        Me.ingreso_lbl_cliente.Name = "ingreso_lbl_cliente"
        Me.ingreso_lbl_cliente.Size = New System.Drawing.Size(51, 12)
        Me.ingreso_lbl_cliente.TabIndex = 5
        Me.ingreso_lbl_cliente.Text = "CLIENTE"
        '
        'ingreso_txt_fecha
        '
        Me.ingreso_txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ingreso_txt_fecha.Location = New System.Drawing.Point(275, 42)
        Me.ingreso_txt_fecha.Name = "ingreso_txt_fecha"
        Me.ingreso_txt_fecha.Size = New System.Drawing.Size(200, 20)
        Me.ingreso_txt_fecha.TabIndex = 4
        '
        'ingreso_lbl_fecha
        '
        Me.ingreso_lbl_fecha.AutoSize = True
        Me.ingreso_lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_fecha.ForeColor = System.Drawing.Color.Black
        Me.ingreso_lbl_fecha.Location = New System.Drawing.Point(273, 27)
        Me.ingreso_lbl_fecha.Name = "ingreso_lbl_fecha"
        Me.ingreso_lbl_fecha.Size = New System.Drawing.Size(111, 12)
        Me.ingreso_lbl_fecha.TabIndex = 3
        Me.ingreso_lbl_fecha.Text = "FECHA RECEPCION"
        '
        'ingreso_txt_rservicio
        '
        Me.ingreso_txt_rservicio.Location = New System.Drawing.Point(8, 42)
        Me.ingreso_txt_rservicio.Name = "ingreso_txt_rservicio"
        Me.ingreso_txt_rservicio.ReadOnly = True
        Me.ingreso_txt_rservicio.Size = New System.Drawing.Size(231, 20)
        Me.ingreso_txt_rservicio.TabIndex = 2
        '
        'ingreso_lbl_rservicio
        '
        Me.ingreso_lbl_rservicio.AutoSize = True
        Me.ingreso_lbl_rservicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_lbl_rservicio.ForeColor = System.Drawing.Color.Black
        Me.ingreso_lbl_rservicio.Location = New System.Drawing.Point(6, 27)
        Me.ingreso_lbl_rservicio.Name = "ingreso_lbl_rservicio"
        Me.ingreso_lbl_rservicio.Size = New System.Drawing.Size(138, 12)
        Me.ingreso_lbl_rservicio.TabIndex = 1
        Me.ingreso_lbl_rservicio.Text = "RESPONSABLE INGRESO"
        '
        'ingreso_gp_tproceso
        '
        Me.ingreso_gp_tproceso.Controls.Add(Me.ingreso_rb_garantia)
        Me.ingreso_gp_tproceso.Controls.Add(Me.ingreso_rb_presupuesto)
        Me.ingreso_gp_tproceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_gp_tproceso.ForeColor = System.Drawing.Color.DarkOrange
        Me.ingreso_gp_tproceso.Location = New System.Drawing.Point(567, 10)
        Me.ingreso_gp_tproceso.Name = "ingreso_gp_tproceso"
        Me.ingreso_gp_tproceso.Size = New System.Drawing.Size(212, 44)
        Me.ingreso_gp_tproceso.TabIndex = 0
        Me.ingreso_gp_tproceso.TabStop = False
        Me.ingreso_gp_tproceso.Text = "TIPO PROCESO"
        '
        'ingreso_rb_garantia
        '
        Me.ingreso_rb_garantia.AutoSize = True
        Me.ingreso_rb_garantia.ForeColor = System.Drawing.Color.Black
        Me.ingreso_rb_garantia.Location = New System.Drawing.Point(115, 17)
        Me.ingreso_rb_garantia.Name = "ingreso_rb_garantia"
        Me.ingreso_rb_garantia.Size = New System.Drawing.Size(81, 16)
        Me.ingreso_rb_garantia.TabIndex = 1
        Me.ingreso_rb_garantia.TabStop = True
        Me.ingreso_rb_garantia.Text = "GARANTIA"
        Me.ingreso_rb_garantia.UseVisualStyleBackColor = True
        '
        'ingreso_rb_presupuesto
        '
        Me.ingreso_rb_presupuesto.AutoSize = True
        Me.ingreso_rb_presupuesto.ForeColor = System.Drawing.Color.Black
        Me.ingreso_rb_presupuesto.Location = New System.Drawing.Point(6, 17)
        Me.ingreso_rb_presupuesto.Name = "ingreso_rb_presupuesto"
        Me.ingreso_rb_presupuesto.Size = New System.Drawing.Size(103, 16)
        Me.ingreso_rb_presupuesto.TabIndex = 0
        Me.ingreso_rb_presupuesto.TabStop = True
        Me.ingreso_rb_presupuesto.Text = "PRESUPUESTO"
        Me.ingreso_rb_presupuesto.UseVisualStyleBackColor = True
        '
        'ingresot_pic_title
        '
        Me.ingresot_pic_title.Location = New System.Drawing.Point(31, 23)
        Me.ingresot_pic_title.Name = "ingresot_pic_title"
        Me.ingresot_pic_title.Size = New System.Drawing.Size(144, 27)
        Me.ingresot_pic_title.TabIndex = 1
        Me.ingresot_pic_title.TabStop = False
        '
        'ingresot_pic_ot
        '
        Me.ingresot_pic_ot.Location = New System.Drawing.Point(618, 17)
        Me.ingresot_pic_ot.Name = "ingresot_pic_ot"
        Me.ingresot_pic_ot.Size = New System.Drawing.Size(84, 33)
        Me.ingresot_pic_ot.TabIndex = 2
        Me.ingresot_pic_ot.TabStop = False
        '
        'ingreso_txt_not
        '
        Me.ingreso_txt_not.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ingreso_txt_not.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_txt_not.ForeColor = System.Drawing.Color.DarkOrange
        Me.ingreso_txt_not.Location = New System.Drawing.Point(708, 7)
        Me.ingreso_txt_not.Name = "ingreso_txt_not"
        Me.ingreso_txt_not.Size = New System.Drawing.Size(128, 47)
        Me.ingreso_txt_not.TabIndex = 3
        Me.ingreso_txt_not.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ingresot_pn_imgcontainer
        '
        Me.ingresot_pn_imgcontainer.Controls.Add(Me.ingresot_lv_imagenes)
        Me.ingresot_pn_imgcontainer.Location = New System.Drawing.Point(31, 287)
        Me.ingresot_pn_imgcontainer.Name = "ingresot_pn_imgcontainer"
        Me.ingresot_pn_imgcontainer.Size = New System.Drawing.Size(805, 248)
        Me.ingresot_pn_imgcontainer.TabIndex = 4
        '
        'ingresot_lv_imagenes
        '
        Me.ingresot_lv_imagenes.AutoArrange = False
        Me.ingresot_lv_imagenes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ingresot_lv_imagenes.Location = New System.Drawing.Point(0, 0)
        Me.ingresot_lv_imagenes.MultiSelect = False
        Me.ingresot_lv_imagenes.Name = "ingresot_lv_imagenes"
        Me.ingresot_lv_imagenes.Size = New System.Drawing.Size(805, 248)
        Me.ingresot_lv_imagenes.TabIndex = 0
        Me.ingresot_lv_imagenes.UseCompatibleStateImageBehavior = False
        Me.ingresot_lv_imagenes.View = System.Windows.Forms.View.SmallIcon
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 70
        '
        'ingresot_pic_saveimages
        '
        Me.ingresot_pic_saveimages.Location = New System.Drawing.Point(342, 541)
        Me.ingresot_pic_saveimages.Name = "ingresot_pic_saveimages"
        Me.ingresot_pic_saveimages.Size = New System.Drawing.Size(137, 36)
        Me.ingresot_pic_saveimages.TabIndex = 24
        Me.ingresot_pic_saveimages.TabStop = False
        '
        'ingresot_il_fotos
        '
        Me.ingresot_il_fotos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ingresot_il_fotos.ImageSize = New System.Drawing.Size(16, 16)
        Me.ingresot_il_fotos.TransparentColor = System.Drawing.Color.Transparent
        '
        'form_ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(889, 585)
        Me.Controls.Add(Me.ingresot_pic_saveimages)
        Me.Controls.Add(Me.ingresot_pn_imgcontainer)
        Me.Controls.Add(Me.ingreso_txt_not)
        Me.Controls.Add(Me.ingresot_pic_ot)
        Me.Controls.Add(Me.ingresot_pic_title)
        Me.Controls.Add(Me.ingreso_gp_datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_ingreso"
        Me.Text = "Ingreso"
        Me.ingreso_gp_datos.ResumeLayout(False)
        Me.ingreso_gp_datos.PerformLayout()
        CType(Me.ingresot_pic_saveot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ingreso_gp_tproceso.ResumeLayout(False)
        Me.ingreso_gp_tproceso.PerformLayout()
        CType(Me.ingresot_pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ingresot_pic_ot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ingresot_pn_imgcontainer.ResumeLayout(False)
        CType(Me.ingresot_pic_saveimages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ingreso_gp_datos As System.Windows.Forms.GroupBox
    Friend WithEvents ingresot_pic_title As System.Windows.Forms.PictureBox
    Friend WithEvents ingresot_pic_ot As System.Windows.Forms.PictureBox
    Friend WithEvents ingreso_txt_not As System.Windows.Forms.TextBox
    Friend WithEvents ingreso_gp_tproceso As System.Windows.Forms.GroupBox
    Friend WithEvents ingreso_rb_garantia As System.Windows.Forms.RadioButton
    Friend WithEvents ingreso_rb_presupuesto As System.Windows.Forms.RadioButton
    Friend WithEvents ingreso_lbl_rservicio As System.Windows.Forms.Label
    Friend WithEvents ingreso_txt_rservicio As System.Windows.Forms.TextBox
    Friend WithEvents ingreso_txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ingreso_lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents ingreso_lbl_cliente As System.Windows.Forms.Label
    Friend WithEvents ingreso_cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents ingreso_txt_guia As System.Windows.Forms.TextBox
    Friend WithEvents ingreso_lbl_nguia As System.Windows.Forms.Label
    Friend WithEvents ingreso_txt_iequipo As System.Windows.Forms.TextBox
    Friend WithEvents ingreso_lbl_iequipo As System.Windows.Forms.Label
    Friend WithEvents ingreso_cmb_modelo As System.Windows.Forms.ComboBox
    Friend WithEvents ingreso_lbl_modelo As System.Windows.Forms.Label
    Friend WithEvents ingreso_cmb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents ingreso_lbl_marca As System.Windows.Forms.Label
    Friend WithEvents ingreso_cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents ingreso_lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents ingreso_lbl_addcliente As System.Windows.Forms.LinkLabel
    Friend WithEvents ingreso_tp_help As System.Windows.Forms.ToolTip
    Friend WithEvents ingreso_lbl_addtipo As System.Windows.Forms.LinkLabel
    Friend WithEvents ingreso_lbl_addmodelo As System.Windows.Forms.LinkLabel
    Friend WithEvents ingreso_lbl_addmarca As System.Windows.Forms.LinkLabel
    Friend WithEvents ingreso_txt_nserie As System.Windows.Forms.TextBox
    Friend WithEvents ingreso_lbl_nserie As System.Windows.Forms.Label
    Friend WithEvents ingresot_pn_imgcontainer As System.Windows.Forms.Panel
    Friend WithEvents ingresot_pic_saveot As System.Windows.Forms.PictureBox
    Friend WithEvents ingresot_pic_saveimages As System.Windows.Forms.PictureBox
    Friend WithEvents ingresot_il_fotos As System.Windows.Forms.ImageList
    Friend WithEvents ingresot_lv_imagenes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
