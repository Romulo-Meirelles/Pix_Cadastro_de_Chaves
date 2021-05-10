Imports System.Net
Imports System.Text
Imports System.IO

Module API_Request
    <STAThread()>
    Friend Function APIREQUEST(ByVal URL As String, ByVal PARAMETRO As String) As String

        Try
            'ABAIXO COMEÇA A FUNCÃO DO POST PARA O SITE DE PAGAMENTO. FAUCETHUB.COM
            'Dim Resposta As String
            Dim logincookie As CookieContainer
            Dim tempCookies As New CookieContainer
            Dim encoding As New UTF8Encoding

            'O QUE SERÁ ENVIADO PARA OBTER UMA RESPOSTA
            Dim byteData As Byte() = encoding.GetBytes(PARAMETRO)
            Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create(URL), HttpWebRequest)
            postReq.Method = "POST"
            postReq.KeepAlive = True
            postReq.CookieContainer = tempCookies
            postReq.ContentType = "application/json; charset=UTF-8"
            postReq.Referer = URL
            postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)"
            postReq.ContentLength = byteData.Length
            Dim postreqstream As Stream = postReq.GetRequestStream()
            postreqstream.Write(byteData, 0, byteData.Length)
            postreqstream.Close()
            Dim postresponse As HttpWebResponse
            postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
            tempCookies.Add(postresponse.Cookies)
            logincookie = tempCookies
            Dim postreqreader As New StreamReader(postresponse.GetResponseStream())
            APIREQUEST = postreqreader.ReadToEnd

        Catch ex As Exception
            'CASO TENHA ALGUM ERRO RETORNA O NOME DO ERRO
            APIREQUEST = ex.ToString

        End Try

        Return APIREQUEST.ToString
    End Function


    Public Class Post

        Enum Method
            POST_
            GET_
            HEAD_
            PUT_
            DELETE_
            CONNECT_
            OPTIONS_
            TRACE_
            PATCH_
        End Enum

        Enum Secure
            SSL3
            TLS
            TLS11
            TLS12
            Unsecure
        End Enum

        Public Function SEND(ByRef URL As String, ByVal Post As String, Optional ByVal Method As Method = Method.POST_, Optional ByVal Secure As Secure = Secure.TLS12) As String

            'FAZ O SERVIÇO FICAR SEGURO CRIPTOGRAFADO
            Select Case Secure
                Case API_Request.Post.Secure.SSL3
                    ServicePointManager.SecurityProtocol = DirectCast(48, SecurityProtocolType)
                Case API_Request.Post.Secure.TLS
                    ServicePointManager.SecurityProtocol = DirectCast(192, SecurityProtocolType)
                Case API_Request.Post.Secure.TLS11
                    ServicePointManager.SecurityProtocol = DirectCast(768, SecurityProtocolType)
                Case API_Request.Post.Secure.TLS12
                    ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)
                Case API_Request.Post.Secure.Unsecure

            End Select


            Try
                Dim REQUESTWEB As HttpWebRequest = DirectCast(HttpWebRequest.Create(URL), HttpWebRequest)
                Dim TempCookies As New CookieContainer
                Dim Encoding_UTF8() As Byte = Encoding.UTF8.GetBytes(Post)
                Dim DataStream As Stream
                Dim Response As WebResponse
                Dim Reader As StreamReader
                Dim ResponseFromServer As String = Nothing

                With REQUESTWEB

                    Select Case Method
                        Case API_Request.Post.Method.POST_
                            .Method = "POST"
                        Case API_Request.Post.Method.GET_
                            .Method = "GET"
                        Case API_Request.Post.Method.HEAD_
                            .Method = "HEAD"
                        Case API_Request.Post.Method.PUT_
                            .Method = "PUT"
                        Case API_Request.Post.Method.DELETE_
                            .Method = "DELETE"
                        Case API_Request.Post.Method.CONNECT_
                            .Method = "CONNECT"
                        Case API_Request.Post.Method.OPTIONS_
                            .Method = "OPTIONS"
                        Case API_Request.Post.Method.TRACE_
                            .Method = "TRACE"
                        Case API_Request.Post.Method.PATCH_
                            .Method = "PATCH"
                    End Select

                    .ContentType = "application/x-www-form-urlencoded"
                    .UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:64.0) Gecko/20100101 Firefox/64.0"
                    .KeepAlive = True
                    .CookieContainer = TempCookies
                    .ContentLength = Encoding_UTF8.Length
                    DataStream = .GetRequestStream
                    DataStream.Write(Encoding_UTF8, 0, Encoding_UTF8.Length)
                    DataStream.Close()

                    Response = .GetResponse
                    DataStream = Response.GetResponseStream()

                    Reader = New StreamReader(DataStream)
                    ResponseFromServer = Reader.ReadToEnd()
                    Reader.Close()
                    DataStream.Close()
                    Response.Close()
                    Return ResponseFromServer
                End With

            Catch ex As Exception
                Return ex.Message
            End Try
        End Function

    End Class

End Module
