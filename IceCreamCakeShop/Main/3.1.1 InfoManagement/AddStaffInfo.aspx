<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStaffInfo.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._1_InfoManagement.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="添加员工信息"></asp:Label>
    </p>
        <table style="width:100%;">
            <tr>
                <td style="height: 24px; width: 245px">
                    <asp:Label ID="Label2" runat="server" Text="id"></asp:Label>
                </td>
                <td style="height: 24px">
                    <asp:Label ID="StaffId" runat="server" Text="StaffId"></asp:Label>
                </td>
                <td style="height: 24px"></td>
            </tr>
            <tr>
                <td style="width: 245px">
                    <asp:Label ID="Label3" runat="server" Text="password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="PWBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 245px">Retype poassword</td>
                <td>
                    <asp:TextBox ID="RPWBox" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="TipPW" runat="server" ForeColor="Red" Text="两次密码输入不一致" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
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
                <td style="height: 24px; width: 245px">
                    <asp:Label ID="Label5" runat="server" Text="sex"></asp:Label>
                </td>
                <td style="height: 24px">
                    <asp:RadioButtonList ID="SexRDL" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="height: 24px"></td>
            </tr>
            <tr>
                <td style="width: 245px">
                    <asp:Label ID="Label6" runat="server" Text="age"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="AgeBox" runat="server"></asp:TextBox>
                    <asp:Label ID="ageLab" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 245px">
                    <asp:Label ID="Label7" runat="server" Text="phonenumber"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="PNBox" runat="server"></asp:TextBox>
                    <asp:Label ID="PHETip" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 245px">
                    <asp:Label ID="Label8" runat="server" Text="position"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="positionRDL" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">服务员</asp:ListItem>
                        <asp:ListItem>厨师</asp:ListItem>
                        <asp:ListItem>送货员</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 245px">
                    <asp:Label ID="Label9" runat="server" Text="salary"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="SalaryBox" runat="server"></asp:TextBox>
                    <asp:Label ID="salaryLab" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
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
