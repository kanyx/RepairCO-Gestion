﻿Module FUNC_MISC
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
    Public Function MISC_CALCULA_MEDIA(ByVal g45 As Integer, ByVal g90 As Integer, ByVal g135 As Integer, ByVal g180 As Integer) As Long
        Try
            Dim SumaVolares As Integer = g45 + g90 + g135 + g180
            Dim Media As Long = SumaVolares / 4
            Return Media
        Catch exe As Exception
            MessageBox.Show("Ocurrio un error al calcular la media de las medidas." & vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & _
                            vbNewLine & vbNewLine & exe.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0.0
        End Try
    End Function
    Public Function MISC_CALCULA_MEDIA_GENERAL(ByVal A As Integer, ByVal B As Integer, ByVal C As Integer) As Long
        Try
            Dim SumaValores As Integer = A + B + C
            Return SumaValores / 4
        Catch ex As Exception
            Return 0.0
        End Try
    End Function
End Module
