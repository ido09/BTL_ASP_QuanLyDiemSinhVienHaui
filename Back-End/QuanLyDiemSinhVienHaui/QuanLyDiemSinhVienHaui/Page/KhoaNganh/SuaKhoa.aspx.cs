using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;
namespace QuanLyDiemSinhVienHaui.Page.KhoaNganh
{
    public partial class SuaKhoa : System.Web.UI.Page
    {
        private KhoaDB data = new KhoaDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Khoa khoa = (Khoa)Session["khoa"];
                txtMaKhoa.Text = khoa.id + "";
                txtTenKhoa.Text = khoa.name;
                txtMoTa.Text = khoa.description;
            }
        }
        protected void CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maKhoa = int.Parse(txtMaKhoa.Text);
                string tenKhoa = txtTenKhoa.Text;
                string moTa = txtMoTa.Text;
                if (tenKhoa.Trim().Equals(""))
                {
                    msg.Text = "Tên khoa không được để trống.";
                    return;
                }
                Khoa khoa = new Khoa();
                khoa.id = maKhoa;
                khoa.name = tenKhoa;
                khoa.description = moTa;
                data.editKhoa(khoa);
                Response.Redirect("DSNganhHoc.aspx");
            }
            catch (Exception ex)
            {
                msg.Text = "Lỗi: " + ex.Message;
                msg.CssClass = "text-danger";
            }
        }
    }
}