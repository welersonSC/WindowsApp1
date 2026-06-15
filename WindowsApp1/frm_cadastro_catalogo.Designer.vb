<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cadastro_catalogo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.chk_item_ativo = New System.Windows.Forms.RadioButton()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.cbo_categoria = New System.Windows.Forms.ComboBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1299, 100)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(485, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cadastro de Catálogo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.cbo_tipo)
        Me.GroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GroupBox1.Controls.Add(Me.chk_item_ativo)
        Me.GroupBox1.Controls.Add(Me.txt_descricao)
        Me.GroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GroupBox1.Controls.Add(Me.txt_valor)
        Me.GroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GroupBox1.Controls.Add(Me.cbo_categoria)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox1.Location = New System.Drawing.Point(26, 145)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(596, 616)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DADOS DO ITEM"
        '
        'cbo_tipo
        '
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Items.AddRange(New Object() {"Pacote Base", "Item/Serviço Extra"})
        Me.cbo_tipo.Location = New System.Drawing.Point(25, 141)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(529, 39)
        Me.cbo_tipo.TabIndex = 11
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel5.Location = New System.Drawing.Point(21, 110)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(39, 20)
        Me.GunaLabel5.TabIndex = 10
        Me.GunaLabel5.Text = "Tipo"
        '
        'chk_item_ativo
        '
        Me.chk_item_ativo.AutoSize = True
        Me.chk_item_ativo.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_item_ativo.Location = New System.Drawing.Point(28, 567)
        Me.chk_item_ativo.Name = "chk_item_ativo"
        Me.chk_item_ativo.Size = New System.Drawing.Size(113, 29)
        Me.chk_item_ativo.TabIndex = 9
        Me.chk_item_ativo.TabStop = True
        Me.chk_item_ativo.Text = "Item ativo"
        Me.chk_item_ativo.UseVisualStyleBackColor = True
        '
        'txt_descricao
        '
        Me.txt_descricao.AccessibleDescription = ""
        Me.txt_descricao.AccessibleName = ""
        Me.txt_descricao.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txt_descricao.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_descricao.Location = New System.Drawing.Point(25, 392)
        Me.txt_descricao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(529, 147)
        Me.txt_descricao.TabIndex = 8
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel4.Location = New System.Drawing.Point(24, 369)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(147, 20)
        Me.GunaLabel4.TabIndex = 7
        Me.GunaLabel4.Text = "Descrição detalhada"
        '
        'txt_valor
        '
        Me.txt_valor.AccessibleDescription = ""
        Me.txt_valor.AccessibleName = ""
        Me.txt_valor.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txt_valor.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_valor.Location = New System.Drawing.Point(25, 303)
        Me.txt_valor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(529, 32)
        Me.txt_valor.TabIndex = 6
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel3.Location = New System.Drawing.Point(21, 281)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(111, 20)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Valor Base (R$)"
        '
        'cbo_categoria
        '
        Me.cbo_categoria.FormattingEnabled = True
        Me.cbo_categoria.Items.AddRange(New Object() {"Decoração", "", "", "Efeitos especiais", "", "", "Entretenimento", "", "", "Gastronomia", "", "", "Serviços extras", "", "", "Tecnologia"})
        Me.cbo_categoria.Location = New System.Drawing.Point(25, 225)
        Me.cbo_categoria.Name = "cbo_categoria"
        Me.cbo_categoria.Size = New System.Drawing.Size(529, 39)
        Me.cbo_categoria.TabIndex = 4
        '
        'txt_nome
        '
        Me.txt_nome.AccessibleDescription = "txt_nome"
        Me.txt_nome.AccessibleName = "txt_nome"
        Me.txt_nome.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_nome.Location = New System.Drawing.Point(25, 68)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(529, 32)
        Me.txt_nome.TabIndex = 3
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel2.Location = New System.Drawing.Point(21, 192)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(75, 20)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Categoria"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel1.Location = New System.Drawing.Point(21, 47)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(107, 20)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Nome do item"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btn_salvar)
        Me.Panel3.Controls.Add(Me.btn_limpar)
        Me.Panel3.Controls.Add(Me.btn_fechar)
        Me.Panel3.Location = New System.Drawing.Point(0, 795)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1299, 98)
        Me.Panel3.TabIndex = 35
        '
        'btn_salvar
        '
        Me.btn_salvar.Location = New System.Drawing.Point(877, 14)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(112, 62)
        Me.btn_salvar.TabIndex = 21
        Me.btn_salvar.Text = "salvar"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(995, 14)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(112, 62)
        Me.btn_limpar.TabIndex = 22
        Me.btn_limpar.Text = "limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'btn_fechar
        '
        Me.btn_fechar.Location = New System.Drawing.Point(1113, 14)
        Me.btn_fechar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(112, 62)
        Me.btn_fechar.TabIndex = 23
        Me.btn_fechar.Text = "fechar"
        Me.btn_fechar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_cadastro_catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1299, 923)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_cadastro_catalogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cadastro_catralogo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbo_categoria As ComboBox
    Friend WithEvents chk_item_ativo As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents cbo_tipo As ComboBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
