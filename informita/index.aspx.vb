Public Class index
    Inherits System.Web.UI.Page
    Protected Content_Text As informita.Json_Content_Text
    Protected Content_Media As informita.Json_Content_Media
    Protected Content_List As List(Of informita.Json_Content)
    Private Sub index_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Render_()
        End If
    End Sub
    Protected Sub Render_()
        'Dim RadPageLayout As New Telerik.Web.UI.RadPageLayout
        'Dim LayoutRow_Menu As New Telerik.Web.UI.LayoutRow
        'RadPageLayout.Rows.Add(LayoutRow_Menu)
        'Dim RadNavigation As Telerik.Web.UI.RadNavigation = Page.Master.FindControl("RadNavigation")
        'Dim NodeMenu As Telerik.Web.UI.NavigationNode = RadNavigation.FindNodeByText("Menu")


        For Each Content As informita.Json_Content In Framework.Content_List
            LayoutColumn.Controls.Add(New informita.ObjectCreator(Content).GetWholeControl)
            Dim RadTab As New Telerik.Web.UI.RadTab
            With RadTab
                .BorderStyle = BorderStyle.None
                .CssClass = "RadTab_CssClass"
                .HoveredCssClass = "RadTab_HoveredCssClass"
                .SelectedCssClass = "RadTab_SelectedCssClass"
                .Text = Content.Text.Title
            End With
            RadTabStrip_.Tabs.Add(RadTab)
            Dim RadPageView As New Telerik.Web.UI.RadPageView
            With RadPageView
                .CssClass = "RadPageView"
                .Controls.Add(New informita.ObjectCreator(Content).GetWholeControl)
            End With
            RadMultiPage_.PageViews.Add(RadPageView)
            Dim HyperLink As New HyperLink
            With HyperLink
                .Text = Content.Text.Title
                .NavigateUrl = ""
            End With


            'Dim LayoutColumn_Menu As New Telerik.Web.UI.LayoutColumn
            'LayoutColumn_Menu.Controls.Add(HyperLink)
            'LayoutRow_Menu.Columns.Add(LayoutColumn_Menu)


        Next
        'NodeMenu.ContentTemplate = GetTemplate(RadPageLayout)

    End Sub

    Private Function GetContent_Text(Title As String, Description As String, FileStream As String) As informita.Json_Content_Text
        Dim Content_Text As New informita.Json_Content_Text
        With Content_Text
            .Title = Title
            .Description = Description
        End With
        Return Content_Text
    End Function
    Private Function GetContent_Media(Source As String, Type As informita.Json_Content_Media.E_Type) As informita.Json_Content_Media
        Dim Content_Media As New informita.Json_Content_Media
        With Content_Media
            .Source = Source
            .Type = Type
        End With
        Return Content_Media
    End Function
    Protected Friend Function GetTemplate(Control) As ITemplate
        Return New template(Control)
    End Function
End Class