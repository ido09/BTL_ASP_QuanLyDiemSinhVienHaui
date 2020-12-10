﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThemKhoa.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.KhoaNganh.ThemKhoa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Thêm khoa
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="role" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="taikhoan" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title2" runat="server">
    THÊM KHOA
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="main_content" runat="server">
    <div class="form-group" style="width: 450px; margin: 0 auto">
        <div class="form-group row">
            <label for="" class="col-4 col-form-label">Tên khoa:</label>
            <div class="col-8">
                <asp:TextBox CssClass="form-control" runat="server" ID="txtTenKhoa"></asp:TextBox>
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
            <asp:Button CssClass="btn btn-dark mt-3 px-5" ID="QuayLai" PostBackUrl="~/Page/KhoaNganh/DSKhoa.aspx" Text="Quay lại" runat="server" />
        </div>
        <div class="text-center mt-5">
            <asp:Label ID="msg" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </div>
</asp:Content>