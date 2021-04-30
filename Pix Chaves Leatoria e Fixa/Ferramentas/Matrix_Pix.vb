Module Matrix_Pix

    Public Function GerarPix(ByRef ChavePix As String, ByVal Valor As String, ByVal Nome As String, ByVal Cidade As String, ByVal Pagamento As String) As String
        Dim PIX As String = "00020126600014BR.GOV.BCB.PIX0138" & ChavePix & "5204000053039865404" & Valor & "5802BR5916" & Nome & "6014" & Cidade & "62160512" & Pagamento & ""
        Return PIX
    End Function
End Module
