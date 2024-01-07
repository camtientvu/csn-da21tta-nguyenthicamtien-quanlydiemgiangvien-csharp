using ProjectManage.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WaterAndPower.Dao;
using WaterAndPower.Model;
using WaterAndPower.UserControls;

namespace WaterAndPower.Forms.Diem
{
    public partial class Form_Diem : Form
    {
        private string _masv = "";
        private int _id = 0;
        private string _lop { get; set; }
        private string _tensv { get; set; }
        private string _nghanh { get; set; }
        private string _mamh = "";
        private string _idtaikhoan = "";
        private bool updateOrAdd = false;
        private DiemDao _diemDao;
        private ThietLapThoiGianChamThiDao _thietLapThoiGianChamThiDao;
        private ThietLapThoiGianThiDao _thietLapThoiGianThiDao;
        private List<MonHocModel> monHocTaiKhoanModel = new List<MonHocModel>();
        private List<DiemMonHocSinhVienModel> diemsinhviens = new List<DiemMonHocSinhVienModel>();
        private SinhVienDao _sinhVienDao;
        private MonHocDao _monHocDao;
        private NghanhHocVaLopHocDao _nghanhHocVaLopHocDao;
        private MonHocDao _subjectDao;
        public Form_Diem(string ma_sv, string lop, string nghanh, string ten_sv,string idTaikhoan)
        {
            InitializeComponent();
            _diemDao = new DiemDao(ConnectionString.connectionStr);
            _thietLapThoiGianChamThiDao = new ThietLapThoiGianChamThiDao(ConnectionString.connectionStr);
            _thietLapThoiGianThiDao = new ThietLapThoiGianThiDao(ConnectionString.connectionStr);
            _diemDao = new DiemDao(ConnectionString.connectionStr);
            _monHocDao = new MonHocDao(ConnectionString.connectionStr);
            _nghanhHocVaLopHocDao = new NghanhHocVaLopHocDao(ConnectionString.connectionStr);
            _subjectDao = new MonHocDao(ConnectionString.connectionStr);
            _masv = ma_sv;
            _lop = lop;
            _nghanh = nghanh;
            _tensv = ten_sv;
            _idtaikhoan = idTaikhoan;
            cb_lop.Enabled = false;
            cb_nghanh.Enabled = false;
            txt_masv.Text = ma_sv;
            txt_tensv.Text = ten_sv;
            txt_masv.Enabled = false;
            txt_tensv.Enabled = false;
            LayDuLieuDiemCuaSv();
            LayTatCaMonHoc();
            LayDuLieuCuaLopHocHoc();
            LayDuLieuCuaNghanhHoc();
        }

        private void GanDuLieuMacDinhChoComboboxNghanhHoc(string nghanh_hoc)
        {
            foreach (var item in cb_nghanh.Items)
            {
                var value = (NghanhHocModel)item;
                if (value.ma_nghanh.Equals(nghanh_hoc))
                {
                    cb_nghanh.SelectedItem = item;
                }
            }
        }

        private void GanDuLieuMacDinhChoComboboxLopHoc(string lop_hoc)
        {
            foreach (var item in cb_lop.Items)
            {
                var value = (LopHocModel)item;
                if (value.ma_lop.Equals(lop_hoc))
                {
                    cb_lop.SelectedItem = item;
                }
            }
        }

        private void GanDuLieuMacDinhChoComboboxMonHoc(string mon_hoc)
        {
            foreach (var item in cb_monhoc.Items)
            {
                var value = (MonHocModel)item;
                if (value.ma_monhoc.Equals(mon_hoc))
                {
                    cb_monhoc.SelectedItem = item;
                }
            }
        }

        /// <summary>
        /// Hàm load tất cả các nghành học lên combobox
        /// </summary>
        private void LayDuLieuCuaNghanhHoc()
        {
            List<NghanhHocModel> list = _nghanhHocVaLopHocDao.LayTatCaNghanhHoc();
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
        private void LayDuLieuCuaLopHocHoc()
        {
            List<LopHocModel> list = _nghanhHocVaLopHocDao.LayTatCaLopHoc();
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

        /// <summary>
        /// Hàm load tất cả các nghành học lên combobox
        /// </summary>
        private void LayTatCaMonHoc()
        {
            List<MonHocModel> list = _monHocDao.LayTatCaMonHoc();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    cb_monhoc.Items.Add(item);
                }
                cb_monhoc.ValueMember = "ten_monhoc";
                cb_monhoc.DisplayMember = "ma_monhoc";
                cb_monhoc.SelectedIndex = 0;
            }
        }

        public void LayDuLieuDiemCuaSv()
        {
            dataGridView1.Rows.Clear();
            diemsinhviens = _diemDao.LayDiemMonHocTheoMaSinhVien(_masv);
            monHocTaiKhoanModel = _subjectDao.LayTatCaMonHocTheoIdTaikhoan(_idtaikhoan);
            if (diemsinhviens != null && diemsinhviens.Count > 0)
            {
                try
                {
                    foreach(var item in monHocTaiKhoanModel)
                    {
                        foreach (var diem in diemsinhviens)
                        {
                            if(item.ma_monhoc == diem.ma_monhoc)
                            {
                                DataGridViewRow newRow = new DataGridViewRow();
                                newRow.CreateCells(dataGridView1);
                                newRow.Cells[0].Value = diem.id;
                                newRow.Cells[1].Value = diem.id_nghanh;
                                newRow.Cells[2].Value = diem.id_lop;
                                newRow.Cells[3].Value = diem.ma_sv;
                                newRow.Cells[4].Value = diem.ten_sv;
                                newRow.Cells[5].Value = diem.ma_monhoc;
                                newRow.Cells[6].Value = diem.ten_monhoc;
                                newRow.Cells[7].Value = diem.DiemQT1;
                                newRow.Cells[8].Value = diem.DiemQT2;
                                newRow.Cells[9].Value = diem.DiemThilan1;
                                newRow.Cells[10].Value = diem.DiemThilan2;
                                newRow.Cells[11].Value = diem.ngay_ket_thuc;
                                dataGridView1.Rows.Add(newRow);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có dữ liệu trong hệ thống", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong hệ thống", "Thông báo");
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(updateOrAdd)
            {
                var valueMonhoc = (MonHocModel)cb_monhoc.SelectedItem;
                int resultAdd = _diemDao.ThemDiemMonHoc(_masv, valueMonhoc.ma_monhoc, Convert.ToDouble(txt_diemqt1.Text), Convert.ToDouble(txt_diemqt2.Text), Convert.ToDouble(txt_diemthi1.Text), Convert.ToDouble(txt_diemthi2.Text));
                if (resultAdd == 1)
                {
                    MessageBox.Show("Thêm điểm điểm thành công", "Thông báo");
                    LayDuLieuDiemCuaSv();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra với hệ thống vui lòng thử lại sau", "Thông báo");
                }
            }
            else
            {
                int result = _diemDao.CapNhapDiemSinhVien(_id, _masv, _mamh, Convert.ToDouble(txt_diemqt1.Text), Convert.ToDouble(txt_diemqt2.Text), Convert.ToDouble(txt_diemthi1.Text), Convert.ToDouble(txt_diemthi2.Text));
                if (result == 1)
                {
                    MessageBox.Show("Cập nhập điểm thành công", "Thông báo");
                    LayDuLieuDiemCuaSv();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra với hệ thống vui lòng thử lại sau", "Thông báo");
                }
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

        private void Form_Diem_ControlAdded(object sender, ControlEventArgs e)
        {
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_SinhVien)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayDuLieuSinhVien();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                try
                {
                    updateOrAdd = false;
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    _id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    string nghanh = row.Cells[1].Value.ToString();
                    string lop = row.Cells[2].Value.ToString();
                    string ma_sv = row.Cells[3].Value.ToString();
                    string ten_sv = row.Cells[4].Value.ToString();
                    string ma_mh = row.Cells[5].Value.ToString();
                    _mamh = row.Cells[5].Value.ToString();
                    string ten_mh = row.Cells[6].Value.ToString();
                    string diem_qt1 = Convert.ToDouble(row.Cells[7].Value.ToString()) > 0.0 ? row.Cells[7].Value.ToString() : "Chưa có điểm";
                    string diem_qt2 = Convert.ToDouble(row.Cells[7].Value.ToString()) > 0.0 ? "Lấy điểm lần 1" : row.Cells[8].Value.ToString();
                    string diem_thi1 = Convert.ToDouble(row.Cells[9].Value.ToString()) > 0.0 ? row.Cells[9].Value.ToString() : "Chưa có điểm";
                    string diem_thi2 = Convert.ToDouble(row.Cells[9].Value.ToString()) > 0.0 ? "Lấy điểm lần 1" : row.Cells[10].Value.ToString();
                    DateTime ngay_chot = Convert.ToDateTime(row.Cells[11].Value.ToString());
                    if (_masv != null && _masv != "")
                    {
                        btn_save.Enabled = true;
                        GanDuLieuMacDinhChoComboboxLopHoc(_lop);
                        GanDuLieuMacDinhChoComboboxNghanhHoc(_nghanh);
                        GanDuLieuMacDinhChoComboboxMonHoc(ma_mh);
                        txt_masv.Text = ma_sv;
                        txt_tenmh.Text = ten_mh;
                        txt_tensv.Text = ten_sv;
                        txt_diemqt1.Text = diem_qt1;
                        txt_diemqt2.Text = diem_qt2 == "Lấy điểm lần 1" ? "0" : txt_diemqt2.Text;
                        txt_diemthi1.Text = diem_thi1;
                        txt_diemthi2.Text = diem_thi2 == "Lấy điểm lần 1" ? "0" : txt_diemqt2.Text;
                        dpk_ngayketthuc.Value = ngay_chot;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra với hệ thống vui lòng thử lại sau", "Thông báo");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LayTatCaMonHoc();
            LayDuLieuCuaLopHocHoc();
            LayDuLieuCuaNghanhHoc();
            txt_diemqt1.Text = "0";
            txt_diemqt2.Text = "0";
            txt_diemthi1.Text = "0";
            txt_diemthi2.Text = "0";
            updateOrAdd = true;
        }

        private void cb_monhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valueMonhoc = (MonHocModel)cb_monhoc.SelectedItem;
            txt_tenmh.Text = valueMonhoc.ten_monhoc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_masv != "" && _masv != null)
            {
                int result = _diemDao.XoaDiemQuaMaSvVaMaMonHoc(_masv, _mamh);
                if (result == 1)
                {
                    MessageBox.Show("Xóa điểm thành công", "Thông báo");
                    LayDuLieuDiemCuaSv();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra với hệ thống vui lòng thử lại sau", "Thông báo");
                }
            }
        }
    }
}
