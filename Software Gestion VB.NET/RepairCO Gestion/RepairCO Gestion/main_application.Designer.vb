<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_application
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_application))
        Me.mainapp_menuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainapp_help_aboutme = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainapp_statusStrip = New System.Windows.Forms.StatusStrip()
        Me.mainapp_status_text = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainapp_lbl_clock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainapp_tooltip_help = New System.Windows.Forms.ToolTip(Me.components)
        Me.mainapp_tm_clock = New System.Windows.Forms.Timer(Me.components)
        Me.mainapp_menuStrip.SuspendLayout()
        Me.mainapp_statusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainapp_menuStrip
        '
        Me.mainapp_menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HelpMenu})
        Me.mainapp_menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainapp_menuStrip.Name = "mainapp_menuStrip"
        Me.mainapp_menuStrip.Size = New System.Drawing.Size(768, 24)
        Me.mainapp_menuStrip.TabIndex = 5
        Me.mainapp_menuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(60, 20)
        Me.FileMenu.Text = "&Archivo"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainapp_help_aboutme})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(53, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'mainapp_help_aboutme
        '
        Me.mainapp_help_aboutme.Name = "mainapp_help_aboutme"
        Me.mainapp_help_aboutme.Size = New System.Drawing.Size(135, 22)
        Me.mainapp_help_aboutme.Text = "&Acerca de..."
        '
        'mainapp_statusStrip
        '
        Me.mainapp_statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainapp_status_text, Me.mainapp_lbl_clock})
        Me.mainapp_statusStrip.Location = New System.Drawing.Point(0, 443)
        Me.mainapp_statusStrip.Name = "mainapp_statusStrip"
        Me.mainapp_statusStrip.Size = New System.Drawing.Size(768, 22)
        Me.mainapp_statusStrip.TabIndex = 7
        Me.mainapp_statusStrip.Text = "StatusStrip"
        '
        'mainapp_status_text
        '
        Me.mainapp_status_text.Name = "mainapp_status_text"
        Me.mainapp_status_text.Size = New System.Drawing.Size(42, 17)
        Me.mainapp_status_text.Text = "Estado"
        '
        'mainapp_lbl_clock
        '
        Me.mainapp_lbl_clock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainapp_lbl_clock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mainapp_lbl_clock.Name = "mainapp_lbl_clock"
        Me.mainapp_lbl_clock.Size = New System.Drawing.Size(55, 17)
        Me.mainapp_lbl_clock.Text = "00:00:00"
        Me.mainapp_lbl_clock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mainapp_lbl_clock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'mainapp_tm_clock
        '
        Me.mainapp_tm_clock.Interval = 1000
        '
        'main_application
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(768, 465)
        Me.Controls.Add(Me.mainapp_menuStrip)
        Me.Controls.Add(Me.mainapp_statusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mainapp_menuStrip
        Me.MaximizeBox = False
        Me.Name = "main_application"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.G.O"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainapp_menuStrip.ResumeLayout(False)
        Me.mainapp_menuStrip.PerformLayout()
        Me.mainapp_statusStrip.ResumeLayout(False)
        Me.mainapp_statusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainapp_help_aboutme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainapp_tooltip_help As System.Windows.Forms.ToolTip
    Friend WithEvents mainapp_status_text As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mainapp_statusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainapp_menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mainapp_tm_clock As System.Windows.Forms.Timer
    Friend WithEvents mainapp_lbl_clock As System.Windows.Forms.ToolStripStatusLabel

End Class
