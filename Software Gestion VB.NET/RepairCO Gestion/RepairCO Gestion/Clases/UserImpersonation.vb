Imports Microsoft.VisualBasic
Imports System.Web
Imports System.Web.Security
Imports System.Security.Principal
Imports System.Runtime.InteropServices
Public Class UserImpersonation
    Const LOGON32_LOGON_INTERACTIVE = 2
    Const LOGON32_LOGON_NETWORK = 3
    Const LOGON32_LOGON_BATCH = 4
    Const LOGON32_LOGON_SERVICE = 5
    Const LOGON32_LOGON_UNLOCK = 7
    Const LOGON32_LOGON_NETWORK_CLEARTEXT = 8
    Const LOGON32_LOGON_NEW_CREDENTIALS = 9
    Const LOGON32_PROVIDER_DEFAULT = 0
    Const LOGON32_PROVIDER_WINNT35 = 1
    Const LOGON32_PROVIDER_WINNT40 = 2
    Const LOGON32_PROVIDER_WINNT50 = 3
    Dim impersonationContext As WindowsImpersonationContext
    Declare Function LogonUserA Lib "advapi32.dll" (ByVal lpszUsername As String, _
                            ByVal lpszDomain As String, _
                            ByVal lpszPassword As String, _
                            ByVal dwLogonType As Integer, _
                            ByVal dwLogonProvider As Integer, _
                           ByRef phToken As IntPtr) As Integer

    Declare Auto Function DuplicateToken Lib "advapi32.dll" ( _
                            ByVal ExistingTokenHandle As IntPtr, _
                            ByVal ImpersonationLevel As Integer, _
                            ByRef DuplicateTokenHandle As IntPtr) As Integer

    Declare Auto Function RevertToSelf Lib "advapi32.dll" () As Long
    Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal handle As IntPtr) As Long

    Public Function impersonateUser(ByVal userName As String, ByVal domain As String, ByVal password As String) As Boolean
        Return impersonateValidUser(userName, domain, password)
    End Function

    Public Sub undoimpersonateUser()
        undoImpersonation()
    End Sub

    Private Function impersonateValidUser(ByVal userName As String, ByVal domain As String, ByVal password As String) As Boolean

        Dim tempWindowsIdentity As WindowsIdentity
        Dim token As IntPtr = IntPtr.Zero
        Dim tokenDuplicate As IntPtr = IntPtr.Zero
        impersonateValidUser = False

        If RevertToSelf() Then
            If LogonUserA(userName, domain, password, LOGON32_LOGON_NEW_CREDENTIALS, LOGON32_PROVIDER_WINNT50, token) <> 0 Then
                If DuplicateToken(token, 2, tokenDuplicate) <> 0 Then
                    tempWindowsIdentity = New WindowsIdentity(tokenDuplicate)
                    impersonationContext = tempWindowsIdentity.Impersonate()
                    If Not impersonationContext Is Nothing Then
                        impersonateValidUser = True
                    End If
                End If
            End If
        End If
        If Not tokenDuplicate.Equals(IntPtr.Zero) Then
            CloseHandle(tokenDuplicate)
        End If
        If Not token.Equals(IntPtr.Zero) Then
            CloseHandle(token)
        End If
    End Function

    Private Sub undoImpersonation()
        Try
            impersonationContext.Undo()
        Catch ex As Exception

        End Try
    End Sub
End Class
