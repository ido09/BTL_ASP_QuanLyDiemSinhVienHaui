<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="SuaLopHoc.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.LopHoc.SuaLopHoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Sửa lớp học
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="role" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="taikhoan" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title2" runat="server">
    SỬA LỚP HỌC
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="main_content" runat="server">
    <div class="form-group" style="width: 450px; margin: 0 auto">
         <div class="form-group row">
            <label for="" class="col-4 col-form-label">Mã lớp:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" Enabled="false" runat="server" ID="txtMaLop"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Tên Lớp:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtTenLop"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Mô tả:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtMoTa"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Ngành học: </label>
            <div class="col-8">
                <asp:DropDownList CssClass="form-control" ID="ddlNganh" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="text-center">
            <asp:Button CssClass="btn btn-primary mt-3 px-5" ID="CapNhat" Text="Cập nhật" runat="server" OnClick="CapNhat_Click" />
            <asp:Button CssClass="btn btn-dark mt-3 px-5" ID="QuayLai" PostBackUrl="~/Page/LopHoc/DSLopHoc.aspx" Text="Quay lại" runat="server" />
        </div>
        <div class="text-center mt-5">
            <asp:Label ID="msg" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </div>
</asp:Content>
