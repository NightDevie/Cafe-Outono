Public Class MsgBoxNIF
    Public MsgBox As Integer

    Private Sub Sim_Click(sender As Object, e As EventArgs) Handles Sim.Click
        MsgBox = 1
        Panel1.Visible = False
        NIF.Visible = True
        OK.Visible = True

    End Sub

    Private Sub Não_Click(sender As Object, e As EventArgs) Handles Não.Click
        MsgBox = 2
        Me.Close()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        MsgBox = 0
        Me.Close()

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim X As New Faturacao
        X.NIF = Me.NIF.Text
        Me.Close()

    End Sub
End Class