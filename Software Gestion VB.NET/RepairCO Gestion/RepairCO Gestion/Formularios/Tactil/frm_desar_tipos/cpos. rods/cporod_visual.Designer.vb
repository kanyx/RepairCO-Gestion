<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cporod_visual
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
        Me.visual_cmb_z18 = New System.Windows.Forms.ComboBox()
        Me.visual_lbl_z18 = New System.Windows.Forms.Label()
        Me.visual_pic_save = New System.Windows.Forms.PictureBox()
        Me.visual_cmb_z17 = New System.Windows.Forms.ComboBox()
        Me.visual_cmb_z16 = New System.Windows.Forms.ComboBox()
        Me.visual_gb_obs = New System.Windows.Forms.GroupBox()
        Me.visual_lbl_obs = New System.Windows.Forms.Label()
        Me.visual_lbl_z17 = New System.Windows.Forms.Label()
        Me.visual_lbl_z16 = New System.Windows.Forms.Label()
        CType(Me.visual_pic_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'visual_cmb_z18
        '
        Me.visual_cmb_z18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_cmb_z18.FormattingEnabled = True
        Me.visual_cmb_z18.Location = New System.Drawing.Point(350, 135)
        Me.visual_cmb_z18.Name = "visual_cmb_z18"
        Me.visual_cmb_z18.Size = New System.Drawing.Size(121, 32)
        Me.visual_cmb_z18.TabIndex = 33
        '
        'visual_lbl_z18
        '
        Me.visual_lbl_z18.AutoSize = True
        Me.visual_lbl_z18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_z18.Location = New System.Drawing.Point(12, 146)
        Me.visual_lbl_z18.Name = "visual_lbl_z18"
        Me.visual_lbl_z18.Size = New System.Drawing.Size(238, 13)
        Me.visual_lbl_z18.TabIndex = 32
        Me.visual_lbl_z18.Text = "COND. SEGURO RODAMIENTO RADIAL"
        '
        'visual_pic_save
        '
        Me.visual_pic_save.Location = New System.Drawing.Point(173, 358)
        Me.visual_pic_save.Name = "visual_pic_save"
        Me.visual_pic_save.Size = New System.Drawing.Size(160, 38)
        Me.visual_pic_save.TabIndex = 31
        Me.visual_pic_save.TabStop = False
        '
        'visual_cmb_z17
        '
        Me.visual_cmb_z17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_cmb_z17.FormattingEnabled = True
        Me.visual_cmb_z17.Location = New System.Drawing.Point(350, 97)
        Me.visual_cmb_z17.Name = "visual_cmb_z17"
        Me.visual_cmb_z17.Size = New System.Drawing.Size(121, 32)
        Me.visual_cmb_z17.TabIndex = 30
        '
        'visual_cmb_z16
        '
        Me.visual_cmb_z16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_cmb_z16.FormattingEnabled = True
        Me.visual_cmb_z16.Location = New System.Drawing.Point(350, 57)
        Me.visual_cmb_z16.Name = "visual_cmb_z16"
        Me.visual_cmb_z16.Size = New System.Drawing.Size(121, 32)
        Me.visual_cmb_z16.TabIndex = 29
        '
        'visual_gb_obs
        '
        Me.visual_gb_obs.Location = New System.Drawing.Point(15, 191)
        Me.visual_gb_obs.Name = "visual_gb_obs"
        Me.visual_gb_obs.Size = New System.Drawing.Size(514, 165)
        Me.visual_gb_obs.TabIndex = 28
        Me.visual_gb_obs.TabStop = False
        '
        'visual_lbl_obs
        '
        Me.visual_lbl_obs.AutoSize = True
        Me.visual_lbl_obs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_obs.Location = New System.Drawing.Point(412, 179)
        Me.visual_lbl_obs.Name = "visual_lbl_obs"
        Me.visual_lbl_obs.Size = New System.Drawing.Size(111, 13)
        Me.visual_lbl_obs.TabIndex = 27
        Me.visual_lbl_obs.Text = "OBSERVACIONES"
        '
        'visual_lbl_z17
        '
        Me.visual_lbl_z17.AutoSize = True
        Me.visual_lbl_z17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_z17.Location = New System.Drawing.Point(12, 108)
        Me.visual_lbl_z17.Name = "visual_lbl_z17"
        Me.visual_lbl_z17.Size = New System.Drawing.Size(228, 13)
        Me.visual_lbl_z17.TabIndex = 26
        Me.visual_lbl_z17.Text = "COND. SEGURO RODAMIENTO AXIAL"
        '
        'visual_lbl_z16
        '
        Me.visual_lbl_z16.AutoSize = True
        Me.visual_lbl_z16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_z16.Location = New System.Drawing.Point(12, 68)
        Me.visual_lbl_z16.Name = "visual_lbl_z16"
        Me.visual_lbl_z16.Size = New System.Drawing.Size(202, 13)
        Me.visual_lbl_z16.TabIndex = 25
        Me.visual_lbl_z16.Text = "COND. HILO AMARRE DE FRAME"
        '
        'cporod_visual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 409)
        Me.Controls.Add(Me.visual_cmb_z18)
        Me.Controls.Add(Me.visual_lbl_z18)
        Me.Controls.Add(Me.visual_pic_save)
        Me.Controls.Add(Me.visual_cmb_z17)
        Me.Controls.Add(Me.visual_cmb_z16)
        Me.Controls.Add(Me.visual_gb_obs)
        Me.Controls.Add(Me.visual_lbl_obs)
        Me.Controls.Add(Me.visual_lbl_z17)
        Me.Controls.Add(Me.visual_lbl_z16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cporod_visual"
        Me.Text = "cporod_visual"
        CType(Me.visual_pic_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents visual_cmb_z18 As System.Windows.Forms.ComboBox
    Friend WithEvents visual_lbl_z18 As System.Windows.Forms.Label
    Friend WithEvents visual_pic_save As System.Windows.Forms.PictureBox
    Friend WithEvents visual_cmb_z17 As System.Windows.Forms.ComboBox
    Friend WithEvents visual_cmb_z16 As System.Windows.Forms.ComboBox
    Friend WithEvents visual_gb_obs As System.Windows.Forms.GroupBox
    Friend WithEvents visual_lbl_obs As System.Windows.Forms.Label
    Friend WithEvents visual_lbl_z17 As System.Windows.Forms.Label
    Friend WithEvents visual_lbl_z16 As System.Windows.Forms.Label
End Class
