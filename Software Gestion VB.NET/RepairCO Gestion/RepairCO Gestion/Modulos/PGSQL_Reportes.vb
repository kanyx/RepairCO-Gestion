Imports Npgsql
Module PGSQL_Reportes
    Function PGSQL_REPORTE_OT(ByVal NumeroOrden As String) As ArrayList
        Try
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                               ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                               ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                               ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                               ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPGSQL
            CommandPGSQL.CommandType = CommandType.Text
            CommandPGSQL.CommandText = "SELECT id, notrabajo, nguiadespacho, idcliente, idtipo, idmarca, idmodelo, idrespingreso, nserie, prioridad, numerocontrato, fecha_ingreso, nseriefabricante, tipo, noc, nagendamiento FROM ordenestrabajo WHERE notrabajo=@nordentrabajo LIMIT 1"
            CommandPGSQL.Parameters.AddWithValue("@nordentrabajo", NumeroOrden)
            Dim dr = CommandPGSQL.ExecuteReader()
            Dim Retorno As New ArrayList
            dr.Read()
            Retorno.Add(dr("id").ToString)
            Retorno.Add(dr("notrabajo").ToString)
            Retorno.Add(dr("nguiadespacho").ToString)
            Retorno.Add(dr("idcliente").ToString)

        Catch ex As Exception

        End Try
    End Function
End Module
