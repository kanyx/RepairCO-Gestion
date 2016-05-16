Imports Npgsql
Module PGSQL_Reportes
    Public Function PGSQL_REPORTE_OT(ByVal NumeroOrden As String) As ArrayList
        Dim Retorno As New ArrayList
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                               ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                               ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                               ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                               ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPGSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT id, notrabajo, nguiadespacho, razonsocial, rut, nombretipo, nombremarca, nombremodelo, nserie, prioridad, numerocontrato, fecha_ingreso, nseriefabricante, nestado, tipo, noc, nagendamiento, nombres, apellido_p, apellido_m, dempresa, tag, ingernombre FROM vista_otreporte WHERE notrabajo=@nordentrabajo LIMIT 1"
            CommandPGSQL.Parameters.AddWithValue("@nordentrabajo", NumeroOrden)
            Dim dr = CommandPGSQL.ExecuteReader()
            dr.Read()
            Retorno.Add(dr(0).ToString) ' # id(0)
            Retorno.Add(dr(1).ToString) ' # numero orden(1)
            Retorno.Add(dr(2).ToString) ' # guia despacho(2)
            Retorno.Add(dr(3).ToString) ' # nombre cliente(3)
            Retorno.Add(dr(4).ToString) ' # rut cliente(4)
            Retorno.Add(dr(5).ToString) ' # nombre tipo(5)
            Retorno.Add(dr(6).ToString) ' # nombre marca(6)
            Retorno.Add(dr(7).ToString) ' # nombre modelo(7)
            Retorno.Add(dr(8).ToString) ' # numero serie(8)
            Retorno.Add(dr(9).ToString) ' # prioridad(9)
            Retorno.Add(dr(10).ToString) ' # numero contrato(10)
            Retorno.Add(dr(11).ToString) ' # fecha ingreso (11)
            Retorno.Add(dr(12).ToString) ' # numero serie fabricante (12)
            Retorno.Add(dr(13).ToString) ' # estado orden de tabajo (13)
            Retorno.Add(dr(14).ToString) ' # tipo orden de trabajo (1 = Reparacion / 2 = Garantia) (14)
            Retorno.Add(dr(15).ToString) ' # orden de compra (15)
            Retorno.Add(dr(16).ToString) ' # agendamiento (generalmente usado por MEL) (16)
            Retorno.Add(dr(17).ToString & " " & dr(18).ToString & " " & dr(19).ToString) ' # nombre responsable orden de trabajo (17)
            Retorno.Add(dr(20).ToString) ' # direccion de empresa. (18)
            Retorno.Add(dr(21).ToString) ' # identificacion del equipo. (19)
            Retorno.Add(dr(22).ToString) ' # ingeniero reparable. (20)
            ConexPGSQL.Close()
            Return Retorno
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar la orden de trabajo al momento de generar un reporte, por favor vuelva a intentarlo, si el problema persiste contacte al equipo de desarrollo." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Retorno.Add("ERROR.!")
            Return Retorno
        End Try
    End Function
End Module
