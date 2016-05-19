Module FUNC_Keyboard
    ' ############################################################################################################# '
    ' #                       TECLADO PARA APLICACION EN PANTALLA TACTIL                                          # '
    ' ############################################################################################################# '
    ' # VERSION: 1.0.0 - trunk DEVELOPER: SEBASTIAN J. GUAJARDO A.                                                # '
    ' # BUG TRACK GITHUB: http://github.com/kanyx/RepairCO-Gestion/                                               # '
    ' ############################################################################################################# '
    ' KKKKKKKKK    KKKKKKK                  NNNNNNNN        NNNNNNNN                         XXXXXXX       XXXXXXX
    ' K:::::::K    K:::::K                  N:::::::N       N::::::N                         X:::::X       X:::::X
    ' K:::::::K    K:::::K                  N::::::::N      N::::::N                         X:::::X       X:::::X
    ' K:::::::K   K::::::K                  N:::::::::N     N::::::N                         X::::::X     X::::::X
    ' KK::::::K  K:::::KKK  aaaaaaaaaaaaa   N::::::::::N    N::::::Nyyyyyyy           yyyyyyyXXX:::::X   X:::::XXX
    ' K:::::K K:::::K     a::::::::::::a  N:::::::::::N   N::::::N y:::::y         y:::::y    X:::::X X:::::X   
    ' K::::::K:::::K      aaaaaaaaa:::::a N:::::::N::::N  N::::::N  y:::::y       y:::::y      X:::::X:::::X    
    ' K:::::::::::K                a::::a N::::::N N::::N N::::::N   y:::::y     y:::::y        X:::::::::X     
    ' K:::::::::::K         aaaaaaa:::::a N::::::N  N::::N:::::::N    y:::::y   y:::::y         X:::::::::X     
    ' K::::::K:::::K      aa::::::::::::a N::::::N   N:::::::::::N     y:::::y y:::::y         X:::::X:::::X    
    ' K:::::K K:::::K    a::::aaaa::::::a N::::::N    N::::::::::N      y:::::y:::::y         X:::::X X:::::X   
    ' KK::::::K  K:::::KKKa::::a    a:::::a N::::::N     N:::::::::N       y:::::::::y       XXX:::::X   X:::::XXX
    ' K:::::::K   K::::::Ka::::a    a:::::a N::::::N      N::::::::N        y:::::::y        X::::::X     X::::::X
    ' K:::::::K    K:::::Ka:::::aaaa::::::a N::::::N       N:::::::N         y:::::y         X:::::X       X:::::X
    ' K:::::::K    K:::::K a::::::::::aa:::aN::::::N        N::::::N        y:::::y          X:::::X       X:::::X
    ' KKKKKKKKK    KKKKKKK  aaaaaaaaaa  aaaaNNNNNNNN         NNNNNNN       y:::::y           XXXXXXX       XXXXXXX
    '                                                                     y:::::y                                 
    '                                                                    y:::::y                                  
    '                                                                   y:::::y                                   
    '                                                                  y:::::y                                    
    '                                                                 yyyyyyy            
    ' ##############################################################################################################
    Public Sub KEYBOARDRC_SHOW(ByVal Control As TextBox, ByVal Numerico As Boolean, ByVal MainContenedor As Panel, ByVal AjustarPantalla As Boolean, _
                               ByVal MaxChars As Integer, Optional ByVal Fixed As Boolean = False)
        Call KEYBOARD_ISOPEN(mec_keyboard)
        Dim keyboardRC As New mec_keyboard
        keyboardRC.Top = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - keyboardRC.Height
        keyboardRC.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (keyboardRC.Width \ 2)
        keyboardRC.Opacity = 0.8
        If MaxChars <> 0 Then
            keyboardRC.key_sender.MaxLength = MaxChars
        End If
        keyboardRC.CursorPosition = Control.SelectionStart
        keyboardRC.key_sender.Text = Control.Text
        If Numerico = True Then
            ' # SI SE REQUIERE EL TECLADO NUMERICO.
            keyboardRC.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/keyboard/background_numerico.png")
            keyboardRC.keyboard_pn_numerico.BackColor = Color.Transparent
            keyboardRC.keyboard_pn_numerico.Enabled = True
            keyboardRC.keyboard_pn_numerico.Visible = True
        Else
            ' # SI SE REQUIERE UN TECLADO ALFANUMERICO.
        End If
        ' # MOSTRAMOS EL TECLADO EN PANTALLA
        keyboardRC.ShowInTaskbar = False
        keyboardRC.ShowIcon = False
        keyboardRC.Control = Control
        If Fixed = True Then
            keyboardRC.ShowDialog()
            Exit Sub
        End If
        keyboardRC.Show()
        Exit Sub
    End Sub
    Private Sub KEYBOARD_ISOPEN(ByVal KeyBoard As Form)
        For Each f As Form In Application.OpenForms
            If f.Name = KeyBoard.Name Then
                f.Close()
                Exit Sub
            End If
        Next
    End Sub
End Module
