Public Class main_menu_lateral
    Private Sub main_menu_lateral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # Carga elementos visuales, texto y de la aplicacion.
        main_menu_logo.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/logo_menu.png")
        mainmenu_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/menu_lateral_texto.png")
    End Sub
End Class