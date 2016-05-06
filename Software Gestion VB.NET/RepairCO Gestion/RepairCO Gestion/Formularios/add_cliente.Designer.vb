<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_cliente
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
        Me.addcliente_title = New System.Windows.Forms.PictureBox()
        Me.addcliente_close = New System.Windows.Forms.PictureBox()
        Me.addcliente_tp_help = New System.Windows.Forms.ToolTip(Me.components)
        Me.addcliente_gb_dcliente = New System.Windows.Forms.GroupBox()
        Me.addcliente_pic_btnadd = New System.Windows.Forms.PictureBox()
        Me.addcliente_lbl_rut = New System.Windows.Forms.Label()
        Me.addcliente_txt_rut = New System.Windows.Forms.TextBox()
        Me.addcliente_pic_titleicon = New System.Windows.Forms.PictureBox()
        Me.addcliente_txt_rs = New System.Windows.Forms.TextBox()
        Me.addcliente_lbl_rs = New System.Windows.Forms.Label()
        Me.addcliente_lbl_direccion = New System.Windows.Forms.Label()
        Me.addcliente_txt_direccion = New System.Windows.Forms.TextBox()
        Me.addcliente_lbl_ciudad = New System.Windows.Forms.Label()
        Me.addcliente_cmb_ciudad = New System.Windows.Forms.ComboBox()
        Me.addcliente_lbl_telefono = New System.Windows.Forms.Label()
        Me.addcliente_txt_telefonocode = New System.Windows.Forms.TextBox()
        Me.addcliente_txt_telefono = New System.Windows.Forms.TextBox()
        Me.addcliente_lbl_correo = New System.Windows.Forms.Label()
        Me.addcliente_txt_correo = New System.Windows.Forms.TextBox()
        Me.addcliente_gb_contacto = New System.Windows.Forms.GroupBox()
        Me.addcliente_chk_contacto = New System.Windows.Forms.CheckBox()
        Me.addcliente_lbl_cnombres = New System.Windows.Forms.Label()
        Me.addcliente_txt_cnombres = New System.Windows.Forms.TextBox()
        Me.addcliente_lbl_capellidop = New System.Windows.Forms.Label()
        Me.addcliente_txt_capellidop = New System.Windows.Forms.TextBox()
        Me.addcliente_lbl_capellidom = New System.Windows.Forms.Label()
        Me.addcliente_txt_capellidom = New System.Windows.Forms.TextBox()
        Me.addcliente_lbl_ccorreo = New System.Windows.Forms.Label()
        Me.addcliente_txt_ccorreo = New System.Windows.Forms.TextBox()
        Me.addcliente_lbl_ctelefono = New System.Windows.Forms.Label()
        Me.addcliente_txt_ctelefonocode = New System.Windows.Forms.TextBox()
        Me.addcliente_txt_ctelefono = New System.Windows.Forms.TextBox()
        Me.addcliente_lbl_ccargo = New System.Windows.Forms.Label()
        Me.addcliente_txt_ccargo = New System.Windows.Forms.TextBox()
        CType(Me.addcliente_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addcliente_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addcliente_gb_dcliente.SuspendLayout()
        CType(Me.addcliente_pic_btnadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addcliente_pic_titleicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addcliente_gb_contacto.SuspendLayout()
        Me.SuspendLayout()
        '
        'addcliente_title
        '
        Me.addcliente_title.Location = New System.Drawing.Point(12, 17)
        Me.addcliente_title.Name = "addcliente_title"
        Me.addcliente_title.Size = New System.Drawing.Size(217, 25)
        Me.addcliente_title.TabIndex = 1
        Me.addcliente_title.TabStop = False
        '
        'addcliente_close
        '
        Me.addcliente_close.BackColor = System.Drawing.Color.Transparent
        Me.addcliente_close.Location = New System.Drawing.Point(668, 12)
        Me.addcliente_close.Name = "addcliente_close"
        Me.addcliente_close.Size = New System.Drawing.Size(32, 32)
        Me.addcliente_close.TabIndex = 2
        Me.addcliente_close.TabStop = False
        '
        'addcliente_gb_dcliente
        '
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_chk_contacto)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_gb_contacto)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_txt_correo)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_lbl_correo)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_txt_telefono)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_txt_telefonocode)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_lbl_telefono)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_cmb_ciudad)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_lbl_ciudad)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_txt_direccion)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_lbl_direccion)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_lbl_rs)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_txt_rs)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_txt_rut)
        Me.addcliente_gb_dcliente.Controls.Add(Me.addcliente_lbl_rut)
        Me.addcliente_gb_dcliente.Location = New System.Drawing.Point(12, 42)
        Me.addcliente_gb_dcliente.Name = "addcliente_gb_dcliente"
        Me.addcliente_gb_dcliente.Size = New System.Drawing.Size(688, 213)
        Me.addcliente_gb_dcliente.TabIndex = 3
        Me.addcliente_gb_dcliente.TabStop = False
        '
        'addcliente_pic_btnadd
        '
        Me.addcliente_pic_btnadd.Location = New System.Drawing.Point(563, 258)
        Me.addcliente_pic_btnadd.Name = "addcliente_pic_btnadd"
        Me.addcliente_pic_btnadd.Size = New System.Drawing.Size(137, 36)
        Me.addcliente_pic_btnadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addcliente_pic_btnadd.TabIndex = 4
        Me.addcliente_pic_btnadd.TabStop = False
        '
        'addcliente_lbl_rut
        '
        Me.addcliente_lbl_rut.AutoSize = True
        Me.addcliente_lbl_rut.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_rut.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_rut.Location = New System.Drawing.Point(6, 16)
        Me.addcliente_lbl_rut.Name = "addcliente_lbl_rut"
        Me.addcliente_lbl_rut.Size = New System.Drawing.Size(35, 12)
        Me.addcliente_lbl_rut.TabIndex = 0
        Me.addcliente_lbl_rut.Text = "R.U.T"
        '
        'addcliente_txt_rut
        '
        Me.addcliente_txt_rut.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_rut.Location = New System.Drawing.Point(8, 31)
        Me.addcliente_txt_rut.Name = "addcliente_txt_rut"
        Me.addcliente_txt_rut.Size = New System.Drawing.Size(118, 18)
        Me.addcliente_txt_rut.TabIndex = 1
        '
        'addcliente_pic_titleicon
        '
        Me.addcliente_pic_titleicon.Location = New System.Drawing.Point(235, 15)
        Me.addcliente_pic_titleicon.Name = "addcliente_pic_titleicon"
        Me.addcliente_pic_titleicon.Size = New System.Drawing.Size(32, 32)
        Me.addcliente_pic_titleicon.TabIndex = 5
        Me.addcliente_pic_titleicon.TabStop = False
        '
        'addcliente_txt_rs
        '
        Me.addcliente_txt_rs.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_rs.Location = New System.Drawing.Point(147, 31)
        Me.addcliente_txt_rs.Name = "addcliente_txt_rs"
        Me.addcliente_txt_rs.Size = New System.Drawing.Size(251, 18)
        Me.addcliente_txt_rs.TabIndex = 2
        '
        'addcliente_lbl_rs
        '
        Me.addcliente_lbl_rs.AutoSize = True
        Me.addcliente_lbl_rs.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_rs.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_rs.Location = New System.Drawing.Point(145, 16)
        Me.addcliente_lbl_rs.Name = "addcliente_lbl_rs"
        Me.addcliente_lbl_rs.Size = New System.Drawing.Size(88, 12)
        Me.addcliente_lbl_rs.TabIndex = 3
        Me.addcliente_lbl_rs.Text = "RAZON SOCIAL"
        '
        'addcliente_lbl_direccion
        '
        Me.addcliente_lbl_direccion.AutoSize = True
        Me.addcliente_lbl_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_direccion.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_direccion.Location = New System.Drawing.Point(415, 16)
        Me.addcliente_lbl_direccion.Name = "addcliente_lbl_direccion"
        Me.addcliente_lbl_direccion.Size = New System.Drawing.Size(68, 12)
        Me.addcliente_lbl_direccion.TabIndex = 4
        Me.addcliente_lbl_direccion.Text = "DIRECCION"
        '
        'addcliente_txt_direccion
        '
        Me.addcliente_txt_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_direccion.Location = New System.Drawing.Point(417, 31)
        Me.addcliente_txt_direccion.Name = "addcliente_txt_direccion"
        Me.addcliente_txt_direccion.Size = New System.Drawing.Size(248, 18)
        Me.addcliente_txt_direccion.TabIndex = 5
        '
        'addcliente_lbl_ciudad
        '
        Me.addcliente_lbl_ciudad.AutoSize = True
        Me.addcliente_lbl_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_ciudad.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_ciudad.Location = New System.Drawing.Point(6, 61)
        Me.addcliente_lbl_ciudad.Name = "addcliente_lbl_ciudad"
        Me.addcliente_lbl_ciudad.Size = New System.Drawing.Size(49, 12)
        Me.addcliente_lbl_ciudad.TabIndex = 6
        Me.addcliente_lbl_ciudad.Text = "CIUDAD"
        '
        'addcliente_cmb_ciudad
        '
        Me.addcliente_cmb_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_cmb_ciudad.FormattingEnabled = True
        Me.addcliente_cmb_ciudad.Location = New System.Drawing.Point(8, 76)
        Me.addcliente_cmb_ciudad.Name = "addcliente_cmb_ciudad"
        Me.addcliente_cmb_ciudad.Size = New System.Drawing.Size(140, 20)
        Me.addcliente_cmb_ciudad.TabIndex = 7
        '
        'addcliente_lbl_telefono
        '
        Me.addcliente_lbl_telefono.AutoSize = True
        Me.addcliente_lbl_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_telefono.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_telefono.Location = New System.Drawing.Point(171, 61)
        Me.addcliente_lbl_telefono.Name = "addcliente_lbl_telefono"
        Me.addcliente_lbl_telefono.Size = New System.Drawing.Size(62, 12)
        Me.addcliente_lbl_telefono.TabIndex = 8
        Me.addcliente_lbl_telefono.Text = "TELEFONO"
        '
        'addcliente_txt_telefonocode
        '
        Me.addcliente_txt_telefonocode.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_telefonocode.Location = New System.Drawing.Point(173, 76)
        Me.addcliente_txt_telefonocode.Name = "addcliente_txt_telefonocode"
        Me.addcliente_txt_telefonocode.ReadOnly = True
        Me.addcliente_txt_telefonocode.Size = New System.Drawing.Size(25, 18)
        Me.addcliente_txt_telefonocode.TabIndex = 9
        '
        'addcliente_txt_telefono
        '
        Me.addcliente_txt_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_telefono.Location = New System.Drawing.Point(204, 76)
        Me.addcliente_txt_telefono.Name = "addcliente_txt_telefono"
        Me.addcliente_txt_telefono.Size = New System.Drawing.Size(87, 18)
        Me.addcliente_txt_telefono.TabIndex = 10
        '
        'addcliente_lbl_correo
        '
        Me.addcliente_lbl_correo.AutoSize = True
        Me.addcliente_lbl_correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_correo.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_correo.Location = New System.Drawing.Point(300, 61)
        Me.addcliente_lbl_correo.Name = "addcliente_lbl_correo"
        Me.addcliente_lbl_correo.Size = New System.Drawing.Size(133, 12)
        Me.addcliente_lbl_correo.TabIndex = 11
        Me.addcliente_lbl_correo.Text = "CORREO ELECTRONICO"
        '
        'addcliente_txt_correo
        '
        Me.addcliente_txt_correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_correo.Location = New System.Drawing.Point(302, 76)
        Me.addcliente_txt_correo.Name = "addcliente_txt_correo"
        Me.addcliente_txt_correo.Size = New System.Drawing.Size(159, 18)
        Me.addcliente_txt_correo.TabIndex = 12
        '
        'addcliente_gb_contacto
        '
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_txt_ccargo)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_lbl_ccargo)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_txt_ctelefono)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_txt_ctelefonocode)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_lbl_ctelefono)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_txt_ccorreo)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_lbl_ccorreo)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_txt_capellidom)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_lbl_capellidom)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_txt_capellidop)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_lbl_capellidop)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_txt_cnombres)
        Me.addcliente_gb_contacto.Controls.Add(Me.addcliente_lbl_cnombres)
        Me.addcliente_gb_contacto.Enabled = False
        Me.addcliente_gb_contacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_gb_contacto.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_gb_contacto.Location = New System.Drawing.Point(8, 107)
        Me.addcliente_gb_contacto.Name = "addcliente_gb_contacto"
        Me.addcliente_gb_contacto.Size = New System.Drawing.Size(657, 94)
        Me.addcliente_gb_contacto.TabIndex = 13
        Me.addcliente_gb_contacto.TabStop = False
        Me.addcliente_gb_contacto.Text = "CONTACTO EMPRESA"
        '
        'addcliente_chk_contacto
        '
        Me.addcliente_chk_contacto.AutoSize = True
        Me.addcliente_chk_contacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_chk_contacto.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_chk_contacto.Location = New System.Drawing.Point(509, 76)
        Me.addcliente_chk_contacto.Name = "addcliente_chk_contacto"
        Me.addcliente_chk_contacto.Size = New System.Drawing.Size(136, 16)
        Me.addcliente_chk_contacto.TabIndex = 14
        Me.addcliente_chk_contacto.Text = "CONTACTO INTERNO"
        Me.addcliente_chk_contacto.UseVisualStyleBackColor = True
        '
        'addcliente_lbl_cnombres
        '
        Me.addcliente_lbl_cnombres.AutoSize = True
        Me.addcliente_lbl_cnombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_cnombres.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_cnombres.Location = New System.Drawing.Point(6, 18)
        Me.addcliente_lbl_cnombres.Name = "addcliente_lbl_cnombres"
        Me.addcliente_lbl_cnombres.Size = New System.Drawing.Size(60, 12)
        Me.addcliente_lbl_cnombres.TabIndex = 1
        Me.addcliente_lbl_cnombres.Text = "NOMBRES"
        '
        'addcliente_txt_cnombres
        '
        Me.addcliente_txt_cnombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_cnombres.Location = New System.Drawing.Point(8, 33)
        Me.addcliente_txt_cnombres.Name = "addcliente_txt_cnombres"
        Me.addcliente_txt_cnombres.Size = New System.Drawing.Size(164, 18)
        Me.addcliente_txt_cnombres.TabIndex = 3
        '
        'addcliente_lbl_capellidop
        '
        Me.addcliente_lbl_capellidop.AutoSize = True
        Me.addcliente_lbl_capellidop.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_capellidop.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_capellidop.Location = New System.Drawing.Point(187, 18)
        Me.addcliente_lbl_capellidop.Name = "addcliente_lbl_capellidop"
        Me.addcliente_lbl_capellidop.Size = New System.Drawing.Size(114, 12)
        Me.addcliente_lbl_capellidop.TabIndex = 4
        Me.addcliente_lbl_capellidop.Text = "APELLIDO PATERNO"
        '
        'addcliente_txt_capellidop
        '
        Me.addcliente_txt_capellidop.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_capellidop.Location = New System.Drawing.Point(189, 33)
        Me.addcliente_txt_capellidop.Name = "addcliente_txt_capellidop"
        Me.addcliente_txt_capellidop.Size = New System.Drawing.Size(221, 18)
        Me.addcliente_txt_capellidop.TabIndex = 5
        '
        'addcliente_lbl_capellidom
        '
        Me.addcliente_lbl_capellidom.AutoSize = True
        Me.addcliente_lbl_capellidom.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_capellidom.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_capellidom.Location = New System.Drawing.Point(425, 18)
        Me.addcliente_lbl_capellidom.Name = "addcliente_lbl_capellidom"
        Me.addcliente_lbl_capellidom.Size = New System.Drawing.Size(117, 12)
        Me.addcliente_lbl_capellidom.TabIndex = 6
        Me.addcliente_lbl_capellidom.Text = "APELLIDO MATERNO"
        '
        'addcliente_txt_capellidom
        '
        Me.addcliente_txt_capellidom.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_capellidom.Location = New System.Drawing.Point(427, 33)
        Me.addcliente_txt_capellidom.Name = "addcliente_txt_capellidom"
        Me.addcliente_txt_capellidom.Size = New System.Drawing.Size(210, 18)
        Me.addcliente_txt_capellidom.TabIndex = 7
        '
        'addcliente_lbl_ccorreo
        '
        Me.addcliente_lbl_ccorreo.AutoSize = True
        Me.addcliente_lbl_ccorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_ccorreo.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_ccorreo.Location = New System.Drawing.Point(6, 54)
        Me.addcliente_lbl_ccorreo.Name = "addcliente_lbl_ccorreo"
        Me.addcliente_lbl_ccorreo.Size = New System.Drawing.Size(133, 12)
        Me.addcliente_lbl_ccorreo.TabIndex = 8
        Me.addcliente_lbl_ccorreo.Text = "CORREO ELECTRONICO"
        '
        'addcliente_txt_ccorreo
        '
        Me.addcliente_txt_ccorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_ccorreo.Location = New System.Drawing.Point(8, 67)
        Me.addcliente_txt_ccorreo.Name = "addcliente_txt_ccorreo"
        Me.addcliente_txt_ccorreo.Size = New System.Drawing.Size(164, 18)
        Me.addcliente_txt_ccorreo.TabIndex = 9
        '
        'addcliente_lbl_ctelefono
        '
        Me.addcliente_lbl_ctelefono.AutoSize = True
        Me.addcliente_lbl_ctelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_ctelefono.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_ctelefono.Location = New System.Drawing.Point(187, 54)
        Me.addcliente_lbl_ctelefono.Name = "addcliente_lbl_ctelefono"
        Me.addcliente_lbl_ctelefono.Size = New System.Drawing.Size(62, 12)
        Me.addcliente_lbl_ctelefono.TabIndex = 10
        Me.addcliente_lbl_ctelefono.Text = "TELEFONO"
        '
        'addcliente_txt_ctelefonocode
        '
        Me.addcliente_txt_ctelefonocode.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_ctelefonocode.Location = New System.Drawing.Point(189, 67)
        Me.addcliente_txt_ctelefonocode.Name = "addcliente_txt_ctelefonocode"
        Me.addcliente_txt_ctelefonocode.ReadOnly = True
        Me.addcliente_txt_ctelefonocode.Size = New System.Drawing.Size(25, 18)
        Me.addcliente_txt_ctelefonocode.TabIndex = 11
        '
        'addcliente_txt_ctelefono
        '
        Me.addcliente_txt_ctelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_ctelefono.Location = New System.Drawing.Point(220, 67)
        Me.addcliente_txt_ctelefono.Name = "addcliente_txt_ctelefono"
        Me.addcliente_txt_ctelefono.Size = New System.Drawing.Size(96, 18)
        Me.addcliente_txt_ctelefono.TabIndex = 12
        '
        'addcliente_lbl_ccargo
        '
        Me.addcliente_lbl_ccargo.AutoSize = True
        Me.addcliente_lbl_ccargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_lbl_ccargo.ForeColor = System.Drawing.Color.DarkOrange
        Me.addcliente_lbl_ccargo.Location = New System.Drawing.Point(332, 54)
        Me.addcliente_lbl_ccargo.Name = "addcliente_lbl_ccargo"
        Me.addcliente_lbl_ccargo.Size = New System.Drawing.Size(45, 12)
        Me.addcliente_lbl_ccargo.TabIndex = 13
        Me.addcliente_lbl_ccargo.Text = "CARGO"
        '
        'addcliente_txt_ccargo
        '
        Me.addcliente_txt_ccargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcliente_txt_ccargo.Location = New System.Drawing.Point(334, 67)
        Me.addcliente_txt_ccargo.Name = "addcliente_txt_ccargo"
        Me.addcliente_txt_ccargo.Size = New System.Drawing.Size(164, 18)
        Me.addcliente_txt_ccargo.TabIndex = 14
        '
        'add_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(712, 319)
        Me.Controls.Add(Me.addcliente_pic_titleicon)
        Me.Controls.Add(Me.addcliente_pic_btnadd)
        Me.Controls.Add(Me.addcliente_gb_dcliente)
        Me.Controls.Add(Me.addcliente_close)
        Me.Controls.Add(Me.addcliente_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_cliente"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_cliente"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.addcliente_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addcliente_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addcliente_gb_dcliente.ResumeLayout(False)
        Me.addcliente_gb_dcliente.PerformLayout()
        CType(Me.addcliente_pic_btnadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addcliente_pic_titleicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addcliente_gb_contacto.ResumeLayout(False)
        Me.addcliente_gb_contacto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents addcliente_title As System.Windows.Forms.PictureBox
    Friend WithEvents addcliente_close As System.Windows.Forms.PictureBox
    Friend WithEvents addcliente_tp_help As System.Windows.Forms.ToolTip
    Friend WithEvents addcliente_gb_dcliente As System.Windows.Forms.GroupBox
    Friend WithEvents addcliente_pic_btnadd As System.Windows.Forms.PictureBox
    Friend WithEvents addcliente_txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_lbl_rut As System.Windows.Forms.Label
    Friend WithEvents addcliente_pic_titleicon As System.Windows.Forms.PictureBox
    Friend WithEvents addcliente_lbl_rs As System.Windows.Forms.Label
    Friend WithEvents addcliente_txt_rs As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents addcliente_lbl_ciudad As System.Windows.Forms.Label
    Friend WithEvents addcliente_cmb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents addcliente_txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_txt_telefonocode As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents addcliente_txt_correo As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_lbl_correo As System.Windows.Forms.Label
    Friend WithEvents addcliente_gb_contacto As System.Windows.Forms.GroupBox
    Friend WithEvents addcliente_chk_contacto As System.Windows.Forms.CheckBox
    Friend WithEvents addcliente_txt_ccargo As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_lbl_ccargo As System.Windows.Forms.Label
    Friend WithEvents addcliente_txt_ctelefono As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_txt_ctelefonocode As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_lbl_ctelefono As System.Windows.Forms.Label
    Friend WithEvents addcliente_txt_ccorreo As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_lbl_ccorreo As System.Windows.Forms.Label
    Friend WithEvents addcliente_txt_capellidom As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_lbl_capellidom As System.Windows.Forms.Label
    Friend WithEvents addcliente_txt_capellidop As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_lbl_capellidop As System.Windows.Forms.Label
    Friend WithEvents addcliente_txt_cnombres As System.Windows.Forms.TextBox
    Friend WithEvents addcliente_lbl_cnombres As System.Windows.Forms.Label
End Class
