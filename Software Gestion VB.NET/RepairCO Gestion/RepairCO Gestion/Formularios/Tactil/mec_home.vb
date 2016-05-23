Public Class mec_home
    Private MecAuthClose As Boolean = False
    Private Sub mec_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGAMOS LAS IMAGEMES DEL FORMULARIO.
        Me.mechome_pic_otasignadas.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/meca/dash_home_wotasign.png")
        Me.mechome_pic_icot.Image = Image.FromFile(Application.StartupPath & "/Data/grafica/ico/desarme.png")
        ' # ESTABLECEMOS PARAMETROS A LOS CONTROLES.
        Me.mechome_pic_otasignadas.BackColor = Color.Transparent
        Me.mechome_pic_icot.BackColor = Color.Transparent
        Me.mechome_pic_icot.SizeMode = PictureBoxSizeMode.StretchImage
        Me.mechome_dg_ot.EnableHeadersVisualStyles = False
        ' # CARGAMOS DATA A LOS CONTROLES.
        Call PGSQL_TACTIL_LOADOT(mec_dashboard.MecStationID, Me.mechome_dg_ot) ' # CARGAMOS LAS OT DESDE LA BASE DE DATOS.
        ' # DISEÑAMOS EL DATAGRIDVIEW LISTA DE OT'S
        Me.mechome_dg_ot.Columns("idmechanicstation").Visible = False
        Me.mechome_dg_ot.Columns("notrabajo").HeaderText = "N° OT"
        Me.mechome_dg_ot.Columns("nombretipo").HeaderText = "PRODUCTO"
        Me.mechome_dg_ot.Columns("equipo").HeaderText = "EQUIPO"
        Me.mechome_dg_ot.Columns("estsadoid").Visible = False
        Me.mechome_dg_ot.Columns("estadonombre").HeaderText = "ESTADO OT"
        Me.mechome_dg_ot.Columns("idtipo").Visible = False
        Me.mechome_dg_ot.ColumnHeadersHeight = 60
        Me.mechome_dg_ot.RowTemplate.Height = 100
        Me.mechome_dg_ot.Columns("notrabajo").Width = 100
        Me.mechome_dg_ot.Columns("nombretipo").Width = 180
        Me.mechome_dg_ot.Columns("equipo").Width = 458
        Me.mechome_dg_ot.Columns("estadonombre").Width = 206
        Me.mechome_dg_ot.Columns("notrabajo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.mechome_dg_ot.ReadOnly = True
        Me.mechome_dg_ot.RowHeadersVisible = False
        Me.mechome_dg_ot.AllowUserToAddRows = False
        Me.mechome_dg_ot.AllowUserToResizeColumns = False
        Me.mechome_dg_ot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.mechome_dg_ot.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 20)
        Me.mechome_dg_ot.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 17)
        Me.mechome_dg_ot.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ff9001")
        Me.mechome_dg_ot.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#ffffff")
    End Sub
    Private Sub mec_home_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' # COMPROBAMOS QUE EL USUARIO PRESIONE CTRL + ALT + R PARA SETEAR LA CORRECTA FINALIZACION DE LA APLICACION.
        If e.Control And e.Alt And e.KeyCode = Keys.R Then
            If MessageBox.Show("¿Desea cerrar la estacion de trabajo.?", Application.ProductName & " - " & Application.ProductVersion, _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MecAuthClose = True
                Me.Close()
                main_loggin.Close()
            End If
        End If
    End Sub
    Private Sub mec_home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.MecAuthClose = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub mechome_dg_ot_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles mechome_dg_ot.CellDoubleClick
        ' # RegistroSeleccionado.Cells(4).Value = ID ESTADO DE LA ORDEN DE TRABAJO.
        ' # RegistroSeleccionado.Cells(6).Value = ID TIPO DE PRODUCTO.
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            mec_dashboard.mecdash_pn_content.Refresh()
            Dim RegistroSeleccionado = Me.mechome_dg_ot.Rows(e.RowIndex)
            If RegistroSeleccionado.Cells(4).Value = 1 Or RegistroSeleccionado.Cells(4).Value = 2 Then
                ' # CARGAMOS VISTA DE DESARME DE LA ORDEN.
                Dim frm_desarme As New mec_desarme
                frm_desarme.TopLevel = False
                frm_desarme.MecDesaOT = RegistroSeleccionado.Cells(0).Value
                frm_desarme.MecTipoProducto = RegistroSeleccionado.Cells(6).Value
                frm_desarme.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                frm_desarme.Dock = DockStyle.Fill
                mec_dashboard.mecdash_pn_content.Controls.Remove(Me)
                mec_dashboard.mecdash_pn_content.Controls.Add(frm_desarme)
                frm_desarme.Show()
            End If
            Me.Close()
        End If
    End Sub
End Class