Public Class mec_home
    Private MecAuthClose As Boolean = False
    Private Sub mec_home_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' # COMPROBAMOS QUE EL USUARIO PRESIONE CTRL + ALT + R PARA SETEAR LA CORRECTA FINALIZACION DE LA APLICACION.
        If e.Control And e.Alt And e.KeyCode = Keys.R Then
            If MessageBox.Show("¿Desea cerrar la estacion de trabajo.?", Application.ProductName & " - " & Application.ProductVersion, _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MecAuthClose = True
                Me.Close()
                main_loggin.Close()
            End If
        End If
    End Sub
    Private Sub mec_home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.MecAuthClose = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class