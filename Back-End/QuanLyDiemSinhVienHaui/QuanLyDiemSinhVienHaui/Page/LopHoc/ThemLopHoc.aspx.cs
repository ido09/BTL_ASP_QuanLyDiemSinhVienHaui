using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;


namespace QuanLyDiemSinhVienHaui.Page.LopHoc
{
    public partial class ThemLopHoc : System.Web.UI.Page
    {
        private LopHocDB data = new LopHocDB();
        private NganhHocDB nganhHoc = new NganhHocDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlNganh.DataSource = nganhHoc.getDSNganhHoc();
                ddlNganh.DataTextField = "name";
                ddlNganh.DataValueField = "id";
                DataBind();
            }
        }

        protected void Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenLop = txtTenLop.Text;
                string moTa = txtMoTa.Text;
                int id_nganhhoc = int.Parse(ddlNganh.SelectedValue);
                if (tenLop.Trim().Equals(""))
                {
                    msg.Text = "Tên lớp không được để trống.";
                    return;
                }
                Lop lop = new Lop();
                lop.name = tenLop;
                lop.description = moTa;
                lop.id_nganhhoc = id_nganhhoc;
                data.addLopHoc(lop);
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