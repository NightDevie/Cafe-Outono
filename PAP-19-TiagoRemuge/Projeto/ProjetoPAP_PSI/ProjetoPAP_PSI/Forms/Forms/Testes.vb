Public Class Testes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As New ListViewItem
        Dim a As Integer = 1
        Dim P As New Produto
        i = ListView1.Items.Add(P.CodProduto)
        i.SubItems.Add("2")
        i.SubItems.Add("3")
        i.SubItems.Add("4")
    End Sub
End Class