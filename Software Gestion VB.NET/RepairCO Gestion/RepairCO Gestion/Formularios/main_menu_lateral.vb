Public Class main_menu_lateral
    Private Sub main_menu_lateral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # Carga elementos visuales, texto y de la aplicacion.
        main_menu_logo.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/logo_menu.png")
        mainmenu_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/menu_lateral_texto.png")
        mainmenu_iconlist.Images.Add(0, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/planificacion.png"))
        mainmenu_iconlist.Images.Add(1, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/recepcion.png"))
        mainmenu_iconlist.Images.Add(2, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/buscar.png"))
        mainmenu_iconlist.Images.Add(3, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/ingreso.png"))
        mainmenu_iconlist.Images.Add(4, Image.FromFile(Application.StartupPath & "/Data/grafica/ico/atareas.png"))
    End Sub
    Private Sub mainmenu_container_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles mainmenu_container.AfterSelect
        If e.Node.Name = "menu_planificacion" Then
            ' # Cuando seleccionan planificacion
        ElseIf e.Node.Name = "menu_recepcion" Then
            ' # Seleccion de recepcion
        ElseIf e.Node.Name = "menu_recepcioneslista" Then
            ' # Seleccion Buscar
            CloseForms(gestion_ot)
            If CheckForm(gestion_ot) = True Then
                Exit Sub
            End If
            Dim Frm_GestionOT As New gestion_ot
            Frm_GestionOT.MdiParent = main_application
            Frm_GestionOT.ShowInTaskbar = False
            Frm_GestionOT.StartPosition = FormStartPosition.Manual
            Frm_GestionOT.Left += 260
            Frm_GestionOT.Height = main_application.ClientSize.Height * 0.929
            Frm_GestionOT.Width = main_application.ClientSize.Width * 0.8
            Frm_GestionOT.Show()
        ElseIf e.Node.Name = "menu_recepcioningresar" Then
            ' # Formulario de ingreso de formulario.
            CloseForms(form_ingreso)
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
        ElseIf e.Node.Name = "menu_planificacion_asignaciontareas" Then
            CloseForms(planificacion_atareas)
            If CheckForm(planificacion_atareas) = True Then
                Exit Sub
            End If
            Dim Frm_PlanificacionAtareas As New planificacion_atareas
            Frm_PlanificacionAtareas.MdiParent = main_application
            Frm_PlanificacionAtareas.ShowInTaskbar = False
            Frm_PlanificacionAtareas.StartPosition = FormStartPosition.Manual
            Frm_PlanificacionAtareas.Left += 260
            Frm_PlanificacionAtareas.Height = main_application.ClientSize.Height * 0.929
            Frm_PlanificacionAtareas.Width = main_application.ClientSize.Width * 0.8
            Frm_PlanificacionAtareas.Show()
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
    Sub CloseForms(ByVal OpeningForm As Form)
        For Each f As Form In main_application.MdiChildren
            If f.Name <> OpeningForm.Name Then
                If f.Name <> "main_menu_lateral" Then
                    f.Close()
                End If
            End If
        Next
    End Sub
End Class