<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBoxNIF
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
        Me.Sim = New System.Windows.Forms.Button()
        Me.Não = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OK = New System.Windows.Forms.Button()
        Me.NIF = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Sim
        '
        Me.Sim.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Sim.FlatAppearance.BorderSize = 0
        Me.Sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sim.Font = New System.Drawing.Font("Rancho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Sim.Location = New System.Drawing.Point(11, 40)
        Me.Sim.Name = "Sim"
        Me.Sim.Size = New System.Drawing.Size(75, 33)
        Me.Sim.TabIndex = 0
        Me.Sim.Text = "Sim"
        Me.Sim.UseVisualStyleBackColor = False
        '
        'Não
        '
        Me.Não.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Não.FlatAppearance.BorderSize = 0
        Me.Não.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Não.Font = New System.Drawing.Font("Rancho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Não.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Não.Location = New System.Drawing.Point(92, 40)
        Me.Não.Name = "Não"
        Me.Não.Size = New System.Drawing.Size(75, 33)
        Me.Não.TabIndex = 1
        Me.Não.Text = "Não"
        Me.Não.UseVisualStyleBackColor = False
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Cancelar.FlatAppearance.BorderSize = 2
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Font = New System.Drawing.Font("Rancho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cancelar.Location = New System.Drawing.Point(173, 40)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 33)
        Me.Cancelar.TabIndex = 2
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Eras Light ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Deseja Inserir NIF?"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Sim)
        Me.Panel1.Controls.Add(Me.Cancelar)
        Me.Panel1.Controls.Add(Me.Não)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 83)
        Me.Panel1.TabIndex = 4
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.OK.FlatAppearance.BorderSize = 0
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("Rancho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.OK.Location = New System.Drawing.Point(12, 43)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(236, 29)
        Me.OK.TabIndex = 4
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        Me.OK.Visible = False
        '
        'NIF
        '
        Me.NIF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.NIF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NIF.Font = New System.Drawing.Font("Patrick Hand", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.NIF.Location = New System.Drawing.Point(12, 13)
        Me.NIF.MaxLength = 9
        Me.NIF.Name = "NIF"
        Me.NIF.Size = New System.Drawing.Size(236, 26)
        Me.NIF.TabIndex = 5
        Me.NIF.Visible = False
        '
        'MsgBoxNIF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(260, 83)
        Me.Controls.Add(Me.NIF)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MsgBoxNIF"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MsgBoxNIF"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sim As System.Windows.Forms.Button
    Friend WithEvents Não As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NIF As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
End Class
