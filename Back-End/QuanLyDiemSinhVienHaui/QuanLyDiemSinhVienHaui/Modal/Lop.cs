﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyDiemSinhVienHaui.Modal
{
    public class Lop
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int id_nganhhoc { get; set; }

        public string tennganh { get; set; }
    }
}