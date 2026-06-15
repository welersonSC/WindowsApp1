<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_limpar = New System.Windows.Forms.LinkLabel()
        Me.btn_sair = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(505, 313)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(272, 30)
        Me.txt_usuario.TabIndex = 7
        Me.txt_usuario.Text = "usuario"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txt_senha.Location = New System.Drawing.Point(504, 364)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(272, 30)
        Me.txt_senha.TabIndex = 8
        Me.txt_senha.Text = "senha"
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.Black
        Me.btn_entrar.Location = New System.Drawing.Point(504, 414)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(272, 36)
        Me.btn_entrar.TabIndex = 9
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Design_sem_nome__6_
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(456, 652)
        Me.FlowLayoutPanel1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Rose_Gold_Elegant_Monogram_Floral_Circular_Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.Rose_Gold_Elegant_Monogram_Floral_Circular_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(505, 85)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 192)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btn_limpar
        '
        Me.btn_limpar.AutoSize = True
        Me.btn_limpar.LinkColor = System.Drawing.Color.Goldenrod
        Me.btn_limpar.Location = New System.Drawing.Point(612, 488)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(56, 16)
        Me.btn_limpar.TabIndex = 12
        Me.btn_limpar.TabStop = True
        Me.btn_limpar.Text = "LIMPAR"
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(770, 12)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(66, 39)
        Me.btn_sair.TabIndex = 13
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AcceptButton = Me.btn_entrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(848, 652)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.btn_entrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn_limpar As LinkLabel
    Friend WithEvents btn_sair As Button
End Class
