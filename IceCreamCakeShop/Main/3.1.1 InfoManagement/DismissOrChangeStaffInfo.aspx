<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DismissOrChangeStaffInfo.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._1_InfoManagement.DismissOrChangeStaffInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="修改/删除员工信息"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="LinqDataSource1" style="margin-right: 40px" Width="636px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="sex" DataFormatString="{0:男}" HeaderText="sex" SortExpression="sex" />
                <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                <asp:BoundField DataField="phonenumber" HeaderText="phonenumber" SortExpression="phonenumber" />
                <asp:BoundField DataField="position" HeaderText="position" SortExpression="position" />
                <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="IceCreamCakeShop.DataClasses1DataContext" EnableDelete="True" EnableUpdate="True" EntityTypeName="" TableName="Staffinfo">
        </asp:LinqDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="返回" />
    </p>
</asp:Content>
