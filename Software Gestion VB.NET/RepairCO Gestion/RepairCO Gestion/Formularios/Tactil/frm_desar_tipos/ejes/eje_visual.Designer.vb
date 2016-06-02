<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eje_visual
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
        Me.visual_lbl_z1 = New System.Windows.Forms.Label()
        Me.visual_lbl_z2 = New System.Windows.Forms.Label()
        Me.visual_lbl_obs = New System.Windows.Forms.Label()
        Me.visual_gb_obs = New System.Windows.Forms.GroupBox()
        Me.visual_cmb_z1 = New System.Windows.Forms.ComboBox()
        Me.visual_cmb_z2 = New System.Windows.Forms.ComboBox()
        Me.visual_pic_save = New System.Windows.Forms.PictureBox()
        CType(Me.visual_pic_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'visual_lbl_z1
        '
        Me.visual_lbl_z1.AutoSize = True
        Me.visual_lbl_z1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_z1.Location = New System.Drawing.Point(12, 67)
        Me.visual_lbl_z1.Name = "visual_lbl_z1"
        Me.visual_lbl_z1.Size = New System.Drawing.Size(321, 13)
        Me.visual_lbl_z1.TabIndex = 0
        Me.visual_lbl_z1.Text = "COND. HILO DE TUERCA FIJACION DE RODAMIENTO"
        '
        'visual_lbl_z2
        '
        Me.visual_lbl_z2.AutoSize = True
        Me.visual_lbl_z2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_z2.Location = New System.Drawing.Point(12, 115)
        Me.visual_lbl_z2.Name = "visual_lbl_z2"
        Me.visual_lbl_z2.Size = New System.Drawing.Size(198, 13)
        Me.visual_lbl_z2.TabIndex = 1
        Me.visual_lbl_z2.Text = "COND. CHAVETA Y CHAVETERO"
        '
        'visual_lbl_obs
        '
        Me.visual_lbl_obs.AutoSize = True
        Me.visual_lbl_obs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_obs.Location = New System.Drawing.Point(418, 167)
        Me.visual_lbl_obs.Name = "visual_lbl_obs"
        Me.visual_lbl_obs.Size = New System.Drawing.Size(111, 13)
        Me.visual_lbl_obs.TabIndex = 2
        Me.visual_lbl_obs.Text = "OBSERVACIONES"
        '
        'visual_gb_obs
        '
        Me.visual_gb_obs.Location = New System.Drawing.Point(15, 178)
        Me.visual_gb_obs.Name = "visual_gb_obs"
        Me.visual_gb_obs.Size = New System.Drawing.Size(514, 173)
        Me.visual_gb_obs.TabIndex = 3
        Me.visual_gb_obs.TabStop = False
        '
        'visual_cmb_z1
        '
        Me.visual_cmb_z1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_cmb_z1.FormattingEnabled = True
        Me.visual_cmb_z1.Location = New System.Drawing.Point(350, 64)
        Me.visual_cmb_z1.Name = "visual_cmb_z1"
        Me.visual_cmb_z1.Size = New System.Drawing.Size(121, 32)
        Me.visual_cmb_z1.TabIndex = 4
        '
        'visual_cmb_z2
        '
        Me.visual_cmb_z2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_cmb_z2.FormattingEnabled = True
        Me.visual_cmb_z2.Location = New System.Drawing.Point(350, 104)
        Me.visual_cmb_z2.Name = "visual_cmb_z2"
        Me.visual_cmb_z2.Size = New System.Drawing.Size(121, 32)
        Me.visual_cmb_z2.TabIndex = 5
        '
        'visual_pic_save
        '
        Me.visual_pic_save.Location = New System.Drawing.Point(173, 359)
        Me.visual_pic_save.Name = "visual_pic_save"
        Me.visual_pic_save.Size = New System.Drawing.Size(160, 38)
        Me.visual_pic_save.TabIndex = 6
        Me.visual_pic_save.TabStop = False
        '
        'eje_visual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 409)
        Me.Controls.Add(Me.visual_pic_save)
        Me.Controls.Add(Me.visual_cmb_z2)
        Me.Controls.Add(Me.visual_cmb_z1)
        Me.Controls.Add(Me.visual_gb_obs)
        Me.Controls.Add(Me.visual_lbl_obs)
        Me.Controls.Add(Me.visual_lbl_z2)
        Me.Controls.Add(Me.visual_lbl_z1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "eje_visual"
        Me.Text = "eje_visual"
        CType(Me.visual_pic_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents visual_lbl_z1 As System.Windows.Forms.Label
    Friend WithEvents visual_lbl_z2 As System.Windows.Forms.Label
    Friend WithEvents visual_lbl_obs As System.Windows.Forms.Label
    Friend WithEvents visual_gb_obs As System.Windows.Forms.GroupBox
    Friend WithEvents visual_cmb_z1 As System.Windows.Forms.ComboBox
    Friend WithEvents visual_cmb_z2 As System.Windows.Forms.ComboBox
    Friend WithEvents visual_pic_save As System.Windows.Forms.PictureBox
End Class
