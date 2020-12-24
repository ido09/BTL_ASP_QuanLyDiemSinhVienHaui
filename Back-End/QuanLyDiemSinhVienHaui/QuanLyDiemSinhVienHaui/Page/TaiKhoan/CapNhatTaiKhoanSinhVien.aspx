<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="CapNhatTaiKhoanSinhVien.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.TaiKhoan.ThemTaiKhoanSinhVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Thêm tài khoản sinh viên
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title2" runat="server">
    THÊM TÀI KHOẢN SINH VIÊN
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main_content" runat="server">
    <div class="form-group" style="width: 450px; margin: 0 auto">
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Mã SV:</label>
            <div class="col-8">
                <asp:TextBox Enabled="false" CssClass="form-control" runat="server" ID="txtMaSV"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Họ Tên:</label>
            <div class="col-8">
                <asp:TextBox Enabled="false" CssClass="form-control" runat="server" ID="txtName"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Email:(Tên đăng nhập)</label>
            <div class="col-8">
                <asp:TextBox Enabled="false" CssClass="form-control" runat="server" ID="txtEmail"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Password:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtPassword"></asp:TextBox>
            </div>
        </div>

        <div class="text-center">
            <asp:Button CssClass="btn btn-primary mt-3 px-5" ID="CapNhat" Text="Cập nhật" runat="server" OnClick="CapNhat_Click" />
            <asp:Button CssClass="btn btn-dark mt-3 px-5" ID="QuayLai" PostBackUrl="~/Page/TaiKhoan/TaiKhoanSinhVien.aspx" Text="Quay lại" runat="server" />
        </div>
        <div class="text-center my-5">
            <asp:Label ID="msg" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </div>
</asp:Content>
