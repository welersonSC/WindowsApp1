Imports System.ComponentModel
Imports System.Data.SqlClient

Module mod_geral

    Public con As New SqlConnection("Server=.\SQLEXPRESS; Database=db_golden_moment; Integrated Security=True; TrustServerCertificate=True;")
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public sql As String
    Public db As Object
    Public rs As Object
    Public diretorio As String
    Public id_logado As Integer
    Public nome_logado As String
    Public perfil_logado As String
    Public id_selecionado As Integer = 0

    ' Subroutine para realizar o login com tratamento de erro
    Public Sub Logar(usuario As String, senha As String)
        Try
            ' Verifica se a conexão está fechada antes de abrir
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            ' IMPORTANTE: Removemos o 'AND status_conta = 'Ativo'' para podermos verificar o status manualmente
            sql = "SELECT id_funcionario, nome_completo, perfil_acesso, status_conta FROM tb_funcionarios WHERE usuario = @usuario AND senha = @senha"

            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@senha", senha)

            ' Executa a leitura
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                ' Captura o status antes de definir o login
                Dim status As String = dr("status_conta").ToString()

                If status = "Ativo" Then
                    ' Caso de SUCESSO
                    id_logado = dr("id_funcionario")
                    nome_logado = dr("nome_completo")
                    perfil_logado = dr("perfil_acesso")
                ElseIf status = "Bloqueado" Then
                    ' Caso de CONTA BLOQUEADA
                    id_logado = -1 ' Usaremos o -1 para identificar o bloqueio no botão
                    nome_logado = ""
                    perfil_logado = ""
                Else
                    ' Caso de outro status (Ex: Excluído ou Inativo)
                    id_logado = 0
                    nome_logado = ""
                    perfil_logado = ""
                End If
            Else
                ' Se não encontrar usuário e senha, limpa as variáveis
                id_logado = 0
                nome_logado = ""
                perfil_logado = ""
            End If

            dr.Close() ' Sempre feche o reader após o uso

        Catch ex As Exception
            MessageBox.Show("Erro de conexão com o banco de dados: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Sub LimparCampos(ByVal container As Control)
        Try
            For Each ctrl As Control In container.Controls

                ' 1. Se for uma Caixa de Texto Normal
                If TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).Clear()

                    ' 2. Se for uma Caixa com Máscara (CPF, CEP, Telefone)
                ElseIf TypeOf ctrl Is MaskedTextBox Then
                    DirectCast(ctrl, MaskedTextBox).Clear()

                    ' 3. Se for uma Caixa de Seleção (ComboBox)
                ElseIf TypeOf ctrl Is ComboBox Then
                    DirectCast(ctrl, ComboBox).SelectedIndex = -1 ' Volta pro espaço em branco

                    ' 4. Se for uma Caixinha de Marcar (CheckBox)
                ElseIf TypeOf ctrl Is CheckBox Then
                    DirectCast(ctrl, CheckBox).Checked = False

                ElseIf TypeOf ctrl Is RadioButton Then
                    DirectCast(ctrl, RadioButton).Checked = False

                End If

                ' A MÁGICA DA RECURSIVIDADE:
                ' Se o controle for um Panel ou GroupBox, ele tem outros controles dentro dele.
                ' Então a função "chama ela mesma" para limpar o que tem lá dentro também!
                If ctrl.HasChildren Then
                    LimparCampos(ctrl)
                End If

            Next


        Catch ex As Exception
            MsgBox("Erro ao Processar...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try
    End Sub



    Public Function ObterTotalEventosDoMes(mes As Integer, ano As Integer) As Integer
        Dim total As Integer = 0
        Try
            ' SQL que conta as linhas filtrando por mês e ano
            Dim sql As String = "SELECT COUNT(*) FROM tb_eventos WHERE MONTH(data_evento) = @mes AND YEAR(data_evento) = @ano"

            If con.State = ConnectionState.Closed Then con.Open()

            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@mes", mes)
            cmd.Parameters.AddWithValue("@ano", ano)

            ' ExecuteScalar é perfeito para retornar um único valor (o contador)
            total = Convert.ToInt32(cmd.ExecuteScalar())

        Catch ex As Exception
            MessageBox.Show("Erro ao contar eventos: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return total
    End Function

End Module
