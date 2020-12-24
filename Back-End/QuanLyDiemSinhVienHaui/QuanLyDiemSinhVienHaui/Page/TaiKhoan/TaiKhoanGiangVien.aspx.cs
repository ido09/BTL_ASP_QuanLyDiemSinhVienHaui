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
    public partial class TaiKhoanGiangVien : System.Web.UI.Page
    {
        GiangVienDB giangVienDB = new GiangVienDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hienThiDSGiangVien();
            }
        }
        public void hienThiDSGiangVien()
        {
            dsGiangVien.DataSource = giangVienDB.getDSGiangVien();
            DataBind();
        }
        public void Xoa_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                giangVienDB.xoaTK(id);
                hienThiDSGiangVien();
            }
        }
        public void CapNhat_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "capnhat")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Session["capnhat_tk"] = giangVienDB.lay1GV(id);
                Response.Redirect("CapNhatTaiKhoanGiangVien.aspx");
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyWord.Text.Trim();
            if (keyword.Equals(""))
                hienThiDSGiangVien();
            else
            {
                dsGiangVien.DataSource = giangVienDB.timkiemGV(keyword);
                DataBind();
            }
        }
    }
}