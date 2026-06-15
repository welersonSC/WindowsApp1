<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_clientes
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.col_id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nome_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_excluir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_novo_cliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_cliente, Me.col_nome_cliente, Me.col_telefone, Me.col_email, Me.col_cidade, Me.col_editar, Me.col_excluir})
        Me.dgv_clientes.Location = New System.Drawing.Point(51, 190)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.RowHeadersVisible = False
        Me.dgv_clientes.RowHeadersWidth = 51
        Me.dgv_clientes.RowTemplate.Height = 24
        Me.dgv_clientes.Size = New System.Drawing.Size(1185, 385)
        Me.dgv_clientes.TabIndex = 1
        '
        'col_id_cliente
        '
        Me.col_id_cliente.HeaderText = "Cód."
        Me.col_id_cliente.MinimumWidth = 6
        Me.col_id_cliente.Name = "col_id_cliente"
        Me.col_id_cliente.Width = 75
        '
        'col_nome_cliente
        '
        Me.col_nome_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_nome_cliente.HeaderText = "Nome Completo"
        Me.col_nome_cliente.MinimumWidth = 6
        Me.col_nome_cliente.Name = "col_nome_cliente"
        '
        'col_telefone
        '
        Me.col_telefone.HeaderText = "WhatsApp"
        Me.col_telefone.MinimumWidth = 6
        Me.col_telefone.Name = "col_telefone"
        Me.col_telefone.Width = 130
        '
        'col_email
        '
        Me.col_email.HeaderText = "E-mail"
        Me.col_email.MinimumWidth = 6
        Me.col_email.Name = "col_email"
        Me.col_email.Width = 180
        '
        'col_cidade
        '
        Me.col_cidade.HeaderText = "Cidade"
        Me.col_cidade.MinimumWidth = 6
        Me.col_cidade.Name = "col_cidade"
        Me.col_cidade.Width = 220
        '
        'col_editar
        '
        Me.col_editar.HeaderText = ""
        Me.col_editar.MinimumWidth = 6
        Me.col_editar.Name = "col_editar"
        Me.col_editar.Width = 60
        '
        'col_excluir
        '
        Me.col_excluir.HeaderText = ""
        Me.col_excluir.MinimumWidth = 6
        Me.col_excluir.Name = "col_excluir"
        Me.col_excluir.Width = 60
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.btn_novo_cliente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(51, 49)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1185, 100)
        Me.Panel1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = "btn_buscarcliente"
        Me.TextBox1.AccessibleName = "btn_buscarcliente"
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TextBox1.Location = New System.Drawing.Point(735, 28)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 39)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "🔍 Buscar cliente..."
        '
        'btn_novo_cliente
        '
        Me.btn_novo_cliente.AccessibleDescription = "btn_novocliente"
        Me.btn_novo_cliente.AccessibleName = "btn_novocliente"
        Me.btn_novo_cliente.BackColor = System.Drawing.Color.Gold
        Me.btn_novo_cliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_novo_cliente.Location = New System.Drawing.Point(975, 25)
        Me.btn_novo_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_novo_cliente.Name = "btn_novo_cliente"
        Me.btn_novo_cliente.Size = New System.Drawing.Size(180, 46)
        Me.btn_novo_cliente.TabIndex = 2
        Me.btn_novo_cliente.Text = "➕ Novo Cliente"
        Me.btn_novo_cliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTÃO DE CLIENTES"
        '
        'uc_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "uc_clientes"
        Me.Size = New System.Drawing.Size(1337, 652)
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_novo_cliente As Button
    Friend WithEvents col_id_cliente As DataGridViewTextBoxColumn
    Friend WithEvents col_nome_cliente As DataGridViewTextBoxColumn
    Friend WithEvents col_telefone As DataGridViewTextBoxColumn
    Friend WithEvents col_email As DataGridViewTextBoxColumn
    Friend WithEvents col_cidade As DataGridViewTextBoxColumn
    Friend WithEvents col_editar As DataGridViewButtonColumn
    Friend WithEvents col_excluir As DataGridViewButtonColumn
End Class
