Public Class uc_resumo_mes
    Private Sub uc_resumo_mes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim eventosJunho As Integer = ObterTotalEventosDoMes(6, 2026)

        ' Exibe no Label
        lbl_qtdmes.Text = eventosJunho.ToString()
    End Sub
End Class
