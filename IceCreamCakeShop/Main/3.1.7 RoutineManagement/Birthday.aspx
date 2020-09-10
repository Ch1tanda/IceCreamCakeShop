<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Birthday.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._7_RoutineManagement.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="username" HeaderText="username" ReadOnly="True" SortExpression="username" />
            <asp:BoundField DataField="phonenumber" HeaderText="phonenumber" ReadOnly="True" SortExpression="phonenumber" />
        </Columns>
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="IceCreamCakeShop.DataClasses1DataContext" EntityTypeName="" Select="new (id, username, phonenumber)" TableName="Userinfo">
    </asp:LinqDataSource>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    </asp:Content>
