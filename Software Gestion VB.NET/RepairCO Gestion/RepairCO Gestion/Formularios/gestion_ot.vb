﻿Public Class gestion_ot
    Private Sub gestion_ot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS DEL FORMULARIO.
        Me.BackColor = Color.White
        Me.gestionot_pic_title.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/frm_gestionot_title.png")
        Me.gestionot_pic_buscar.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/buscar32.png")
        Me.gestionot_pic_title.SizeMode = PictureBoxSizeMode.StretchImage
        Me.gestionot_pic_buscar.SizeMode = PictureBoxSizeMode.StretchImage
        Me.gestionot_pic_buscar.Cursor = Cursors.Hand
        Me.gestionot_tp_help.SetToolTip(Me.gestionot_pic_buscar, "Presione aquí para aplicar los filtros de búsqueda.")
        Me.gestionot_tp_help.SetToolTip(Me.gestionot_cmb_cliente, "Seleccione nombre del cliente.")
        Me.gestionot_tp_help.SetToolTip(Me.gestionot_cmb_tipo, "Seleccione el tipo de producto.")
        Me.gestionot_tp_help.SetToolTip(Me.gestionot_lbl_rfilter, "Presione aquí para remover los filtros de búsqueda aplicados.")
        Me.gestionot_tp_help.SetToolTip(Me.gestionot_lbl_resultados, "Cantidad de órdenes de trabajo en el sistema.")
        ' # CARGAMOS LAS ORDENES DE TRABAJO A LA DATAGGRID DEL FORMULARIO.
        ' # ES IMPORTANTE ACOTAR QUE AL HACER DOBLE CLICK EN UNA ORDEN DE TRABAJO SE TIENE QUE ABRIR EL FORMULARIO
        ' # VIEW OT Y DESPLEGAR LA INFORMACION DETALLADA DE LA MISMA.
        PGSQL_CargarOTDataView(Me.gestionot_dg_resultados, False)
        Me.gestionot_dg_resultados.EnableHeadersVisualStyles = False
        Me.gestionot_dg_resultados.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#17375e")
        Me.gestionot_dg_resultados.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#b88d00")
        Me.gestionot_dg_resultados.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8, FontStyle.Bold)
        Me.gestionot_dg_resultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gestionot_dg_resultados.ColumnHeadersHeight = 25
        Me.gestionot_dg_resultados.Columns(0).HeaderText = "N° OT"
        Me.gestionot_dg_resultados.Columns(0).Width = 65
        Me.gestionot_lbl_rfilter.Visible = False
    End Sub
End Class