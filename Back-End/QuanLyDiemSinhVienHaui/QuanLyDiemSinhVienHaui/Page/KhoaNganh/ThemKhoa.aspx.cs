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
    public partial class ThemKhoa : System.Web.UI.Page
    {
        private DataUtil.KhoaDB data = new DataUtil.KhoaDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenKhoa = txtTenKhoa.Text;
                string moTa = txtMoTa.Text;
                Khoa khoa = new Khoa();
                khoa.name = tenKhoa;
                khoa.description = moTa;
                data.addKhoa(khoa);
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