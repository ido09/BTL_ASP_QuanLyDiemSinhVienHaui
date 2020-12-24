using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyDiemSinhVienHaui.Modal
{
    public class SinhVien
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string birthday { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string avatar { get; set; }
        public string password { get; set; }
        public int id_lop { get; set; }
    }
}