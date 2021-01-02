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
    public partial class SuaGiangVien : System.Web.UI.Page
    {
        KhoaDB khoaDB = new KhoaDB();
        GiangVienDB giangVienDB = new GiangVienDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Modal.GiangVien gv = (Modal.GiangVien)Session["giangvien"];
                txtMaGV.Text = gv.id + "";
                txtHoTen.Text = gv.name;
                txtEmail.Text = gv.email;
                txtNgaySinh.Text = gv.birthday;
                txtPhone.Text = gv.phone;
                txtAddress.Text = gv.address;
                avatarOld.ImageUrl = gv.avatar;

                if (gv.gender.Equals("Nam"))
                    rdNam.Checked = true;
                else rdNu.Checked = true;

                ddlKhoa.DataSource = khoaDB.getDSKhoa();
                ddlKhoa.DataTextField = "name";
                ddlKhoa.DataValueField = "id";
                DataBind();
                ddlKhoa.SelectedValue = gv.id.ToString();
            }

        }

        protected void CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMaGV.Text);
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
                    avatar = giangVienDB.layAvatar(id);//lấy file cũ trong db
                }else
                {
                    string path = Server.MapPath("~/images/GiangVien/");
                    avatar = "/images/GiangVien/" + fileAvatar.FileName;
                    fileAvatar.SaveAs(path + fileAvatar.FileName);
                }
                int id_khoa = int.Parse(ddlKhoa.SelectedValue);

                Modal.GiangVien gv = new Modal.GiangVien();
                gv.id = id;
                gv.name = name;
                gv.gender = gender;
                gv.birthday = birthday;
                gv.email = email;
                gv.phone = phone;
                gv.address = address;
                gv.avatar = avatar;
                gv.id_khoa = id_khoa;

                giangVienDB.suaGV(gv);
                Response.Redirect("DSGiangVien.aspx");
            }
            catch (Exception ex)
            {
                msg.Text += "Lỗi: " + ex.Message;
            }
        }
    }
}