Public Class Produto
    Public CodProduto, Quantidade As Integer
    Public Preco As Decimal
    Public Nome, TipoProduto As String

    Public DS As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
    Public DT As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.ProdutoDataTable
    Public TA As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.ProdutoTableAdapter

    Public Sub New(CodProduto As Integer)
        TA.FillBy(DT, CodProduto)
        Me.CodProduto = CodProduto
        Quantidade = DT.Item(0).Item("Quantidade")
        Preco = DT.Item(0).Item("Preço")
        Nome = DT.Item(0).Item("Nome")
        TipoProduto = DT.Item(0).Item("TipoProduto")

    End Sub

    Public Function AtualizarStock(CodProduto, Quantidade) As Integer
        TA.FillBy(DT, CodProduto)

        Return TA.UpdateQuantidade(DT.Item(0).Item("Quantidade") - Quantidade, CodProduto)
    End Function

    Public Function CodTipoProduto(CodProduto) As String
        TA.FillBy(DT, CodProduto)
        Dim TP As String
        TP = DT.Item(0).Item("TipoProduto")

        Return TP
    End Function

    Public Sub New()

    End Sub
End Class
