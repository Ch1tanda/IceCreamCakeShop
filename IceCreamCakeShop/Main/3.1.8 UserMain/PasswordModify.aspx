<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="PasswordModify.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._8_UserMain.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="MessageBorder">
    <div class="MessageBorderLeft">id:&nbsp;</div>
        <div class="MessageBorderRight">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    <div class="MessageBorder">
    <div class="MessageBorderLeft">原密码:&nbsp;</div>
        <div class="MessageBorderRight">
            <asp:TextBox ID="TextBox1" runat="server" type="password"></asp:TextBox>
        </div>
    </div>
        <div class="MessageBorder">
    <div class="MessageBorderLeft">新密码:&nbsp;</div>
        <div class="MessageBorderRight">
            <asp:TextBox ID="TextBox2" runat="server" type="password"></asp:TextBox>
        </div>
    </div>
        <div class="MessageBorder">
    <div class="MessageBorderLeft">重复新密码:&nbsp;</div>
        <div class="MessageBorderRight">
            <asp:TextBox ID="TextBox3" runat="server" type="password"></asp:TextBox>
        </div>
    </div>
    <div>
        <div class="MessageBorderLeft"></div>

        <div class="MessageBorderRight">
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" class="ProfileButton" runat="server" Text="确定" OnClick="Button3_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" class="ProfileButton" runat="server" Text="取消" OnClick="Button4_Click" />
        </div>
    </div>
</asp:Content>
