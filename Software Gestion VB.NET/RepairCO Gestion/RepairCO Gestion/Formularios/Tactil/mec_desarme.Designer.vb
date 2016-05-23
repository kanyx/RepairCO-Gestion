<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mec_desarme
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
        Me.mecdesarme_tb_main = New System.Windows.Forms.TabControl()
        Me.mecdesarme_pn_eje = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.mecdesarme_tb_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'mecdesarme_tb_main
        '
        Me.mecdesarme_tb_main.Controls.Add(Me.mecdesarme_pn_eje)
        Me.mecdesarme_tb_main.Controls.Add(Me.TabPage2)
        Me.mecdesarme_tb_main.Location = New System.Drawing.Point(-1, 63)
        Me.mecdesarme_tb_main.Name = "mecdesarme_tb_main"
        Me.mecdesarme_tb_main.SelectedIndex = 0
        Me.mecdesarme_tb_main.Size = New System.Drawing.Size(1369, 532)
        Me.mecdesarme_tb_main.TabIndex = 0
        '
        'mecdesarme_pn_eje
        '
        Me.mecdesarme_pn_eje.Location = New System.Drawing.Point(4, 22)
        Me.mecdesarme_pn_eje.Name = "mecdesarme_pn_eje"
        Me.mecdesarme_pn_eje.Padding = New System.Windows.Forms.Padding(3)
        Me.mecdesarme_pn_eje.Size = New System.Drawing.Size(1361, 506)
        Me.mecdesarme_pn_eje.TabIndex = 0
        Me.mecdesarme_pn_eje.Text = "EJE"
        Me.mecdesarme_pn_eje.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1361, 506)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'mec_desarme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 593)
        Me.Controls.Add(Me.mecdesarme_tb_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mec_desarme"
        Me.Text = "mec_desarme"
        Me.mecdesarme_tb_main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mecdesarme_tb_main As System.Windows.Forms.TabControl
    Friend WithEvents mecdesarme_pn_eje As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
