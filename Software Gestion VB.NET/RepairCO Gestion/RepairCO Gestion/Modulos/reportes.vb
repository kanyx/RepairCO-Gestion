Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf

Module reportes
    Public Function REPORTES_GENERAOT(ByVal NumeroOT As String) As Boolean
        Try
            'Dim DatosOT As New ArrayList =
            Dim FileName As String = NumeroOT & ".pdf"
            Dim sr As StreamReader = New StreamReader(Application.StartupPath & "/Data/report/OT.html")
            Dim line As String
            line = sr.ReadToEnd
            sr.Close()
            ' # LLAMAMOS LOS VALORES DE LA OT DESDE LA BASE DE DATOS.
            Dim DatosOrdenesTrabajo As New ArrayList
            DatosOrdenesTrabajo = PGSQL_REPORTE_OT(NumeroOT)
            Dim IcoGarantia As String = Application.StartupPath & "/Data/grafica/ico/ot_uncheked.png"
            Dim IcoReparacion As String = Application.StartupPath & "/Data/grafica/ico/ot_uncheked.png"
            If DatosOrdenesTrabajo(14) = "1" Then
                IcoReparacion = Application.StartupPath & "/Data/grafica/ico/ot_cheked.png"
            ElseIf DatosOrdenesTrabajo(14) = "2" Then
                IcoGarantia = Application.StartupPath & "/Data/grafica/ico/ot_cheked.png"
            End If
            ' # CARGAMOS EL ARREGLO QUECONTIENE LAS IMAGENES DE LA ORDEN DE TRABAJO
            Dim ImagenesArrayReporte As New ArrayList()
            ImagenesArrayReporte = PGSQL_CargaImagenesOT(NumeroOT, 4)
            Dim Foto1 As String = ""
            Dim Foto2 As String = ""
            Dim Foto3 As String = ""
            Dim Foto4 As String = ""
            If ImagenesArrayReporte.Count > 0 Then
                Foto1 = main_loggin.ParametrosConfiguracion(5).ToString & NumeroOT & "\" & ImagenesArrayReporte(0)
            End If
            If ImagenesArrayReporte.Count > 1 Then
                Foto2 = main_loggin.ParametrosConfiguracion(5).ToString & NumeroOT & "\" & ImagenesArrayReporte(1)
            End If
            If ImagenesArrayReporte.Count > 2 Then
                Foto3 = main_loggin.ParametrosConfiguracion(5).ToString & NumeroOT & "\" & ImagenesArrayReporte(2)
            End If
            If ImagenesArrayReporte.Count > 3 Then
                Foto4 = main_loggin.ParametrosConfiguracion(5).ToString & NumeroOT & "\" & ImagenesArrayReporte(3)
            End If
            ' # CARGAMOS COMENTARIOS DESDE LA BASE DE DATOS.
            Dim Comentario As String = PGSQL_CargaComentariosOT(NumeroOT)
            ' # HACEMOS UN PHARSE A LAS VARIABLES GENERALES.
            line = line.Replace("@RUTALOGO", Application.StartupPath & "/Data/grafica/Logo.jpg").Replace("@ICO_REPARACION", IcoReparacion) _
                .Replace("@ICO_GARANTIA", IcoGarantia).Replace("@NUMEROORDEN", DatosOrdenesTrabajo(1)).Replace("@RSERVICIO", DatosOrdenesTrabajo(17).ToString.ToUpper) _
                .Replace("@FECHA", DatosOrdenesTrabajo(11)).Replace("@NAGENDA", DatosOrdenesTrabajo(16)).Replace("@CLIENTE", DatosOrdenesTrabajo(3).ToString.ToUpper) _
                .Replace("@GDNUMBER", DatosOrdenesTrabajo(2).ToString.ToUpper).Replace("@DIRECCION", DatosOrdenesTrabajo(18).ToString.ToUpper) _
                .Replace("@NOC", DatosOrdenesTrabajo(15).ToString.ToUpper).Replace("@TIPO", DatosOrdenesTrabajo(5).ToString.ToUpper).Replace("@MARCA", DatosOrdenesTrabajo(6).ToString.ToUpper) _
                .Replace("@MODELO", DatosOrdenesTrabajo(7).ToString.ToUpper).Replace("@NSERIE", DatosOrdenesTrabajo(8).ToString.ToUpper).Replace("@TAG", DatosOrdenesTrabajo(19).ToString.ToUpper) _
                .Replace("@NONE", " ").Replace("@FOTO1", Foto1).Replace("@FOTO2", Foto2).Replace("@FOTO3", Foto3).Replace("@FOTO4", Foto4).Replace("@COMENTARIO", Comentario.ToUpper) _
                .Replace("@ING.REPARABLE", DatosOrdenesTrabajo(20).ToString.ToUpper)
            ' # CRAMOS Y CONVERTIMOS EL ARCHIVO A PDF
            Dim doc As New Document(PageSize.LETTER, 80, 50, 30, 65)
            Dim fsNew As New StringReader(line)
            Dim document As New Document(PageSize.A4, 80, 50, 30, 65)
            Using fs As New FileStream(Application.StartupPath & "/Data/_temp/" & FileName, FileMode.Create)
                PdfWriter.GetInstance(document, fs)
                Using stringReader As New StringReader(line)
                    Dim parsedList As System.Collections.Generic.List(Of IElement) = html.simpleparser.HTMLWorker.ParseToList(stringReader, Nothing)
                    document.Open()
                    ' # PARSEAR CADA LINEA DE CODIGO HTML Y LO INGRESAMOS AL DOMCUMENTO
                    For Each item As Object In parsedList
                        document.Add(DirectCast(item, IElement))
                    Next
                    document.Close()
                End Using
            End Using
            ' # COPIAMOS EL REPORTE DESDE LA CARPETA TEMPORAL HASTA EL SERVIDOR DE DATOS.
            If File.Exists(Application.StartupPath & "/Data/_temp/" & FileName) = True Then
                If Directory.Exists(main_loggin.ParametrosConfiguracion(5).ToString & NumeroOT) = False Then
                    Directory.CreateDirectory(main_loggin.ParametrosConfiguracion(5).ToString & NumeroOT)
                End If
                Dim infoFoto As FileInfo
                infoFoto = My.Computer.FileSystem.GetFileInfo(Application.StartupPath & "/Data/_temp/" & FileName)
                File.Copy(Application.StartupPath & "/Data/_temp/" & FileName, main_loggin.ParametrosConfiguracion(5).ToString & NumeroOT & "\" & infoFoto.Name, True)
                Return True
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
End Module
