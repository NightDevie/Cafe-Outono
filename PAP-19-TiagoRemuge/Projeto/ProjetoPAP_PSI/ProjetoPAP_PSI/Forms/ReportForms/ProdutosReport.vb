Public Class ProdutosReport
    Private Sub ProdutosReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.Produto' table. You can move, or remove it, as needed.
        Me.ProdutoTableAdapter.Fill(Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.Produto)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Sair_Click(sender As Object, e As EventArgs) Handles Sair.Click
        Me.Close()

    End Sub
End Class