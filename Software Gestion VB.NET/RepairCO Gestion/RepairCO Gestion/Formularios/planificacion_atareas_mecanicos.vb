Imports System.Drawing.Text
Public Class planificacion_atareas_mecanicos
    Public MecOT As String = ""
    Private MyriadPro_Bold As New PrivateFontCollection()
    Private Sub planificacion_atareas_mecanicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # LLAMAMOS A LAS FUNCIONES DE CARGA DE INFORMACION.
        Call PGSQL_PLANIFICACION_LOADMEC_NOASIGNADO(Me.planificacion_atareasmec_gv_disponible)
        ' # CARGA DE ELEMENTOS GRAFICOS DE LA APLICACION.
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Data\grafica\frm_asign_meca_background.png")
        Me.planificacion_atareasmec_il_tab.Images.Add(0, Image.FromFile(Application.StartupPath & "\Data\grafica\ico\user_libre.png"))
        Me.planificacion_atareasmec_il_tab.Images.Add(1, Image.FromFile(Application.StartupPath & "\Data\grafica\ico\user_asignado.png"))
        Me.planificacion_atareasmec_pic_close.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\ico\close.png")
        Me.planificacion_atareasmec_pic_meca.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\mecnofoto_atareas.png")
        ' # ESTABLECEMOS PARAMETROS DE LOS CONTROLES DE LA APLICACION.
        MyriadPro_Bold.AddFontFile(Application.StartupPath & "\Data\fonts\MyriadPro-BoldCond.ttf")
        Me.planificacion_atareasmec_lbl_title.Text = "ASIGNAR PERSONAL OT N°" & MecOT
        Me.planificacion_atareasmec_gb_informacion.Font = New Font(MyriadPro_Bold.Families(0), 12, FontStyle.Bold)
        Me.planificacion_atareasmec_lbl_title.Font = New Font(MyriadPro_Bold.Families(0), 22, FontStyle.Bold)
        Me.planificacion_atareasmec_lbl_infonombretitle.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.planificacion_atareasmec_lbl_infonombrevalue.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.planificacion_atareasmec_lbl_inforuttitle.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.planificacion_atareasmec_lbl_inforutvalue.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.planificacion_atareasmec_lbl_infospectitle.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.planificacion_atareasmec_lbl_infosepecvalue.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.planificacion_atareasmec_lbl_infootasigtitle.Font = New Font(MyriadPro_Bold.Families(0), 12, FontStyle.Bold)
        Me.planificacion_atareasmec_lbl_infootasigvalue.Font = New Font(MyriadPro_Bold.Families(0), 30, FontStyle.Bold)
        Me.planificacion_atareasmec_lbl_title.BackColor = Color.Transparent
        Me.planificacion_atareasmec_lbl_infonombretitle.BackColor = Color.Transparent
        Me.planificacion_atareasmec_lbl_infonombrevalue.BackColor = Color.Transparent
        Me.planificacion_atareasmec_lbl_inforuttitle.BackColor = Color.Transparent
        Me.planificacion_atareasmec_lbl_inforutvalue.BackColor = Color.Transparent
        Me.planificacion_atareasmec_lbl_infospectitle.BackColor = Color.Transparent
        Me.planificacion_atareasmec_lbl_infosepecvalue.BackColor = Color.Transparent
        Me.planificacion_atareasmec_lbl_infootasigtitle.BackColor = Color.Transparent
        Me.planificacion_atareasmec_lbl_infootasigvalue.BackColor = Color.Transparent
        Me.planificacion_atareasmec_gb_informacion.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.planificacion_atareasmec_lbl_title.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.planificacion_atareasmec_lbl_infonombretitle.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.planificacion_atareasmec_lbl_infonombrevalue.ForeColor = ColorTranslator.FromHtml("#464544")
        Me.planificacion_atareasmec_lbl_inforuttitle.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.planificacion_atareasmec_lbl_inforutvalue.ForeColor = ColorTranslator.FromHtml("#464544")
        Me.planificacion_atareasmec_lbl_infospectitle.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.planificacion_atareasmec_lbl_infosepecvalue.ForeColor = ColorTranslator.FromHtml("#464544")
        Me.planificacion_atareasmec_lbl_infootasigtitle.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.planificacion_atareasmec_lbl_infootasigvalue.ForeColor = ColorTranslator.FromHtml("#5b5b5b")
        Me.planificacion_atareasmec_il_tab.ColorDepth = ColorDepth.Depth32Bit
        Me.planificacion_atareasmec_il_tab.ImageSize = New Size(32, 32)
        Me.planificacion_atareasmec_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.planificacion_atareasmec_tp_principal.ImageList = Me.planificacion_atareasmec_il_tab
        Me.planificacion_atareasmec_gb_informacion.Visible = False
        Me.planificacion_atareasmec_gv_disponible.EnableHeadersVisualStyles = False
        Me.planificacion_atareasmec_gv_disponible.ReadOnly = True
        Me.planificacion_atareasmec_gv_disponible.RowHeadersVisible = False
        Me.planificacion_atareasmec_gv_disponible.AllowUserToResizeColumns = False
        Me.planificacion_atareasmec_gv_disponible.AllowUserToAddRows = False
        Me.planificacion_atareasmec_gv_disponible.AllowUserToDeleteRows = False
        Me.planificacion_atareasmec_gv_disponible.AllowUserToOrderColumns = False
        Me.planificacion_atareasmec_gv_disponible.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.planificacion_atareasmec_gv_disponible.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.planificacion_atareasmec_gv_disponible.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.planificacion_atareasmec_gv_disponible.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.planificacion_atareasmec_gv_disponible.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.planificacion_atareasmec_gv_disponible.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#17375e")
        Me.planificacion_atareasmec_gv_disponible.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.planificacion_atareasmec_gv_disponible.ColumnHeadersDefaultCellStyle.Font = New Font(MyriadPro_Bold.Families(0), 7, FontStyle.Bold)
        Me.planificacion_atareasmec_gv_disponible.Columns(0).HeaderText = "NOMBRE"
        Me.planificacion_atareasmec_gv_disponible.Columns(1).HeaderText = "RUT"
        Me.planificacion_atareasmec_gv_disponible.ColumnHeadersHeight = 30
        Me.planificacion_atareasmec_gv_disponible.Columns(0).Width = 250
        Me.planificacion_atareasmec_gv_disponible.Columns(1).Width = 90
        Me.planificacion_atareasmec_gv_disponible.Columns(4).Width = 350
    End Sub
    Private Sub planificacion_atareasmec_pic_close_Click(sender As Object, e As EventArgs) Handles planificacion_atareasmec_pic_close.Click
        ' # CERRAMOS EL FORMULARIO.
        Me.Close()
    End Sub
    Private Sub planificacion_atareasmec_gv_disponible_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles planificacion_atareasmec_gv_disponible.CellClick
        Dim OTASIGNMEC As String = ""
        ' # RELLENAMOS EL CUADRO DE RESUMEN DEL MECANICO.
        Me.planificacion_atareasmec_gb_informacion.Visible = True
        Me.planificacion_atareasmec_lbl_infonombrevalue.Text = Me.planificacion_atareasmec_gv_disponible.Rows(e.RowIndex).Cells(0).Value.ToString.ToUpper
        Me.planificacion_atareasmec_lbl_inforutvalue.Text = Me.planificacion_atareasmec_gv_disponible.Rows(e.RowIndex).Cells(1).Value.ToString.ToUpper
        Me.planificacion_atareasmec_lbl_infosepecvalue.Text = Me.planificacion_atareasmec_gv_disponible.Rows(e.RowIndex).Cells(4).Value.ToString.ToUpper
        ' # CARGAMOS LAS OT ASIGNADAS AL MECANICO.
        Dim ListOTASIGMEC As New ArrayList
        ListOTASIGMEC = PGSQL_MECGETOTASIGACTIVE(Me.planificacion_atareasmec_gv_disponible.Rows(e.RowIndex).Cells(3).Value.ToString)
        If ListOTASIGMEC.Count <= 0 Or ListOTASIGMEC(0).ToString = "" Then
            Me.planificacion_atareasmec_lbl_infootasigvalue.Text = "NINGUNA"
        Else
            For Each OT In ListOTASIGMEC
                If OTASIGNMEC = "" Then
                    OTASIGNMEC = OT
                Else
                    OTASIGNMEC = OTASIGNMEC & "/" & OT
                End If
            Next
            Me.planificacion_atareasmec_lbl_infootasigvalue.Text = OTASIGNMEC
        End If
    End Sub
    Private Sub planificacion_atareasmec_gv_disponible_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles planificacion_atareasmec_gv_disponible.CellDoubleClick
        ' # LANZAMOS UN MESSAGEBOX DE CONFIRMACION PARA ASIGANR DICHA ORDEN.
        If MessageBox.Show("¿Desea asignar al mecánico " & Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Me.planificacion_atareasmec_gv_disponible.Rows(e.RowIndex).Cells(0).Value.ToString) & _
                           " a la orden de trabajo numero " & MecOT & "?", Application.ProductName & " - Asignación de mecánico", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            ' # SI SE ACEPTA ASIGNAR LA ORDEN DE TRABAJO AL MECANICO
        End If
    End Sub
End Class