using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.Modal;
using QuanLyDiemSinhVienHaui.DataUtil;

namespace QuanLyDiemSinhVienHaui.Page.MonHoc
{
    public partial class PhanCong : System.Web.UI.Page
    {
        GiangVienDB giangVienDB = new GiangVienDB();
        MonHocDB monHocDB = new MonHocDB();
        PhanCongGiangDayDB data = new PhanCongGiangDayDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlGiangVien.DataSource = giangVienDB.getDSGiangVien();
                ddlGiangVien.DataTextField = "name";
                ddlGiangVien.DataValueField = "id";
                DataBind();

                ddlMonHoc.DataSource = monHocDB.getDSMonHoc();
                ddlMonHoc.DataTextField = "name";
                ddlMonHoc.DataValueField = "id";
                DataBind();
            }
        }

        protected void Them_Click(object sender, EventArgs e)
        {
            try
            {
                int idMon = int.Parse(ddlMonHoc.SelectedValue);
                int idGV = int.Parse(ddlGiangVien.SelectedValue);
                string diaDiem = txtDiaDiem.Text;
                string ghiChu = txtGhiChu.Text;

                if (diaDiem.Trim().Equals(""))
                {
                    msg.Text = "Vui lòng thêm địa điểm giảng dạy.";
                    return;
                }
                GV_MonHoc gv_mon = new GV_MonHoc();
                gv_mon.id_gv = idGV;
                gv_mon.id_mon = idMon;
                gv_mon.diadiem = diaDiem;
                gv_mon.ghichu = ghiChu;
                data.themPC(gv_mon);
                msg.Text = "Thành công.";
            }catch(Exception ex)
            {
                msg.Text = "Lỗi: " + ex.Message;
            }
        }

    }
}