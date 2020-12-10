using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.Modal;
using QuanLyDiemSinhVienHaui.DataUtil;

namespace QuanLyDiemSinhVienHaui.Page.SinhVien
{
    public partial class ThemSinhVien : System.Web.UI.Page
    {
        LopHocDB lop = new LopHocDB();
        SinhVienDB data = new SinhVienDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlLop.DataSource = lop.getDSLopHoc();
                ddlLop.DataTextField = "name";
                ddlLop.DataValueField = "id";
                DataBind();
            }
        }
        protected void Them_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtHoTen.Text;
                string gender = "";
                if (rdNam.Checked)
                    gender += "Nam";
                else gender += "Nữ";
                string birthday = txtNgaySinh.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;

                //save file
                string path = Server.MapPath("~/images/SinhVien/");
                fileAvatar.SaveAs(path + fileAvatar.FileName);

                string avatar = "/images/SinhVien/" + fileAvatar.FileName;
                int id_lop = int.Parse(ddlLop.SelectedValue);

                Modal.SinhVien sv = new Modal.SinhVien();
                sv.name = name;
                sv.gender = gender;
                sv.birthday = birthday;
                sv.email = email;
                sv.phone = phone;
                sv.address = address;
                sv.avatar = avatar;
                sv.id_lop = id_lop;

                data.themSV(sv);
                msg.Text = "Thêm thành công.";
            }
            catch (Exception ex)
            {
                msg.Text += "Lỗi: " + ex.Message;
            }
        }
    }
}