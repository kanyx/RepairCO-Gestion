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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("INGRESAR", 3, 3)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VER", 2, 2)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RECEPCION", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PLANIFICACION", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.main_menu_logo = New System.Windows.Forms.PictureBox()
        Me.mainmenu_container = New System.Windows.Forms.TreeView()
        Me.mainmenu_iconlist = New System.Windows.Forms.ImageList(Me.components)
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
        Me.mainmenu_container.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mainmenu_container.Cursor = System.Windows.Forms.Cursors.Default
        Me.mainmenu_container.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainmenu_container.ImageIndex = 0
        Me.mainmenu_container.ImageList = Me.mainmenu_iconlist
        Me.mainmenu_container.ItemHeight = 24
        Me.mainmenu_container.Location = New System.Drawing.Point(12, 133)
        Me.mainmenu_container.Name = "mainmenu_container"
        TreeNode1.ImageIndex = 3
        TreeNode1.Name = "menu_recepcioningresar"
        TreeNode1.SelectedImageIndex = 3
        TreeNode1.Text = "INGRESAR"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "menu_recepcioneslista"
        TreeNode2.SelectedImageIndex = 2
        TreeNode2.Text = "VER"
        TreeNode3.ImageIndex = 1
        TreeNode3.Name = "menu_recepcion"
        TreeNode3.SelectedImageIndex = 1
        TreeNode3.Text = "RECEPCION"
        TreeNode4.ImageIndex = 0
        TreeNode4.Name = "menu_planificacion"
        TreeNode4.SelectedImageIndex = 0
        TreeNode4.Text = "PLANIFICACION"
        Me.mainmenu_container.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.mainmenu_container.SelectedImageIndex = 0
        Me.mainmenu_container.Size = New System.Drawing.Size(235, 358)
        Me.mainmenu_container.TabIndex = 1
        '
        'mainmenu_iconlist
        '
        Me.mainmenu_iconlist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.mainmenu_iconlist.ImageSize = New System.Drawing.Size(24, 24)
        Me.mainmenu_iconlist.TransparentColor = System.Drawing.Color.Transparent
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
    Friend WithEvents mainmenu_iconlist As System.Windows.Forms.ImageList
End Class
