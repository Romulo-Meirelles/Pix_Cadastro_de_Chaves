Public Class Mensagem
    Private _Result As String

    ReadOnly Property Result() As String
        Get
            Return _Result
        End Get
    End Property
    Private Sub Fechar_btn_Click(sender As Object, e As EventArgs) Handles Fechar_btn.Click
        Me.Close()
    End Sub

    Private Sub Yes_btn_Click(sender As Object, e As EventArgs) Handles Yes_btn.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        _Result = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub No_btn_Click(sender As Object, e As EventArgs) Handles No_btn.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        _Result = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub
End Class

Public Module Msg
    Enum MessageNumber
        Nothing_ = 0
        Ok_ = 1
        Exclamation_ = 2
        Error_ = 3
        Interrogation_ = 4
        YesOrNo_ = 5
    End Enum

    Public Function MensagemBox(ByVal Texto As String, Optional ByVal Icon_ As MessageNumber = MessageNumber.Nothing_, ByVal Optional Titulo As String = "") As Object
        Try
            Dim MSGSS As New Mensagem
            MSGSS.Control_TaskBar_Top1.Text = Titulo
            MSGSS.Mensagem_lbl.Text = Texto
            CarregaBordas(MSGSS.Fechar_btn, 5)
            CarregaBordas(MSGSS.Yes_btn, 5)
            CarregaBordas(MSGSS.No_btn, 5)

            Select Case Icon_
                Case MessageNumber.Nothing_
                    MSGSS.PictureBox1.Image = Nothing
                Case MessageNumber.Ok_
                    MSGSS.PictureBox1.Image = My.Resources.ok_50px
                Case MessageNumber.Exclamation_
                    MSGSS.PictureBox1.Image = My.Resources.Exclamation_50px
                Case MessageNumber.Error_
                    MSGSS.PictureBox1.Image = My.Resources.Close_50px
                Case MessageNumber.Interrogation_
                    MSGSS.PictureBox1.Image = My.Resources.Question_mark_50px
                Case MessageNumber.YesOrNo_
                    MSGSS.PictureBox1.Image = My.Resources.Question_mark_50px
                    MSGSS.Fechar_btn.Visible = False
                    MSGSS.Yes_btn.Visible = True
                    MSGSS.No_btn.Visible = True
                Case Else
                    MSGSS.PictureBox1.Image = Nothing
            End Select

            Using MSGSS

                Dim Resultado = MSGSS.ShowDialog()

                If DialogResult.Yes = Resultado Then
                    Return MSGSS.Result
                ElseIf DialogResult.No = Resultado Then
                    Return MSGSS.Result
                Else
                    Return True
                End If
            End Using

            ' Return True
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
End Module

