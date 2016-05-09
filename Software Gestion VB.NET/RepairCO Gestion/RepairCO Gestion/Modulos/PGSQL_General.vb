﻿Imports Npgsql
Module PGSQL_General
    ' # Modulo de funciones generales para realizar comprobaciones e interactuar de forma basica con el servidor PostgreSQL
    Dim ConextionString As String = "" ' # Cadena de conexion para PostgreSQL.
    Private ConnectorPGSQL As NpgsqlConnection
    Private CommandPGSQL As NpgsqlCommand
    Function PGSQL_ProbarConexion(ByVal Server As String, ByVal Port As String, ByVal Username As String, _
                                  ByVal Password As String, ByVal NameBD As String) As Boolean
        Try
            Dim Resultado As ArrayList
            ConnectorPGSQL = New NpgsqlConnection("Host=" & Server & ";Port= " & Port & " ;Username=" & Username & ";Password=" & Password & _
                                                  ";Database=" & NameBD)
            ConnectorPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConnectorPGSQL
            CommandPGSQL.CommandText = "SELECT * FROM personal LIMIT 2"
            Dim rd = CommandPGSQL.ExecuteReader()
            Resultado = New ArrayList
            While rd.Read()
                Resultado.Add(rd.Item(1))
            End While
            If Resultado.Count <= 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("PostgreSQL: Ocurrio un error en la conexion con el servidor PostgreSQL, el mensaje de error " _
                            & " generado por este problema es el siguiente: " & vbNewLine & ex.ToString)
            Return False
        End Try
    End Function
    Public Sub PGSQL_CargaClientes()
        ' # CARGA AL INICIAR MAINAPPLICATION
    End Sub
    Public Sub PGSQL_CargaTipos()
        ' # CARGA AL INICIAR MAINAPPLICATION
        Try
            ConnectorPGSQL = New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                  ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                  ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                  ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                  ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConnectorPGSQL.Open()
            CommandPGSQL = New NpgsqlCommand
            CommandPGSQL.Connection = ConnectorPGSQL
            CommandPGSQL.CommandText = "SELECT id, nombre FROM tipos_productos"
            Dim rd = CommandPGSQL.ExecuteReader
            If rd.HasRows = False Then
                Exit Sub
            End If
            _globalTipos = New List(Of KeyValuePair(Of String, String))
            While rd.Read
                _globalTipos.Add(New KeyValuePair(Of String, String)(rd.Item("id"), rd.Item("nombre").ToString))
            End While
            ConnectorPGSQL.Close()
        Catch ex As Exception
            ' # CREAR SISTEMA DE LOGEO DE OPERACIONES EN LOCAL (OUTPUT.LOG)
            ConnectorPGSQL.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub PGSQL_CargaMarcas(ByVal IdTipo As String)
        Try
            ' # CARGA CUANDO SE SELECCION UN TIPO
            Dim ConexPGSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPGSQL.Open()
            Dim CommPGSQL As New NpgsqlCommand
            CommPGSQL.Connection = ConexPGSQL
            CommPGSQL.CommandType = CommandType.Text
            CommPGSQL.CommandText = "SELECT id, nombre FROM marcas WHERE idtipo=@tipo"
            CommPGSQL.Parameters.AddWithValue("@tipo", Integer.Parse(IdTipo))
            Dim rd = CommPGSQL.ExecuteReader
            If rd.HasRows = False Then
                Exit Sub
            End If
            _globalMarcas = New List(Of KeyValuePair(Of String, String))
            While rd.Read
                _globalMarcas.Add(New KeyValuePair(Of String, String)(rd.Item("id"), rd.Item("nombre").ToString))
            End While
            ConexPGSQL.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al cargar la lista de marcas desde la base de datos." & vbNewLine & vbNewLine & _
                            "[DETALLE DEL ERROR]" & vbNewLine & ex.ToString, Application.ProductName & " - " & Application.ProductVersion, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub PGSQL_CargaModelos()
        ' # CARGA CUANDO SE SELECCIONA UNA MARCA
    End Sub
    Public Sub PGSQL_CargaEstados()
        ' # CARGA AL INICIAR MAINAPPLICATION
    End Sub
    Public Sub PGSQL_CargaPais()
        ' # CARGA SOLO ON-DEMAND EN ALGUNOS FORMULARIOS (POR EJEMPLO AÑADIR MARCA).
        Try
            Dim ConexPostgreSQL As New NpgsqlConnection("Host=" & main_loggin.ParametrosConfiguracion(0).ToString & _
                                                  ";Port=" & main_loggin.ParametrosConfiguracion(1).ToString & _
                                                  ";Username=" & main_loggin.ParametrosConfiguracion(2).ToString & _
                                                  ";Password=" & main_loggin.ParametrosConfiguracion(3).ToString & _
                                                  ";Database=" & main_loggin.ParametrosConfiguracion(4).ToString)
            ConexPostgreSQL.Open()
            Dim CommandPGSQL As New NpgsqlCommand
            CommandPGSQL.Connection = ConexPostgreSQL
            CommandPGSQL.CommandText = "SELECT id, nombre FROM paises"
            Dim dr = CommandPGSQL.ExecuteReader
            If dr.HasRows = False Then
                Exit Sub
            End If
            _globalPaises = New List(Of KeyValuePair(Of String, String))
            While dr.Read
                _globalPaises.Add(New KeyValuePair(Of String, String)(dr.Item("id"), dr.Item("nombre").ToString))
            End While
            ConexPostgreSQL.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al momento de cargar la lista de países desde la base de datos." & _
                            vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & ex.ToString, _
                            Application.ProductName & " - " & Application.ProductVersion, MessageBoxButtons.OK)
        End Try
    End Sub
End Module
