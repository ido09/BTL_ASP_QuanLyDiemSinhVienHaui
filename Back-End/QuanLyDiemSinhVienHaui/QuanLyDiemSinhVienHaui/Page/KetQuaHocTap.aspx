<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="KetQuaHocTap.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.KetQuaHocTap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title2" runat="server">
    Ket qua hoc tap
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

        <asp:TableRow>
            <asp:TableCell>GV chủ nhiệm : </asp:TableCell>
            <asp:TableCell><asp:Label runat="server" Text="Trần Mai Linh"></asp:Label></asp:TableCell>
        </asp:TableRow>

    </asp:Table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_sv,id_mon" DataSourceID="SqlDataSource1" CssClass="table table-bordered">
        <Columns>
            <asp:BoundField DataField="id_sv" HeaderText="id_sv" ReadOnly="True" SortExpression="id_sv" />
            <asp:BoundField DataField="id_mon" HeaderText="id_mon" ReadOnly="True" SortExpression="id_mon" />
            <asp:BoundField DataField="diemTX1" HeaderText="diemTX1" SortExpression="diemTX1" />
            <asp:BoundField DataField="diemTX2" HeaderText="diemTX2" SortExpression="diemTX2" />
            <asp:BoundField DataField="diemThi1" HeaderText="diemThi1" SortExpression="diemThi1" />
            <asp:BoundField DataField="diemThi2" HeaderText="diemThi2" SortExpression="diemThi2" />
            <asp:BoundField DataField="diem10" HeaderText="diem10" SortExpression="diem10" />
            <asp:BoundField DataField="diem4" HeaderText="diem4" SortExpression="diem4" />
            <asp:BoundField DataField="diemChu" HeaderText="diemChu" SortExpression="diemChu" />
            <asp:BoundField DataField="xepLoai" HeaderText="xepLoai" SortExpression="xepLoai" />
            <asp:BoundField DataField="ghiChu" HeaderText="ghiChu" SortExpression="ghiChu" />
        </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLSVConnectionString2 %>" SelectCommand="SELECT * FROM [Diem]"></asp:SqlDataSource>
</asp:Content>
