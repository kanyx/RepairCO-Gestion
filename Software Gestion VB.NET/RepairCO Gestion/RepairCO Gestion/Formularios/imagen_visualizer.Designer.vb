<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imagen_visualizer
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
        Me.visorimagen_pic_image = New System.Windows.Forms.PictureBox()
        Me.visorimagen_pic_close = New System.Windows.Forms.PictureBox()
        Me.visorimagen_pic_title = New System.Windows.Forms.PictureBox()
        Me.visorimagen_pic_ico = New System.Windows.Forms.PictureBox()
        CType(Me.visorimagen_pic_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visorimagen_pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visorimagen_pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visorimagen_pic_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'visorimagen_pic_image
        '
        Me.visorimagen_pic_image.Location = New System.Drawing.Point(20, 51)
        Me.visorimagen_pic_image.Name = "visorimagen_pic_image"
        Me.visorimagen_pic_image.Size = New System.Drawing.Size(640, 480)
        Me.visorimagen_pic_image.TabIndex = 0
        Me.visorimagen_pic_image.TabStop = False
        '
        'visorimagen_pic_close
        '
        Me.visorimagen_pic_close.Location = New System.Drawing.Point(628, 13)
        Me.visorimagen_pic_close.Name = "visorimagen_pic_close"
        Me.visorimagen_pic_close.Size = New System.Drawing.Size(32, 32)
        Me.visorimagen_pic_close.TabIndex = 2
        Me.visorimagen_pic_close.TabStop = False
        '
        'visorimagen_pic_title
        '
        Me.visorimagen_pic_title.Location = New System.Drawing.Point(20, 20)
        Me.visorimagen_pic_title.Name = "visorimagen_pic_title"
        Me.visorimagen_pic_title.Size = New System.Drawing.Size(348, 25)
        Me.visorimagen_pic_title.TabIndex = 3
        Me.visorimagen_pic_title.TabStop = False
        '
        'visorimagen_pic_ico
        '
        Me.visorimagen_pic_ico.Location = New System.Drawing.Point(374, 16)
        Me.visorimagen_pic_ico.Name = "visorimagen_pic_ico"
        Me.visorimagen_pic_ico.Size = New System.Drawing.Size(32, 32)
        Me.visorimagen_pic_ico.TabIndex = 4
        Me.visorimagen_pic_ico.TabStop = False
        '
        'imagen_visualizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 577)
        Me.Controls.Add(Me.visorimagen_pic_ico)
        Me.Controls.Add(Me.visorimagen_pic_title)
        Me.Controls.Add(Me.visorimagen_pic_close)
        Me.Controls.Add(Me.visorimagen_pic_image)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "imagen_visualizer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "imagen_visualizer"
        CType(Me.visorimagen_pic_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visorimagen_pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visorimagen_pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visorimagen_pic_ico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents visorimagen_pic_image As System.Windows.Forms.PictureBox
    Friend WithEvents visorimagen_pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents visorimagen_pic_title As System.Windows.Forms.PictureBox
    Friend WithEvents visorimagen_pic_ico As System.Windows.Forms.PictureBox
End Class
