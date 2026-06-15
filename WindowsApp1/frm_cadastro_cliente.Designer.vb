<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_cliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_whatsapp = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_data = New System.Windows.Forms.DateTimePicker()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_complemento = New System.Windows.Forms.TextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(485, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "👤 Ficha do Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.txt_email)
        Me.GroupBox2.Controls.Add(Me.GunaLabel5)
        Me.GroupBox2.Controls.Add(Me.GunaLabel4)
        Me.GroupBox2.Controls.Add(Me.txt_whatsapp)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox2.Location = New System.Drawing.Point(665, 126)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(596, 204)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONTATOS"
        '
        'txt_email
        '
        Me.txt_email.AccessibleDescription = "txt_email"
        Me.txt_email.AccessibleName = "txt_email"
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_email.Location = New System.Drawing.Point(27, 137)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(529, 32)
        Me.txt_email.TabIndex = 8
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel5.Location = New System.Drawing.Point(21, 114)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(53, 20)
        Me.GunaLabel5.TabIndex = 7
        Me.GunaLabel5.Text = "E-Mail"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel4.Location = New System.Drawing.Point(20, 41)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(77, 20)
        Me.GunaLabel4.TabIndex = 6
        Me.GunaLabel4.Text = "Whatsapp"
        '
        'txt_whatsapp
        '
        Me.txt_whatsapp.AccessibleDescription = "txt_whats"
        Me.txt_whatsapp.AccessibleName = "txt_whats"
        Me.txt_whatsapp.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_whatsapp.Location = New System.Drawing.Point(24, 66)
        Me.txt_whatsapp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_whatsapp.Mask = "(00) 00000-0000"
        Me.txt_whatsapp.Name = "txt_whatsapp"
        Me.txt_whatsapp.Size = New System.Drawing.Size(244, 32)
        Me.txt_whatsapp.TabIndex = 5
        Me.txt_whatsapp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.dtp_data)
        Me.GroupBox1.Controls.Add(Me.txt_cpf)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox1.Location = New System.Drawing.Point(32, 126)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(596, 204)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DADOS DE IDENTIFICAÇÃO"
        '
        'dtp_data
        '
        Me.dtp_data.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data.Location = New System.Drawing.Point(307, 142)
        Me.dtp_data.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_data.Name = "dtp_data"
        Me.dtp_data.Size = New System.Drawing.Size(248, 32)
        Me.dtp_data.TabIndex = 5
        Me.dtp_data.Value = New Date(2026, 6, 7, 0, 0, 0, 0)
        '
        'txt_cpf
        '
        Me.txt_cpf.AccessibleDescription = "txt_cpf"
        Me.txt_cpf.AccessibleName = "txt_cpf"
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_cpf.Location = New System.Drawing.Point(25, 142)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(244, 32)
        Me.txt_cpf.TabIndex = 4
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel3.Location = New System.Drawing.Point(353, 118)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(147, 20)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "Data de Nascimento"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel2.Location = New System.Drawing.Point(21, 118)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(35, 20)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "CPF"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel1.Location = New System.Drawing.Point(21, 47)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(121, 20)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Nome Completo"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.txt_obs)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox3.Location = New System.Drawing.Point(779, 361)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(483, 298)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OBSERVAÇÕES"
        '
        'txt_obs
        '
        Me.txt_obs.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_obs.Location = New System.Drawing.Point(21, 53)
        Me.txt_obs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(445, 210)
        Me.txt_obs.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Me.txt_complemento)
        Me.GroupBox4.Controls.Add(Me.GunaLabel11)
        Me.GroupBox4.Controls.Add(Me.txt_cidade)
        Me.GroupBox4.Controls.Add(Me.GunaLabel10)
        Me.GroupBox4.Controls.Add(Me.txt_bairro)
        Me.GroupBox4.Controls.Add(Me.GunaLabel9)
        Me.GroupBox4.Controls.Add(Me.txt_numero)
        Me.GroupBox4.Controls.Add(Me.GunaLabel8)
        Me.GroupBox4.Controls.Add(Me.txt_endereco)
        Me.GroupBox4.Controls.Add(Me.GunaLabel7)
        Me.GroupBox4.Controls.Add(Me.txt_cep)
        Me.GroupBox4.Controls.Add(Me.GunaLabel6)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox4.Location = New System.Drawing.Point(32, 361)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(731, 298)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ENDEREÇO"
        '
        'txt_complemento
        '
        Me.txt_complemento.AccessibleDescription = "txt_complemento"
        Me.txt_complemento.AccessibleName = "txt_complemento"
        Me.txt_complemento.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_complemento.Location = New System.Drawing.Point(496, 225)
        Me.txt_complemento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(195, 32)
        Me.txt_complemento.TabIndex = 16
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel11.Location = New System.Drawing.Point(497, 199)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(105, 20)
        Me.GunaLabel11.TabIndex = 15
        Me.GunaLabel11.Text = "Complemento"
        '
        'txt_cidade
        '
        Me.txt_cidade.AccessibleDescription = "txt_cidade"
        Me.txt_cidade.AccessibleName = "txt_cidade"
        Me.txt_cidade.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_cidade.Location = New System.Drawing.Point(267, 225)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(195, 32)
        Me.txt_cidade.TabIndex = 14
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel10.Location = New System.Drawing.Point(267, 199)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(56, 20)
        Me.GunaLabel10.TabIndex = 13
        Me.GunaLabel10.Text = "Cidade"
        '
        'txt_bairro
        '
        Me.txt_bairro.AccessibleDescription = "txt_bairro"
        Me.txt_bairro.AccessibleName = "txt_bairro"
        Me.txt_bairro.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_bairro.Location = New System.Drawing.Point(25, 225)
        Me.txt_bairro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(207, 32)
        Me.txt_bairro.TabIndex = 12
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel9.Location = New System.Drawing.Point(27, 199)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(51, 20)
        Me.GunaLabel9.TabIndex = 11
        Me.GunaLabel9.Text = "Bairro"
        '
        'txt_numero
        '
        Me.txt_numero.AccessibleDescription = "txt_nr"
        Me.txt_numero.AccessibleName = "txt_nr"
        Me.txt_numero.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_numero.Location = New System.Drawing.Point(437, 143)
        Me.txt_numero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(63, 32)
        Me.txt_numero.TabIndex = 10
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel8.Location = New System.Drawing.Point(435, 118)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(66, 20)
        Me.GunaLabel8.TabIndex = 9
        Me.GunaLabel8.Text = "Numero"
        '
        'txt_endereco
        '
        Me.txt_endereco.AccessibleDescription = "txt_endereco"
        Me.txt_endereco.AccessibleName = "txt_endereco"
        Me.txt_endereco.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_endereco.Location = New System.Drawing.Point(25, 143)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(393, 32)
        Me.txt_endereco.TabIndex = 8
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel7.Location = New System.Drawing.Point(27, 118)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(73, 20)
        Me.GunaLabel7.TabIndex = 7
        Me.GunaLabel7.Text = "Endereço"
        '
        'txt_cep
        '
        Me.txt_cep.AccessibleDescription = "txt_cep"
        Me.txt_cep.AccessibleName = "txt_cep"
        Me.txt_cep.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_cep.Location = New System.Drawing.Point(25, 66)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cep.Mask = "00000-000"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(183, 32)
        Me.txt_cep.TabIndex = 6
        Me.txt_cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel6.Location = New System.Drawing.Point(24, 43)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(35, 20)
        Me.GunaLabel6.TabIndex = 5
        Me.GunaLabel6.Text = "CEP"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 1026)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1299, 23)
        Me.Panel2.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox5.Location = New System.Drawing.Point(32, 683)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(1229, 172)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CONTRATOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 50)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1188, 75)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_salvar
        '
        Me.btn_salvar.AccessibleDescription = "btn_salvar"
        Me.btn_salvar.AccessibleName = "btn_salvar"
        Me.btn_salvar.Location = New System.Drawing.Point(897, 9)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(112, 62)
        Me.btn_salvar.TabIndex = 18
        Me.btn_salvar.Text = "salvar"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(1015, 9)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(112, 62)
        Me.btn_limpar.TabIndex = 19
        Me.btn_limpar.Text = "limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'btn_fechar
        '
        Me.btn_fechar.Location = New System.Drawing.Point(1133, 9)
        Me.btn_fechar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(112, 62)
        Me.btn_fechar.TabIndex = 20
        Me.btn_fechar.Text = "fechar"
        Me.btn_fechar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_salvar)
        Me.Panel3.Controls.Add(Me.btn_limpar)
        Me.Panel3.Controls.Add(Me.btn_fechar)
        Me.Panel3.Location = New System.Drawing.Point(0, 898)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1299, 128)
        Me.Panel3.TabIndex = 22
        '
        'frm_cadastro_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1299, 881)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_cadastro_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cadastro_cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_whatsapp As MaskedTextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtp_data As DateTimePicker
End Class
