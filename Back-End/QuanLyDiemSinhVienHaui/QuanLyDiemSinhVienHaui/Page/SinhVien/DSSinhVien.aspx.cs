using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui.Page.SinhVien
{
    public partial class DSSinhVien : System.Web.UI.Page
    {
        SinhVienDB sinhVienDB = new SinhVienDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                hienThiDSSinhVien();
        }

        private void hienThiDSSinhVien()
        {
            dsSinhVien.DataSource = sinhVienDB.getDSSinhVien();
            DataBind();
        }

        public void Xoa_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                sinhVienDB.xoaSV(id);
                hienThiDSSinhVien();
            }
        }
        public void Sua_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sua")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Session["sinhvien"] = sinhVienDB.lay1SV(id);
                Response.Redirect("SuaSinhVien.aspx");
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyWord.Text.Trim();
            if (keyword.Equals(""))
                hienThiDSSinhVien();
            else
            {
                dsSinhVien.DataSource = sinhVienDB.timkiemSV(keyword);
                DataBind();
            }
        }
    }
}