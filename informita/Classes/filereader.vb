Imports System.IO

Public Class filereader

    Public Function Read(FileName As String) As String
        Dim FilePath As String = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings("text") & FileName)
        Try
            Dim text As String
            Dim sr As StreamReader = New StreamReader(FilePath)
            text = sr.ReadToEnd
            sr.Close()
            Return text
        Catch
            Return ""
        End Try
    End Function
End Class

