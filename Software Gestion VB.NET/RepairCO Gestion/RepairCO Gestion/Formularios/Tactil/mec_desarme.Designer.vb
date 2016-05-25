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
        Me.components = New System.ComponentModel.Container()
        Me.mecdesarme_tb_main = New System.Windows.Forms.TabControl()
        Me.mecdesarme_pn_eje = New System.Windows.Forms.TabPage()
        Me.mecdesarme_pn_resumen = New System.Windows.Forms.TabPage()
        Me.mecdesarme_il_tab = New System.Windows.Forms.ImageList(Me.components)
        Me.mecdesarme_pn_carcasa = New System.Windows.Forms.TabPage()
        Me.mecdesarme_pn_camisa = New System.Windows.Forms.TabPage()
        Me.mecdesarme_tb_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'mecdesarme_tb_main
        '
        Me.mecdesarme_tb_main.Controls.Add(Me.mecdesarme_pn_eje)
        Me.mecdesarme_tb_main.Controls.Add(Me.mecdesarme_pn_camisa)
        Me.mecdesarme_tb_main.Controls.Add(Me.mecdesarme_pn_carcasa)
        Me.mecdesarme_tb_main.Controls.Add(Me.mecdesarme_pn_resumen)
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
        'mecdesarme_pn_resumen
        '
        Me.mecdesarme_pn_resumen.Location = New System.Drawing.Point(4, 22)
        Me.mecdesarme_pn_resumen.Name = "mecdesarme_pn_resumen"
        Me.mecdesarme_pn_resumen.Padding = New System.Windows.Forms.Padding(3)
        Me.mecdesarme_pn_resumen.Size = New System.Drawing.Size(1361, 506)
        Me.mecdesarme_pn_resumen.TabIndex = 1
        Me.mecdesarme_pn_resumen.Text = "RESUMEN"
        Me.mecdesarme_pn_resumen.UseVisualStyleBackColor = True
        '
        'mecdesarme_il_tab
        '
        Me.mecdesarme_il_tab.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.mecdesarme_il_tab.ImageSize = New System.Drawing.Size(16, 16)
        Me.mecdesarme_il_tab.TransparentColor = System.Drawing.Color.Transparent
        '
        'mecdesarme_pn_carcasa
        '
        Me.mecdesarme_pn_carcasa.Location = New System.Drawing.Point(4, 22)
        Me.mecdesarme_pn_carcasa.Name = "mecdesarme_pn_carcasa"
        Me.mecdesarme_pn_carcasa.Size = New System.Drawing.Size(1361, 506)
        Me.mecdesarme_pn_carcasa.TabIndex = 2
        Me.mecdesarme_pn_carcasa.Text = "CARCASA"
        Me.mecdesarme_pn_carcasa.UseVisualStyleBackColor = True
        '
        'mecdesarme_pn_camisa
        '
        Me.mecdesarme_pn_camisa.Location = New System.Drawing.Point(4, 22)
        Me.mecdesarme_pn_camisa.Name = "mecdesarme_pn_camisa"
        Me.mecdesarme_pn_camisa.Size = New System.Drawing.Size(1361, 506)
        Me.mecdesarme_pn_camisa.TabIndex = 3
        Me.mecdesarme_pn_camisa.Text = "CAMISA"
        Me.mecdesarme_pn_camisa.UseVisualStyleBackColor = True
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
    Friend WithEvents mecdesarme_pn_resumen As System.Windows.Forms.TabPage
    Friend WithEvents mecdesarme_il_tab As System.Windows.Forms.ImageList
    Friend WithEvents mecdesarme_pn_carcasa As System.Windows.Forms.TabPage
    Friend WithEvents mecdesarme_pn_camisa As System.Windows.Forms.TabPage
End Class
