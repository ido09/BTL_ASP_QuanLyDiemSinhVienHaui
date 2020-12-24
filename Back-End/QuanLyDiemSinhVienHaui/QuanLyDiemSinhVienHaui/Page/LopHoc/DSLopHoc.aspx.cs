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
    public partial class DSLopHoc : System.Web.UI.Page
    {
        private LopHocDB data = new LopHocDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                hienThiDSLopHoc();
        }

        private void hienThiDSLopHoc()
        {
            dsLopHoc.DataSource = data.getDSLopHoc();
            DataBind();
        }

        public void Xoa_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                data.deleteNganhHoc(id);
                hienThiDSLopHoc();
            }
        }
        public void Sua_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sua")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Session["lophoc"] = data.get1LopHoc(id);
                Response.Redirect("SuaLopHoc.aspx");
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyWord.Text.Trim();
            if (keyword.Equals(""))
                hienThiDSLopHoc();
            else
            {
                dsLopHoc.DataSource = data.timkiemLopHoc(keyword);
                DataBind();
            }
        }
    }
}