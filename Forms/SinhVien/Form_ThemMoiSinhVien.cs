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

namespace WaterAndPower.Forms.SinhVien
{
    public partial class Form_ThemMoiSinhVien : Form
    {
        private SinhVienDao _sinhVienDao;
        private NghanhHocVaLopHocDao _majorDao;
        public Form_ThemMoiSinhVien()
        {
            InitializeComponent();
            _sinhVienDao = new SinhVienDao(ConnectionString.connectionStr);
            _majorDao = new NghanhHocVaLopHocDao(ConnectionString.connectionStr);
            LayTatCaNghanhHoc();
            LayTatCaLopHoc();
        }

        /// <summary>
        /// Hàm load tất cả các nghành học lên combobox
        /// </summary>
        private void LayTatCaNghanhHoc()
        {
            List<NghanhHocModel> list = _majorDao.LayTatCaNghanhHoc();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    cb_nghanh.Items.Add(item);
                }
                cb_nghanh.ValueMember = "ma_nghanh";
                cb_nghanh.DisplayMember = "ten_nghanh";
                cb_nghanh.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Hàm load tất cả các nghành học lên combobox
        /// </summary>
        private void LayTatCaLopHoc()
        {
            List<LopHocModel> list = _majorDao.LayTatCaLopHoc();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    cb_lop.Items.Add(item);
                }
                cb_lop.ValueMember = "ma_lop";
                cb_lop.DisplayMember = "ten_lop";
                cb_lop.SelectedIndex = 0;
            }
        }

        private void btn_saveandupdate_Click(object sender, EventArgs e)
        {
            if(Check())
            {
                if (_sinhVienDao.KiemTraMaSinhVienTonTai(txt_masv.Text))
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại", "Thông báo");
                }
                else
                {
                    bool gt = false;
                    if (ckb_nam.Checked)
                    {
                        gt = true;
                    }
                    if (ckb_nu.Checked)
                    {
                        gt = false;
                    }
                    var valueNghanh = (NghanhHocModel)cb_nghanh.SelectedItem;
                    var valueLop = (LopHocModel)cb_lop.SelectedItem;
                    int result = _sinhVienDao.ThemSinhVien(txt_masv.Text, txt_tensv.Text, gt, dpk_ngaysinh.Value, valueNghanh.ma_nghanh, valueLop.ma_lop, ckb_trangthai.Checked);
                    if (result == 1)
                    {
                        MessageBox.Show("Thêm mới thành công", "Thông báo");
                    }
                }
            }
        }

        private bool Check()
        {
            if (txt_masv.Text == "" || txt_masv.Text == null)
            {
                DialogResult res = MessageBox.Show("Mã sinh viên không được để chống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            if (txt_tensv.Text == "" || txt_tensv.Text == null)
            {
                DialogResult res = MessageBox.Show("Tên sinh viên không được để chống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            int count2 = this.Controls
                .OfType<CheckBox>()
                .Where(i => i.Checked && i.Text != "")
                .Count();
            int totalcount = count2;

            if (totalcount < 1)
            {
                DialogResult res = MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            if (ckb_trangthai.Checked == false)
            {
                DialogResult res = MessageBox.Show("Bạn phải chọn trạng thái", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void ckb_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_nam.Checked)
            {
                ckb_nu.Checked = false;
            }
        }

        private void ckb_nu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_nu.Checked)
            {
                ckb_nam.Checked = false;
            }
        }

        private void GanDuLieuChoComboboxKhiChonNghanh(string ma_nganh)
        {
            cb_lop.Items.Clear();
            List<LopHocModel> list = _majorDao.LayTatCaLopHoc();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    if (item.id_nghanh == ma_nganh)
                    {
                        cb_lop.Items.Add(item);
                    }
                }
                cb_lop.ValueMember = "ma_lop";
                cb_lop.DisplayMember = "ten_lop";
                cb_lop.SelectedIndex = 0;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_SinhVien)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayDuLieuSinhVien();
            }
        }

        private void Form_ThemMoiSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_SinhVien)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayDuLieuSinhVien();
            }
        }

        private void cb_nghanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valueNghanh = (NghanhHocModel)cb_nghanh.SelectedItem;
            GanDuLieuChoComboboxKhiChonNghanh(valueNghanh.ma_nghanh);
        }
    }
}
