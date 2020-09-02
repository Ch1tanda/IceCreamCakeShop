<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockManagement.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._3_StockManagement.StockManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server">

        <asp:Label ID="Label2" runat="server" Font-Size="Larger" Text="库存管理"></asp:Label>
        <br />
        <table style="width: 100%">
            <tr>
                <td style="width: 334px; float: left; clip: rect(0px, auto, auto, auto);">
                    <asp:Label ID="Label3" runat="server" Text="原料库存"></asp:Label>
                </td>
                <td style="text-align: left; float: left;">
                    <asp:Label ID="Label4" runat="server" Text="点心库存"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="float: left; clip: rect(0px, auto, auto, auto); width: 334px;">
                    &nbsp;</td>
                <td style="float: left; clip: rect(auto, 100px, auto, 100px);">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="mid" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-right: 0px" Width="317px">
                        <Columns>
                            <asp:BoundField DataField="mid" HeaderText="原料id" ReadOnly="True" SortExpression="mid" />
                            <asp:BoundField DataField="name" HeaderText="名称" SortExpression="name" />
                            <asp:BoundField DataField="stock" HeaderText="库存" SortExpression="stock" />
                            <asp:ButtonField ButtonType="Button" CommandName="Update" Text="进货" />
                            <asp:ButtonField ButtonType="Button" CommandName="Update" Text="退货" />
                        </Columns>
                    </asp:GridView>
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="mid" DataSourceID="SqlDataSource2">
                        <Columns>
                            <asp:BoundField DataField="mid" HeaderText="点心id" ReadOnly="True" SortExpression="mid" />
                            <asp:BoundField DataField="name" HeaderText="名称" SortExpression="name" />
                            <asp:BoundField DataField="stock" HeaderText="库存" SortExpression="stock" />
                        </Columns>
                    </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IceCream_Cake_ShopConnectionString %>" SelectCommand="SELECT Stock.* FROM Stock WHERE (mid LIKE '%d%')"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IceCream_Cake_ShopConnectionString %>" SelectCommand="SELECT mid, name, stock FROM Stock WHERE (mid LIKE '%m%')"></asp:SqlDataSource>

    </div>
</asp:Content>
