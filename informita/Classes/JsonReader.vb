
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Public Class JsonReader
    Protected Friend Function GetContents() As List(Of Json_Content)
        Dim jsonstring As String = IO.File.ReadAllText(HttpContext.Current.Server.MapPath("/media/document.json"), Encoding.UTF8)
        Dim Json_Response As Json_Response
        Json_Response = JsonConvert.DeserializeObject(Of Json_Response)(jsonstring)
        If Not IsNothing(Json_Response) Then
            Return Json_Response.Response.Content
        End If
    End Function


End Class
