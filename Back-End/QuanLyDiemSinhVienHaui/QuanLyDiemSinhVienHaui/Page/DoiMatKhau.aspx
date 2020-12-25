<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="DoiMatKhau.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.DoiMatKhau" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title2" runat="server">
   Đổi Mật Khẩu
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main_content" runat="server">
    <asp:Table runat="server">

        <asp:TableRow>
            <asp:TableCell>Mật khẩu cũ*</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtmatkhaucu" Width="400"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
            
         <asp:TableRow>
            <asp:TableCell>Mật khẩu mới*</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtmatkhaumoi" Width="400"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

         <asp:TableRow>
            <asp:TableCell>Xác nhận mật khẩu mới*</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtxacnhanmatkhau" Width="400"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell><asp:Button ID="CapnhatMK" runat="server" Text="Cập nhật mật khẩu" OnClick="CapNhatMK_Click"/></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
