<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_marca
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
        Me.addmarca_pic_title = New System.Windows.Forms.PictureBox()
        Me.addmarca_gb_datos = New System.Windows.Forms.GroupBox()
        Me.addmarca_cmb_pais = New System.Windows.Forms.ComboBox()
        Me.addmarca_lbl_pais = New System.Windows.Forms.Label()
        Me.addmarca_txt_nombre = New System.Windows.Forms.TextBox()
        Me.addmarca_lbl_nombre = New System.Windows.Forms.Label()
        Me.addmarca_cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.addmarca_lbl_tipo = New System.Windows.Forms.Label()
        Me.addmarca_pic_close = New System.Windows.Forms.PictureBox()
        Me.addmarca_pic_btnadd = New System.Windows.Forms.PictureBox()
        Me.addmarca_tp_help = New System.Windows.Forms.ToolTip(Me.components)
        Me.addmarca_pic_ico = New System.Windows.Forms.PictureBox()
        CType(Me.addmarca_pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addmarca_gb_datos.SuspendLayout()
        CType(Me.addmarca_pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addmarca_pic_btnadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addmarca_pic_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addmarca_pic_title
        '
        Me.addmarca_pic_title.Location = New System.Drawing.Point(22, 25)
        Me.addmarca_pic_title.Name = "addmarca_pic_title"
        Me.addmarca_pic_title.Size = New System.Drawing.Size(173, 22)
        Me.addmarca_pic_title.TabIndex = 0
        Me.addmarca_pic_title.TabStop = False
        '
        'addmarca_gb_datos
        '
        Me.addmarca_gb_datos.Controls.Add(Me.addmarca_cmb_pais)
        Me.addmarca_gb_datos.Controls.Add(Me.addmarca_lbl_pais)
        Me.addmarca_gb_datos.Controls.Add(Me.addmarca_txt_nombre)
        Me.addmarca_gb_datos.Controls.Add(Me.addmarca_lbl_nombre)
        Me.addmarca_gb_datos.Controls.Add(Me.addmarca_cmb_tipo)
        Me.addmarca_gb_datos.Controls.Add(Me.addmarca_lbl_tipo)
        Me.addmarca_gb_datos.Location = New System.Drawing.Point(22, 53)
        Me.addmarca_gb_datos.Name = "addmarca_gb_datos"
        Me.addmarca_gb_datos.Size = New System.Drawing.Size(453, 112)
        Me.addmarca_gb_datos.TabIndex = 1
        Me.addmarca_gb_datos.TabStop = False
        '
        'addmarca_cmb_pais
        '
        Me.addmarca_cmb_pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmarca_cmb_pais.FormattingEnabled = True
        Me.addmarca_cmb_pais.Location = New System.Drawing.Point(8, 73)
        Me.addmarca_cmb_pais.Name = "addmarca_cmb_pais"
        Me.addmarca_cmb_pais.Size = New System.Drawing.Size(174, 20)
        Me.addmarca_cmb_pais.TabIndex = 5
        '
        'addmarca_lbl_pais
        '
        Me.addmarca_lbl_pais.AutoSize = True
        Me.addmarca_lbl_pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmarca_lbl_pais.ForeColor = System.Drawing.Color.DarkOrange
        Me.addmarca_lbl_pais.Location = New System.Drawing.Point(6, 58)
        Me.addmarca_lbl_pais.Name = "addmarca_lbl_pais"
        Me.addmarca_lbl_pais.Size = New System.Drawing.Size(115, 12)
        Me.addmarca_lbl_pais.TabIndex = 4
        Me.addmarca_lbl_pais.Text = "PAIS PROCEDENCIA"
        '
        'addmarca_txt_nombre
        '
        Me.addmarca_txt_nombre.Location = New System.Drawing.Point(207, 35)
        Me.addmarca_txt_nombre.Name = "addmarca_txt_nombre"
        Me.addmarca_txt_nombre.Size = New System.Drawing.Size(234, 20)
        Me.addmarca_txt_nombre.TabIndex = 3
        '
        'addmarca_lbl_nombre
        '
        Me.addmarca_lbl_nombre.AutoSize = True
        Me.addmarca_lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmarca_lbl_nombre.ForeColor = System.Drawing.Color.DarkOrange
        Me.addmarca_lbl_nombre.Location = New System.Drawing.Point(205, 16)
        Me.addmarca_lbl_nombre.Name = "addmarca_lbl_nombre"
        Me.addmarca_lbl_nombre.Size = New System.Drawing.Size(98, 12)
        Me.addmarca_lbl_nombre.TabIndex = 2
        Me.addmarca_lbl_nombre.Text = "NOMBRE MARCA"
        '
        'addmarca_cmb_tipo
        '
        Me.addmarca_cmb_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmarca_cmb_tipo.FormattingEnabled = True
        Me.addmarca_cmb_tipo.Location = New System.Drawing.Point(8, 35)
        Me.addmarca_cmb_tipo.Name = "addmarca_cmb_tipo"
        Me.addmarca_cmb_tipo.Size = New System.Drawing.Size(174, 20)
        Me.addmarca_cmb_tipo.TabIndex = 1
        '
        'addmarca_lbl_tipo
        '
        Me.addmarca_lbl_tipo.AutoSize = True
        Me.addmarca_lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmarca_lbl_tipo.ForeColor = System.Drawing.Color.DarkOrange
        Me.addmarca_lbl_tipo.Location = New System.Drawing.Point(6, 16)
        Me.addmarca_lbl_tipo.Name = "addmarca_lbl_tipo"
        Me.addmarca_lbl_tipo.Size = New System.Drawing.Size(94, 12)
        Me.addmarca_lbl_tipo.TabIndex = 0
        Me.addmarca_lbl_tipo.Text = "TIPO PRODUCTO"
        '
        'addmarca_pic_close
        '
        Me.addmarca_pic_close.Location = New System.Drawing.Point(443, 18)
        Me.addmarca_pic_close.Name = "addmarca_pic_close"
        Me.addmarca_pic_close.Size = New System.Drawing.Size(32, 32)
        Me.addmarca_pic_close.TabIndex = 2
        Me.addmarca_pic_close.TabStop = False
        '
        'addmarca_pic_btnadd
        '
        Me.addmarca_pic_btnadd.Location = New System.Drawing.Point(338, 171)
        Me.addmarca_pic_btnadd.Name = "addmarca_pic_btnadd"
        Me.addmarca_pic_btnadd.Size = New System.Drawing.Size(137, 36)
        Me.addmarca_pic_btnadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addmarca_pic_btnadd.TabIndex = 3
        Me.addmarca_pic_btnadd.TabStop = False
        '
        'addmarca_pic_ico
        '
        Me.addmarca_pic_ico.Location = New System.Drawing.Point(201, 20)
        Me.addmarca_pic_ico.Name = "addmarca_pic_ico"
        Me.addmarca_pic_ico.Size = New System.Drawing.Size(32, 32)
        Me.addmarca_pic_ico.TabIndex = 4
        Me.addmarca_pic_ico.TabStop = False
        '
        'add_marca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 226)
        Me.Controls.Add(Me.addmarca_pic_ico)
        Me.Controls.Add(Me.addmarca_pic_btnadd)
        Me.Controls.Add(Me.addmarca_pic_close)
        Me.Controls.Add(Me.addmarca_gb_datos)
        Me.Controls.Add(Me.addmarca_pic_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_marca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_marca"
        CType(Me.addmarca_pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addmarca_gb_datos.ResumeLayout(False)
        Me.addmarca_gb_datos.PerformLayout()
        CType(Me.addmarca_pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addmarca_pic_btnadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addmarca_pic_ico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents addmarca_pic_title As System.Windows.Forms.PictureBox
    Friend WithEvents addmarca_gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents addmarca_pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents addmarca_pic_btnadd As System.Windows.Forms.PictureBox
    Friend WithEvents addmarca_txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents addmarca_lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents addmarca_cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents addmarca_lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents addmarca_cmb_pais As System.Windows.Forms.ComboBox
    Friend WithEvents addmarca_lbl_pais As System.Windows.Forms.Label
    Friend WithEvents addmarca_tp_help As System.Windows.Forms.ToolTip
    Friend WithEvents addmarca_pic_ico As System.Windows.Forms.PictureBox
End Class
