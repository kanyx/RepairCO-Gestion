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
            mecdesarme_pn_eje.Controls.Add(frm_bomba_impulsorcerrado_eje)
            frm_bomba_impulsorcerrado_eje.Show()
        End If
    End Sub
End Class