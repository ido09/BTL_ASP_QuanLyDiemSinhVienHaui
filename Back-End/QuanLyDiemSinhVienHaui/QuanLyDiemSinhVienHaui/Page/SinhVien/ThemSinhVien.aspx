<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThemSinhVien.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.SinhVien.ThemSinhVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Thêm giảng viên
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="title2" runat="server">
    THÊM GIẢNG VIÊN
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="main_content" runat="server">
    <div class="text-center my-5">
            <asp:Label ID="msg" runat="server" Font-Bold="true"></asp:Label>
        </div>
    <div class="form-group" style="width: 450px; margin: 0 auto">
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Họ Tên:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtHoTen"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Giới tính:</label>
            <div class="col-8">
                <asp:RadioButton ID="rdNam" runat="server" Text="Nam" GroupName="Gender" Checked="True" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rdNu" runat="server" Text="Nữ" GroupName="Gender" />
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Ngày sinh</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtNgaySinh"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Email:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtEmail"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Phone:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtPhone"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Address:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtAddress"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Avatar:</label>
            <div class="col-8">
                <asp:FileUpload ID="fileAvatar" runat="server" />
            </div>
        </div>

        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Lớp:</label>
            <div class="col-8">
                <asp:DropDownList ID="ddlLop" CssClass="form-control" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div class="text-center">
            <asp:Button CssClass="btn btn-primary mt-3 px-5" ID="Them" Text="Thêm" runat="server" OnClick="Them_Click" />
            <asp:Button CssClass="btn btn-dark mt-3 px-5" ID="QuayLai" PostBackUrl="~/Page/SinhVien/DSSinhVien.aspx" Text="Quay lại" runat="server" />
        </div>
    </div>
</asp:Content>
