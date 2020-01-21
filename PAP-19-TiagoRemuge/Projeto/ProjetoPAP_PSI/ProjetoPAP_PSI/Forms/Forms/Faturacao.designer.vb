<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Faturacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faturacao))
        Me.Registar = New System.Windows.Forms.Button()
        Me.Opções = New System.Windows.Forms.Button()
        Me.ProdutosPanel = New System.Windows.Forms.Panel()
        Me.ProdutosFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelProdutos1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelSala = New System.Windows.Forms.Panel()
        Me.SalaComboBox = New System.Windows.Forms.ComboBox()
        Me.MesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet = New ProjetoPAP_PSI.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet()
        Me.SalaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelTipoProduto = New System.Windows.Forms.Panel()
        Me.Sandes = New System.Windows.Forms.Button()
        Me.Salgados = New System.Windows.Forms.Button()
        Me.Guloseimas = New System.Windows.Forms.Button()
        Me.Gelataria = New System.Windows.Forms.Button()
        Me.Grill = New System.Windows.Forms.Button()
        Me.Cervejaria = New System.Windows.Forms.Button()
        Me.Refrigerantes = New System.Windows.Forms.Button()
        Me.Pastelaria = New System.Windows.Forms.Button()
        Me.Cafetaria = New System.Windows.Forms.Button()
        Me.PanelProdutos3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelItemsFatura = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Cod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Produto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Qtd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Preço = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Empregado = New System.Windows.Forms.Label()
        Me.PanelTotal = New System.Windows.Forms.Panel()
        Me.PanelTotalEuro = New System.Windows.Forms.Label()
        Me.PanelTotalUnidades = New System.Windows.Forms.Label()
        Me.PanelTotalProdutos = New System.Windows.Forms.Label()
        Me.PanelTotalQtdUnidades = New System.Windows.Forms.Label()
        Me.PanelTotalQtdProdutos = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.PanelTotalTotal = New System.Windows.Forms.Label()
        Me.Mesa = New System.Windows.Forms.Label()
        Me.PanelQuantidade = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelPreco = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MesaComboBox = New System.Windows.Forms.ComboBox()
        Me.SalaTableAdapter = New ProjetoPAP_PSI.Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.SalaTableAdapter()
        Me.MesaTableAdapter = New ProjetoPAP_PSI.Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.MesaTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AdicionarConta = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sair = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProdutosPanel.SuspendLayout()
        Me.PanelProdutos1.SuspendLayout()
        Me.PanelSala.SuspendLayout()
        CType(Me.MesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTipoProduto.SuspendLayout()
        Me.PanelProdutos3.SuspendLayout()
        Me.PanelItemsFatura.SuspendLayout()
        Me.PanelTotal.SuspendLayout()
        Me.PanelQuantidade.SuspendLayout()
        Me.PanelPreco.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Registar
        '
        Me.Registar.AutoSize = True
        Me.Registar.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Registar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Registar.FlatAppearance.BorderSize = 0
        Me.Registar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Registar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Registar.Font = New System.Drawing.Font("Rancho", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registar.ForeColor = System.Drawing.Color.White
        Me.Registar.Location = New System.Drawing.Point(829, 713)
        Me.Registar.Name = "Registar"
        Me.Registar.Size = New System.Drawing.Size(190, 51)
        Me.Registar.TabIndex = 1
        Me.Registar.Text = "Registar"
        Me.Registar.UseVisualStyleBackColor = False
        '
        'Opções
        '
        Me.Opções.AutoSize = True
        Me.Opções.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Opções.Enabled = False
        Me.Opções.FlatAppearance.BorderSize = 0
        Me.Opções.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Opções.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Opções.Font = New System.Drawing.Font("Rancho", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opções.ForeColor = System.Drawing.Color.White
        Me.Opções.Location = New System.Drawing.Point(709, 713)
        Me.Opções.Name = "Opções"
        Me.Opções.Size = New System.Drawing.Size(119, 51)
        Me.Opções.TabIndex = 0
        Me.Opções.Text = "Opções"
        Me.Opções.UseVisualStyleBackColor = False
        '
        'ProdutosPanel
        '
        Me.ProdutosPanel.BackColor = System.Drawing.Color.White
        Me.ProdutosPanel.Controls.Add(Me.ProdutosFlowLayoutPanel)
        Me.ProdutosPanel.Location = New System.Drawing.Point(133, 129)
        Me.ProdutosPanel.Name = "ProdutosPanel"
        Me.ProdutosPanel.Size = New System.Drawing.Size(574, 635)
        Me.ProdutosPanel.TabIndex = 3
        '
        'ProdutosFlowLayoutPanel
        '
        Me.ProdutosFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ProdutosFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdutosFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ProdutosFlowLayoutPanel.Name = "ProdutosFlowLayoutPanel"
        Me.ProdutosFlowLayoutPanel.Size = New System.Drawing.Size(574, 635)
        Me.ProdutosFlowLayoutPanel.TabIndex = 12
        '
        'PanelProdutos1
        '
        Me.PanelProdutos1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.PanelProdutos1.Controls.Add(Me.Label4)
        Me.PanelProdutos1.Location = New System.Drawing.Point(133, 100)
        Me.PanelProdutos1.Name = "PanelProdutos1"
        Me.PanelProdutos1.Size = New System.Drawing.Size(575, 28)
        Me.PanelProdutos1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 30)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Produtos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PanelSala
        '
        Me.PanelSala.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.PanelSala.Controls.Add(Me.SalaComboBox)
        Me.PanelSala.Location = New System.Drawing.Point(4, 100)
        Me.PanelSala.Name = "PanelSala"
        Me.PanelSala.Size = New System.Drawing.Size(128, 28)
        Me.PanelSala.TabIndex = 1
        '
        'SalaComboBox
        '
        Me.SalaComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.SalaComboBox.CausesValidation = False
        Me.SalaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MesaBindingSource, "CodSala", True))
        Me.SalaComboBox.DataSource = Me.SalaBindingSource
        Me.SalaComboBox.DisplayMember = "Descrição"
        Me.SalaComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalaComboBox.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SalaComboBox.FormattingEnabled = True
        Me.SalaComboBox.Location = New System.Drawing.Point(0, 0)
        Me.SalaComboBox.MaxDropDownItems = 10
        Me.SalaComboBox.Name = "SalaComboBox"
        Me.SalaComboBox.Size = New System.Drawing.Size(128, 38)
        Me.SalaComboBox.TabIndex = 0
        Me.SalaComboBox.ValueMember = "CodSala"
        '
        'MesaBindingSource
        '
        Me.MesaBindingSource.DataMember = "Mesa"
        Me.MesaBindingSource.DataSource = Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
        '
        'Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
        '
        Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.DataSetName = "Gestão_do_Stock_e_Faturação_de_um_CaféDataSet"
        Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalaBindingSource
        '
        Me.SalaBindingSource.DataMember = "Sala"
        Me.SalaBindingSource.DataSource = Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
        '
        'PanelTipoProduto
        '
        Me.PanelTipoProduto.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelTipoProduto.Controls.Add(Me.Sandes)
        Me.PanelTipoProduto.Controls.Add(Me.Salgados)
        Me.PanelTipoProduto.Controls.Add(Me.Guloseimas)
        Me.PanelTipoProduto.Controls.Add(Me.Gelataria)
        Me.PanelTipoProduto.Controls.Add(Me.Grill)
        Me.PanelTipoProduto.Controls.Add(Me.Cervejaria)
        Me.PanelTipoProduto.Controls.Add(Me.Refrigerantes)
        Me.PanelTipoProduto.Controls.Add(Me.Pastelaria)
        Me.PanelTipoProduto.Controls.Add(Me.Cafetaria)
        Me.PanelTipoProduto.Location = New System.Drawing.Point(4, 129)
        Me.PanelTipoProduto.Name = "PanelTipoProduto"
        Me.PanelTipoProduto.Size = New System.Drawing.Size(128, 583)
        Me.PanelTipoProduto.TabIndex = 2
        '
        'Sandes
        '
        Me.Sandes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Sandes.FlatAppearance.BorderSize = 0
        Me.Sandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sandes.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sandes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Sandes.Location = New System.Drawing.Point(3, 83)
        Me.Sandes.Name = "Sandes"
        Me.Sandes.Size = New System.Drawing.Size(122, 38)
        Me.Sandes.TabIndex = 8
        Me.Sandes.Text = "Sandes"
        Me.Sandes.UseVisualStyleBackColor = False
        '
        'Salgados
        '
        Me.Salgados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Salgados.FlatAppearance.BorderSize = 0
        Me.Salgados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salgados.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salgados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Salgados.Location = New System.Drawing.Point(3, 243)
        Me.Salgados.Name = "Salgados"
        Me.Salgados.Size = New System.Drawing.Size(122, 38)
        Me.Salgados.TabIndex = 7
        Me.Salgados.Text = "Salgados"
        Me.Salgados.UseVisualStyleBackColor = False
        '
        'Guloseimas
        '
        Me.Guloseimas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Guloseimas.FlatAppearance.BorderSize = 0
        Me.Guloseimas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Guloseimas.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guloseimas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Guloseimas.Location = New System.Drawing.Point(3, 323)
        Me.Guloseimas.Name = "Guloseimas"
        Me.Guloseimas.Size = New System.Drawing.Size(122, 38)
        Me.Guloseimas.TabIndex = 6
        Me.Guloseimas.Text = "Guloseimas"
        Me.Guloseimas.UseVisualStyleBackColor = False
        '
        'Gelataria
        '
        Me.Gelataria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Gelataria.FlatAppearance.BorderSize = 0
        Me.Gelataria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gelataria.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gelataria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Gelataria.Location = New System.Drawing.Point(3, 283)
        Me.Gelataria.Name = "Gelataria"
        Me.Gelataria.Size = New System.Drawing.Size(122, 38)
        Me.Gelataria.TabIndex = 5
        Me.Gelataria.Text = "Gelataria"
        Me.Gelataria.UseVisualStyleBackColor = False
        '
        'Grill
        '
        Me.Grill.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Grill.FlatAppearance.BorderSize = 0
        Me.Grill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grill.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Grill.Location = New System.Drawing.Point(3, 203)
        Me.Grill.Name = "Grill"
        Me.Grill.Size = New System.Drawing.Size(122, 38)
        Me.Grill.TabIndex = 4
        Me.Grill.Text = "Grill"
        Me.Grill.UseVisualStyleBackColor = False
        '
        'Cervejaria
        '
        Me.Cervejaria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cervejaria.FlatAppearance.BorderSize = 0
        Me.Cervejaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cervejaria.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cervejaria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Cervejaria.Location = New System.Drawing.Point(3, 163)
        Me.Cervejaria.Name = "Cervejaria"
        Me.Cervejaria.Size = New System.Drawing.Size(122, 38)
        Me.Cervejaria.TabIndex = 3
        Me.Cervejaria.Text = "Cervejaria"
        Me.Cervejaria.UseVisualStyleBackColor = False
        '
        'Refrigerantes
        '
        Me.Refrigerantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Refrigerantes.FlatAppearance.BorderSize = 0
        Me.Refrigerantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Refrigerantes.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refrigerantes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Refrigerantes.Location = New System.Drawing.Point(3, 123)
        Me.Refrigerantes.Name = "Refrigerantes"
        Me.Refrigerantes.Size = New System.Drawing.Size(122, 38)
        Me.Refrigerantes.TabIndex = 2
        Me.Refrigerantes.Text = "Refrigerantes"
        Me.Refrigerantes.UseVisualStyleBackColor = False
        '
        'Pastelaria
        '
        Me.Pastelaria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Pastelaria.FlatAppearance.BorderSize = 0
        Me.Pastelaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pastelaria.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pastelaria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Pastelaria.Location = New System.Drawing.Point(3, 43)
        Me.Pastelaria.Name = "Pastelaria"
        Me.Pastelaria.Size = New System.Drawing.Size(122, 38)
        Me.Pastelaria.TabIndex = 1
        Me.Pastelaria.Text = "Pastelaria"
        Me.Pastelaria.UseVisualStyleBackColor = False
        '
        'Cafetaria
        '
        Me.Cafetaria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cafetaria.FlatAppearance.BorderSize = 0
        Me.Cafetaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cafetaria.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cafetaria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Cafetaria.Location = New System.Drawing.Point(3, 3)
        Me.Cafetaria.Name = "Cafetaria"
        Me.Cafetaria.Size = New System.Drawing.Size(122, 38)
        Me.Cafetaria.TabIndex = 0
        Me.Cafetaria.Text = "Cafetaria"
        Me.Cafetaria.UseVisualStyleBackColor = False
        '
        'PanelProdutos3
        '
        Me.PanelProdutos3.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.PanelProdutos3.Controls.Add(Me.Label1)
        Me.PanelProdutos3.Location = New System.Drawing.Point(709, 129)
        Me.PanelProdutos3.Name = "PanelProdutos3"
        Me.PanelProdutos3.Size = New System.Drawing.Size(182, 28)
        Me.PanelProdutos3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(50, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Produto"
        '
        'PanelItemsFatura
        '
        Me.PanelItemsFatura.BackColor = System.Drawing.Color.White
        Me.PanelItemsFatura.Controls.Add(Me.ListView1)
        Me.PanelItemsFatura.Location = New System.Drawing.Point(709, 158)
        Me.PanelItemsFatura.Name = "PanelItemsFatura"
        Me.PanelItemsFatura.Size = New System.Drawing.Size(310, 502)
        Me.PanelItemsFatura.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Cod, Me.Produto, Me.Qtd, Me.Preço})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Patrick Hand", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(310, 502)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Cod
        '
        Me.Cod.Text = "Cod"
        Me.Cod.Width = 0
        '
        'Produto
        '
        Me.Produto.Text = "Produto"
        Me.Produto.Width = 182
        '
        'Qtd
        '
        Me.Qtd.Text = "Qtd"
        Me.Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Qtd.Width = 64
        '
        'Preço
        '
        Me.Preço.Text = "Preço"
        Me.Preço.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Preço.Width = 64
        '
        'Empregado
        '
        Me.Empregado.AutoSize = True
        Me.Empregado.BackColor = System.Drawing.Color.Transparent
        Me.Empregado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Empregado.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empregado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Empregado.Location = New System.Drawing.Point(14, 12)
        Me.Empregado.Name = "Empregado"
        Me.Empregado.Size = New System.Drawing.Size(96, 30)
        Me.Empregado.TabIndex = 0
        Me.Empregado.Text = "Empregado"
        '
        'PanelTotal
        '
        Me.PanelTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PanelTotal.Controls.Add(Me.PanelTotalEuro)
        Me.PanelTotal.Controls.Add(Me.PanelTotalUnidades)
        Me.PanelTotal.Controls.Add(Me.PanelTotalProdutos)
        Me.PanelTotal.Controls.Add(Me.PanelTotalQtdUnidades)
        Me.PanelTotal.Controls.Add(Me.PanelTotalQtdProdutos)
        Me.PanelTotal.Controls.Add(Me.Total)
        Me.PanelTotal.Controls.Add(Me.PanelTotalTotal)
        Me.PanelTotal.Location = New System.Drawing.Point(709, 661)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Size = New System.Drawing.Size(310, 51)
        Me.PanelTotal.TabIndex = 6
        '
        'PanelTotalEuro
        '
        Me.PanelTotalEuro.AutoSize = True
        Me.PanelTotalEuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PanelTotalEuro.Font = New System.Drawing.Font("Rancho", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTotalEuro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelTotalEuro.Location = New System.Drawing.Point(222, 13)
        Me.PanelTotalEuro.Name = "PanelTotalEuro"
        Me.PanelTotalEuro.Size = New System.Drawing.Size(23, 26)
        Me.PanelTotalEuro.TabIndex = 13
        Me.PanelTotalEuro.Text = "€"
        '
        'PanelTotalUnidades
        '
        Me.PanelTotalUnidades.AutoSize = True
        Me.PanelTotalUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PanelTotalUnidades.Font = New System.Drawing.Font("Rancho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTotalUnidades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelTotalUnidades.Location = New System.Drawing.Point(125, 24)
        Me.PanelTotalUnidades.Name = "PanelTotalUnidades"
        Me.PanelTotalUnidades.Size = New System.Drawing.Size(63, 23)
        Me.PanelTotalUnidades.TabIndex = 12
        Me.PanelTotalUnidades.Text = "Unidades"
        '
        'PanelTotalProdutos
        '
        Me.PanelTotalProdutos.AutoSize = True
        Me.PanelTotalProdutos.BackColor = System.Drawing.Color.Transparent
        Me.PanelTotalProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PanelTotalProdutos.Font = New System.Drawing.Font("Rancho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTotalProdutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelTotalProdutos.Location = New System.Drawing.Point(127, 5)
        Me.PanelTotalProdutos.Name = "PanelTotalProdutos"
        Me.PanelTotalProdutos.Size = New System.Drawing.Size(61, 23)
        Me.PanelTotalProdutos.TabIndex = 11
        Me.PanelTotalProdutos.Text = "Produtos"
        '
        'PanelTotalQtdUnidades
        '
        Me.PanelTotalQtdUnidades.AutoSize = True
        Me.PanelTotalQtdUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PanelTotalQtdUnidades.Font = New System.Drawing.Font("Rancho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTotalQtdUnidades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelTotalQtdUnidades.Location = New System.Drawing.Point(103, 23)
        Me.PanelTotalQtdUnidades.Name = "PanelTotalQtdUnidades"
        Me.PanelTotalQtdUnidades.Size = New System.Drawing.Size(19, 23)
        Me.PanelTotalQtdUnidades.TabIndex = 10
        Me.PanelTotalQtdUnidades.Text = "0"
        '
        'PanelTotalQtdProdutos
        '
        Me.PanelTotalQtdProdutos.AutoSize = True
        Me.PanelTotalQtdProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PanelTotalQtdProdutos.Font = New System.Drawing.Font("Rancho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTotalQtdProdutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelTotalQtdProdutos.Location = New System.Drawing.Point(103, 4)
        Me.PanelTotalQtdProdutos.Name = "PanelTotalQtdProdutos"
        Me.PanelTotalQtdProdutos.Size = New System.Drawing.Size(19, 23)
        Me.PanelTotalQtdProdutos.TabIndex = 9
        Me.PanelTotalQtdProdutos.Text = "0"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Total.Font = New System.Drawing.Font("Rancho", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Total.Location = New System.Drawing.Point(240, 13)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(55, 26)
        Me.Total.TabIndex = 8
        Me.Total.Text = "00,00"
        '
        'PanelTotalTotal
        '
        Me.PanelTotalTotal.AutoSize = True
        Me.PanelTotalTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PanelTotalTotal.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTotalTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelTotalTotal.Location = New System.Drawing.Point(18, 12)
        Me.PanelTotalTotal.Name = "PanelTotalTotal"
        Me.PanelTotalTotal.Size = New System.Drawing.Size(57, 30)
        Me.PanelTotalTotal.TabIndex = 7
        Me.PanelTotalTotal.Text = "Total :"
        '
        'Mesa
        '
        Me.Mesa.AutoSize = True
        Me.Mesa.BackColor = System.Drawing.Color.Transparent
        Me.Mesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mesa.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Mesa.Location = New System.Drawing.Point(95, 1)
        Me.Mesa.Name = "Mesa"
        Me.Mesa.Size = New System.Drawing.Size(54, 30)
        Me.Mesa.TabIndex = 9
        Me.Mesa.Text = "Mesa"
        '
        'PanelQuantidade
        '
        Me.PanelQuantidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.PanelQuantidade.Controls.Add(Me.Label2)
        Me.PanelQuantidade.Location = New System.Drawing.Point(892, 129)
        Me.PanelQuantidade.Name = "PanelQuantidade"
        Me.PanelQuantidade.Size = New System.Drawing.Size(63, 28)
        Me.PanelQuantidade.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 30)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Qtd"
        '
        'PanelPreco
        '
        Me.PanelPreco.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.PanelPreco.Controls.Add(Me.Label3)
        Me.PanelPreco.Location = New System.Drawing.Point(956, 129)
        Me.PanelPreco.Name = "PanelPreco"
        Me.PanelPreco.Size = New System.Drawing.Size(63, 28)
        Me.PanelPreco.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 30)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Preço"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.BackColor = System.Drawing.Color.Transparent
        Me.Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Time.Font = New System.Drawing.Font("Rancho", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Time.Location = New System.Drawing.Point(136, 16)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(157, 26)
        Me.Time.TabIndex = 11
        Me.Time.Text = "00-00-0000  00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MesaComboBox
        '
        Me.MesaComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MesaComboBox.CausesValidation = False
        Me.MesaComboBox.DataSource = Me.MesaBindingSource
        Me.MesaComboBox.DisplayMember = "CodMesa"
        Me.MesaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MesaComboBox.Font = New System.Drawing.Font("Rancho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesaComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.MesaComboBox.FormattingEnabled = True
        Me.MesaComboBox.Location = New System.Drawing.Point(98, 31)
        Me.MesaComboBox.MaxDropDownItems = 10
        Me.MesaComboBox.Name = "MesaComboBox"
        Me.MesaComboBox.Size = New System.Drawing.Size(46, 31)
        Me.MesaComboBox.TabIndex = 12
        Me.MesaComboBox.ValueMember = "CodMesa"
        '
        'SalaTableAdapter
        '
        Me.SalaTableAdapter.ClearBeforeFill = True
        '
        'MesaTableAdapter
        '
        Me.MesaTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Panel1.Controls.Add(Me.AdicionarConta)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.MesaComboBox)
        Me.Panel1.Controls.Add(Me.Mesa)
        Me.Panel1.Location = New System.Drawing.Point(709, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 65)
        Me.Panel1.TabIndex = 15
        '
        'AdicionarConta
        '
        Me.AdicionarConta.BackColor = System.Drawing.Color.Transparent
        Me.AdicionarConta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AdicionarConta.FlatAppearance.BorderSize = 0
        Me.AdicionarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdicionarConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdicionarConta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AdicionarConta.Image = Global.ProjetoPAP_PSI.My.Resources.Resources.SquareAdd
        Me.AdicionarConta.Location = New System.Drawing.Point(0, 0)
        Me.AdicionarConta.Name = "AdicionarConta"
        Me.AdicionarConta.Size = New System.Drawing.Size(65, 64)
        Me.AdicionarConta.TabIndex = 14
        Me.AdicionarConta.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.Image = Global.ProjetoPAP_PSI.My.Resources.Resources.SquareRight
        Me.Button2.Location = New System.Drawing.Point(244, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 64)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Image = Global.ProjetoPAP_PSI.My.Resources.Resources.SquareLeft
        Me.Button1.Location = New System.Drawing.Point(174, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 64)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Sair
        '
        Me.Sair.AutoSize = True
        Me.Sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Sair.FlatAppearance.BorderSize = 0
        Me.Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sair.Font = New System.Drawing.Font("Rancho", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sair.ForeColor = System.Drawing.Color.White
        Me.Sair.Location = New System.Drawing.Point(4, 713)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(128, 51)
        Me.Sair.TabIndex = 16
        Me.Sair.Text = "Sair"
        Me.Sair.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Empregado)
        Me.Panel2.Controls.Add(Me.Time)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(709, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 53)
        Me.Panel2.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetoPAP_PSI.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(4, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Faturacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Sair)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelPreco)
        Me.Controls.Add(Me.PanelQuantidade)
        Me.Controls.Add(Me.PanelTotal)
        Me.Controls.Add(Me.Opções)
        Me.Controls.Add(Me.Registar)
        Me.Controls.Add(Me.PanelItemsFatura)
        Me.Controls.Add(Me.PanelProdutos3)
        Me.Controls.Add(Me.PanelTipoProduto)
        Me.Controls.Add(Me.PanelSala)
        Me.Controls.Add(Me.PanelProdutos1)
        Me.Controls.Add(Me.ProdutosPanel)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Faturacao"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ProdutosPanel.ResumeLayout(False)
        Me.PanelProdutos1.ResumeLayout(False)
        Me.PanelProdutos1.PerformLayout()
        Me.PanelSala.ResumeLayout(False)
        CType(Me.MesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTipoProduto.ResumeLayout(False)
        Me.PanelProdutos3.ResumeLayout(False)
        Me.PanelProdutos3.PerformLayout()
        Me.PanelItemsFatura.ResumeLayout(False)
        Me.PanelTotal.ResumeLayout(False)
        Me.PanelTotal.PerformLayout()
        Me.PanelQuantidade.ResumeLayout(False)
        Me.PanelQuantidade.PerformLayout()
        Me.PanelPreco.ResumeLayout(False)
        Me.PanelPreco.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Registar As System.Windows.Forms.Button
    Friend WithEvents Opções As System.Windows.Forms.Button
    Friend WithEvents ProdutosPanel As System.Windows.Forms.Panel
    Friend WithEvents PanelProdutos1 As System.Windows.Forms.Panel
    Friend WithEvents PanelSala As System.Windows.Forms.Panel
    Friend WithEvents PanelTipoProduto As System.Windows.Forms.Panel
    Friend WithEvents PanelProdutos3 As System.Windows.Forms.Panel
    Friend WithEvents PanelItemsFatura As System.Windows.Forms.Panel
    Friend WithEvents Empregado As System.Windows.Forms.Label
    Friend WithEvents PanelTotal As System.Windows.Forms.Panel
    Friend WithEvents PanelTotalQtdProdutos As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents PanelTotalTotal As System.Windows.Forms.Label
    Friend WithEvents PanelTotalQtdUnidades As System.Windows.Forms.Label
    Friend WithEvents PanelTotalProdutos As System.Windows.Forms.Label
    Friend WithEvents PanelTotalUnidades As System.Windows.Forms.Label
    Friend WithEvents Mesa As System.Windows.Forms.Label
    Friend WithEvents PanelTotalEuro As System.Windows.Forms.Label
    Friend WithEvents PanelQuantidade As System.Windows.Forms.Panel
    Friend WithEvents PanelPreco As System.Windows.Forms.Panel
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProdutosFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MesaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SalaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Refrigerantes As System.Windows.Forms.Button
    Friend WithEvents Pastelaria As System.Windows.Forms.Button
    Friend WithEvents Cafetaria As System.Windows.Forms.Button
    Friend WithEvents Gestão_do_Stock_e_Faturação_de_um_CaféDataSet As ProjetoPAP_PSI.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
    Friend WithEvents SalaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalaTableAdapter As ProjetoPAP_PSI.Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.SalaTableAdapter
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Cod As System.Windows.Forms.ColumnHeader
    Friend WithEvents Produto As System.Windows.Forms.ColumnHeader
    Friend WithEvents Qtd As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preço As System.Windows.Forms.ColumnHeader
    Friend WithEvents MesaBindingSource As BindingSource
    Friend WithEvents MesaTableAdapter As Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.MesaTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Sair As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AdicionarConta As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Grill As System.Windows.Forms.Button
    Friend WithEvents Cervejaria As System.Windows.Forms.Button
    Friend WithEvents Gelataria As System.Windows.Forms.Button
    Friend WithEvents Sandes As System.Windows.Forms.Button
    Friend WithEvents Salgados As System.Windows.Forms.Button
    Friend WithEvents Guloseimas As System.Windows.Forms.Button
End Class
