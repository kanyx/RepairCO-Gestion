<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_menu_lateral
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
        Me.main_menu_logo = New System.Windows.Forms.PictureBox()
        Me.mainmenu_container = New System.Windows.Forms.TreeView()
        Me.mainmenu_pic_title = New System.Windows.Forms.PictureBox()
        CType(Me.main_menu_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainmenu_pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main_menu_logo
        '
        Me.main_menu_logo.Location = New System.Drawing.Point(30, 17)
        Me.main_menu_logo.Name = "main_menu_logo"
        Me.main_menu_logo.Size = New System.Drawing.Size(184, 71)
        Me.main_menu_logo.TabIndex = 0
        Me.main_menu_logo.TabStop = False
        '
        'mainmenu_container
        '
        Me.mainmenu_container.Location = New System.Drawing.Point(12, 133)
        Me.mainmenu_container.Name = "mainmenu_container"
        Me.mainmenu_container.Size = New System.Drawing.Size(227, 358)
        Me.mainmenu_container.TabIndex = 1
        '
        'mainmenu_pic_title
        '
        Me.mainmenu_pic_title.Location = New System.Drawing.Point(12, 108)
        Me.mainmenu_pic_title.Name = "mainmenu_pic_title"
        Me.mainmenu_pic_title.Size = New System.Drawing.Size(140, 19)
        Me.mainmenu_pic_title.TabIndex = 2
        Me.mainmenu_pic_title.TabStop = False
        '
        'main_menu_lateral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(251, 514)
        Me.Controls.Add(Me.mainmenu_pic_title)
        Me.Controls.Add(Me.mainmenu_container)
        Me.Controls.Add(Me.main_menu_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main_menu_lateral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "main_menu_lateral"
        CType(Me.main_menu_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainmenu_pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_menu_logo As System.Windows.Forms.PictureBox
    Friend WithEvents mainmenu_container As System.Windows.Forms.TreeView
    Friend WithEvents mainmenu_pic_title As System.Windows.Forms.PictureBox
End Class
