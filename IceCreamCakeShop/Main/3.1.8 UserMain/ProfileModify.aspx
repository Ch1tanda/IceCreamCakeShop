<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="ProfileModify.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._8_UserMain.WebForm6" %>
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
            
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            
        </div>
    </div>
    <div class="MessageBorder">
        <div class="MessageBorderLeft">电话号码:&nbsp;</div>
        <div class="MessageBorderRight">
            
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            
        </div>
    </div>
    <div class="MessageBorder">
    <div class="MessageBorderLeft">家庭住址:&nbsp;</div>
        <div class="MessageBorderRight">
            
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            
        </div>
    </div>
    <div class="MessageBorder">
    <div class="MessageBorderLeft">生日:&nbsp;</div>
        <div class="MessageBorderRight">
            
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            
        </div>
    </div>
    <div class="MessageBorder">
    <div class="MessageBorderLeft">VIP种类:&nbsp;</div>
        <div class="MessageBorderRight">
            
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            
        </div>
    </div>
    <div class="MessageBorder">
    <div class="MessageBorderLeft">消费总值:&nbsp;</div>
        <div class="MessageBorderRight">
            
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            
        </div>
    </div>
    <div class="MessageBorder">
        <div class="MessageBorderLeft"></div>
        <div class="MessageBorderRight">
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="确认" class="ProfileButton" OnClick="Button4_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="取消" class="ProfileButton" OnClick="Button3_Click"/>
            
        </div>
    </div>
</asp:Content>
