using ProjectManage.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WaterAndPower.Dao;
using WaterAndPower.Model;
using WaterAndPower.UserControls;

namespace WaterAndPower.Forms.MonHoc
{
    public partial class Form_SuaMonHoc : Form
    {
        private MonHocDao _subjectDao;
        private NghanhHocVaLopHocDao _majorDao;
        private HocKyDao _semesterDao;
        public Form_SuaMonHoc(string id_monhoc, string ten_mh, string ma_nghanh, string id_hocky, bool trang_thai_thi, DateTime ngay_ket_thuc)
        {
            InitializeComponent();
            _subjectDao = new MonHocDao(ConnectionString.connectionStr);
            _majorDao = new NghanhHocVaLopHocDao(ConnectionString.connectionStr);
            _semesterDao = new HocKyDao(ConnectionString.connectionStr);
            txt_mamh.Text = id_monhoc;
            txt_tenmh.Text = ten_mh;
            txt_mamh.Text = id_monhoc;
            ckb_trangthai.Checked = trang_thai_thi;
            dpk_ngayketthuc.Value = ngay_ket_thuc;
            txt_mamh.Enabled = false;
            LoadComboboxMajors();
            LoadDefaultValueCombobox(ma_nghanh);
            LoadComboboxSemesters();
        }

        private void LoadDefaultValueCombobox(string ma_nganh)
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

        private void LoadComboboxSemesters()
        {
            List<HocKyModel> list = _semesterDao.LayTatCaHocKy();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    cb_semester.Items.Add(item);
                }
                cb_semester.ValueMember = "ma_hocky";
                cb_semester.DisplayMember = "ten_hocky";
                cb_semester.SelectedIndex = 0;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                var value = (NghanhHocModel)cb_nghanh.SelectedItem;
                int result = _subjectDao.CapNhapMonHocQuaMa(txt_mamh.Text, txt_tenmh.Text, value.ma_nghanh, ckb_trangthai.Checked, dpk_ngayketthuc.Value);
                if (result == 1)
                {
                    MessageBox.Show("Sửa môn học thành công", "Thông báo");
                    txt_mamh.Text = string.Empty;
                    txt_tenmh.Text = string.Empty;
                    cb_nghanh.SelectedIndex = 0;
                    ckb_trangthai.Checked = false;
                    dpk_ngayketthuc.Value = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Hàm load tất cả các nghành học lên combobox
        /// </summary>
        private void LoadComboboxMajors()
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
        /// Hàm check mã nghành, mã môn học, tên môn học không được để trống
        /// Trả về true nếu không trống còn false nếu để trống 1 trong những trường trên
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (txt_mamh.Text == "" || txt_tenmh.Text == null)
            {
                DialogResult res = MessageBox.Show("Mã môn học không được để chống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            if (txt_tenmh.Text == "" || txt_tenmh.Text == null)
            {
                DialogResult res = MessageBox.Show("Tên môn học không được để chống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            if (cb_nghanh.SelectedItem.ToString() == "" || cb_nghanh.SelectedItem.ToString() == null)
            {
                DialogResult res = MessageBox.Show("Nghành học không được để chống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }

            return true;
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

        private void Form_EditSubject_FormClosed(object sender, FormClosedEventArgs e)
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
