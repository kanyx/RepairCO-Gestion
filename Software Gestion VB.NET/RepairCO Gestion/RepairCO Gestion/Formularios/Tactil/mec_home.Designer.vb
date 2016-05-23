<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mec_home
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
        Me.mechome_dg_ot = New System.Windows.Forms.DataGridView()
        Me.mechome_pic_icot = New System.Windows.Forms.PictureBox()
        Me.mechome_pic_otasignadas = New System.Windows.Forms.PictureBox()
        CType(Me.mechome_dg_ot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mechome_pic_icot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mechome_pic_otasignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mechome_dg_ot
        '
        Me.mechome_dg_ot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mechome_dg_ot.Location = New System.Drawing.Point(31, 92)
        Me.mechome_dg_ot.Name = "mechome_dg_ot"
        Me.mechome_dg_ot.Size = New System.Drawing.Size(947, 437)
        Me.mechome_dg_ot.TabIndex = 0
        '
        'mechome_pic_icot
        '
        Me.mechome_pic_icot.Location = New System.Drawing.Point(31, 38)
        Me.mechome_pic_icot.Name = "mechome_pic_icot"
        Me.mechome_pic_icot.Size = New System.Drawing.Size(48, 48)
        Me.mechome_pic_icot.TabIndex = 1
        Me.mechome_pic_icot.TabStop = False
        '
        'mechome_pic_otasignadas
        '
        Me.mechome_pic_otasignadas.Location = New System.Drawing.Point(83, 46)
        Me.mechome_pic_otasignadas.Name = "mechome_pic_otasignadas"
        Me.mechome_pic_otasignadas.Size = New System.Drawing.Size(329, 32)
        Me.mechome_pic_otasignadas.TabIndex = 2
        Me.mechome_pic_otasignadas.TabStop = False
        '
        'mec_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1363, 593)
        Me.Controls.Add(Me.mechome_pic_otasignadas)
        Me.Controls.Add(Me.mechome_pic_icot)
        Me.Controls.Add(Me.mechome_dg_ot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mec_home"
        Me.Text = "mec_home"
        CType(Me.mechome_dg_ot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mechome_pic_icot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mechome_pic_otasignadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mechome_dg_ot As System.Windows.Forms.DataGridView
    Friend WithEvents mechome_pic_icot As System.Windows.Forms.PictureBox
    Friend WithEvents mechome_pic_otasignadas As System.Windows.Forms.PictureBox
End Class
