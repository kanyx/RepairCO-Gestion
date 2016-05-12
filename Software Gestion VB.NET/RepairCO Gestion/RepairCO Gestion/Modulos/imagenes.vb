Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Module imagenes
    Function IMAGE_SAVEOT(ByVal Imagenes As ArrayList, ByVal NumeroOrden As String) As Boolean
        Try
            If Imagenes.Count = 0 Or Imagenes.Count < 0 Then
                Return False
            End If
            For Each foto In Imagenes
                If (Not Directory.Exists(Application.StartupPath & "/Data/_temp/" & NumeroOrden)) Then
                    Directory.CreateDirectory(Application.StartupPath & "/Data/_temp/" & NumeroOrden)
                End If
                Dim infoFoto As FileInfo
                infoFoto = My.Computer.FileSystem.GetFileInfo(foto)
                If infoFoto.Name <> "ingresoot_add_foto.png" Then

                    ' # COMENZAMOS EL TRATAMIENTO DE LA IMAGEN.
                    Dim resized As Image = ResizeImage(Image.FromFile(foto), New Size(640, 480))
                    resized.Save(Application.StartupPath & "/Data/_temp/" & NumeroOrden & "/" & infoFoto.Name, ImageFormat.Jpeg)
                    ' # COPIAMOS LA IMAGEN AL SERVIDOR.
                    If IMG_COPYIMGOT(Application.StartupPath & "/Data/_temp/" & NumeroOrden & "/" & infoFoto.Name, NumeroOrden) = True Then
                        ' # AGREGAMOS LA IMAGEN A LA BASE DE DATOS. (ver si es necesario poner time out)
                        Call PGSQL_ADDIMGOT(NumeroOrden, infoFoto.Name)
                    Else
                        MessageBox.Show("ERROR FATAL AL COPIAR LA IMAGEN")
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al momento de procesar el proceso de optimización de imágenes, por favor contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                   "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                   MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Function IMG_COPYIMGOT(ByVal ArchivoImagen As String, ByVal NumeroOrden As String) As Boolean
        Try
            If File.Exists(ArchivoImagen) = True Then
                If Directory.Exists("\\192.168.0.10\Servidor\Desarrollo\" & NumeroOrden) = False Then
                    Directory.CreateDirectory("\\192.168.0.10\Servidor\Desarrollo\" & NumeroOrden)
                End If
                Dim infoFoto As FileInfo
                infoFoto = My.Computer.FileSystem.GetFileInfo(ArchivoImagen)
                File.Copy(ArchivoImagen, "\\192.168.0.10\Servidor\Desarrollo\" & NumeroOrden & "\" & infoFoto.Name, True)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    Private Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function
End Module
