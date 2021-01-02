<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="CapNhatTTSV.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.CapNhatTTSV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Sửa sinh viên
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="title2" runat="server">
    Thông Tin Sinh Viên
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="main_content" runat="server">
    <asp:Table runat="server" CssClass="table table-bordered">

        <asp:TableRow>
            <asp:TableCell>Mã sinh viên</asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="lbmasv" ></asp:Label></asp:TableCell>
            <asp:TableCell>Mã sinh viên</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtmasv" Enabled="false"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell>Họ tên</asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="lbhoten"  ></asp:Label></asp:TableCell>
            <asp:TableCell>Họ tên</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txthoten"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Giới tính</asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="lbgioitinh" ></asp:Label></asp:TableCell>
            <asp:TableCell>Giới tính</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtgioitinh"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell>Birthday</asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="lbnamsinh"></asp:Label></asp:TableCell>
            <asp:TableCell>Họ tên</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtnamsinh"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Email</asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="lbemail" ></asp:Label></asp:TableCell>
            <asp:TableCell>Email</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtemail"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell>Phone</asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="lbphone" ></asp:Label></asp:TableCell>
            <asp:TableCell>Phone</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtphone"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Address</asp:TableCell>
            <asp:TableCell><asp:Label runat="server" ID="lbaddress" ></asp:Label></asp:TableCell>
            <asp:TableCell>Address</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtaddress"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell>Avatar</asp:TableCell>
            <asp:TableCell><asp:Image ID="avatar" ImageUrl="~/images/" runat="server" Width="200"/></asp:TableCell>
            <asp:TableCell>Avatar</asp:TableCell>
            <asp:TableCell>
                <asp:FileUpload ID="fileAvatar" runat="server" />
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                
                <asp:Button  ID="btnCapNhatTTSV" Text="Cập nhật" runat="server" OnClick="CapNhat_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
