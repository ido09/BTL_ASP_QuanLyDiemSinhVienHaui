<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThemMonHoc.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.ThemMonHoc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Thêm môn học
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="role" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="taikhoan" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title2" runat="server">
    THÊM MÔN HỌC
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="main_content" runat="server">
    <div class="form-group" style="width: 450px; margin: 0 auto">
        <%-- <asp:Table runat="server" ID="tblThemMon" Width="347px" Height="122px">
            <asp:TableRow CssClass="my-5">
                <asp:TableCell CssClass="mr-4">Tên môn</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox CssClass="form-control" runat="server" ID="txtTenMon"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="my-5">
                <asp:TableCell CssClass="mr-4">Số tín chỉ</asp:TableCell>
                <asp:TableCell CssClass="mr-4">
                    <asp:TextBox CssClass="form-control " runat="server" ID="txtSoTinChi"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="my-5">
                <asp:TableCell CssClass="mr-4">Mô tả</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox CssClass="form-control " runat="server" ID="txtMoTa"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>--%>


        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Tên môn:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtTenMon"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Số tín chỉ:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtSoTinChi"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Mô tả:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtMoTa"></asp:TextBox>
            </div>
        </div>
        <div class="text-center">
            <asp:Button CssClass="btn btn-primary mt-3 px-5" ID="Them" Text="Thêm" runat="server" OnClick="Them_Click" />
            <asp:Button CssClass="btn btn-dark mt-3 px-5" ID="QuayLai" PostBackUrl="~/Page/MonHoc/DSMonHoc.aspx" Text="Quay lại" runat="server" />
        </div>
        <div class="text-center mt-5">
            <asp:Label ID="msg" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </div>
</asp:Content>
