<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_configuration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_configuration))
        Me.configuration_tabcontrol = New System.Windows.Forms.TabControl()
        Me.configuration_tab_bd = New System.Windows.Forms.TabPage()
        Me.configuration_lbl_warning = New System.Windows.Forms.Label()
        Me.configuration_btn_cancel = New System.Windows.Forms.Button()
        Me.configuration_btn_save = New System.Windows.Forms.Button()
        Me.configuration_pic_logo = New System.Windows.Forms.PictureBox()
        Me.configuration_txt_dbserver = New System.Windows.Forms.TextBox()
        Me.configuration_txt_dbport = New System.Windows.Forms.TextBox()
        Me.configuration_lbl_server = New System.Windows.Forms.Label()
        Me.configuration_lbl_port = New System.Windows.Forms.Label()
        Me.configuration_lbl_user = New System.Windows.Forms.Label()
        Me.configuration_lbl_pass = New System.Windows.Forms.Label()
        Me.configuration_txt_dbuser = New System.Windows.Forms.TextBox()
        Me.configuration_txt_dbpass = New System.Windows.Forms.TextBox()
        Me.configuration_lbl_db = New System.Windows.Forms.Label()
        Me.configuration_txt_dbname = New System.Windows.Forms.TextBox()
        Me.configuration_cmb_dbssl = New System.Windows.Forms.ComboBox()
        Me.configuration_lbl_ssl = New System.Windows.Forms.Label()
        Me.configuration_btn_testconex = New System.Windows.Forms.Button()
        Me.configuration_lbl_appversion = New System.Windows.Forms.Label()
        Me.configuration_tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.configuration_tabcontrol.SuspendLayout()
        Me.configuration_tab_bd.SuspendLayout()
        CType(Me.configuration_pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'configuration_tabcontrol
        '
        Me.configuration_tabcontrol.Controls.Add(Me.configuration_tab_bd)
        Me.configuration_tabcontrol.Location = New System.Drawing.Point(12, 34)
        Me.configuration_tabcontrol.Name = "configuration_tabcontrol"
        Me.configuration_tabcontrol.SelectedIndex = 0
        Me.configuration_tabcontrol.Size = New System.Drawing.Size(714, 295)
        Me.configuration_tabcontrol.TabIndex = 0
        '
        'configuration_tab_bd
        '
        Me.configuration_tab_bd.Controls.Add(Me.configuration_btn_testconex)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_lbl_ssl)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_cmb_dbssl)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_txt_dbname)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_lbl_db)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_txt_dbpass)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_txt_dbuser)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_lbl_pass)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_lbl_user)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_lbl_port)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_lbl_server)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_txt_dbport)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_txt_dbserver)
        Me.configuration_tab_bd.Controls.Add(Me.configuration_pic_logo)
        Me.configuration_tab_bd.Location = New System.Drawing.Point(4, 22)
        Me.configuration_tab_bd.Name = "configuration_tab_bd"
        Me.configuration_tab_bd.Padding = New System.Windows.Forms.Padding(3)
        Me.configuration_tab_bd.Size = New System.Drawing.Size(706, 269)
        Me.configuration_tab_bd.TabIndex = 0
        Me.configuration_tab_bd.Text = "Base de Datos"
        Me.configuration_tab_bd.UseVisualStyleBackColor = True
        '
        'configuration_lbl_warning
        '
        Me.configuration_lbl_warning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.configuration_lbl_warning.ForeColor = System.Drawing.Color.Red
        Me.configuration_lbl_warning.Location = New System.Drawing.Point(131, 16)
        Me.configuration_lbl_warning.Name = "configuration_lbl_warning"
        Me.configuration_lbl_warning.Size = New System.Drawing.Size(588, 31)
        Me.configuration_lbl_warning.TabIndex = 1
        Me.configuration_lbl_warning.Text = resources.GetString("configuration_lbl_warning.Text")
        '
        'configuration_btn_cancel
        '
        Me.configuration_btn_cancel.Location = New System.Drawing.Point(647, 335)
        Me.configuration_btn_cancel.Name = "configuration_btn_cancel"
        Me.configuration_btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.configuration_btn_cancel.TabIndex = 2
        Me.configuration_btn_cancel.Text = "Cancelar"
        Me.configuration_btn_cancel.UseVisualStyleBackColor = True
        '
        'configuration_btn_save
        '
        Me.configuration_btn_save.Location = New System.Drawing.Point(566, 335)
        Me.configuration_btn_save.Name = "configuration_btn_save"
        Me.configuration_btn_save.Size = New System.Drawing.Size(75, 23)
        Me.configuration_btn_save.TabIndex = 3
        Me.configuration_btn_save.Text = "Guardar"
        Me.configuration_btn_save.UseVisualStyleBackColor = True
        '
        'configuration_pic_logo
        '
        Me.configuration_pic_logo.Location = New System.Drawing.Point(432, 21)
        Me.configuration_pic_logo.Name = "configuration_pic_logo"
        Me.configuration_pic_logo.Size = New System.Drawing.Size(250, 229)
        Me.configuration_pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.configuration_pic_logo.TabIndex = 0
        Me.configuration_pic_logo.TabStop = False
        '
        'configuration_txt_dbserver
        '
        Me.configuration_txt_dbserver.Location = New System.Drawing.Point(6, 32)
        Me.configuration_txt_dbserver.Name = "configuration_txt_dbserver"
        Me.configuration_txt_dbserver.Size = New System.Drawing.Size(162, 20)
        Me.configuration_txt_dbserver.TabIndex = 1
        '
        'configuration_txt_dbport
        '
        Me.configuration_txt_dbport.Location = New System.Drawing.Point(174, 32)
        Me.configuration_txt_dbport.Name = "configuration_txt_dbport"
        Me.configuration_txt_dbport.Size = New System.Drawing.Size(83, 20)
        Me.configuration_txt_dbport.TabIndex = 2
        '
        'configuration_lbl_server
        '
        Me.configuration_lbl_server.AutoSize = True
        Me.configuration_lbl_server.Location = New System.Drawing.Point(6, 16)
        Me.configuration_lbl_server.Name = "configuration_lbl_server"
        Me.configuration_lbl_server.Size = New System.Drawing.Size(46, 13)
        Me.configuration_lbl_server.TabIndex = 3
        Me.configuration_lbl_server.Text = "Servidor"
        '
        'configuration_lbl_port
        '
        Me.configuration_lbl_port.AutoSize = True
        Me.configuration_lbl_port.Location = New System.Drawing.Point(171, 16)
        Me.configuration_lbl_port.Name = "configuration_lbl_port"
        Me.configuration_lbl_port.Size = New System.Drawing.Size(38, 13)
        Me.configuration_lbl_port.TabIndex = 4
        Me.configuration_lbl_port.Text = "Puerto"
        '
        'configuration_lbl_user
        '
        Me.configuration_lbl_user.AutoSize = True
        Me.configuration_lbl_user.Location = New System.Drawing.Point(6, 55)
        Me.configuration_lbl_user.Name = "configuration_lbl_user"
        Me.configuration_lbl_user.Size = New System.Drawing.Size(61, 13)
        Me.configuration_lbl_user.TabIndex = 5
        Me.configuration_lbl_user.Text = "Usuario BD"
        '
        'configuration_lbl_pass
        '
        Me.configuration_lbl_pass.AutoSize = True
        Me.configuration_lbl_pass.Location = New System.Drawing.Point(139, 55)
        Me.configuration_lbl_pass.Name = "configuration_lbl_pass"
        Me.configuration_lbl_pass.Size = New System.Drawing.Size(71, 13)
        Me.configuration_lbl_pass.TabIndex = 6
        Me.configuration_lbl_pass.Text = "Password BD"
        '
        'configuration_txt_dbuser
        '
        Me.configuration_txt_dbuser.Location = New System.Drawing.Point(6, 72)
        Me.configuration_txt_dbuser.Name = "configuration_txt_dbuser"
        Me.configuration_txt_dbuser.Size = New System.Drawing.Size(130, 20)
        Me.configuration_txt_dbuser.TabIndex = 7
        '
        'configuration_txt_dbpass
        '
        Me.configuration_txt_dbpass.Location = New System.Drawing.Point(142, 72)
        Me.configuration_txt_dbpass.Name = "configuration_txt_dbpass"
        Me.configuration_txt_dbpass.Size = New System.Drawing.Size(115, 20)
        Me.configuration_txt_dbpass.TabIndex = 8
        '
        'configuration_lbl_db
        '
        Me.configuration_lbl_db.AutoSize = True
        Me.configuration_lbl_db.Location = New System.Drawing.Point(6, 95)
        Me.configuration_lbl_db.Name = "configuration_lbl_db"
        Me.configuration_lbl_db.Size = New System.Drawing.Size(77, 13)
        Me.configuration_lbl_db.TabIndex = 9
        Me.configuration_lbl_db.Text = "Base de Datos"
        '
        'configuration_txt_dbname
        '
        Me.configuration_txt_dbname.Location = New System.Drawing.Point(6, 111)
        Me.configuration_txt_dbname.Name = "configuration_txt_dbname"
        Me.configuration_txt_dbname.Size = New System.Drawing.Size(130, 20)
        Me.configuration_txt_dbname.TabIndex = 10
        '
        'configuration_cmb_dbssl
        '
        Me.configuration_cmb_dbssl.FormattingEnabled = True
        Me.configuration_cmb_dbssl.Items.AddRange(New Object() {"Si", "No"})
        Me.configuration_cmb_dbssl.Location = New System.Drawing.Point(142, 111)
        Me.configuration_cmb_dbssl.Name = "configuration_cmb_dbssl"
        Me.configuration_cmb_dbssl.Size = New System.Drawing.Size(121, 21)
        Me.configuration_cmb_dbssl.TabIndex = 11
        '
        'configuration_lbl_ssl
        '
        Me.configuration_lbl_ssl.AutoSize = True
        Me.configuration_lbl_ssl.Location = New System.Drawing.Point(139, 95)
        Me.configuration_lbl_ssl.Name = "configuration_lbl_ssl"
        Me.configuration_lbl_ssl.Size = New System.Drawing.Size(27, 13)
        Me.configuration_lbl_ssl.TabIndex = 12
        Me.configuration_lbl_ssl.Text = "SSL"
        '
        'configuration_btn_testconex
        '
        Me.configuration_btn_testconex.Location = New System.Drawing.Point(151, 138)
        Me.configuration_btn_testconex.Name = "configuration_btn_testconex"
        Me.configuration_btn_testconex.Size = New System.Drawing.Size(112, 23)
        Me.configuration_btn_testconex.TabIndex = 13
        Me.configuration_btn_testconex.Text = "Probar Conexion"
        Me.configuration_btn_testconex.UseVisualStyleBackColor = True
        '
        'configuration_lbl_appversion
        '
        Me.configuration_lbl_appversion.AutoSize = True
        Me.configuration_lbl_appversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.configuration_lbl_appversion.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.configuration_lbl_appversion.Location = New System.Drawing.Point(9, 340)
        Me.configuration_lbl_appversion.Name = "configuration_lbl_appversion"
        Me.configuration_lbl_appversion.Size = New System.Drawing.Size(97, 13)
        Me.configuration_lbl_appversion.TabIndex = 4
        Me.configuration_lbl_appversion.Text = "Version: 9.9.9.9"
        '
        'main_configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(738, 365)
        Me.Controls.Add(Me.configuration_lbl_appversion)
        Me.Controls.Add(Me.configuration_btn_save)
        Me.Controls.Add(Me.configuration_btn_cancel)
        Me.Controls.Add(Me.configuration_lbl_warning)
        Me.Controls.Add(Me.configuration_tabcontrol)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main_configuration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RepairCO - Configuracion"
        Me.configuration_tabcontrol.ResumeLayout(False)
        Me.configuration_tab_bd.ResumeLayout(False)
        Me.configuration_tab_bd.PerformLayout()
        CType(Me.configuration_pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents configuration_tabcontrol As System.Windows.Forms.TabControl
    Friend WithEvents configuration_tab_bd As System.Windows.Forms.TabPage
    Friend WithEvents configuration_lbl_warning As System.Windows.Forms.Label
    Friend WithEvents configuration_btn_cancel As System.Windows.Forms.Button
    Friend WithEvents configuration_btn_save As System.Windows.Forms.Button
    Friend WithEvents configuration_pic_logo As System.Windows.Forms.PictureBox
    Friend WithEvents configuration_txt_dbport As System.Windows.Forms.TextBox
    Friend WithEvents configuration_txt_dbserver As System.Windows.Forms.TextBox
    Friend WithEvents configuration_lbl_server As System.Windows.Forms.Label
    Friend WithEvents configuration_txt_dbpass As System.Windows.Forms.TextBox
    Friend WithEvents configuration_txt_dbuser As System.Windows.Forms.TextBox
    Friend WithEvents configuration_lbl_pass As System.Windows.Forms.Label
    Friend WithEvents configuration_lbl_user As System.Windows.Forms.Label
    Friend WithEvents configuration_lbl_port As System.Windows.Forms.Label
    Friend WithEvents configuration_txt_dbname As System.Windows.Forms.TextBox
    Friend WithEvents configuration_lbl_db As System.Windows.Forms.Label
    Friend WithEvents configuration_btn_testconex As System.Windows.Forms.Button
    Friend WithEvents configuration_lbl_ssl As System.Windows.Forms.Label
    Friend WithEvents configuration_cmb_dbssl As System.Windows.Forms.ComboBox
    Friend WithEvents configuration_lbl_appversion As System.Windows.Forms.Label
    Friend WithEvents configuration_tooltip As System.Windows.Forms.ToolTip
End Class
