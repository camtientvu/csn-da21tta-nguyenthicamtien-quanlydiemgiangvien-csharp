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

namespace WaterAndPower.Forms.Quyen
{
    public partial class Form_QuyenTaiKhoan : Form
    {
        private string _idtaikhoan = "";
        private QuyenHeThongDao _quyenHeThongDao;
        private List<QuyenHeThongModel> _quyenHeThongModels;
        private List<QuyenHeThongModel> _quyenHeThongDaGanTheoIdModels;
        private List<QuyenHeThongDaGanModel> _quyenHeThongDaGanModels;

        public Form_QuyenTaiKhoan(string idtaikhoan)
        {
            InitializeComponent();
            _quyenHeThongDao = new QuyenHeThongDao(ConnectionString.connectionStr);
            _idtaikhoan = idtaikhoan;
            _quyenHeThongModels = new List<QuyenHeThongModel>();
            _quyenHeThongDaGanTheoIdModels = new List<QuyenHeThongModel>();
            _quyenHeThongDaGanModels = new List<QuyenHeThongDaGanModel>();
            LayQuyenHeThongCuaTaiKhoanChoCheckbox();
        }

        private void LayQuyenHeThongCuaTaiKhoanChoCheckbox()
        {
            _quyenHeThongModels.Clear();
            _quyenHeThongDaGanTheoIdModels.Clear();
            _quyenHeThongDaGanModels.Clear();
            dataGridView1.Rows.Clear();
            _quyenHeThongModels = _quyenHeThongDao.LayTatCaQuyenHeThong();
            _quyenHeThongDaGanTheoIdModels = _quyenHeThongDao.LayTatCaQuyenHeThongTheoIdTaiKhoan(_idtaikhoan);
            foreach (var item in _quyenHeThongModels)
            {
                QuyenHeThongDaGanModel model = new QuyenHeThongDaGanModel()
                {
                    id = item.id,
                    ten_quyen = item.ten_quyen,
                    code = item.code,
                    trang_thai = false
                };
                _quyenHeThongDaGanModels.Add(model);
            }

            foreach (var item in _quyenHeThongDaGanTheoIdModels)
            {
                var result = _quyenHeThongDaGanModels.FirstOrDefault(x => x.id == item.id);
                if (result != null)
                {
                    result.trang_thai = true;
                }
            }

            try
            {
                foreach (var item in _quyenHeThongDaGanModels)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = item.id;
                    newRow.Cells[1].Value = item.ten_quyen;
                    newRow.Cells[2].Value = item.trang_thai;
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
            bool isSuccess = false;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells[2].Value == true)
                {
                    bool isExist = _quyenHeThongDao.KiemTraQuyenCuaTaiKhoan(item.Cells[0].Value.ToString(), _idtaikhoan);
                    if (!isExist)
                    {
                        int resultInsert = _quyenHeThongDao.GanQuyenChoTaiKhoan(_idtaikhoan, item.Cells[0].Value.ToString());
                        if (resultInsert == 1)
                        {
                            isSuccess = true;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                    }
                }
                else
                {
                    int resultDelete = _quyenHeThongDao.XoaQuyenCuaTaiKhoan(item.Cells[0].Value.ToString(), _idtaikhoan);
                    if (resultDelete == 1)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }
                }
            }
            if (isSuccess)
            {
                MessageBox.Show("Cập nhập quyền thành công", "Thông báo");
                LayQuyenHeThongCuaTaiKhoanChoCheckbox();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xẩy ra với hệ thống. Vui lòng thử lại sau", "Thông báo");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _quyenHeThongDao.Dispose();
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            frm.XuLyQuyenCuaTaiKhoan();
            var uc = (UC_TaiKhoanQuyen)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayDuLieuTaiKhoan();
            }
        }

        private void Form_QuyenTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            _quyenHeThongDao.Dispose();
            this.Close();
            Form_TrangChu frm = Application.OpenForms.OfType<Form_TrangChu>().FirstOrDefault();
            frm.XuLyQuyenCuaTaiKhoan();
            var uc = (UC_TaiKhoanQuyen)frm.ActiveControl;
            if (uc != null)
            {
                uc.LayDuLieuTaiKhoan();
            }
        }
    }
}
