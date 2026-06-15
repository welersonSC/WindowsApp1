Public Class frm_menu
    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirUserControl(New uc_resumo_mes())

        btn_op_usuario.Text = "Olá, " & nome_logado
        If perfil_logado <> "Administrador" Then
            btn_painel_gerencial.Visible = False
        Else
            btn_painel_gerencial.Visible = True
        End If




    End Sub

    ' ========================================================
    ' FUNÇÃO PARA ABRIR USER CONTROLS DENTRO DO PAINEL
    ' ========================================================
    Private Sub AbrirUserControl(ByVal uc As UserControl)

        ' 1. Limpa o painel
        pnl_conteudo.Controls.Clear()

        ' 2. Manda o User Control preencher todo o espaço
        uc.Dock = DockStyle.Fill

        ' 3. Adiciona e mostra na tela
        pnl_conteudo.Controls.Add(uc)

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        AbrirUserControl(New uc_clientes())
    End Sub

    Private Sub CatalogoDeEventosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoDeEventosToolStripMenuItem.Click
        AbrirUserControl(New uc_catalogo())
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        AbrirUserControl(New uc_resumo_mes())

    End Sub

    Private Sub btn_op_usuario_Click(sender As Object, e As EventArgs) Handles btn_op_usuario.Click
        menu_usuario_dropdown.Show(btn_op_usuario, 0, btn_op_usuario.Height)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btn_eventos_Click(sender As Object, e As EventArgs) Handles btn_eventos.Click
        AbrirUserControl(New uc_gestao_eventos())
    End Sub


    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        If MessageBox.Show("Deseja realmente sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            id_logado = 0
            nome_logado = ""
            perfil_logado = ""
            frm_login.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btn_painel_gerencial_Click(sender As Object, e As EventArgs) Handles btn_painel_gerencial.Click
        AbrirUserControl(New uc_funcionarios())
    End Sub

    Private Sub btn_meu_perfil_Click(sender As Object, e As EventArgs) Handles btn_meu_perfil.Click
        id_selecionado = id_logado
        Dim frm As New frm_cadastro_funcionario()
        frm.ShowDialog()
    End Sub
End Class