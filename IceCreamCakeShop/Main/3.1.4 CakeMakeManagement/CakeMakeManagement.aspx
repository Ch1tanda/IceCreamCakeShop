<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CakeMakeManagement.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._4_CakeMakeManagement.CakeMakeManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="按名称搜索："></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <br />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal" RepeatLayout="Flow">
        <asp:ListItem Selected="True" Value="0">全选</asp:ListItem>
        <asp:ListItem Value="C">蛋糕</asp:ListItem>
        <asp:ListItem Value="D">点心</asp:ListItem>
    </asp:RadioButtonList>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server">

        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="LinqDataSource1" ForeColor="#333333" GridLines="None" Width="816px" OnRowCommand="GridView1_RowCommand" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="名称" SortExpression="name" />
                <asp:BoundField DataField="price" HeaderText="单价" SortExpression="price" />
                <asp:BoundField DataField="recipe" HeaderText="配方" SortExpression="recipe" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("id") %>' CommandName="edit" Text="编辑" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="增加" Width="325px" />
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="IceCreamCakeShop.DataClasses1DataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="Cakeinfo">
        </asp:LinqDataSource>

    </div>
</asp:Content>
