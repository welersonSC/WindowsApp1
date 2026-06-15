<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_gestao_eventos
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
        Me.dtp_data_fim = New System.Windows.Forms.DateTimePicker()
        Me.dtp_data_inicio = New System.Windows.Forms.DateTimePicker()
        Me.cmb_status_filtro = New System.Windows.Forms.ComboBox()
        Me.btn_novofunc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_eventos = New System.Windows.Forms.DataGridView()
        Me.col_id_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_excluir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_eventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtp_data_fim)
        Me.Panel1.Controls.Add(Me.dtp_data_inicio)
        Me.Panel1.Controls.Add(Me.cmb_status_filtro)
        Me.Panel1.Controls.Add(Me.btn_novofunc)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(73, 45)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1185, 100)
        Me.Panel1.TabIndex = 6
        '
        'dtp_data_fim
        '
        Me.dtp_data_fim.CalendarFont = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.dtp_data_fim.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.dtp_data_fim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data_fim.Location = New System.Drawing.Point(822, 42)
        Me.dtp_data_fim.Name = "dtp_data_fim"
        Me.dtp_data_fim.ShowCheckBox = True
        Me.dtp_data_fim.Size = New System.Drawing.Size(135, 30)
        Me.dtp_data_fim.TabIndex = 5
        Me.dtp_data_fim.Value = New Date(2026, 6, 7, 0, 0, 0, 0)
        '
        'dtp_data_inicio
        '
        Me.dtp_data_inicio.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_data_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data_inicio.Location = New System.Drawing.Point(648, 42)
        Me.dtp_data_inicio.Name = "dtp_data_inicio"
        Me.dtp_data_inicio.ShowCheckBox = True
        Me.dtp_data_inicio.Size = New System.Drawing.Size(168, 30)
        Me.dtp_data_inicio.TabIndex = 4
        Me.dtp_data_inicio.Value = New Date(2026, 6, 7, 0, 0, 0, 0)
        '
        'cmb_status_filtro
        '
        Me.cmb_status_filtro.AutoCompleteCustomSource.AddRange(New String() {"Todos", "Orçamentos", "Confirmado", "Cancelados", "Finalizados"})
        Me.cmb_status_filtro.FormattingEnabled = True
        Me.cmb_status_filtro.Items.AddRange(New Object() {"Todos", "Orçamentos", "Confirmados", "Cancelados", "Finalizados"})
        Me.cmb_status_filtro.Location = New System.Drawing.Point(411, 42)
        Me.cmb_status_filtro.Name = "cmb_status_filtro"
        Me.cmb_status_filtro.Size = New System.Drawing.Size(174, 24)
        Me.cmb_status_filtro.TabIndex = 3
        '
        'btn_novofunc
        '
        Me.btn_novofunc.AccessibleDescription = "btn_novofunc"
        Me.btn_novofunc.AccessibleName = "btn_novofunc"
        Me.btn_novofunc.BackColor = System.Drawing.Color.Gold
        Me.btn_novofunc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_novofunc.Location = New System.Drawing.Point(975, 31)
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
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EVENTOS"
        '
        'dgv_eventos
        '
        Me.dgv_eventos.AllowUserToAddRows = False
        Me.dgv_eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_eventos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_evento, Me.col_data, Me.col_cliente, Me.col_status, Me.col_valor, Me.col_editar, Me.col_excluir})
        Me.dgv_eventos.Location = New System.Drawing.Point(73, 184)
        Me.dgv_eventos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_eventos.Name = "dgv_eventos"
        Me.dgv_eventos.RowHeadersVisible = False
        Me.dgv_eventos.RowHeadersWidth = 51
        Me.dgv_eventos.RowTemplate.Height = 24
        Me.dgv_eventos.Size = New System.Drawing.Size(1185, 385)
        Me.dgv_eventos.TabIndex = 5
        '
        'col_id_evento
        '
        Me.col_id_evento.HeaderText = "Cód."
        Me.col_id_evento.MinimumWidth = 6
        Me.col_id_evento.Name = "col_id_evento"
        Me.col_id_evento.Width = 90
        '
        'col_data
        '
        Me.col_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_data.HeaderText = "Data"
        Me.col_data.MinimumWidth = 6
        Me.col_data.Name = "col_data"
        Me.col_data.Width = 125
        '
        'col_cliente
        '
        Me.col_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_cliente.HeaderText = "Cliente"
        Me.col_cliente.MinimumWidth = 6
        Me.col_cliente.Name = "col_cliente"
        '
        'col_status
        '
        Me.col_status.HeaderText = "Status"
        Me.col_status.MinimumWidth = 6
        Me.col_status.Name = "col_status"
        Me.col_status.Width = 160
        '
        'col_valor
        '
        Me.col_valor.HeaderText = "Valor Total (R$)"
        Me.col_valor.MinimumWidth = 6
        Me.col_valor.Name = "col_valor"
        Me.col_valor.Width = 140
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
        'uc_gestao_eventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_eventos)
        Me.Name = "uc_gestao_eventos"
        Me.Size = New System.Drawing.Size(1337, 652)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_eventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_novofunc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_eventos As DataGridView
    Friend WithEvents dtp_data_fim As DateTimePicker
    Friend WithEvents dtp_data_inicio As DateTimePicker
    Friend WithEvents cmb_status_filtro As ComboBox
    Friend WithEvents col_id_evento As DataGridViewTextBoxColumn
    Friend WithEvents col_data As DataGridViewTextBoxColumn
    Friend WithEvents col_cliente As DataGridViewTextBoxColumn
    Friend WithEvents col_status As DataGridViewTextBoxColumn
    Friend WithEvents col_valor As DataGridViewTextBoxColumn
    Friend WithEvents col_editar As DataGridViewButtonColumn
    Friend WithEvents col_excluir As DataGridViewButtonColumn
End Class
