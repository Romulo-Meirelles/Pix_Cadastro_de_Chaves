Imports ZXing
Imports ZXing.Rendering
Imports ZXing.QrCode.Internal
Imports ZXing.Common
Imports System.IO
Imports ToolsBox

Public Module Tools
    Dim LOCAT As Point
    Private Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer



    Public Enum LOGOS
        PIX
        BTC
        LTC
        ETH
        DOGE
    End Enum
    Friend Function GerarQRPicture(ByVal StringToQR As String, Optional ByRef Logo As LOGOS = LOGOS.PIX) As Bitmap
        Dim BMP As Bitmap = Nothing

        Select Case Logo
            Case Tools.LOGOS.PIX
                BMP = New Bitmap(My.Resources.Pix_64x64)
            Case Tools.LOGOS.BTC
                BMP = New Bitmap(My.Resources.BTC_64x64)
            Case Tools.LOGOS.LTC
                BMP = New Bitmap(My.Resources.LTC_64x64)
            Case Tools.LOGOS.ETH
                BMP = New Bitmap(My.Resources.Ethereum_64x64)
            Case Tools.LOGOS.DOGE
                BMP = New Bitmap(My.Resources.DogeCoin_64x64)
        End Select


        Dim barcodeWriter As BarcodeWriter = New BarcodeWriter()
        Dim EncodingOptions As EncodingOptions = New EncodingOptions() With {
            .Width = 500,
            .Height = 500,
            .Margin = 0,
            .PureBarcode = True
        }
        EncodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H)
        barcodeWriter.Renderer = New BitmapRenderer With {
        .Background = Color.White,
        .Foreground = Color.FromArgb(8, 12, 23)
            }
        barcodeWriter.Options = EncodingOptions
        barcodeWriter.Format = BarcodeFormat.QR_CODE
        Dim MyBitmap As Bitmap = barcodeWriter.Write(StringToQR)
        Dim g As Graphics = Graphics.FromImage(MyBitmap)
        g.DrawImage(BMP, New Point((MyBitmap.Width - BMP.Width) / 2, (MyBitmap.Height - BMP.Height) / 2))
        Return MyBitmap
    End Function

    'DECLARAÇÃO REGIONHANDLE PARA BORDAS
    Private regionHandle As IntPtr

    'FUNÇÃO QUE CRIA BORDAS NOS OBJETOS, MODIFIQUE O 20, 20 PARA O TAMANHO DAS BORDAS.
    Friend Sub CarregaBordas(ByVal Componente As Object, Optional ByRef Size As Integer = 10)
        regionHandle = New IntPtr(CreateRoundRectRgn(0, 0, Componente.Width, Componente.Height, Size, Size))
        Componente.Region = Region.FromHrgn(regionHandle)
        Componente.Region.ReleaseHrgn(regionHandle)
    End Sub

    Friend Function ConvertImageToBase64String(ByVal Picture As PictureBox) As String
        Using ms As New MemoryStream()
            Picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png) 'We load the image from first PictureBox in the MemoryStream
            Dim obyte = ms.ToArray() 'We tranform it to byte array..
            Return Convert.ToBase64String(obyte) 'We then convert the byte array to base 64 string.
        End Using
    End Function

    'Here's the part of your code (which works)
    Friend Function Base64ToImage(ByVal Base64 As String) As Image
        Dim B As Byte() = Convert.FromBase64String(Base64)
        Dim ms As MemoryStream = New MemoryStream(B)
        Dim image = System.Drawing.Image.FromStream(ms)
        Return image
    End Function

    Friend Sub MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub
    Friend Sub MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs, ByVal Form As Form)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Form.Location += e.Location - LOCAT
        End If
    End Sub
End Module
