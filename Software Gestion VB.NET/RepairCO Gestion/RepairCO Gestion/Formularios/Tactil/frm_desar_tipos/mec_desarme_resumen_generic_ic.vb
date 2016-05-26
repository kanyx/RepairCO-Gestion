Public Class mec_desarme_resumen_generic_ic
    Public MecOT As String = "" ' # Numero de orden de trabajo a la cual se necesita obener los resultados del desarme.
    Private Sub mec_desarme_resumen_generic_ic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS GRAFICOS DEL FORMULARIO.
        Me.resultados_pic_adesgastetitle.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/resultados/generico_imp_cerrado/anillodesgaste_title.png")
        Me.resultados_pic_ejezonarodamientostitle.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/resultados/generico_imp_cerrado/ejezonarodamientos_title.png")
        Me.resultados_pic_arodinterior.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/resultados/generico_imp_cerrado/alojamientorodamientoexterior_title.png")
        Me.resultados_pic_cdesgaste.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/resultados/generico_imp_cerrado/camisadesgaste_title.png")
        Me.resultados_pic_comprobar.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/comprobar_hover.png")
        ' # CARGA PARAMETRO DE CONTROLES.
        Me.resultados_lbl_ad1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ad2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ad3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ad4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ad5.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ad6.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ad7.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ari1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ari2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ari3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ari4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ari5.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ari6.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ejezr1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ejezr2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ejezr3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ejezr4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ejezr5.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_ejezr6.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_cd1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_cd2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_cd3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_cd4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_cd5.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_cd6.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_lbl_cd7.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_ads1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_ads2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_ads3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_adp4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_adsstatus.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_adp1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_adp2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_adp3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_adp4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_adpstatus.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_arodintacopla1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_arodintacopla2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_arodintacopla3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_arodintacoplastatus.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_arodintlibre1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_arodintlibre2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_arodintlibre3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_arodintlibrestatus.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_cdla1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_cdla2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_cdla3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_cdla4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_cdlastatus.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_cdll1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_cdll2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_cdll3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_cdll4.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_cdllstatus.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_ejezrodacopla1.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_ejezrodacopla2.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_ejezrodacopla3.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_ejezrodacoplastatus.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.resultados_txt_adp1.ReadOnly = True
        Me.resultados_txt_adp2.ReadOnly = True
        Me.resultados_txt_adp3.ReadOnly = True
        Me.resultados_txt_adp4.ReadOnly = True
        Me.resultados_txt_adpstatus.ReadOnly = True
        Me.resultados_txt_ads1.ReadOnly = True
        Me.resultados_txt_ads2.ReadOnly = True
        Me.resultados_txt_ads3.ReadOnly = True
        Me.resultados_txt_ads4.ReadOnly = True
        Me.resultados_txt_adsstatus.ReadOnly = True
        Me.resultados_txt_arodintacopla1.ReadOnly = True
        Me.resultados_txt_arodintacopla2.ReadOnly = True
        Me.resultados_txt_arodintacopla3.ReadOnly = True
        Me.resultados_txt_arodintacoplastatus.ReadOnly = True
        Me.resultados_txt_arodintlibre1.ReadOnly = True
        Me.resultados_txt_arodintlibre2.ReadOnly = True
        Me.resultados_txt_arodintlibre3.ReadOnly = True
        Me.resultados_txt_arodintlibrestatus.ReadOnly = True
        Me.resultados_txt_cdla1.ReadOnly = True
        Me.resultados_txt_cdla2.ReadOnly = True
        Me.resultados_txt_cdla3.ReadOnly = True
        Me.resultados_txt_cdla4.ReadOnly = True
        Me.resultados_txt_cdlastatus.ReadOnly = True
        Me.resultados_txt_cdll1.ReadOnly = True
        Me.resultados_txt_cdll2.ReadOnly = True
        Me.resultados_txt_cdll3.ReadOnly = True
        Me.resultados_txt_cdll4.ReadOnly = True
        Me.resultados_txt_cdllstatus.ReadOnly = True
        Me.resultados_txt_ejezrodacopla1.ReadOnly = True
        Me.resultados_txt_ejezrodacopla2.ReadOnly = True
        Me.resultados_txt_ejezrodacopla3.ReadOnly = True
        Me.resultados_txt_ejezrodacoplastatus.ReadOnly = True
        Me.resultados_txt_ejezrodlibre1.ReadOnly = True
        Me.resultados_txt_ejezrodlibre2.ReadOnly = True
        Me.resultados_txt_ejezrodlibre3.ReadOnly = True
        Me.resultados_txt_ejezrodlibrestatus.ReadOnly = True
    End Sub
    Private Sub resultados_pic_comprobar_Click(sender As Object, e As EventArgs) Handles resultados_pic_comprobar.Click
        ' # REALIZAMOS LA COMPILACION DE INFORMACION DE LOS FORMULARIOS Y LOS PARAMETROS DE LA BASE DE DATOS
        Dim vMedEJE As New Dictionary(Of String, String)
        Dim vFlexEJE As New Dictionary(Of Integer, String)
        Dim vMedCamisa As New Dictionary(Of String, String)
        Dim vMedCarcasa As New Dictionary(Of String, String)
        Dim vMedCpoRod As New Dictionary(Of String, String)
        Dim vMedImpulsor As New Dictionary(Of String, String)
        ' # CARGAMOS LOS PARAMETROS DE COMPARACION (AJUSTES) DESDE LA BASE DE DATOS.

        ' # CARGAMOS LOS VALORES DE LAS MEDICIONES DEL EQUIPO A LOS CAMPOS DEL FORMULARIO.
        vMedEJE = PGSQL_TACTIL_MEDPROMLOAD(MecOT, "1")
        vFlexEJE = PGSQL_TACTIL_FLEXLOAD(MecOT, 1)
        vMedCamisa = PGSQL_TACTIL_MEDPROMLOAD(MecOT, "3")
        vMedCarcasa = PGSQL_TACTIL_MEDPROMLOAD(MecOT, "2")
        vMedCpoRod = PGSQL_TACTIL_MEDPROMLOAD(MecOT, "4")
        vMedImpulsor = PGSQL_TACTIL_MEDPROMLOAD(MecOT, "5")
        If vMedEJE.ContainsKey("0") = False Then
            For Each Eje In vMedEJE
                If Eje.Key = "1" And Eje.Value <> "" Then
                    'Me.eje_txt_z1.Text = Format(Single.Parse(Eje.Value), "##,##0.0")
                ElseIf Eje.Key = "2" And Eje.Value <> "" Then
                    Me.resultados_txt_ejezrodacopla1.Text = Format(Single.Parse(Eje.Value), "##,##0.0")
                ElseIf Eje.Key = "3" And Eje.Value <> "" Then
                    Me.resultados_txt_ejezrodlibre1.Text = Format(Single.Parse(Eje.Value), "##,##0.0")
                ElseIf Eje.Key = "4" And Eje.Value <> "" Then
                    Me.resultados_txt_cdla2.Text = Format(Single.Parse(Eje.Value), "##,##0.0")
                ElseIf Eje.Key = "5" And Eje.Value <> "" Then
                    Me.resultados_txt_cdll2.Text = Format(Single.Parse(Eje.Value), "##,##0.0")
                End If
            Next
        End If
        If vMedCamisa.ContainsKey("0") = False Then
            For Each Camisa In vMedCamisa
                If Camisa.Key = "1" And Camisa.Value <> "" Then
                    Me.resultados_txt_cdla1.Text = Format(Single.Parse(camisa.Value), "##,##0.0")
                ElseIf Camisa.Key = "2" And Camisa.Value <> "" Then
                    Me.resultados_txt_cdll1.Text = Format(Single.Parse(Camisa.Value), "##,##0.0")
                ElseIf Camisa.Key = "3" And Camisa.Value <> "" Then
                    'Me.resultados_txt_ejezrodlibre1.Text = Format(Single.Parse(Camisa.Value), "##,##0.0")
                ElseIf Camisa.Key = "4" And Camisa.Value <> "" Then
                    'Me.resultados_txt_cdla2.Text = Format(Single.Parse(Camisa.Value), "##,##0.0")
                End If
            Next
        End If
        If vMedImpulsor.ContainsKey("0") = False Then
            For Each Impulsor In vMedImpulsor
                If Impulsor.Key = "1" And Impulsor.Value <> "" Then
                    Me.resultados_txt_adp2.Text = Format(Single.Parse(Impulsor.Value), "##,##0.0")
                ElseIf Impulsor.Key = "2" And Impulsor.Value <> "" Then
                    Me.resultados_txt_ads2.Text = Format(Single.Parse(Impulsor.Value), "##,##0.0")
                ElseIf Impulsor.Key = "3" And Impulsor.Value <> "" Then
                    Me.resultados_txt_ads1.Text = Format(Single.Parse(Impulsor.Value), "##,##0.0")
                ElseIf Impulsor.Key = "4" And Impulsor.Value <> "" Then
                    Me.resultados_txt_adp1.Text = Format(Single.Parse(Impulsor.Value), "##,##0.0")
                End If
            Next
        End If
        If vMedCpoRod.ContainsKey("0") = False Then
            For Each CpoRod In vMedCpoRod
                If CpoRod.Key = "1" And CpoRod.Value <> "" Then
                    Me.resultados_txt_arodintlibre1.Text = Format(Single.Parse(CpoRod.Value), "##,##0.0")
                ElseIf CpoRod.Key = "2" And CpoRod.Value <> "" Then
                    Me.resultados_txt_arodintlibre1.Text = Format(Single.Parse(CpoRod.Value), "##,##0.0")
                End If
            Next
        End If
    End Sub
End Class