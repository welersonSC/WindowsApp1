Imports System.Data.SqlClient
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class frm_cadastro_funcionario

    Private Sub txt_cep_Leave(sender As Object, e As EventArgs) Handles txt_cep.Leave, txt_cep.Leave
        Try

            If txt_cep.Text.Length < 9 Then
                Exit Sub
            End If

            Dim cep As String

            cep = txt_cep.Text.Replace("-", "").Trim()

            Dim url As String

            url = "https://viacep.com.br/ws/" & cep & "/json/"

            Dim client As New WebClient()

            Dim resposta As String

            resposta = client.DownloadString(url)

            Dim json As JObject = JObject.Parse(resposta)

            txt_endereco.Text = json("logradouro").ToString()
            txt_bairro.Text = json("bairro").ToString()
            txt_cidade.Text = json("localidade").ToString()

        Catch ex As Exception

            MessageBox.Show("CEP não encontrado!")

        End Try
    End Sub

    Private Sub frm_cadastro_funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_cargo.Items.Add("Recepcionista")
        cmb_cargo.Items.Add("Vendedor")
        cmb_cargo.Items.Add("Gerente")
        cmb_cargo.Items.Add("Financeiro")
        cmb_cargo.Items.Add("Administrador")

        cmb_cargo.SelectedIndex = 0

        If id_selecionado > 0 Then
            CarregarDadosEdicao()
        End If


    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If txt_nome.Text = "" Then

            MessageBox.Show("Digite o nome!")

            txt_nome.Focus()

            Exit Sub

        End If

        If txt_usuario.Text = "" Then

            MessageBox.Show("Digite o usuário!")

            txt_usuario.Focus()

            Exit Sub

        End If

        If txt_senha.Text = "" Then

            MessageBox.Show("Digite a senha!")

            txt_senha.Focus()

            Exit Sub

        End If


        ' Verifica se o CPF existe
        Try
            If con.State = ConnectionState.Closed Then con.Open()

            Dim sqlComando As String = ""

            ' Se id_selecionado > 0, fazemos UPDATE. Se for 0, é um novo registro (INSERT).
            If id_selecionado > 0 Then
                sqlComando = "UPDATE tb_funcionarios SET nome_completo=@nome, data_nascimento=@nasc, whatsapp=@whats, email=@email, " &
                             "cep=@cep, endereco=@end, numero=@num, bairro=@bairro, cidade=@cidade, complemento=@compl, " &
                             "cargo=@cargo, perfil_acesso=@perfil, usuario=@user, senha=@senha, status_conta=@status " &
                             "WHERE id_funcionario=@id"
            Else
                sqlComando = "INSERT INTO tb_funcionarios (nome_completo, cpf, data_nascimento, whatsapp, email, cep, endereco, " &
                             "numero, bairro, cidade, complemento, cargo, perfil_acesso, usuario, senha, status_conta) " &
                             "VALUES (@nome, @cpf, @nasc, @whats, @email, @cep, @end, @num, @bairro, @cidade, @compl, @cargo, @perfil, @user, @senha, @status)"
            End If

            Dim cmdGravar As New SqlCommand(sqlComando, con)

            ' Parâmetros comuns
            cmdGravar.Parameters.AddWithValue("@nome", txt_nome.Text)
            cmdGravar.Parameters.AddWithValue("@cpf", txt_cpf.Text)
            cmdGravar.Parameters.AddWithValue("@nasc", dt_nascimento.Value)
            cmdGravar.Parameters.AddWithValue("@whats", txt_whatsapp.Text)
            cmdGravar.Parameters.AddWithValue("@email", txt_email.Text)
            cmdGravar.Parameters.AddWithValue("@cep", txt_cep.Text)
            cmdGravar.Parameters.AddWithValue("@end", txt_endereco.Text)
            cmdGravar.Parameters.AddWithValue("@num", txt_numero.Text)
            cmdGravar.Parameters.AddWithValue("@bairro", txt_bairro.Text)
            cmdGravar.Parameters.AddWithValue("@cidade", txt_cidade.Text)
            cmdGravar.Parameters.AddWithValue("@compl", txt_complemento.Text)
            cmdGravar.Parameters.AddWithValue("@cargo", cmb_cargo.Text)
            cmdGravar.Parameters.AddWithValue("@perfil", If(rb_admin.Checked, "Administrador", "Operador"))
            cmdGravar.Parameters.AddWithValue("@user", txt_usuario.Text)
            cmdGravar.Parameters.AddWithValue("@senha", txt_senha.Text)
            cmdGravar.Parameters.AddWithValue("@status", cmb_status_conta.Text)

            ' Apenas se for Update, precisamos do ID
            If id_selecionado > 0 Then
                cmdGravar.Parameters.AddWithValue("@id", id_selecionado)
            End If

            cmdGravar.ExecuteNonQuery()
            MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_nome.Clear()

        txt_cpf.Clear()

        txt_whatsapp.Clear()

        txt_email.Clear()

        txt_usuario.Clear()

        txt_senha.Clear()

        txt_cep.Clear()

        txt_endereco.Clear()

        txt_numero.Clear()

        txt_bairro.Clear()

        txt_cidade.Clear()

        rb_operador.Checked = False
        rb_admin.Checked = False

        cmb_cargo.SelectedIndex = 0

        txt_nome.Focus()

    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Me.Close()
    End Sub

    Private Sub CarregarDadosEdicao()

        Try
                If con.State = ConnectionState.Closed Then con.Open()

                Dim sql As String = "SELECT * FROM tb_funcionarios WHERE id_funcionario = @id"
                Dim cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@id", id_selecionado)

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                ' Preenchimento de todos os campos
                txt_nome.Text = dr("nome_completo").ToString()
                txt_cpf.Text = dr("cpf").ToString()
                txt_usuario.Text = dr("usuario").ToString()
                txt_senha.Text = dr("senha").ToString()
                txt_email.Text = dr("email").ToString()
                txt_whatsapp.Text = dr("whatsapp").ToString()

                txt_cep.Text = dr("cep").ToString()
                txt_endereco.Text = dr("endereco").ToString()
                txt_numero.Text = dr("numero").ToString()
                txt_bairro.Text = dr("bairro").ToString()
                txt_cidade.Text = dr("cidade").ToString()
                txt_complemento.Text = dr("complemento").ToString()

                cmb_cargo.Text = dr("cargo").ToString()
                cmb_status_conta.Text = dr("status_conta").ToString()

                If IsDate(dr("data_nascimento")) Then
                    dt_nascimento.Value = Convert.ToDateTime(dr("data_nascimento"))
                End If

                ' Lógica dos RadioButtons
                If dr("perfil_acesso").ToString() = "Administrador" Then
                    rb_admin.Checked = True
                Else
                    rb_operador.Checked = True
                End If

                ' Bloqueia o CPF na edição para manter a integridade
                txt_cpf.Enabled = False
            End If
            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' IMPORTANTE: Limpar a variável ao fechar para não abrir em modo de edição da próxima vez
    Private Sub frm_cadastro_funcionario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        id_selecionado = 0
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub
End Class