<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class planificacion_atareas
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
        Me.planificacion_pn_realtimetab = New System.Windows.Forms.TabPage()
        Me.planificacion_dg_actual = New System.Windows.Forms.DataGridView()
        Me.planificacion_tp_principal = New System.Windows.Forms.TabControl()
        Me.planificacion_pn_asignacion = New System.Windows.Forms.TabPage()
        Me.planificacion_dg_asignacion = New System.Windows.Forms.DataGridView()
        Me.planificacion_tm_refresh = New System.Windows.Forms.Timer(Me.components)
        Me.planificacion_il_tab = New System.Windows.Forms.ImageList(Me.components)
        Me.planificacion_pic_title = New System.Windows.Forms.PictureBox()
        Me.planificacion_pn_realtimetab.SuspendLayout()
        CType(Me.planificacion_dg_actual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.planificacion_tp_principal.SuspendLayout()
        Me.planificacion_pn_asignacion.SuspendLayout()
        CType(Me.planificacion_dg_asignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.planificacion_pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'planificacion_pn_realtimetab
        '
        Me.planificacion_pn_realtimetab.Controls.Add(Me.planificacion_dg_actual)
        Me.planificacion_pn_realtimetab.ImageIndex = 0
        Me.planificacion_pn_realtimetab.Location = New System.Drawing.Point(4, 22)
        Me.planificacion_pn_realtimetab.Name = "planificacion_pn_realtimetab"
        Me.planificacion_pn_realtimetab.Padding = New System.Windows.Forms.Padding(3)
        Me.planificacion_pn_realtimetab.Size = New System.Drawing.Size(998, 366)
        Me.planificacion_pn_realtimetab.TabIndex = 0
        Me.planificacion_pn_realtimetab.UseVisualStyleBackColor = True
        '
        'planificacion_dg_actual
        '
        Me.planificacion_dg_actual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.planificacion_dg_actual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.planificacion_dg_actual.EnableHeadersVisualStyles = False
        Me.planificacion_dg_actual.Location = New System.Drawing.Point(3, 3)
        Me.planificacion_dg_actual.Name = "planificacion_dg_actual"
        Me.planificacion_dg_actual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.planificacion_dg_actual.Size = New System.Drawing.Size(992, 360)
        Me.planificacion_dg_actual.TabIndex = 0
        '
        'planificacion_tp_principal
        '
        Me.planificacion_tp_principal.Controls.Add(Me.planificacion_pn_realtimetab)
        Me.planificacion_tp_principal.Controls.Add(Me.planificacion_pn_asignacion)
        Me.planificacion_tp_principal.Location = New System.Drawing.Point(12, 162)
        Me.planificacion_tp_principal.Name = "planificacion_tp_principal"
        Me.planificacion_tp_principal.SelectedIndex = 0
        Me.planificacion_tp_principal.Size = New System.Drawing.Size(1006, 392)
        Me.planificacion_tp_principal.TabIndex = 0
        '
        'planificacion_pn_asignacion
        '
        Me.planificacion_pn_asignacion.Controls.Add(Me.planificacion_dg_asignacion)
        Me.planificacion_pn_asignacion.ImageIndex = 1
        Me.planificacion_pn_asignacion.Location = New System.Drawing.Point(4, 22)
        Me.planificacion_pn_asignacion.Name = "planificacion_pn_asignacion"
        Me.planificacion_pn_asignacion.Size = New System.Drawing.Size(998, 366)
        Me.planificacion_pn_asignacion.TabIndex = 1
        Me.planificacion_pn_asignacion.UseVisualStyleBackColor = True
        '
        'planificacion_dg_asignacion
        '
        Me.planificacion_dg_asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.planificacion_dg_asignacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.planificacion_dg_asignacion.Location = New System.Drawing.Point(0, 0)
        Me.planificacion_dg_asignacion.Name = "planificacion_dg_asignacion"
        Me.planificacion_dg_asignacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.planificacion_dg_asignacion.Size = New System.Drawing.Size(998, 366)
        Me.planificacion_dg_asignacion.TabIndex = 0
        '
        'planificacion_tm_refresh
        '
        '
        'planificacion_il_tab
        '
        Me.planificacion_il_tab.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.planificacion_il_tab.ImageSize = New System.Drawing.Size(16, 16)
        Me.planificacion_il_tab.TransparentColor = System.Drawing.Color.Transparent
        '
        'planificacion_pic_title
        '
        Me.planificacion_pic_title.Location = New System.Drawing.Point(12, 28)
        Me.planificacion_pic_title.Name = "planificacion_pic_title"
        Me.planificacion_pic_title.Size = New System.Drawing.Size(330, 74)
        Me.planificacion_pic_title.TabIndex = 1
        Me.planificacion_pic_title.TabStop = False
        '
        'planificacion_atareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 555)
        Me.Controls.Add(Me.planificacion_pic_title)
        Me.Controls.Add(Me.planificacion_tp_principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "planificacion_atareas"
        Me.Text = "planificacion_atareas"
        Me.planificacion_pn_realtimetab.ResumeLayout(False)
        CType(Me.planificacion_dg_actual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.planificacion_tp_principal.ResumeLayout(False)
        Me.planificacion_pn_asignacion.ResumeLayout(False)
        CType(Me.planificacion_dg_asignacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.planificacion_pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents planificacion_pn_realtimetab As System.Windows.Forms.TabPage
    Friend WithEvents planificacion_tp_principal As System.Windows.Forms.TabControl
    Friend WithEvents planificacion_tm_refresh As System.Windows.Forms.Timer
    Public WithEvents planificacion_dg_actual As System.Windows.Forms.DataGridView
    Friend WithEvents planificacion_il_tab As System.Windows.Forms.ImageList
    Friend WithEvents planificacion_pn_asignacion As System.Windows.Forms.TabPage
    Friend WithEvents planificacion_dg_asignacion As System.Windows.Forms.DataGridView
    Friend WithEvents planificacion_pic_title As System.Windows.Forms.PictureBox
End Class
