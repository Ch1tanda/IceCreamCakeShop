<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SupplierInfoManagement.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._1_InfoManagement.SupplierInfoManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server">

        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="LinqDataSource1" Width="564px">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="供应商名称" SortExpression="name" />
                <asp:BoundField DataField="tel" HeaderText="联系电话" SortExpression="tel" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="IceCreamCakeShop.DataClasses1DataContext" EnableUpdate="True" EntityTypeName="" TableName="Supplierinfo">
        </asp:LinqDataSource>

        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加供应商" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="删除/修改" />

    </div>
</asp:Content>
