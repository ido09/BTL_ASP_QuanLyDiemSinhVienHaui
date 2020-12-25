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
    public partial class SuaNganhHoc : System.Web.UI.Page
    {
        private NganhHocDB data = new NganhHocDB();
        private KhoaDB khoa = new KhoaDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NganhHoc nganh = (NganhHoc)Session["nganhhoc"];
                txtMaNganh.Text = nganh.id + "";
                txtTenNganh.Text = nganh.name;
                txtMoTa.Text = nganh.description;

                ddlKhoa.DataSource = khoa.getDSKhoa();
                ddlKhoa.DataTextField = "name";
                ddlKhoa.DataValueField = "id";
                DataBind();
                ddlKhoa.SelectedValue = nganh.id_khoa.ToString();
            }
        }

        protected void CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maNganh = int.Parse(txtMaNganh.Text);
                string tenNganh = txtTenNganh.Text;
                string moTa = txtMoTa.Text;
                int id_khoa = int.Parse(ddlKhoa.SelectedValue);
                NganhHoc nganh = new NganhHoc();

                nganh.id = maNganh;
                nganh.name = tenNganh;
                nganh.description = moTa;
                nganh.id_khoa = id_khoa;

                data.editNganhHoc(nganh);
                Response.Redirect("DSNganhHoc.aspx");
            }
            catch (Exception ex)
            {
                msg.Text = "Lỗi: " + ex.Message;
                msg.CssClass = "text-danger";
            }
        }
    }
}