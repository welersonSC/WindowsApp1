<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_resumo_mes
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv_tarefas_dia = New System.Windows.Forms.DataGridView()
        Me.col_concluido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_defini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_qtdmes = New System.Windows.Forms.Label()
        Me.lbl_evento_mes = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_agenda_semana = New System.Windows.Forms.DataGridView()
        Me.col_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_tarefas_dia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_agenda_semana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.dgv_tarefas_dia)
        Me.Panel5.Controls.Add(Me.LinkLabel1)
        Me.Panel5.Location = New System.Drawing.Point(32, 313)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1324, 231)
        Me.Panel5.TabIndex = 6
        '
        'dgv_tarefas_dia
        '
        Me.dgv_tarefas_dia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tarefas_dia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_concluido, Me.col_defini, Me.col_ref})
        Me.dgv_tarefas_dia.Location = New System.Drawing.Point(22, 53)
        Me.dgv_tarefas_dia.Name = "dgv_tarefas_dia"
        Me.dgv_tarefas_dia.RowHeadersVisible = False
        Me.dgv_tarefas_dia.RowHeadersWidth = 51
        Me.dgv_tarefas_dia.RowTemplate.Height = 24
        Me.dgv_tarefas_dia.Size = New System.Drawing.Size(1284, 147)
        Me.dgv_tarefas_dia.TabIndex = 1
        '
        'col_concluido
        '
        Me.col_concluido.HeaderText = "Status"
        Me.col_concluido.MinimumWidth = 6
        Me.col_concluido.Name = "col_concluido"
        Me.col_concluido.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_concluido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_concluido.Width = 60
        '
        'col_defini
        '
        Me.col_defini.HeaderText = "Definição"
        Me.col_defini.MinimumWidth = 6
        Me.col_defini.Name = "col_defini"
        Me.col_defini.Width = 900
        '
        'col_ref
        '
        Me.col_ref.HeaderText = "Referência"
        Me.col_ref.MinimumWidth = 6
        Me.col_ref.Name = "col_ref"
        Me.col_ref.Width = 320
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkGoldenrod
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(241, 38)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "TAREFAS DO DIA"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lbl_qtdmes)
        Me.Panel4.Controls.Add(Me.lbl_evento_mes)
        Me.Panel4.Location = New System.Drawing.Point(32, 57)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(304, 178)
        Me.Panel4.TabIndex = 4
        '
        'lbl_qtdmes
        '
        Me.lbl_qtdmes.AutoSize = True
        Me.lbl_qtdmes.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qtdmes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_qtdmes.Location = New System.Drawing.Point(164, 99)
        Me.lbl_qtdmes.Name = "lbl_qtdmes"
        Me.lbl_qtdmes.Size = New System.Drawing.Size(110, 41)
        Me.lbl_qtdmes.TabIndex = 1
        Me.lbl_qtdmes.Text = "Label1"
        '
        'lbl_evento_mes
        '
        Me.lbl_evento_mes.AutoSize = True
        Me.lbl_evento_mes.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_evento_mes.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lbl_evento_mes.LinkColor = System.Drawing.Color.DarkGoldenrod
        Me.lbl_evento_mes.Location = New System.Drawing.Point(18, 10)
        Me.lbl_evento_mes.Name = "lbl_evento_mes"
        Me.lbl_evento_mes.Size = New System.Drawing.Size(256, 38)
        Me.lbl_evento_mes.TabIndex = 0
        Me.lbl_evento_mes.TabStop = True
        Me.lbl_evento_mes.Text = "EVENTOS DO MÊS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgv_agenda_semana)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Location = New System.Drawing.Point(388, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 178)
        Me.Panel1.TabIndex = 5
        '
        'dgv_agenda_semana
        '
        Me.dgv_agenda_semana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_agenda_semana.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_data, Me.col_horario, Me.col_evento, Me.col_status})
        Me.dgv_agenda_semana.Location = New System.Drawing.Point(21, 63)
        Me.dgv_agenda_semana.Name = "dgv_agenda_semana"
        Me.dgv_agenda_semana.RowHeadersVisible = False
        Me.dgv_agenda_semana.RowHeadersWidth = 51
        Me.dgv_agenda_semana.RowTemplate.Height = 24
        Me.dgv_agenda_semana.Size = New System.Drawing.Size(906, 98)
        Me.dgv_agenda_semana.TabIndex = 1
        '
        'col_data
        '
        Me.col_data.HeaderText = "Data"
        Me.col_data.MinimumWidth = 6
        Me.col_data.Name = "col_data"
        Me.col_data.Width = 125
        '
        'col_horario
        '
        Me.col_horario.HeaderText = "Hora"
        Me.col_horario.MinimumWidth = 6
        Me.col_horario.Name = "col_horario"
        Me.col_horario.Width = 125
        '
        'col_evento
        '
        Me.col_evento.HeaderText = "Evento"
        Me.col_evento.MinimumWidth = 6
        Me.col_evento.Name = "col_evento"
        Me.col_evento.Width = 450
        '
        'col_status
        '
        Me.col_status.HeaderText = "Status"
        Me.col_status.MinimumWidth = 6
        Me.col_status.Name = "col_status"
        Me.col_status.Width = 200
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DarkGoldenrod
        Me.LinkLabel2.Location = New System.Drawing.Point(14, 10)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(317, 38)
        Me.LinkLabel2.TabIndex = 0
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "EVENTOS DA SEMANA"
        '
        'uc_resumo_mes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "uc_resumo_mes"
        Me.Size = New System.Drawing.Size(1411, 652)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgv_tarefas_dia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_agenda_semana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_qtdmes As Label
    Friend WithEvents lbl_evento_mes As LinkLabel
    Friend WithEvents dgv_tarefas_dia As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents col_concluido As DataGridViewCheckBoxColumn
    Friend WithEvents col_defini As DataGridViewTextBoxColumn
    Friend WithEvents col_ref As DataGridViewTextBoxColumn
    Friend WithEvents dgv_agenda_semana As DataGridView
    Friend WithEvents col_data As DataGridViewTextBoxColumn
    Friend WithEvents col_horario As DataGridViewTextBoxColumn
    Friend WithEvents col_evento As DataGridViewTextBoxColumn
    Friend WithEvents col_status As DataGridViewTextBoxColumn
End Class
