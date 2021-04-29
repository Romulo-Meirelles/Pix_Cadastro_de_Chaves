Public Class Adicionar

    Private Sub Adicionar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaBordas(Adicionar_btn, 5)
        CarregaBordas(Me)
        Banco_Cbx.Items.AddRange(Bancos.Bancos)
    End Sub

    Private Sub Close_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Close_Pic.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Adicionar_btn_Click(sender As System.Object, e As System.EventArgs) Handles Adicionar_btn.Click
        Try
            If Banco_Cbx.SelectedItem = "" Or Chave_Pix_txt.Text = "" Then
                MessageBox.Show("Preencha todos os campos.", "Mensagem.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Insert(Banco_Cbx.SelectedItem.ToString, Chave_Pix_txt.Text)
            Pix.ListView1.Items.Clear()
            LoadPix(Pix.ListView1)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Não Concluída", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub

    Private Sub Banco_Cbx_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Banco_Cbx.SelectedIndexChanged
        LoadBancos(Banco_Cbx, Banco_Pic)
    End Sub
End Class