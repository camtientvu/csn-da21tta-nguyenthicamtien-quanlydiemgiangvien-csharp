using ProjectManage.Common;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WaterAndPower.Common;
using WaterAndPower.Dao;
using WaterAndPower.Forms.Quyen;
using WaterAndPower.Forms.TaiKhoan;
using WaterAndPower.Model;

namespace WaterAndPower.UserControls
{
    public partial class UC_TaiKhoanQuyen : UserControl
    {
        private QuyenHeThongDao _quyenHeThongDao;
        private TaiKhoanDao _taiKhoanDao;
        private List<TaiKhoanModel> _taiKhoanModel;
        private string _idtaikhoan = "";
        public UC_TaiKhoanQuyen(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
            InitializeComponent();
            panel1.Height = Height;
            panel1.Width = Width;
            dataGridView1.Width = Width;
            dataGridView1.Height = Height;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_xemquyen.Enabled = false;
            btn_ganmonhoctk.Enabled = false;
            btn_quyen.Enabled = false;
            _quyenHeThongDao = new QuyenHeThongDao(ConnectionString.connectionStr);
            _taiKhoanDao = new TaiKhoanDao(ConnectionString.connectionStr);
            LayDuLieuTaiKhoan();
        }

        public void LayDuLieuTaiKhoan()
        {
            dataGridView1.Rows.Clear();
            _taiKhoanModel = _taiKhoanDao.LayTatCaTaiKhoan(txtSearch.Text);
            if (_taiKhoanModel != null && _taiKhoanModel.Count > 0)
            {
                try
                {
                    foreach (var item in _taiKhoanModel)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dataGridView1);
                        newRow.Cells[0].Value = item.id;
                        newRow.Cells[1].Value = item.tai_khoan;
                        newRow.Cells[2].Value = item.mat_khau;
                        newRow.Cells[3].Value = item.email;
                        newRow.Cells[4].Value = item.ngay_tao;
                        newRow.Cells[5].Value = item.ngay_dangnhap_cuoicung;
                        newRow.Cells[6].Value = item.trang_thai;
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
                    _idtaikhoan = row.Cells[0].Value.ToString();
                    if (_idtaikhoan != null && _idtaikhoan != "")
                    {
                        btn_delete.Enabled = true;
                        btn_edit.Enabled = true;
                        btn_xemquyen.Enabled = true;
                        btn_ganmonhoctk.Enabled = true;
                        btn_quyen.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra với hệ thống vui lòng thử lại sau", "Thông báo");
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LayDuLieuTaiKhoan();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_idtaikhoan != null && _idtaikhoan != "")
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string tai_khoan = row.Cells[1].Value.ToString();
                string mat_khau = row.Cells[2].Value.ToString();
                string email = row.Cells[3].Value.ToString();
                DateTime ngay_tao = Convert.ToDateTime(row.Cells[4].Value.ToString());
                DateTime ngay_dang_nhap = Convert.ToDateTime(row.Cells[5].Value.ToString());
                bool trang_thai = row.Cells[6].Value.ToString() == "Hoạt động" ? false : true;
                using (Form_SuaTaiKhoan wd = new Form_SuaTaiKhoan(_idtaikhoan, tai_khoan, mat_khau, email, ngay_tao, ngay_dang_nhap, trang_thai))
                {
                    wd.ShowDialog();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_idtaikhoan != null && _idtaikhoan != "")
            {
                DialogResult dialogResult = MessageBox.Show("Việc xóa tài khoản sẽ xóa các bản ghi liên quan trong hệ thống, bạn có chắc muốn xóa bản ghi này?",
                   "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool check = false;
                    int delete_quyentaikhoan = _quyenHeThongDao.XoaQuyenCuaTaiKhoanTheoIdTaiKhoan(_idtaikhoan);
                    if (delete_quyentaikhoan == 1)
                    {
                        check = true;
                    }

                    if (check)
                    {
                        int result = _taiKhoanDao.XoaTaiKhoan(_idtaikhoan);
                        if (result == 1)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo");
                            LayDuLieuTaiKhoan();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại.", "Thông báo");
                    }
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (Form_ThemTaiKhoan wd = new Form_ThemTaiKhoan())
            {
                wd.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LayDuLieuTaiKhoan();
        }

        private void btn_xemdiemquatrinh_Click(object sender, EventArgs e)
        {
            if (_idtaikhoan != null && _idtaikhoan != "")
            {
                using (Form_QuyenMonHoc wd = new Form_QuyenMonHoc(_idtaikhoan))
                {
                    wd.ShowDialog();
                }
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

            dataTable.Columns.Add("Ten Dang Nhap");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Ngay Tao");
            dataTable.Columns.Add("Ngay Dang Nhap Gan Day");
            dataTable.Columns.Add("Trang Thai");

            dataTable = ListExtension.AddDataToDatatable(_taiKhoanModel, dataTable);
            pdfGrid.DataSource = dataTable;
            // Định dạng bảng
            // Sự kiện để tùy chỉnh kiểu của từng ô cụ thể
            pdfGrid.BeginCellLayout += PdfGrid_BeginCellLayout;

            pdfGrid.Draw(page, new PointF(10, 10));
            MemoryStream stream = new MemoryStream();
            //Save the document
            document.Save("QuanLyTaiKhoan.pdf");
            //Close the document
            document.Close(true);
            System.Diagnostics.Process.Start("QuanLyTaiKhoan.pdf");
        }

        private static void PdfGrid_BeginCellLayout(object sender, PdfGridBeginCellLayoutEventArgs args)
        {
            // Đặt font cho ô trong bảng
            args.Style.Font = new PdfTrueTypeFont(new Font("Arial Unicode MS", 12), true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_idtaikhoan != null && _idtaikhoan != "")
            {
                using (Form_GanMonHocTaiKhoan wd = new Form_GanMonHocTaiKhoan(_idtaikhoan))
                {
                    wd.ShowDialog();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (_idtaikhoan != null && _idtaikhoan != "")
            {
                using (Form_QuyenTaiKhoan wd = new Form_QuyenTaiKhoan(_idtaikhoan))
                {
                    wd.ShowDialog();
                }
            }
        }
    }
}
