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
using WaterAndPower.Model;
using WaterAndPower.UserControls;

namespace WaterAndPower.Forms.TaiKhoan
{
    public partial class Form_ThemTaiKhoan : Form
    {
        private TaiKhoanDao _taiKhoanDao;
        public Form_ThemTaiKhoan()
        {
            InitializeComponent();
            _taiKhoanDao = new TaiKhoanDao(ConnectionString.connectionStr);
        }

        private void btn_saveandupdate_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (_taiKhoanDao.KiemTraTenDangNhapTonTai(txt_tendn.Text))
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại", "Thông báo");
                }
                else
                {
                    int result = _taiKhoanDao.ThemTaiKhoan(txt_tendn.Text, Common.MD5Extension.MD5Hash(txt_matkhau.Text), txt_email.Text, ckb_trangthai.Checked);
                    if (result == 1)
                    {
                        MessageBox.Show("Thêm mới thành công", "Thông báo");
                    }
                }
            }
        }

        private bool Check()
        {
            if (txt_tendn.Text == "" || txt_tendn.Text == null)
            {
                DialogResult res = MessageBox.Show("Tài khoản không được để chống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            if (txt_matkhau.Text == "" || txt_matkhau.Text == null)
            {
                DialogResult res = MessageBox.Show("Mật khẩu không được để chống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            if (txt_email.Text == "" || txt_email.Text == null)
            {
                DialogResult res = MessageBox.Show("Email không được để chống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            return true;
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

        private void Form_ThemTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
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
