<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="OrderSearch.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._8_UserMain.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="用户订单查询"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="userid" HeaderText="userid" ReadOnly="True" SortExpression="userid" />
            <asp:BoundField DataField="cdid" HeaderText="cdid" ReadOnly="True" SortExpression="cdid" />
            <asp:BoundField DataField="number" HeaderText="number" ReadOnly="True" SortExpression="number" />
            <asp:BoundField DataField="price" HeaderText="price" ReadOnly="True" SortExpression="price" />
            <asp:BoundField DataField="time" HeaderText="time" ReadOnly="True" SortExpression="time" />
        </Columns>
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="IceCreamCakeShop.DataClasses1DataContext" EntityTypeName="" OrderBy="time desc" Select="new (id, userid, cdid, number, price, time)" TableName="Userorder">
    </asp:LinqDataSource>
    <br />
</asp:Content>
