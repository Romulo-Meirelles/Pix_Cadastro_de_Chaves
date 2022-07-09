'Imports Pix_Chaves_Leatoria_e_Fixa.Tools

Public Class Information

    Private Sub Information_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label5.Text = My.Application.Info.Version.ToString
        Tools.CarregaBordas(Me)
    End Sub

    Private Sub Information_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        Try
            Process.Start("https://github.com/Romulo-Meirelles")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        Try
            Process.Start("https://github.com/Romulo-Meirelles/Pix_Cadastro_de_Chaves")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer_Mensagem_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Mensagem.Tick
        Mensagem_lbl.Visible = False
        Timer_Mensagem.Stop()
    End Sub
    Private Sub Mensagem(ByVal MSG As String)
        Timer_Mensagem.Stop()
        Mensagem_lbl.Text = MSG
        Mensagem_lbl.Visible = True
        Timer_Mensagem.Start()
    End Sub
    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click
        Try
            Dim BTC As String = "1BZpHRGAePYE8J4sSq6v9QkBPAeVrTffgt"
            QR_Code_Pic.Image = GerarQRPicture(BTC, Tools.LOGOS.BTC) 'TryCast(qrcode, Image)
            QR_Moeda_Nome_lbl.Visible = True
            QR_Moeda_Nome_lbl.Text = "BitCoin"
            Clipboard.SetText(BTC)
            Mensagem("Carteira BTC Copiada!")
        Catch ex As Exception

        End Try
    End Sub
   

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click
        Try
            Dim LTC As String = "LLkEawSYhM76B1zqHLmZTWbQHjksrwjeWx"
            ' Dim qrencod As New Codec.QRCodeEncoder
            'Dim qrcode As Bitmap = qrencod.Encode(BTC)
            QR_Code_Pic.Image = GerarQRPicture(LTC, Tools.LOGOS.LTC) 'TryCast(qrcode, Image)
            QR_Moeda_Nome_lbl.Visible = True
            QR_Moeda_Nome_lbl.Text = "LiteCoin"

            Clipboard.SetText(LTC)
            Mensagem("Carteira LTC Copiada!")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click
        Try
            Dim ETH As String = "0x4454b8f08cc9d147afd93b72bf7066f10f3c2b90"
            'Dim qrencod As New Codec.QRCodeEncoder
            'Dim qrcode As Bitmap = qrencod.Encode(BTC)
            QR_Code_Pic.Image = GerarQRPicture(ETH, Tools.LOGOS.ETH) 'TryCast(qrcode, Image)
            QR_Moeda_Nome_lbl.Visible = True
            QR_Moeda_Nome_lbl.Text = "Ethereum"

            Clipboard.SetText(ETH)
            Mensagem("Carteira ETH Copiada!")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click
        Try
            Dim DOGE As String = "D8dJGkba3wL8wuNLDAm7gFSu1KYSVLHxLp"
            ' Dim qrencod As New Codec.QRCodeEncoder
            ' Dim qrcode As Bitmap = qrencod.Encode(DOGE)
            QR_Code_Pic.Image = GerarQRPicture(DOGE, Tools.LOGOS.DOGE) 'TryCast(qrcode, Image)
            QR_Moeda_Nome_lbl.Visible = True
            QR_Moeda_Nome_lbl.Text = "DogeCoin"

            Clipboard.SetText(DOGE)
            Mensagem("Carteira DOGE Copiada!")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click
        Try
            Dim PIX As String = "767938fe-66cd-4831-9b3c-bc9760e9c835"
            'Dim qrencod As New Codec.QRCodeEncoder
            'Dim qrcode As Bitmap = qrencod.Encode(BTC)
            QR_Code_Pic.Image = GerarQRPicture(PIX) 'TryCast(qrcode, Image)
            QR_Moeda_Nome_lbl.Visible = True
            QR_Moeda_Nome_lbl.Text = "Pix NuBank"

            Clipboard.SetText(PIX)
            Mensagem("Carteira PIX Copiada!")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Close_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Close_Pic.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub QR_Code_Pic_Click(sender As System.Object, e As System.EventArgs) Handles QR_Code_Pic.Click
        Me.Close()
    End Sub

    Private Sub QR_Moeda_Nome_lbl_Click(sender As System.Object, e As System.EventArgs) Handles QR_Moeda_Nome_lbl.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub Mensagem_lbl_Click(sender As System.Object, e As System.EventArgs) Handles Mensagem_lbl.Click
        Me.Close()
    End Sub
End Class