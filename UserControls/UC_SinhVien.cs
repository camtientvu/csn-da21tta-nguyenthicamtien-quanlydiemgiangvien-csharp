using ProjectManage.Common;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WaterAndPower.Common;
using WaterAndPower.Dao;
using WaterAndPower.Forms.Diem;
using WaterAndPower.Forms.SinhVien;
using WaterAndPower.Model;

namespace WaterAndPower.UserControls
{
    public partial class UC_SinhVien : UserControl
    {
        private SinhVienDao _sinhVienDao;
        private DiemDao _diemDao;
        private List<SinhVienModel> sinhVienModels;
        private string _id { get; set; }
        private string _lop { get; set; }
        private string _nghanh { get; set; }
        private string _tensv { get; set; }
        private QuyenHeThongDao _quyenHeThongDao;
        private QuyenMonHocDao _quyenMonHocao;
        private bool isView = false;
        private string _idtaikhoan = "";
        public UC_SinhVien(int Height, int Width, string idtaikhoan)
        {
            this.Height = Height;
            this.Width = Width;
            InitializeComponent();
            panel1.Height = Height;
            panel1.Width = Width;
            dataGridView1.Width = Width;
            dataGridView1.Height = Height;
            _idtaikhoan = idtaikhoan;
            _quyenHeThongDao = new QuyenHeThongDao(ConnectionString.connectionStr);
            _sinhVienDao = new SinhVienDao(ConnectionString.connectionStr);
            _diemDao = new DiemDao(ConnectionString.connectionStr);
            _quyenMonHocao = new QuyenMonHocDao(ConnectionString.connectionStr);
            XuLyQuyenCuaTaiKhoan();
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            LayDuLieuSinhVien();
        }

        private void XuLyQuyenCuaTaiKhoan()
        {
            Common.UserCommon.models = _quyenHeThongDao.LayTatCaQuyenHeThongTheoIdTaiKhoan(Common.UserCommon.id_taikhoan);
            var quyenMonHocModels = _quyenHeThongDao.LayTatCaQuyenMonHocTheoIdTaiKhoan(Common.UserCommon.id_taikhoan);
            btn_xemdiemquatrinh.Enabled = false;
            foreach (var model in quyenMonHocModels)
            {
                if (model.code.Contains("VIEW"))
                {
                    isView = true;
                }
            }
        }

        public void LayDuLieuSinhVien()
        {
            dataGridView1.Rows.Clear();
            sinhVienModels = _sinhVienDao.LayTatCaSinhVien(txtSearch.Text);
            if (sinhVienModels != null && sinhVienModels.Count > 0)
            {
                try
                {
                    foreach (var item in sinhVienModels)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dataGridView1);
                        newRow.Cells[0].Value = item.ma_sv;
                        newRow.Cells[1].Value = item.ten_sv;
                        newRow.Cells[2].Value = item.gioi_tinh;
                        newRow.Cells[3].Value = item.ngay_sinh;
                        newRow.Cells[4].Value = item.id_nghanh;
                        newRow.Cells[5].Value = item.id_lop;
                        newRow.Cells[6].Value = item.ngay_tao;
                        newRow.Cells[7].Value = item.trang_thai;
                        dataGridView1.Rows.Add(newRow);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    _id = row.Cells[0].Value.ToString();
                    _lop = row.Cells[5].Value.ToString();
                    _nghanh = row.Cells[4].Value.ToString();
                    _tensv = row.Cells[1].Value.ToString();
                    if (_id != null && _id != "")
                    {
                        btn_delete.Enabled = true;
                        btn_edit.Enabled = true;
                        if(isView)
                        {
                            btn_xemdiemquatrinh.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra với hệ thống vui lòng thử lại sau", "Thông báo");
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (Form_ThemMoiSinhVien wd = new Form_ThemMoiSinhVien())
            {
                wd.ShowDialog();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_id != null && _id != "")
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string ma_sv = row.Cells[0].Value.ToString();
                string ten_sv = row.Cells[1].Value.ToString();
                bool gioi_tinh = row.Cells[2].Value.ToString() == "Nam" ? true : false;
                DateTime ngay_sinh = Convert.ToDateTime(row.Cells[3].Value.ToString());
                string id_nghanh = row.Cells[4].Value.ToString();
                string id_lop = row.Cells[5].Value.ToString();
                DateTime ngay_nhap_hoc = Convert.ToDateTime(row.Cells[6].Value.ToString());
                bool trang_thai = row.Cells[7].Value.ToString() == "Đang học" ? true : false;
                using (Form_SuaSinhVien wd = new Form_SuaSinhVien(ma_sv, ten_sv, gioi_tinh, ngay_sinh, id_nghanh, id_lop, ngay_nhap_hoc, trang_thai))
                {
                    wd.ShowDialog();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_id != null && _id != "")
            {
                DialogResult dialogResult = MessageBox.Show("Việc xóa sinh viên này sẽ xóa các bản ghi liên quan trong hệ thống, bạn có chắc muốn xóa bản ghi này?",
                    "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool isSuccess = false;
                    // Xóa trong bảng điểm
                    int deleteScore = _diemDao.XoaDiemQuaMaSv(_id);
                    if (deleteScore == 1)
                    {
                        isSuccess = true;
                    }
                    
                    if (isSuccess)
                    {
                        int result = _sinhVienDao.XoaSinhVien(_id);
                        if (result == 1)
                        {
                            MessageBox.Show("Xóa bản ghi thành công", "Thông báo");
                            LayDuLieuSinhVien();
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra với hệ thống vui lòng thử lại sau", "Thông báo");
                        }
                    }
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            LayDuLieuSinhVien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form_Diem wd = new Form_Diem(_id, _lop,_nghanh,_tensv,Common.UserCommon.id_taikhoan))
            {
                wd.ShowDialog();
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();

            // Tạo một trang mới
            PdfPage page = document.Pages.Add();

            // Tạo một đối tượng PdfGraphics cho trang
            PdfGraphics graphics = page.Graphics;

            // Tạo đối tượng PdfGrid
            PdfGrid pdfGrid = new PdfGrid();
            //Create a DataTable
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Ma Sinh Vien");
            dataTable.Columns.Add("Ten Sinh Vien");
            dataTable.Columns.Add("Gioi Tinh");
            dataTable.Columns.Add("Ngay Sinh");
            dataTable.Columns.Add("Ma Nghanh");
            dataTable.Columns.Add("Ma Lop");
            dataTable.Columns.Add("Ngay Nhap Hoc");
            dataTable.Columns.Add("Trang Thai Hoc");

            dataTable = ListExtension.AddDataToDatatable(sinhVienModels, dataTable);
            pdfGrid.DataSource = dataTable;
            // Định dạng bảng
            // Sự kiện để tùy chỉnh kiểu của từng ô cụ thể
            pdfGrid.BeginCellLayout += PdfGrid_BeginCellLayout;

            pdfGrid.Draw(page, new PointF(10, 10));
            MemoryStream stream = new MemoryStream();
            //Save the document
            document.Save("QuanLySinhVien.pdf");
            //Close the document
            document.Close(true);
            System.Diagnostics.Process.Start("QuanLySinhVien.pdf");
        }

        private static void PdfGrid_BeginCellLayout(object sender, PdfGridBeginCellLayoutEventArgs args)
        {
            // Đặt font cho ô trong bảng
            args.Style.Font = new PdfTrueTypeFont(new Font("Arial Unicode MS", 12), true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LayDuLieuSinhVien();
        }
    }
}
