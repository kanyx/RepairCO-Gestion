<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_loggin
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
        Me.loggin_logo = New System.Windows.Forms.PictureBox()
        Me.loggin_username_txt = New System.Windows.Forms.TextBox()
        Me.loggin_username_lbl = New System.Windows.Forms.Label()
        Me.loggin_password_lbl = New System.Windows.Forms.Label()
        Me.loggin_password_txt = New System.Windows.Forms.TextBox()
        Me.loggin_help_tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.loggin_enter_btn = New System.Windows.Forms.Button()
        Me.loggin_config_btn = New System.Windows.Forms.Button()
        CType(Me.loggin_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loggin_logo
        '
        Me.loggin_logo.Location = New System.Drawing.Point(15, 12)
        Me.loggin_logo.Name = "loggin_logo"
        Me.loggin_logo.Size = New System.Drawing.Size(246, 61)
        Me.loggin_logo.TabIndex = 0
        Me.loggin_logo.TabStop = False
        '
        'loggin_username_txt
        '
        Me.loggin_username_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggin_username_txt.Location = New System.Drawing.Point(32, 105)
        Me.loggin_username_txt.Name = "loggin_username_txt"
        Me.loggin_username_txt.Size = New System.Drawing.Size(194, 26)
        Me.loggin_username_txt.TabIndex = 1
        '
        'loggin_username_lbl
        '
        Me.loggin_username_lbl.AutoSize = True
        Me.loggin_username_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggin_username_lbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.loggin_username_lbl.Location = New System.Drawing.Point(28, 84)
        Me.loggin_username_lbl.Name = "loggin_username_lbl"
        Me.loggin_username_lbl.Size = New System.Drawing.Size(146, 20)
        Me.loggin_username_lbl.TabIndex = 2
        Me.loggin_username_lbl.Text = "Nombre de Usuario"
        '
        'loggin_password_lbl
        '
        Me.loggin_password_lbl.AutoSize = True
        Me.loggin_password_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggin_password_lbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.loggin_password_lbl.Location = New System.Drawing.Point(28, 134)
        Me.loggin_password_lbl.Name = "loggin_password_lbl"
        Me.loggin_password_lbl.Size = New System.Drawing.Size(92, 20)
        Me.loggin_password_lbl.TabIndex = 3
        Me.loggin_password_lbl.Text = "Contraseña"
        '
        'loggin_password_txt
        '
        Me.loggin_password_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggin_password_txt.Location = New System.Drawing.Point(32, 157)
        Me.loggin_password_txt.Name = "loggin_password_txt"
        Me.loggin_password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.loggin_password_txt.Size = New System.Drawing.Size(194, 26)
        Me.loggin_password_txt.TabIndex = 4
        '
        'loggin_enter_btn
        '
        Me.loggin_enter_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggin_enter_btn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.loggin_enter_btn.Location = New System.Drawing.Point(63, 189)
        Me.loggin_enter_btn.Name = "loggin_enter_btn"
        Me.loggin_enter_btn.Size = New System.Drawing.Size(131, 30)
        Me.loggin_enter_btn.TabIndex = 5
        Me.loggin_enter_btn.Text = "INGRESAR"
        Me.loggin_enter_btn.UseVisualStyleBackColor = True
        '
        'loggin_config_btn
        '
        Me.loggin_config_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggin_config_btn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.loggin_config_btn.Location = New System.Drawing.Point(63, 225)
        Me.loggin_config_btn.Name = "loggin_config_btn"
        Me.loggin_config_btn.Size = New System.Drawing.Size(131, 29)
        Me.loggin_config_btn.TabIndex = 6
        Me.loggin_config_btn.Text = "CONFIGURACION"
        Me.loggin_config_btn.UseVisualStyleBackColor = True
        '
        'main_loggin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(270, 263)
        Me.Controls.Add(Me.loggin_config_btn)
        Me.Controls.Add(Me.loggin_enter_btn)
        Me.Controls.Add(Me.loggin_password_txt)
        Me.Controls.Add(Me.loggin_password_lbl)
        Me.Controls.Add(Me.loggin_username_lbl)
        Me.Controls.Add(Me.loggin_username_txt)
        Me.Controls.Add(Me.loggin_logo)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main_loggin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RepairCO"
        CType(Me.loggin_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loggin_logo As System.Windows.Forms.PictureBox
    Friend WithEvents loggin_username_txt As System.Windows.Forms.TextBox
    Friend WithEvents loggin_username_lbl As System.Windows.Forms.Label
    Friend WithEvents loggin_password_lbl As System.Windows.Forms.Label
    Friend WithEvents loggin_password_txt As System.Windows.Forms.TextBox
    Friend WithEvents loggin_help_tip As System.Windows.Forms.ToolTip
    Friend WithEvents loggin_enter_btn As System.Windows.Forms.Button
    Friend WithEvents loggin_config_btn As System.Windows.Forms.Button

End Class
