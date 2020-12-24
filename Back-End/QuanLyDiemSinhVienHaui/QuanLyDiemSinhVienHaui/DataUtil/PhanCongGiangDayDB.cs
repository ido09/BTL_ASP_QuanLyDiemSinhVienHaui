using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QuanLyDiemSinhVienHaui.Modal;
namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class PhanCongGiangDayDB
    {
        SqlConnection conn = ConnectDB.getDBConnection();

        public List<GV_MonHoc> getDSPhanCongGiangDay()
        {
            conn.Open();
            List<GV_MonHoc> ds = new List<GV_MonHoc>();
            string sql = "select GV_MonHoc.id, id_mon, MonHoc.name as 'tenmon',id_gv, GiangVien.name as 'tengv', diadiem, ghichu " +
                "from MonHoc inner join GV_MonHoc on MonHoc.id = GV_MonHoc.id_mon " +
                "inner join GiangVien on GiangVien.id = GV_MonHoc.id_gv";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                GV_MonHoc gv_mon = new GV_MonHoc();
                gv_mon.id = (int)rd["id"];
                gv_mon.id_gv = (int)rd["id_gv"];
                gv_mon.id_mon = (int)rd["id_mon"];
                gv_mon.tengv = (string)rd["tengv"];
                gv_mon.tenmon = (string)rd["tenmon"];
                gv_mon.diadiem = (string)rd["diadiem"];
                gv_mon.ghichu = (string)rd["ghichu"];
                ds.Add(gv_mon);
            }
            conn.Close();
            return ds;
        }

        public GV_MonHoc get1PC(int id)
        {
            conn.Open();
            GV_MonHoc gv_mon = null;
            string sql = "select * from GV_MonHoc where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                gv_mon = new GV_MonHoc();
                gv_mon.id = (int)rd["id"];
                gv_mon.id_gv = (int)rd["id_gv"];
                gv_mon.id_mon = (int)rd["id_mon"];
                gv_mon.diadiem = (string)rd["diadiem"];
                gv_mon.ghichu = (string)rd["ghichu"];
            }
            conn.Close();
            return gv_mon;
        }


        public void deletePC(int id)
        {
            conn.Open();
            string sql = "delete from GV_MonHoc where id = "+ id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void suaPC(GV_MonHoc gv_mon)
        {
            conn.Open();
            string sql = "update GV_MonHoc set id_gv = @id_gv, id_mon = @id_mon, diadiem = @diadiem," +
                "ghichu = @ghichu where id = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_gv", gv_mon.id_gv);
            cmd.Parameters.AddWithValue("@id_mon", gv_mon.id_mon);
            cmd.Parameters.AddWithValue("@diadiem", gv_mon.diadiem);
            cmd.Parameters.AddWithValue("@ghichu", gv_mon.ghichu);
            cmd.Parameters.AddWithValue("@id", gv_mon.id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void themPC(GV_MonHoc gv_mon)
        {
            conn.Open();
            String sql = "insert into GV_MonHoc values(@id_gv, @id_mon, @diadiem, @ghichu)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_gv", gv_mon.id_gv);
            cmd.Parameters.AddWithValue("@id_mon", gv_mon.id_mon);
            cmd.Parameters.AddWithValue("@diadiem", gv_mon.diadiem);
            cmd.Parameters.AddWithValue("@ghichu", gv_mon.ghichu);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}