'Public Class Code
'    Dim f As New Fatura
'    f.dock=dockstyle.fill
'    fatura.size=(302;256)
'    panel.location=(12; 12)
'    rowheaderclick / rowheaderdoubleclick
'    showdialog

'Public Sub AdicionarProduto(sender As Object, e As EventArgs) Handles NovoBotao.Click

'End Sub

'taConta.fillByID(ID)
'taVenda.insert(dtConta.item(0).item("Oq tem nas tabelas"))

'Public Function adicionarfatura(cod_cliente As Integer) As Integer
'    Dim query As String = "INSERT INTO `Fatura` (`Data_fatura`, `Cod_cliente_fac`, `Cod_funcionario`) VALUES (@data_fatura, @Cod_cliente_fac, @Cod_funcionario);"
'    Dim query2 As String = "Select @@Identity"
'    Dim connect As String = My.Settings.BasededadosCactusConnectionString
'    Dim conn As New System.Data.OleDb.OleDbConnection(connect)
'    Dim cmd As New System.Data.OleDb.OleDbCommand(query, conn)
'    cmd.Parameters.AddWithValue("data_fatura", Now.Date)
'    cmd.Parameters.AddWithValue("Cod_cliente", cod_cliente)
'    cmd.Parameters.AddWithValue("Cod_funcionario", 2)
'    conn.Open()
'    cmd.ExecuteNonQuery()
'    cmd.CommandText = query2
'    adicionarfatura = cmd.ExecuteScalar()
'End Function

'End Class