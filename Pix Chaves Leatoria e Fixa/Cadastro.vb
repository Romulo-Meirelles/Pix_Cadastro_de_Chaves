Imports System.ComponentModel
Imports ToolsBox.Utils
Public Class Cadastro
    Dim CadastroFeito As Boolean = False
    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaBordas(Concluir_btn, 5)
        CarregaBordas(Sem_Senha_btn, 5)
    End Sub
    Private Sub RescrevaPassword_txb_TextChanged(sender As Object, e As EventArgs) Handles RescrevaPassword_txb.TextChanged
        If Novo_Password_txb.Text <> RescrevaPassword_txb.Text Then
            PopLabel_lbl.Visible = True
            PopLabel_lbl.ForeColor = Color.Red
            PopLabel_lbl.Text = "Os carecteres diferem!"
        Else
            PopLabel_lbl.Visible = True
            PopLabel_lbl.ForeColor = Color.LimeGreen
            PopLabel_lbl.Text = "Os carecteres são iguais!"
        End If
    End Sub
    Private Sub Novo_Password_txb_TextChanged(sender As Object, e As EventArgs) Handles Novo_Password_txb.TextChanged
        If Novo_Password_txb.Text <> RescrevaPassword_txb.Text Then
            PopLabel_lbl.Visible = True
            PopLabel_lbl.ForeColor = Color.Red
            PopLabel_lbl.Text = "Os carecteres diferem!"
        Else
            PopLabel_lbl.Visible = True
            PopLabel_lbl.ForeColor = Color.LimeGreen
            PopLabel_lbl.Text = "Os carecteres são iguais!"
        End If
    End Sub
    Private Sub Email_txb_KeyDown(sender As Object, e As KeyEventArgs) Handles Email_txb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cadastro()
        End If
    End Sub

    Private Sub Concluir_btn_Click(sender As Object, e As EventArgs) Handles Concluir_btn.Click
        Cadastro()
    End Sub

    Private Sub Cadastro()
        If Email_txb.Text.Length <= 5 Or Not Email_txb.Text.Contains("@") Then
            MensagemBox("Coloque um E-Mail Válido", MessageNumber.Exclamation_, "E-Mail.")
            Exit Sub
        End If

        If Novo_Password_txb.Text <> RescrevaPassword_txb.Text Then
            MensagemBox("As senhas não são idênticas!", MessageNumber.Exclamation_, "Senhas Diferentes.")
            Exit Sub
        End If

        If Novo_Password_txb.Text.Length < 3 Or RescrevaPassword_txb.Text.Length < 3 Then
            MensagemBox("Senha menor que 3 caracteres!", MessageNumber.Exclamation_, "Senha Inválida.")
            Exit Sub
        End If

        Call CreatorTable()

        If CreateNewPassword(Novo_Password_txb.Text, Email_txb.Text) = True Then
            CadastroFeito = True
            Dim Pix1 As New Pix
            Pix1.NotifyIcon1.Visible = True
            Pix1.Pass = Novo_Password_txb.Text
            Me.Hide()
            Pix1.Show()
        Else
            If IO.File.Exists(My.Application.Info.DirectoryPath.ToString & "/Pix_DataBase.pix") Then
                IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "/Pix_DataBase.pix")
            End If
            MensagemBox("Não foi possivel cadastrar!", MessageNumber.Error_, "Cadastro.")
        End If

    End Sub
    Private Sub Sem_Senha_btn_Click(sender As Object, e As EventArgs) Handles Sem_Senha_btn.Click

        If Email_txb.Text.Length <= 5 Or Not Email_txb.Text.Contains("@") Then
            MensagemBox("Coloque pelo menos um E-Mail Válido", MessageNumber.Exclamation_, "E-Mail.")
            Exit Sub
        End If

        Call CreatorTable()
        If CreateNewPassword("", Email_txb.Text) = True Then
            CadastroFeito = True
            Dim Pix1 As New Pix
            Pix1.NotifyIcon1.Visible = True
            Pix1.Pass = ""
            Me.Hide()
            Pix1.Show()
        Else
            If IO.File.Exists(My.Application.Info.DirectoryPath.ToString & "/Pix_DataBase.pix") Then
                IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "/Pix_DataBase.pix")
            End If
            MensagemBox("Não foi possivel cadastrar!", MessageNumber.Error_, "Cadastro.")
        End If
    End Sub
    Private Sub Cadastro_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            If CadastroFeito = False Then
                If IO.File.Exists(My.Application.Info.DirectoryPath.ToString & "/Pix_DataBase.pix") Then
                    IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "/Pix_DataBase.pix")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class