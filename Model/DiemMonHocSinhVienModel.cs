using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterAndPower.Model
{
    public class DiemMonHocSinhVienModel
    {
        public int id { get; set; }
        public string id_nghanh { get; set; }
        public string id_lop { get; set; }
        public string ma_sv { get; set; }
        public string ten_sv { get; set; }
        public string ma_monhoc { get; set; }
        public string ten_monhoc { get; set; }
        public string DiemQT1 { get; set; }
        public string DiemQT2 { get; set; }
        public string DiemThilan1 { get; set; }
        public string DiemThilan2 { get; set; }
        public string ngay_ket_thuc { get; set; }
        public string ngay_thi { get; set; }
        public string ngay_cham { get; set; }
    }
}
