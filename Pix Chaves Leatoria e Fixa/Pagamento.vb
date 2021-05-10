Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class Pagamento
    Dim LOCAT As Point

    Public Property ChavePix As String
    Public Property Nome As String

    Private Sub Pagamento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        CarregaBordas(Gerar_QRCode_btn)


        If ChavePix.Contains("(") Then
            Tipo_Chave_CBX.SelectedIndex = 0

        ElseIf ChavePix.Contains("@") Then
            Tipo_Chave_CBX.SelectedIndex = 1

        ElseIf ChavePix.Contains("-") And ChavePix.Contains("/") Then
            Tipo_Chave_CBX.SelectedIndex = 3

        ElseIf ChavePix.Contains(".") And ChavePix.Contains("-") Then
            Tipo_Chave_CBX.SelectedIndex = 2

        Else
            Tipo_Chave_CBX.SelectedIndex = 4
        End If

        ChavePix_txb.Text = ChavePix
        Nome_txb.Text = Nome
    End Sub

    Private Sub Close_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Close_Pic.Click
        Me.Close()
    End Sub

    Private Sub ChavePix_txb_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ChavePix_txb.KeyPress
        If Tipo_Chave_CBX.SelectedIndex = 0 Then 'Telefone
            MaskCelular_KeyPress(sender, e)
        ElseIf Tipo_Chave_CBX.SelectedIndex = 2 Then 'CPF
            MaskCPF_KeyPress(sender, e)
        ElseIf Tipo_Chave_CBX.SelectedIndex = 3 Then 'CNPJ
            MaskCNPJ_KeyPress(sender, e)
        ElseIf Tipo_Chave_CBX.SelectedIndex = 4 Then 'Leatória

        End If
    End Sub

    Private Sub Gerar_QRCode_btn_Click(sender As System.Object, e As System.EventArgs) Handles Gerar_QRCode_btn.Click

        Dim TIP As String = Nothing
        Dim CHA As String = Nothing
        Dim NOM As String = Nothing
        Dim CID As String = Nothing
        Dim VAL As String = Nothing
        Dim COD As String = Nothing

        If Tipo_Chave_CBX.SelectedIndex = 0 Then
            CHA = ChavePix_txb.Text.Replace("(", "").Replace(")", "").Replace("-", "")

        ElseIf Tipo_Chave_CBX.SelectedIndex = 1 Then
            If Not ChavePix_txb.Text.Contains("@") Then
                Mensagem("O E-Mail está incorreto!")
                Exit Sub
            End If
            CHA = ChavePix_txb.Text.ToLower

        ElseIf Tipo_Chave_CBX.SelectedIndex = 2 Then
            CHA = ChavePix_txb.Text.Replace(".", "").Replace("-", "")
        ElseIf Tipo_Chave_CBX.SelectedIndex = 3 Then
            CHA = ChavePix_txb.Text.Replace(".", "").Replace("-", "").Replace("/", "")
        ElseIf Tipo_Chave_CBX.SelectedIndex = 4 Then
        End If

        TIP = Tipo_Chave_CBX.SelectedItem.ToString
        NOM = Nome_txb.Text
        CID = Cidade_txb.Text
        VAL = Valor_txb.Text.Replace("R$", "").Replace(" ", "")
        COD = Codigo_txb.Text

        Dim JsonTratar As String = GerarPix(TIP, CHA, VAL, NOM, CID, COD)
        Dim B As List(Of Dados) = JsonConvert.DeserializeObject(Of List(Of Dados))("[" & JsonTratar & "]")
        Dim QR As New QRCode

        For Each item As Dados In B
            QR.QR_Code_Base64 = item.qrcode_base64.Replace("data:image/png;base64,", "")
            QR.Code = item.code
            QR.Key_Type = item.key_type
            QR.Key = item.key
            QR.Amount = item.amount
            QR.Name_ = item.name
            QR.City = item.city
            QR.Reference = item.reference
            QR.Formated_amount = item.formated_amount
        Next

        Me.Close()
        QR.Show()

    End Sub

    Private Sub Mensagem_Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Mensagem_Timer.Tick
        Mensagem_lbl.Visible = False
        Mensagem_Timer.Stop()
    End Sub

    Sub Mensagem(ByVal MSG As String)
        Mensagem_Timer.Stop()
        Mensagem_lbl.Text = MSG
        Mensagem_lbl.Visible = True
        Mensagem_Timer.Start()
    End Sub

    Private Sub Valor_txb_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Valor_txb.KeyPress
        MaskApenasNumeros(sender, e)
    End Sub

    Private Sub Valor_txb_TextChanged(sender As System.Object, e As System.EventArgs) Handles Valor_txb.TextChanged
        MaskReal_ChangedText(sender)
    End Sub


    <Serializable()> _
    Public Class Dados
        Public Property qrcode_base64 As String
        Public Property code As String
        Public Property key_type As String
        Public Property key As String
        Public Property amount As String
        Public Property name As String
        Public Property city As String
        Public Property reference As String
        Public Property formated_amount As String
    End Class

    Private Sub Pagamento_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub

    Private Sub Pagamento_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub
End Class