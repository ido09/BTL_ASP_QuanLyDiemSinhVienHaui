<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThongTinCacLopHoc.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.ThongTinCacLopHoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title2" runat="server">
    Thông tin các lớp học
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main_content" runat="server">
    <asp:Table runat="server" CssClass="table table-bordered">
        <asp:TableRow>
            <asp:TableCell>Họ tên : </asp:TableCell>
            <asp:TableCell><asp:Label runat="server" Text="Vương Dương"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Lớp : </asp:TableCell>
            <asp:TableCell><asp:Label runat="server" Text="HTTT1"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  DataSourceID="SqlDataSource1" CssClass="table table-bordered" DataKeyNames="id">
        <Columns>
           
            

           
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
            <asp:BoundField DataField="sotinchi" HeaderText="sotinchi" SortExpression="sotinchi" />
           
            

           
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLSV1ConnectionString5 %>" SelectCommand="SELECT * FROM [MonHoc]"></asp:SqlDataSource>
</asp:Content>
