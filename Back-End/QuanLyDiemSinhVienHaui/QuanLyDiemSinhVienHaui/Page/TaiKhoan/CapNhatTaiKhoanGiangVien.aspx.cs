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
    public partial class CapNhatTaiKhoanGiangVien : System.Web.UI.Page
    {
        GiangVienDB giangVienDB = new GiangVienDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Modal.GiangVien gv = (Modal.GiangVien)Session["capnhat_tk"];
                txtMaGV.Text = gv.id + "";
                txtName.Text = gv.name;
                txtEmail.Text = gv.email;
                txtPassword.Text = gv.password;
            }
        }
        protected void CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMaGV.Text);
                string password = txtPassword.Text.Trim();
                if (password.Equals(""))
                {
                    msg.Text = "Vui lòng thêm mật khẩu.";
                    return;
                }
                if (password.Length < 6)
                {
                    msg.Text = "Mật khẩu phải lớn hơn hoặc bằng 6 kí tự.";
                    return;
                }
                Modal.GiangVien gv = new Modal.GiangVien();
                gv.id = id;
                gv.password = password;
                giangVienDB.capNhatTK(gv);
                msg.Text = "Thành công";
            }
            catch (Exception ex)
            {
                msg.Text = "Lỗi: " + ex.Message;
            }
        }
    }
}