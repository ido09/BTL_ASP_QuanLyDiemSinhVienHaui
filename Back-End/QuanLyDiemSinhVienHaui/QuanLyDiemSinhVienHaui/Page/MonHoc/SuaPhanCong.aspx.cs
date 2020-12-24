using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui.Page.MonHoc
{
    public partial class SuaPhanCong : System.Web.UI.Page
    {
        PhanCongGiangDayDB data = new PhanCongGiangDayDB();
        GiangVienDB giangVienDB = new GiangVienDB();
        MonHocDB monHocDB = new MonHocDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GV_MonHoc gv_mon = (GV_MonHoc) Session["GV_MonHoc"];

                ddlGiangVien.DataSource = giangVienDB.getDSGiangVien();
                ddlGiangVien.DataTextField = "name";
                ddlGiangVien.DataValueField = "id";
                ddlGiangVien.SelectedValue = gv_mon.id_gv.ToString();
                DataBind();

                ddlMonHoc.DataSource = monHocDB.getDSMonHoc();
                ddlMonHoc.DataTextField = "name";
                ddlMonHoc.DataValueField = "id";
                ddlMonHoc.SelectedValue = gv_mon.id_mon.ToString();
                DataBind();

                txtMaPC.Text = gv_mon.id + "";
                txtDiaDiem.Text = gv_mon.diadiem;
                txtGhiChu.Text = gv_mon.ghichu;
            }
        }

        protected void CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maPC = int.Parse(txtMaPC.Text);
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
                gv_mon.id = maPC;
                gv_mon.id_gv = idGV;
                gv_mon.id_mon = idMon;
                gv_mon.diadiem = diaDiem;
                gv_mon.ghichu = ghiChu;
                data.suaPC(gv_mon);
                Response.Redirect("PhanCongGiangDay.aspx");
            }
            catch (Exception ex)
            {
                msg.Text = "Lỗi: " + ex.Message;
            }
        }
    }
}