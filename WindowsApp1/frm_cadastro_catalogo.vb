Imports System.Data.SqlClient
Imports System.IO

Public Class frm_cadastro_catalogo


    Public conexao As New SqlConnection(
        "Server=SERVIDOR;" &
        "Database=SEU_BANCO;" &
        "Trusted_Connection=True;"
    )


    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        LimparCampos(Me)
    End Sub

    Private Sub cmb_tipo_item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo.SelectedIndexChanged, cbo_tipo.SelectedIndexChanged
        If cbo_tipo.Text = "Pacote Base" Then
            ' Se for pacote, desabilita a categoria (fica cinza) e limpa a seleção
            cbo_categoria.Enabled = False
            cbo_categoria.SelectedIndex = -1
        Else
            ' Se for um item avulso, libera a caixa para o usuário escolher a categoria
            cbo_categoria.Enabled = True
        End If
    End Sub



    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click

        ' Abre conexão
        If con.State = ConnectionState.Closed Then con.Open()

        ' Inicia uma Transação (segurança total)
        Dim trans As SqlTransaction = con.BeginTransaction()

        Try


            ' 2. Inserir na tb_catalogo e pegar o ID gerado (SCOPE_IDENTITY)
            Dim sqlItem As String = "INSERT INTO tb_catalogo (nome_item, tipo_item, categoria, valor_base, descricao_detalhada, status_item) " &
                                    "VALUES (@nome, @tipo, @cat, @valor, @desc, @status); SELECT SCOPE_IDENTITY();"

            Dim cmdItem As New SqlCommand(sqlItem, con, trans)
            cmdItem.Parameters.AddWithValue("@nome", txt_nome.Text)
            cmdItem.Parameters.AddWithValue("@tipo", cbo_tipo.Text)
            cmdItem.Parameters.AddWithValue("@cat", cbo_categoria.Text)
            cmdItem.Parameters.AddWithValue("@valor", CDec(txt_valor.Text))
            cmdItem.Parameters.AddWithValue("@desc", txt_descricao.Text)
            cmdItem.Parameters.AddWithValue("@status", If(chk_item_ativo.Checked, 1, 0))

            ' Executa e pega o ID do novo item
            Dim novoId As Integer = Convert.ToInt32(cmdItem.ExecuteScalar())

            ' 3. Inserir a imagem na tb_imagens_catalogo vinculada ao novoId

            ' Finaliza a transação (Salva tudo)
            trans.Commit()
            MessageBox.Show("Item e imagem cadastrados com sucesso!")

        Catch ex As Exception
            ' 1. Verifica se a transação foi iniciada antes de tentar cancelar
            If trans IsNot Nothing Then
                Try
                    trans.Rollback()
                Catch exRollback As Exception
                    ' Se o rollback falhar, apenas ignoramos (ou logamos)
                    ' Isso evita o erro de "transação já concluída"
                End Try
            End If

            MessageBox.Show("Erro ao salvar: " & ex.Message)

        Finally
            ' 2. Fecha a conexão sempre
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub



    Private Sub frm_cadastro_catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_tipo.Items.Add("Produto")
        cbo_tipo.Items.Add("Serviço")
        cbo_categoria.Items.Add("Debutante")
        cbo_categoria.Items.Add("Casamento")
        cbo_categoria.Items.Add("Social")
    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Me.Close()

    End Sub
End Class