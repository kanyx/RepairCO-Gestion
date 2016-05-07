<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_tipo
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
        Me.addtipo_gb_datos = New System.Windows.Forms.GroupBox()
        Me.addtipo_pic_close = New System.Windows.Forms.PictureBox()
        Me.addtipo_pic_title = New System.Windows.Forms.PictureBox()
        Me.addtipo_pic_add = New System.Windows.Forms.PictureBox()
        Me.addtipo_tp_help = New System.Windows.Forms.ToolTip(Me.components)
        Me.addtipo_lbl_tipo = New System.Windows.Forms.Label()
        Me.addtipo_txt_tipo = New System.Windows.Forms.TextBox()
        Me.addtipo_pic_ico = New System.Windows.Forms.PictureBox()
        Me.addtipo_gb_datos.SuspendLayout()
        CType(Me.addtipo_pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addtipo_pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addtipo_pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addtipo_pic_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addtipo_gb_datos
        '
        Me.addtipo_gb_datos.Controls.Add(Me.addtipo_txt_tipo)
        Me.addtipo_gb_datos.Controls.Add(Me.addtipo_lbl_tipo)
        Me.addtipo_gb_datos.Location = New System.Drawing.Point(12, 40)
        Me.addtipo_gb_datos.Name = "addtipo_gb_datos"
        Me.addtipo_gb_datos.Size = New System.Drawing.Size(469, 121)
        Me.addtipo_gb_datos.TabIndex = 0
        Me.addtipo_gb_datos.TabStop = False
        '
        'addtipo_pic_close
        '
        Me.addtipo_pic_close.Location = New System.Drawing.Point(449, 12)
        Me.addtipo_pic_close.Name = "addtipo_pic_close"
        Me.addtipo_pic_close.Size = New System.Drawing.Size(32, 32)
        Me.addtipo_pic_close.TabIndex = 1
        Me.addtipo_pic_close.TabStop = False
        '
        'addtipo_pic_title
        '
        Me.addtipo_pic_title.Location = New System.Drawing.Point(12, 18)
        Me.addtipo_pic_title.Name = "addtipo_pic_title"
        Me.addtipo_pic_title.Size = New System.Drawing.Size(154, 22)
        Me.addtipo_pic_title.TabIndex = 2
        Me.addtipo_pic_title.TabStop = False
        '
        'addtipo_pic_add
        '
        Me.addtipo_pic_add.Location = New System.Drawing.Point(341, 167)
        Me.addtipo_pic_add.Name = "addtipo_pic_add"
        Me.addtipo_pic_add.Size = New System.Drawing.Size(137, 36)
        Me.addtipo_pic_add.TabIndex = 3
        Me.addtipo_pic_add.TabStop = False
        '
        'addtipo_lbl_tipo
        '
        Me.addtipo_lbl_tipo.AutoSize = True
        Me.addtipo_lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addtipo_lbl_tipo.ForeColor = System.Drawing.Color.DarkOrange
        Me.addtipo_lbl_tipo.Location = New System.Drawing.Point(109, 38)
        Me.addtipo_lbl_tipo.Name = "addtipo_lbl_tipo"
        Me.addtipo_lbl_tipo.Size = New System.Drawing.Size(112, 12)
        Me.addtipo_lbl_tipo.TabIndex = 0
        Me.addtipo_lbl_tipo.Text = "TIPO DE PRODUCTO"
        '
        'addtipo_txt_tipo
        '
        Me.addtipo_txt_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addtipo_txt_tipo.Location = New System.Drawing.Point(111, 53)
        Me.addtipo_txt_tipo.Name = "addtipo_txt_tipo"
        Me.addtipo_txt_tipo.Size = New System.Drawing.Size(251, 18)
        Me.addtipo_txt_tipo.TabIndex = 1
        '
        'addtipo_pic_ico
        '
        Me.addtipo_pic_ico.Location = New System.Drawing.Point(172, 12)
        Me.addtipo_pic_ico.Name = "addtipo_pic_ico"
        Me.addtipo_pic_ico.Size = New System.Drawing.Size(32, 32)
        Me.addtipo_pic_ico.TabIndex = 4
        Me.addtipo_pic_ico.TabStop = False
        '
        'add_tipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 226)
        Me.Controls.Add(Me.addtipo_pic_ico)
        Me.Controls.Add(Me.addtipo_pic_add)
        Me.Controls.Add(Me.addtipo_pic_title)
        Me.Controls.Add(Me.addtipo_pic_close)
        Me.Controls.Add(Me.addtipo_gb_datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_tipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_tipo"
        Me.addtipo_gb_datos.ResumeLayout(False)
        Me.addtipo_gb_datos.PerformLayout()
        CType(Me.addtipo_pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addtipo_pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addtipo_pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addtipo_pic_ico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents addtipo_gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents addtipo_pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents addtipo_pic_title As System.Windows.Forms.PictureBox
    Friend WithEvents addtipo_pic_add As System.Windows.Forms.PictureBox
    Friend WithEvents addtipo_tp_help As System.Windows.Forms.ToolTip
    Friend WithEvents addtipo_txt_tipo As System.Windows.Forms.TextBox
    Friend WithEvents addtipo_lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents addtipo_pic_ico As System.Windows.Forms.PictureBox
End Class
