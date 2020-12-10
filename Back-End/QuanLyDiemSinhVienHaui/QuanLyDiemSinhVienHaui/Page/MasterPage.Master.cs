using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.Modal;
using QuanLyDiemSinhVienHaui.DataUtil;

namespace QuanLyDiemSinhVienHaui
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GiangVien gv = null;
            SinhVien sv = null;
            Admin ad = null;
            if(Session["ADMIN_LOGIN"] != null)
            {
                ad = (Admin)Session["ADMIN_LOGIN"];
                txtRole.Text = "QUẢN TRỊ";
                txtRole2.Text = "QUẢN TRỊ";
                txtUserLogin.Text = ad.username;
            }else if(Session["GV_LOGIN"] != null)
            {
                gv = (GiangVien)Session["GV_LOGIN"];
                txtRole.Text = "GIẢNG VIÊN";
                txtRole2.Text = "GIẢNG VIÊN";
                txtUserLogin.Text = gv.name;
            }else if(Session["SV_LOGIN"] != null)
            {
                sv = (SinhVien)Session["SV_LOGIN"];
                txtRole.Text = "SINH VIÊN";
                txtRole2.Text = "SINH VIÊN";
                txtUserLogin.Text = sv.name;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("/Page/Login.aspx");
        }
    }
}