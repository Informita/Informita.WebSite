<Serializable>
Public Class Json_Response
    Public Property Response As Json_Responses
End Class
Public Class Json_Responses
    Public Property id As String
    Public Property Content As List(Of Json_Content)
End Class


Public Class Json_Content
    Enum E_Type
        Orizzontal = 0
        Vertical = 1
    End Enum
    Public Property Text As Json_Content_Text
    Public Property Media As Json_Content_Media

    Public Property Type As E_Type
End Class
Public Class Json_Content_Text
    Public Property Title As String
    Public Property Description As String
    Public Property Text As String
End Class

Public Class Json_Content_Media
    Enum E_Type As Byte
        Null = 0
        Image = 1
        Youtube = 2

    End Enum

    Public Property Source As String
    Public Property Type As E_Type
End Class
