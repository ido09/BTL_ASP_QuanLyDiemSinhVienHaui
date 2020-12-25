using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.Modal;
using System.Data.SqlClient;
using QuanLyDiemSinhVienHaui.DataUtil;

namespace QuanLyDiemSinhVienHaui.Page
{
    public partial class DoiMatKhau : System.Web.UI.Page
    {
        CapNhatTTSVDB capnhap = new CapNhatTTSVDB();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //modal.sinhvien sv = (modal.sinhvien)session["sv_login"];
            //txtmatkhaucu.text = sv.password;
            
        }

        protected void CapNhatMK_Click(object sender, EventArgs e)
        {
            Modal.SinhVien sv = (Modal.SinhVien)Session["SV_LOGIN"];
            sv.password = txtmatkhaumoi.Text;
            
            if ((txtmatkhaucu.Text).Equals(txtmatkhaumoi.Text))
            {
                Response.Write("<script>alert('Mat khau khong thay doi. Doi that bai');</script>");

                return;
            }
            if (!(txtmatkhaumoi.Text).Equals(txtxacnhanmatkhau.Text))
            {
                Response.Write("<script>alert('Xac nhan sai. Doi that bai');</script>");

                return;
            }
            capnhap.doiMK(sv);
            Response.Write("<script>alert('Doi thanh cong');</script>");
            
        }
    }
}