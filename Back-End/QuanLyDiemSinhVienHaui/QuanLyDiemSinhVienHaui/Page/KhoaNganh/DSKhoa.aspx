<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="DSKhoa.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.KhoaNganh.DSKhoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Danh sách khoa
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="title2" runat="server">
    DANH SÁCH KHOA
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="main_content" runat="server">
    <div class="my-3">
        <asp:Button CssClass="btn btn-primary" ID="btnDSKhoa" Text="Thêm khoa" runat="server" PostBackUrl="~/Page/KhoaNganh/ThemKhoa.aspx" />
    </div>
    <div class="tbl_render">
        <asp:GridView ID="dsKhoa" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Mã khoa" />
                <asp:BoundField DataField="name" HeaderText="Tên khoa" />
                <asp:BoundField DataField="description" HeaderText="Mô tả" />
                <asp:TemplateField HeaderText="Xóa" ItemStyle-CssClass="text-center" ItemStyle-Width="100px">
                    <ItemTemplate>
                        <asp:Button ID="xoa" CommandName="xoa" Text="Xóa"
                            CommandArgument='<%# Bind("id") %>' OnCommand="Xoa_click" runat="server"
                            OnClientClick="return confirm('Bạn có chắc chắn muốn xóa?')" CssClass="btn btn-danger" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sửa" ItemStyle-CssClass="text-center" ItemStyle-Width="100px">
                    <ItemTemplate>
                        <asp:Button ID="sua" CommandName="sua" Text="Sửa"
                            CommandArgument='<%# Bind("id") %>' OnCommand="Sua_click" runat="server"
                            CssClass="btn btn-primary" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
