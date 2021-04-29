Module Form_Move
    Dim LOCAT As Point

    Public Sub MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub


    Public Sub MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Pix.Location += e.Location - LOCAT
        End If
    End Sub
End Module
