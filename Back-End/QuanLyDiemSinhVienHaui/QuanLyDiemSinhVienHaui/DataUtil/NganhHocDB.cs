using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class NganhHocDB
    {
        SqlConnection conn = ConnectDB.getDBConnection();
        public List<NganhHoc> getDSNganhHoc()
        {
            List<NganhHoc> ds = new List<NganhHoc>();
            conn.Open();
            String sql = "select NganhHoc.id, NganhHoc.id_khoa, Khoa.name as 'tenkhoa', NganhHoc.name, " +
                "NganhHoc.description from NganhHoc inner join Khoa on NganhHoc.id_khoa = Khoa.id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                NganhHoc n = new NganhHoc();
                n.id = (int)rd["id"];
                n.name = (string)rd["name"];
                n.description = (string)rd["description"];
                n.id_khoa = (int)rd["id_khoa"];
                n.tenkhoa = (string)rd["tenkhoa"];
                ds.Add(n);
            }
            conn.Close();
            return ds;
        }

        public void addNganhHoc(NganhHoc NganhHoc)
        {
            conn.Open();
            String sql = "insert into NganhHoc values(@name, @description, @id_khoa)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", NganhHoc.name);
            cmd.Parameters.AddWithValue("@description", NganhHoc.description);
            cmd.Parameters.AddWithValue("@id_khoa", NganhHoc.id_khoa);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void editNganhHoc(NganhHoc NganhHoc)
        {
            conn.Open();
            String sql = "update NganhHoc set name = @name, description = @description, id_khoa = @id_khoa" +
                " where id = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", NganhHoc.name);
            cmd.Parameters.AddWithValue("@description", NganhHoc.description);
            cmd.Parameters.AddWithValue("@id_khoa", NganhHoc.id_khoa);
            cmd.Parameters.AddWithValue("@id", NganhHoc.id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public NganhHoc get1NganhHoc(int id)
        {
            conn.Open();
            String sql = "select * from NganhHoc where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            NganhHoc nganh = null;
            if (rd.Read())
            {
                nganh = new NganhHoc();
                nganh.id = (int)rd["id"];
                nganh.name = (string)rd["name"];
                nganh.description = (string)rd["description"];
                nganh.id_khoa = (int)rd["id_khoa"];
            }
            conn.Close();
            return nganh;
        }

        public void deleteNganhHoc(int id)
        {
            conn.Open();
            String sql = "delete from NganhHoc where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}