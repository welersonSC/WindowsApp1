Imports System.Data.SqlClient
Public Class uc_clientes

    Private Sub btn_novo_cliente_Click(sender As Object, e As EventArgs) Handles btn_novo_cliente.Click
        ' 1. Cria a variável referenciando o seu formulário exato
        Dim telaCadastro As New frm_cadastro_cliente()
        telaCadastro.ShowDialog()
    End Sub
    Private Sub uc_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
    End Sub
    Public Sub carregar_dados()
        Try
            dgv_clientes.Rows.Clear()

            ' SQL para buscar os dados
            Dim sqlSelect As String = "SELECT id_cliente, nome_completo, whatsapp, email, cidade FROM tb_clientes"

            ' Abre conexão se estiver fechada
            If con.State = ConnectionState.Closed Then con.Open()

            Dim cmd As New SqlCommand(sqlSelect, con)
            Dim dr As SqlDataReader = cmd.ExecuteReader()

            While dr.Read()
                dgv_clientes.Rows.Add(dr("id_cliente"),
                                      dr("nome_completo"),
                                      dr("whatsapp"),
                                      dr("email"),
                                      dr("cidade"))
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar grade: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub




End Class
