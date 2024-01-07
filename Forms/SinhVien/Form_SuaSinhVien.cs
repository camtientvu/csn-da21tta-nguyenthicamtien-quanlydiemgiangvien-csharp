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
    public partial class Form_SuaSinhVien : Form
    {
        private string _id = "";
        private NghanhHocVaLopHocDao _majorDao;
        private SinhVienDao _sinhVienDao;
        public Form_SuaSinhVien(string ma_sv, string ten_sv, bool gioi_tinh, DateTime ngay_sinh, string id_nghanh, string id_lop, DateTime ngay_tao, bool trang_thai)
        {
            InitializeComponent();
            _majorDao = new NghanhHocVaLopHocDao(ConnectionString.connectionStr);
            _sinhVienDao = new SinhVienDao(ConnectionString.connectionStr);
            txt_masv.Enabled = false;
            txt_masv.Text = ma_sv;
            _id = ma_sv;
            txt_tensv.Text = ten_sv;
            if (gioi_tinh)
            {
                ckb_nam.Checked = true;
            }
            else
            {
                ckb_nu.Checked = true;
            }
            dpk_ngaysinh.Value = ngay_sinh;
            dpk_ngaytao.Value = ngay_tao;
            ckb_trangthai.Checked = trang_thai;
            LayTatCaNghanhHoc();
            LayTatCaLopHoc();
            GanDuLieuChoMacDinhChoComboboxNghanhHoc(id_nghanh);
            GanDuLieuChoMacDinhChoComboboxLopHoc(id_lop);
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

        private void GanDuLieuChoMacDinhChoComboboxNghanhHoc(string ma_nganh)
        {
            foreach (var item in cb_nghanh.Items)
            {
                var value = (NghanhHocModel)item;
                if (value.ma_nghanh.Equals(ma_nganh))
                {
                    cb_nghanh.SelectedItem = item;
                }
            }
        }

        private void GanDuLieuChoMacDinhChoComboboxLopHoc(string ma_nganh)
        {
            foreach (var item in cb_lop.Items)
            {
                var value = (LopHocModel)item;
                if (value.ma_lop.Equals(ma_nganh))
                {
                    cb_lop.SelectedItem = item;
                }
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
                    if(item.id_nghanh == ma_nganh)
                    {
                        cb_lop.Items.Add(item);
                    }
                }
                cb_lop.ValueMember = "ma_lop";
                cb_lop.DisplayMember = "ten_lop";
                cb_lop.SelectedIndex = 0;
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

            if (ckb_nam.Checked == false || ckb_nu.Checked == false)
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

        private void btn_saveandupdate_Click(object sender, EventArgs e)
        {
            if (_id != null && _id != "")
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
                int result = _sinhVienDao.CapNhapSinhVienQuaMa(txt_masv.Text, txt_tensv.Text, gt, dpk_ngaysinh.Value, valueNghanh.ma_nghanh, valueLop.ma_lop, ckb_trangthai.Checked);
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
            _majorDao.Dispose();
            _sinhVienDao.Dispose();
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_SinhVien)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayDuLieuSinhVien();
            }
        }

        private void Form_SuaSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            _majorDao.Dispose();
            _sinhVienDao.Dispose();
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_SinhVien)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayDuLieuSinhVien();
            }
        }

        private void ckb_nam_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_nam.Checked)
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

        private void cb_nghanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valueNghanh = (NghanhHocModel)cb_nghanh.SelectedItem;
            GanDuLieuChoComboboxKhiChonNghanh(valueNghanh.ma_nghanh);
        }
    }
}
