Imports System.Data.SqlClient

Public Class frm_novo_evento

    ' Variáveis globais para o sistema lembrar em qual mês/ano estamos navegando
    Private mesAtual As Integer
    Private anoAtual As Integer
    Private dataSelecionadaDoEvento As DateTime

    ' =========================================================
    ' FUNÇÃO PRINCIPAL: DESENHAR O CALENDÁRIO
    ' =========================================================
    Public Sub MontarCalendarioVisual(mes As Integer, ano As Integer)

        ' 1. Atualiza a Label de Título automaticamente (Ex: "JUNHO / 2026")
        Dim dataTitulo As New DateTime(ano, mes, 1)
        lbl_mes_ano.Text = dataTitulo.ToString("MMMM / yyyy").ToUpper()

        ' 2. Limpa o painel para não sobrepor botões antigos
        tlp_calendario.Controls.Clear()

        ' 3. Cria o Cabeçalho (Domingo a Sábado)
        Dim diasSemana As String() = {"Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb"}

        For col As Integer = 0 To 6
            Dim lblDia As New Label()
            lblDia.Text = diasSemana(col)
            lblDia.TextAlign = ContentAlignment.MiddleCenter
            lblDia.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            lblDia.ForeColor = Color.Goldenrod ' Dourado da Golden Moment
            lblDia.Dock = DockStyle.Fill

            tlp_calendario.Controls.Add(lblDia, col, 0)
        Next

        ' 4. Matemática dos Espaços
        Dim primeiroDiaDoMes As New DateTime(ano, mes, 1)
        Dim espacosVazios As Integer = CInt(primeiroDiaDoMes.DayOfWeek)
        Dim totalDiasNoMes As Integer = DateTime.DaysInMonth(ano, mes)

        Dim linhaAtual As Integer = 1
        Dim colunaAtual As Integer = espacosVazios

        ' 5. Fabricação dos Botões dos Dias
        For dia As Integer = 1 To totalDiasNoMes

            Dim btnDia As New Button()
            btnDia.Text = dia.ToString()
            btnDia.Dock = DockStyle.Fill
            btnDia.FlatStyle = FlatStyle.Flat
            btnDia.Cursor = Cursors.Hand
            btnDia.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            ' Visual padrão: Disponível
            btnDia.BackColor = Color.MediumSeaGreen
            btnDia.ForeColor = Color.White
            btnDia.FlatAppearance.BorderSize = 0

            ' Guarda a data "invisível" dentro do botão
            btnDia.Tag = New DateTime(ano, mes, dia)

            ' Ensina o botão o que fazer ao ser clicado
            AddHandler btnDia.Click, AddressOf BotaoDia_Click

            ' Coloca o botão no painel
            tlp_calendario.Controls.Add(btnDia, colunaAtual, linhaAtual)

            ' Anda para o lado
            colunaAtual += 1

            ' Quebra de linha ao chegar no sábado
            If colunaAtual > 6 Then
                colunaAtual = 0
                linhaAtual += 1
            End If
        Next
    End Sub

    ' =========================================================
    ' EVENTO: QUANDO O VENDEDOR CLICA NO DIA
    ' =========================================================
    Private Sub BotaoDia_Click(sender As Object, e As EventArgs)
        Dim botaoClicado As Button = DirectCast(sender, Button)

        ' Salva a data na variável global
        dataSelecionadaDoEvento = DirectCast(botaoClicado.Tag, DateTime)

        ' Mostra na tela para o usuário confirmar
        lbl_data_escolhida.Text = "Data Selecionada: " & dataSelecionadaDoEvento.ToShortDateString()
    End Sub

    ' =========================================================
    ' EVENTOS DE NAVEGAÇÃO (BOTÕES < E >)
    ' =========================================================
    Private Sub btn_mes_anterior_Click(sender As Object, e As EventArgs) Handles btn_mes_anterior.Click
        mesAtual -= 1
        If mesAtual < 1 Then
            mesAtual = 12
            anoAtual -= 1
        End If
        MontarCalendarioVisual(mesAtual, anoAtual)
    End Sub

    Private Sub btn_mes_seguinte_Click(sender As Object, e As EventArgs) Handles btn_mes_seguinte.Click
        mesAtual += 1
        If mesAtual > 12 Then
            mesAtual = 1
            anoAtual += 1
        End If
        MontarCalendarioVisual(mesAtual, anoAtual)
    End Sub
    Private Sub frm_novo_evento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Carrega o mês e ano do dia de hoje nas variáveis globais
        mesAtual = Date.Now.Month
        anoAtual = Date.Now.Year

        ' 2. Manda a função desenhar o calendário usando esse mês e ano
        MontarCalendarioVisual(mesAtual, anoAtual)

        dtp_hora_inicio.Value = DateTime.Today.AddHours(19)




    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click, lbl_tipo_evento.Click

    End Sub

    Private Sub btn_remover_item_Click(sender As Object, e As EventArgs) Handles btn_remover_item.Click
        ' 1. Verifica se existe alguma linha selecionada na tabela
        ' (Garante que não é nulo e não é a linha vazia de criação)
        If dgv_carrinho.CurrentRow IsNot Nothing AndAlso Not dgv_carrinho.CurrentRow.IsNewRow Then

            ' 2. Remove a linha que está focada no momento
            dgv_carrinho.Rows.Remove(dgv_carrinho.CurrentRow)

        Else
            ' 3. Se o vendedor apertar o botão sem selecionar nada, mostra um aviso
            MessageBox.Show("Por favor, clique em um item na tabela primeiro para poder removê-lo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_proximo_1_Click(sender As Object, e As EventArgs) Handles btn_proximo_1.Click
        If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
            TabControl1.SelectedIndex += 1
        End If

    End Sub

    Private Sub btn_proximo_2_Click(sender As Object, e As EventArgs) Handles btn_proximo_2.Click
        If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
            TabControl1.SelectedIndex += 1
        End If
    End Sub

    Private Sub btn_voltar_2_Click(sender As Object, e As EventArgs) Handles btn_voltar_2.Click
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.SelectedIndex -= 1
        End If

    End Sub

    Private Sub btn_buscar_cpf_Click(sender As Object, e As EventArgs) Handles btn_buscar_cpf.Click
        ' Verifica se o campo de busca está vazio
        If String.IsNullOrWhiteSpace(mtb_cpf_busca.Text) Then
            MessageBox.Show("Por favor, digite um CPF para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            If con.State = ConnectionState.Closed Then con.Open()

            ' Consulta o banco pelo CPF
            Dim sql As String = "SELECT * FROM tb_clientes WHERE cpf = @cpf"
            Dim cmd As New SqlCommand(sql, con)

            ' Usamos parâmetros para evitar SQL Injection
            cmd.Parameters.AddWithValue("@cpf", mtb_cpf_busca.Text)

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            ' Verifica se o cliente foi encontrado
            If dr.Read() Then
                ' Preenche os campos do formulário com os dados retornados
                txt_nome_cliente.Text = dr("nome_completo").ToString()
                ' ... adicione outros campos conforme necessário ...

                MessageBox.Show("Cliente encontrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Se não encontrar ninguém
                MessageBox.Show("CPF não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Opcional: Limpar campos caso não encontre
                ' LimparCampos() 
            End If

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao buscar cliente: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

End Class