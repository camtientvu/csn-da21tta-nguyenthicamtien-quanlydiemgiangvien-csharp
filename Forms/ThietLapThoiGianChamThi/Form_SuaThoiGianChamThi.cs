using ProjectManage.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterAndPower.Dao;
using WaterAndPower.UserControls;

namespace WaterAndPower.Forms.ThietLapThoiGianChamThi
{
    public partial class Form_SuaThoiGianChamThi : Form
    {
        private int _id;
        private ThietLapThoiGianChamThiDao _thietLapThoiGianChamThiDao;
        public Form_SuaThoiGianChamThi(int id, string id_hocky, string id_nghanh, string ma_monhoc, string ten_monhoc, DateTime ngay_cham, DateTime ngay_ket_thuc)
        {
            InitializeComponent();
            _thietLapThoiGianChamThiDao = new ThietLapThoiGianChamThiDao(ConnectionString.connectionStr);
            txt_mahocky.Enabled = false;
            txt_idnghanh.Enabled = false;
            txt_mamonhoc.Enabled = false;
            txt_tenmonhoc.Enabled = false;
            dpk_ngayketthuc.Enabled = false;
            _id = id;
            txt_mahocky.Text = id_hocky;
            txt_idnghanh.Text = id_nghanh;
            txt_mamonhoc.Text = ma_monhoc;
            txt_tenmonhoc.Text = ten_monhoc;
            dpk_ngaythi.Value = ngay_cham;
            dpk_ngayketthuc.Value = ngay_ket_thuc;
        }

        private void btn_saveandupdate_Click(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                int result = _thietLapThoiGianChamThiDao.CapNhapThoiGianChamThi(_id, dpk_ngaythi.Value);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhập thành công", "Thông báo");
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_QuanLyThoiGianChamThi)frm.ActiveControl;
            if (uc != null)
            {
                uc.LoadDataTimeExams();
            }
        }

        private void Form_SuaThoiGianChamThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_QuanLyThoiGianChamThi)frm.ActiveControl;
            if (uc != null)
            {
                uc.LoadDataTimeExams();
            }
        }
    }
}
