﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carcasa_visual
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
        Me.visual_pic_save = New System.Windows.Forms.PictureBox()
        Me.visual_cmb_z4 = New System.Windows.Forms.ComboBox()
        Me.visual_cmb_z3 = New System.Windows.Forms.ComboBox()
        Me.visual_gb_obs = New System.Windows.Forms.GroupBox()
        Me.visual_lbl_obs = New System.Windows.Forms.Label()
        Me.visual_lbl_z4 = New System.Windows.Forms.Label()
        Me.visual_lbl_z3 = New System.Windows.Forms.Label()
        Me.visual_lbl_z5 = New System.Windows.Forms.Label()
        Me.visual_cmb_z5 = New System.Windows.Forms.ComboBox()
        CType(Me.visual_pic_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'visual_pic_save
        '
        Me.visual_pic_save.Location = New System.Drawing.Point(173, 356)
        Me.visual_pic_save.Name = "visual_pic_save"
        Me.visual_pic_save.Size = New System.Drawing.Size(160, 38)
        Me.visual_pic_save.TabIndex = 13
        Me.visual_pic_save.TabStop = False
        '
        'visual_cmb_z4
        '
        Me.visual_cmb_z4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_cmb_z4.FormattingEnabled = True
        Me.visual_cmb_z4.Location = New System.Drawing.Point(350, 89)
        Me.visual_cmb_z4.Name = "visual_cmb_z4"
        Me.visual_cmb_z4.Size = New System.Drawing.Size(121, 32)
        Me.visual_cmb_z4.TabIndex = 12
        '
        'visual_cmb_z3
        '
        Me.visual_cmb_z3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_cmb_z3.FormattingEnabled = True
        Me.visual_cmb_z3.Location = New System.Drawing.Point(350, 49)
        Me.visual_cmb_z3.Name = "visual_cmb_z3"
        Me.visual_cmb_z3.Size = New System.Drawing.Size(121, 32)
        Me.visual_cmb_z3.TabIndex = 11
        '
        'visual_gb_obs
        '
        Me.visual_gb_obs.Location = New System.Drawing.Point(15, 183)
        Me.visual_gb_obs.Name = "visual_gb_obs"
        Me.visual_gb_obs.Size = New System.Drawing.Size(514, 165)
        Me.visual_gb_obs.TabIndex = 10
        Me.visual_gb_obs.TabStop = False
        '
        'visual_lbl_obs
        '
        Me.visual_lbl_obs.AutoSize = True
        Me.visual_lbl_obs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_obs.Location = New System.Drawing.Point(412, 171)
        Me.visual_lbl_obs.Name = "visual_lbl_obs"
        Me.visual_lbl_obs.Size = New System.Drawing.Size(111, 13)
        Me.visual_lbl_obs.TabIndex = 9
        Me.visual_lbl_obs.Text = "OBSERVACIONES"
        '
        'visual_lbl_z4
        '
        Me.visual_lbl_z4.AutoSize = True
        Me.visual_lbl_z4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_z4.Location = New System.Drawing.Point(12, 100)
        Me.visual_lbl_z4.Name = "visual_lbl_z4"
        Me.visual_lbl_z4.Size = New System.Drawing.Size(98, 13)
        Me.visual_lbl_z4.TabIndex = 8
        Me.visual_lbl_z4.Text = "COND. FLANGE"
        '
        'visual_lbl_z3
        '
        Me.visual_lbl_z3.AutoSize = True
        Me.visual_lbl_z3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_z3.Location = New System.Drawing.Point(12, 60)
        Me.visual_lbl_z3.Name = "visual_lbl_z3"
        Me.visual_lbl_z3.Size = New System.Drawing.Size(156, 13)
        Me.visual_lbl_z3.TabIndex = 7
        Me.visual_lbl_z3.Text = "COND. ZONA DE AJUSTE"
        '
        'visual_lbl_z5
        '
        Me.visual_lbl_z5.AutoSize = True
        Me.visual_lbl_z5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_lbl_z5.Location = New System.Drawing.Point(12, 138)
        Me.visual_lbl_z5.Name = "visual_lbl_z5"
        Me.visual_lbl_z5.Size = New System.Drawing.Size(157, 13)
        Me.visual_lbl_z5.TabIndex = 14
        Me.visual_lbl_z5.Text = "COND. PATAS DE APOYO"
        '
        'visual_cmb_z5
        '
        Me.visual_cmb_z5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual_cmb_z5.FormattingEnabled = True
        Me.visual_cmb_z5.Location = New System.Drawing.Point(350, 127)
        Me.visual_cmb_z5.Name = "visual_cmb_z5"
        Me.visual_cmb_z5.Size = New System.Drawing.Size(121, 32)
        Me.visual_cmb_z5.TabIndex = 15
        '
        'carcasa_visual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 409)
        Me.Controls.Add(Me.visual_cmb_z5)
        Me.Controls.Add(Me.visual_lbl_z5)
        Me.Controls.Add(Me.visual_pic_save)
        Me.Controls.Add(Me.visual_cmb_z4)
        Me.Controls.Add(Me.visual_cmb_z3)
        Me.Controls.Add(Me.visual_gb_obs)
        Me.Controls.Add(Me.visual_lbl_obs)
        Me.Controls.Add(Me.visual_lbl_z4)
        Me.Controls.Add(Me.visual_lbl_z3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "carcasa_visual"
        Me.Text = "carcasa_visual"
        CType(Me.visual_pic_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents visual_pic_save As System.Windows.Forms.PictureBox
    Friend WithEvents visual_cmb_z4 As System.Windows.Forms.ComboBox
    Friend WithEvents visual_cmb_z3 As System.Windows.Forms.ComboBox
    Friend WithEvents visual_gb_obs As System.Windows.Forms.GroupBox
    Friend WithEvents visual_lbl_obs As System.Windows.Forms.Label
    Friend WithEvents visual_lbl_z4 As System.Windows.Forms.Label
    Friend WithEvents visual_lbl_z3 As System.Windows.Forms.Label
    Friend WithEvents visual_lbl_z5 As System.Windows.Forms.Label
    Friend WithEvents visual_cmb_z5 As System.Windows.Forms.ComboBox
End Class