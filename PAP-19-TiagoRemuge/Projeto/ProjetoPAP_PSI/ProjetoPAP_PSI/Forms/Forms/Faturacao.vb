
Public Class Faturacao
    Public NIF As String
    Private WithEvents NovoBotao As New System.Windows.Forms.Button()
    Public x As Integer
    Public y As String
    Private K As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = DateAndTime.Now

    End Sub

    Private Sub Registar_Click(sender As Object, e As EventArgs) Handles Registar.Click
        Dim DS As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
        Dim DT As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.LinhaContaDataTable
        Dim TA As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.LinhaContaTableAdapter
        TA.Fill(DT)
        PassarParaVenda()
        Dim C As New Conta
        C.AtualizarEstado(MesaComboBox.SelectedValue, False)
        ProdutosFlowLayoutPanel.Enabled = False
        AtualizaLabels()

    End Sub

    Public Sub PedirNIF()
        Dim MB As New MsgBoxNIF
        MB.ShowDialog()

        If MB.MsgBox = 1 Then
            'TA.Insert(MesaComboBox.SelectedValue, ListView1.Items)

        ElseIf MB.MsgBox = 2 Then
            NIF = "Consumidor Final"

        ElseIf MB.MsgBox = 0 Then
        End If
    End Sub

    Public Sub PassarParaVenda()
        Dim V As New Venda
        Dim CVenda As Integer
        Dim CB As Integer = MesaComboBox.SelectedValue
        CVenda = V.CriarVenda(CB)

        Dim LV As New LinhaVenda
        LV.PassarLinhas(CVenda, CB)

        Dim LC As New LinhaConta
        LC.EliminarLinhas(CB)

        ListView1.Items.Clear()

    End Sub

    Public Function CreateButton(x As Integer, y As String)
        NovoBotao = New System.Windows.Forms.Button()
        AddHandler NovoBotao.Click, AddressOf AdicionarProduto
        NovoBotao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        NovoBotao.FlatAppearance.BorderSize = 0
        NovoBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        NovoBotao.Font = New System.Drawing.Font("Rancho", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NovoBotao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        'NovoBotao.Location = New System.Drawing.Point(0,0)
        NovoBotao.Size = New System.Drawing.Size(76, 76)
        'NovoBotao.TabIndex = 3
        NovoBotao.Text = y
        NovoBotao.UseVisualStyleBackColor = False
        NovoBotao.Name = x
        Me.x = x

        Return NovoBotao
    End Function

    Public Sub AdicionarProduto(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim n As Integer
        Me.NovoBotao = CType(sender, Button)
        n = NovoBotao.Name
        AdicionarProdutoLV()

    End Sub

    Public Sub AdicionarProdutoLV()
        Dim P As New Produto(Me.NovoBotao.Name)
        Dim item As New ListViewItem
        Dim n As Integer
        Dim s As String
        Dim LC As New LinhaConta

        If ListView1.Items.Count = 0 Then
            'Lista de produto está vazia
            AdicionaNovoProduto(P)

        Else
            Dim flag As Boolean = False

            'Verifica se é um novo item ou se adiciona quantidade a um item já existente
            For Each item In ListView1.Items
                'MsgBox(item.Text)
                If (item.Text) = P.CodProduto Then
                    s = item.SubItems.Item(2).Text
                    n = CInt(s) + 1
                    item.SubItems.Item(2).Text = CStr(n)
                    item.SubItems.Item(3).Text = CStr(n * P.Preco)
                    LC.TA.UpdateQuantidade(n, CInt(MesaComboBox.SelectedValue), P.CodProduto)
                    P.AtualizarStock(P.CodProduto, 1)
                    AtualizaLabels()
                    n = 0
                    flag = True

                    Exit For
                End If
            Next

            If Not flag Then
                'Produto ainda não consta da lista
                AdicionaNovoProduto(P)

            End If
        End If
    End Sub

    Public Sub AdicionaNovoProduto(P As Produto)
        Dim LC As New LinhaConta
        Dim item As New ListViewItem
        item = ListView1.Items.Add(P.CodProduto)
        item.SubItems.Add(P.Nome)
        item.SubItems.Add(1)
        item.SubItems.Add(P.Preco)
        LC.InserirLinha(Me.MesaComboBox.SelectedValue, P.CodProduto, 1)
        P.AtualizarStock(P.CodProduto, 1)
        AtualizaLabels()

    End Sub

    Public Sub Faturacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.Mesa' table. You can move, or remove it, as needed.
        Me.MesaTableAdapter.Fill(Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.Mesa)
        'TODO: This line of code loads data into the 'Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.Sala' table. You can move, or remove it, as needed.
        Me.SalaTableAdapter.Fill(Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.Sala)

        Dim ProdTA As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.ProdutoTableAdapter
        ProdTA.Fill(Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.Produto)

        If K = False Then
            For i = 1 To Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.Produto.Count Step 1
                Me.ProdutosFlowLayoutPanel.Controls.Add(CreateButton(Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.Produto.Item(i - 1).Item("CodProduto"), Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.Produto.Item(i - 1).Item("Nome")))

            Next
            K = True

        ElseIf K = True Then
        End If

        AtualizaLabels()
        ProdutosFlowLayoutPanel.Enabled = False
        MesaBindingSource.Filter = "CodSala= " & SalaComboBox.SelectedValue

        Dim P As New Produto
        For i = 0 To ProdutosFlowLayoutPanel.Controls.Count - 1
            If P.CodTipoProduto(ProdutosFlowLayoutPanel.Controls(i).Name) = "Café" Then
                ProdutosFlowLayoutPanel.Controls.Item(i).Visible = True

            Else
                ProdutosFlowLayoutPanel.Controls.Item(i).Visible = False

            End If
        Next
        Cafetaria.Enabled = False
        Empregado.Text = "ColdFire"
    End Sub

    Private Sub AtualizaLabels()
        Dim TotalQuantidade As Integer = 0
        Dim Total As Decimal = 0

        For c = 0 To ListView1.Items.Count - 1
            TotalQuantidade = TotalQuantidade + CInt(Me.ListView1.Items.Item(c).SubItems.Item(2).Text)
            Total = Total + CDec(Me.ListView1.Items.Item(c).SubItems.Item(3).Text)

        Next
        Me.PanelTotalQtdProdutos.Text = ListView1.Items.Count
        Me.PanelTotalQtdUnidades.Text = CStr(TotalQuantidade)
        Me.Total.Text = CStr(Total)

    End Sub

    Private Sub Sair_Click(sender As Object, e As EventArgs) Handles Sair.Click
        Me.Close()

    End Sub

    Private Sub SalaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SalaComboBox.SelectedIndexChanged
        MesaBindingSource.Filter = "CodSala= " & SalaComboBox.SelectedValue

    End Sub

    Private Sub AdicionarConta_Click(sender As Object, e As EventArgs) Handles AdicionarConta.Click
        'Dim DT As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.ContaDataTable
        'Dim TA As New Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.ContaTableAdapter
        'TA.Fill(dt)
        'TA.Insert(Now, "Ocupada", CInt(MesaComboBox.SelectedValue))
        Dim C As New Conta
        'cConta = C.CriarConta(CInt(MesaComboBox.SelectedValue))
        C.AtualizarConta(MesaComboBox.SelectedValue, Now.Date, True)
        ProdutosFlowLayoutPanel.Enabled = True

    End Sub

    Private Sub MesaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MesaComboBox.SelectedIndexChanged
        Dim C As New Conta
        Dim LC As New LinhaConta
        Dim P As New Produto
        Dim M As Integer = MesaComboBox.SelectedValue
        Me.ListView1.Items.Clear()

        If C.DT.Item(M - 1).Item("Estado") = True Then
            LC.TA.FillByCodConta(LC.DT, M)

            For i = 1 To LC.DT.Rows.Count
                P.TA.FillBy(P.DT, LC.DT.Item(i - 1).Item("CodProduto"))

                Dim item As New ListViewItem
                item = ListView1.Items.Add(MesaComboBox.SelectedValue)
                item.SubItems.Add(P.DT.Item(i - 1).Item("Nome"))
                item.SubItems.Add(LC.DT.Item(i - 1).Item("Quantidade"))
                item.SubItems.Add(P.DT.Item(i - 1).Item("Preço"))

            Next
            ProdutosFlowLayoutPanel.Enabled = True

        Else
            ProdutosFlowLayoutPanel.Enabled = False

        End If

        AtualizaLabels()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MesaComboBox.SelectedValue = MesaComboBox.SelectedValue - 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MesaComboBox.SelectedValue = MesaComboBox.SelectedValue + 1

    End Sub

    Private Sub Cafetaria_Click(sender As Object, e As EventArgs) Handles Cafetaria.Click
        Pastelaria.Enabled = True
        Refrigerantes.Enabled = True
        Cafetaria.Enabled = False
        Dim P As New Produto

        For i = 0 To ProdutosFlowLayoutPanel.Controls.Count - 1
            If P.CodTipoProduto(ProdutosFlowLayoutPanel.Controls(i).Name) = "Café" Then
                ProdutosFlowLayoutPanel.Controls.Item(i).Visible = True

            Else
                ProdutosFlowLayoutPanel.Controls.Item(i).Visible = False

            End If
        Next
    End Sub

    Private Sub Pastelaria_Click(sender As Object, e As EventArgs) Handles Pastelaria.Click
        Cafetaria.Enabled = True
        Refrigerantes.Enabled = True
        Pastelaria.Enabled = False
        Dim P As New Produto

        For i = 0 To ProdutosFlowLayoutPanel.Controls.Count - 1
            If P.CodTipoProduto(ProdutosFlowLayoutPanel.Controls(i).Name) = "Bolo" Then
                ProdutosFlowLayoutPanel.Controls.Item(i).Visible = True

            Else
                ProdutosFlowLayoutPanel.Controls.Item(i).Visible = False

            End If
        Next
    End Sub
End Class