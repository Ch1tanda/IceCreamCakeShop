<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._0_Login.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div runat="server">

        <table style="width: 100%">
            <tr>
                <td colspan="2" style="text-align: center; height: 28px;">
                    <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="注册"></asp:Label>
                &nbsp;&nbsp;&nbsp;<asp:Label ID="IsNULLTip" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">
                    <asp:Label ID="Label2" runat="server" Text="姓名："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">
                    <asp:Label ID="Label3" runat="server" Text="密码："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">
                    <asp:Label ID="Label4" runat="server" Text="确认密码："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="repassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">
                    <asp:Label ID="Label5" runat="server" Text="手机号："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="phonenumber" runat="server"></asp:TextBox>
                    <asp:Label ID="PHETip" runat="server" ForeColor="Red" Text="电话格式错误" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">
                    <asp:Label ID="Label6" runat="server" Text="地址："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="address" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right" class="auto-style1">
                    <asp:Label ID="Label7" runat="server" Text="生日："></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="year" runat="server" Width="50px"></asp:TextBox>
                    <asp:Label ID="Label8" runat="server" Text="年"></asp:Label>
                    <asp:TextBox ID="month" runat="server" Width="50px"></asp:TextBox>
                    <asp:Label ID="Label9" runat="server" Text="月"></asp:Label>
                    <asp:TextBox ID="days" runat="server" Width="50px"></asp:TextBox>
                    <asp:Label ID="Label10" runat="server" Text="日"></asp:Label>
                    <asp:Label ID="ErrorTip" runat="server" BorderColor="#CC3300" ForeColor="#CC3300" Text="输入错误" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td>&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="注册" Width="82px" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</asp:Content>

