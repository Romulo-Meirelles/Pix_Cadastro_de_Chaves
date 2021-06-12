Imports Pix_Chaves_Leatoria_e_Fixa.Tools
Public Class Pix
    Private Sub Pix_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaBordas(Me)
        CarregaBordas(Adicionar_btn, 5)
        CarregaBordas(Remover_btn, 5)
        CarregaBordas(Gerar_Pagamentos_btn, 5)
        CarregaBordas(Historico_btn, 5)
        CarregaBordas(Close_btn, 5)
        CarregaBordas(Minimize_btn, 5)
        CarregaBordas(Panel_Principal, 20)
        CarregaBordas(Panel_Mensagem, 20)
        Version_lbl.Text = "Versão: " & My.Application.Info.Version.ToString
        CreatorTable()
        LoadPix(ListView1)
    End Sub
    Private Sub Close_btn_Click(sender As System.Object, e As System.EventArgs) Handles Close_btn.Click
        Try
            NotifyIcon1.Visible = False
            End
            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Minimize_btn_Click(sender As System.Object, e As System.EventArgs) Handles Minimize_btn.Click
        Try
            Me.Hide()
            NotifyIcon1.BalloonTipText = "Pix Minimizado..."
            NotifyIcon1.ShowBalloonTip(3000)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        Try
            Me.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Me.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Pix_Icon_Pic_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Pix_Icon_Pic.MouseDown
        Tools.MouseDown(sender, e)
    End Sub
    Private Sub Pix_Icon_Pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Pix_Icon_Pic.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub
    Private Sub Title_Label_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Title_Label.MouseDown
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Title_Label_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Title_Label.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub

    Private Sub Superior_Panel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Superior_Panel.MouseDown
        Tools.MouseDown(sender, e)
    End Sub
    Private Sub Superior_Panel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Superior_Panel.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub
    Private Sub TabStoper()
        Me.ActiveControl = Nothing
    End Sub
   
    Private Sub Adicionar_btn_Click(sender As System.Object, e As System.EventArgs) Handles Adicionar_btn.Click
        Try

            TabStoper()

            If Application.OpenForms.OfType(Of Adicionar)().Count() > 0 Then
                Exit Sub
            End If

            Dim NovaChave As New Adicionar
            Dim Result As DialogResult = NovaChave.ShowDialog()
            Adicionar_btn.TabStop = False
            If Result = Windows.Forms.DialogResult.OK Then
                Mensagem("Chave Pix adicionada com sucesso!")
            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
    End Sub

    Private Sub Remover_btn_Click(sender As System.Object, e As System.EventArgs) Handles Remover_btn.Click
        Try
            TabStoper()

            If MessageBox.Show("Tem certeza que deseja excluír " & ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text & "", "Exclusão.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            Delete(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text)
            ListView1.Items.Clear()
            LoadPix(ListView1)
            Mensagem("Chave Pix excluída com sucesso!")
            QR_Code_Pix_Pic.Visible = False
            'QR_Code_lbl.Visible = False
            QR_Code_Banco_lbl.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensagem Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub Gerar_Pagamentos_btn_Click(sender As System.Object, e As System.EventArgs) Handles Gerar_Pagamentos_btn.Click
        On Error Resume Next
        TabStoper()

        If Application.OpenForms.OfType(Of Pagamento)().Count() > 0 Then
            Exit Sub
        End If

        QR_Code_Pix_Pic.Visible = False
        QR_Code_Banco_lbl.Visible = False
        Dim Pagamentos As New Pagamento
        Dim IT = ListView1.FocusedItem.Selected

        If IT = Nothing Or IT = False Then
            Pagamentos.Bancos = Nothing
            Pagamentos.ChavePix = Nothing
            Pagamentos.Nome = Nothing
        Else
            Dim p = ListView1.FocusedItem.Index
            Pagamentos.Bancos = ListView1.Items(p).SubItems(1).Text
            Pagamentos.ChavePix = ListView1.Items(p).SubItems(3).Text
            Pagamentos.Nome = ListView1.Items(p).SubItems(2).Text
        End If

        Pagamentos.Show()

    End Sub
    Private Sub Historico_btn_Click(sender As System.Object, e As System.EventArgs) Handles Historico_btn.Click
        Try
            TabStoper()

            If Application.OpenForms.OfType(Of Historico)().Count() > 0 Then
                Exit Sub
            End If

            Dim H As New Historico
            H.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer_Mensagem_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Mensagem.Tick
        Try
            Mensagem_lbl.ForeColor = Color.Red
            Mensagem_lbl.Text = "Dê 2 cliques para copiar a chave."
            Timer_Mensagem.Stop()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Mensagem(ByVal MSG As String)
        Mensagem_lbl.ForeColor = Color.LimeGreen
        Mensagem_lbl.Text = MSG
        Timer_Mensagem.Start()
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        Try
            Clipboard.SetText(ListView1.Items(ListView1.FocusedItem.Index).SubItems(3).Text)
            Mensagem("Chave Pix copiada com sucesso!")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            Dim IT = ListView1.FocusedItem.Selected

            If IT = Nothing Or IT = False Then
                QR_Code_Pix_Pic.Visible = False
                QR_Code_Banco_lbl.Visible = False
            Else
                Dim Pix As String = ListView1.Items(ListView1.FocusedItem.Index).SubItems(3).Text
                QR_Code_Pix_Pic.Image = GerarQRPicture(Pix) 'TryCast(qrcode, Image)
                QR_Code_Banco_lbl.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text
                QR_Code_Pix_Pic.Visible = True
                QR_Code_Banco_lbl.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Information_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Information_Pic.Click
        Try
            Dim Inf As New Information
            Inf.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    

  

    
End Class
