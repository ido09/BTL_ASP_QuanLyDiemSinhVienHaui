<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MasterPage.Master" AutoEventWireup="true" CodeBehind="DSLopHoc.aspx.cs" Inherits="QuanLyDiemSinhVienHaui.Page.LopHoc.DSLopHoc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Danh sách lớp học
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="title2" runat="server">
    DANH SÁCH LỚP HỌC
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="main_content" runat="server">
    <div class="my-3 d-flex justify-content-between align-content-center">
        <asp:Button CssClass="btn btn-primary" ID="btnDSLopHoc" Text="Thêm lớp học" runat="server" PostBackUrl="~/Page/LopHoc/ThemLopHoc.aspx" />
        <div class="form-group" style="width: 350px; margin:0">
            <div class="form-group row m-0 align-items-center">
                <label for="" class="col-4 col-form-label">
                    <asp:Button CssClass="btn btn-primary" ID="btnTimKiem" Text="Tìm kiếm" runat="server" OnClick="btnTimKiem_Click" />
                </label>
                <div class="col-8 ">
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtKeyWord"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="tbl_render">
        <asp:GridView ID="dsLopHoc" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Mã ngành" />
                <asp:BoundField DataField="name" HeaderText="Tên ngành" />
                <asp:BoundField DataField="description" HeaderText="Mô tả" />
                <asp:BoundField DataField="tennganh" HeaderText="Ngành" />
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
