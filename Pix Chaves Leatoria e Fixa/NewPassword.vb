Imports ToolsBox.Utils
Public Class NewPassword
    Private _Result As String
    ReadOnly Property Result() As String
        Get
            Return _Result
        End Get
    End Property
    Private Sub NewPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaBordas(Concluir_btn, 5)

        If CheckPassword("") = True Then
            Antigo_Password_lbl.Enabled = False
            Antigo_Password_txb.Enabled = False
            Antigo_Password_lbl.Visible = False
            Antigo_Password_txb.Visible = False
            Me.Height = Me.Height - 70
        End If
    End Sub
    Private Sub RescrevaPassword_txb_TextChanged(sender As Object, e As EventArgs) Handles ReescrevaPassword_txb.TextChanged
        If Novo_Password_txb.Text <> ReescrevaPassword_txb.Text Then
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
        If Novo_Password_txb.Text <> ReescrevaPassword_txb.Text Then
            PopLabel_lbl.Visible = True
            PopLabel_lbl.ForeColor = Color.Red
            PopLabel_lbl.Text = "Os carecteres diferem!"
        Else
            PopLabel_lbl.Visible = True
            PopLabel_lbl.ForeColor = Color.LimeGreen
            PopLabel_lbl.Text = "Os carecteres são iguais!"
        End If
    End Sub
    Private Sub ReescrevaPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles ReescrevaPassword_txb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call TrocarSenha()
        End If
    End Sub
    Private Sub Concluir_btn_Click(sender As Object, e As EventArgs) Handles Concluir_btn.Click
        Call TrocarSenha()
    End Sub
    Private Sub TrocarSenha()
        If Novo_Password_txb.Text <> ReescrevaPassword_txb.Text Then
            MensagemBox("As senha não condizem!", MessageNumber.Exclamation_, "Senha.")
            Exit Sub
        End If

        If Antigo_Password_txb.Visible = True Then
            If CheckPassword(Antigo_Password_txb.Text) = False Then
                MensagemBox("A senha original Incorreta!", MessageNumber.Exclamation_, "Senha.")
                Exit Sub
            End If
        End If

        If ChangePassword(Novo_Password_txb.Text) = True Then
            Me.Hide()
            MensagemBox("Sua senha foi alterada com sucesso!", MessageNumber.Ok_, "Senha.")
            Antigo_Password_txb.Clear()
            Novo_Password_txb.Clear()
            ReescrevaPassword_txb.Clear()
            _Result = Windows.Forms.DialogResult.Yes
            Me.DialogResult = Windows.Forms.DialogResult.Yes
            Me.Close()
        Else
            MensagemBox("Erro na troca de senha!", MessageNumber.Exclamation_, "Senha.")
        End If
    End Sub


End Class