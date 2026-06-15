<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_op_usuario = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeEventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_eventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnl_conteudo = New System.Windows.Forms.Panel()
        Me.menu_usuario_dropdown = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_meu_perfil = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_painel_gerencial = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_sair = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu_usuario_dropdown.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1444, 100)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_op_usuario)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(100, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1344, 100)
        Me.Panel2.TabIndex = 1
        '
        'btn_op_usuario
        '
        Me.btn_op_usuario.Location = New System.Drawing.Point(1059, 31)
        Me.btn_op_usuario.Name = "btn_op_usuario"
        Me.btn_op_usuario.Size = New System.Drawing.Size(227, 42)
        Me.btn_op_usuario.TabIndex = 1
        Me.btn_op_usuario.Text = "Olá, Nome do Usuário 🔽"
        Me.btn_op_usuario.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EventosToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1344, 100)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Goldenrod
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(128, 96)
        Me.ToolStripMenuItem1.Text = "Inicio"
        '
        'EventosToolStripMenuItem
        '
        Me.EventosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoDeEventosToolStripMenuItem, Me.btn_eventos})
        Me.EventosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventosToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod
        Me.EventosToolStripMenuItem.Name = "EventosToolStripMenuItem"
        Me.EventosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.EventosToolStripMenuItem.Size = New System.Drawing.Size(186, 96)
        Me.EventosToolStripMenuItem.Text = "   Eventos   "
        '
        'CatalogoDeEventosToolStripMenuItem
        '
        Me.CatalogoDeEventosToolStripMenuItem.Name = "CatalogoDeEventosToolStripMenuItem"
        Me.CatalogoDeEventosToolStripMenuItem.Size = New System.Drawing.Size(291, 32)
        Me.CatalogoDeEventosToolStripMenuItem.Text = "Catalogo de eventos"
        '
        'btn_eventos
        '
        Me.btn_eventos.Name = "btn_eventos"
        Me.btn_eventos.Size = New System.Drawing.Size(291, 32)
        Me.btn_eventos.Text = "Eventos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(181, 96)
        Me.ClientesToolStripMenuItem.Text = "   Clientes  "
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.Rose_Gold_Elegant_Monogram_Floral_Circular_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnl_conteudo
        '
        Me.pnl_conteudo.AutoScroll = True
        Me.pnl_conteudo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnl_conteudo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_conteudo.Location = New System.Drawing.Point(0, 100)
        Me.pnl_conteudo.Name = "pnl_conteudo"
        Me.pnl_conteudo.Size = New System.Drawing.Size(1444, 631)
        Me.pnl_conteudo.TabIndex = 3
        '
        'menu_usuario_dropdown
        '
        Me.menu_usuario_dropdown.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menu_usuario_dropdown.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_meu_perfil, Me.btn_painel_gerencial, Me.btn_sair})
        Me.menu_usuario_dropdown.Name = "menu_usuario_dropdown"
        Me.menu_usuario_dropdown.Size = New System.Drawing.Size(211, 104)
        '
        'btn_meu_perfil
        '
        Me.btn_meu_perfil.Name = "btn_meu_perfil"
        Me.btn_meu_perfil.Size = New System.Drawing.Size(210, 24)
        Me.btn_meu_perfil.Text = "👤 Meu Perfil"
        '
        'btn_painel_gerencial
        '
        Me.btn_painel_gerencial.Name = "btn_painel_gerencial"
        Me.btn_painel_gerencial.Size = New System.Drawing.Size(210, 24)
        Me.btn_painel_gerencial.Text = "⚙️ Painel Gerencial"
        '
        'btn_sair
        '
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(210, 24)
        Me.btn_sair.Text = "🚪 Sair do Sistema"
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 731)
        Me.Controls.Add(Me.pnl_conteudo)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_menu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Golden Moment Eventos - Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu_usuario_dropdown.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_conteudo As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoDeEventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_eventos As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btn_op_usuario As Button
    Friend WithEvents menu_usuario_dropdown As ContextMenuStrip
    Friend WithEvents btn_meu_perfil As ToolStripMenuItem
    Friend WithEvents btn_painel_gerencial As ToolStripMenuItem
    Friend WithEvents btn_sair As ToolStripMenuItem
End Class
