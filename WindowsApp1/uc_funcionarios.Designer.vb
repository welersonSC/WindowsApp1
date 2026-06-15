<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_funcionarios
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_buscarfunc = New System.Windows.Forms.TextBox()
        Me.btn_novofunc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_funcionarios = New System.Windows.Forms.DataGridView()
        Me.col_id_func = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_senha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_excluir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_funcionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_buscarfunc)
        Me.Panel1.Controls.Add(Me.btn_novofunc)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(73, 55)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1185, 100)
        Me.Panel1.TabIndex = 4
        '
        'btn_buscarfunc
        '
        Me.btn_buscarfunc.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_buscarfunc.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btn_buscarfunc.Location = New System.Drawing.Point(699, 28)
        Me.btn_buscarfunc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_buscarfunc.Name = "btn_buscarfunc"
        Me.btn_buscarfunc.Size = New System.Drawing.Size(260, 39)
        Me.btn_buscarfunc.TabIndex = 3
        Me.btn_buscarfunc.Text = "🔍 Buscar funcionário..."
        '
        'btn_novofunc
        '
        Me.btn_novofunc.AccessibleDescription = "btn_novofunc"
        Me.btn_novofunc.AccessibleName = "btn_novofunc"
        Me.btn_novofunc.BackColor = System.Drawing.Color.Gold
        Me.btn_novofunc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_novofunc.Location = New System.Drawing.Point(975, 25)
        Me.btn_novofunc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_novofunc.Name = "btn_novofunc"
        Me.btn_novofunc.Size = New System.Drawing.Size(180, 46)
        Me.btn_novofunc.TabIndex = 2
        Me.btn_novofunc.Text = "➕ Novo"
        Me.btn_novofunc.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTÃO DE FUNCIONÁRIOS"
        '
        'dgv_funcionarios
        '
        Me.dgv_funcionarios.AllowUserToAddRows = False
        Me.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_funcionarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_func, Me.col_usuario, Me.col_email, Me.col_senha, Me.col_status, Me.col_editar, Me.col_excluir})
        Me.dgv_funcionarios.Location = New System.Drawing.Point(73, 194)
        Me.dgv_funcionarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_funcionarios.Name = "dgv_funcionarios"
        Me.dgv_funcionarios.RowHeadersVisible = False
        Me.dgv_funcionarios.RowHeadersWidth = 51
        Me.dgv_funcionarios.RowTemplate.Height = 24
        Me.dgv_funcionarios.Size = New System.Drawing.Size(1185, 385)
        Me.dgv_funcionarios.TabIndex = 3
        '
        'col_id_func
        '
        Me.col_id_func.HeaderText = "Cód."
        Me.col_id_func.MinimumWidth = 6
        Me.col_id_func.Name = "col_id_func"
        Me.col_id_func.Width = 90
        '
        'col_usuario
        '
        Me.col_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_usuario.HeaderText = "Usuário"
        Me.col_usuario.MinimumWidth = 6
        Me.col_usuario.Name = "col_usuario"
        '
        'col_email
        '
        Me.col_email.HeaderText = "Email"
        Me.col_email.MinimumWidth = 6
        Me.col_email.Name = "col_email"
        Me.col_email.Width = 300
        '
        'col_senha
        '
        Me.col_senha.HeaderText = "Senha"
        Me.col_senha.MinimumWidth = 6
        Me.col_senha.Name = "col_senha"
        Me.col_senha.Width = 200
        '
        'col_status
        '
        Me.col_status.HeaderText = "Status Conta"
        Me.col_status.MinimumWidth = 6
        Me.col_status.Name = "col_status"
        Me.col_status.Width = 200
        '
        'col_editar
        '
        Me.col_editar.HeaderText = ""
        Me.col_editar.MinimumWidth = 6
        Me.col_editar.Name = "col_editar"
        Me.col_editar.Text = "✏️"
        Me.col_editar.UseColumnTextForButtonValue = True
        Me.col_editar.Width = 40
        '
        'col_excluir
        '
        Me.col_excluir.HeaderText = ""
        Me.col_excluir.MinimumWidth = 6
        Me.col_excluir.Name = "col_excluir"
        Me.col_excluir.Text = "❌"
        Me.col_excluir.UseColumnTextForButtonValue = True
        Me.col_excluir.Width = 40
        '
        'uc_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_funcionarios)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "uc_funcionarios"
        Me.Size = New System.Drawing.Size(1337, 652)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_funcionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_buscarfunc As TextBox
    Friend WithEvents btn_novofunc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_funcionarios As DataGridView
    Friend WithEvents col_id_func As DataGridViewTextBoxColumn
    Friend WithEvents col_usuario As DataGridViewTextBoxColumn
    Friend WithEvents col_email As DataGridViewTextBoxColumn
    Friend WithEvents col_senha As DataGridViewTextBoxColumn
    Friend WithEvents col_status As DataGridViewTextBoxColumn
    Friend WithEvents col_editar As DataGridViewButtonColumn
    Friend WithEvents col_excluir As DataGridViewButtonColumn
End Class
