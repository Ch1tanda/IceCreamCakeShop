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
                <td style="width: 421px; float: left; clip: rect(0px, auto, auto, auto);">
                    <asp:Label ID="Label3" runat="server" Text="原料库存"></asp:Label>
                </td>
                <td style="text-align: left; float: left;">
                    <asp:Label ID="Label4" runat="server" Text="点心库存"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="float: left; clip: rect(0px, auto, auto, auto); width: 421px; height: 357px;">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="mid" DataSourceID="LinqDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-right: 0px" Width="417px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                        <Columns>
                            <asp:CommandField EditText="进/退货" ShowEditButton="True" UpdateText="保存" />
                            <asp:BoundField DataField="mid" HeaderText="编号" ReadOnly="True" SortExpression="mid" />
                            <asp:BoundField DataField="name" HeaderText="原料" SortExpression="name" />
                            <asp:BoundField DataField="stock" HeaderText="库存" SortExpression="stock" />
                        </Columns>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                    </td>
                <td style="float: left; clip: rect(auto, 100px, auto, 100px); height: 357px;">
                    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="IceCreamCakeShop.DataClasses1DataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="Stock">
                    </asp:LinqDataSource>
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="mid" DataSourceID="SqlDataSource2" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="241px">
                        <Columns>
                            <asp:BoundField DataField="mid" HeaderText="点心id" ReadOnly="True" SortExpression="mid" />
                            <asp:BoundField DataField="name" HeaderText="名称" SortExpression="name" />
                            <asp:BoundField DataField="stock" HeaderText="库存" SortExpression="stock" />
                        </Columns>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
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
