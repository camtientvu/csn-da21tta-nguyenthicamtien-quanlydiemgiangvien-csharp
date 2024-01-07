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
    public partial class Form_GanMonHocTaiKhoan : Form
    {
        private QuyenHeThongDao _quyenHeThongDao;
        private QuyenMonHocDao _quyenMonHocDao;
        private MonHocDao _monhocDao;
        private List<MonHocModel> _monHocModel;
        private List<MonHocModel> _tatCaMonHocModel;
        private List<QuyenMonHocDaGan> _quyenMonHocDaGanModel;
        private List<QuyenHeThongModel> _tatCaQuyenMonHocModel;
        private List<string> _monhocquyen;
        private string _idtaikhoan = "";
        private string _idmonhoc = "";
        private string _tenmonhoc = "";
        private bool _trangthai = false;

        public Form_GanMonHocTaiKhoan(string idtaikhoan)
        {
            InitializeComponent();
            _quyenHeThongDao = new QuyenHeThongDao(ConnectionString.connectionStr);
            _monhocDao = new MonHocDao(ConnectionString.connectionStr);
            _quyenMonHocDao = new QuyenMonHocDao(ConnectionString.connectionStr);
            _monHocModel = new List<MonHocModel>();
            _tatCaMonHocModel = new List<MonHocModel>();
            _monhocquyen = new List<string>();
            _quyenMonHocDaGanModel = new List<QuyenMonHocDaGan>();
            _tatCaQuyenMonHocModel = new List<QuyenHeThongModel>();
            _idtaikhoan = idtaikhoan;
            LayDuLieuMonHocDaGanTaiKhoan();
        }

        private void LayDuLieuMonHocDaGanTaiKhoan()
        {
            dataGridView1.Rows.Clear();
            _monHocModel.Clear();
            _tatCaMonHocModel.Clear();
            _quyenMonHocDaGanModel.Clear();
            _tatCaQuyenMonHocModel.Clear();
            if (_monHocModel.Count > 0)
            {
                _monHocModel.Clear();
            }
            _monHocModel = _monhocDao.LayTatCaMonHocTheoIdTaikhoan(_idtaikhoan);
            _tatCaMonHocModel = _monhocDao.LayTatCaMonHoc();
            foreach (var monhoc in _tatCaMonHocModel)
            {
                QuyenMonHocDaGan model = new QuyenMonHocDaGan()
                {
                    mamonhoc = monhoc.ma_monhoc,
                    tenmonhoc = monhoc.ten_monhoc,
                    trangthaigan = false
                };
                _quyenMonHocDaGanModel.Add(model);
            }

            foreach (var item in _monHocModel)
            {
                var result = _quyenMonHocDaGanModel.FirstOrDefault(x => x.mamonhoc == item.ma_monhoc);
                if(result != null)
                {
                    result.trangthaigan = true;
                }
            }

            try
            {
                foreach (var item in _quyenMonHocDaGanModel)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = item.mamonhoc;
                    newRow.Cells[1].Value = item.tenmonhoc;
                    newRow.Cells[2].Value = item.trangthaigan;
                    dataGridView1.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu trong hệ thống", "Thông báo");
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int result = 0;
            _tatCaQuyenMonHocModel = _quyenHeThongDao.LayTatCaQuyenMonHoc();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var idmonhoc = row.Cells[0].Value.ToString();
                var lua_chon = Convert.ToBoolean(row.Cells[2].Value);
                if(lua_chon)
                {
                    if (!_quyenMonHocDao.KiemTraQuyenCuaTaiKhoan(_idtaikhoan, idmonhoc))
                    {
                        foreach (var item in _tatCaQuyenMonHocModel)
                        {
                            result = _quyenMonHocDao.GanQuyenMonHocChoTaiKhoan(item.id, idmonhoc, _idtaikhoan);
                        }
                    }
                }
                else
                {
                    result = _quyenMonHocDao.XoaQuyenCuaMonHocTheoIdTaiKhoan(_idtaikhoan, idmonhoc);
                }
            }
            if (result == 1)
            {
                MessageBox.Show("Gán môn học cho tài khoản thành công.", "Thông báo");
                LayDuLieuMonHocDaGanTaiKhoan();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi gán vui lòng thử lại.", "Thông báo");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _quyenHeThongDao.Dispose();
            _monhocDao.Dispose();
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            var uc = (UC_TaiKhoanQuyen)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayDuLieuTaiKhoan();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    _idmonhoc = row.Cells[0].Value.ToString();
                    _tenmonhoc = row.Cells[1].Value.ToString();
                    _trangthai = Convert.ToBoolean(row.Cells[2].Value);
                    txt_tenmh.Text = _tenmonhoc;
                    txt_mamh.Text = _idmonhoc;
                    ckb_trangthai.Checked = _trangthai;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra với hệ thống vui lòng thử lại sau", "Thông báo");
                }
            }
        }

        private void Form_GanMonHocTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            _quyenHeThongDao.Dispose();
            _monhocDao.Dispose();
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
