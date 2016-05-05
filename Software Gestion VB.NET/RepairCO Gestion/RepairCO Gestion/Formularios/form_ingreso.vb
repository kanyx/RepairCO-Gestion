Public Class form_ingreso
    Private Sub form_ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS FORMULARIO PRINCIPAL
        Me.ingresot_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ingreso_ot_title.png")
        Me.ingresot_pic_ot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/not.png")
        Me.ingreso_lbl_addcliente.Cursor = Cursors.Hand
        Me.ingreso_lbl_addtipo.Cursor = Cursors.Hand
        Me.ingreso_lbl_addmarca.Cursor = Cursors.Hand
        Me.ingreso_lbl_addmodelo.Cursor = Cursors.Hand
        ' # SETEAMOS VALORES DEL TOOLTIP
        Me.ingreso_tp_help.SetToolTip(Me.ingreso_lbl_addcliente, "Presione aquí para agregar un nuevo cliente.")
        Me.ingreso_tp_help.SetToolTip(Me.ingreso_lbl_addmarca, "Presione aquí para ingresar una nueva marca.")
        Me.ingreso_tp_help.SetToolTip(Me.ingreso_lbl_addmodelo, "Presione aquí para agregar un nuevo modelo.")
    End Sub
End Class