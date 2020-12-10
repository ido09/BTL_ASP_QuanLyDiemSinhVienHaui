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
    public partial class Login : System.Web.UI.Page
    {
        LoginDB data = new LoginDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            if(username.Equals("") || password.Equals(""))
            {
                msg.Text = "Vui lòng nhập tên tài khoản và mật khẩu.";
                msg.CssClass = "text-danger";
                return;
            }
            if(data.checkLoginAdmin(username,password) != null)
            {
                Session["ADMIN_LOGIN"] = data.checkLoginAdmin(username, password);
                Response.Redirect("TrangChu.aspx");
            }
            else if(data.checkLoginGV(username, password) != null)
            {
                Session["GV_LOGIN"] = data.checkLoginGV(username, password);
                Response.Redirect("TrangChu.aspx");
            }
            else if (data.checkLoginSV(username, password) != null)
            {
                Session["SV_LOGIN"] = data.checkLoginSV(username, password);
                Response.Redirect("TrangChu.aspx");
            }
            else
            {
                msg.Text = "Sai tên tài khoản hoặc mật khẩu.";
                msg.CssClass = "text-danger";
            }
        }
    }
}