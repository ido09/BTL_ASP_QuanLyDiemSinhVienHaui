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
    public partial class DSNganhHoc : System.Web.UI.Page
    {
        private NganhHocDB data = new NganhHocDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                hienThiDSNganhHoc();
        }

        private void hienThiDSNganhHoc()
        {
            dsNganh.DataSource = data.getDSNganhHoc();
            DataBind();
        }

        public void Xoa_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                data.deleteNganhHoc(id);
                hienThiDSNganhHoc();
            }
        }
        public void Sua_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sua")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Session["nganhhoc"] = data.get1NganhHoc(id);
                Response.Redirect("SuaNganhHoc.aspx");
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyWord.Text.Trim();
            if (keyword.Equals(""))
                hienThiDSNganhHoc();
            else
            {
                dsNganh.DataSource = data.timkiemNganhHoc(keyword);
                DataBind();
            }
        }
    }
}