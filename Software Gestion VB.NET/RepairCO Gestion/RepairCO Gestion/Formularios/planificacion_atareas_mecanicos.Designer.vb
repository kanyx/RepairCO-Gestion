<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class planificacion_atareas_mecanicos
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
        Me.planificacion_atareasmec_tp_principal = New System.Windows.Forms.TabControl()
        Me.planificacion_atareasmec_tp_principal_disponible = New System.Windows.Forms.TabPage()
        Me.planificacion_atareasmec_gv_disponible = New System.Windows.Forms.DataGridView()
        Me.planificacion_atareasmec_tp_principal_asignados = New System.Windows.Forms.TabPage()
        Me.planificacion_atareasmec_gv_asignados = New System.Windows.Forms.DataGridView()
        Me.planificacion_atareasmec_il_tab = New System.Windows.Forms.ImageList(Me.components)
        Me.planificacion_atareasmec_lbl_title = New System.Windows.Forms.Label()
        Me.planificacion_atareasmec_pic_close = New System.Windows.Forms.PictureBox()
        Me.planificacion_atareasmec_gb_informacion = New System.Windows.Forms.GroupBox()
        Me.planificacion_atareasmec_lbl_infospectitle = New System.Windows.Forms.Label()
        Me.planificacion_atareasmec_lbl_inforuttitle = New System.Windows.Forms.Label()
        Me.planificacion_atareasmec_lbl_infonombretitle = New System.Windows.Forms.Label()
        Me.planificacion_atareasmec_lbl_infootasigvalue = New System.Windows.Forms.Label()
        Me.planificacion_atareasmec_lbl_infootasigtitle = New System.Windows.Forms.Label()
        Me.planificacion_atareasmec_lbl_infosepecvalue = New System.Windows.Forms.Label()
        Me.planificacion_atareasmec_lbl_inforutvalue = New System.Windows.Forms.Label()
        Me.planificacion_atareasmec_lbl_infonombrevalue = New System.Windows.Forms.Label()
        Me.planificacion_atareasmec_pic_meca = New System.Windows.Forms.PictureBox()
        Me.planificacion_atareasmec_tp_principal.SuspendLayout()
        Me.planificacion_atareasmec_tp_principal_disponible.SuspendLayout()
        CType(Me.planificacion_atareasmec_gv_disponible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.planificacion_atareasmec_tp_principal_asignados.SuspendLayout()
        CType(Me.planificacion_atareasmec_gv_asignados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.planificacion_atareasmec_pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.planificacion_atareasmec_gb_informacion.SuspendLayout()
        CType(Me.planificacion_atareasmec_pic_meca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'planificacion_atareasmec_tp_principal
        '
        Me.planificacion_atareasmec_tp_principal.Controls.Add(Me.planificacion_atareasmec_tp_principal_disponible)
        Me.planificacion_atareasmec_tp_principal.Controls.Add(Me.planificacion_atareasmec_tp_principal_asignados)
        Me.planificacion_atareasmec_tp_principal.Location = New System.Drawing.Point(12, 156)
        Me.planificacion_atareasmec_tp_principal.Name = "planificacion_atareasmec_tp_principal"
        Me.planificacion_atareasmec_tp_principal.SelectedIndex = 0
        Me.planificacion_atareasmec_tp_principal.Size = New System.Drawing.Size(779, 300)
        Me.planificacion_atareasmec_tp_principal.TabIndex = 0
        '
        'planificacion_atareasmec_tp_principal_disponible
        '
        Me.planificacion_atareasmec_tp_principal_disponible.Controls.Add(Me.planificacion_atareasmec_gv_disponible)
        Me.planificacion_atareasmec_tp_principal_disponible.ImageIndex = 0
        Me.planificacion_atareasmec_tp_principal_disponible.Location = New System.Drawing.Point(4, 22)
        Me.planificacion_atareasmec_tp_principal_disponible.Name = "planificacion_atareasmec_tp_principal_disponible"
        Me.planificacion_atareasmec_tp_principal_disponible.Padding = New System.Windows.Forms.Padding(3)
        Me.planificacion_atareasmec_tp_principal_disponible.Size = New System.Drawing.Size(771, 274)
        Me.planificacion_atareasmec_tp_principal_disponible.TabIndex = 0
        Me.planificacion_atareasmec_tp_principal_disponible.UseVisualStyleBackColor = True
        '
        'planificacion_atareasmec_gv_disponible
        '
        Me.planificacion_atareasmec_gv_disponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.planificacion_atareasmec_gv_disponible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.planificacion_atareasmec_gv_disponible.Location = New System.Drawing.Point(3, 3)
        Me.planificacion_atareasmec_gv_disponible.Name = "planificacion_atareasmec_gv_disponible"
        Me.planificacion_atareasmec_gv_disponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.planificacion_atareasmec_gv_disponible.Size = New System.Drawing.Size(765, 268)
        Me.planificacion_atareasmec_gv_disponible.TabIndex = 0
        '
        'planificacion_atareasmec_tp_principal_asignados
        '
        Me.planificacion_atareasmec_tp_principal_asignados.Controls.Add(Me.planificacion_atareasmec_gv_asignados)
        Me.planificacion_atareasmec_tp_principal_asignados.ImageIndex = 1
        Me.planificacion_atareasmec_tp_principal_asignados.Location = New System.Drawing.Point(4, 22)
        Me.planificacion_atareasmec_tp_principal_asignados.Name = "planificacion_atareasmec_tp_principal_asignados"
        Me.planificacion_atareasmec_tp_principal_asignados.Padding = New System.Windows.Forms.Padding(3)
        Me.planificacion_atareasmec_tp_principal_asignados.Size = New System.Drawing.Size(771, 274)
        Me.planificacion_atareasmec_tp_principal_asignados.TabIndex = 1
        Me.planificacion_atareasmec_tp_principal_asignados.UseVisualStyleBackColor = True
        '
        'planificacion_atareasmec_gv_asignados
        '
        Me.planificacion_atareasmec_gv_asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.planificacion_atareasmec_gv_asignados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.planificacion_atareasmec_gv_asignados.Location = New System.Drawing.Point(3, 3)
        Me.planificacion_atareasmec_gv_asignados.Name = "planificacion_atareasmec_gv_asignados"
        Me.planificacion_atareasmec_gv_asignados.Size = New System.Drawing.Size(765, 268)
        Me.planificacion_atareasmec_gv_asignados.TabIndex = 0
        '
        'planificacion_atareasmec_il_tab
        '
        Me.planificacion_atareasmec_il_tab.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.planificacion_atareasmec_il_tab.ImageSize = New System.Drawing.Size(16, 16)
        Me.planificacion_atareasmec_il_tab.TransparentColor = System.Drawing.Color.Transparent
        '
        'planificacion_atareasmec_lbl_title
        '
        Me.planificacion_atareasmec_lbl_title.AutoSize = True
        Me.planificacion_atareasmec_lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planificacion_atareasmec_lbl_title.Location = New System.Drawing.Point(68, 22)
        Me.planificacion_atareasmec_lbl_title.Name = "planificacion_atareasmec_lbl_title"
        Me.planificacion_atareasmec_lbl_title.Size = New System.Drawing.Size(294, 29)
        Me.planificacion_atareasmec_lbl_title.TabIndex = 1
        Me.planificacion_atareasmec_lbl_title.Text = "PERSONAL MECANICO"
        '
        'planificacion_atareasmec_pic_close
        '
        Me.planificacion_atareasmec_pic_close.Location = New System.Drawing.Point(759, 7)
        Me.planificacion_atareasmec_pic_close.Name = "planificacion_atareasmec_pic_close"
        Me.planificacion_atareasmec_pic_close.Size = New System.Drawing.Size(32, 32)
        Me.planificacion_atareasmec_pic_close.TabIndex = 2
        Me.planificacion_atareasmec_pic_close.TabStop = False
        '
        'planificacion_atareasmec_gb_informacion
        '
        Me.planificacion_atareasmec_gb_informacion.Controls.Add(Me.planificacion_atareasmec_lbl_infospectitle)
        Me.planificacion_atareasmec_gb_informacion.Controls.Add(Me.planificacion_atareasmec_lbl_inforuttitle)
        Me.planificacion_atareasmec_gb_informacion.Controls.Add(Me.planificacion_atareasmec_lbl_infonombretitle)
        Me.planificacion_atareasmec_gb_informacion.Controls.Add(Me.planificacion_atareasmec_lbl_infootasigvalue)
        Me.planificacion_atareasmec_gb_informacion.Controls.Add(Me.planificacion_atareasmec_lbl_infootasigtitle)
        Me.planificacion_atareasmec_gb_informacion.Controls.Add(Me.planificacion_atareasmec_lbl_infosepecvalue)
        Me.planificacion_atareasmec_gb_informacion.Controls.Add(Me.planificacion_atareasmec_lbl_inforutvalue)
        Me.planificacion_atareasmec_gb_informacion.Controls.Add(Me.planificacion_atareasmec_lbl_infonombrevalue)
        Me.planificacion_atareasmec_gb_informacion.Controls.Add(Me.planificacion_atareasmec_pic_meca)
        Me.planificacion_atareasmec_gb_informacion.Location = New System.Drawing.Point(135, 60)
        Me.planificacion_atareasmec_gb_informacion.Name = "planificacion_atareasmec_gb_informacion"
        Me.planificacion_atareasmec_gb_informacion.Size = New System.Drawing.Size(542, 100)
        Me.planificacion_atareasmec_gb_informacion.TabIndex = 3
        Me.planificacion_atareasmec_gb_informacion.TabStop = False
        Me.planificacion_atareasmec_gb_informacion.Text = "INFORMACION"
        '
        'planificacion_atareasmec_lbl_infospectitle
        '
        Me.planificacion_atareasmec_lbl_infospectitle.AutoSize = True
        Me.planificacion_atareasmec_lbl_infospectitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planificacion_atareasmec_lbl_infospectitle.Location = New System.Drawing.Point(113, 68)
        Me.planificacion_atareasmec_lbl_infospectitle.Name = "planificacion_atareasmec_lbl_infospectitle"
        Me.planificacion_atareasmec_lbl_infospectitle.Size = New System.Drawing.Size(61, 9)
        Me.planificacion_atareasmec_lbl_infospectitle.TabIndex = 8
        Me.planificacion_atareasmec_lbl_infospectitle.Text = "ESPECIALIDAD"
        '
        'planificacion_atareasmec_lbl_inforuttitle
        '
        Me.planificacion_atareasmec_lbl_inforuttitle.AutoSize = True
        Me.planificacion_atareasmec_lbl_inforuttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planificacion_atareasmec_lbl_inforuttitle.Location = New System.Drawing.Point(113, 42)
        Me.planificacion_atareasmec_lbl_inforuttitle.Name = "planificacion_atareasmec_lbl_inforuttitle"
        Me.planificacion_atareasmec_lbl_inforuttitle.Size = New System.Drawing.Size(22, 9)
        Me.planificacion_atareasmec_lbl_inforuttitle.TabIndex = 7
        Me.planificacion_atareasmec_lbl_inforuttitle.Text = "RUT"
        '
        'planificacion_atareasmec_lbl_infonombretitle
        '
        Me.planificacion_atareasmec_lbl_infonombretitle.AutoSize = True
        Me.planificacion_atareasmec_lbl_infonombretitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planificacion_atareasmec_lbl_infonombretitle.Location = New System.Drawing.Point(113, 15)
        Me.planificacion_atareasmec_lbl_infonombretitle.Name = "planificacion_atareasmec_lbl_infonombretitle"
        Me.planificacion_atareasmec_lbl_infonombretitle.Size = New System.Drawing.Size(40, 9)
        Me.planificacion_atareasmec_lbl_infonombretitle.TabIndex = 6
        Me.planificacion_atareasmec_lbl_infonombretitle.Text = "NOMBRE"
        '
        'planificacion_atareasmec_lbl_infootasigvalue
        '
        Me.planificacion_atareasmec_lbl_infootasigvalue.AutoSize = True
        Me.planificacion_atareasmec_lbl_infootasigvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planificacion_atareasmec_lbl_infootasigvalue.Location = New System.Drawing.Point(330, 37)
        Me.planificacion_atareasmec_lbl_infootasigvalue.Name = "planificacion_atareasmec_lbl_infootasigvalue"
        Me.planificacion_atareasmec_lbl_infootasigvalue.Size = New System.Drawing.Size(176, 42)
        Me.planificacion_atareasmec_lbl_infootasigvalue.TabIndex = 5
        Me.planificacion_atareasmec_lbl_infootasigvalue.Text = "784 - 783"
        '
        'planificacion_atareasmec_lbl_infootasigtitle
        '
        Me.planificacion_atareasmec_lbl_infootasigtitle.AutoSize = True
        Me.planificacion_atareasmec_lbl_infootasigtitle.Location = New System.Drawing.Point(334, 22)
        Me.planificacion_atareasmec_lbl_infootasigtitle.Name = "planificacion_atareasmec_lbl_infootasigtitle"
        Me.planificacion_atareasmec_lbl_infootasigtitle.Size = New System.Drawing.Size(87, 13)
        Me.planificacion_atareasmec_lbl_infootasigtitle.TabIndex = 4
        Me.planificacion_atareasmec_lbl_infootasigtitle.Text = "OT ASIGNADAS"
        '
        'planificacion_atareasmec_lbl_infosepecvalue
        '
        Me.planificacion_atareasmec_lbl_infosepecvalue.AutoSize = True
        Me.planificacion_atareasmec_lbl_infosepecvalue.Location = New System.Drawing.Point(113, 79)
        Me.planificacion_atareasmec_lbl_infosepecvalue.Name = "planificacion_atareasmec_lbl_infosepecvalue"
        Me.planificacion_atareasmec_lbl_infosepecvalue.Size = New System.Drawing.Size(67, 13)
        Me.planificacion_atareasmec_lbl_infosepecvalue.TabIndex = 3
        Me.planificacion_atareasmec_lbl_infosepecvalue.Text = "CORNETEO"
        '
        'planificacion_atareasmec_lbl_inforutvalue
        '
        Me.planificacion_atareasmec_lbl_inforutvalue.AutoSize = True
        Me.planificacion_atareasmec_lbl_inforutvalue.Location = New System.Drawing.Point(112, 53)
        Me.planificacion_atareasmec_lbl_inforutvalue.Name = "planificacion_atareasmec_lbl_inforutvalue"
        Me.planificacion_atareasmec_lbl_inforutvalue.Size = New System.Drawing.Size(70, 13)
        Me.planificacion_atareasmec_lbl_inforutvalue.TabIndex = 2
        Me.planificacion_atareasmec_lbl_inforutvalue.Text = "16.438.313.8"
        '
        'planificacion_atareasmec_lbl_infonombrevalue
        '
        Me.planificacion_atareasmec_lbl_infonombrevalue.AutoSize = True
        Me.planificacion_atareasmec_lbl_infonombrevalue.Location = New System.Drawing.Point(112, 27)
        Me.planificacion_atareasmec_lbl_infonombrevalue.Name = "planificacion_atareasmec_lbl_infonombrevalue"
        Me.planificacion_atareasmec_lbl_infonombrevalue.Size = New System.Drawing.Size(136, 13)
        Me.planificacion_atareasmec_lbl_infonombrevalue.TabIndex = 1
        Me.planificacion_atareasmec_lbl_infonombrevalue.Text = "JOSEFINA POR EL CHICO"
        '
        'planificacion_atareasmec_pic_meca
        '
        Me.planificacion_atareasmec_pic_meca.Location = New System.Drawing.Point(6, 17)
        Me.planificacion_atareasmec_pic_meca.Name = "planificacion_atareasmec_pic_meca"
        Me.planificacion_atareasmec_pic_meca.Size = New System.Drawing.Size(100, 79)
        Me.planificacion_atareasmec_pic_meca.TabIndex = 0
        Me.planificacion_atareasmec_pic_meca.TabStop = False
        '
        'planificacion_atareas_mecanicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 463)
        Me.Controls.Add(Me.planificacion_atareasmec_gb_informacion)
        Me.Controls.Add(Me.planificacion_atareasmec_pic_close)
        Me.Controls.Add(Me.planificacion_atareasmec_lbl_title)
        Me.Controls.Add(Me.planificacion_atareasmec_tp_principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "planificacion_atareas_mecanicos"
        Me.Text = "planificacion_atareas_mecanicos"
        Me.planificacion_atareasmec_tp_principal.ResumeLayout(False)
        Me.planificacion_atareasmec_tp_principal_disponible.ResumeLayout(False)
        CType(Me.planificacion_atareasmec_gv_disponible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.planificacion_atareasmec_tp_principal_asignados.ResumeLayout(False)
        CType(Me.planificacion_atareasmec_gv_asignados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.planificacion_atareasmec_pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.planificacion_atareasmec_gb_informacion.ResumeLayout(False)
        Me.planificacion_atareasmec_gb_informacion.PerformLayout()
        CType(Me.planificacion_atareasmec_pic_meca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents planificacion_atareasmec_tp_principal As System.Windows.Forms.TabControl
    Friend WithEvents planificacion_atareasmec_tp_principal_disponible As System.Windows.Forms.TabPage
    Friend WithEvents planificacion_atareasmec_tp_principal_asignados As System.Windows.Forms.TabPage
    Friend WithEvents planificacion_atareasmec_il_tab As System.Windows.Forms.ImageList
    Friend WithEvents planificacion_atareasmec_lbl_title As System.Windows.Forms.Label
    Friend WithEvents planificacion_atareasmec_pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents planificacion_atareasmec_gb_informacion As System.Windows.Forms.GroupBox
    Friend WithEvents planificacion_atareasmec_pic_meca As System.Windows.Forms.PictureBox
    Friend WithEvents planificacion_atareasmec_gv_disponible As System.Windows.Forms.DataGridView
    Friend WithEvents planificacion_atareasmec_gv_asignados As System.Windows.Forms.DataGridView
    Friend WithEvents planificacion_atareasmec_lbl_infonombrevalue As System.Windows.Forms.Label
    Friend WithEvents planificacion_atareasmec_lbl_inforutvalue As System.Windows.Forms.Label
    Friend WithEvents planificacion_atareasmec_lbl_infosepecvalue As System.Windows.Forms.Label
    Friend WithEvents planificacion_atareasmec_lbl_infootasigvalue As System.Windows.Forms.Label
    Friend WithEvents planificacion_atareasmec_lbl_infootasigtitle As System.Windows.Forms.Label
    Friend WithEvents planificacion_atareasmec_lbl_infospectitle As System.Windows.Forms.Label
    Friend WithEvents planificacion_atareasmec_lbl_inforuttitle As System.Windows.Forms.Label
    Friend WithEvents planificacion_atareasmec_lbl_infonombretitle As System.Windows.Forms.Label
End Class
