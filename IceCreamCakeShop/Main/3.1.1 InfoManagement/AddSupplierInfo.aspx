<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSupplierInfo.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._1_InfoManagement.AddSupplierInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="添加供应商信息"></asp:Label>
    </p>
    <table style="width:100%;">
        <tr>
            <td style="height: 24px; width: 245px">
                <asp:Label ID="Label2" runat="server" Text="id"></asp:Label>
            </td>
            <td style="height: 24px">
                <asp:Label ID="SupplierId" runat="server" Text="SupplierId"></asp:Label>
            </td>
            <td style="height: 24px"></td>
        </tr>
        <tr>
            <td style="height: 23px; width: 245px">
                <asp:Label ID="Label4" runat="server" Text="name"></asp:Label>
            </td>
            <td style="height: 23px">
                <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
            </td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td style="width: 245px">
                <asp:Label ID="Label6" runat="server" Text="tel"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="PNBox" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </p>
    <p>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确认" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="取消" />
    </p>
</asp:Content>
