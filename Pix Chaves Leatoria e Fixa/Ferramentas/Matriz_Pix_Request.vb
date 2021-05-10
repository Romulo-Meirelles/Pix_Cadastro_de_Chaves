Imports Newtonsoft.Json
Imports Newtonsoft
Module Matriz_Pix_Request

    Private ReadOnly JsonPix As String = "{""key_type"":""ChaveTipo"",""key"":""SuaChave"",""name"":""SeuNome"",""city"":""SuaCidade"",""amount"":""SeuValor"",""reference"":""SeuCodigo""}"
    Private ReadOnly SiteAPI As String = "https://www.gerarpix.com.br/emvqr-static"


  

    Public Function GerarPix(ByVal TIP As String, ByVal CHA As String, ByVal VAL As String, ByVal NOM As String, ByVal CID As String, ByVal COD As String)

        Dim Produce As String = JsonPix.Replace("ChaveTipo", TIP).Replace("SuaChave", CHA).Replace("SeuValor", VAL).Replace("SeuNome", NOM).Replace("SuaCidade", CID).Replace("SeuCodigo", COD)
        Dim Json As String = APIREQUEST(SiteAPI, Produce)
        Return Json

    End Function



End Module
