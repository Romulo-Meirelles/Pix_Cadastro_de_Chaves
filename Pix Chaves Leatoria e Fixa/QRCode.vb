Public Class QRCode

    Public Property QR_Code_Base64 As String
    Public Property Code As String
    Public Property Key_Type As String
    Public Property Key As String
    Public Property Amount As String
    Public Property Name_ As String
    Public Property City As String
    Public Property Reference As String
    Public Property Formated_amount As String

    Dim LOCAT As Point

    Private Sub QRCode_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaBordas(Copiar_Code_btn)
        QR_Code_Pic.Image = Base64ToImage(QR_Code_Base64)

        Chave_lbl.Text = "Chave PIX: " & Key & vbCrLf &
                         "Valor: " & Amount & vbCrLf &
                         "Nome: " & Name_ & vbCrLf &
                         "Cidade: " & City & vbCrLf &
                         "Código QRCode: " & Code

    End Sub

    Private Sub Copiar_Code_btn_Click(sender As System.Object, e As System.EventArgs) Handles Copiar_Code_btn.Click
        Try
            Mensagem_Timer.Stop()
            Clipboard.SetText(Code)
            Mensagem_lbl.Visible = True
            Mensagem_Timer.Start()
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub Mensagem_Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Mensagem_Timer.Tick
        Mensagem_lbl.Visible = False
        Mensagem_Timer.Stop()
    End Sub

    Private Sub Close_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Close_Pic.Click
        Me.Close()
    End Sub

    Private Sub QRCode_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub

    Private Sub QRCode_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub

    Private Sub QR_Code_Pic_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles QR_Code_Pic.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub

    Private Sub QR_Code_Pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles QR_Code_Pic.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub

    Private Sub Chave_lbl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Chave_lbl.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub

    Private Sub Chave_lbl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Chave_lbl.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub
End Class