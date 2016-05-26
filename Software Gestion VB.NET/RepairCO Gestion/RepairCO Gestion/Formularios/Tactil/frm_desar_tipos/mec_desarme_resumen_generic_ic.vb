Public Class mec_desarme_resumen_generic_ic
    Public MecOT As String = "" ' # Numero de orden de trabajo a la cual se necesita obener los resultados del desarme.
    Private Sub mec_desarme_resumen_generic_ic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS GRAFICOS DEL FORMULARIO
        Me.resultados_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/resultados/resultado_title.png")
        Me.resultados_pic_adesgastetitle.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/resultados/generico_imp_cerrado/anillodesgaste_title.png")
        Me.resultados_pic_ejezonarodamientostitle.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/vectores/resultados/generico_imp_cerrado/ejezonarodamientos_title.png")
    End Sub
End Class