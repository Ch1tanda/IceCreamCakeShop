<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffInfoManagement.aspx.cs" Inherits="IceCreamCakeShop.Main._3._1._1_InfoManagement.StaffInfoManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="id" DataSourceID="LinqDataSource1" Width="700px" CellSpacing="2">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="name" HeaderText="姓名" SortExpression="name" />
            <asp:BoundField DataField="sex" HeaderText="性别" SortExpression="sex" />
            <asp:BoundField DataField="age" HeaderText="年龄" SortExpression="age" />
            <asp:BoundField DataField="phonenumber" HeaderText="手机号" SortExpression="phonenumber" />
            <asp:BoundField DataField="position" HeaderText="职位" SortExpression="position" />
            <asp:BoundField DataField="salary" HeaderText="薪资" SortExpression="salary" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加员工" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="解雇/修改" />
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="IceCreamCakeShop.DataClasses1DataContext" EntityTypeName="" TableName="Staffinfo">
    </asp:LinqDataSource>
</asp:Content>
