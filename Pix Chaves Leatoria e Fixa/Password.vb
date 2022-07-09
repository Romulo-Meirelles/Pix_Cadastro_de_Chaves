Imports ToolsBox.Utils
Public Class Password
    Private Pix1 As New Pix
    Private Count As Integer = 0
    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaBordas(Entrar_btn, 5)
        Password_txb.Focus()
    End Sub
    Private Sub Opening() Handles MyBase.Shown
        Me.Opacity = 0

        If CheckDataBaseExist() = False Then
            Me.Hide()
            Dim Register As New Cadastro
            Register.Show()
            Exit Sub
        End If

        If CheckPassword("") = True Then
            Me.Hide()
            Pix1.Pass = ""
            Pix1.NotifyIcon1.Visible = True
            Pix1.Show()
            Exit Sub
        End If

        Me.Opacity = 100
    End Sub
    Private Sub Password_txb_KeyDown(sender As Object, e As KeyEventArgs) Handles Password_txb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Entrar()
        End If
    End Sub
    Private Sub Entrar_btn_Click(sender As Object, e As EventArgs) Handles Entrar_btn.Click
        Entrar()
    End Sub

    Private Sub Entrar()

        If CheckPassword(Password_txb.Text) = True Then
            Me.Hide()
            Pix1.Pass = Password_txb.Text
            Pix1.NotifyIcon1.Visible = True
            Pix1.Show()

        Else
            Me.Hide()
            MensagemBox("Password Incorreto", MessageNumber.Error_, "Password.")
            Count += 1
            Password_txb.Clear()
            If Count = 3 Then
                Application.Exit()
                Close()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub Esqueci_Senha_llb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Esqueci_Senha_llb.LinkClicked
        Try
            Dim EsqueciSenha As New Esqueci_Senha
            Me.Hide()
            EsqueciSenha.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class