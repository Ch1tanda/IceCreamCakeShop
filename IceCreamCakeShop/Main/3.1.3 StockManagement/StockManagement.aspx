<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockManagement.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._3_StockManagement.StockManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server">

        <asp:Label ID="Label2" runat="server" Font-Size="Larger" Text="库存管理"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Tip" runat="server" Text="提醒：" Visible="False"></asp:Label>
        <asp:Label ID="contain" runat="server" Text="Label" Visible="False"></asp:Label>
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
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="mid" DataSourceID="LinqDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-right: 0px" Width="317px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField EditText="进/退货" ShowEditButton="True" UpdateText="保存" />
                            <asp:BoundField DataField="mid" HeaderText="编号" ReadOnly="True" SortExpression="mid" />
                            <asp:BoundField DataField="name" HeaderText="原料" SortExpression="name" />
                            <asp:BoundField DataField="stock" HeaderText="库存" SortExpression="stock" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>
                    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="IceCreamCakeShop.DataClasses1DataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="Stock">
                    </asp:LinqDataSource>
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="mid" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField DataField="mid" HeaderText="点心id" ReadOnly="True" SortExpression="mid" />
                            <asp:BoundField DataField="name" HeaderText="名称" SortExpression="name" />
                            <asp:BoundField DataField="stock" HeaderText="库存" SortExpression="stock" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IceCream_Cake_ShopConnectionString %>" SelectCommand="SELECT Stock.* FROM Stock WHERE (mid LIKE '%d%')"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IceCream_Cake_ShopConnectionString %>" SelectCommand="SELECT mid, name, stock FROM Stock WHERE (mid LIKE '%m%')"></asp:SqlDataSource>

        <br />

    </div>
</asp:Content>
