<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FaturaReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.FaturaDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet = New ProjetoPAP_PSI.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FaturaTableAdapter = New ProjetoPAP_PSI.Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.FaturaTableAdapter()
        Me.ProdutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutoTableAdapter = New ProjetoPAP_PSI.Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.ProdutoTableAdapter()
        Me.Sair = New System.Windows.Forms.Button()
        CType(Me.FaturaDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FaturaDataTableBindingSource
        '
        Me.FaturaDataTableBindingSource.DataMember = "FaturaDataTable"
        Me.FaturaDataTableBindingSource.DataSource = Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
        '
        'Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
        '
        Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.DataSetName = "Gestão_do_Stock_e_Faturação_de_um_CaféDataSet"
        Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "FaturaDataSet"
        ReportDataSource1.Value = Me.FaturaDataTableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoPAP_PSI.Fatura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.ReportViewer1.Size = New System.Drawing.Size(657, 548)
        Me.ReportViewer1.TabIndex = 0
        '
        'FaturaTableAdapter
        '
        Me.FaturaTableAdapter.ClearBeforeFill = True
        '
        'ProdutoBindingSource
        '
        Me.ProdutoBindingSource.DataMember = "Produto"
        Me.ProdutoBindingSource.DataSource = Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
        '
        'ProdutoTableAdapter
        '
        Me.ProdutoTableAdapter.ClearBeforeFill = True
        '
        'Sair
        '
        Me.Sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Sair.FlatAppearance.BorderSize = 0
        Me.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sair.Font = New System.Drawing.Font("Rancho", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Sair.Location = New System.Drawing.Point(1, 488)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(81, 48)
        Me.Sair.TabIndex = 2
        Me.Sair.Text = "Sair"
        Me.Sair.UseVisualStyleBackColor = False
        '
        'FaturaReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(657, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.Sair)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FaturaReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FaturaReport"
        CType(Me.FaturaDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gestão_do_Stock_e_Faturação_de_um_CaféDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FaturaDataTableBindingSource As BindingSource
    Friend WithEvents Gestão_do_Stock_e_Faturação_de_um_CaféDataSet As Gestão_do_Stock_e_Faturação_de_um_CaféDataSet
    Friend WithEvents FaturaTableAdapter As Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.FaturaTableAdapter
    Friend WithEvents ProdutoBindingSource As BindingSource
    Friend WithEvents ProdutoTableAdapter As Gestão_do_Stock_e_Faturação_de_um_CaféDataSetTableAdapters.ProdutoTableAdapter
    Friend WithEvents Sair As Button
End Class
