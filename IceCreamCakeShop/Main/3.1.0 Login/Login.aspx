<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._0_Login.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:800px">
        <h2 style="text-align:right">登录</h2>
    </div>
    <div class="MessageBorder">
        <div class="MessageBorderLeft">
            <asp:Label ID="Label2" runat="server" Text="手机号：" Font-Overline="False" Font-Size="14pt"></asp:Label>
        </div>
        <div class="MessageBorderRight">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    </div>
        <div class="MessageBorder">
        <div class="MessageBorderLeft"> 
            <asp:Label ID="Label3" runat="server" Text="密码：" Font-Size="14pt"></asp:Label>
        </div>
        <div class="MessageBorderRight">
            <asp:TextBox ID="TextBox2" runat="server" type="password"></asp:TextBox>
        </div>
    </div>
            <div class="MessageBorder">
        <div class="MessageBorderLeft">
        </div>
        <div class="MessageBorderRight">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登录" Width="73px"/>
            <asp:Button ID="Button2" runat="server" Text="注册" Width="73px" OnClick="Button2_Click" />
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
</asp:Content>


