Imports Pix_Payload.CobrancaModels
Imports Pix_Payload.PayloadModels

Public Class Pagamento
    Dim LOCAT As Point
    Public Property Bancos As String
    Public Property ChavePix As String
    Public Property Nome As String

    Private Sub Pagamento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Tools.CarregaBordas(Me)

        CarregaBordas(Gerar_QRCode_btn, 5)

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
        Try
            Dim BAN As String = String.Empty
            Dim TIP As String = String.Empty
            Dim CHA As String = String.Empty
            Dim NOM As String = String.Empty
            Dim SEV As String = String.Empty
            Dim CID As String = String.Empty
            Dim VAL As String = String.Empty
            Dim COD As String = String.Empty


            If Tipo_Chave_CBX.SelectedIndex = 0 Then 'CELULAR
                CHA = ChavePix_txb.Text.Replace("(", "").Replace(")", "").Replace("-", "")

            ElseIf Tipo_Chave_CBX.SelectedIndex = 1 Then 'E-MAIL
                If Not ChavePix_txb.Text.Contains("@") Then
                    Mensagem("O E-Mail está incorreto!")
                    Exit Sub
                End If
                CHA = ChavePix_txb.Text.ToLower

            ElseIf Tipo_Chave_CBX.SelectedIndex = 2 Then 'CPF
                CHA = ChavePix_txb.Text.Replace(".", "").Replace("-", "")

            ElseIf Tipo_Chave_CBX.SelectedIndex = 3 Then 'CNPJ
                CHA = ChavePix_txb.Text.Replace(".", "").Replace("-", "").Replace("/", "")

            ElseIf Tipo_Chave_CBX.SelectedIndex = 4 Then 'OUTROS
                CHA = ChavePix_txb.Text
            End If

            If CHA = "" Then
                MessageBox.Show("Coloque uma chave Pix Válida!.", "Pix Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

           

            BAN = Bancos
            TIP = Tipo_Chave_CBX.SelectedItem.ToString
            NOM = Nome_txb.Text
            SEV = ServProd_txb.Text
            CID = Cidade_txb.Text
            VAL = Valor_txb.Text.Replace("R$", "").Replace(" ", "").Replace(",", ".")
            COD = Codigo_txb.Text

            Dim QR As New QRCode
            Dim QRCode As String = Gerar(Pix:=CHA, ServicoProduto:=SEV, Nome:=NOM, Cidade:=CID, Valores:=VAL, ID:=COD)

            With QR
                .QR_Code = QRCode
                .Tipo_Chave = TIP
                .Chave = CHA
                .Nome = NOM
                .Servico = SEV
                .Valor = VAL
                .Cidade = CID
                .Codigo = COD
            End With


            ''''DataBase
            Dim HIST As New HistoricoDataBase
            If Bancos = Nothing Then
                BAN = "Ausente"
            End If
            If TIP = Nothing Then
                TIP = "Ausente"
            End If
            If NOM = Nothing Then
                NOM = "Ausente"
            End If
            If SEV = Nothing Then
                SEV = "Ausente"
            End If
            If VAL = Nothing Then
                VAL = "Ausente"
            End If
            If CID = Nothing Then
                CID = "Ausente"
            End If
            If COD = Nothing Then
                COD = "Ausente"
            End If
            HIST.Insert_Historico(BAN, NOM, CHA, VAL, TIP, SEV, CID, COD, QRCode, Date.Today.ToShortDateString.ToString)
            ''''End DataBase

            Me.Close()
            QR.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'MessageBox.Show("Não foi possivel gerar o QRCode.", "QRCode Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub Tipo_Chave_CBX_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Tipo_Chave_CBX.SelectedIndexChanged
        Try
            ChavePix_txb.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Close_btn_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Superior_Panel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Superior_Panel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Tools.MouseMove(sender, e, Me)
    End Sub

    Private Sub Title_Label_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Title_Label_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Tools.MouseMove(sender, e, Me)
    End Sub

    Private Sub Pix_Icon_Pic_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Pix_Icon_Pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Tools.MouseMove(sender, e, Me)
    End Sub
End Class