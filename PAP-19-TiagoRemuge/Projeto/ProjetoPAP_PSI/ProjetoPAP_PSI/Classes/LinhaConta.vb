Public Class LinhaConta
    Public CodConta, CodProduto, Quantidade As Integer

    Public DS As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
    Public DT As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.LinhaContaDataTable
    Public TA As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.LinhaContaTableAdapter

    Public Sub New()
        TA.Fill(DT)

    End Sub

    Public Sub EliminarLinhas(CodConta As Integer)
        TA.FillByCodConta(DT, CodConta)
        For i = 1 To DT.Count
            TA.Delete(DT.Item(i - 1).Item("CodConta"), DT.Item(i - 1).Item("CodProduto"), DT.Item(i - 1).Item("Quantidade"))

        Next
    End Sub

    Public Function InserirLinha(CodConta As Integer, CodProduto As Integer, Quantidade As Integer) As Integer
        Me.CodConta = CodConta
        Me.CodProduto = CodProduto
        Me.Quantidade = Quantidade

        Return Me.TA.Insert(CodConta, CodProduto, Quantidade)
    End Function
End Class
