Public Class Venda
    Public CodVenda, CodFuncionario, CodSala As Integer

    Public DS As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
    Public DT As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.VendaDataTable
    Public TA As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.VendaTableAdapter

    Public Sub New()
        TA.Fill(DT)
    End Sub

    Public Function CriarVenda(CodMesa As Integer) As Integer
        '  TA.LinhaVenda.Insert(CodVendaCriadaAtras, TodosOsOutrosCamposDaLinhaConta)

        Dim Query As String = "INSERT INTO `Venda` (`CodMesa`, `Data`) VALUES (@CodMesa, @Data);"
        Dim Query2 As String = "Select @@Identity"
        Dim Connect As String = My.Settings.GestãoStockFaturaçãoCaféConnectionString
        Dim Conn As New System.Data.OleDb.OleDbConnection(Connect)
        Dim Cmd As New System.Data.OleDb.OleDbCommand(Query, Conn)

        Cmd.Parameters.AddWithValue("CodMesa", CodMesa)
        Cmd.Parameters.AddWithValue("Data", Now.Date)

        Conn.Open()

        Cmd.ExecuteNonQuery()
        Cmd.CommandText = Query2

        Return Cmd.ExecuteScalar()
    End Function
End Class
