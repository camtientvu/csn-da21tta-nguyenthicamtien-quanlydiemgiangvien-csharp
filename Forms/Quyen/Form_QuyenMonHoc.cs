using ProjectManage.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WaterAndPower.Common;
using WaterAndPower.Dao;
using WaterAndPower.Model;
using WaterAndPower.UserControls;

namespace WaterAndPower.Forms.Quyen
{
    public partial class Form_QuyenMonHoc : Form
    {
        private QuyenHeThongDao _quyenHeThongDao;
        private QuyenMonHocDao _quyenMonHocDao;
        private MonHocDao _monhocDao;
        private List<MonHocModel> _monHocModel;
        private List<QuyenHeThongDaGanModel> _quyenHTTaiKhoanModel;
        private List<QuyenHeThongModel> _quyenHeThongModel;
        private string _idtaikhoan = "";
        private string _idmonhoc = "";

        public Form_QuyenMonHoc(string id_taikhoan)
        {
            InitializeComponent();
            _quyenHeThongDao = new QuyenHeThongDao(ConnectionString.connectionStr);
            _quyenMonHocDao = new QuyenMonHocDao(ConnectionString.connectionStr);
            _monhocDao = new MonHocDao(ConnectionString.connectionStr);
            _monHocModel = new List<MonHocModel>();
            _quyenHTTaiKhoanModel = new List<QuyenHeThongDaGanModel>();
            _quyenHeThongModel = new List<QuyenHeThongModel>();
            _idtaikhoan = id_taikhoan;
            LayTatCaCacQuyenCuaTaiKhoan("");
        }

        public void LayTatCaCacQuyenCuaTaiKhoan(string code)
        {
            dataGridView1.Rows.Clear();
            if(_quyenHeThongModel.Count > 0)
            {
                _quyenHeThongModel.Clear();
            }
            if (_quyenHTTaiKhoanModel.Count > 0)
            {
                _quyenHTTaiKhoanModel.Clear();
            }
            if (_monHocModel.Count > 0)
            {
                _monHocModel.Clear();
            }

            _monHocModel = _monhocDao.LayTatCaMonHocTheoIdTaikhoan(_idtaikhoan);
            try
            {
                foreach (var item in _monHocModel)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = item.ma_monhoc;
                    newRow.Cells[1].Value = item.ten_monhoc;
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
            var checkBoxes = groupBox2.Controls.OfType<CheckBox>();
            foreach (CheckBox rb in checkBoxes)
            {
                bool state = rb.Checked;
                string code = "";
                if (rb.Text == "ADD")
                {
                    code = "ADD";
                }
                if (rb.Text == "READ")
                {
                    code = "READ";
                }
                if (rb.Text == "VIEW")
                {
                    code = "VIEW";
                }
                if (rb.Text == "EDIT")
                {
                    code = "EDIT";
                }
                if (rb.Text == "DELETE")
                {
                    code = "DELETE";
                }
                var idquyen = _quyenMonHocDao.LayTatCaQuyenTheoMaCode(code);
                if (state == true)
                {
                    
                    bool isExist = _quyenMonHocDao.KiemTraQuyenCuaTaiKhoanTheoIdTaiKhoanVaIdQuyen(_idtaikhoan, idquyen);
                    if (!isExist)
                    {
                        int resultInsert = _quyenMonHocDao.GanQuyenMonHocChoTaiKhoan(idquyen ,_idmonhoc , _idtaikhoan);
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
                    int resultDelete = _quyenMonHocDao.XoaQuyenCuaMonHocTheoIdTaiKhoanVaIdQuyen(_idtaikhoan, idquyen);
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
            if(isSuccess)
            {
                MessageBox.Show("Cập nhập quyền thành công", "Thông báo");
                LayTatCaCacQuyenCuaTaiKhoan("");
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

        public void LayDuLieuKhiCheckBox(string code = "")
        {
            dataGridView1.Rows.Clear();
            if (code != "")
            {
                foreach (var item in _quyenHTTaiKhoanModel)
                {
                    if(item.code.Contains(code))
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dataGridView1);
                        newRow.Cells[0].Value = item.id;
                        newRow.Cells[1].Value = item.ten_quyen;
                        newRow.Cells[2].Value = item.trang_thai;
                        dataGridView1.Rows.Add(newRow);
                    }
                }
            }
            else
            {
                foreach (var item in _quyenHTTaiKhoanModel)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = item.id;
                    newRow.Cells[1].Value = item.ten_quyen;
                    newRow.Cells[2].Value = item.trang_thai;
                    dataGridView1.Rows.Add(newRow);
                }
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
                    if (_idmonhoc != null && _idmonhoc != "")
                    {
                        _quyenHeThongModel = _quyenHeThongDao.LayTatCaQuyenMonhocTheoIdTaiKhoanVaIdMonhoc(_idtaikhoan, _idmonhoc);
                        foreach (var item in _quyenHeThongModel)
                        {
                            if(item.code == "ADD")
                            {
                                ckb_add.Checked = true; 
                            }
                            if (item.code == "READ")
                            {
                                ckb_read.Checked = true;
                            }
                            if (item.code == "VIEW")
                            {
                                ckb_view.Checked = true;
                            }
                            if (item.code == "EDIT")
                            {
                                ckb_edit.Checked = true;
                            }
                            if (item.code == "DELETE")
                            {
                                ckb_delete.Checked = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra với hệ thống vui lòng thử lại sau", "Thông báo");
                }
            }
        }
    }
}
