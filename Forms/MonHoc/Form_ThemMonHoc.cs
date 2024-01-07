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
    public partial class Form_ThemMonHoc : Form
    {
        private MonHocDao _subjectDao;
        private NghanhHocVaLopHocDao _majorDao;
        private HocKyDao _semesterDao;
        public Form_ThemMonHoc()
        {
            InitializeComponent();
            _subjectDao = new MonHocDao(ConnectionString.connectionStr);
            _majorDao = new NghanhHocVaLopHocDao(ConnectionString.connectionStr);
            _semesterDao = new HocKyDao(ConnectionString.connectionStr);
            LoadComboboxMajors();
            LoadComboboxSemesters();
        }

        /// <summary>
        /// Hàm lưu môn học vào csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                bool isExist = _subjectDao.KiemTraMaMonHocDaTonTai(txt_mamh.Text);
                if (isExist)
                {
                    MessageBox.Show("Mã môn học này đã tồn tại trong hệ thống", "Thông báo");
                }
                else
                {
                    var value = (NghanhHocModel)cb_nghanh.SelectedItem;
                    int result = _subjectDao.ThemMonHoc(txt_mamh.Text, txt_tenmh.Text, value.ma_nghanh, ckb_trangthai.Checked, dpk_ngayketthuc.Value);
                    if (result == 1)
                    {
                        var value1 = (HocKyModel)comboBox1.SelectedItem;
                        int resultHockyMonHoc = _semesterDao.ThemMonHocHocKy(txt_mamh.Text, value1.ma_hocky);
                        if(resultHockyMonHoc == 1)
                        {
                            MessageBox.Show("Thêm môn học thành công", "Thông báo");
                            txt_mamh.Text = string.Empty;
                            txt_tenmh.Text = string.Empty;
                            cb_nghanh.SelectedIndex = 0;
                            ckb_trangthai.Checked = false;
                            dpk_ngayketthuc.Value = DateTime.Now;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra với hệ thống", "Thông báo");
                    }
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
                    comboBox1.Items.Add(item);
                }
                comboBox1.ValueMember = "ma_hocky";
                comboBox1.DisplayMember = "ten_hocky";
                comboBox1.SelectedIndex = 0;
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

        private void Form_AddSubject_FormClosed(object sender, FormClosedEventArgs e)
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
