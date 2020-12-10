using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui.Page.KhoaNganh
{
    public partial class ThemNganhHoc : System.Web.UI.Page
    {
        private KhoaDB khoa = new KhoaDB();
        private NganhHocDB data = new NganhHocDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlKhoa.DataSource = khoa.getDSKhoa();
                ddlKhoa.DataTextField = "name";
                ddlKhoa.DataValueField = "id";
                DataBind();
            }
        }

        protected void Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNganh = txtTenNganh.Text;
                string moTa = txtMoTa.Text;
                int id_khoa = int.Parse(ddlKhoa.SelectedValue);
                NganhHoc nganh = new NganhHoc();
                nganh.name = tenNganh;
                nganh.description = moTa;
                nganh.id_khoa = id_khoa;
                data.addNganhHoc(nganh);
                msg.Text = "Thêm thành công";
                msg.CssClass = "text-success";
            }
            catch (Exception ex)
            {
                msg.Text = "Lỗi: " + ex.Message;
                msg.CssClass = "text-danger";
            }
        }
    }
}