Imports System.Collections
Public Class mec_med_flexion
    Public FlexComponente As String = ""
    Public FlexOT As String = ""
    Public ControlReturn As TextBox
    Public PanelCarga As Panel
    Private DatosAnteriores As New Dictionary(Of Integer, String)
    Private Sub mec_med_flexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS GRAFICOS DEL FORMULARIO
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/fondo_panel_med_flexion.png")
        Me.flex_pic_save.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/guardar_hover.png")
        ' # ESTABLECEMOS PARAMETROS DE LOS CONTROLES.
        Me.flex_lbl_0.BackColor = Color.Transparent
        Me.flex_lbl_45.BackColor = Color.Transparent
        Me.flex_lbl_90.BackColor = Color.Transparent
        Me.flex_lbl_135.BackColor = Color.Transparent
        Me.flex_lbl_posa.BackColor = Color.Transparent
        Me.flex_lbl_posb.BackColor = Color.Transparent
        Me.flex_lbl_posc.BackColor = Color.Transparent
        Me.flex_lbl_posd.BackColor = Color.Transparent
        Me.flex_lbl_0.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.flex_lbl_45.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.flex_lbl_90.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.flex_lbl_135.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.flex_lbl_posa.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.flex_lbl_posb.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.flex_lbl_posc.ForeColor = ColorTranslator.FromHtml("#595959")
        Me.flex_lbl_posd.ForeColor = ColorTranslator.FromHtml("#595959")
        ' # CARGAMOS LOS DATOS ANTERIORES DESDE LA BASE DE DATOS Y LOS DESPLEGAMOS EN LOS TEXTBOX DE LA TABLA.
        ' # ESTO SE REALIZA PARA LAS 4 POSICIONES DISPONIBLES EN EL FORMULARIO FLEXION A, B, C, D !
        DatosAnteriores = PGSQL_TACTIL_FLEXLOAD(FlexOT, FlexComponente)
        If DatosAnteriores.ContainsValue("ERROR") = False Then
            For Each flex In DatosAnteriores
                If flex.Key = 1 Then
                    Dim ValoresFlex As String() = flex.Value.Split("#")
                    Me.flex_txt_a0.Text = Format(Single.Parse(ValoresFlex(0)), "##,##0.0")
                    Me.flex_txt_a45.Text = Format(Single.Parse(ValoresFlex(1)), "##,##0.0")
                    Me.flex_txt_a90.Text = Format(Single.Parse(ValoresFlex(2)), "##,##0.0")
                    Me.flex_txt_a135.Text = Format(Single.Parse(ValoresFlex(3)), "##,##0.0")
                ElseIf flex.Key = 2 Then
                    Dim ValoresFlex As String() = flex.Value.Split("#")
                    Me.flex_txt_b0.Text = Format(Single.Parse(ValoresFlex(0)), "##,##0.0")
                    Me.flex_txt_b45.Text = Format(Single.Parse(ValoresFlex(1)), "##,##0.0")
                    Me.flex_txt_b90.Text = Format(Single.Parse(ValoresFlex(2)), "##,##0.0")
                    Me.flex_txt_b135.Text = Format(Single.Parse(ValoresFlex(3)), "##,##0.0")
                ElseIf flex.Key = 3 Then
                    Dim ValoresFlex As String() = flex.Value.Split("#")
                    Me.flex_txt_c0.Text = Format(Single.Parse(ValoresFlex(0)), "##,##0.0")
                    Me.flex_txt_c45.Text = Format(Single.Parse(ValoresFlex(1)), "##,##0.0")
                    Me.flex_txt_c90.Text = Format(Single.Parse(ValoresFlex(2)), "##,##0.0")
                    Me.flex_txt_c135.Text = Format(Single.Parse(ValoresFlex(3)), "##,##0.0")
                ElseIf flex.Key = 4 Then
                    Dim ValoresFlex As String() = flex.Value.Split("#")
                    Me.flex_txt_d0.Text = Format(Single.Parse(ValoresFlex(0)), "##,##0.0")
                    Me.flex_txt_d45.Text = Format(Single.Parse(ValoresFlex(1)), "##,##0.0")
                    Me.flex_txt_d90.Text = Format(Single.Parse(ValoresFlex(2)), "##,##0.0")
                    Me.flex_txt_d135.Text = Format(Single.Parse(ValoresFlex(3)), "##,##0.0")
                End If
            Next
        End If
    End Sub
    Private Sub flex_pic_save_Click(sender As Object, e As EventArgs) Handles flex_pic_save.Click
        If Me.flex_txt_a0.Text <> "" Then
            If PGSQL_TACTIL_FLEXSAVE(FlexOT, FlexComponente, 1, Single.Parse(Me.flex_txt_a0.Text), Single.Parse(Me.flex_txt_a45.Text), _
                                     Single.Parse(Me.flex_txt_a90.Text), Single.Parse(Me.flex_txt_a135.Text)) = False Then
                Exit Sub
            End If
        End If
        If Me.flex_txt_b0.Text <> "" Then
            If PGSQL_TACTIL_FLEXSAVE(FlexOT, FlexComponente, 2, Single.Parse(Me.flex_txt_b0.Text), Single.Parse(Me.flex_txt_b45.Text), _
                                     Single.Parse(Me.flex_txt_b90.Text), Single.Parse(Me.flex_txt_b135.Text)) = False Then
                Exit Sub
            End If
        End If
        If Me.flex_txt_c0.Text <> "" Then
            If PGSQL_TACTIL_FLEXSAVE(FlexOT, FlexComponente, 3, Single.Parse(Me.flex_txt_c0.Text), Single.Parse(Me.flex_txt_c45.Text), _
                                     Single.Parse(Me.flex_txt_c90.Text), Single.Parse(Me.flex_txt_c135.Text)) = False Then
                Exit Sub
            End If
        End If
        If Me.flex_txt_d0.Text <> "" Then
            If PGSQL_TACTIL_FLEXSAVE(FlexOT, FlexComponente, 4, Single.Parse(Me.flex_txt_d0.Text), Single.Parse(Me.flex_txt_d45.Text), _
                                     Single.Parse(Me.flex_txt_d90.Text), Single.Parse(Me.flex_txt_d135.Text)) = False Then
                Exit Sub
            End If
        End If
        ' # CARGAMOS EL VALOR MAS GRANDE EN EL PRINCIPAL DEL FORMULARIO.
        Dim Valores As New ArrayList()
        If Me.flex_txt_a0.Text <> "" Then
            Valores.Add(Single.Parse(Me.flex_txt_a0.Text))
            Valores.Add(Single.Parse(Me.flex_txt_a45.Text))
            Valores.Add(Single.Parse(Me.flex_txt_a90.Text))
            Valores.Add(Single.Parse(Me.flex_txt_a135.Text))
        End If
        If Me.flex_txt_b0.Text <> "" Then
            Valores.Add(Single.Parse(Me.flex_txt_b0.Text))
            Valores.Add(Single.Parse(Me.flex_txt_b45.Text))
            Valores.Add(Single.Parse(Me.flex_txt_b90.Text))
            Valores.Add(Single.Parse(Me.flex_txt_b135.Text))
        End If
        If Me.flex_txt_c0.Text <> "" Then
            Valores.Add(Single.Parse(Me.flex_txt_c0.Text))
            Valores.Add(Single.Parse(Me.flex_txt_c45.Text))
            Valores.Add(Single.Parse(Me.flex_txt_c90.Text))
            Valores.Add(Single.Parse(Me.flex_txt_c135.Text))
        End If
        If Me.flex_txt_d0.Text <> "" Then
            Valores.Add(Single.Parse(Me.flex_txt_d0.Text))
            Valores.Add(Single.Parse(Me.flex_txt_d45.Text))
            Valores.Add(Single.Parse(Me.flex_txt_d90.Text))
            Valores.Add(Single.Parse(Me.flex_txt_d135.Text))
        End If
        If Valores.Count > 0 Then
            Valores.Sort()
            ControlReturn.Text = Format(Single.Parse(Valores(Valores.Count - 1).ToString), "##,##0.0").Replace(",", ".")
        End If
            PanelCarga.Visible = False
            Me.Close()
    End Sub
    Private Sub flex_txt_a0_Click(sender As Object, e As EventArgs) Handles flex_txt_a0.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_a0, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_a45_Click(sender As Object, e As EventArgs) Handles flex_txt_a45.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_a45, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_a90_Click(sender As Object, e As EventArgs) Handles flex_txt_a90.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_a90, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_a135_Click(sender As Object, e As EventArgs) Handles flex_txt_a135.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_a135, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_b0_Click(sender As Object, e As EventArgs) Handles flex_txt_b0.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_b0, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_b45_Click(sender As Object, e As EventArgs) Handles flex_txt_b45.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_b45, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_b90_Click(sender As Object, e As EventArgs) Handles flex_txt_b90.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_b90, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_b135_Click(sender As Object, e As EventArgs) Handles flex_txt_b135.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_b135, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_c0_Click(sender As Object, e As EventArgs) Handles flex_txt_c0.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_c0, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_c45_Click(sender As Object, e As EventArgs) Handles flex_txt_c45.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_c45, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_c90_Click(sender As Object, e As EventArgs) Handles flex_txt_c90.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_c90, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_c135_Click(sender As Object, e As EventArgs) Handles flex_txt_c135.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_c135, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_d0_Click(sender As Object, e As EventArgs) Handles flex_txt_d0.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_d0, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_d45_Click(sender As Object, e As EventArgs) Handles flex_txt_d45.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_d45, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_d90_Click(sender As Object, e As EventArgs) Handles flex_txt_d90.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_d90, True, PanelCarga, False, 2)
    End Sub
    Private Sub flex_txt_d135_Click(sender As Object, e As EventArgs) Handles flex_txt_d135.Click
        Call KEYBOARDRC_SHOW(Me.flex_txt_d135, True, PanelCarga, False, 2)
    End Sub
End Class