using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterAndPower.Model
{
    public class TaiKhoanModel
    {
        public string id { get; set; }  
        public string tai_khoan { get; set; }
        public string mat_khau { get; set; }
        public string email { get; set; }
        public string ngay_tao { get; set; }
        public string ngay_dangnhap_cuoicung { get; set; }
        public string trang_thai { get; set; }
    }
}
