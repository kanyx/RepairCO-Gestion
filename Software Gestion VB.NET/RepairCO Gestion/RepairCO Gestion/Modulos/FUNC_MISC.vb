Imports System.IO
Module FUNC_MISC
    Public Function validarRut(ByVal rut As String) As Boolean
        Dim validacion As Boolean = False
        Try
            rut = rut.ToUpper()
            rut = rut.Replace(".", "")
            rut = rut.Replace("-", "")
            Dim rutAux As Integer
            rutAux = Integer.Parse(rut.Substring(0, rut.Length - 1))
            Dim dv As Integer = Asc(rut.Substring(rut.Length - 1, 1))
            Dim s As Integer = 1
            Dim m As Integer = 0
            While rutAux <> 0
                If (rutAux = 0) Then
                    Dim valor As Integer = (s + ((rutAux Mod 10) * (9 - (m Mod 6))))
                    s = valor Mod 11
                    m += 1
                End If
                rutAux /= 10
            End While
            Dim dvAux As Integer = IIf(s <> 0, s + 47, 75)
            If (dv = dvAux) Then
                validacion = True
            End If
        Catch es As Exception
        End Try
        Return validacion
    End Function
    Public Function MISC_CALCULA_MEDIA(ByVal g45 As Single, ByVal g90 As Single, ByVal g135 As Single, ByVal g180 As Single) As Single
        Try
            Dim SumaVolares As Single = g45 + g90 + g135 + g180
            Dim Media As Single = SumaVolares / 4
            Return Media
        Catch exe As Exception
            MessageBox.Show("Ocurrio un error al calcular la media de las medidas." & vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & _
                            vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0.0
        End Try
    End Function
    Public Function MISC_CALCULA_MEDIA_GENERAL(ByVal Valores As List(Of Single)) As Single
        Try
            Dim SumaValores As Single = 0
            For Each valor In Valores
                SumaValores = Single.Parse(SumaValores) + Single.Parse(valor)
            Next
            Return Single.Parse(SumaValores) / Valores.Count
        Catch ex As Exception
            Return 0.0
        End Try
    End Function
    Public Function MISC_READFOLDER_DOCUMENTOS(ByVal OT As String, ByVal Path As String, Optional ByVal ExtencionFilter As String = "*") _
        As Dictionary(Of String, String)
        Dim varReturn As New Dictionary(Of String, String) ' # Variable de retorno de la funcion.
        Dim impersonateUser As New UserImpersonation
        Try
            impersonateUser.impersonateUser(_globalSAMBAU, "", _globalSAMBAP)
            ' # REVISAMOS LA CARPETA DONDE SE DEBERAN BUSCAR LOS ARCHIVOS, ES IMPORTANTE ACOTAR QUE NO SE LEERAN LOS DOCUMENTOS
            ' # QUE NO TERMINEN EN LA EXTENCION ESPECIFICADA. NI EL ARCHIVO DE SALIDA DE LA ORDEN DE TRABAJO.
            If Directory.Exists(Path) = False Then
                varReturn.Add("0", "")
                Return varReturn
            End If
            Dim i = 1 ' # Key del numero de archivo que se esta agregando.
            For Each Archivo As String In My.Computer.FileSystem.GetFiles(Path, FileIO.SearchOption.SearchAllSubDirectories, "*." & ExtencionFilter)
                Dim infoFile As FileInfo = New FileInfo(Archivo)
                If InStr(infoFile.Name, OT) < 1 Then
                    varReturn.Add(i.ToString, Archivo)
                    i = i + 1
                End If
            Next
            Return varReturn
            impersonateUser.undoimpersonateUser()
        Catch ex As Exception
            MsgBox(ex.ToString)
            varReturn.Add("0", "ERROR.")
            Return varReturn
        End Try
    End Function
    Public Function MISC_FILECOPY(ByVal Source As String, ByVal Destiny As String, ByVal OT As String) As Boolean
        ' # FUNCION PARA COPIAR CUALQUIER TIPO DE ARCHIVO.
        ' # Def. Variables: Source str(Archivo original), Destiny str(ruta mas nombre de archivo donde dejaremos).
        Try
            Dim impersonateUser As New UserImpersonation
            impersonateUser.impersonateUser(_globalSAMBAU, "", _globalSAMBAP)
            If Directory.Exists(main_loggin.ParametrosConfiguracion(5).ToString & OT) = False Then
                System.IO.Directory.CreateDirectory(main_loggin.ParametrosConfiguracion(5).ToString & OT)
            End If
            File.Copy(Source, Destiny, True)
            impersonateUser.undoimpersonateUser()
            Return True
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al intentar copiar el archivo (" & Source & ") hasta ( " & Destiny & ")." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Sub MISC_EXECUTEFILE(ByVal Archivo As String)
        Try
            Dim elavateExecute As New UserImpersonation
            elavateExecute.impersonateUser(_globalSAMBAU, "", _globalSAMBAP)
            If File.Exists(Archivo) = True Then
                Process.Start(Archivo)
            Else
                MessageBox.Show("No existe el archivo seleccionado en la carpeta de la OT.", Application.ProductName & " - " & Application.ProductVersion, _
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            elavateExecute.undoimpersonateUser()
        Catch ex As Exception
        End Try
    End Sub
End Module
