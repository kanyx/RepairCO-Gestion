Public Class mec_keyboard
    Public Control As TextBox
    Public MaxChar As Integer
    Public CursorPosition As Integer
    Private TextChange As Boolean = False
    Private Sub mec_keyboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.Focus()
        Control.BackColor = ColorTranslator.FromHtml("#4d8bd4")
        Control.ForeColor = ColorTranslator.FromHtml("#ffffff")
        ' # CARGA DE ELEMENTOS GRAFICOS DE LA APLICACION.
        ' # CARGAMOS TODAS LAS IMAGENES A UN CONTROL IMAGELIST.
        Me.key_img_List.ColorDepth = ColorDepth.Depth32Bit
        Me.key_img_List.ImageSize = New Size(59, 60)
        Me.key_img_List.Images.Add(0, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_background.png"))
        Me.key_img_List.Images.Add(1, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_1.png"))
        Me.key_img_List.Images.Add(2, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_2.png"))
        Me.key_img_List.Images.Add(3, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_3.png"))
        Me.key_img_List.Images.Add(4, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_4.png"))
        Me.key_img_List.Images.Add(5, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_5.png"))
        Me.key_img_List.Images.Add(6, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_6.png"))
        Me.key_img_List.Images.Add(7, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_7.png"))
        Me.key_img_List.Images.Add(8, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_8.png"))
        Me.key_img_List.Images.Add(9, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_9.png"))
        Me.key_img_List.Images.Add(10, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_0.png"))
        Me.key_img_List.Images.Add(11, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_del.png"))
        Me.key_img_List.Images.Add(12, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_space.png"))
        Me.key_img_List.Images.Add(13, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_dot.png"))
        Me.key_img_List.Images.Add(14, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_coma.png"))
        Me.key_img_List.Images.Add(15, Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/key_guion.png"))
        Me.key_img_List.Images.Add("close", Image.FromFile(Application.StartupPath & "/Data/grafica/ico/close42x42.png"))
        ' # SETEAMOS LA IMAGEN A LOS CONTROLES
        Me.key_pic_1.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_2.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_3.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_4.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_5.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_6.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_7.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_8.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_9.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_0.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_delete.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_space.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_dot.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_coma.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_guion.BackgroundImage = Me.key_img_List.Images(0)
        Me.key_pic_1.Image = Me.key_img_List.Images(1)
        Me.key_pic_2.Image = Me.key_img_List.Images(2)
        Me.key_pic_3.Image = Me.key_img_List.Images(3)
        Me.key_pic_4.Image = Me.key_img_List.Images(4)
        Me.key_pic_5.Image = Me.key_img_List.Images(5)
        Me.key_pic_6.Image = Me.key_img_List.Images(6)
        Me.key_pic_7.Image = Me.key_img_List.Images(7)
        Me.key_pic_8.Image = Me.key_img_List.Images(8)
        Me.key_pic_9.Image = Me.key_img_List.Images(9)
        Me.key_pic_0.Image = Me.key_img_List.Images(10)
        Me.key_pic_delete.Image = Me.key_img_List.Images(11)
        Me.key_pic_space.Image = Me.key_img_List.Images(12)
        Me.key_pic_dot.Image = Me.key_img_List.Images(13)
        Me.key_pic_coma.Image = Me.key_img_List.Images(14)
        Me.key_pic_guion.Image = Me.key_img_List.Images(15)
        Me.key_pic_close.Image = Me.key_img_List.Images("close")
        ' # SETEAMOS ALGUNOS PARAMETROS DE LOS CONTROLES.
        Me.key_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.key_pic_close.BackColor = Color.Transparent
        Me.key_sender.Visible = True
        Me.key_sender.Location = New Point(200, 300)
        If MaxChar <> 0 Then
            Me.key_sender.MaxLength = MaxChar
        End If
        Me.key_sender.Focus()
        Me.key_sender.SelectionStart = CursorPosition
    End Sub
    Private Sub key_pic_1_Click(sender As Object, e As EventArgs) Handles key_pic_1.Click
        TextChange = True
        SendKeys.Send("1")
    End Sub
    Private Sub key_pic_2_Click(sender As Object, e As EventArgs) Handles key_pic_2.Click
        TextChange = True
        SendKeys.Send("2")
    End Sub
    Private Sub key_pic_3_Click(sender As Object, e As EventArgs) Handles key_pic_3.Click
        TextChange = True
        SendKeys.Send("3")
    End Sub
    Private Sub key_pic_4_Click(sender As Object, e As EventArgs) Handles key_pic_4.Click
        TextChange = True
        SendKeys.Send("4")
    End Sub
    Private Sub key_pic_5_Click(sender As Object, e As EventArgs) Handles key_pic_5.Click
        TextChange = True
        SendKeys.Send("5")
    End Sub
    Private Sub key_pic_6_Click(sender As Object, e As EventArgs) Handles key_pic_6.Click
        TextChange = True
        SendKeys.Send("6")
    End Sub
    Private Sub key_pic_7_Click(sender As Object, e As EventArgs) Handles key_pic_7.Click
        TextChange = True
        SendKeys.Send("7")
    End Sub
    Private Sub key_pic_8_Click(sender As Object, e As EventArgs) Handles key_pic_8.Click
        TextChange = True
        SendKeys.Send("8")
    End Sub
    Private Sub key_pic_9_Click(sender As Object, e As EventArgs) Handles key_pic_9.Click
        TextChange = True
        SendKeys.Send("9")
    End Sub
    Private Sub key_pic_0_Click(sender As Object, e As EventArgs) Handles key_pic_0.Click
        TextChange = True
        SendKeys.Send("0")
    End Sub
    Private Sub key_pic_delete_Click(sender As Object, e As EventArgs) Handles key_pic_delete.Click
        TextChange = True
        SendKeys.Send("{BACKSPACE}")
    End Sub
    Private Sub key_pic_space_Click(sender As Object, e As EventArgs) Handles key_pic_space.Click
        TextChange = True
        SendKeys.Send(" ")
    End Sub
    Private Sub key_pic_dot_Click(sender As Object, e As EventArgs) Handles key_pic_dot.Click
        TextChange = True
        SendKeys.Send(".")
    End Sub
    Private Sub key_pic_coma_Click(sender As Object, e As EventArgs) Handles key_pic_coma.Click
        TextChange = True
        SendKeys.Send(",")
    End Sub
    Private Sub key_pic_guion_Click(sender As Object, e As EventArgs) Handles key_pic_guion.Click
        TextChange = True
        SendKeys.Send("-")
    End Sub
    Private Sub key_pic_close_Click(sender As Object, e As EventArgs) Handles key_pic_close.Click
        Me.Close()
    End Sub
    Private Sub key_sender_TextChanged(sender As Object, e As EventArgs) Handles key_sender.TextChanged
        If TextChange = True Then
            Control.Text = Me.key_sender.Text
        End If
    End Sub
End Class