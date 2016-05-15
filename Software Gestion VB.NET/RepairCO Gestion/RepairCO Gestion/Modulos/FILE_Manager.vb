Imports System.IO
Module FILE_Manager
    Public Sub CleanTempFiles()
        ' # CLASE ENCARGADA DE LIMPIAR LA CARPETA /Data/_temp
        Try
            If Directory.Exists(Application.StartupPath & "/Data/_temp") Then
                ' # ELIMINAMOS TODOS LOS ARCHIVOS.
                For Each Archivo In Directory.GetFiles(Application.StartupPath & "/Data/_temp")
                    My.Computer.FileSystem.DeleteFile(Archivo, FileIO.UIOption.OnlyErrorDialogs, _
                                                      FileIO.RecycleOption.DeletePermanently)
                Next
                ' # ELIMINAMOS TODOS LOS DIRECTORIOS.
                For Each Carpeta In Directory.GetDirectories(Application.StartupPath & "/Data/_temp")
                    My.Computer.FileSystem.DeleteDirectory(Carpeta, FileIO.DeleteDirectoryOption.DeleteAllContents)
                Next
            Else
                ' # EN CASO QUE NO EXISTA EL DIRECTORIO TEMPORAL.
                Exit Sub
            End If
        Catch exe As Exception
            ' # EN CASO DE OCURRIR UN ERROR AL MOMENTO DE ELIMINAR LOS ARCHIVOS TEMPORALES DE LA APLICACION.
            MessageBox.Show("Ocurrió un error al momento de eliminar los archivos temporales de la aplicación, por favor vuelva a iniciar la aplicación si el problema persiste contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
End Module
