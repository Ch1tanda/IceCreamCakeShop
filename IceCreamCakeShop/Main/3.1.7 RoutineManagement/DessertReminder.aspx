<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DessertReminder.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._7_RoutineManagement.DessertReminder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server">

        <asp:Label ID="Label1" runat="server"></asp:Label>

        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="mid" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="mid" HeaderText="点心id" ReadOnly="True" SortExpression="mid" />
                <asp:BoundField DataField="name" HeaderText="点心名称" SortExpression="name" />
                <asp:TemplateField HeaderText="补货">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("mid") %>' CommandName="add" Text="制作5份" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IceCream_Cake_ShopConnectionString %>" SelectCommand="SELECT mid, name FROM Stock WHERE (mid LIKE '%d%') AND (stock &lt; 5)"></asp:SqlDataSource>

    </div>
</asp:Content>
