Imports System.Text
Imports ToolsBox.Utils
Public Class Esqueci_Senha
    Private YourEmail As String
    Private Sub Esqueci_Senha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaBordas(Enviar_btn, 5)
        CarregaBordas(Reenviar_btn, 5)
        CarregaBordas(Trocar_btn, 5)

    End Sub
    Private Sub Enviar_btn_Click(sender As Object, e As EventArgs) Handles Enviar_btn.Click

        Try
            If Not EMail_txb.Text.Contains("@") Then
                MensagemBox("Insira o e-mail corretamente!", MessageNumber.Error_, "E-Mail Incorreto.")
                Exit Sub
            End If

            Dim Checkup As String = CheckEmailExist(EMail_txb.Text)

            If Checkup = "False" Then
                MensagemBox("O Email inserido não existe na base de dados!", MessageNumber.Error_, "E-Mail Incorreto.")
            ElseIf Checkup <> "False" Then
                Dim EM As New ToolsBox.Utils.EMails(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString({&H63, &H47, &H6C, &H34, &H4C, &H6D, &H6C, &H75, &H62, &H33, &H5A, &H68, &H64, &H47, &H6C, &H76, &H62, &H6B, &H42, &H76, &H64, &H58, &H52, &H73, &H62, &H32, &H39, &H72, &H4C, &H6D, &H4E, &H76, &H62, &H51, &H3D, &H3D}))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString({&H55, &H47, &H6C, &H34, &H51, &H44, &H49, &H77, &H4D, &H6A, &H49, &H3D}))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString({&H63, &H32, &H31, &H30, &H63, &H43, &H35, &H76, &H5A, &H6D, &H5A, &H70, &H59, &H32, &H55, &H7A, &H4E, &H6A, &H55, &H75, &H59, &H32, &H39, &H74}))))
                Dim Enviado = EM.Send("Pix Inovation Password Recovery.", "O seu código de recuperação é: " & Checkup & vbCrLf & "Insira o seu código no programa." & vbCrLf & vbCrLf & "Att: Pix Inovation!", EMail_txb.Text.ToLower)

                If Enviado = True Then
                    YourEmail = EMail_txb.Text
                    MensagemBox("Código enviado com sucesso!", MessageNumber.Ok_, "Enviado.")
                    Email_lbl.Text = "Insira o seu código! " & vbCrLf & "Não esqueça de verificar na caixa de Spam ou Lixo Eletrônico!"
                    Enviar_btn.Visible = False
                    Reenviar_btn.Visible = True
                    Trocar_btn.Visible = True
                    EMail_txb.Clear()
                Else
                    MensagemBox("Não foi possível enviar o código! Verifique o Firewall.", MessageNumber.Error_, "Error.")
                End If

            Else
                MensagemBox("Não foi possivel recuperar a senha!", MessageNumber.Error_, "Error.")
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error.")
        End Try
    End Sub
    Private Sub Trocar_btn_Click(sender As Object, e As EventArgs) Handles Trocar_btn.Click
        Dim Checkup As String = CheckEmailExist(YourEmail)
        If Checkup <> "False" Then
            If Checkup = EMail_txb.Text Then
                Dim NewPass As New NewPassword
                NewPass.Antigo_Password_lbl.Enabled = False
                NewPass.Antigo_Password_txb.Enabled = False
                NewPass.Antigo_Password_lbl.Visible = False
                NewPass.Antigo_Password_txb.Visible = False
                NewPass.Height = NewPass.Height - 70
                Me.Hide()
                NewPass.ShowDialog()

                If NewPass.DialogResult = DialogResult.Yes Then
                    Dim Pix As New Pix
                    Pix.Show()
                    Me.Close()
                Else
                    Me.Show()
                End If
            Else
                MensagemBox("Código Incorreto!", MessageNumber.Error_, "Incorreto.")
            End If
        Else
            MensagemBox("Error na reposição do código!", MessageNumber.Error_, "Error.")
        End If
    End Sub

    Private Sub Reenviar_btn_Click(sender As Object, e As EventArgs) Handles Reenviar_btn.Click
        Try
            Email_lbl.Text = "Insira seu e-mail cadastrado."
            Enviar_btn.Visible = True
            Reenviar_btn.Visible = False
            Trocar_btn.Visible = False
            EMail_txb.Clear()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error.")
        End Try
    End Sub
End Class