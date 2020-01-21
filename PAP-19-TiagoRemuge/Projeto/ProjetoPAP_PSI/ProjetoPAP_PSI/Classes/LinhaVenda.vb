Public Class LinhaVenda
    Public CodProduto, CodVenda, Quantidade As Integer

    Public DS As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
    Public DT As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.LinhaVendaDataTable
    Public TA As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.LinhaVendaTableAdapter
    Public DTLC As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.LinhaContaDataTable
    Public TALC As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.LinhaContaTableAdapter

    Public Sub New()
        TA.Fill(DT)

    End Sub

    Public Sub PassarLinhas(CodVenda As Integer, CodConta As Integer)
        TALC.FillByCodConta(DTLC, CodConta)
        For i = 1 To DTLC.Count
            TA.Insert(DTLC.Item(i - 1).Item("CodProduto"), CodVenda, DTLC.Item(i - 1).Item("Quantidade"))

        Next
    End Sub

    Public Function InserirLinha(CodProduto As Integer, CodVenda As Integer, Quantidade As Integer) As Integer
        Me.CodProduto = CodProduto
        Me.CodVenda = CodVenda
        Me.Quantidade = Quantidade

        Return Me.TA.Insert(CodProduto, CodVenda, Quantidade)
    End Function
End Class