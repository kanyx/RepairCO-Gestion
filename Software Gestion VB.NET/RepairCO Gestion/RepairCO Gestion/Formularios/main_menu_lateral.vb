Public Class main_menu_lateral
    Private Sub main_menu_lateral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # Carga elementos visuales, texto y de la aplicacion.
        main_menu_logo.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/logo_menu.png")
        mainmenu_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/menu_lateral_texto.png")
        mainmenu_iconlist.Images.Add(0, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/planificacion.png"))
        mainmenu_iconlist.Images.Add(1, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/recepcion.png"))
        mainmenu_iconlist.Images.Add(2, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/buscar.png"))
        mainmenu_iconlist.Images.Add(3, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/ingreso.png"))
    End Sub
    Private Sub mainmenu_container_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles mainmenu_container.AfterSelect
        If e.Node.Name = "menu_planificacion" Then
            ' # Cuando seleccionan planificacion
        ElseIf e.Node.Name = "menu_recepcion" Then
            ' # Seleccion de recepcion
        ElseIf e.Node.Name = "menu_recepcioneslista" Then
            ' # Seleccion Ingresar
        End If
    End Sub
End Class