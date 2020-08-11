<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserInfoManagement.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._1_InfoManagement.UserInfoManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="LinqDataSource1" Width="795px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="username" HeaderText="用户姓名" SortExpression="username" />
                <asp:BoundField DataField="phonenumber" HeaderText="手机号" SortExpression="phonenumber" />
                <asp:BoundField DataField="address" HeaderText="地址" SortExpression="address" />
                <asp:BoundField DataField="birthday" HeaderText="生日" SortExpression="birthday" />
                <asp:BoundField DataField="viptype" HeaderText="会员等级" SortExpression="viptype" />
                <asp:BoundField DataField="gmv" HeaderText="总消费金额" SortExpression="gmv" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="IceCreamCakeShop.DataClasses1DataContext" EntityTypeName="" TableName="Userinfo">
        </asp:LinqDataSource>

    </div>
</asp:Content>
