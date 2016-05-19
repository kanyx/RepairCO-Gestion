<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mec_dashboard
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
        Me.mecdash_pic_header = New System.Windows.Forms.PictureBox()
        Me.mecdash_pic_user = New System.Windows.Forms.PictureBox()
        Me.mecdash_lbl_nombreuser = New System.Windows.Forms.Label()
        Me.mecdash_lbl_rut = New System.Windows.Forms.Label()
        Me.mecdash_lbl_station = New System.Windows.Forms.Label()
        Me.mecdash_tm_clock = New System.Windows.Forms.Timer(Me.components)
        Me.mecdash_lbl_clock = New System.Windows.Forms.Label()
        Me.mecdash_pn_content = New System.Windows.Forms.Panel()
        Me.mecdash_pic_utilhome = New System.Windows.Forms.PictureBox()
        Me.mecdash_pic_utilinspector = New System.Windows.Forms.PictureBox()
        Me.mecdash_pic_utildevelop = New System.Windows.Forms.PictureBox()
        Me.mecdash_pic_utilcuser = New System.Windows.Forms.PictureBox()
        Me.mecdash_pn_utils = New System.Windows.Forms.Panel()
        Me.close_hide = New System.Windows.Forms.PictureBox()
        CType(Me.mecdash_pic_header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mecdash_pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mecdash_pic_utilhome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mecdash_pic_utilinspector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mecdash_pic_utildevelop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mecdash_pic_utilcuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mecdash_pn_utils.SuspendLayout()
        CType(Me.close_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mecdash_pic_header
        '
        Me.mecdash_pic_header.Location = New System.Drawing.Point(0, 0)
        Me.mecdash_pic_header.Name = "mecdash_pic_header"
        Me.mecdash_pic_header.Size = New System.Drawing.Size(1366, 169)
        Me.mecdash_pic_header.TabIndex = 0
        Me.mecdash_pic_header.TabStop = False
        '
        'mecdash_pic_user
        '
        Me.mecdash_pic_user.Location = New System.Drawing.Point(22, 17)
        Me.mecdash_pic_user.Name = "mecdash_pic_user"
        Me.mecdash_pic_user.Size = New System.Drawing.Size(142, 134)
        Me.mecdash_pic_user.TabIndex = 1
        Me.mecdash_pic_user.TabStop = False
        '
        'mecdash_lbl_nombreuser
        '
        Me.mecdash_lbl_nombreuser.AutoSize = True
        Me.mecdash_lbl_nombreuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mecdash_lbl_nombreuser.Location = New System.Drawing.Point(170, 43)
        Me.mecdash_lbl_nombreuser.Name = "mecdash_lbl_nombreuser"
        Me.mecdash_lbl_nombreuser.Size = New System.Drawing.Size(90, 20)
        Me.mecdash_lbl_nombreuser.TabIndex = 2
        Me.mecdash_lbl_nombreuser.Text = "NOMBRE:"
        '
        'mecdash_lbl_rut
        '
        Me.mecdash_lbl_rut.AutoSize = True
        Me.mecdash_lbl_rut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mecdash_lbl_rut.Location = New System.Drawing.Point(171, 67)
        Me.mecdash_lbl_rut.Name = "mecdash_lbl_rut"
        Me.mecdash_lbl_rut.Size = New System.Drawing.Size(57, 18)
        Me.mecdash_lbl_rut.TabIndex = 3
        Me.mecdash_lbl_rut.Text = "Label1"
        '
        'mecdash_lbl_station
        '
        Me.mecdash_lbl_station.AutoSize = True
        Me.mecdash_lbl_station.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mecdash_lbl_station.Location = New System.Drawing.Point(171, 108)
        Me.mecdash_lbl_station.Name = "mecdash_lbl_station"
        Me.mecdash_lbl_station.Size = New System.Drawing.Size(57, 18)
        Me.mecdash_lbl_station.TabIndex = 4
        Me.mecdash_lbl_station.Text = "Label1"
        '
        'mecdash_tm_clock
        '
        '
        'mecdash_lbl_clock
        '
        Me.mecdash_lbl_clock.AutoSize = True
        Me.mecdash_lbl_clock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mecdash_lbl_clock.Location = New System.Drawing.Point(171, 128)
        Me.mecdash_lbl_clock.Name = "mecdash_lbl_clock"
        Me.mecdash_lbl_clock.Size = New System.Drawing.Size(57, 18)
        Me.mecdash_lbl_clock.TabIndex = 5
        Me.mecdash_lbl_clock.Text = "Label1"
        '
        'mecdash_pn_content
        '
        Me.mecdash_pn_content.Location = New System.Drawing.Point(1, 172)
        Me.mecdash_pn_content.Name = "mecdash_pn_content"
        Me.mecdash_pn_content.Size = New System.Drawing.Size(1363, 593)
        Me.mecdash_pn_content.TabIndex = 7
        '
        'mecdash_pic_utilhome
        '
        Me.mecdash_pic_utilhome.Location = New System.Drawing.Point(60, 22)
        Me.mecdash_pic_utilhome.Name = "mecdash_pic_utilhome"
        Me.mecdash_pic_utilhome.Size = New System.Drawing.Size(55, 50)
        Me.mecdash_pic_utilhome.TabIndex = 8
        Me.mecdash_pic_utilhome.TabStop = False
        '
        'mecdash_pic_utilinspector
        '
        Me.mecdash_pic_utilinspector.Location = New System.Drawing.Point(130, 28)
        Me.mecdash_pic_utilinspector.Name = "mecdash_pic_utilinspector"
        Me.mecdash_pic_utilinspector.Size = New System.Drawing.Size(56, 50)
        Me.mecdash_pic_utilinspector.TabIndex = 9
        Me.mecdash_pic_utilinspector.TabStop = False
        '
        'mecdash_pic_utildevelop
        '
        Me.mecdash_pic_utildevelop.Location = New System.Drawing.Point(202, 25)
        Me.mecdash_pic_utildevelop.Name = "mecdash_pic_utildevelop"
        Me.mecdash_pic_utildevelop.Size = New System.Drawing.Size(50, 50)
        Me.mecdash_pic_utildevelop.TabIndex = 10
        Me.mecdash_pic_utildevelop.TabStop = False
        '
        'mecdash_pic_utilcuser
        '
        Me.mecdash_pic_utilcuser.Location = New System.Drawing.Point(268, 25)
        Me.mecdash_pic_utilcuser.Name = "mecdash_pic_utilcuser"
        Me.mecdash_pic_utilcuser.Size = New System.Drawing.Size(50, 50)
        Me.mecdash_pic_utilcuser.TabIndex = 11
        Me.mecdash_pic_utilcuser.TabStop = False
        '
        'mecdash_pn_utils
        '
        Me.mecdash_pn_utils.Controls.Add(Me.mecdash_pic_utilhome)
        Me.mecdash_pn_utils.Controls.Add(Me.mecdash_pic_utilcuser)
        Me.mecdash_pn_utils.Controls.Add(Me.mecdash_pic_utilinspector)
        Me.mecdash_pn_utils.Controls.Add(Me.mecdash_pic_utildevelop)
        Me.mecdash_pn_utils.Location = New System.Drawing.Point(567, 51)
        Me.mecdash_pn_utils.Name = "mecdash_pn_utils"
        Me.mecdash_pn_utils.Size = New System.Drawing.Size(373, 80)
        Me.mecdash_pn_utils.TabIndex = 12
        '
        'close_hide
        '
        Me.close_hide.Location = New System.Drawing.Point(1354, 0)
        Me.close_hide.Name = "close_hide"
        Me.close_hide.Size = New System.Drawing.Size(10, 10)
        Me.close_hide.TabIndex = 13
        Me.close_hide.TabStop = False
        '
        'mec_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.close_hide)
        Me.Controls.Add(Me.mecdash_pn_utils)
        Me.Controls.Add(Me.mecdash_pn_content)
        Me.Controls.Add(Me.mecdash_lbl_clock)
        Me.Controls.Add(Me.mecdash_lbl_station)
        Me.Controls.Add(Me.mecdash_lbl_rut)
        Me.Controls.Add(Me.mecdash_lbl_nombreuser)
        Me.Controls.Add(Me.mecdash_pic_user)
        Me.Controls.Add(Me.mecdash_pic_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mec_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "mec_dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.mecdash_pic_header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mecdash_pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mecdash_pic_utilhome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mecdash_pic_utilinspector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mecdash_pic_utildevelop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mecdash_pic_utilcuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mecdash_pn_utils.ResumeLayout(False)
        CType(Me.close_hide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mecdash_pic_header As System.Windows.Forms.PictureBox
    Friend WithEvents mecdash_pic_user As System.Windows.Forms.PictureBox
    Friend WithEvents mecdash_lbl_nombreuser As System.Windows.Forms.Label
    Friend WithEvents mecdash_lbl_rut As System.Windows.Forms.Label
    Friend WithEvents mecdash_lbl_station As System.Windows.Forms.Label
    Friend WithEvents mecdash_tm_clock As System.Windows.Forms.Timer
    Friend WithEvents mecdash_lbl_clock As System.Windows.Forms.Label
    Friend WithEvents mecdash_pn_content As System.Windows.Forms.Panel
    Friend WithEvents mecdash_pic_utilhome As System.Windows.Forms.PictureBox
    Friend WithEvents mecdash_pic_utilinspector As System.Windows.Forms.PictureBox
    Friend WithEvents mecdash_pic_utildevelop As System.Windows.Forms.PictureBox
    Friend WithEvents mecdash_pic_utilcuser As System.Windows.Forms.PictureBox
    Friend WithEvents mecdash_pn_utils As System.Windows.Forms.Panel
    Friend WithEvents close_hide As System.Windows.Forms.PictureBox
End Class
