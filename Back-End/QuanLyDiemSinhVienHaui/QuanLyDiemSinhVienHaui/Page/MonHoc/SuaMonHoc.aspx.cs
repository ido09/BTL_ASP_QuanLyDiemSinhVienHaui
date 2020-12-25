using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyDiemSinhVienHaui
{
    public partial class SuaMonHoc : System.Web.UI.Page
    {
        MonHocDB data = new MonHocDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MonHoc mon = (MonHoc)Session["monhoc"];
                txtMaMon.Text = mon.id + "";
                txtTenMon.Text = mon.name;
                txtSoTinChi.Text = mon.sotinchi + "";
                txtMoTa.Text = mon.description;
            }
        }

        protected void CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maMon = int.Parse(txtMaMon.Text);
                string tenMon = txtTenMon.Text;
                int soTinChi = int.Parse(txtSoTinChi.Text);
                string moTa = txtMoTa.Text;
                MonHoc mon = new MonHoc();
                mon.id = maMon;
                mon.name = tenMon;
                mon.sotinchi = soTinChi;
                mon.description = moTa;
                data.editMonHoc(mon);
                Response.Redirect("DSMonHoc.aspx");
            }
            catch (Exception ex)
            {
                msg.Text = "Lỗi: " + ex.Message;
                msg.CssClass = "text-danger";
            }
        }
    }
}