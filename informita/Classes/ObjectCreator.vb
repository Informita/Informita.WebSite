Public Class ObjectCreator
    Protected Friend Property Content_Media_Control As Control
    Protected Friend Property Content_Text_Control As Control
    Public Property Content As informita.Json_Content
    Public Sub New(Content_ As informita.Json_Content)
        Content_Media_Control = Content_Media_Render(Content_.Media)
        Content_Text_Control = Content_Media_Render(Content_.Text)
        Content = Content_
    End Sub


    Public Function GetWholeControl() As Control
        Dim RadPageLayout As New Telerik.Web.UI.RadPageLayout
        Dim LayoutRow As New Telerik.Web.UI.LayoutRow
        Dim LayoutColumn_Content_Text, LayoutColumn_Content_Media As New Telerik.Web.UI.LayoutColumn
        RadPageLayout.Rows.Add(LayoutRow)
        LayoutRow.Columns.Add(LayoutColumn_Content_Media)
        LayoutRow.Columns.Add(LayoutColumn_Content_Text)
        Select Case Content.Type
            Case informita.Json_Content.E_Type.Orizzontal

                With LayoutColumn_Content_Media
                    .Span = 6
                    .SpanXl = 6
                    .SpanLg = 6
                    .SpanMd = 12
                    .SpanSm = 12
                    .SpanXs = 12
                End With
                With LayoutColumn_Content_Text
                    .Span = 6
                    .SpanXl = 6
                    .SpanLg = 6
                    .SpanMd = 12
                    .SpanSm = 12
                    .SpanXs = 12

                End With
            Case informita.Json_Content.E_Type.Vertical
                With LayoutColumn_Content_Media
                    .Span = 12
                    .SpanXl = 12
                    .SpanLg = 12
                    .SpanMd = 12
                    .SpanSm = 12
                    .SpanXs = 12
                End With
                With LayoutColumn_Content_Text
                    .Span = 12
                    .SpanXl = 12
                    .SpanLg = 12
                    .SpanMd = 12
                    .SpanSm = 12
                    .SpanXs = 12
                End With
        End Select
        LayoutColumn_Content_Text.Controls.Add(Content_Text_Control)
        LayoutColumn_Content_Media.Controls.Add(Content_Media_Control)
        Return RadPageLayout
    End Function
    Protected Friend Function Content_Media_Render(Content_Media As informita.Json_Content_Media) As Control
        Select Case Content_Media.Type
            Case Json_Content_Media.E_Type.Image
                Dim Image As New Image
                With Image
                    .ImageUrl = Content_Media.Source
                    .Width = Unit.Percentage(100)
                End With
                Return Image
            Case Json_Content_Media.E_Type.Youtube
                Dim RadMediaPlayer As New Telerik.Web.UI.RadMediaPlayer
                With RadMediaPlayer
                    .CssClass = "RadMediaPlayer"
                    .Source = Content_Media.Source
                    .RenderMode = Telerik.Web.UI.RenderMode.Lightweight
                    .Width = Unit.Percentage(100)
                    .Height = Unit.Pixel(360)
                End With
                Return RadMediaPlayer
        End Select

    End Function
    Protected Friend Function Content_Media_Render(Content_Text As informita.Json_Content_Text) As Control
        Dim lblTitle As New Label With {.CssClass = "Content_Title", .Text = Content_Text.Title}
        Dim lblDescription As New Label With {.CssClass = "Content_Description", .Text = Content_Text.Description}
        Dim lblText As New Label With {.CssClass = "Content_Text", .Text = Content_Text.Text}

        Dim RadPageLayout As New Telerik.Web.UI.RadPageLayout With {.CssClass = "RadPageLayout_ContentList"}
        Dim LayoutRow As New Telerik.Web.UI.LayoutRow

        Dim LayoutColumn_Title As New Telerik.Web.UI.LayoutColumn
        With LayoutColumn_Title
            .Controls.Add(lblTitle)
        End With

        Dim LayoutColumn_Description As New Telerik.Web.UI.LayoutColumn
        With LayoutColumn_Description
            .Controls.Add(lblDescription)
        End With
        Dim LayoutColumn_Text As New Telerik.Web.UI.LayoutColumn
        With LayoutColumn_Text
            .Controls.Add(lblText)
        End With
        RadPageLayout.Rows.Add(LayoutRow)
        With LayoutRow.Columns
            .Add(LayoutColumn_Title)
            .Add(LayoutColumn_Description)
            .Add(LayoutColumn_Text)

        End With
        Return RadPageLayout

    End Function



End Class
