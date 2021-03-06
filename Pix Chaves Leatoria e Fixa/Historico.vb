'Imports Pix_Chaves_Leatoria_e_Fixa.Msg
Public Class Historico
    Private Sub Historico_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Hist As New HistoricoDataBase
        Hist.Load_Historico(ListView1)
    End Sub

    Private Sub Mensagem_lbl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Mensagem_lbl.MouseDown
        Tools.MouseDown(sender, e)
    End Sub
    Private Sub Mensagem_lbl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Mensagem_lbl.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub
    Private Sub Copiar_btn_Click(sender As System.Object, e As System.EventArgs) Handles Copiar_btn.Click
        Try
            Dim PIX As String = ListView1.Items(ListView1.FocusedItem.Index).SubItems(10).Text
            If PIX = Nothing Then
                MensagemBox("Selecione na tabela o item primeiro", MessageNumber.Error_, "Erro ao Copiar.")
            Else
                Clipboard.SetText(PIX)
                MensagemBox("Copiado com Sucesso!", MessageNumber.Ok_, "Copiado")
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub QRCode_btn_Click(sender As System.Object, e As System.EventArgs) Handles QRCode_btn.Click
        Try
            Dim QR As New QRCode
            Dim CONTEUDO(10) As String

            For I = 0 To CONTEUDO.Count - 1
                Dim H As String = ListView1.Items(ListView1.FocusedItem.Index).SubItems(I).Text
                If H = "Ausente" Or H = "" Then
                    CONTEUDO(I) = Nothing
                Else
                    CONTEUDO(I) = H
                End If
            Next

            With QR
                .Nome = CONTEUDO(2)
                .Chave = CONTEUDO(3)
                .Valor = CONTEUDO(4)
                .Tipo_Chave = CONTEUDO(5)
                .Servico = CONTEUDO(6)
                .Cidade = CONTEUDO(7)
                .Codigo = CONTEUDO(8)
                .QR_Code = CONTEUDO(10)
            End With

            QR.Show()

        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub Limpar_Historico_btn_Click(sender As System.Object, e As System.EventArgs) Handles Limpar_Historico_btn.Click
        Try
            If MessageBox.Show("Deseja realmente deletar todo o histórico?", "Deletar.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Dim Hist As New HistoricoDataBase
                Hist.Delete_Historico()
                ListView1.Items.Clear()
                MessageBox.Show("Seu histórico foi limpo com sucesso!", "Deletado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Hist.Load_Historico(ListView1)
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub

    Private Sub Timer_Copia_Cola_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Copia_Cola.Tick
        Try
            Mensagem_lbl.ForeColor = Color.Red
            Mensagem_lbl.Text = "Dê 2 cliques para ""Copia e Cola"" Chave Gerada."
            Timer_Copia_Cola.Stop()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        Try
            Clipboard.SetText(ListView1.Items(ListView1.FocusedItem.Index).SubItems(10).Text)
            MensagemBox("Chave Pix Gerada e Copiada com Sucesso!", MessageNumber.Ok_, "Gerador de Chave.")
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub Close_btn_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Close()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub ResizeFom()
        CarregaBordas(Me)
        CarregaBordas(Copiar_btn, 5)
        CarregaBordas(QRCode_btn, 5)
        CarregaBordas(Limpar_Historico_btn, 5)
    End Sub
    Private Sub Historico_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeFom()
    End Sub
End Class