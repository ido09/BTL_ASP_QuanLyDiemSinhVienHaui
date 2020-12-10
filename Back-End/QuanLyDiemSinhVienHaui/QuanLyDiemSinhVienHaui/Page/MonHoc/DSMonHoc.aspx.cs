using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui
{
    public partial class DSMonHoc : System.Web.UI.Page
    {
        private DataUtil.MonHocDB data = new DataUtil.MonHocDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                hienThiDSMonHoc();
        }

        private void hienThiDSMonHoc()
        {
            dsMonHoc.DataSource = data.getDSMonHoc();
            DataBind();
        }

        public void Xoa_click(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "xoa")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                data.deleteMonHoc(id);
                hienThiDSMonHoc();
            }
        }
        public void Sua_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sua")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Session["monhoc"] = data.get1MonHoc(id);
                Response.Redirect("SuaMonHoc.aspx");
            }
        }
    }
}