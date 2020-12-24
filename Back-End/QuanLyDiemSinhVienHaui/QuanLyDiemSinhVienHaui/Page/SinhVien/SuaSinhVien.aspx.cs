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
    public partial class SuaSinhVien : System.Web.UI.Page
    {
        LopHocDB lopHocDB = new LopHocDB();
        SinhVienDB sinhVienDB = new SinhVienDB();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Modal.SinhVien sv = (Modal.SinhVien)Session["sinhvien"];
                txtMaSV.Text = sv.id + "";
                txtHoTen.Text = sv.name;
                txtEmail.Text = sv.email;
                txtNgaySinh.Text = sv.birthday;
                txtPhone.Text = sv.phone;
                txtAddress.Text = sv.address;

                if (sv.gender.Equals("Nam"))
                    rdNam.Checked = true;
                else rdNu.Checked = true;

                ddlLop.DataSource = lopHocDB.getDSLopHoc();
                ddlLop.DataTextField = "name";
                ddlLop.DataValueField = "id";
                DataBind();
                ddlLop.SelectedValue = sv.id.ToString();
            }
        }
        protected void CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMaSV.Text);
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
                if (fileAvatar.FileName.Equals(""))
                {
                    avatar = sinhVienDB.layAvatar(id);//lấy file cũ trong db
                }
                else
                {
                    string path = Server.MapPath("~/images/SinhVien/");
                    avatar = "/images/SinhVien/" + fileAvatar.FileName;
                    fileAvatar.SaveAs(path + fileAvatar.FileName);
                }
                int id_lop = int.Parse(ddlLop.SelectedValue);

                Modal.SinhVien sv = new Modal.SinhVien();
                sv.id = id;
                sv.name = name;
                sv.gender = gender;
                sv.birthday = birthday;
                sv.email = email;
                sv.phone = phone;
                sv.address = address;
                sv.avatar = avatar;
                sv.id_lop = id_lop;

                sinhVienDB.suaSV(sv);
                Response.Redirect("DSSinhVien.aspx");
            }
            catch (Exception ex)
            {
                msg.Text += "Lỗi: " + ex.Message;
            }
        }
    }
}