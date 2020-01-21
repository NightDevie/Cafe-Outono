Public Class Funcionario
    Public CodFuncionario As Integer
    Public Nome, NomeUtilizador, Password, Funcao As String

    Public DS As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
    Public DT As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.FuncionárioDataTable
    Public TA As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.FuncionárioTableAdapter

    Public Sub New()

    End Sub

    Public Sub Login(NU As String, PW As String)
        Dim x As Integer
        x = TA.FillByNomeUtilizador(DT, NU)

        If x = 0 Then
            MsgBox("Utilizador não existe!", MsgBoxStyle.Critical, "Erro")

        Else
            NomeUtilizador = NU
            Password = DT.Item(0).Item("Password")

            If PW = Password Then
                CodFuncionario = DT.Item(0).Item("CodFuncionário")
                Nome = DT.Item(0).Item("Nome")
                Funcao = DT.Item(0).Item("CodFunção")
                SignIn.Hide()
                Dim MM As New MainMenu
                MM.ShowDialog()

            Else
                MsgBox("Password incorreta!", MsgBoxStyle.Critical, "Erro")

            End If
        End If
    End Sub
End Class