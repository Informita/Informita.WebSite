<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="informita.index"  Theme="informita" MasterPageFile="~/base.Master"%>

<%--<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder_TabStripMenu">

</asp:Content>--%>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder_Content" runat="server">
    <telerik:RadPageLayout runat="server">
        <Rows>
            <telerik:LayoutRow>
                <Columns>
                     <telerik:LayoutColumn HiddenXs="true" HiddenSm="true" Height="170px">
                                                        </telerik:LayoutColumn>
                    <telerik:LayoutColumn HiddenMd="True" HiddenSm="True" HiddenXs="True">
                        <telerik:RadTabStrip runat="server" ID="RadTabStrip_" MultiPageID="RadMultiPage_" RenderMode="Lightweight"   Align="Right"  Skin="" CssClass="Telerik_RadTabStrip">
                        </telerik:RadTabStrip>
                        <telerik:RadMultiPage runat="server" ID="RadMultiPage_" SelectedIndex="0" >
                        </telerik:RadMultiPage>

                    </telerik:LayoutColumn>
                    
                    <telerik:LayoutColumn runat="server" ID="LayoutColumn" HiddenXl="True" HiddenLg="True">
                        
                    </telerik:LayoutColumn>
                </Columns>
            </telerik:LayoutRow>
        </Rows>
    </telerik:RadPageLayout>



</asp:Content>