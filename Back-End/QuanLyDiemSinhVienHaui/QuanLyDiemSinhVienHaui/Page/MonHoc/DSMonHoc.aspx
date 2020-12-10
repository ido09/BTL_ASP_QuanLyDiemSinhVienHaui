<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="DSMonHoc.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.DSMonHoc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Danh sách môn học
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title2" runat="server">
    DANH SÁCH MÔN HỌC
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main_content" runat="server">
    <div class="my-3">
        <asp:Button CssClass="btn btn-primary" ID="btnDSMonHoc" Text="Thêm môn học" runat="server" PostBackUrl="~/Page/MonHoc/ThemMonHoc.aspx" />
    </div>
    <div class="tbl_render">
        <asp:GridView ID="dsMonHoc" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Mã môn" />
                <asp:BoundField DataField="name" HeaderText="Tên môn" />
                <asp:BoundField DataField="description" HeaderText="Mô tả" />
                <asp:BoundField DataField="sotinchi" HeaderText="Số tín chỉ" />
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
