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

        public int diemTX1 { get; set; }
        public int diemTX2 { get; set; }
        public int diemThi1 { get; set; }
        public int diemThi2 { get; set; }
        public int diem10 { get; set; }
        public int diem4 { get; set; }
        public string diemChu { get; set; }
        public string xepLoai { get; set; }
        public string ghiChu { get; set; }
    }
}