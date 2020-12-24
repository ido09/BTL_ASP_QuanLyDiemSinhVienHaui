using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui.Page.MonHoc
{
    public partial class PhanCongGiangDay : System.Web.UI.Page
    {
        PhanCongGiangDayDB data = new PhanCongGiangDayDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hienThiDSPhanCongGV();
            }
        }

        private void hienThiDSPhanCongGV()
        {
            dsPhanCongGiangDay.DataSource = data.getDSPhanCongGiangDay();
            DataBind();
        }

        public void Xoa_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                data.deletePC(id);
                hienThiDSPhanCongGV();
            }
        }
        public void Sua_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sua")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Session["GV_MonHoc"] = data.get1PC(id);
                Response.Redirect("SuaPhanCong.aspx");
            }
        }
    }
}