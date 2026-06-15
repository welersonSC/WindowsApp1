Public Class frm_login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Logar(txt_usuario.Text, txt_senha.Text)

        ' Verifica se o login funcionou (se o id_logado for maior que 0)
        Logar(txt_usuario.Text, txt_senha.Text)

        If id_logado > 0 Then
            ' SUCESSO
            MessageBox.Show("Bem-vindo, " & nome_logado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frm_menu.Show()
            Me.Hide()

        ElseIf id_logado = -1 Then
            ' AVISO DE BLOQUEIO
            MessageBox.Show("Atenção: Esta conta está BLOQUEADA. Entre em contato com o administrador do sistema.", "Conta Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            ' LOGIN INVÁLIDO (Senha ou usuário errado)
            MessageBox.Show("Usuário ou senha inválidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btn_limpar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_limpar.LinkClicked
        txt_usuario.Clear()
        txt_senha.Clear()

        txt_usuario.Focus()
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        ' 1. Pergunta de confirmação (Evita fechamento acidental)
        Dim resposta As DialogResult = MessageBox.Show("Deseja realmente encerrar o sistema?", "Sair do Golden Moment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            ' 2. Fecha a conexão com o banco se ela estiver aberta (Segurança)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' 3. Encerra a aplicação completamente
            Application.Exit()
        End If
    End Sub
End Class
