Imports ToolsBox.Utils
Public Class Adicionar_Conta

    Private CX_TEMP As ListView = New ListView
    Private CODEBANK As ListView = New ListView
    Public ListImage As New ImageList
    Dim LOCAT As Point
    Public ID As Integer

    Private Sub Adicionar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaBordas(Adicionar_btn, 5)
        CarregaBordas(Add_Bancos_btn, 5)
        CarregaBordas(Editar_Conta_btn, 5)
        CarregaBordas(Banco_Pic)
        CarregaBordas(Me)

        CODEBANK = AdicionarContasLoad(Banco_Cbx, ListImage)

        For i = 0 To Banco_Cbx.Items.Count - 1
            CX_TEMP.Items.Add(Banco_Cbx.Items(i))
        Next

        Call Search()

    End Sub
    Private Sub Adicionar_btn_Click(sender As System.Object, e As System.EventArgs) Handles Adicionar_btn.Click
        Try
            If Banco_Cbx.SelectedItem = "" Then
                MensagemBox("Não existe banco cadastrado! Para incluir clique no botão 'Add Bancos'.", MessageNumber.Exclamation_, "Mensagem.")
                Exit Sub
            End If
            If Nome_txb.Text = "" Then
                MensagemBox("Preencha o campo com nome!", MessageNumber.Exclamation_, "Mensagem.")
                Exit Sub
            End If
            If Chave_Pix_txt.Text = "" Then
                MensagemBox("Preencha a sua chave Pix!", MessageNumber.Exclamation_, "Mensagem.")
                Exit Sub
            End If


            If Chave_Tipo_Cbx.SelectedIndex = 1 Then
                If Not Chave_Pix_txt.Text.Contains("@") Then
                    MensagemBox("Preencha o E-Mail corretamente!", MessageNumber.Exclamation_, "Mensagem.")
                    Exit Sub
                End If
                Chave_Pix_txt.Text = Chave_Pix_txt.Text.ToLower
            End If

            'BANCO
            'NOME
            'CHAVE
            'CODIGO_BANCO
            'AGENCIA
            'CONTA
            'OPERACAO
            'TIPO CONTA
            Insert({Banco_Cbx.SelectedItem.ToString, Nome_txb.Text, Chave_Pix_txt.Text, Chave_Tipo_Cbx.SelectedItem, Codigo_Banco_txt.Text, Agencia_txt.Text, Conta_txt.Text, Operacao_txt.Text, Tipo_Conta_cbx.SelectedItem})
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub
    Private Sub Banco_Cbx_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Banco_Cbx.SelectedIndexChanged
        Try
            Dim Int As Integer = ListImage.Images.IndexOfKey(Banco_Cbx.SelectedItem.ToString)
            Banco_Pic.Image = ListImage.Images.Item(Int)
            Codigo_Banco_txt.Text = CODEBANK.FindItemWithText(Banco_Cbx.SelectedItem.ToString).SubItems(2).Text
        Catch ex As Exception
            MensagemBox("Error!", ex.Message, MessageNumber.Error_)
        End Try
    End Sub
    Public Sub Search()
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
            MaskApenasNumeros(sender, e)
            MaskCelular_KeyPress(sender, e)
        ElseIf Chave_Tipo_Cbx.SelectedIndex = 2 Then
            MaskApenasNumeros(sender, e)
            MaskCPF_KeyPress(sender, e)
        ElseIf Chave_Tipo_Cbx.SelectedIndex = 3 Then
            MaskApenasNumeros(sender, e)
            MaskCNPJ_KeyPress(sender, e)
        End If
    End Sub
    Private Change As Boolean = False
    Private Sub Chave_Tipo_Cbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Chave_Tipo_Cbx.SelectedIndexChanged
        If Change = False Then Change = True Else Chave_Pix_txt.Clear()
    End Sub
    Private Sub Close_btn_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Close()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub Adicionar_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        MouseMoveUnick(sender, e, Me)
    End Sub
    Private Sub Superior_Panel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        MouseMoveUnick(sender, e, Me)
    End Sub
    Private Sub Title_Label_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        MouseMoveUnick(sender, e, Me)
    End Sub
    Private Sub Pix_Icon_Pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        MouseMoveUnick(sender, e, Me)
    End Sub
    Private Sub Add_Bancos_btn_Click(sender As Object, e As EventArgs) Handles Add_Bancos_btn.Click
        Try
            Dim AddBancos As New Bancos_Add
            AddBancos.ShowDialog()
            Call AdicionarContasLoad(Banco_Cbx, ListImage)
            CX_TEMP.Items.Clear()

            For i = 0 To Banco_Cbx.Items.Count - 1
                CX_TEMP.Items.Add(Banco_Cbx.Items(i))
            Next
            Call Search()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Private Sub Editar_Conta_btn_Click(sender As Object, e As EventArgs) Handles Editar_Conta_btn.Click
        Try

            If Banco_Cbx.SelectedItem = "" Then
                MensagemBox("Preencha com o banco!", MessageNumber.Exclamation_, "Banco.")
                Exit Sub
            ElseIf Nome_txb.Text = "" Then
                MensagemBox("Preencha com o nome!", MessageNumber.Exclamation_, "Nome.")
                Exit Sub
            ElseIf Chave_Tipo_Cbx.SelectedItem = "" Then
                MensagemBox("Preencha com o tipo de chave!", MessageNumber.Exclamation_, "Tipo de Chave.")
                Exit Sub
            ElseIf Chave_Pix_txt.Text = "" Then
                MensagemBox("Preencha com a chave!", MessageNumber.Exclamation_, "Chave.")
                Exit Sub
            End If

            If MensagemBox("Deseja realmente alterar o registro?", MessageNumber.YesOrNo_, "Atualização.") = Windows.Forms.DialogResult.Yes Then
                If UpdateConta(ID, {Banco_Cbx.SelectedItem, Nome_txb.Text, Chave_Pix_txt.Text, Chave_Tipo_Cbx.SelectedItem, Codigo_Banco_txt.Text, Agencia_txt.Text, Conta_txt.Text, Operacao_txt.Text, Tipo_Conta_cbx.SelectedItem}) = True Then
                    MensagemBox("Atualizado com sucesso!", MessageNumber.Ok_, "Atualização.")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MensagemBox("Não foi possível atualizar!", MessageNumber.Error_, "Atualização!")
                End If
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub


End Class