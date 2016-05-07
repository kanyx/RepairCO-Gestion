<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_modelo
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
        Me.addmodelo_gb_datos = New System.Windows.Forms.GroupBox()
        Me.addmodelo_pic_close = New System.Windows.Forms.PictureBox()
        Me.addmodelo_pic_title = New System.Windows.Forms.PictureBox()
        Me.addmodelo_pic_ico = New System.Windows.Forms.PictureBox()
        Me.addmodelo_pic_add = New System.Windows.Forms.PictureBox()
        Me.addmodelo_lbl_marca = New System.Windows.Forms.Label()
        Me.addmodelo_cmb_marca = New System.Windows.Forms.ComboBox()
        Me.addmodelo_lbl_modelo = New System.Windows.Forms.Label()
        Me.addmodelo_txt_modelo = New System.Windows.Forms.TextBox()
        Me.addmodelo_tp_help = New System.Windows.Forms.ToolTip(Me.components)
        Me.addmodelo_gb_datos.SuspendLayout()
        CType(Me.addmodelo_pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addmodelo_pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addmodelo_pic_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addmodelo_pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addmodelo_gb_datos
        '
        Me.addmodelo_gb_datos.Controls.Add(Me.addmodelo_txt_modelo)
        Me.addmodelo_gb_datos.Controls.Add(Me.addmodelo_lbl_modelo)
        Me.addmodelo_gb_datos.Controls.Add(Me.addmodelo_cmb_marca)
        Me.addmodelo_gb_datos.Controls.Add(Me.addmodelo_lbl_marca)
        Me.addmodelo_gb_datos.Location = New System.Drawing.Point(12, 49)
        Me.addmodelo_gb_datos.Name = "addmodelo_gb_datos"
        Me.addmodelo_gb_datos.Size = New System.Drawing.Size(469, 122)
        Me.addmodelo_gb_datos.TabIndex = 0
        Me.addmodelo_gb_datos.TabStop = False
        '
        'addmodelo_pic_close
        '
        Me.addmodelo_pic_close.Location = New System.Drawing.Point(449, 16)
        Me.addmodelo_pic_close.Name = "addmodelo_pic_close"
        Me.addmodelo_pic_close.Size = New System.Drawing.Size(32, 32)
        Me.addmodelo_pic_close.TabIndex = 1
        Me.addmodelo_pic_close.TabStop = False
        '
        'addmodelo_pic_title
        '
        Me.addmodelo_pic_title.Location = New System.Drawing.Point(12, 20)
        Me.addmodelo_pic_title.Name = "addmodelo_pic_title"
        Me.addmodelo_pic_title.Size = New System.Drawing.Size(173, 22)
        Me.addmodelo_pic_title.TabIndex = 2
        Me.addmodelo_pic_title.TabStop = False
        '
        'addmodelo_pic_ico
        '
        Me.addmodelo_pic_ico.Location = New System.Drawing.Point(191, 16)
        Me.addmodelo_pic_ico.Name = "addmodelo_pic_ico"
        Me.addmodelo_pic_ico.Size = New System.Drawing.Size(32, 32)
        Me.addmodelo_pic_ico.TabIndex = 3
        Me.addmodelo_pic_ico.TabStop = False
        '
        'addmodelo_pic_add
        '
        Me.addmodelo_pic_add.Location = New System.Drawing.Point(344, 178)
        Me.addmodelo_pic_add.Name = "addmodelo_pic_add"
        Me.addmodelo_pic_add.Size = New System.Drawing.Size(137, 36)
        Me.addmodelo_pic_add.TabIndex = 4
        Me.addmodelo_pic_add.TabStop = False
        '
        'addmodelo_lbl_marca
        '
        Me.addmodelo_lbl_marca.AutoSize = True
        Me.addmodelo_lbl_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmodelo_lbl_marca.ForeColor = System.Drawing.Color.DarkOrange
        Me.addmodelo_lbl_marca.Location = New System.Drawing.Point(6, 32)
        Me.addmodelo_lbl_marca.Name = "addmodelo_lbl_marca"
        Me.addmodelo_lbl_marca.Size = New System.Drawing.Size(47, 12)
        Me.addmodelo_lbl_marca.TabIndex = 0
        Me.addmodelo_lbl_marca.Text = "MARCA"
        '
        'addmodelo_cmb_marca
        '
        Me.addmodelo_cmb_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmodelo_cmb_marca.FormattingEnabled = True
        Me.addmodelo_cmb_marca.Location = New System.Drawing.Point(8, 47)
        Me.addmodelo_cmb_marca.Name = "addmodelo_cmb_marca"
        Me.addmodelo_cmb_marca.Size = New System.Drawing.Size(203, 20)
        Me.addmodelo_cmb_marca.TabIndex = 1
        '
        'addmodelo_lbl_modelo
        '
        Me.addmodelo_lbl_modelo.AutoSize = True
        Me.addmodelo_lbl_modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmodelo_lbl_modelo.ForeColor = System.Drawing.Color.DarkOrange
        Me.addmodelo_lbl_modelo.Location = New System.Drawing.Point(235, 32)
        Me.addmodelo_lbl_modelo.Name = "addmodelo_lbl_modelo"
        Me.addmodelo_lbl_modelo.Size = New System.Drawing.Size(52, 12)
        Me.addmodelo_lbl_modelo.TabIndex = 2
        Me.addmodelo_lbl_modelo.Text = "MODELO"
        '
        'addmodelo_txt_modelo
        '
        Me.addmodelo_txt_modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmodelo_txt_modelo.Location = New System.Drawing.Point(237, 48)
        Me.addmodelo_txt_modelo.Name = "addmodelo_txt_modelo"
        Me.addmodelo_txt_modelo.Size = New System.Drawing.Size(223, 18)
        Me.addmodelo_txt_modelo.TabIndex = 3
        '
        'add_modelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 226)
        Me.Controls.Add(Me.addmodelo_pic_add)
        Me.Controls.Add(Me.addmodelo_pic_ico)
        Me.Controls.Add(Me.addmodelo_pic_title)
        Me.Controls.Add(Me.addmodelo_pic_close)
        Me.Controls.Add(Me.addmodelo_gb_datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_modelo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_modelo"
        Me.addmodelo_gb_datos.ResumeLayout(False)
        Me.addmodelo_gb_datos.PerformLayout()
        CType(Me.addmodelo_pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addmodelo_pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addmodelo_pic_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addmodelo_pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents addmodelo_gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents addmodelo_pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents addmodelo_pic_title As System.Windows.Forms.PictureBox
    Friend WithEvents addmodelo_pic_ico As System.Windows.Forms.PictureBox
    Friend WithEvents addmodelo_pic_add As System.Windows.Forms.PictureBox
    Friend WithEvents addmodelo_txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents addmodelo_lbl_modelo As System.Windows.Forms.Label
    Friend WithEvents addmodelo_cmb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents addmodelo_lbl_marca As System.Windows.Forms.Label
    Friend WithEvents addmodelo_tp_help As System.Windows.Forms.ToolTip
End Class
