Imports System.IO

Module ConvertToImage
    Public Function ConvertImageToBase64String(ByVal Picture As PictureBox) As String
        Using ms As New MemoryStream()
            Picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png) 'We load the image from first PictureBox in the MemoryStream
            Dim obyte = ms.ToArray() 'We tranform it to byte array..
            Return Convert.ToBase64String(obyte) 'We then convert the byte array to base 64 string.
        End Using
    End Function

    'Here's the part of your code (which works)
    Public Function Base64ToImage(ByVal Base64 As String) As Image
        Dim B As Byte() = Convert.FromBase64String(Base64)
        Dim ms As MemoryStream = New MemoryStream(B)
        Dim image = System.Drawing.Image.FromStream(ms)
        Return image
    End Function
End Module
