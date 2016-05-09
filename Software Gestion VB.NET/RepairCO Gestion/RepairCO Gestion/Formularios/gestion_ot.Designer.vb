<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestion_ot
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
        Me.gestionot_gb_resultados = New System.Windows.Forms.GroupBox()
        Me.gestionot_dg_resultados = New System.Windows.Forms.DataGridView()
        Me.gestionot_lbl_resultados = New System.Windows.Forms.Label()
        Me.gestionot_gb_filtros = New System.Windows.Forms.GroupBox()
        Me.gestionot_txt_not = New System.Windows.Forms.TextBox()
        Me.gestionot_lbl_not = New System.Windows.Forms.Label()
        Me.gestionot_lbl_cliente = New System.Windows.Forms.Label()
        Me.gestionot_pic_buscar = New System.Windows.Forms.PictureBox()
        Me.gestionot_cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.gestionot_lbl_tipo = New System.Windows.Forms.Label()
        Me.gestionot_cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.gestionot_lbl_rfilter = New System.Windows.Forms.LinkLabel()
        Me.gestionot_pic_title = New System.Windows.Forms.PictureBox()
        Me.gestionot_tp_help = New System.Windows.Forms.ToolTip(Me.components)
        Me.gestionot_gb_resultados.SuspendLayout()
        CType(Me.gestionot_dg_resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gestionot_gb_filtros.SuspendLayout()
        CType(Me.gestionot_pic_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gestionot_pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gestionot_gb_resultados
        '
        Me.gestionot_gb_resultados.Controls.Add(Me.gestionot_dg_resultados)
        Me.gestionot_gb_resultados.Location = New System.Drawing.Point(26, 143)
        Me.gestionot_gb_resultados.Name = "gestionot_gb_resultados"
        Me.gestionot_gb_resultados.Size = New System.Drawing.Size(558, 316)
        Me.gestionot_gb_resultados.TabIndex = 0
        Me.gestionot_gb_resultados.TabStop = False
        '
        'gestionot_dg_resultados
        '
        Me.gestionot_dg_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gestionot_dg_resultados.Location = New System.Drawing.Point(6, 11)
        Me.gestionot_dg_resultados.Name = "gestionot_dg_resultados"
        Me.gestionot_dg_resultados.Size = New System.Drawing.Size(546, 299)
        Me.gestionot_dg_resultados.TabIndex = 0
        '
        'gestionot_lbl_resultados
        '
        Me.gestionot_lbl_resultados.AutoSize = True
        Me.gestionot_lbl_resultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gestionot_lbl_resultados.Location = New System.Drawing.Point(29, 130)
        Me.gestionot_lbl_resultados.Name = "gestionot_lbl_resultados"
        Me.gestionot_lbl_resultados.Size = New System.Drawing.Size(85, 12)
        Me.gestionot_lbl_resultados.TabIndex = 1
        Me.gestionot_lbl_resultados.Text = "RESULTADOS: "
        '
        'gestionot_gb_filtros
        '
        Me.gestionot_gb_filtros.Controls.Add(Me.gestionot_cmb_tipo)
        Me.gestionot_gb_filtros.Controls.Add(Me.gestionot_lbl_tipo)
        Me.gestionot_gb_filtros.Controls.Add(Me.gestionot_cmb_cliente)
        Me.gestionot_gb_filtros.Controls.Add(Me.gestionot_pic_buscar)
        Me.gestionot_gb_filtros.Controls.Add(Me.gestionot_lbl_cliente)
        Me.gestionot_gb_filtros.Controls.Add(Me.gestionot_lbl_not)
        Me.gestionot_gb_filtros.Controls.Add(Me.gestionot_txt_not)
        Me.gestionot_gb_filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gestionot_gb_filtros.Location = New System.Drawing.Point(26, 53)
        Me.gestionot_gb_filtros.Name = "gestionot_gb_filtros"
        Me.gestionot_gb_filtros.Size = New System.Drawing.Size(558, 71)
        Me.gestionot_gb_filtros.TabIndex = 2
        Me.gestionot_gb_filtros.TabStop = False
        '
        'gestionot_txt_not
        '
        Me.gestionot_txt_not.Location = New System.Drawing.Point(15, 33)
        Me.gestionot_txt_not.Name = "gestionot_txt_not"
        Me.gestionot_txt_not.Size = New System.Drawing.Size(89, 20)
        Me.gestionot_txt_not.TabIndex = 0
        '
        'gestionot_lbl_not
        '
        Me.gestionot_lbl_not.AutoSize = True
        Me.gestionot_lbl_not.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gestionot_lbl_not.Location = New System.Drawing.Point(13, 18)
        Me.gestionot_lbl_not.Name = "gestionot_lbl_not"
        Me.gestionot_lbl_not.Size = New System.Drawing.Size(71, 12)
        Me.gestionot_lbl_not.TabIndex = 1
        Me.gestionot_lbl_not.Text = "NUMERO OT"
        '
        'gestionot_lbl_cliente
        '
        Me.gestionot_lbl_cliente.AutoSize = True
        Me.gestionot_lbl_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gestionot_lbl_cliente.Location = New System.Drawing.Point(112, 18)
        Me.gestionot_lbl_cliente.Name = "gestionot_lbl_cliente"
        Me.gestionot_lbl_cliente.Size = New System.Drawing.Size(51, 12)
        Me.gestionot_lbl_cliente.TabIndex = 2
        Me.gestionot_lbl_cliente.Text = "CLIENTE"
        '
        'gestionot_pic_buscar
        '
        Me.gestionot_pic_buscar.Location = New System.Drawing.Point(499, 26)
        Me.gestionot_pic_buscar.Name = "gestionot_pic_buscar"
        Me.gestionot_pic_buscar.Size = New System.Drawing.Size(32, 32)
        Me.gestionot_pic_buscar.TabIndex = 3
        Me.gestionot_pic_buscar.TabStop = False
        '
        'gestionot_cmb_cliente
        '
        Me.gestionot_cmb_cliente.FormattingEnabled = True
        Me.gestionot_cmb_cliente.Location = New System.Drawing.Point(114, 32)
        Me.gestionot_cmb_cliente.Name = "gestionot_cmb_cliente"
        Me.gestionot_cmb_cliente.Size = New System.Drawing.Size(186, 21)
        Me.gestionot_cmb_cliente.TabIndex = 4
        '
        'gestionot_lbl_tipo
        '
        Me.gestionot_lbl_tipo.AutoSize = True
        Me.gestionot_lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gestionot_lbl_tipo.Location = New System.Drawing.Point(304, 18)
        Me.gestionot_lbl_tipo.Name = "gestionot_lbl_tipo"
        Me.gestionot_lbl_tipo.Size = New System.Drawing.Size(30, 12)
        Me.gestionot_lbl_tipo.TabIndex = 5
        Me.gestionot_lbl_tipo.Text = "TIPO"
        '
        'gestionot_cmb_tipo
        '
        Me.gestionot_cmb_tipo.FormattingEnabled = True
        Me.gestionot_cmb_tipo.Location = New System.Drawing.Point(306, 33)
        Me.gestionot_cmb_tipo.Name = "gestionot_cmb_tipo"
        Me.gestionot_cmb_tipo.Size = New System.Drawing.Size(168, 21)
        Me.gestionot_cmb_tipo.TabIndex = 6
        '
        'gestionot_lbl_rfilter
        '
        Me.gestionot_lbl_rfilter.AutoSize = True
        Me.gestionot_lbl_rfilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gestionot_lbl_rfilter.Location = New System.Drawing.Point(482, 130)
        Me.gestionot_lbl_rfilter.Name = "gestionot_lbl_rfilter"
        Me.gestionot_lbl_rfilter.Size = New System.Drawing.Size(96, 12)
        Me.gestionot_lbl_rfilter.TabIndex = 3
        Me.gestionot_lbl_rfilter.TabStop = True
        Me.gestionot_lbl_rfilter.Text = "QUITAR FILTROS"
        '
        'gestionot_pic_title
        '
        Me.gestionot_pic_title.Location = New System.Drawing.Point(26, 22)
        Me.gestionot_pic_title.Name = "gestionot_pic_title"
        Me.gestionot_pic_title.Size = New System.Drawing.Size(142, 27)
        Me.gestionot_pic_title.TabIndex = 4
        Me.gestionot_pic_title.TabStop = False
        '
        'gestion_ot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(610, 492)
        Me.Controls.Add(Me.gestionot_pic_title)
        Me.Controls.Add(Me.gestionot_lbl_rfilter)
        Me.Controls.Add(Me.gestionot_gb_filtros)
        Me.Controls.Add(Me.gestionot_lbl_resultados)
        Me.Controls.Add(Me.gestionot_gb_resultados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gestion_ot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "gestion_ot"
        Me.gestionot_gb_resultados.ResumeLayout(False)
        CType(Me.gestionot_dg_resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gestionot_gb_filtros.ResumeLayout(False)
        Me.gestionot_gb_filtros.PerformLayout()
        CType(Me.gestionot_pic_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gestionot_pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gestionot_gb_resultados As System.Windows.Forms.GroupBox
    Friend WithEvents gestionot_dg_resultados As System.Windows.Forms.DataGridView
    Friend WithEvents gestionot_lbl_resultados As System.Windows.Forms.Label
    Friend WithEvents gestionot_gb_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents gestionot_lbl_not As System.Windows.Forms.Label
    Friend WithEvents gestionot_txt_not As System.Windows.Forms.TextBox
    Friend WithEvents gestionot_pic_buscar As System.Windows.Forms.PictureBox
    Friend WithEvents gestionot_lbl_cliente As System.Windows.Forms.Label
    Friend WithEvents gestionot_cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents gestionot_cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents gestionot_lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents gestionot_lbl_rfilter As System.Windows.Forms.LinkLabel
    Friend WithEvents gestionot_pic_title As System.Windows.Forms.PictureBox
    Friend WithEvents gestionot_tp_help As System.Windows.Forms.ToolTip
End Class
