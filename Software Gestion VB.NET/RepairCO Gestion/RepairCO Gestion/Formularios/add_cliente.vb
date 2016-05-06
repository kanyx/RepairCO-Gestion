Public Class add_cliente
    Private Sub add_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA PRINCIPAL DE LA APLICACION.
        Me.addcliente_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_addcliente_title.png")
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_addcliente_background.png")
        Me.addcliente_close.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/close.png")
        Me.addcliente_pic_btnadd.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
        Me.addcliente_pic_titleicon.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/cliente.png")
        ' # SETEO DE PARAMETROS PRINCIPALES DE FUNCIONES
        Me.AllowTransparency = True
        Me.addcliente_close.Cursor = Cursors.Hand
        Me.addcliente_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addcliente_pic_titleicon.SizeMode = PictureBoxSizeMode.StretchImage
        Me.addcliente_tp_help.SetToolTip(Me.addcliente_close, "Cancelar la creación del cliente.")
        Me.addcliente_tp_help.SetToolTip(Me.addcliente_pic_btnadd, "Presione aquí para agregar el nuevo cliente a la base de datos.")
        Me.addcliente_pic_btnadd.Cursor = Cursors.Hand
    End Sub
    Private Sub addcliente_close_Click(sender As Object, e As EventArgs) Handles addcliente_close.Click
        Me.Close()
    End Sub
    Private Sub addcliente_pic_btnadd_MouseHover(sender As Object, e As EventArgs) Handles addcliente_pic_btnadd.MouseHover
        Me.addcliente_pic_btnadd.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_hover.png")
    End Sub
    Private Sub addcliente_pic_btnadd_MouseLeave(sender As Object, e As EventArgs) Handles addcliente_pic_btnadd.MouseLeave
        Me.addcliente_pic_btnadd.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/botones/agregar_normal.png")
    End Sub
    Private Sub addcliente_chk_contacto_CheckedChanged(sender As Object, e As EventArgs) Handles addcliente_chk_contacto.CheckedChanged
        ' # CUANDO PRESIONE EL CHECKED INDICADO QUE EXISTE INFORMACION DE UN CONTACTO DE LA EMPRESA
        ' # HABILITE EL GROUPBOX PARA QUE EL USUARIO PUEDA RELLENAR LA INFORMACION DEL CONTACTO.
        ' # EN CASO CONTRARIO QUE DESELECCIONE EL CHECKED DESHABILITE EL GROUPBOX DE INFORMACION DEL CONTACTO.
        If Me.addcliente_gb_contacto.Enabled = False Then
            Me.addcliente_gb_contacto.Enabled = True
        Else
            Me.addcliente_gb_contacto.Enabled = False
        End If
    End Sub
End Class