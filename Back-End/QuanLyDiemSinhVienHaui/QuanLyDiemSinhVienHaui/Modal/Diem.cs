using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyDiemSinhVienHaui.Modal
{
    public class Diem
    {
        public int id_sv { get; set; }
        public int id_mon { get; set; }

        public double diemTX1 { get; set; }
        public double diemTX2 { get; set; }
        public double diemThi1 { get; set; }
        public double diemThi2 { get; set; }
        public double diem10 { get; set; }
        public double diem4 { get; set; }
        public string diemChu { get; set; }
        public string xepLoai { get; set; }
        public string ghiChu { get; set; }
    }
}