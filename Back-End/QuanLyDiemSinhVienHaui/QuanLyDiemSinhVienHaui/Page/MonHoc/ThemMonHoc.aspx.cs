using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui
{
    public partial class ThemMonHoc : System.Web.UI.Page
    {
        private DataUtil.MonHocDB data = new DataUtil.MonHocDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenMon = txtTenMon.Text;
                int soTinChi = int.Parse(txtSoTinChi.Text);
                string moTa = txtMoTa.Text;
                MonHoc mon = new MonHoc();
                mon.name = tenMon;
                mon.sotinchi = soTinChi;
                mon.description = moTa;
                data.addMonHoc(mon);
                msg.Text = "Thêm thành công";
                msg.CssClass = "text-success";// css sang màu xanh
            }
            catch (Exception ex)
            {
                msg.Text = "Lỗi: " + ex.Message;
                msg.CssClass = "text-danger";
            }
        }
    }
}