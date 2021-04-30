Public Class Adicionar

    Private CX_TEMP As ListView = New ListView

    Private Sub Adicionar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaBordas(Adicionar_btn, 5)
        CarregaBordas(Me)


        For i = 0 To Bancos.Bancos.Count - 1
            CX_TEMP.Items.Add(Bancos.Bancos(i))
        Next


        Search()
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
            If Banco_Cbx.SelectedItem = "" Or Nome_txb.Text = "" Or Chave_Pix_txt.Text = "" Then
                MessageBox.Show("Preencha todos os campos.", "Mensagem.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Insert(Banco_Cbx.SelectedItem.ToString, Nome_txb.Text, Chave_Pix_txt.Text)
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

    
    Private Sub Search()
        On Error Resume Next
        Banco_Cbx.Items.Clear()
        For i = 0 To CX_TEMP.Items.Count - 1

            If CX_TEMP.Items(i).Text.ToLower.Contains(Procurar_txb.Text.ToLower) Then
                Banco_Cbx.Items.Add(CX_TEMP.Items(i).Text)
            End If
        Next
        Banco_Cbx.SelectedIndex = 0
    End Sub

    Private Sub Procurar_txb_TextChanged(sender As System.Object, e As System.EventArgs) Handles Procurar_txb.TextChanged
        Call Search()
    End Sub
End Class