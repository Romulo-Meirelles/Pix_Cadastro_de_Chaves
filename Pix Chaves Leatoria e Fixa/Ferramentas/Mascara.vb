Module Mascara

    'INSIRA NA TEXBOX_keyPress

    Public Sub MaskApenasNumeros(Sender As Object, e As KeyPressEventArgs)
        Dim TeclaPressionada As String
        Dim UltimoChar As String
        TeclaPressionada = e.KeyChar
        If Sender.SelectionStart - 1 <> -1 Then
            UltimoChar = Sender.text.chars(Sender.SelectionStart - 1)
        Else
            UltimoChar = ""
        End If
        'Rejeitando teclas que sejam diferentes de BACKSPACE e que não sejam algum numero

        If (AscW(e.KeyChar) < 48 Or AscW(e.KeyChar) > 57) And (AscW(e.KeyChar) <> 8) Then
            e.Handled = True 'SUPRIMIR BEEP
            e.KeyChar = ""
        End If

    End Sub
    Public Sub MaskReal_ChangedText(CaixaTexBox As Object)
        On Error Resume Next
        Dim n As String = String.Empty
        Dim v As Double = 0
        n = CaixaTexBox.Text.Replace(",", "").Replace(".", "").Replace("R$", "")
        'If n.Equals("") Then
        '    n = "000"
        '    n = n.PadLeft(3, "0")
        'End If
        'If n.Length > 3 And n.Substring(0, 1) = "0" Then
        '    n = n.Substring(1, n.Length - 1)
        'End If
        v = Convert.ToDouble(n) / 100
        'CaixaTexBox.Text = String.Format("{0:N}", v)
        CaixaTexBox.Text = v.ToString("C")
        CaixaTexBox.SelectionStart = CaixaTexBox.Text.Length
        CaixaTexBox.e.Handled = True 'SUPRIMIR BEEP
    End Sub
    Public Sub MaskData_KeyPress(CaixaTexBox As Object, e As KeyPressEventArgs)

        If e.KeyChar = ChrW(Keys.Back) Then
            Return
        Else
            'APOS 3 LINHAS COLOCA PONTO NA 4 E COMEÇA NA 5
            If Len(CaixaTexBox.Text) = 2 Then
                CaixaTexBox.Text = CaixaTexBox.Text + "/"
                CaixaTexBox.SelectionStart = 4
            End If

            'APOS 7 LINHAS COLOCA PONTO NA 8 E COMEÇA NA 9
            If Len(CaixaTexBox.Text) = 5 Then
                CaixaTexBox.Text = CaixaTexBox.Text + "/"
                CaixaTexBox.SelectionStart = 7
            End If
        End If
    End Sub
    Public Sub MaskCelularPais_KeyPress(CaixaTexBox As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Back) Then
            Return
        Else
            'INSERE A +XX O PAIS
            If Len(CaixaTexBox.Text) = 1 Then
                CaixaTexBox.Text = "+" + CaixaTexBox.Text
                CaixaTexBox.SelectionStart = 3
            End If

            'INSERE 3 ALGORITIMO (021)
            If Len(CaixaTexBox.Text) = 3 Then
                CaixaTexBox.Text = CaixaTexBox.Text + " ("
                CaixaTexBox.SelectionStart = 9
            End If

            'INSERE 3 ALGORITIMO (021)
            If Len(CaixaTexBox.Text) = 8 Then
                CaixaTexBox.Text = CaixaTexBox.Text + ") "
                CaixaTexBox.SelectionStart = 11
            End If

            'INSERE INSERE O TRAÇO -
            If Len(CaixaTexBox.Text) = 15 Then
                CaixaTexBox.Text = CaixaTexBox.Text + "-"
                CaixaTexBox.SelectionStart = 17
            End If
        End If

    End Sub

    Public Sub MaskCelular_KeyPress(CaixaTexBox As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Back) Then
            Return
        Else
            
            'INSERE 3 ALGORITIMO (021)
            If Len(CaixaTexBox.Text) = 0 Then
                CaixaTexBox.Text = CaixaTexBox.Text + "("
                CaixaTexBox.SelectionStart = 3
            End If

            'INSERE 3 ALGORITIMO (021)
            If Len(CaixaTexBox.Text) = 3 Then
                CaixaTexBox.Text = CaixaTexBox.Text + ") "
                CaixaTexBox.SelectionStart = 10
            End If

            'INSERE INSERE O TRAÇO -
            If Len(CaixaTexBox.Text) = 9 Then
                CaixaTexBox.Text = CaixaTexBox.Text + "-"
                CaixaTexBox.SelectionStart = 11
            End If

            If Len(CaixaTexBox.Text) >= 14 Then
                e.Handled = True 'SUPRIMIR BEEP
                e.KeyChar = ""
            End If
        End If

    End Sub
    Public Sub MaskCPF_KeyPress(Sender As Object, e As KeyPressEventArgs)

        If e.KeyChar = ChrW(Keys.Back) Then
            Return
        Else
            'APOS 3 LINHAS COLOCA PONTO NA 4 E COMEÇA NA 5
            If Len(Sender.Text) = 3 Then
                Sender.Text = Sender.Text + "."
                Sender.SelectionStart = 5
            End If

            'APOS 7 LINHAS COLOCA PONTO NA 8 E COMEÇA NA 9
            If Len(Sender.Text) = 7 Then
                Sender.Text = Sender.Text + "."
                Sender.SelectionStart = 9
            End If

            'APOS 11 LINHAS COLOCA PONTO NA 12 E COMEÇA NA 13
            If Len(Sender.Text) = 11 Then
                Sender.Text = Sender.Text + "-"
                Sender.SelectionStart = 13
            End If

            If Len(Sender.Text) >= 14 Then
                e.Handled = True 'SUPRIMIR BEEP
                e.KeyChar = ""
            End If
        End If
    End Sub

    Public Sub MaskCNPJ_KeyPress(Sender As Object, e As KeyPressEventArgs)

        If e.KeyChar = ChrW(Keys.Back) Then
            Return
        Else
            'APOS 3 LINHAS COLOCA PONTO NA 4 E COMEÇA NA 5
            If Len(Sender.Text) = 2 Then
                Sender.Text = Sender.Text + "."
                Sender.SelectionStart = 4
            End If

            'APOS 7 LINHAS COLOCA PONTO NA 8 E COMEÇA NA 9
            If Len(Sender.Text) = 6 Then
                Sender.Text = Sender.Text + "."
                Sender.SelectionStart = 8
            End If

            'APOS 11 LINHAS COLOCA PONTO NA 12 E COMEÇA NA 13
            If Len(Sender.Text) = 10 Then
                Sender.Text = Sender.Text + "/"
                Sender.SelectionStart = 12
            End If

            'APOS 11 LINHAS COLOCA PONTO NA 12 E COMEÇA NA 13
            If Len(Sender.Text) = 15 Then
                Sender.Text = Sender.Text + "-"
                Sender.SelectionStart = 17
            End If

            If Len(Sender.Text) >= 18 Then
                e.Handled = True 'SUPRIMIR BEEP
                e.KeyChar = ""
            End If
        End If
    End Sub
End Module

