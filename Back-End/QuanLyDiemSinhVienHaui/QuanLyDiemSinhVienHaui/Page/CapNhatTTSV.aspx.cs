using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui.Page
{
    public partial class CapNhatTTSV : System.Web.UI.Page
    {

        CapNhatTTSVDB data = new CapNhatTTSVDB();
        SqlConnection con = ConnectDB.getDBConnection();
      
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Modal.SinhVien sv = (Modal.SinhVien)Session["SV_LOGIN"];

                txtmasv.Text = sv.id + "";
                txthoten.Text = data.getName(sv.email);
                txtemail.Text = sv.email;
                txtnamsinh.Text = data.getBirthday(sv.email);
                txtphone.Text = data.getPhone(sv.email);
                txtaddress.Text = data.getAddress(sv.email);
                txtgioitinh.Text = sv.gender;
                avatar.ImageUrl = sv.avatar;




                lbmasv.Text = sv.id + "";
                lbhoten.Text = data.getName(sv.email);
                lbemail.Text = sv.email;
                lbnamsinh.Text = data.getBirthday(sv.email);
                lbphone.Text = data.getPhone(sv.email);
                lbaddress.Text = data.getAddress(sv.email);
                lbgioitinh.Text = data.getGender(sv.email);
            }
               

        }

        protected void CapNhat_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtmasv.Text);
            string name = txthoten.Text;
            string gender = txtgioitinh.Text;
            string birthday = txtnamsinh.Text;
            string email = txtemail.Text;
            string phone = txtphone.Text;
            string address = txtaddress.Text;
            string avatar = "";
            //save file
            if (fileAvatar.FileName.Equals(""))
            {
                avatar = data.layAvatar(id);
            }
            else
            {
                string path = Server.MapPath("~/images/SinhVien/");
                avatar = "/images/SinhVien/" + fileAvatar.FileName;
                fileAvatar.SaveAs(path + fileAvatar.FileName);
            }


            Modal.SinhVien sv = new Modal.SinhVien();
            sv.id = id;
            sv.name = name;
            sv.gender = gender;
            sv.birthday = birthday;
            sv.email = email;
            sv.phone = phone;
            sv.address = address;
            sv.avatar = avatar;

            data.suaSV(sv);
            Response.Redirect("CapNhatTTSV.aspx");
            


        }
    }
}