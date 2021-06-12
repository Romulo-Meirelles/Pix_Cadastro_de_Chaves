Public Class Adicionar

    Private CX_TEMP As ListView = New ListView
    Dim LOCAT As Point

    Private Sub Adicionar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaBordas(Adicionar_btn, 5)
        CarregaBordas(Close_btn, 5)
        CarregaBordas(Banco_Pic)
        CarregaBordas(Me)
        Chave_Tipo_Cbx.SelectedIndex = 4

        For i = 0 To Bancos.Bancos.Count - 1
            CX_TEMP.Items.Add(Bancos.Bancos(i))
        Next

        Call Search()

    End Sub

    Private Sub Adicionar_btn_Click(sender As System.Object, e As System.EventArgs) Handles Adicionar_btn.Click
        Try
            If Banco_Cbx.SelectedItem = "" Or Nome_txb.Text = "" Or Chave_Pix_txt.Text = "" Then
                MessageBox.Show("Preencha todos os campos.", "Mensagem.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Chave_Tipo_Cbx.SelectedIndex = 1 Then
                If Not Chave_Pix_txt.Text.Contains("@") Then
                    MessageBox.Show("Preencha o E-Mail corretamente!", "Mensagem.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Chave_Pix_txt.Text = Chave_Pix_txt.Text.ToLower
            End If

            Insert(Banco_Cbx.SelectedItem.ToString, Nome_txb.Text, Chave_Pix_txt.Text)
            Pix.ListView1.Items.Clear()
            LoadPix(Pix.ListView1)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Não Concluída", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub

    Private Sub Banco_Cbx_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Banco_Cbx.SelectedIndexChanged
        LoadBancos(Banco_Cbx, Banco_Pic)
    End Sub

    
    Private Sub Search()
        On Error Resume Next
        Banco_Cbx.Items.Clear()
        For i = 0 To CX_TEMP.Items.Count - 1

            If CX_TEMP.Items(i).Text.ToLower.Contains(Procurar_txb.Text.ToLower) Then
                Banco_Cbx.Items.Add(CX_TEMP.Items(i).Text)
            End If
        Next
        Banco_Cbx.SelectedIndex = 0
    End Sub

    Private Sub Procurar_txb_TextChanged(sender As System.Object, e As System.EventArgs) Handles Procurar_txb.TextChanged
        Call Search()
    End Sub

    Private Sub Chave_Pix_txt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Chave_Pix_txt.KeyPress
        If Chave_Tipo_Cbx.SelectedIndex = 0 Then
            MaskCelular_KeyPress(sender, e)
        ElseIf Chave_Tipo_Cbx.SelectedIndex = 2 Then
            MaskCPF_KeyPress(sender, e)
        ElseIf Chave_Tipo_Cbx.SelectedIndex = 3 Then
            MaskCNPJ_KeyPress(sender, e)
        End If
    End Sub

    Private Sub Adicionar_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Adicionar_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub

    Private Sub Close_btn_Click(sender As System.Object, e As System.EventArgs) Handles Close_btn.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Superior_Panel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Superior_Panel.MouseDown
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Superior_Panel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Superior_Panel.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub

    Private Sub Title_Label_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Title_Label.MouseDown
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Title_Label_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Title_Label.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub

    Private Sub Pix_Icon_Pic_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Pix_Icon_Pic.MouseDown
        Tools.MouseDown(sender, e)
    End Sub

    Private Sub Pix_Icon_Pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Pix_Icon_Pic.MouseMove
        Tools.MouseMove(sender, e, Me)
    End Sub
End Class