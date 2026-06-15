<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_novo_evento
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbp_dados_evento = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_proximo_1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp_hora_inicio = New System.Windows.Forms.DateTimePicker()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_buscar_cpf = New System.Windows.Forms.Button()
        Me.mtb_cpf_busca = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nome_cliente = New System.Windows.Forms.TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tlp_calendario = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_mes_anterior = New System.Windows.Forms.Button()
        Me.btn_mes_seguinte = New System.Windows.Forms.Button()
        Me.lbl_data_escolhida = New System.Windows.Forms.Label()
        Me.lbl_mes_ano = New System.Windows.Forms.Label()
        Me.tbp_pacotes_servicos = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_voltar_2 = New System.Windows.Forms.Button()
        Me.btn_proximo_2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_remover_item = New System.Windows.Forms.Button()
        Me.dgv_carrinho = New System.Windows.Forms.DataGridView()
        Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_valor_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_adicionar_extra = New System.Windows.Forms.Button()
        Me.txt_valor_unitario = New System.Windows.Forms.TextBox()
        Me.lbl_valor_unitario = New Guna.UI.WinForms.GunaLabel()
        Me.nud_qtd_item = New System.Windows.Forms.NumericUpDown()
        Me.cmb_item_extra = New System.Windows.Forms.ComboBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_quantidade = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_valor_pacote = New System.Windows.Forms.TextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_pacote_principal = New System.Windows.Forms.ComboBox()
        Me.lbl_pacote_principal = New Guna.UI.WinForms.GunaLabel()
        Me.nud_qtd_pessoas = New System.Windows.Forms.NumericUpDown()
        Me.cmb_tipo_evento = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo_evento = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_qtd_pessoas = New Guna.UI.WinForms.GunaLabel()
        Me.tbp_financeiro_contrato = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_voltar_3 = New System.Windows.Forms.Button()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_metodo_pagamento = New System.Windows.Forms.ComboBox()
        Me.lbl_metodo_pagamento = New Guna.UI.WinForms.GunaLabel()
        Me.grp_resumo_financeiro = New System.Windows.Forms.GroupBox()
        Me.txt_total_final = New System.Windows.Forms.TextBox()
        Me.lbl_total_final = New Guna.UI.WinForms.GunaLabel()
        Me.txt_desconto = New System.Windows.Forms.TextBox()
        Me.lbl_desconto = New Guna.UI.WinForms.GunaLabel()
        Me.txt_subtotal_pacote = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_subtotal_pacote = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.tbp_dados_evento.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbp_pacotes_servicos.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_carrinho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nud_qtd_item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nud_qtd_pessoas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp_financeiro_contrato.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.grp_resumo_financeiro.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 1038)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1165, 17)
        Me.Panel2.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbp_dados_evento)
        Me.TabControl1.Controls.Add(Me.tbp_pacotes_servicos)
        Me.TabControl1.Controls.Add(Me.tbp_financeiro_contrato)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(50, 60)
        Me.TabControl1.Location = New System.Drawing.Point(0, 100)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1165, 938)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 4
        '
        'tbp_dados_evento
        '
        Me.tbp_dados_evento.AutoScroll = True
        Me.tbp_dados_evento.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tbp_dados_evento.Controls.Add(Me.Panel3)
        Me.tbp_dados_evento.Controls.Add(Me.GroupBox3)
        Me.tbp_dados_evento.Controls.Add(Me.GroupBox2)
        Me.tbp_dados_evento.Controls.Add(Me.GroupBox1)
        Me.tbp_dados_evento.Location = New System.Drawing.Point(4, 64)
        Me.tbp_dados_evento.Name = "tbp_dados_evento"
        Me.tbp_dados_evento.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_dados_evento.Size = New System.Drawing.Size(1157, 870)
        Me.tbp_dados_evento.TabIndex = 0
        Me.tbp_dados_evento.Text = "TabPage1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_proximo_1)
        Me.Panel3.Location = New System.Drawing.Point(0, 800)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1133, 100)
        Me.Panel3.TabIndex = 19
        '
        'btn_proximo_1
        '
        Me.btn_proximo_1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_proximo_1.ForeColor = System.Drawing.Color.Goldenrod
        Me.btn_proximo_1.Location = New System.Drawing.Point(938, 33)
        Me.btn_proximo_1.Name = "btn_proximo_1"
        Me.btn_proximo_1.Size = New System.Drawing.Size(157, 45)
        Me.btn_proximo_1.TabIndex = 0
        Me.btn_proximo_1.Text = "Próxima"
        Me.btn_proximo_1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.dtp_hora_inicio)
        Me.GroupBox3.Controls.Add(Me.GunaLabel3)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox3.Location = New System.Drawing.Point(680, 292)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(415, 166)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "HORÁRIO"
        '
        'dtp_hora_inicio
        '
        Me.dtp_hora_inicio.CustomFormat = "HH:mm"
        Me.dtp_hora_inicio.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_hora_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_hora_inicio.Location = New System.Drawing.Point(25, 80)
        Me.dtp_hora_inicio.Name = "dtp_hora_inicio"
        Me.dtp_hora_inicio.ShowUpDown = True
        Me.dtp_hora_inicio.Size = New System.Drawing.Size(110, 31)
        Me.dtp_hora_inicio.TabIndex = 2
        Me.dtp_hora_inicio.Value = New Date(2026, 6, 7, 17, 13, 0, 0)
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel3.Location = New System.Drawing.Point(21, 57)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(46, 20)
        Me.GunaLabel3.TabIndex = 1
        Me.GunaLabel3.Text = "Inicio"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.btn_buscar_cpf)
        Me.GroupBox2.Controls.Add(Me.mtb_cpf_busca)
        Me.GroupBox2.Controls.Add(Me.txt_nome_cliente)
        Me.GroupBox2.Controls.Add(Me.GunaLabel2)
        Me.GroupBox2.Controls.Add(Me.GunaLabel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox2.Location = New System.Drawing.Point(57, 28)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(607, 225)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DADOS DE IDENTIFICAÇÃO"
        '
        'btn_buscar_cpf
        '
        Me.btn_buscar_cpf.Location = New System.Drawing.Point(205, 80)
        Me.btn_buscar_cpf.Name = "btn_buscar_cpf"
        Me.btn_buscar_cpf.Size = New System.Drawing.Size(73, 35)
        Me.btn_buscar_cpf.TabIndex = 5
        Me.btn_buscar_cpf.Text = "🔎"
        Me.btn_buscar_cpf.UseVisualStyleBackColor = True
        '
        'mtb_cpf_busca
        '
        Me.mtb_cpf_busca.AccessibleDescription = "txt_cpf"
        Me.mtb_cpf_busca.AccessibleName = "txt_cpf"
        Me.mtb_cpf_busca.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.mtb_cpf_busca.Location = New System.Drawing.Point(25, 84)
        Me.mtb_cpf_busca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtb_cpf_busca.Mask = "999,999,999-99"
        Me.mtb_cpf_busca.Name = "mtb_cpf_busca"
        Me.mtb_cpf_busca.Size = New System.Drawing.Size(145, 32)
        Me.mtb_cpf_busca.TabIndex = 4
        Me.mtb_cpf_busca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nome_cliente
        '
        Me.txt_nome_cliente.AccessibleDescription = ""
        Me.txt_nome_cliente.AccessibleName = ""
        Me.txt_nome_cliente.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txt_nome_cliente.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_nome_cliente.Location = New System.Drawing.Point(25, 163)
        Me.txt_nome_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nome_cliente.Name = "txt_nome_cliente"
        Me.txt_nome_cliente.ReadOnly = True
        Me.txt_nome_cliente.Size = New System.Drawing.Size(529, 32)
        Me.txt_nome_cliente.TabIndex = 3
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel2.Location = New System.Drawing.Point(21, 62)
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
        Me.GunaLabel1.Location = New System.Drawing.Point(21, 132)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(56, 20)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.tlp_calendario)
        Me.GroupBox1.Controls.Add(Me.btn_mes_anterior)
        Me.GroupBox1.Controls.Add(Me.btn_mes_seguinte)
        Me.GroupBox1.Controls.Add(Me.lbl_data_escolhida)
        Me.GroupBox1.Controls.Add(Me.lbl_mes_ano)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox1.Location = New System.Drawing.Point(57, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 478)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AGENDA"
        '
        'tlp_calendario
        '
        Me.tlp_calendario.ColumnCount = 7
        Me.tlp_calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlp_calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp_calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp_calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp_calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp_calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp_calendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp_calendario.Location = New System.Drawing.Point(46, 105)
        Me.tlp_calendario.Name = "tlp_calendario"
        Me.tlp_calendario.RowCount = 7
        Me.tlp_calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.06689!))
        Me.tlp_calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.37793!))
        Me.tlp_calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.37793!))
        Me.tlp_calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.37793!))
        Me.tlp_calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.37793!))
        Me.tlp_calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.37793!))
        Me.tlp_calendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348!))
        Me.tlp_calendario.Size = New System.Drawing.Size(520, 316)
        Me.tlp_calendario.TabIndex = 0
        '
        'btn_mes_anterior
        '
        Me.btn_mes_anterior.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mes_anterior.Location = New System.Drawing.Point(64, 52)
        Me.btn_mes_anterior.Name = "btn_mes_anterior"
        Me.btn_mes_anterior.Size = New System.Drawing.Size(45, 47)
        Me.btn_mes_anterior.TabIndex = 13
        Me.btn_mes_anterior.Text = "<"
        Me.btn_mes_anterior.UseVisualStyleBackColor = True
        '
        'btn_mes_seguinte
        '
        Me.btn_mes_seguinte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mes_seguinte.Location = New System.Drawing.Point(505, 52)
        Me.btn_mes_seguinte.Name = "btn_mes_seguinte"
        Me.btn_mes_seguinte.Size = New System.Drawing.Size(45, 47)
        Me.btn_mes_seguinte.TabIndex = 14
        Me.btn_mes_seguinte.Text = ">"
        Me.btn_mes_seguinte.UseVisualStyleBackColor = True
        '
        'lbl_data_escolhida
        '
        Me.lbl_data_escolhida.AutoSize = True
        Me.lbl_data_escolhida.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_escolhida.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_data_escolhida.Location = New System.Drawing.Point(227, 434)
        Me.lbl_data_escolhida.Name = "lbl_data_escolhida"
        Me.lbl_data_escolhida.Size = New System.Drawing.Size(136, 23)
        Me.lbl_data_escolhida.TabIndex = 15
        Me.lbl_data_escolhida.Text = "Não selecionada"
        '
        'lbl_mes_ano
        '
        Me.lbl_mes_ano.AutoSize = True
        Me.lbl_mes_ano.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mes_ano.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_mes_ano.Location = New System.Drawing.Point(226, 54)
        Me.lbl_mes_ano.Name = "lbl_mes_ano"
        Me.lbl_mes_ano.Size = New System.Drawing.Size(74, 28)
        Me.lbl_mes_ano.TabIndex = 1
        Me.lbl_mes_ano.Text = "Label2"
        '
        'tbp_pacotes_servicos
        '
        Me.tbp_pacotes_servicos.AllowDrop = True
        Me.tbp_pacotes_servicos.AutoScroll = True
        Me.tbp_pacotes_servicos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tbp_pacotes_servicos.Controls.Add(Me.Panel5)
        Me.tbp_pacotes_servicos.Controls.Add(Me.Panel4)
        Me.tbp_pacotes_servicos.Controls.Add(Me.GroupBox5)
        Me.tbp_pacotes_servicos.Controls.Add(Me.GroupBox4)
        Me.tbp_pacotes_servicos.Location = New System.Drawing.Point(4, 64)
        Me.tbp_pacotes_servicos.Name = "tbp_pacotes_servicos"
        Me.tbp_pacotes_servicos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_pacotes_servicos.Size = New System.Drawing.Size(1157, 870)
        Me.tbp_pacotes_servicos.TabIndex = 1
        Me.tbp_pacotes_servicos.Text = "TabPage2"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_voltar_2)
        Me.Panel5.Controls.Add(Me.btn_proximo_2)
        Me.Panel5.Location = New System.Drawing.Point(24, 748)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1133, 100)
        Me.Panel5.TabIndex = 21
        '
        'btn_voltar_2
        '
        Me.btn_voltar_2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar_2.ForeColor = System.Drawing.Color.Goldenrod
        Me.btn_voltar_2.Location = New System.Drawing.Point(27, 29)
        Me.btn_voltar_2.Name = "btn_voltar_2"
        Me.btn_voltar_2.Size = New System.Drawing.Size(157, 45)
        Me.btn_voltar_2.TabIndex = 1
        Me.btn_voltar_2.Text = "Anterior"
        Me.btn_voltar_2.UseVisualStyleBackColor = True
        '
        'btn_proximo_2
        '
        Me.btn_proximo_2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_proximo_2.ForeColor = System.Drawing.Color.Goldenrod
        Me.btn_proximo_2.Location = New System.Drawing.Point(938, 29)
        Me.btn_proximo_2.Name = "btn_proximo_2"
        Me.btn_proximo_2.Size = New System.Drawing.Size(157, 45)
        Me.btn_proximo_2.TabIndex = 0
        Me.btn_proximo_2.Text = "Próxima"
        Me.btn_proximo_2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.btn_remover_item)
        Me.Panel4.Controls.Add(Me.dgv_carrinho)
        Me.Panel4.Location = New System.Drawing.Point(595, 405)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(554, 316)
        Me.Panel4.TabIndex = 20
        '
        'btn_remover_item
        '
        Me.btn_remover_item.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_remover_item.ForeColor = System.Drawing.Color.Goldenrod
        Me.btn_remover_item.Location = New System.Drawing.Point(395, 257)
        Me.btn_remover_item.Name = "btn_remover_item"
        Me.btn_remover_item.Size = New System.Drawing.Size(145, 37)
        Me.btn_remover_item.TabIndex = 12
        Me.btn_remover_item.Text = "❌ Remover"
        Me.btn_remover_item.UseVisualStyleBackColor = True
        '
        'dgv_carrinho
        '
        Me.dgv_carrinho.AllowUserToAddRows = False
        Me.dgv_carrinho.AllowUserToDeleteRows = False
        Me.dgv_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_carrinho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_item, Me.col_qtd, Me.col_valor_unitario, Me.col_subtotal})
        Me.dgv_carrinho.Location = New System.Drawing.Point(15, 35)
        Me.dgv_carrinho.Name = "dgv_carrinho"
        Me.dgv_carrinho.ReadOnly = True
        Me.dgv_carrinho.RowHeadersVisible = False
        Me.dgv_carrinho.RowHeadersWidth = 51
        Me.dgv_carrinho.RowTemplate.Height = 24
        Me.dgv_carrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_carrinho.Size = New System.Drawing.Size(525, 206)
        Me.dgv_carrinho.TabIndex = 11
        '
        'col_item
        '
        Me.col_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_item.HeaderText = "Adicional"
        Me.col_item.MinimumWidth = 6
        Me.col_item.Name = "col_item"
        Me.col_item.ReadOnly = True
        '
        'col_qtd
        '
        Me.col_qtd.HeaderText = "Qtd."
        Me.col_qtd.MinimumWidth = 6
        Me.col_qtd.Name = "col_qtd"
        Me.col_qtd.ReadOnly = True
        Me.col_qtd.Width = 60
        '
        'col_valor_unitario
        '
        Me.col_valor_unitario.HeaderText = "Valor Unit. (R$)"
        Me.col_valor_unitario.MinimumWidth = 6
        Me.col_valor_unitario.Name = "col_valor_unitario"
        Me.col_valor_unitario.ReadOnly = True
        Me.col_valor_unitario.Width = 125
        '
        'col_subtotal
        '
        Me.col_subtotal.HeaderText = "Subtotal (R$)"
        Me.col_subtotal.MinimumWidth = 6
        Me.col_subtotal.Name = "col_subtotal"
        Me.col_subtotal.ReadOnly = True
        Me.col_subtotal.Width = 125
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox5.Controls.Add(Me.btn_adicionar_extra)
        Me.GroupBox5.Controls.Add(Me.txt_valor_unitario)
        Me.GroupBox5.Controls.Add(Me.lbl_valor_unitario)
        Me.GroupBox5.Controls.Add(Me.nud_qtd_item)
        Me.GroupBox5.Controls.Add(Me.cmb_item_extra)
        Me.GroupBox5.Controls.Add(Me.GunaLabel7)
        Me.GroupBox5.Controls.Add(Me.lbl_quantidade)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox5.Location = New System.Drawing.Point(36, 405)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(533, 316)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ITENS E SERVIÇOS ADICIONAIS"
        '
        'btn_adicionar_extra
        '
        Me.btn_adicionar_extra.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar_extra.Location = New System.Drawing.Point(351, 172)
        Me.btn_adicionar_extra.Name = "btn_adicionar_extra"
        Me.btn_adicionar_extra.Size = New System.Drawing.Size(128, 48)
        Me.btn_adicionar_extra.TabIndex = 10
        Me.btn_adicionar_extra.Text = "+ Adicionar"
        Me.btn_adicionar_extra.UseVisualStyleBackColor = True
        '
        'txt_valor_unitario
        '
        Me.txt_valor_unitario.Location = New System.Drawing.Point(25, 182)
        Me.txt_valor_unitario.Name = "txt_valor_unitario"
        Me.txt_valor_unitario.ReadOnly = True
        Me.txt_valor_unitario.Size = New System.Drawing.Size(147, 38)
        Me.txt_valor_unitario.TabIndex = 9
        '
        'lbl_valor_unitario
        '
        Me.lbl_valor_unitario.AutoSize = True
        Me.lbl_valor_unitario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor_unitario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_valor_unitario.Location = New System.Drawing.Point(20, 150)
        Me.lbl_valor_unitario.Name = "lbl_valor_unitario"
        Me.lbl_valor_unitario.Size = New System.Drawing.Size(117, 20)
        Me.lbl_valor_unitario.TabIndex = 8
        Me.lbl_valor_unitario.Text = "Valor Unit. (R$):"
        '
        'nud_qtd_item
        '
        Me.nud_qtd_item.Location = New System.Drawing.Point(359, 88)
        Me.nud_qtd_item.Name = "nud_qtd_item"
        Me.nud_qtd_item.Size = New System.Drawing.Size(120, 38)
        Me.nud_qtd_item.TabIndex = 5
        '
        'cmb_item_extra
        '
        Me.cmb_item_extra.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cmb_item_extra.FormattingEnabled = True
        Me.cmb_item_extra.Location = New System.Drawing.Point(25, 90)
        Me.cmb_item_extra.Name = "cmb_item_extra"
        Me.cmb_item_extra.Size = New System.Drawing.Size(294, 33)
        Me.cmb_item_extra.TabIndex = 4
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel7.Location = New System.Drawing.Point(21, 62)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(202, 20)
        Me.GunaLabel7.TabIndex = 1
        Me.GunaLabel7.Text = "Produto / Serviço Adicional:"
        '
        'lbl_quantidade
        '
        Me.lbl_quantidade.AutoSize = True
        Me.lbl_quantidade.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantidade.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_quantidade.Location = New System.Drawing.Point(355, 62)
        Me.lbl_quantidade.Name = "lbl_quantidade"
        Me.lbl_quantidade.Size = New System.Drawing.Size(56, 20)
        Me.lbl_quantidade.TabIndex = 0
        Me.lbl_quantidade.Text = "Cliente"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Me.txt_valor_pacote)
        Me.GroupBox4.Controls.Add(Me.GunaLabel4)
        Me.GroupBox4.Controls.Add(Me.cmb_pacote_principal)
        Me.GroupBox4.Controls.Add(Me.lbl_pacote_principal)
        Me.GroupBox4.Controls.Add(Me.nud_qtd_pessoas)
        Me.GroupBox4.Controls.Add(Me.cmb_tipo_evento)
        Me.GroupBox4.Controls.Add(Me.lbl_tipo_evento)
        Me.GroupBox4.Controls.Add(Me.lbl_qtd_pessoas)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox4.Location = New System.Drawing.Point(36, 36)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(607, 300)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PACOTE"
        '
        'txt_valor_pacote
        '
        Me.txt_valor_pacote.Location = New System.Drawing.Point(360, 192)
        Me.txt_valor_pacote.Name = "txt_valor_pacote"
        Me.txt_valor_pacote.ReadOnly = True
        Me.txt_valor_pacote.Size = New System.Drawing.Size(147, 38)
        Me.txt_valor_pacote.TabIndex = 9
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel4.Location = New System.Drawing.Point(355, 160)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(152, 20)
        Me.GunaLabel4.TabIndex = 8
        Me.GunaLabel4.Text = "Valor do Pacote (R$):"
        '
        'cmb_pacote_principal
        '
        Me.cmb_pacote_principal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cmb_pacote_principal.FormattingEnabled = True
        Me.cmb_pacote_principal.Location = New System.Drawing.Point(25, 193)
        Me.cmb_pacote_principal.Name = "cmb_pacote_principal"
        Me.cmb_pacote_principal.Size = New System.Drawing.Size(294, 33)
        Me.cmb_pacote_principal.TabIndex = 7
        '
        'lbl_pacote_principal
        '
        Me.lbl_pacote_principal.AutoSize = True
        Me.lbl_pacote_principal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pacote_principal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_pacote_principal.Location = New System.Drawing.Point(21, 160)
        Me.lbl_pacote_principal.Name = "lbl_pacote_principal"
        Me.lbl_pacote_principal.Size = New System.Drawing.Size(90, 20)
        Me.lbl_pacote_principal.TabIndex = 6
        Me.lbl_pacote_principal.Text = "Pacote Base"
        '
        'nud_qtd_pessoas
        '
        Me.nud_qtd_pessoas.Location = New System.Drawing.Point(359, 88)
        Me.nud_qtd_pessoas.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nud_qtd_pessoas.Name = "nud_qtd_pessoas"
        Me.nud_qtd_pessoas.Size = New System.Drawing.Size(120, 38)
        Me.nud_qtd_pessoas.TabIndex = 5
        '
        'cmb_tipo_evento
        '
        Me.cmb_tipo_evento.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_evento.FormattingEnabled = True
        Me.cmb_tipo_evento.Items.AddRange(New Object() {"Aniversário", "Casamento", "Corporativo", ""})
        Me.cmb_tipo_evento.Location = New System.Drawing.Point(25, 90)
        Me.cmb_tipo_evento.Name = "cmb_tipo_evento"
        Me.cmb_tipo_evento.Size = New System.Drawing.Size(294, 33)
        Me.cmb_tipo_evento.TabIndex = 4
        '
        'lbl_tipo_evento
        '
        Me.lbl_tipo_evento.AutoSize = True
        Me.lbl_tipo_evento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_evento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_tipo_evento.Location = New System.Drawing.Point(21, 62)
        Me.lbl_tipo_evento.Name = "lbl_tipo_evento"
        Me.lbl_tipo_evento.Size = New System.Drawing.Size(111, 20)
        Me.lbl_tipo_evento.TabIndex = 1
        Me.lbl_tipo_evento.Text = "Tipo de evento"
        '
        'lbl_qtd_pessoas
        '
        Me.lbl_qtd_pessoas.AutoSize = True
        Me.lbl_qtd_pessoas.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qtd_pessoas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_qtd_pessoas.Location = New System.Drawing.Point(355, 62)
        Me.lbl_qtd_pessoas.Name = "lbl_qtd_pessoas"
        Me.lbl_qtd_pessoas.Size = New System.Drawing.Size(89, 20)
        Me.lbl_qtd_pessoas.TabIndex = 0
        Me.lbl_qtd_pessoas.Text = "Convidados"
        '
        'tbp_financeiro_contrato
        '
        Me.tbp_financeiro_contrato.AutoScroll = True
        Me.tbp_financeiro_contrato.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tbp_financeiro_contrato.Controls.Add(Me.Panel6)
        Me.tbp_financeiro_contrato.Controls.Add(Me.GroupBox6)
        Me.tbp_financeiro_contrato.Controls.Add(Me.grp_resumo_financeiro)
        Me.tbp_financeiro_contrato.Location = New System.Drawing.Point(4, 64)
        Me.tbp_financeiro_contrato.Name = "tbp_financeiro_contrato"
        Me.tbp_financeiro_contrato.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_financeiro_contrato.Size = New System.Drawing.Size(1157, 870)
        Me.tbp_financeiro_contrato.TabIndex = 2
        Me.tbp_financeiro_contrato.Text = "TabPage3"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btn_voltar_3)
        Me.Panel6.Controls.Add(Me.btn_finalizar)
        Me.Panel6.Location = New System.Drawing.Point(16, 750)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1133, 100)
        Me.Panel6.TabIndex = 22
        '
        'btn_voltar_3
        '
        Me.btn_voltar_3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar_3.ForeColor = System.Drawing.Color.Goldenrod
        Me.btn_voltar_3.Location = New System.Drawing.Point(27, 29)
        Me.btn_voltar_3.Name = "btn_voltar_3"
        Me.btn_voltar_3.Size = New System.Drawing.Size(157, 45)
        Me.btn_voltar_3.TabIndex = 1
        Me.btn_voltar_3.Text = "Anterior"
        Me.btn_voltar_3.UseVisualStyleBackColor = True
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_finalizar.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_finalizar.ForeColor = System.Drawing.Color.White
        Me.btn_finalizar.Location = New System.Drawing.Point(642, 29)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(453, 45)
        Me.btn_finalizar.TabIndex = 0
        Me.btn_finalizar.Text = "📜 Salvar e Gerar Contrato"
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox6.Controls.Add(Me.GunaLabel6)
        Me.GroupBox6.Controls.Add(Me.cmb_metodo_pagamento)
        Me.GroupBox6.Controls.Add(Me.lbl_metodo_pagamento)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox6.Location = New System.Drawing.Point(46, 403)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(607, 300)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "FORMA E CONDIÇÕES DE PAGAMENTO"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel6.Location = New System.Drawing.Point(22, 156)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(103, 20)
        Me.GunaLabel6.TabIndex = 16
        Me.GunaLabel6.Text = "Parcelamento"
        '
        'cmb_metodo_pagamento
        '
        Me.cmb_metodo_pagamento.AutoCompleteCustomSource.AddRange(New String() {"Dinheiro", "Pix", "Cartão de Débito", "Cartão de Crédito", "Boleto Bancário"})
        Me.cmb_metodo_pagamento.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cmb_metodo_pagamento.FormattingEnabled = True
        Me.cmb_metodo_pagamento.Location = New System.Drawing.Point(26, 101)
        Me.cmb_metodo_pagamento.Name = "cmb_metodo_pagamento"
        Me.cmb_metodo_pagamento.Size = New System.Drawing.Size(253, 33)
        Me.cmb_metodo_pagamento.TabIndex = 15
        '
        'lbl_metodo_pagamento
        '
        Me.lbl_metodo_pagamento.AutoSize = True
        Me.lbl_metodo_pagamento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metodo_pagamento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_metodo_pagamento.Location = New System.Drawing.Point(21, 62)
        Me.lbl_metodo_pagamento.Name = "lbl_metodo_pagamento"
        Me.lbl_metodo_pagamento.Size = New System.Drawing.Size(177, 20)
        Me.lbl_metodo_pagamento.TabIndex = 1
        Me.lbl_metodo_pagamento.Text = "Subtotal do Pacote Base:"
        '
        'grp_resumo_financeiro
        '
        Me.grp_resumo_financeiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grp_resumo_financeiro.Controls.Add(Me.txt_total_final)
        Me.grp_resumo_financeiro.Controls.Add(Me.lbl_total_final)
        Me.grp_resumo_financeiro.Controls.Add(Me.txt_desconto)
        Me.grp_resumo_financeiro.Controls.Add(Me.lbl_desconto)
        Me.grp_resumo_financeiro.Controls.Add(Me.txt_subtotal_pacote)
        Me.grp_resumo_financeiro.Controls.Add(Me.TextBox1)
        Me.grp_resumo_financeiro.Controls.Add(Me.GunaLabel5)
        Me.grp_resumo_financeiro.Controls.Add(Me.lbl_subtotal_pacote)
        Me.grp_resumo_financeiro.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_resumo_financeiro.ForeColor = System.Drawing.Color.Goldenrod
        Me.grp_resumo_financeiro.Location = New System.Drawing.Point(46, 49)
        Me.grp_resumo_financeiro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grp_resumo_financeiro.Name = "grp_resumo_financeiro"
        Me.grp_resumo_financeiro.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grp_resumo_financeiro.Size = New System.Drawing.Size(607, 300)
        Me.grp_resumo_financeiro.TabIndex = 19
        Me.grp_resumo_financeiro.TabStop = False
        Me.grp_resumo_financeiro.Text = "RESUMO DOS VALORES"
        '
        'txt_total_final
        '
        Me.txt_total_final.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_final.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_total_final.Location = New System.Drawing.Point(325, 205)
        Me.txt_total_final.Name = "txt_total_final"
        Me.txt_total_final.ReadOnly = True
        Me.txt_total_final.Size = New System.Drawing.Size(213, 38)
        Me.txt_total_final.TabIndex = 14
        Me.txt_total_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_total_final
        '
        Me.lbl_total_final.AutoSize = True
        Me.lbl_total_final.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_final.ForeColor = System.Drawing.Color.Goldenrod
        Me.lbl_total_final.Location = New System.Drawing.Point(320, 168)
        Me.lbl_total_final.Name = "lbl_total_final"
        Me.lbl_total_final.Size = New System.Drawing.Size(218, 25)
        Me.lbl_total_final.TabIndex = 13
        Me.lbl_total_final.Text = "TOTAL GERAL A PAGAR:"
        '
        'txt_desconto
        '
        Me.txt_desconto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desconto.Location = New System.Drawing.Point(26, 205)
        Me.txt_desconto.Name = "txt_desconto"
        Me.txt_desconto.Size = New System.Drawing.Size(161, 34)
        Me.txt_desconto.TabIndex = 12
        Me.txt_desconto.Text = "0,00"
        Me.txt_desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_desconto
        '
        Me.lbl_desconto.AutoSize = True
        Me.lbl_desconto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desconto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_desconto.Location = New System.Drawing.Point(21, 173)
        Me.lbl_desconto.Name = "lbl_desconto"
        Me.lbl_desconto.Size = New System.Drawing.Size(166, 20)
        Me.lbl_desconto.TabIndex = 11
        Me.lbl_desconto.Text = "Desconto Especial (R$):"
        '
        'txt_subtotal_pacote
        '
        Me.txt_subtotal_pacote.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_subtotal_pacote.Location = New System.Drawing.Point(25, 88)
        Me.txt_subtotal_pacote.Name = "txt_subtotal_pacote"
        Me.txt_subtotal_pacote.ReadOnly = True
        Me.txt_subtotal_pacote.Size = New System.Drawing.Size(234, 34)
        Me.txt_subtotal_pacote.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(325, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(199, 34)
        Me.TextBox1.TabIndex = 9
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel5.Location = New System.Drawing.Point(321, 62)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(165, 20)
        Me.GunaLabel5.TabIndex = 8
        Me.GunaLabel5.Text = "Subtotal de Adicionais:"
        '
        'lbl_subtotal_pacote
        '
        Me.lbl_subtotal_pacote.AutoSize = True
        Me.lbl_subtotal_pacote.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal_pacote.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_subtotal_pacote.Location = New System.Drawing.Point(21, 62)
        Me.lbl_subtotal_pacote.Name = "lbl_subtotal_pacote"
        Me.lbl_subtotal_pacote.Size = New System.Drawing.Size(177, 20)
        Me.lbl_subtotal_pacote.TabIndex = 1
        Me.lbl_subtotal_pacote.Text = "Subtotal do Pacote Base:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(517, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Orçamento"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1165, 100)
        Me.Panel1.TabIndex = 2
        '
        'frm_novo_evento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1165, 1055)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_novo_evento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_novo_evento"
        Me.TabControl1.ResumeLayout(False)
        Me.tbp_dados_evento.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbp_pacotes_servicos.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgv_carrinho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nud_qtd_item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nud_qtd_pessoas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp_financeiro_contrato.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.grp_resumo_financeiro.ResumeLayout(False)
        Me.grp_resumo_financeiro.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbp_dados_evento As TabPage
    Friend WithEvents tbp_pacotes_servicos As TabPage
    Friend WithEvents tlp_calendario As TableLayoutPanel
    Friend WithEvents lbl_mes_ano As Label
    Friend WithEvents lbl_data_escolhida As Label
    Friend WithEvents btn_mes_seguinte As Button
    Friend WithEvents btn_mes_anterior As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents mtb_cpf_busca As MaskedTextBox
    Friend WithEvents txt_nome_cliente As TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_buscar_cpf As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtp_hora_inicio As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_proximo_1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbp_financeiro_contrato As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_tipo_evento As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_qtd_pessoas As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_tipo_evento As ComboBox
    Friend WithEvents cmb_pacote_principal As ComboBox
    Friend WithEvents lbl_pacote_principal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents nud_qtd_pessoas As NumericUpDown
    Friend WithEvents txt_valor_pacote As TextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txt_valor_unitario As TextBox
    Friend WithEvents lbl_valor_unitario As Guna.UI.WinForms.GunaLabel
    Friend WithEvents nud_qtd_item As NumericUpDown
    Friend WithEvents cmb_item_extra As ComboBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_quantidade As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_adicionar_extra As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_carrinho As DataGridView
    Friend WithEvents col_item As DataGridViewTextBoxColumn
    Friend WithEvents col_qtd As DataGridViewTextBoxColumn
    Friend WithEvents col_valor_unitario As DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As DataGridViewTextBoxColumn
    Friend WithEvents btn_remover_item As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_voltar_2 As Button
    Friend WithEvents btn_proximo_2 As Button
    Friend WithEvents grp_resumo_financeiro As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_subtotal_pacote As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_subtotal_pacote As TextBox
    Friend WithEvents txt_desconto As TextBox
    Friend WithEvents lbl_desconto As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_total_final As TextBox
    Friend WithEvents lbl_total_final As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cmb_metodo_pagamento As ComboBox
    Friend WithEvents lbl_metodo_pagamento As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_voltar_3 As Button
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
End Class
