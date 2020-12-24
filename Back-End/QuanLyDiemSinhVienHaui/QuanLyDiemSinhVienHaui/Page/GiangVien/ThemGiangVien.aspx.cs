using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.Modal;
using QuanLyDiemSinhVienHaui.DataUtil;

namespace QuanLyDiemSinhVienHaui.Page.GiangVien
{
    public partial class ThemGiangVien : System.Web.UI.Page
    {
        KhoaDB khoaDB = new KhoaDB();
        GiangVienDB giangVienDB = new GiangVienDB();
        SinhVienDB sinhVienDB = new SinhVienDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlKhoa.DataSource = khoaDB.getDSKhoa();
                ddlKhoa.DataTextField = "name";
                ddlKhoa.DataValueField = "id";
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
                string avatar = "";
                //save file
                if (!fileAvatar.FileName.Equals(""))
                {
                    string path = Server.MapPath("~/images/GiangVien/");
                    fileAvatar.SaveAs(path + fileAvatar.FileName);
                    avatar = "/images/GiangVien/" + fileAvatar.FileName;
                }
                int id_khoa = int.Parse(ddlKhoa.SelectedValue);

                // kiểm tra tồn tại email?
                if (giangVienDB.checkExistEmail(email) || sinhVienDB.checkExistEmail(email))
                {
                    msg.Text += "Email đã tồn tại. Vui lòng nhập emai khác.";
                    return;
                }

                Modal.GiangVien gv = new Modal.GiangVien();
                gv.name = name;
                gv.gender = gender;
                gv.birthday = birthday;
                gv.email = email;
                gv.phone = phone;
                gv.address = address;
                gv.avatar = avatar;
                gv.id_khoa = id_khoa;

                giangVienDB.themGV(gv);
                msg.Text = "Thêm thành công.";
            }
            catch (Exception ex)
            {
                msg.Text += "Lỗi: " + ex.Message;
            }
        }
    }
}