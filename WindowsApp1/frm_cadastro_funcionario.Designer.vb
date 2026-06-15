<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_funcionario
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_whatsapp = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dt_nascimento = New System.Windows.Forms.DateTimePicker()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmb_status_conta = New System.Windows.Forms.ComboBox()
        Me.lbl_status = New Guna.UI.WinForms.GunaLabel()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.GunaLabel17 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.rb_operador = New System.Windows.Forms.RadioButton()
        Me.rb_admin = New System.Windows.Forms.RadioButton()
        Me.cmb_cargo = New System.Windows.Forms.ComboBox()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 1022)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1299, 23)
        Me.Panel2.TabIndex = 28
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
        Me.Panel1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(485, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "👤 Ficha do Funcionário"
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
        Me.GroupBox2.Location = New System.Drawing.Point(36, 367)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(596, 234)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONTATOS"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_email.Location = New System.Drawing.Point(27, 137)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(436, 32)
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
        Me.txt_whatsapp.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_whatsapp.Location = New System.Drawing.Point(24, 66)
        Me.txt_whatsapp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_whatsapp.Mask = "+55 (99) 99999-9999"
        Me.txt_whatsapp.Name = "txt_whatsapp"
        Me.txt_whatsapp.Size = New System.Drawing.Size(244, 32)
        Me.txt_whatsapp.TabIndex = 5
        Me.txt_whatsapp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.dt_nascimento)
        Me.GroupBox1.Controls.Add(Me.txt_cpf)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox1.Location = New System.Drawing.Point(36, 129)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(596, 204)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DADOS DE IDENTIFICAÇÃO"
        '
        'dt_nascimento
        '
        Me.dt_nascimento.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dt_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_nascimento.Location = New System.Drawing.Point(357, 142)
        Me.dt_nascimento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt_nascimento.Name = "dt_nascimento"
        Me.dt_nascimento.Size = New System.Drawing.Size(197, 32)
        Me.dt_nascimento.TabIndex = 5
        Me.dt_nascimento.Value = New Date(2026, 6, 6, 0, 0, 0, 0)
        '
        'txt_cpf
        '
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
        Me.GroupBox4.Location = New System.Drawing.Point(36, 623)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1193, 277)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ENDEREÇO"
        '
        'txt_complemento
        '
        Me.txt_complemento.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_complemento.Location = New System.Drawing.Point(496, 225)
        Me.txt_complemento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(259, 32)
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
        Me.txt_cidade.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_cidade.Location = New System.Drawing.Point(24, 225)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(313, 32)
        Me.txt_cidade.TabIndex = 14
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel10.Location = New System.Drawing.Point(25, 199)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(56, 20)
        Me.GunaLabel10.TabIndex = 13
        Me.GunaLabel10.Text = "Cidade"
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_bairro.Location = New System.Drawing.Point(813, 143)
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
        Me.GunaLabel9.Location = New System.Drawing.Point(815, 118)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(51, 20)
        Me.GunaLabel9.TabIndex = 11
        Me.GunaLabel9.Text = "Bairro"
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_numero.Location = New System.Drawing.Point(692, 143)
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
        Me.GunaLabel8.Location = New System.Drawing.Point(691, 118)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(66, 20)
        Me.GunaLabel8.TabIndex = 9
        Me.GunaLabel8.Text = "Numero"
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_endereco.Location = New System.Drawing.Point(25, 143)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(615, 32)
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
        Me.txt_cep.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_cep.Location = New System.Drawing.Point(25, 66)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cep.Mask = "99999-999"
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
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(894, 118)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 170)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox5.Controls.Add(Me.cmb_status_conta)
        Me.GroupBox5.Controls.Add(Me.lbl_status)
        Me.GroupBox5.Controls.Add(Me.txt_senha)
        Me.GroupBox5.Controls.Add(Me.GunaLabel17)
        Me.GroupBox5.Controls.Add(Me.txt_usuario)
        Me.GroupBox5.Controls.Add(Me.GunaLabel16)
        Me.GroupBox5.Controls.Add(Me.rb_operador)
        Me.GroupBox5.Controls.Add(Me.rb_admin)
        Me.GroupBox5.Controls.Add(Me.cmb_cargo)
        Me.GroupBox5.Controls.Add(Me.GunaLabel14)
        Me.GroupBox5.Controls.Add(Me.GunaLabel15)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox5.Location = New System.Drawing.Point(675, 319)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(555, 282)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Operacional"
        '
        'cmb_status_conta
        '
        Me.cmb_status_conta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status_conta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_status_conta.FormattingEnabled = True
        Me.cmb_status_conta.Items.AddRange(New Object() {"Ativo", "Bloqueado", "Excluído"})
        Me.cmb_status_conta.Location = New System.Drawing.Point(27, 225)
        Me.cmb_status_conta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_status_conta.Name = "cmb_status_conta"
        Me.cmb_status_conta.Size = New System.Drawing.Size(199, 28)
        Me.cmb_status_conta.TabIndex = 16
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_status.Location = New System.Drawing.Point(23, 192)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(50, 20)
        Me.lbl_status.TabIndex = 15
        Me.lbl_status.Text = "Status"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_senha.Location = New System.Drawing.Point(263, 150)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(201, 32)
        Me.txt_senha.TabIndex = 14
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'GunaLabel17
        '
        Me.GunaLabel17.AutoSize = True
        Me.GunaLabel17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel17.Location = New System.Drawing.Point(264, 125)
        Me.GunaLabel17.Name = "GunaLabel17"
        Me.GunaLabel17.Size = New System.Drawing.Size(51, 20)
        Me.GunaLabel17.TabIndex = 13
        Me.GunaLabel17.Text = "Senha"
        '
        'txt_usuario
        '
        Me.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_usuario.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_usuario.Location = New System.Drawing.Point(27, 150)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(201, 32)
        Me.txt_usuario.TabIndex = 12
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel16.Location = New System.Drawing.Point(21, 125)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(62, 20)
        Me.GunaLabel16.TabIndex = 11
        Me.GunaLabel16.Text = "Usuário"
        '
        'rb_operador
        '
        Me.rb_operador.AutoSize = True
        Me.rb_operador.Checked = True
        Me.rb_operador.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rb_operador.Location = New System.Drawing.Point(263, 78)
        Me.rb_operador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_operador.Name = "rb_operador"
        Me.rb_operador.Size = New System.Drawing.Size(96, 24)
        Me.rb_operador.TabIndex = 10
        Me.rb_operador.TabStop = True
        Me.rb_operador.Text = "Operador"
        Me.rb_operador.UseVisualStyleBackColor = True
        '
        'rb_admin
        '
        Me.rb_admin.AutoSize = True
        Me.rb_admin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_admin.Location = New System.Drawing.Point(379, 78)
        Me.rb_admin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_admin.Name = "rb_admin"
        Me.rb_admin.Size = New System.Drawing.Size(132, 24)
        Me.rb_admin.TabIndex = 9
        Me.rb_admin.Text = "Administrador"
        Me.rb_admin.UseVisualStyleBackColor = True
        '
        'cmb_cargo
        '
        Me.cmb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cargo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Items.AddRange(New Object() {"Gerente", "Cerimonialista", "Vendedor"})
        Me.cmb_cargo.Location = New System.Drawing.Point(27, 69)
        Me.cmb_cargo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(199, 33)
        Me.cmb_cargo.TabIndex = 8
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel14.Location = New System.Drawing.Point(259, 41)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(45, 20)
        Me.GunaLabel14.TabIndex = 7
        Me.GunaLabel14.Text = "Nivel"
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel15.Location = New System.Drawing.Point(21, 41)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(158, 20)
        Me.GunaLabel15.TabIndex = 6
        Me.GunaLabel15.Text = "Cargo do Funcionário"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btn_salvar)
        Me.Panel3.Controls.Add(Me.btn_limpar)
        Me.Panel3.Controls.Add(Me.btn_fechar)
        Me.Panel3.Location = New System.Drawing.Point(0, 938)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1299, 84)
        Me.Panel3.TabIndex = 34
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
        'frm_cadastro_funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1299, 881)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_cadastro_funcionario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_whatsapp As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dt_nascimento As DateTimePicker
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_cargo As ComboBox
    Friend WithEvents rb_operador As RadioButton
    Friend WithEvents rb_admin As RadioButton
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents GunaLabel17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents cmb_status_conta As ComboBox
    Friend WithEvents lbl_status As Guna.UI.WinForms.GunaLabel
End Class
