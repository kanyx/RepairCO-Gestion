Public Class mec_desarme
    Public MecDesaOT As String = "" ' # NUMERO DE LA ORDEN DE TRABAJO A PROCESAR
    Public MecTipoProducto As String = "" ' # IDENTIDFICADOR UNICO (ID) DEL TIPO DE PRODUCTO A DESARMAR.
    Private Sub mec_desarme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA ELEMENTOS DEL FORMULARIO. (IMPORTANTE: EN LOS PANELES CARGA FORMULARIOS SEGUN TIPO)
        If MecTipoProducto = "27" Then
            ' # CARGAMOS FORMULARIOS DE BOMBA DE IMPULSOR CERRADO (TIP. PROD. 27)
            Dim frm_bomba_impulsorcerrado_eje As New eje_imp_cerrado_generico
            frm_bomba_impulsorcerrado_eje.TopLevel = False
            frm_bomba_impulsorcerrado_eje.Dock = DockStyle.Fill
            frm_bomba_impulsorcerrado_eje.MecOT = MecDesaOT
            frm_bomba_impulsorcerrado_eje.MecTipoProducto = MecTipoProducto
            Me.mecdesarme_pn_eje.Controls.Add(frm_bomba_impulsorcerrado_eje)
            frm_bomba_impulsorcerrado_eje.Show()
            ' # CARCASA.
            Dim frm_bomba_impulsorcerrado_carcasa As New carcasa_imp_cerrado_generico
            frm_bomba_impulsorcerrado_carcasa.TopLevel = False
            frm_bomba_impulsorcerrado_carcasa.Dock = DockStyle.Fill
            frm_bomba_impulsorcerrado_carcasa.MecOT = MecDesaOT
            frm_bomba_impulsorcerrado_carcasa.MecTipoProducto = MecTipoProducto
            Me.mecdesarme_pn_carcasa.Controls.Add(frm_bomba_impulsorcerrado_carcasa)
            frm_bomba_impulsorcerrado_carcasa.Show()
            ' # CAMISA.
            Dim frm_bomba_impulsorcerrado_camisa As New camisa_imp_cerrado_generico
            frm_bomba_impulsorcerrado_camisa.TopLevel = False
            frm_bomba_impulsorcerrado_camisa.Dock = DockStyle.Fill
            frm_bomba_impulsorcerrado_camisa.MecOT = MecDesaOT
            frm_bomba_impulsorcerrado_camisa.MecTipoProducto = MecTipoProducto
            Me.mecdesarme_pn_camisa.Controls.Add(frm_bomba_impulsorcerrado_camisa)
            frm_bomba_impulsorcerrado_camisa.Show()
            ' # CUERPO DE RODAMIENTO.
            Dim frm_bomba_impulsorcerrado_cporod As New cporod_imp_cerrado_generico
            frm_bomba_impulsorcerrado_cporod.TopLevel = False
            frm_bomba_impulsorcerrado_cporod.Dock = DockStyle.Fill
            frm_bomba_impulsorcerrado_cporod.MecOT = MecDesaOT
            frm_bomba_impulsorcerrado_cporod.MecTipoProducto = MecTipoProducto
            Me.mecdesarme_pn_cporod.Controls.Add(frm_bomba_impulsorcerrado_cporod)
            frm_bomba_impulsorcerrado_cporod.Show()
            ' # IMPULSOR.
            Dim frm_bomba_impulsorcerrado_impulsor As New impulsor_imp_cerrado_generico
            frm_bomba_impulsorcerrado_impulsor.TopLevel = False
            frm_bomba_impulsorcerrado_impulsor.Dock = DockStyle.Fill
            frm_bomba_impulsorcerrado_impulsor.MecOT = MecDesaOT
            frm_bomba_impulsorcerrado_impulsor.MecTipoProducto = MecTipoProducto
            Me.mecdesarme_pn_impulsor.Controls.Add(frm_bomba_impulsorcerrado_impulsor)
            frm_bomba_impulsorcerrado_impulsor.Show()
            ' # RESUMEN DEL DESARME DE BOMBA DE IMPULSOR CERRADO.
            Dim frm_bomba_impulsorcerrado_resumen As New mec_desarme_resumen_generic_ic
            frm_bomba_impulsorcerrado_resumen.TopLevel = False
            frm_bomba_impulsorcerrado_resumen.Dock = DockStyle.Fill
            frm_bomba_impulsorcerrado_resumen.MecOT = MecDesaOT
            Me.mecdesarme_pn_resumen.Controls.Add(frm_bomba_impulsorcerrado_resumen)
            frm_bomba_impulsorcerrado_resumen.Show()
        End If

    End Sub
End Class