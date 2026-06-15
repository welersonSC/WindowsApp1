<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_catalogo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_categoria_catalogo = New System.Windows.Forms.ComboBox()
        Me.btn_novo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_catalogo = New System.Windows.Forms.DataGridView()
        Me.col_id_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nome_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_excluir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_catalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmb_categoria_catalogo)
        Me.Panel1.Controls.Add(Me.btn_novo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(76, 54)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1307, 100)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(699, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filtrar"
        '
        'cmb_categoria_catalogo
        '
        Me.cmb_categoria_catalogo.FormattingEnabled = True
        Me.cmb_categoria_catalogo.Location = New System.Drawing.Point(765, 30)
        Me.cmb_categoria_catalogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_categoria_catalogo.Name = "cmb_categoria_catalogo"
        Me.cmb_categoria_catalogo.Size = New System.Drawing.Size(203, 24)
        Me.cmb_categoria_catalogo.TabIndex = 3
        '
        'btn_novo
        '
        Me.btn_novo.AccessibleDescription = "btn_novo"
        Me.btn_novo.AccessibleName = "btn_novo"
        Me.btn_novo.BackColor = System.Drawing.Color.Gold
        Me.btn_novo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_novo.Location = New System.Drawing.Point(975, 15)
        Me.btn_novo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_novo.Name = "btn_novo"
        Me.btn_novo.Size = New System.Drawing.Size(180, 46)
        Me.btn_novo.TabIndex = 2
        Me.btn_novo.Text = "➕ Novo"
        Me.btn_novo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CATÁLOGO"
        '
        'dgv_catalogo
        '
        Me.dgv_catalogo.AllowUserToAddRows = False
        Me.dgv_catalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_catalogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_item, Me.col_nome_item, Me.col_tipo, Me.col_categoria, Me.col_valor, Me.col_editar, Me.col_excluir})
        Me.dgv_catalogo.Location = New System.Drawing.Point(76, 174)
        Me.dgv_catalogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_catalogo.Name = "dgv_catalogo"
        Me.dgv_catalogo.RowHeadersVisible = False
        Me.dgv_catalogo.RowHeadersWidth = 51
        Me.dgv_catalogo.RowTemplate.Height = 24
        Me.dgv_catalogo.Size = New System.Drawing.Size(1307, 381)
        Me.dgv_catalogo.TabIndex = 5
        '
        'col_id_item
        '
        Me.col_id_item.HeaderText = "Cód."
        Me.col_id_item.MinimumWidth = 6
        Me.col_id_item.Name = "col_id_item"
        Me.col_id_item.Width = 60
        '
        'col_nome_item
        '
        Me.col_nome_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_nome_item.HeaderText = "Nome do Item / Pacote"
        Me.col_nome_item.MinimumWidth = 6
        Me.col_nome_item.Name = "col_nome_item"
        '
        'col_tipo
        '
        Me.col_tipo.HeaderText = "Tipo"
        Me.col_tipo.MinimumWidth = 250
        Me.col_tipo.Name = "col_tipo"
        Me.col_tipo.Width = 250
        '
        'col_categoria
        '
        Me.col_categoria.HeaderText = "Categoria"
        Me.col_categoria.MinimumWidth = 6
        Me.col_categoria.Name = "col_categoria"
        Me.col_categoria.Width = 125
        '
        'col_valor
        '
        DataGridViewCellStyle1.Format = "C2"
        Me.col_valor.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_valor.HeaderText = "Valor (R$)"
        Me.col_valor.MinimumWidth = 6
        Me.col_valor.Name = "col_valor"
        Me.col_valor.Width = 115
        '
        'col_editar
        '
        Me.col_editar.HeaderText = ""
        Me.col_editar.MinimumWidth = 6
        Me.col_editar.Name = "col_editar"
        Me.col_editar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_editar.Text = "✏️"
        Me.col_editar.UseColumnTextForButtonValue = True
        Me.col_editar.Width = 60
        '
        'col_excluir
        '
        Me.col_excluir.HeaderText = ""
        Me.col_excluir.MinimumWidth = 6
        Me.col_excluir.Name = "col_excluir"
        Me.col_excluir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_excluir.Text = "❌"
        Me.col_excluir.UseColumnTextForButtonValue = True
        Me.col_excluir.Width = 60
        '
        'uc_catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_catalogo)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "uc_catalogo"
        Me.Size = New System.Drawing.Size(1437, 703)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_catalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_catalogo As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_categoria_catalogo As ComboBox
    Friend WithEvents btn_novo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents col_id_item As DataGridViewTextBoxColumn
    Friend WithEvents col_nome_item As DataGridViewTextBoxColumn
    Friend WithEvents col_tipo As DataGridViewTextBoxColumn
    Friend WithEvents col_categoria As DataGridViewTextBoxColumn
    Friend WithEvents col_valor As DataGridViewTextBoxColumn
    Friend WithEvents col_editar As DataGridViewButtonColumn
    Friend WithEvents col_excluir As DataGridViewButtonColumn
End Class
