<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="PhanCongGiangDay.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.MonHoc.PhanCongGiangDay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Phân công giảng dạy
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="title2" runat="server">
    PHÂN CÔNG GIẢNG DẠY
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="main_content" runat="server">
    <div class="my-3 d-flex justify-content-between align-content-center">
        <asp:Button CssClass="btn btn-primary" ID="btnPhanCong" Text="Phân Công Giảng Dạy" PostBackUrl="~/Page/MonHoc/ThemPhanCong.aspx" runat="server" />
    </div>
    <div class="tbl_render">
        <asp:GridView ID="dsPhanCongGiangDay" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Mã PC" />
                <asp:BoundField DataField="id_mon" HeaderText="Mã môn" />
                <asp:BoundField DataField="tenmon" HeaderText="Tên môn" />
                <asp:BoundField DataField="id_gv" HeaderText="Mã GV" />
                <asp:BoundField DataField="tengv" HeaderText="Tên GV" />
                <asp:BoundField DataField="diadiem" HeaderText="Địa điểm" />
                <asp:BoundField DataField="ghichu" HeaderText="Ghi chú" />
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
