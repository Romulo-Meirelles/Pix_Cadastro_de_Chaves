Imports Pix_Chaves_Leatoria_e_Fixa.Tools
Public Class QRCode
    Public Property Banco As String
    Public Property QR_Code As String
    Public Property Codigo As String
    Public Property Tipo_Chave As String
    Public Property Chave As String
    Public Property Valor As String
    Public Property Nome As String
    Public Property Servico As String
    Public Property Cidade As String

    Private Sub QRCode_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Tools.CarregaBordas(Me)
        Tools.CarregaBordas(Close_btn, 5)
        CarregaBordas(Copiar_Code_btn, 5)
        QR_Code_Pic.Image = GerarQRPicture(QR_Code)

        Chave_lbl.Text = "Chave PIX: " & Chave & vbCrLf

        If Valor <> "" Then
            Chave_lbl.Text += "Valor: " & Valor & vbCrLf
        End If

        If Nome <> "" Then
            Chave_lbl.Text += "Nome: " & Nome & vbCrLf
        End If

        If Servico <> "" Then
            Chave_lbl.Text += "Serviço: " & Servico & vbCrLf
        End If

        If Cidade <> "" Then
            Chave_lbl.Text += "Cidade: " & Cidade & vbCrLf
        End If

        Chave_lbl.Text += "Código QRCode: " & QR_Code

    End Sub



    Private Sub Copiar_Code_btn_Click(sender As System.Object, e As System.EventArgs) Handles Copiar_Code_btn.Click
        Try
            Mensagem_Timer.Stop()
            Clipboard.SetText(QR_Code)
            Mensagem_lbl.Visible = True
            Mensagem_Timer.Start()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Mensagem_Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Mensagem_Timer.Tick
        Mensagem_lbl.Visible = False
        Mensagem_Timer.Stop()
    End Sub

    Private Sub QRCode_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub QRCode_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
         Tools.MouseMove(sender, e, Me)
    End Sub

    Private Sub QR_Code_Pic_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles QR_Code_Pic.MouseDown
         Tools.MouseDown(sender, e)
    End Sub

    Private Sub QR_Code_Pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles QR_Code_Pic.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub

    Private Sub Chave_lbl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Chave_lbl.MouseDown
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Chave_lbl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Chave_lbl.MouseMove
         Tools.MouseMove(sender, e, Me)
    End Sub
    Private Sub Superior_Panel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Superior_Panel.MouseDown
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Superior_Panel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Superior_Panel.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub

    Private Sub Title_Label_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Title_Label.MouseDown
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Title_Label_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Title_Label.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub

    Private Sub Close_btn_Click(sender As System.Object, e As System.EventArgs) Handles Close_btn.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class