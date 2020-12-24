<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="SuaPhanCong.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.MonHoc.SuaPhanCong" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Sửa phân công giảng dạy
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title2" runat="server">
    SỬA PHÂN CÔNG GIẢNG DẠY
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main_content" runat="server">
    <div class="form-group" style="width: 450px; margin: 0 auto">
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Mã PC:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" Enabled="false" runat="server" ID="txtMaPC"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Môn Học:</label>
            <div class="col-8">
                <asp:DropDownList CssClass="form-control" ID="ddlMonHoc" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Giảng Viên:</label>
            <div class="col-8">
                <asp:DropDownList CssClass="form-control" ID="ddlGiangVien" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Địa điểm:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtDiaDiem"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Ghi chú:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtGhiChu"></asp:TextBox>
            </div>
        </div>

        <div class="text-center">
            <asp:Button CssClass="btn btn-primary mt-3 px-5" ID="CapNhat" Text="Cập nhật" runat="server" OnClick="CapNhat_Click" />
            <asp:Button CssClass="btn btn-dark mt-3 px-5" ID="QuayLai" PostBackUrl="~/Page/MonHoc/PhanCongGiangDay.aspx" Text="Quay lại" runat="server" />
        </div>
        <div class="text-center mt-5">
            <asp:Label ID="msg" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </div>
</asp:Content>
