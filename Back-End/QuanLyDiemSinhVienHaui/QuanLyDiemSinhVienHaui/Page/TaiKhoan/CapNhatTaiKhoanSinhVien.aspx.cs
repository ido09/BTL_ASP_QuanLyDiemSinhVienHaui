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
    public partial class ThemTaiKhoanSinhVien : System.Web.UI.Page
    {
        SinhVienDB sinhVienDB = new SinhVienDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Modal.SinhVien sv = (Modal.SinhVien)Session["capnhat_tk"];
                txtMaSV.Text = sv.id+"";
                txtName.Text = sv.name;
                txtEmail.Text = sv.email;
                txtPassword.Text = sv.password;
            }
        }

        protected void CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMaSV.Text);
                string password = txtPassword.Text.Trim();
                if (password.Equals(""))
                {
                    msg.Text = "Vui lòng thêm mật khẩu.";
                    return;
                }
                if(password.Length < 6)
                {
                    msg.Text = "Mật khẩu phải lớn hơn hoặc bằng 6 kí tự.";
                    return;
                }
                Modal.SinhVien sv = new Modal.SinhVien();
                sv.id = id;
                sv.password = password;
                sinhVienDB.capNhatTK(sv);
                msg.Text = "Thành công";
            }
            catch (Exception ex)
            {
                msg.Text = "Lỗi: " + ex.Message;
            }
        }
    }
}