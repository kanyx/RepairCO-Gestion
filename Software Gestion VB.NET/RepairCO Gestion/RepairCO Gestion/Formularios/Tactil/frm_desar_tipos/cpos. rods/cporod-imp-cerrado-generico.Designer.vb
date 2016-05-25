<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cporod_imp_cerrado_generico
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
        Me.cporod_pn_vector = New System.Windows.Forms.Panel()
        Me.cporod_pn_z1 = New System.Windows.Forms.Panel()
        Me.cporod_pn_z2 = New System.Windows.Forms.Panel()
        Me.cporod_pic_title = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cporod_lbl_z1 = New System.Windows.Forms.Label()
        Me.cporod_lbl_z2 = New System.Windows.Forms.Label()
        Me.cporod_txt_z1 = New System.Windows.Forms.TextBox()
        Me.cporod_txt_z2 = New System.Windows.Forms.TextBox()
        Me.cporod_pn_med = New System.Windows.Forms.Panel()
        Me.cporod_pn_vector.SuspendLayout()
        CType(Me.cporod_pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cporod_pn_vector
        '
        Me.cporod_pn_vector.Controls.Add(Me.cporod_pn_z2)
        Me.cporod_pn_vector.Controls.Add(Me.cporod_pn_z1)
        Me.cporod_pn_vector.Location = New System.Drawing.Point(12, 80)
        Me.cporod_pn_vector.Name = "cporod_pn_vector"
        Me.cporod_pn_vector.Size = New System.Drawing.Size(427, 320)
        Me.cporod_pn_vector.TabIndex = 0
        '
        'cporod_pn_z1
        '
        Me.cporod_pn_z1.Location = New System.Drawing.Point(182, 0)
        Me.cporod_pn_z1.Name = "cporod_pn_z1"
        Me.cporod_pn_z1.Size = New System.Drawing.Size(40, 320)
        Me.cporod_pn_z1.TabIndex = 1
        '
        'cporod_pn_z2
        '
        Me.cporod_pn_z2.Location = New System.Drawing.Point(296, 0)
        Me.cporod_pn_z2.Name = "cporod_pn_z2"
        Me.cporod_pn_z2.Size = New System.Drawing.Size(56, 320)
        Me.cporod_pn_z2.TabIndex = 1
        '
        'cporod_pic_title
        '
        Me.cporod_pic_title.Location = New System.Drawing.Point(464, 21)
        Me.cporod_pic_title.Name = "cporod_pic_title"
        Me.cporod_pic_title.Size = New System.Drawing.Size(477, 26)
        Me.cporod_pic_title.TabIndex = 1
        Me.cporod_pic_title.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cporod_txt_z2)
        Me.GroupBox1.Controls.Add(Me.cporod_txt_z1)
        Me.GroupBox1.Controls.Add(Me.cporod_lbl_z2)
        Me.GroupBox1.Controls.Add(Me.cporod_lbl_z1)
        Me.GroupBox1.Location = New System.Drawing.Point(464, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 112)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'cporod_lbl_z1
        '
        Me.cporod_lbl_z1.AutoSize = True
        Me.cporod_lbl_z1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cporod_lbl_z1.Location = New System.Drawing.Point(9, 28)
        Me.cporod_lbl_z1.Name = "cporod_lbl_z1"
        Me.cporod_lbl_z1.Size = New System.Drawing.Size(331, 15)
        Me.cporod_lbl_z1.TabIndex = 3
        Me.cporod_lbl_z1.Text = "Ø INTERIOR CPO. ROD. LADO ACOPLAMIENTO (1)"
        '
        'cporod_lbl_z2
        '
        Me.cporod_lbl_z2.AutoSize = True
        Me.cporod_lbl_z2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cporod_lbl_z2.Location = New System.Drawing.Point(9, 68)
        Me.cporod_lbl_z2.Name = "cporod_lbl_z2"
        Me.cporod_lbl_z2.Size = New System.Drawing.Size(306, 15)
        Me.cporod_lbl_z2.TabIndex = 4
        Me.cporod_lbl_z2.Text = "Ø INTERIOR CPO. ROD. LADO LADO LIBRE (2)"
        '
        'cporod_txt_z1
        '
        Me.cporod_txt_z1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cporod_txt_z1.Location = New System.Drawing.Point(346, 22)
        Me.cporod_txt_z1.Name = "cporod_txt_z1"
        Me.cporod_txt_z1.Size = New System.Drawing.Size(66, 26)
        Me.cporod_txt_z1.TabIndex = 6
        '
        'cporod_txt_z2
        '
        Me.cporod_txt_z2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cporod_txt_z2.Location = New System.Drawing.Point(346, 62)
        Me.cporod_txt_z2.Name = "cporod_txt_z2"
        Me.cporod_txt_z2.Size = New System.Drawing.Size(66, 26)
        Me.cporod_txt_z2.TabIndex = 7
        '
        'cporod_pn_med
        '
        Me.cporod_pn_med.Location = New System.Drawing.Point(414, 53)
        Me.cporod_pn_med.Name = "cporod_pn_med"
        Me.cporod_pn_med.Size = New System.Drawing.Size(504, 319)
        Me.cporod_pn_med.TabIndex = 7
        '
        'cporod_imp_cerrado_generico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1361, 506)
        Me.Controls.Add(Me.cporod_pn_med)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cporod_pic_title)
        Me.Controls.Add(Me.cporod_pn_vector)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cporod_imp_cerrado_generico"
        Me.Text = "cporod_imp_cerrado_generico"
        Me.cporod_pn_vector.ResumeLayout(False)
        CType(Me.cporod_pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cporod_pn_vector As System.Windows.Forms.Panel
    Friend WithEvents cporod_pn_z1 As System.Windows.Forms.Panel
    Friend WithEvents cporod_pn_z2 As System.Windows.Forms.Panel
    Friend WithEvents cporod_pic_title As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cporod_lbl_z2 As System.Windows.Forms.Label
    Friend WithEvents cporod_lbl_z1 As System.Windows.Forms.Label
    Friend WithEvents cporod_txt_z2 As System.Windows.Forms.TextBox
    Friend WithEvents cporod_txt_z1 As System.Windows.Forms.TextBox
    Friend WithEvents cporod_pn_med As System.Windows.Forms.Panel
End Class
