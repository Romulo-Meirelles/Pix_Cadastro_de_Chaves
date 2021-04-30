Imports MessagingToolkit
Imports MessagingToolkit.QRCode



Public Class Pix

    Private Sub Pix_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaBordas(Me)
        CarregaBordas(Adicionar_btn)
        CarregaBordas(Remover_btn)
        CarregaBordas(Panel_Principal, 20)
        CarregaBordas(Panel_Mensagem, 20)
        Version_lbl.Text = "Versão: " & My.Application.Info.Version.ToString
        CreatorTable()
        LoadPix(ListView1)
    End Sub
    Private Sub Minimize_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Minimize_Pic.Click
        Try
            Me.Hide()
            NotifyIcon1.BalloonTipText = "Pix Minimizado..."
            NotifyIcon1.ShowBalloonTip(3000)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Close_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Close_Pic.Click
        Try
            End
            Application.Exit()
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
        Form_Move.MouseDown(sender, e)
    End Sub
    Private Sub Pix_Icon_Pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Pix_Icon_Pic.MouseMove
        Form_Move.MouseMove(sender, e)
    End Sub
    Private Sub Title_Label_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Title_Label.MouseDown
        Form_Move.MouseDown(sender, e)
    End Sub

    Private Sub Title_Label_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Title_Label.MouseMove
        Form_Move.MouseMove(sender, e)
    End Sub

    Private Sub Superior_Panel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Superior_Panel.MouseDown
        Form_Move.MouseDown(sender, e)
    End Sub
    Private Sub Superior_Panel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Superior_Panel.MouseMove
        Form_Move.MouseMove(sender, e)
    End Sub


    Private Sub Adicionar_btn_Click(sender As System.Object, e As System.EventArgs) Handles Adicionar_btn.Click
        Try
            Dim NovaChave As New Adicionar
            Dim Result As DialogResult = NovaChave.ShowDialog()

            If Result = Windows.Forms.DialogResult.OK Then
                Mensagem("Chave Pix adicionada com sucesso!")
            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
    End Sub

    Private Sub Remover_btn_Click(sender As System.Object, e As System.EventArgs) Handles Remover_btn.Click
        Try

            If MessageBox.Show("Tem certeza que deseja excluír " & ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text & "", "Exclusão.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            Delete(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text)
            ListView1.Items.Clear()
            LoadPix(ListView1)
            Mensagem("Chave Pix excluída com sucesso!")
            QR_Code_Pix_Pic.Visible = False
            QR_Code_lbl.Visible = False
            QR_Code_Banco_lbl.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensagem Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            Clipboard.SetText(ListView1.Items(ListView1.FocusedItem.Index).SubItems(2).Text)
            Mensagem("Chave Pix copiada com sucesso!")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseWheel
        
    End Sub



    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            Dim Pix As String = ListView1.Items(ListView1.FocusedItem.Index).SubItems(2).Text
            Dim qrencod As New QRCode.Codec.QRCodeEncoder
            Dim qrcode As Bitmap = qrencod.Encode(Pix)
            QR_Code_Pix_Pic.Image = TryCast(qrcode, Image)
            QR_Code_Banco_lbl.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text
            QR_Code_Pix_Pic.Visible = True
            QR_Code_lbl.Visible = True
            QR_Code_Banco_lbl.Visible = True
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
