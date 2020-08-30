<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CakeReserve.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._4_CakeMakeManagement.CakerReserve" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>

        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="订单id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="userid" HeaderText="用户id" SortExpression="userid" />
                <asp:BoundField DataField="cdid" HeaderText="蛋糕id" SortExpression="cdid" />
                <asp:BoundField DataField="number" HeaderText="蛋糕数量" SortExpression="number" />
                <asp:BoundField DataField="price" HeaderText="总价格" SortExpression="price" />
                <asp:BoundField DataField="username" HeaderText="用户姓名" SortExpression="username" />
                <asp:BoundField DataField="address" HeaderText="用户地址" SortExpression="address" />
                <asp:BoundField DataField="time" HeaderText="预定时间" SortExpression="time" />
                <asp:BoundField DataField="phonenumber" HeaderText="用户电话" SortExpression="phonenumber" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IceCream_Cake_ShopConnectionString %>" SelectCommand="SELECT Userorder.id, Userorder.userid, Userorder.cdid, Userorder.number, Userorder.number * Cakeinfo.price AS price, Userorder.time, Userinfo.address, Userinfo.username, Userinfo.phonenumber FROM Userorder INNER JOIN Userinfo ON Userorder.userid = Userinfo.id INNER JOIN Cakeinfo ON Userorder.cdid = Cakeinfo.id AND Userorder.cdid = Cakeinfo.id"></asp:SqlDataSource>

    </div>
</asp:Content>
