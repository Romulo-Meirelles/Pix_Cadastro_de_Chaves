Module Bancos
    Public Property Bancos As String() = {"Bradesco", "Santander", "Itau", "HSBC", "Caixa Econônica", "Banco do Brasil", "Original", "NuBank", "Inter", "C6", "Neon", "BS2", "PagBank", "Next", "PicPay", "Mercado Pago", "Recarga Pay", "Sem Banco"}

    Public Sub LoadBancos(ByVal List As ComboBox, ByRef Picture As PictureBox)
        Try

            Dim S As Integer = List.SelectedIndex
            Picture.Image = Adicionar.Bancos_Images.Images(S)
        Catch ex As Exception
            Picture.Image = Nothing
            MessageBox.Show("Adicione uma imagem a (ImgemList)", "Sem Imagem", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
       
    End Sub

End Module
