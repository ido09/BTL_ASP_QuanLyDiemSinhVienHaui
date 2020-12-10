using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.Modal;
using QuanLyDiemSinhVienHaui.DataUtil;

namespace QuanLyDiemSinhVienHaui.Page.LopHoc
{
    public partial class SuaLopHoc : System.Web.UI.Page
    {
        private LopHocDB data = new LopHocDB();
        private NganhHocDB nganhHoc = new NganhHocDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Lop lop = (Lop)Session["lophoc"];
                txtMaLop.Text = lop.id + "";
                txtMoTa.Text = lop.description;
                txtTenLop.Text = lop.name;
                
                ddlNganh.DataSource = nganhHoc.getDSNganhHoc();
                ddlNganh.DataTextField = "name";
                ddlNganh.DataValueField = "id";
                DataBind();

                ddlNganh.SelectedValue = lop.id.ToString();
            }
        }
        protected void CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maLop = int.Parse(txtMaLop.Text);
                string tenLop = txtTenLop.Text;
                string moTa = txtMoTa.Text;
                int id_nganh = int.Parse(ddlNganh.SelectedValue);

                Lop lop = new Lop();

                lop.id = maLop;
                lop.name = tenLop;
                lop.description = moTa;
                lop.id_nganhhoc = id_nganh;

                data.editLopHoc(lop);
                Response.Redirect("DSLopHoc.aspx");
            }
            catch (Exception ex)
            {
                msg.Text = "Lỗi: " + ex.Message;
                msg.CssClass = "text-danger";
            }
        }
    }
}