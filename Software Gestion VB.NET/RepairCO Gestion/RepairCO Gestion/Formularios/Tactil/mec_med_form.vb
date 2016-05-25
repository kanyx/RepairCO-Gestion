Public Class mec_med_form
    Public MedOT As String = "" ' # NUMERO DE ORDEN DE TRABAJO.
    Public MedTipoProducto As String ' # TIPO DE PRODUCTO AL CUAL SE LE REALIZA LA MEDICION.
    Public MedComponente As String = "" ' # ID DE COMPONENTE.
    Public MedZona As String = "" ' # ZONA DEL COMPONENTE A LA CUAL SE REALIZA LA MEDICION.
    Public PanelCarga As Panel ' # PANEL DE DONDE SE ESTA LLAMANDO EL FORMULARIO DE MEDICION.
    Public ControlReturn As TextBox ' # TEXTBOX DONDE SE DEVOLVERA EL VALOR DE LA MEDIA.
    Public ZoneControl As PictureBox ' # PICTUREBOX QUE CAMBIA EL ESTADO DEL VECTOR.
    Public ZoneControlPanel As Panel ' # EN CASO QUE ESTE REALIZADO EL VECTOR CON PANEL.
    Public ZoneImage As Image ' # IMAGEN ESTADO NORMAL EN EL VECTOR.
    Public ZoneImageSucces As Image ' # IMAGEN ESTADO FINALIZADO CORRECTAMENTE.
    Public ZoneImageError As Image ' # IMAGEN DE ERROR EN CAMBIO DEL VECTOR.
    Private DatosAnteriores As New Dictionary(Of String, String) ' # ARREGLO QUE CONTIENE LOS DATOS DE LA LECTURA ANTERIOR.
    Private Sub mec_med_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGAMOS ELEMENTOS GRAFICOS DEL FORMULARIO.
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/fondo_panel_medicion.png")
        Me.med_pic_save.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_hover.png")
        ' # CARGAMOS PARAMETROS DE LA APLICACION.
        Me.med_lbl_45.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.med_lbl_90.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.med_lbl_135.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.med_lbl_180.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.med_lbl_posa.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.med_lbl_posb.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.med_lbl_posc.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.med_lbl_45.BackColor = Color.Transparent
        Me.med_lbl_90.BackColor = Color.Transparent
        Me.med_lbl_135.BackColor = Color.Transparent
        Me.med_lbl_180.BackColor = Color.Transparent
        Me.med_lbl_posa.BackColor = Color.Transparent
        Me.med_lbl_posb.BackColor = Color.Transparent
        Me.med_lbl_posc.BackColor = Color.Transparent
        ' # CARGAMOS LOS DATOS EN CASO QUE YA SE HAYA REALIZADO LAS MEDICIONES CORRESPONDIENTES. (var. DATOSANTERIORES)
        DatosAnteriores = PGSQL_TACTIL_MEDLOAD(MedOT, MedComponente, MedZona)
        If DatosAnteriores.ContainsValue("ERROR") = False Then
            For Each Medicion In DatosAnteriores
                If Medicion.Key = "1" Then
                    Dim ValoresMED As String() = Medicion.Value.Split("#")
                    Me.med_txt_a45.Text = Format(Single.Parse(ValoresMED(0)), "##,##0.0")
                    Me.med_txt_a90.Text = Format(Single.Parse(ValoresMED(1)), "##,##0.0")
                    Me.med_txt_a135.Text = Format(Single.Parse(ValoresMED(2)), "##,##0.0")
                    Me.med_txt_a180.Text = Format(Single.Parse(ValoresMED(3)), "##,##0.0")
                ElseIf Medicion.Key = "2" Then
                    Dim ValoresMED As String() = Medicion.Value.Split("#")
                    Me.med_txt_b45.Text = Format(Single.Parse(ValoresMED(0)), "##,##0.0")
                    Me.med_txt_b90.Text = Format(Single.Parse(ValoresMED(1)), "##,##0.0")
                    Me.med_txt_b135.Text = Format(Single.Parse(ValoresMED(2)), "##,##0.0")
                    Me.med_txt_b180.Text = Format(Single.Parse(ValoresMED(3)), "##,##0.0")
                ElseIf Medicion.Key = "3" Then
                    Dim ValoresMED As String() = Medicion.Value.Split("#")
                    Me.med_txt_c45.Text = Format(Single.Parse(ValoresMED(0)), "##,##0.0")
                    Me.med_txt_c90.Text = Format(Single.Parse(ValoresMED(1)), "##,##0.0")
                    Me.med_txt_c135.Text = Format(Single.Parse(ValoresMED(2)), "##,##0.0")
                    Me.med_txt_c180.Text = Format(Single.Parse(ValoresMED(3)), "##,##0.0")
                End If
            Next
        End If
    End Sub
    Private Sub med_pic_save_Click(sender As Object, e As EventArgs) Handles med_pic_save.Click
        ' # BOTON PARA SALIR Y GUARDAR LOS COMPONENTES.
        ' # FUNCION DEBE DETECTAR, CUANTAS POSICIONES TIENE RELLENAS EL FORMULARIO
        ' # DEBE INSERTAR CADA POSICION POR SEPARADO (FOR OR WHILE)
        ' # DEBE CALCULAR EL PROMEDIO.
        Dim MediaPosA As Single = 0
        Dim MediaPosB As Single = 0
        Dim MediaPosC As Single = 0
        Dim MediaGeneral As Single = 0
        If Me.med_txt_a45.Text <> "" Then
            MediaPosA = MISC_CALCULA_MEDIA(Single.Parse(Me.med_txt_a45.Text), Single.Parse(Me.med_txt_a90.Text), Single.Parse(Me.med_txt_a135.Text), Single.Parse(Me.med_txt_a180.Text))
            If PGSQL_TACTIL_MEDSAVE(MedOT, MedComponente, MedZona, 1, Me.med_txt_a45.Text, Me.med_txt_a90.Text, Me.med_txt_a135.Text, Me.med_txt_a180.Text, MediaPosA) = False Then
                ZoneControl.Image = ZoneImage
                Exit Sub
            End If
        Else
            If IsNothing(ZoneControl) = False Then
                ZoneControl.Image = ZoneImage
            Else
                If IsNothing(ZoneControlPanel) = False Then
                    ZoneControlPanel.BackgroundImage = ZoneImage
                End If
            End If
        End If
        If Me.med_txt_b45.Text <> "" Then
            MediaPosB = MISC_CALCULA_MEDIA(Single.Parse(Me.med_txt_b45.Text), Single.Parse(Me.med_txt_b90.Text), Single.Parse(Me.med_txt_b135.Text), Single.Parse(Me.med_txt_b180.Text))
            If PGSQL_TACTIL_MEDSAVE(MedOT, MedComponente, MedZona, 2, Me.med_txt_b45.Text, Me.med_txt_b90.Text, Me.med_txt_b135.Text, Me.med_txt_b180.Text, MediaPosB) = False Then
                Exit Sub
            End If
        End If
        If Me.med_txt_c45.Text <> "" Then
            MediaPosC = MISC_CALCULA_MEDIA(Single.Parse(Me.med_txt_c45.Text), Single.Parse(Me.med_txt_c90.Text), Single.Parse(Me.med_txt_c135.Text), Single.Parse(Me.med_txt_c180.Text))
            If PGSQL_TACTIL_MEDSAVE(MedOT, MedComponente, MedZona, 3, Me.med_txt_c45.Text, Me.med_txt_c90.Text, Me.med_txt_c135.Text, Me.med_txt_c180.Text, MediaPosC) = False Then
                Exit Sub
            End If
        End If
        If MediaPosA <> 0 Then
            Dim Valores As New List(Of Single)
            If MediaPosA <> 0 Then
                Valores.Add(MediaPosA)
            End If
            If MediaPosB <> 0 Then
                Valores.Add(MediaPosB)
            End If
            If MediaPosC <> 0 Then
                Valores.Add(MediaPosC)
            End If
            MediaGeneral = MISC_CALCULA_MEDIA_GENERAL(Valores)
            ControlReturn.Text = Format(Single.Parse(MediaGeneral), "##,##0.0")
            If IsNothing(ZoneControl) = False Then
                ZoneControl.Image = ZoneImageSucces
            Else
                If IsNothing(ZoneControlPanel) = False Then
                    ZoneControlPanel.BackgroundImage = ZoneImageSucces
                End If
            End If
        End If
        PanelCarga.Visible = False
        Me.Close()
    End Sub
    Private Sub med_txt_a45_Click(sender As Object, e As EventArgs) Handles med_txt_a45.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_a45, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_a90_Click(sender As Object, e As EventArgs) Handles med_txt_a90.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_a90, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_a135_Click(sender As Object, e As EventArgs) Handles med_txt_a135.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_a135, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_a180_Click(sender As Object, e As EventArgs) Handles med_txt_a180.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_a180, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_b45_Click(sender As Object, e As EventArgs) Handles med_txt_b45.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_b45, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_b90_Click(sender As Object, e As EventArgs) Handles med_txt_b90.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_b90, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_b135_Click(sender As Object, e As EventArgs) Handles med_txt_b135.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_b135, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_b180_Click(sender As Object, e As EventArgs) Handles med_txt_b180.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_b180, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_c45_Click(sender As Object, e As EventArgs) Handles med_txt_c45.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_c45, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_c90_click(sender As Object, e As EventArgs) Handles med_txt_c90.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_c90, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_c135_Click(sender As Object, e As EventArgs) Handles med_txt_c135.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_c135, True, PanelCarga, False, 4)
    End Sub
    Private Sub med_txt_c180_Click(sender As Object, e As EventArgs) Handles med_txt_c180.Click
        Call KEYBOARDRC_SHOW(Me.med_txt_c180, True, PanelCarga, False, 4)
    End Sub
End Class