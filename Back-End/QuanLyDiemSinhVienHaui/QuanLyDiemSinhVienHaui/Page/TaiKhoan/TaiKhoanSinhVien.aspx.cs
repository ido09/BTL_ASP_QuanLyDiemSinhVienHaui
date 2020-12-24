using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.Modal;
using QuanLyDiemSinhVienHaui.DataUtil;

namespace QuanLyDiemSinhVienHaui.Page.TaiKhoan
{
    public partial class TaiKhoanSinhVien : System.Web.UI.Page
    {
        SinhVienDB sinhVienDB = new SinhVienDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hienThiDSSinhVien();
            }
        }
        public void hienThiDSSinhVien()
        {
            dsSinhVien.DataSource = sinhVienDB.getDSSinhVien();
            DataBind();
        }
        public void Xoa_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                sinhVienDB.xoaTK(id);
                hienThiDSSinhVien();
            }
        }
        public void CapNhat_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "capnhat")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Session["capnhat_tk"] = sinhVienDB.lay1SV(id);
                Response.Redirect("CapNhatTaiKhoanSinhVien.aspx");
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