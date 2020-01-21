Public Class MainMenu

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        ProdutosReport.ShowDialog()

    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        Dim F As New Faturacao
        F.ShowDialog()

    End Sub

    Private Sub TestesToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Testes.ShowDialog()

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub FaturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaturaToolStripMenuItem.Click
        FaturaReport.ShowDialog()

    End Sub
End Class