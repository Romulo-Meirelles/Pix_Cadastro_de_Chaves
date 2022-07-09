Imports System.ComponentModel

Public Class Pix
    Private LV_TEMP As New ListView With {
       .HeaderStyle = ColumnHeaderStyle.None,
       .Activation = ItemActivation.TwoClick,
       .AllowColumnReorder = True,
       .BorderStyle = BorderStyle.None,
       .Cursor = Cursors.Hand,
       .Dock = DockStyle.Fill,
       .FullRowSelect = True,
       .HideSelection = False,
       .MultiSelect = False,
       .View = View.Details}
    Private ListImage As New ImageList
    Friend Pass As String
    Private Async Sub Pix_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Await LoadNotes(RichTextBox_Tools1)
        RichTextBox_Tools1.MenuStrip = False
        RichTextBox_Tools1.ToolsStrip = True
        RichTextBox_Tools1.ContextMenuStrip = True
        RichTextBox_Tools1.EnableNew = False
        RichTextBox_Tools1.EnableOpen = False
        RichTextBox_Tools1.EnableSave = False
        RichTextBox_Tools1.Visible = False
        RichTextBox_Tools1.BringToFront()
    End Sub
    Private Sub Opening() Handles MyBase.Shown
        Call CarregarBordasForm()
        Version_lbl.Text = "Versão: " & My.Application.Info.Version.ToString
        CreatorTable()
        Call RefreshList()
    End Sub
    Public Sub RefreshList()
        ListImage.Images.Clear()
        ListImage = LoadPix(LV_TEMP)
        Call Search()
    End Sub
    Public Sub Search()
        On Error Resume Next
        Dim G As Integer

        ListView1.Items.Clear()
        ListView1.SmallImageList = ListImage

        For i = 0 To LV_TEMP.Items.Count - 1
            If LV_TEMP.Items(i).SubItems(0).Text.ToLower.Contains(Pesquisar_txt.Text.ToLower) Or LV_TEMP.Items(i).SubItems(1).Text.ToLower.Contains(Pesquisar_txt.Text.ToLower) Or LV_TEMP.Items(i).SubItems(2).Text.ToLower.Contains(Pesquisar_txt.Text.ToLower) Or LV_TEMP.Items(i).SubItems(4).Text.ToLower.Contains(Pesquisar_txt.Text.ToLower) Then
                ListView1.Items.Add(LV_TEMP.Items(i).SubItems(0).Text)
                'AQUI ABAIXO VAI COLOCANDO OS SUBITENS QUE TENS
                ListView1.Items(G).SubItems.Add(LV_TEMP.Items(i).SubItems(1).Text)
                ListView1.Items(G).SubItems.Add(LV_TEMP.Items(i).SubItems(2).Text)
                ListView1.Items(G).SubItems.Add(LV_TEMP.Items(i).SubItems(3).Text)
                ListView1.Items(G).SubItems.Add(LV_TEMP.Items(i).SubItems(4).Text)
                ListView1.Items(G).SubItems.Add(LV_TEMP.Items(i).SubItems(5).Text)
                ListView1.Items(G).SubItems.Add(LV_TEMP.Items(i).SubItems(6).Text)
                ListView1.Items(G).SubItems.Add(LV_TEMP.Items(i).SubItems(7).Text)
                ListView1.Items(G).SubItems.Add(LV_TEMP.Items(i).SubItems(8).Text)
                ListView1.Items(G).SubItems.Add(LV_TEMP.Items(i).SubItems(9).Text)
                G = G + 1
            End If
        Next

        Dim ITEMCOUNT As Integer = 0
        For Each L As ListViewItem In ListView1.Items
            Dim NAMES As String = L.SubItems(1).Text
            ListView1.Items(L.Index).ImageKey = NAMES
            ListView1.Items(ITEMCOUNT).UseItemStyleForSubItems = False
            ListView1.Items(ITEMCOUNT).SubItems(3).ForeColor = Color.DeepSkyBlue
            ITEMCOUNT += 1
        Next
        Swith_Group()
    End Sub
    Private Sub Pesquisar_txt_TextChanged(sender As Object, e As EventArgs) Handles Pesquisar_txt.TextChanged
        Call Search()
    End Sub
    Private Sub Close_btn_Click(sender As System.Object, e As System.EventArgs)
        Try
            NotifyIcon1.Visible = False
            End
            Application.Exit()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub Minimize_btn_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Hide()
            NotifyIcon1.BalloonTipText = "Pix Minimizado..."
            NotifyIcon1.ShowBalloonTip(3000)
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub NotifyIcon1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        Try
            If CheckPassword(Pass) = True Then
                Me.Show()
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            If CheckPassword(Pass) = True Then
                Me.Show()
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub TabStoper()
        Me.ActiveControl = Nothing
    End Sub
    Private Sub Adicionar_btn_Click(sender As System.Object, e As System.EventArgs) Handles Adicionar_btn.Click
        Try

            TabStoper()

            If Application.OpenForms.OfType(Of Adicionar_Conta)().Count() > 0 Then
                Exit Sub
            End If

            Dim NovaChave As New Adicionar_Conta
            Dim Result As DialogResult = NovaChave.ShowDialog()
            Adicionar_btn.TabStop = False
            If Result = Windows.Forms.DialogResult.OK Then
                Call RefreshList()
                MensagemBox("Chave Pix adicionada com sucesso!", MessageNumber.Ok_, "Copiado.")
            End If


        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub Remover_btn_Click(sender As System.Object, e As System.EventArgs) Handles Remover_btn.Click
        Try
            If IsNothing(ListView1.FocusedItem) Then
                MensagemBox("Selecione o Pix que deseja apagar!", MessageNumber.Exclamation_, "Atualização.")
            Else
                TabStoper()

                If MensagemBox("Tem certeza que deseja excluír " & ListView1.Items(ListView1.Activation).SubItems(1).Text & "", MessageNumber.YesOrNo_, "Exclusão.") = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If

                Delete(ListView1.Items(ListView1.Activation).SubItems(0).Text)
                Call RefreshList()
                MensagemBox("Chave Pix excluída com sucesso!", MessageNumber.Ok_, "Exclusão!")
                QR_Code_Pix_Pic.Visible = False
                'QR_Code_lbl.Visible = False
                QR_Code_Banco_lbl.Visible = False
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub Editar_btn_Click(sender As Object, e As EventArgs) Handles Editar_btn.Click
        Try

            If IsNothing(ListView1.FocusedItem) Then
                MensagemBox("Selecione o Banco que deseja editar!", MessageNumber.Exclamation_, "Atualização.")
            Else
                Dim Editar As New Adicionar_Conta

                Editar.Add_Bancos_btn.Visible = False
                Editar.Editar_Conta_btn.Visible = True
                Editar.Adicionar_btn.Visible = False
                Editar.ID = ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text
                Editar.Banco_Cbx.SelectedItem = ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text
                Editar.Nome_txb.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(2).Text
                Editar.Chave_Pix_txt.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(3).Text
                Editar.Chave_Tipo_Cbx.SelectedItem = ListView1.Items(ListView1.FocusedItem.Index).SubItems(4).Text
                Editar.Codigo_Banco_txt.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(5).Text
                Editar.Agencia_txt.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(6).Text
                Editar.Conta_txt.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(7).Text
                Editar.Operacao_txt.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(8).Text
                Editar.Tipo_Conta_cbx.SelectedItem = ListView1.Items(ListView1.FocusedItem.Index).SubItems(9).Text

                Dim Result As DialogResult = Editar.ShowDialog()

                If Result = Windows.Forms.DialogResult.OK Then
                    Call RefreshList()
                End If
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub Gerar_Pagamentos_btn_Click(sender As System.Object, e As System.EventArgs) Handles Gerar_Pagamentos_btn.Click
        On Error Resume Next
        If IsNothing(ListView1.FocusedItem) Then
            MensagemBox("Selecione o Pix que deseja o QRCode!", MessageNumber.Exclamation_, "Atualização.")
        Else

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
        End If
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
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        Try
            Clipboard.SetText(ListView1.Items(ListView1.FocusedItem.Index).SubItems(3).Text)
            MensagemBox("Chave Pix copiada com sucesso!", MessageNumber.Ok_, "Copiado.")
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next

        If IsNothing(ListView1.FocusedItem) = True Then
            QR_Code_Pix_Pic.Visible = False
            QR_Code_Banco_lbl.Visible = False
        Else
            Dim Pix As String = ListView1.Items(ListView1.FocusedItem.Index).SubItems(3).Text
            QR_Code_Pix_Pic.Image = GerarQRPicture(Pix)
            QR_Code_Banco_lbl.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text
            QR_Code_Pix_Pic.Visible = True
            QR_Code_Banco_lbl.Visible = True
            CodigoBanco_txb.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(5).Text
            Agencia_txb.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(6).Text
            Conta_txb.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(7).Text
            Operacao_txb.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(8).Text
            Tipo_txb.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(9).Text
            Banco_txb.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text
        End If
    End Sub
    Private Sub Information_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Information_Pic.Click
        Try
            Dim Inf As New Information
            Inf.ShowDialog()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub CarregarBordasForm()
        On Error Resume Next
        If ListView1.Width = 0 Or ListView1.Height = 0 Then
            GoTo Nextime
        End If
        Using bmp1 = New Bitmap(ListView1.Width, ListView1.Height)
            Using g1 = Graphics.FromImage(bmp1)
                g1.DrawImage(My.Resources.Pix_2500x1472, 0, 0, bmp1.Width, bmp1.Height)
                ListView1.BackgroundImage = bmp1.Clone
            End Using
        End Using

Nextime:
        CarregaBordas(Me)
        CarregaBordas(Adicionar_btn, 5)
        CarregaBordas(Remover_btn, 5)
        CarregaBordas(Editar_btn, 5)
        CarregaBordas(Gerar_Pagamentos_btn, 5)
        CarregaBordas(Historico_btn, 5)
        CarregaBordas(Panel_Principal, 20)
        CarregaBordas(Panel_Mensagem, 20)
    End Sub
    Private Sub Pix_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Call CarregarBordasForm()
    End Sub

    Private Sub ListView1_Resize(sender As Object, e As EventArgs) Handles ListView1.Resize
        ListView1.Columns(ListView1.Columns.Count - 1).Width = -2
        Tipo_Chave_lbl.Location = New Size(ListView1.Width - 152, 8)
    End Sub
    Private Sub Switch_Grupos_CheckedChanged(sender As Object) Handles Switch_Grupos.CheckedChanged

        Try
            If Switch_Grupos.Checked = True Then
                My.Settings.Grupos = True
                My.Settings.Save()
                Swith_Group()
            Else
                ListView1.Groups.Clear()
                My.Settings.Grupos = False
                My.Settings.Save()
                Swith_Group()
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try


    End Sub
    Private Sub Swith_Group()
        Try
            If My.Settings.Grupos = True Then
                Dim flag As Boolean = True
                For Each l As ListViewItem In ListView1.Items
                    Dim strmyGroupname As String = l.SubItems(2).Text
                    For Each lvg As ListViewGroup In ListView1.Groups
                        If lvg.Name = strmyGroupname Then
                            l.Group = lvg
                            flag = False
                        End If
                    Next

                    If flag = True Then
                        Dim lstGrp As New ListViewGroup(strmyGroupname, strmyGroupname)
                        ListView1.Groups.Add(lstGrp)
                        l.Group = lstGrp
                    End If
                    flag = True
                Next
                Switch_Grupos.Checked = True
            Else
                ListView1.Groups.Clear()
                Switch_Grupos.Checked = False
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub Setting_btn_Click(sender As Object, e As EventArgs) Handles Setting_btn.Click
        Dim Settings As New NewPassword
        Settings.Show()
    End Sub
    Private Async Sub Note_btn_Click(sender As Object, e As EventArgs) Handles Note_btn.Click
        If ListView1.Visible Then
            ListView1.Visible = False
            Panel1.Visible = False
            RichTextBox_Tools1.Visible = True
            RichTextBox_Tools1.BringToFront()
        Else
            ListView1.Visible = True
            Panel1.Visible = True
            RichTextBox_Tools1.Visible = False
            Await SaveNotes(RichTextBox_Tools1)
        End If
    End Sub
    Private Async Sub Pix_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Await SaveNotes(RichTextBox_Tools1)
            End
        Catch ex As Exception
            End
        End Try
    End Sub
End Class
