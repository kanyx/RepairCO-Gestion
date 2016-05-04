Imports System.IO
Imports System.Xml
Public Class RepairCoXml
    Private ArchivoXML As String = ""
    Private RetornoArray As ArrayList
    Private InfoArchivo As FileInfo
    Private VersionApp As String = "1.0.0.1"
    Private RetornoString As String
    Private ConfigHostDB As String = ""
    Private ConfigPortDB As String = ""
    Private ConfigUserDB As String = ""
    Private ConfigPassDB As String = ""
    Private ConfigNameDB As String = ""
    Public Sub New(ByVal Archivo As String)
        ArchivoXML = Archivo
    End Sub
    ' # Rutina para leer documento XML.
    Public Function LeerDocumentoConfiguration(ByVal DevolverArray As Boolean)
        Try
            If ExistenciaArchivo() = True Then
                Dim LectorXML = New XmlTextReader(ArchivoXML)
                LectorXML.WhitespaceHandling = WhitespaceHandling.None
                LectorXML.Read()
                LectorXML.Read()
                LectorXML.Read()
                While Not LectorXML.EOF
                    LectorXML.Read()
                    If Not LectorXML.IsStartElement() Then
                        Exit While
                    End If
                    ConfigHostDB = LectorXML.ReadElementString("server")
                    ConfigPortDB = LectorXML.ReadElementString("port")
                    ConfigUserDB = LectorXML.ReadElementString("username")
                    ConfigPassDB = LectorXML.ReadElementString("password")
                    ConfigNameDB = LectorXML.ReadElementString("nombre")
                End While
                If DevolverArray = True Then
                    RetornoArray = New ArrayList
                    RetornoArray.Add(ConfigHostDB)
                    RetornoArray.Add(ConfigPortDB)
                    RetornoArray.Add(ConfigUserDB)
                    RetornoArray.Add(ConfigPassDB)
                    RetornoArray.Add(ConfigNameDB)
                    Return RetornoArray
                Else
                    RetornoString = ConfigHostDB & "#" & ConfigPortDB & "#" & ConfigUserDB & "#" & ConfigPassDB & _
                        "#" & ConfigNameDB
                    Return RetornoString
                End If
            Else
                MsgBox("Error: No existe el archivo XML [" & ArchivoXML & "]" & vbNewLine & _
                       "Este error se produjo en la libreria RepairCo XML.")
                If DevolverArray = True Then
                    RetornoArray = New ArrayList
                    RetornoArray.Add("ERROR: No existe el archivo XML especificado.")
                    Return RetornoArray
                Else
                    Return "ERROR: No existe el archivo XML especificado."
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al momento de leer el documento xml, el detalle del error se detalla a continuacion: " & _
                   vbNewLine & ex.ToString & vbNewLine & "El error se produjo en la libreria RepairCo XML Reader (DLL)", MsgBoxStyle.Critical)
            If DevolverArray = True Then
                RetornoArray = New ArrayList
                RetornoArray.Add("ERROR")
            Else
                Return "ERROR"
            End If
        End Try
    End Function
    ' # Rutina que entrega la version de la libreria para uso de comparacion.
    Public Function Version()
        Return VersionApp
    End Function
    ' # Funciones internas para la lectura/escritura del documento XML.
    Private Function ExistenciaArchivo() As Boolean
        If File.Exists(ArchivoXML) Then
            InfoArchivo = My.Computer.FileSystem.GetFileInfo(ArchivoXML)
            If InfoArchivo.IsReadOnly = False Then
                Return True
            Else
                MsgBox("Error!: El archivo " & ArchivoXML & " esta en modo solo lectura, por lo cual no se puede ejecutar una lectura o escritura.")
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Class
