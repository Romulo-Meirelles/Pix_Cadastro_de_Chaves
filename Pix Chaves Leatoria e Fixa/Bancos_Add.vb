Imports ToolsBox.Utils
Public Class Bancos_Add

    Private Sub Bancos_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaBordas(Adicionar_btn, 5)
        CarregaBordas(Browser_btn, 5)
        CarregaBordas(Remover_btn, 5)
        CarregaBordas(Editar_btn, 5)
        CarregaBordas(ListView1, 5)

        LoadBancos(ListView1)

    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If IsNothing(ListView1.FocusedItem) = True Then
        Else
            Codigo_txb.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text
            Nome_txb.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(2).Text
            Foto_txb.Clear()
        End If
    End Sub
    Private Sub Codigo_txb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Codigo_txb.KeyPress
        MaskApenasNumeros(sender, e)
    End Sub
    Private Sub Browser_btn_Click(sender As Object, e As EventArgs) Handles Browser_btn.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Title = "Selecione o arquivo"
        OpenFileDialog1.Filter = "Fotos PNG (*.png)|*.png|Fotos JPG (*.jpg)|*.jpg|Fotos JPEG (*.jpeg)|*.jpeg|Fotos BMP (*.bmp)|*.bmp|Todos os arquivos (*.*)|*.*"
        OpenFileDialog1.FileName = "Arquivo_Nome"
        ' OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Foto_txb.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub Adicionar_btn_Click(sender As Object, e As EventArgs) Handles Adicionar_btn.Click
        If Codigo_txb.Text = "" Then
            MensagemBox("Preencha com o código do banco!", MessageNumber.Exclamation_, "Código.")
            Exit Sub
        End If

        If Nome_txb.Text = "" Then
            MensagemBox("Preencha com o nome do banco!", MessageNumber.Exclamation_, "Nome.")
            Exit Sub
        End If

        If Foto_txb.Text = "" Then
            MensagemBox("Preencha com a foto do banco!", MessageNumber.Exclamation_, "Foto.")
            Exit Sub
        End If

        Try
            Dim Foto As Byte() = IO.File.ReadAllBytes(Foto_txb.Text)
            If IsNothing(Foto) Then
                Dim imgCon As New ImageConverter()
                Foto = DirectCast(imgCon.ConvertTo(My.Resources.Exclamation_50px, GetType(Byte())), Byte())
            End If

            Dim G = InsertBancos({Codigo_txb.Text, Nome_txb.Text, Foto})
            If G = True Then
                MensagemBox("Banco Cadastrado com sucesso!", MessageNumber.Ok_, "Mensagem.")
                ListView1.Items.Clear()
                LoadBancos(ListView1)
                Codigo_txb.Clear()
                Nome_txb.Clear()
                Foto_txb.Clear()
            Else
                MensagemBox("Não foi possivél salvar!", MessageNumber.Error_, "Mensagem.")
                ListView1.Items.Clear()
                LoadBancos(ListView1)
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Mensagem.")
        End Try
    End Sub
    Private Sub Editar_btn_Click(sender As Object, e As EventArgs) Handles Editar_btn.Click
        Try
            Dim Foto As Byte() = Nothing

            If IsNothing(ListView1.FocusedItem) Then
                MensagemBox("Selecione o Banco que deseja editar!", MessageNumber.Exclamation_, "Atualização.")
            Else
                If Codigo_txb.Text = "" Then
                    MensagemBox("Preencha com o código do banco!", MessageNumber.Exclamation_, "Código.")
                    Exit Sub
                ElseIf Nome_txb.Text = "" Then
                    MensagemBox("Preencha com o nome do banco!", MessageNumber.Exclamation_, "Nome.")
                    Exit Sub
                ElseIf Foto_txb.Text = "" Then
                    Dim imgCon As New ImageConverter()
                    Foto = DirectCast(imgCon.ConvertTo(My.Resources.No_Bank_50px, GetType(Byte())), Byte())
                Else
                    Foto = IO.File.ReadAllBytes(Foto_txb.Text)
                End If

                If MensagemBox("Deseja realmente alterar o banco?", MessageNumber.YesOrNo_, "Atualização.") = Windows.Forms.DialogResult.Yes Then

                    If UpdateBanco(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text, {Codigo_txb.Text, Nome_txb.Text, Foto}) = True Then
                        MensagemBox("Banco atualizado com sucesso!", MessageNumber.Ok_, "Atualização.")
                        Codigo_txb.Clear()
                        Nome_txb.Clear()
                        Foto_txb.Clear()
                        LoadBancos(ListView1)
                    Else
                        MensagemBox("Não foi possível atualizar!", MessageNumber.Error_, "Atualização.")
                    End If
                End If
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub Remover_btn_Click(sender As Object, e As EventArgs) Handles Remover_btn.Click
        Try
            If MensagemBox("Deseja excluir esse banco?", MessageNumber.YesOrNo_, "Exclusão.") = Windows.Forms.DialogResult.Yes Then
                DeleteBanco(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text)
                ListView1.Items.Clear()
                LoadBancos(ListView1)
                MensagemBox("Banco excluído com sucesso!", MessageNumber.Ok_, "Mensagem.")
            End If

        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
End Class