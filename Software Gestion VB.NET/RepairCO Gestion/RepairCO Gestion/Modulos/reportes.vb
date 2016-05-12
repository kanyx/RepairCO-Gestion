Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf

Module reportes
    Public Function REPORTES_GENERAOT(ByVal NumeroOT As String)
        Try
            'Dim DatosOT As New ArrayList =
            Dim FileName As String = NumeroOT & ".pdf"
            Dim sr As StreamReader = New StreamReader(Application.StartupPath & "/Data/report/OT.html")
            Dim line As String
            line = sr.ReadToEnd
            sr.Close()
            ' # LLAMAMOS LOS VALORES DE LA OT DESDE LA BASE DE DATOS.
            ' # HACEMOS UN PHARSE A LAS VARIABLES GENERALES.
            line = line.Replace("@RUTALOGO", Application.StartupPath & "/Data/grafica/Logo.jpg").Replace("@ICO_REPARACION", Application.StartupPath & "/Data/grafica/ico/ot_uncheked.png") _
                .Replace("@ICO_GARANTIA", Application.StartupPath & "/Data/grafica/ico/ot_uncheked.png")
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
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
End Module
