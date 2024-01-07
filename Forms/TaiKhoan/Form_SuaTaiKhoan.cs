using ProjectManage.Common;
using System;
using System.Linq;
using System.Windows.Forms;
using WaterAndPower.Dao;
using WaterAndPower.UserControls;

namespace WaterAndPower.Forms.TaiKhoan
{
    public partial class Form_SuaTaiKhoan : Form
    {
        private string _idtaikhoan = "";
        private TaiKhoanDao _taiKhoanDao;
        public Form_SuaTaiKhoan(string idtaikhoan, string tai_khoan, string mat_khau, string email, DateTime ngay_tao, DateTime ngay_dang_nhap, bool trang_thai)
        {
            InitializeComponent();
            _taiKhoanDao = new TaiKhoanDao(ConnectionString.connectionStr);
            _idtaikhoan = idtaikhoan;
            txt_tendn.Text = tai_khoan;
            txt_matkhau.Text = mat_khau;
            txt_email.Text = email;
            dpk_ngaytao.Value = ngay_tao;
            dpk_ngaydangnhap.Value = ngay_dang_nhap;
            ckb_trangthai.Checked = trang_thai;
        }

        private void btn_saveandupdate_Click(object sender, EventArgs e)
        {
            if(_idtaikhoan != null && _idtaikhoan != "")
            {
                int result = _taiKhoanDao.CapNhapTaiKhoan(_idtaikhoan, txt_tendn.Text, Common.MD5Extension.MD5Hash(txt_matkhau.Text), txt_email.Text, dpk_ngaytao.Value, dpk_ngaydangnhap.Value, ckb_trangthai.Checked);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhập thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra với hệ thống. Vui lòng thử lại sau", "Thông báo");
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _taiKhoanDao.Dispose();
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_TaiKhoanQuyen)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayDuLieuTaiKhoan();
            }
        }

        private void Form_SuaTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            _taiKhoanDao.Dispose();
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_TaiKhoanQuyen)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayDuLieuTaiKhoan();
            }
        }
    }
}
