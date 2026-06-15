Imports System.Data.SqlClient
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class frm_cadastro_cliente

    Private Sub txt_cep_Leave(sender As Object, e As EventArgs) Handles txt_cep.Leave

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



    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            ' 1. Verifica se o cliente já existe pelo CPF
            Dim sqlCheck As String = "SELECT COUNT(*) FROM tb_clientes WHERE cpf = @cpf"
            cmd = New SqlCommand(sqlCheck, con)
            cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)

            If con.State = ConnectionState.Closed Then con.Open()
            Dim existe As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' 2. Se existe = 0, é um INSERT (novo). Se maior, é UPDATE (editar).
            Dim sqlComando As String = ""
            If existe = 0 Then
                sqlComando = "INSERT INTO tb_clientes (nome_completo, cpf, whatsapp, email, cidade) VALUES (@nome, @cpf, @whats, @email, @cidade)"
            Else
                sqlComando = "UPDATE tb_clientes SET nome_completo=@nome, whatsapp=@whats, email=@email, cidade=@cidade WHERE cpf=@cpf"
            End If

            ' 3. Executa o comando escolhido
            cmd = New SqlCommand(sqlComando, con)
            cmd.Parameters.AddWithValue("@nome", txt_nome.Text)
            cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
            cmd.Parameters.AddWithValue("@whats", txt_whatsapp.Text)
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            cmd.Parameters.AddWithValue("@cidade", txt_cidade.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimparCampos(Me)


        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_nome.Clear()
        txt_cpf.Clear()
        txt_whatsapp.Clear()
        txt_email.Clear()

        txt_cep.Clear()
        txt_endereco.Clear()
        txt_numero.Clear()
        txt_bairro.Clear()
        txt_cidade.Clear()
        txt_complemento.Clear()

        txt_obs.Clear()

        txt_nome.Focus()
    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Me.Close()
    End Sub
    Private Sub CarregarDadosEdicao()
        Try
            If con.State = ConnectionState.Closed Then con.Open()

            ' Ajustado para a tabela de clientes
            Dim sql As String = "SELECT * FROM tb_clientes WHERE id_cliente = @id"
            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@id", id_selecionado)

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                ' Preenchimento dos campos do cliente
                txt_nome.Text = dr("nome_completo").ToString()
                txt_cpf.Text = dr("cpf").ToString()
                txt_email.Text = dr("email").ToString()
                txt_whatsapp.Text = dr("whatsapp").ToString()

                ' Endereço
                txt_cep.Text = dr("cep").ToString()
                txt_endereco.Text = dr("endereco").ToString()
                txt_numero.Text = dr("numero").ToString()
                txt_bairro.Text = dr("bairro").ToString()
                txt_cidade.Text = dr("cidade").ToString()
                txt_complemento.Text = dr("complemento").ToString()

                ' Data de Nascimento
                If IsDate(dr("data_nascimento")) Then
                    dtp_data.Value = Convert.ToDateTime(dr("data_nascimento"))
                End If

                ' Bloqueia o CPF na edição para manter a integridade
                txt_cpf.Enabled = False
            End If
            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados do cliente: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' IMPORTANTE: Limpar a variável ao fechar para não abrir em modo de edição da próxima vez
    Private Sub frm_cadastro_cliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        id_selecionado = 0
    End Sub
End Class