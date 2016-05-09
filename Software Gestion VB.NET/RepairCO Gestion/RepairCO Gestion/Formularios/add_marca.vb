Public Class add_marca
    Private Sub add_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ValueSource_Tipo As New Dictionary(Of String, String)()
        Dim ValueSource_Paises As New Dictionary(Of String, String)()
        ' # PROCESO DE CARGA DE LOS ELEMENTOS DEL FORMULARIO
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_addmarca_background.png")
        Me.addmarca_pic_close.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/close.png")
        Me.addmarca_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_addmarca_title.png")
        Me.addmarca_pic_btnadd.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
        Me.addmarca_pic_ico.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/marca.png")
        Me.addmarca_pic_btnadd.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addmarca_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addmarca_pic_ico.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addmarca_pic_close.BackColor = Color.Transparent
        Me.addmarca_gb_datos.BackColor = Color.White
        Me.addmarca_pic_btnadd.BackColor = Color.Transparent
        Me.addmarca_pic_title.BackColor = Color.Transparent
        Me.addmarca_pic_ico.BackColor = Color.Transparent
        Me.addmarca_pic_close.Cursor = Cursors.Hand
        Me.addmarca_pic_btnadd.Cursor = Cursors.Hand
        Me.addmarca_tp_help.SetToolTip(Me.addmarca_cmb_tipo, "Seleccione  el tipo de producto al cual se asociara la marca.")
        Me.addmarca_tp_help.SetToolTip(Me.addmarca_txt_nombre, "Ingrese el nombre de la marca.")
        Me.addmarca_tp_help.SetToolTip(Me.addmarca_cmb_pais, "Seleccione el país de procedencia de la marca.")
        Me.addmarca_tp_help.SetToolTip(Me.addmarca_pic_close, "Cancelar el proceso de adición de una marca.")
        Me.addmarca_tp_help.SetToolTip(Me.addmarca_pic_btnadd, "Añadir la nueva marca a la base de datos.")
        PGSQL_CargaTipos()
        PGSQL_CargaPais()
        ' # RELLENAMOS LOS VALORES DE LOS COMBOBOX.
        ValueSource_Tipo.Add("", "SELECCIONE TIPO")
        If _globalTipos.Count > 0 Then
            For Each TipoValue As KeyValuePair(Of String, String) In _globalTipos
                ValueSource_Tipo.Add(TipoValue.Key, TipoValue.Value.ToUpper)
            Next
        End If
        Me.addmarca_cmb_tipo.DataSource = New BindingSource(ValueSource_Tipo, Nothing)
        Me.addmarca_cmb_tipo.DisplayMember = "Value"
        Me.addmarca_cmb_tipo.ValueMember = "Key"
        ValueSource_Paises.Add("", "SELECCIONE PAIS")
        If _globalPaises.Count > 0 Then
            For Each TipoValue As KeyValuePair(Of String, String) In _globalPaises
                ValueSource_Paises.Add(TipoValue.Key, TipoValue.Value.ToUpper)
            Next
        End If
        Me.addmarca_cmb_pais.DataSource = New BindingSource(ValueSource_Paises, Nothing)
        Me.addmarca_cmb_pais.DisplayMember = "Value"
        Me.addmarca_cmb_pais.ValueMember = "Key"
    End Sub
    Private Sub addmarca_pic_close_Click(sender As Object, e As EventArgs) Handles addmarca_pic_close.Click
        Me.Close()
    End Sub
    Private Sub addmarca_pic_btnadd_MouseHover(sender As Object, e As EventArgs) Handles addmarca_pic_btnadd.MouseHover
        Me.addmarca_pic_btnadd.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_hover.png")
    End Sub
    Private Sub addmarca_pic_btnadd_MouseLeave(sender As Object, e As EventArgs) Handles addmarca_pic_btnadd.MouseLeave
        Me.addmarca_pic_btnadd.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
    End Sub
    Private Sub addmarca_pic_btnadd_Click(sender As Object, e As EventArgs) Handles addmarca_pic_btnadd.Click
        ' # COMPROBACION AL MOMENTO DE REALIZAR CLICK PARA INGRESAR UNA MARCA.
        If Me.addmarca_cmb_tipo.SelectedValue = "" Then
            Me.addmarca_cmb_tipo.BackColor = Color.Red
            Me.addmarca_cmb_tipo.ForeColor = Color.White
            Exit Sub
        Else
            Me.addmarca_cmb_tipo.BackColor = Color.Green
            Me.addmarca_cmb_tipo.ForeColor = Color.White
        End If
        If Me.addmarca_txt_nombre.Text = "" Or Me.addmarca_txt_nombre.TextLength < 3 Then
            Me.addmarca_txt_nombre.BackColor = Color.Red
            Me.addmarca_txt_nombre.ForeColor = Color.White
            Exit Sub
        Else
            Me.addmarca_txt_nombre.Text = Trim(Me.addmarca_txt_nombre.Text.ToUpper)
            Me.addmarca_txt_nombre.BackColor = Color.Green
            Me.addmarca_txt_nombre.ForeColor = Color.White
        End If
        If Me.addmarca_cmb_pais.SelectedValue = "" Then
            Me.addmarca_cmb_pais.BackColor = Color.Red
            Me.addmarca_cmb_pais.ForeColor = Color.White
            Exit Sub
        Else
            Me.addmarca_cmb_pais.BackColor = Color.Green
            Me.addmarca_cmb_pais.ForeColor = Color.White
        End If
        ' # PROCESO PARA INGRESAR LA MARCA A LA BASE DE DATOS.
        If PGSQL_INGRESO_MARCA(Me.addmarca_cmb_tipo.SelectedValue, Me.addmarca_txt_nombre.Text, _
                               Me.addmarca_cmb_pais.SelectedValue) = True Then
            MessageBox.Show("Marca ingresada exitosamente a la base de datos!.", Application.ProductName & " - " & _
                            Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class