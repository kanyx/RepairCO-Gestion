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
        ElseIf e.Node.Name = "menu_recepcioningresar" Then
            ' # Formulario de ingreso de formulario.
            If CheckForm(form_ingreso) = True Then
                Exit Sub
            End If
            Dim Frm_RecepcionIngreso As New form_ingreso
            Frm_RecepcionIngreso.MdiParent = main_application
            Frm_RecepcionIngreso.ShowInTaskbar = False
            Frm_RecepcionIngreso.StartPosition = FormStartPosition.Manual
            Frm_RecepcionIngreso.Left += 260
            Frm_RecepcionIngreso.Height = main_application.ClientSize.Height * 0.929
            Frm_RecepcionIngreso.Width = main_application.ClientSize.Width * 0.8
            Frm_RecepcionIngreso.Show()
        End If
    End Sub
    ' # Funcion que comprueba si un formulario ya se encuentra abierto.
    Private Function CheckForm(_form As Form) As Boolean
        For Each f As Form In Application.OpenForms
            If f.Name = _form.Name Then
                Return True
            End If
        Next
        Return False
    End Function
End Class