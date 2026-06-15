Imports System.Data.SqlClient

Public Class uc_funcionarios
    Private Sub btn_novofunc_Click(sender As Object, e As EventArgs) Handles btn_novofunc.Click
        ' 1. Cria a variável referenciando o seu formulário exato
        Dim telaCadastro As New frm_cadastro_funcionario()

        ' 2. Avisa para a tela que é um cadastro NOVO (ID = 0)
        'telaCadastro.idClienteSelecionado = 0

        ' 3. Abre como Pop-up (bloqueando a tela de fundo)
        telaCadastro.ShowDialog()
    End Sub


    Private Sub uc_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_funcionarios()
    End Sub

    Public Sub carregar_funcionarios()
        Try
            dgv_funcionarios.Rows.Clear()

            ' SQL para buscar os dados dos funcionários
            Dim sqlSelect As String = "SELECT id_funcionario, usuario, email, senha, status_conta FROM tb_funcionarios"

            ' Abre conexão se estiver fechada
            If con.State = ConnectionState.Closed Then con.Open()

            Dim cmd As New SqlCommand(sqlSelect, con)
            Dim dr As SqlDataReader = cmd.ExecuteReader()

            While dr.Read()
                dgv_funcionarios.Rows.Add(dr("id_funcionario"),
                                          dr("usuario"),
                                          dr("email"),
                                          dr("senha"),
                                          dr("status_conta"))
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar grade de funcionários: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgv_funcionarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_funcionarios.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        ' Captura o ID da linha (assumindo que sua primeira coluna é o ID)
        Dim idClick As Integer = Convert.ToInt32(dgv_funcionarios.Rows(e.RowIndex).Cells(0).Value)

        ' --- AÇÃO: EDITAR ---
        ' Verifique se o nome da sua coluna de Editar é "col_editar" (ajuste se for diferente)
        If dgv_funcionarios.Columns(e.ColumnIndex).Name = "col_editar" Then
            id_selecionado = idClick
            Dim frm As New frm_cadastro_funcionario()
            frm.ShowDialog() ' Abre o formulário
            carregar_funcionarios() ' Recarrega ao voltar
        End If

        ' --- AÇÃO: EXCLUIR ---
        If dgv_funcionarios.Columns(e.ColumnIndex).Name = "col_excluir" Then
            Dim resp = MessageBox.Show("Deseja excluir o funcionário" & idClick & "?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = DialogResult.Yes Then
                Try
                    If con.State = ConnectionState.Closed Then con.Open()
                    Dim cmd As New SqlCommand("DELETE FROM tb_funcionarios WHERE id_funcionario = @id", con)
                    cmd.Parameters.AddWithValue("@id", idClick)
                    cmd.ExecuteNonQuery()
                    carregar_funcionarios()
                Catch ex As Exception
                    MessageBox.Show("Erro: " & ex.Message)
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btn_buscarfunc_TextChanged(sender As Object, e As EventArgs) Handles btn_buscarfunc.TextChanged

    End Sub
End Class
