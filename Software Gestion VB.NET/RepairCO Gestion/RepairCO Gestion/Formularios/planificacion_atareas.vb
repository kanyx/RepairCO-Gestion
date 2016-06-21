Public Class planificacion_atareas
    Private Sub planificacion_atareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE INFORMACION.
        Call PGSQL_PLANIFICACION_LOADOT(Me.planificacion_dg_actual)
        Call PGSQL_PLANIFICACION_LOADOT_NOASIGNADA(Me.planificacion_dg_asignacion)
        ' # CARGA ELEMENTOS GRAFICOS DEL FORMULARIO
        Me.planificacion_il_tab.Images.Add(0, Image.FromFile(Application.StartupPath & "\Data\grafica\ico\reloj.png"))
        Me.planificacion_il_tab.Images.Add(1, Image.FromFile(Application.StartupPath & "\Data\grafica\ico\today_96.png"))
        Me.planificacion_pic_title.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\frm_atareas_title.png")
        ' # PARAMETROS A CONTROLES DEL FORMULARIO.
        Me.planificacion_pic_title.SizeMode = PictureBoxSizeMode.StretchImage
        Me.planificacion_dg_actual.EnableHeadersVisualStyles = False
        Me.planificacion_dg_asignacion.EnableHeadersVisualStyles = False
        Me.planificacion_dg_actual.ReadOnly = True
        Me.planificacion_dg_asignacion.ReadOnly = True
        Me.planificacion_dg_actual.RowHeadersVisible = False
        Me.planificacion_dg_asignacion.RowHeadersVisible = False
        Me.planificacion_dg_actual.AllowUserToResizeColumns = False
        Me.planificacion_dg_asignacion.AllowUserToResizeColumns = False
        Me.planificacion_dg_actual.AllowUserToAddRows = False
        Me.planificacion_dg_asignacion.AllowUserToAddRows = False
        Me.planificacion_dg_actual.AllowUserToDeleteRows = False
        Me.planificacion_dg_asignacion.AllowUserToDeleteRows = False
        Me.planificacion_dg_actual.AllowUserToOrderColumns = False
        Me.planificacion_dg_asignacion.AllowUserToOrderColumns = False
        Me.planificacion_dg_actual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.planificacion_dg_asignacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.planificacion_dg_actual.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.planificacion_dg_asignacion.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.planificacion_dg_actual.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.planificacion_dg_asignacion.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.planificacion_dg_actual.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.planificacion_dg_asignacion.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.planificacion_dg_actual.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.planificacion_dg_asignacion.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.planificacion_dg_actual.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#17375e")
        Me.planificacion_dg_asignacion.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#17375e")
        Me.planificacion_dg_actual.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.planificacion_dg_asignacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.planificacion_dg_actual.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 6, FontStyle.Bold)
        Me.planificacion_dg_asignacion.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 6, FontStyle.Bold)
        Me.planificacion_dg_actual.Columns(0).HeaderText = "N° OT"
        Me.planificacion_dg_asignacion.Columns(0).HeaderText = "N° OT"
        Me.planificacion_dg_asignacion.Columns(7).HeaderText = "PRIORIDAD"
        Me.planificacion_dg_asignacion.Columns(8).HeaderText = "FECHA INGRESO"
        Me.planificacion_dg_asignacion.Columns(13).HeaderText = "TIPO"
        Me.planificacion_dg_asignacion.Columns(14).HeaderText = "MARCA"
        Me.planificacion_dg_asignacion.Columns(15).HeaderText = "MODELO"
        Me.planificacion_dg_actual.ColumnHeadersHeight = 40
        Me.planificacion_dg_asignacion.ColumnHeadersHeight = 40
        Me.planificacion_dg_actual.Columns(0).Width = 70
        Me.planificacion_dg_actual.Columns(12).Width = 80
        Me.planificacion_dg_actual.Columns(13).Width = 120
        Me.planificacion_dg_actual.Columns(14).Width = 120
        Me.planificacion_dg_actual.Columns(15).Width = 120
        Me.planificacion_dg_actual.Columns(16).Width = 120
        Me.planificacion_dg_actual.Columns(18).Width = 80
        Me.planificacion_dg_actual.Columns(19).Width = 80
        Me.planificacion_dg_actual.Columns(20).Width = 80
        Me.planificacion_dg_actual.Columns(21).Width = 80
        Me.planificacion_dg_actual.Columns(22).Width = 80
        Me.planificacion_dg_actual.Columns(23).Width = 120
        Me.planificacion_dg_actual.Columns(24).Width = 120
        Me.planificacion_dg_actual.Columns(25).Width = 120
        Me.planificacion_dg_actual.Columns(26).Width = 100
        Me.planificacion_dg_actual.Columns(27).Width = 100
        Me.planificacion_dg_actual.Columns(28).Width = 80
        Me.planificacion_dg_actual.Columns(29).Width = 80
        Me.planificacion_dg_asignacion.Columns(0).Width = 70
        Me.planificacion_dg_asignacion.Columns(7).Width = 70
        Me.planificacion_dg_asignacion.Columns(8).Width = 90
        Me.planificacion_dg_asignacion.Columns(13).Width = 150
        Me.planificacion_dg_asignacion.Columns(14).Width = 120
        Me.planificacion_dg_asignacion.Columns(15).Width = 250
        Me.planificacion_dg_actual.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(12).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(13).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(14).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(15).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(16).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(18).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(19).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(20).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(21).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(22).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(23).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(24).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(25).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(26).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(27).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(28).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_actual.Columns(29).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_asignacion.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_asignacion.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_asignacion.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_asignacion.Columns(13).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_asignacion.Columns(14).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_dg_asignacion.Columns(15).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.planificacion_tm_refresh.Interval = 33500
        Me.planificacion_tm_refresh.Enabled = True
        Me.planificacion_il_tab.ColorDepth = ColorDepth.Depth32Bit
        Me.planificacion_il_tab.ImageSize = New Size(48, 48)
        Me.planificacion_tp_principal.ImageList = Me.planificacion_il_tab
    End Sub
    Private Sub planificacion_dg_actual_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles planificacion_dg_actual.CellPainting
        Dim StatusValue As Image
        ' # ESTADO DESARME (1)
        If e.ColumnIndex = 12 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(12), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "1" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 20, e.CellBounds.Top + 3)
            Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 20
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(12).ToolTipText = "Editar cliente"
            e.Handled = True
        End If
        ' # ESTADO REGISTRO FOTOGRAFICO DESARME (2)
        If e.ColumnIndex = 13 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(13), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "2" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 40, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # ESTADO CONTROL METROLOGICO DESARME (3)
        If e.ColumnIndex = 14 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(14), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "3" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 40, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # COMENTARIOS DE DESARME (4)
        If e.ColumnIndex = 15 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(15), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "4" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 40, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # EVALUACION DE COMPONENTES DE DESARME (5)
        If e.ColumnIndex = 16 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(16), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "5" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 40, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # DIAGNOSTICO (7)
        If e.ColumnIndex = 18 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(18), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "7" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 25, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # COTIZAR (8)
        If e.ColumnIndex = 19 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(19), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "8" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 25, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # ESPERA OC (9)
        If e.ColumnIndex = 20 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(20), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "9" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 25, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # REPUESTOS (10)
        If e.ColumnIndex = 21 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(21), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "10" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 25, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # ARMADO (11)
        If e.ColumnIndex = 22 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(22), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "11" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 25, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # CONTROL METROLOGICO ARMADO (12)
        If e.ColumnIndex = 23 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(23), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "12" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 40, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # EVALUACION DE COMPONENTES ARMADO (13)
        If e.ColumnIndex = 24 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(24), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "13" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 40, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # REGISTRO FOTOGRAFICO ARMADO (14)
        If e.ColumnIndex = 25 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(25), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "14" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 40, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # REGISTRO DE AJUSTES ARMADO (15)
        If e.ColumnIndex = 26 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(26), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "15" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 30, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # PRUEBAS FINALES ARMADO (16)
        If e.ColumnIndex = 27 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(27), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "16" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 30, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # DESPACHO (17)
        If e.ColumnIndex = 28 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(28), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "17" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 25, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
        ' # EN RUTA (18)
        If e.ColumnIndex = 29 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celBoton As DataGridViewButtonCell = TryCast(Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(29), DataGridViewButtonCell)
            If Me.planificacion_dg_actual.Rows(e.RowIndex).Cells(11).Value >= "18" Then
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\ok_32.png")
            Else
                StatusValue = Image.FromFile(Environment.CurrentDirectory + "\Data\grafica\ico\no_32.png")
            End If
            e.Graphics.DrawImage(StatusValue, e.CellBounds.Left + 25, e.CellBounds.Top + 3)
            'Me.planificacion_dg_actual.Rows(e.RowIndex).Height = StatusValue.Height + 10
            'Me.planificacion_dg_actual.Columns(e.ColumnIndex).Width = StatusValue.Width + 10
            e.Handled = True
        End If
    End Sub
    Private Sub planificacion_tm_refresh_Tick(sender As Object, e As EventArgs) Handles planificacion_tm_refresh.Tick
        Call PGSQL_PLANIFICACION_LOADOT(planificacion_dg_actual)
    End Sub
    Private Sub planificacion_dg_asignacion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles planificacion_dg_asignacion.CellDoubleClick
        'MsgBox(Me.planificacion_dg_asignacion.Rows(e.RowIndex).Cells(0).Value)
        Dim frm_asigna_meca As New planificacion_atareas_mecanicos
        frm_asigna_meca.ShowInTaskbar = False
        frm_asigna_meca.ShowIcon = False
        frm_asigna_meca.MecOT = Me.planificacion_dg_asignacion.Rows(e.RowIndex).Cells(0).Value
        frm_asigna_meca.StartPosition = FormStartPosition.CenterScreen
        frm_asigna_meca.ShowDialog()
    End Sub
End Class