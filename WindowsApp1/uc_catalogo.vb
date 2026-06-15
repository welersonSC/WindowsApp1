Imports System.Data.SqlClient

Public Class uc_catalogo
    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        ' 1. Cria a variável referenciando o seu formulário exato
        Dim telaCadastro As New frm_cadastro_catalogo()
        telaCadastro.ShowDialog()
    End Sub

    Public Sub carregar_catalogo()

        Try
            dgv_catalogo.Rows.Clear()

            ' 1. Teste a conexão primeiro
            If con.State = ConnectionState.Closed Then
                con.Open()
                ' Se passou daqui, a conexão está ok
            End If

            ' 2. Vamos fazer uma query SIMPLES primeiro, sem JOIN
            Dim sql As String = "SELECT id_item, nome_item, tipo_item, categoria, valor_base FROM tb_catalogo"

            Dim cmd As New SqlCommand(sql, con)
            Dim dr As SqlDataReader = cmd.ExecuteReader()

            ' 3. Checagem de dados
            If dr.HasRows Then
                While dr.Read()
                    dgv_catalogo.Rows.Add(dr("id_item"),
                                      dr("nome_item"),
                                      dr("tipo_item"),
                                      dr("categoria"),
                                      dr("valor_base"))
                End While
                MessageBox.Show("Dados carregados com sucesso!")
            Else
                ' Se cair aqui, a tabela está VAZIA no banco
                MessageBox.Show("A consulta foi bem sucedida, mas a tabela está vazia (0 registros).")
            End If

            dr.Close()
        Catch ex As Exception
            ' Isso vai nos mostrar o erro real se o SQL estiver com problema
            MessageBox.Show("Erro crítico: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub uc_catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_catalogo()
    End Sub

    Private Sub dgv_catalogo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_catalogo.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        ' Captura o ID da linha (assumindo que sua primeira coluna é o ID)
        Dim idClick As Integer = Convert.ToInt32(dgv_catalogo.Rows(e.RowIndex).Cells(0).Value)

        ' --- AÇÃO: EDITAR ---
        ' Verifique se o nome da sua coluna de Editar é "col_editar" (ajuste se for diferente)
        If dgv_catalogo.Columns(e.ColumnIndex).Name = "col_editar" Then
            id_selecionado = idClick
            Dim frm As New frm_cadastro_funcionario()
            frm.ShowDialog() ' Abre o formulário
            carregar_catalogo() ' Recarrega ao voltar
        End If

        ' --- AÇÃO: EXCLUIR ---
        If dgv_catalogo.Columns(e.ColumnIndex).Name = "col_excluir" Then
            Dim resp = MessageBox.Show("Deseja excluir o cliente" & idClick & "?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = DialogResult.Yes Then
                Try
                    If con.State = ConnectionState.Closed Then con.Open()
                    Dim cmd As New SqlCommand("DELETE FROM tb_catologo WHERE id_cliente = @id", con)
                    cmd.Parameters.AddWithValue("@id", idClick)
                    cmd.ExecuteNonQuery()
                    carregar_catalogo()
                Catch ex As Exception
                    MessageBox.Show("Erro: " & ex.Message)
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub
End Class
