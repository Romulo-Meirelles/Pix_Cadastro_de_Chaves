Module Bancos
    Public Property Bancos As String() = {"Bradesco", "Santander", "Itau", "HSBC", "Caixa Econômica", "Banco do Brasil", "Original", "NuBank", "Inter", "C6", "Neon", "BS2", "PagBank", "Next", "PicPay", "Mercado Pago", "Recarga Pay", "Alter", "PAN", "Banco da Amazônia", "Banco de Brasilia", "Banco do Nordeste", "Benestes", "Banrisul", "CitiBank", "Safra", "Sicoob", "Sicredi", "AgiBank", "Super Digital", "Sofisa", "Pag!", "BTG Pactual", "UnoBank", "Iti", "Modal Mais", "Digio", "Mercado Bitcoin"}

    Public Sub LoadBancos(ByVal List As ComboBox, ByRef Picture As PictureBox)
        Try
            Dim S As String = List.SelectedItem.ToString
            Dim U As Integer = Adicionar.Bancos_Images.Images.IndexOfKey(S)
            Picture.Image = Adicionar.Bancos_Images.Images(U)
        Catch ex As Exception
            Picture.Image = Nothing
            'MessageBox.Show("Adicione uma imagem a (ImgemList)", "Sem Imagem", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Module
