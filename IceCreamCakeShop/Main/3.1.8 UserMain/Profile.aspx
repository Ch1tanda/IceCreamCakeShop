<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._8_UserMain.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="MessageBorder">
        <div class="MessageBorderLeft">用户ID:&nbsp; </div>
        <div class="MessageBorderRight">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    <div class="MessageBorder">
        <div class="MessageBorderLeft">用户姓名:&nbsp;</div>
        <div class="MessageBorderRight">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    <div class="MessageBorder">
        <div class="MessageBorderLeft">电话号码:&nbsp;</div>
        <div class="MessageBorderRight">
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    <div class="MessageBorder">
    <div class="MessageBorderLeft">收货地址:&nbsp;</div>
        <div class="MessageBorderRight">
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    <div class="MessageBorder">
    <div class="MessageBorderLeft">生日:&nbsp;</div>
        <div class="MessageBorderRight">
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    <div class="MessageBorder">
    <div class="MessageBorderLeft">VIP种类:&nbsp;</div>
        <div class="MessageBorderRight">
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    <div class="MessageBorder">
    <div class="MessageBorderLeft">消费总值:&nbsp;</div>
        <div class="MessageBorderRight">
            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    <div class="MessageBorder">
        <div class="MessageBorderLeft"></div>
        <div class="MessageBorderRight">
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="修改" class="ProfileButton" OnClick="Button3_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="返回" class="ProfileButton" OnClick="Button4_Click" style="height: 21px"/>
        </div>
    </div>
</asp:Content>
