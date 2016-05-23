Public Class mec_med_form
    Public MedOT As String = "" ' # NUMERO DE ORDEN DE TRABAJO.
    Public MedTipoProducto As String ' # TIPO DE PRODUCTO AL CUAL SE LE REALIZA LA MEDICION.
    Public MedComponente As String = "" ' # ID DE COMPONENTE.
    Public MedZona As String = "" ' # ZONA DEL COMPONENTE A LA CUAL SE REALIZA LA MEDICION.
    Public PanelCarga As Panel ' # PANEL DE DONDE SE ESTA LLAMANDO EL FORMULARIO DE MEDICION.
    Public ControlReturn As TextBox ' # TEXTBOX DONDE SE DEVOLVERA EL VALOR DE LA MEDIA.
    Public ZoneControl As PictureBox ' # PICTUREBOX QUE CAMBIA EL ESTADO DEL VECTOR.
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
    End Sub
    Private Sub med_pic_save_Click(sender As Object, e As EventArgs) Handles med_pic_save.Click
        ' # BOTON PARA SALIR Y GUARDAR LOS COMPONENTES.
        ' # FUNCION DEBE DETECTAR, CUANTAS POSICIONES TIENE RELLENAS EL FORMULARIO
        ' # DEBE INSERTAR CADA POSICION POR SEPARADO (FOR OR WHILE)
        ' # DEBE CALCULAR EL PROMEDIO.
        Dim MediaPosA As Long = 0
        Dim MediaPosB As Long = 0
        Dim MediaPosC As Long = 0
        Dim MediaGeneral As Long = 0
        If Me.med_txt_a45.Text <> "" Then
            MediaPosA = MISC_CALCULA_MEDIA(Val(Me.med_txt_a45.Text), Val(Me.med_txt_a90.Text), Val(Me.med_txt_a135.Text), Val(Me.med_txt_a180.Text))
            If PGSQL_TACTIL_MEDSAVE(MedOT, MedComponente, MedZona, 1, Me.med_txt_a45.Text, Me.med_txt_a90.Text, Me.med_txt_a135.Text, Me.med_txt_a180.Text, MediaPosA) = False Then
                Exit Sub
            End If
        End If
        If Me.med_txt_b45.Text <> "" Then
            MediaPosB = MISC_CALCULA_MEDIA(Val(Me.med_txt_b45.Text), Val(Me.med_txt_b90.Text), Val(Me.med_txt_b135.Text), Val(Me.med_txt_b180.Text))
            If PGSQL_TACTIL_MEDSAVE(MedOT, MedComponente, MedZona, 2, Me.med_txt_b45.Text, Me.med_txt_b90.Text, Me.med_txt_b135.Text, Me.med_txt_b180.Text, MediaPosB) = False Then
                Exit Sub
            End If
        End If
        If Me.med_txt_c45.Text <> "" Then
            MediaPosC = MISC_CALCULA_MEDIA(Val(Me.med_txt_c45.Text), Val(Me.med_txt_c90.Text), Val(Me.med_txt_c135.Text), Val(Me.med_txt_c180.Text))
            If PGSQL_TACTIL_MEDSAVE(MedOT, MedComponente, MedZona, 3, Me.med_txt_c45.Text, Me.med_txt_c90.Text, Me.med_txt_c135.Text, Me.med_txt_c180.Text, MediaPosC) = False Then
                Exit Sub
            End If
        End If
        If MediaPosA <> 0 Then
            MediaGeneral = MISC_CALCULA_MEDIA_GENERAL(MediaPosA, MediaPosB, MediaPosC)
            ControlReturn.Text = MediaGeneral
            ZoneControl.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/ejes/generico_imp_cerrado/z1_sucess.png")
        End If
        PanelCarga.Visible = False
        Me.Close()
    End Sub
End Class