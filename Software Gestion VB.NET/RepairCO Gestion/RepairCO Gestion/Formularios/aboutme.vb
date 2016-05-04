Public Class aboutme
    Private Sub aboutme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # Carga de componentes externos a la aplicion.
        Me.aboutme_logo.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/logo_aboutme.png")
        ' # Carga de valores al formulario de informaion de la aplicacion.
        Me.aboutme_txt_version.Text = Application.ProductVersion & " - " & main_loggin.VersionPrefix
        Me.aboutme_txt_mdb.Text = "PostgreSQL 9.3"
        Me.aboutme_txt_framework.Text = System.Environment.Version.ToString
        Me.aboutme_txt_engineer.Text = "Matias Aliaga Cortes"
        Me.aboutme_txt_pengineer.Text = "Pilar Saez Contreras"
        Me.aboutme_txt_developer.Text = "Sebastian Guajardo A."
        Me.aboutme_txt_so.Text = System.Environment.OSVersion.ToString
        Me.aboutme_txt_npgsql.Text = "3.0.7 Stable"
        Me.aboutme_txt_gh.Text = "3.0.17.0 Stable"
        Me.aboutme_txt_wcalice.Text = "2.0.0.7"
    End Sub
End Class