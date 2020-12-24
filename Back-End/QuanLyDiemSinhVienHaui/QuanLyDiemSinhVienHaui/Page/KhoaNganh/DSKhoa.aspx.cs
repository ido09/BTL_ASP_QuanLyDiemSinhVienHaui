using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.DataUtil;

namespace QuanLyDiemSinhVienHaui.Page.KhoaNganh
{
    public partial class DSKhoa : System.Web.UI.Page
    {
        KhoaDB data = new KhoaDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hienThiDSKhoa();
            }
        }

        private void hienThiDSKhoa()
        {
            dsKhoa.DataSource = data.getDSKhoa();
            DataBind();
        }

        public void Sua_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sua")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Session["khoa"] = data.get1Khoa(id);
                Response.Redirect("SuaKhoa.aspx");
            }
        }
        public void Xoa_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                data.deleteKhoa(id);
                hienThiDSKhoa();
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyWord.Text.Trim();
            if (keyword.Equals(""))
                hienThiDSKhoa();
            else
            {
                dsKhoa.DataSource = data.timkiemKhoa(keyword);
                DataBind();
            }
        }
    }
}