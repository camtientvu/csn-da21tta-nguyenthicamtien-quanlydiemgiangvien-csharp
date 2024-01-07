using ProjectManage.Common;
using System;
using System.Linq;
using System.Windows.Forms;
using WaterAndPower.Common;
using WaterAndPower.Dao;
using WaterAndPower.UserControls;

namespace WaterAndPower.Forms.ThietLapThoiGianChamThi
{
    public partial class Form_ThietLapThoiGianChamThi : Form
    {
        private ThietLapThoiGianChamThiDao _thietLapThoiGianChamThiDao;
        private string _id_monhoc = "";
        private string _id_hocky = "";
        public Form_ThietLapThoiGianChamThi(string id_monhoc, string ten_mh, string ma_nghanh, string id_hocky, bool trang_thai_cham)
        {
            InitializeComponent();
            _thietLapThoiGianChamThiDao = new ThietLapThoiGianChamThiDao(ConnectionString.connectionStr);
            _id_monhoc = id_monhoc;
            _id_hocky = id_hocky;
            txt_mamh.Enabled = false;
            txt_tenmh.Enabled = false;
            txt_nghanh.Enabled = false;
            txt_trangthai.Enabled = false;
            txt_mamh.Text = id_monhoc;
            txt_tenmh.Text = ten_mh;
            txt_nghanh.Text = ma_nghanh;
            txt_trangthai.Text = trang_thai_cham == true ? "Đã chấm" : "Chưa chấm";
        }

        private void btn_saveandupdate_Click(object sender, EventArgs e)
        {
            int result = _thietLapThoiGianChamThiDao.ThemMoiThoiGianChamThi(_id_monhoc, UserCommon.id_taikhoan, _id_hocky, dpk_ngaycham.Value);
            if (result == 1)
            {
                MessageBox.Show("Bạn thiết lập thời gian chấm thi thành công. Vui lòng xem ở mục 'Thời gian chấm thi'.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra với hệ thống. Vui lòng thử lại sau.", "Thông báo");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_QuanLyMonHoc)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayTatCaMonHoc();
            }
        }

        private void Form_ThietLapThoiGianChamThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_QuanLyMonHoc)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayTatCaMonHoc();
            }
        }
    }
}
