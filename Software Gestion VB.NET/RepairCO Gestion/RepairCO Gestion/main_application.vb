Imports System.Windows.Forms

Public Class main_application

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Private Sub mainapp_help_aboutme_Click(sender As Object, e As EventArgs) Handles mainapp_help_aboutme.Click
        aboutme.ShowDialog()
    End Sub

    Private Sub main_application_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Está a punto de cerrar la aplicación. ¿Está seguro que desea continuar?", _
                           Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub mainapp_help_aboutme_MouseMove(sender As Object, e As MouseEventArgs) Handles mainapp_help_aboutme.MouseMove
        mainapp_status_text.Text = "Información sobre la aplicación."
    End Sub
    Private Sub main_application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Form_MidiMenu As New main_menu_lateral
        Form_MidiMenu.MdiParent = Me
        ' # Redimencionamos el formulario.
        Form_MidiMenu.Height = Me.ClientSize.Height * 0.92
        'test.Width = Me.ClientSize.Width * 0.1     ' 10% of parent
        'test.Height = Me.ClientSize.Height * 0.99  '  25% of parent
        Form_MidiMenu.Show()
        ' # Cargamos los controles basicos de la aplicacion
        mainapp_status_text.Text = Application.ProductName & " - " & Application.ProductVersion
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/main_background.png")
        Me.BackgroundImageLayout = ImageLayout.Stretch
        ' # ESTABLECEMOS LOS VAORES DEL TIMMER QUE CONTROLA EL RELOJ DE LA PANTALLA PRINCIPAL DE LA APLICACION.
        Me.mainapp_tm_clock.Interval = 1000
        Me.mainapp_lbl_clock.Text = Date.Now
        Me.mainapp_tm_clock.Enabled = True
    End Sub
    Private Sub mainapp_help_aboutme_MouseLeave(sender As Object, e As EventArgs) Handles mainapp_help_aboutme.MouseLeave
        mainapp_status_text.Text = Application.ProductName & " - " & Application.ProductVersion
    End Sub
    Private Sub mainapp_tm_clock_Tick(sender As Object, e As EventArgs) Handles mainapp_tm_clock.Tick
        Me.mainapp_lbl_clock.Text = Date.Now
    End Sub
End Class
