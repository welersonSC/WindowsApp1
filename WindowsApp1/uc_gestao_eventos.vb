Public Class uc_gestao_eventos
    Private Sub uc_gestao_eventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim primeiroDiaDoMes As New DateTime(Date.Now.Year, Date.Now.Month, 1)
        dtp_data_inicio.Value = primeiroDiaDoMes

        ' 2. Define a Data Final para o último dia do mês atual
        Dim ultimoDiaDoMes As New DateTime(Date.Now.Year, Date.Now.Month, Date.DaysInMonth(Date.Now.Year, Date.Now.Month))
        dtp_data_fim.Value = ultimoDiaDoMes
    End Sub

    Private Sub btn_novofunc_Click(sender As Object, e As EventArgs) Handles btn_novofunc.Click
        Dim telaCadastro As New frm_novo_evento()
        telaCadastro.ShowDialog()
    End Sub

    Private Sub dgv_eventos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_eventos.CellContentClick

    End Sub
End Class
