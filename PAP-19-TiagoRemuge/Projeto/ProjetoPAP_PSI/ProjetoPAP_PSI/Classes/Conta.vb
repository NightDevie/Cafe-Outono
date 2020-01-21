Public Class Conta
    Public CodConta, CodMesa As Integer
    Public Data As Date
    Public Estado As Boolean

    Public DS As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
    Public DT As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.ContaDataTable
    Public TA As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.ContaTableAdapter

    Public Sub New()
        TA.Fill(DT)

    End Sub

    Public Function AdicionarConta(Data As Date, Estado As String, CodConta As Integer) As Integer
        Me.CodConta = CodConta
        Me.CodMesa = CodMesa
        Me.Data = Data

        Return Me.TA.Insert(Data, CodMesa, CodConta, Estado)
    End Function

    Public Sub AtualizarConta(CodMesa As Integer, Data As Date, Estado As Boolean)
        TA.FillByCodConta(DT, CodMesa)
        Me.Data = DT.Item(0).Item("Data")
        Me.Estado = DT.Item(0).Item("Estado")
        Me.CodConta = DT.Item(0).Item("CodConta")
        Me.CodMesa = DT.Item(0).Item("CodMesa")

        Me.TA.Update(Data, Me.CodMesa, Estado, Me.Data, Me.CodMesa, Me.CodConta, Me.Estado)
    End Sub

    Public Function AtualizarEstado(CodConta As Integer, Estado As Boolean) As Integer
        TA.FillByCodConta(DT, CodConta)

        Return TA.UpdateEstado(Estado, CodConta)
    End Function

    Public Function CriarConta(CodMesa As Integer) As Integer
        '  TA.LinhaVenda.Insert(CodVendaCriadaAtras, TodosOsOutrosCamposDaLinhaConta)

        Dim Query As String = "INSERT INTO `Conta` (`Data`, `Estado`, `CodMesa` ) VALUES (@Data, @Estado ,@CodMesa);"
        Dim Query2 As String = "Select @@Identity"
        Dim Connect As String = My.Settings.GestãoStockFaturaçãoCaféConnectionString
        Dim Conn As New System.Data.OleDb.OleDbConnection(Connect)
        Dim Cmd As New System.Data.OleDb.OleDbCommand(Query, Conn)

        Cmd.Parameters.AddWithValue("Data", Now.Date)
        Cmd.Parameters.AddWithValue("Estado", "Ocupada")
        Cmd.Parameters.AddWithValue("CodMesa", CodMesa)

        Conn.Open()

        Cmd.ExecuteNonQuery()
        Cmd.CommandText = Query2

        Return Cmd.ExecuteScalar()
    End Function
End Class
