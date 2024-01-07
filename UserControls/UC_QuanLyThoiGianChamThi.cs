using ProjectManage.Common;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterAndPower.Common;
using WaterAndPower.Dao;
using WaterAndPower.Forms.ThietLapThoiGianChamThi;
using WaterAndPower.Forms.ThietLapThoiGianThi;
using WaterAndPower.Model;

namespace WaterAndPower.UserControls
{
    public partial class UC_QuanLyThoiGianChamThi : UserControl
    {
        private ThietLapThoiGianChamThiDao _thietLapThoiGianChamThiDao;
        private List<ThoiGianChamThiModel> studentScoreModels = new List<ThoiGianChamThiModel>();
        private int _id = 0;
        public UC_QuanLyThoiGianChamThi(int Height, int Width)
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
            _thietLapThoiGianChamThiDao = new ThietLapThoiGianChamThiDao(ConnectionString.connectionStr);
            LoadDataTimeExams();
        }

        /// <summary>
        /// Load dữ liệu lên datagridview
        /// </summary>
        public void LoadDataTimeExams(string ten_monhoc = null)
        {
            dataGridView1.Rows.Clear();
            studentScoreModels = _thietLapThoiGianChamThiDao.LayTatCaThoiGianChamThiCuaMonHoc(ten_monhoc);
            if (studentScoreModels != null && studentScoreModels.Count > 0)
            {
                try
                {
                    foreach (var item in studentScoreModels)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dataGridView1);
                        newRow.Cells[0].Value = item.id;
                        newRow.Cells[1].Value = item.id_hocky;
                        newRow.Cells[2].Value = item.id_nghanh;
                        newRow.Cells[3].Value = item.ma_monhoc;
                        newRow.Cells[4].Value = item.ten_monhoc;
                        newRow.Cells[5].Value = item.ngay_cham;
                        newRow.Cells[6].Value = item.ngay_ket_thuc;
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

        /// <summary>
        /// chọn bản ghi muốn gán thời gian ra đề thi, chấm thi hoặc xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                try
                {
                    btn_delete.Enabled = true;
                    btn_edit.Enabled = true;
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    _id = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra với hệ thống vui lòng thử lại sau", "Thông báo");
                }
            }
        }

        /// <summary>
        /// Xóa bản ghi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                int result = _thietLapThoiGianChamThiDao.XoaThoiGianChamThiQuaId(_id);
                if (result == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadDataTimeExams();
                }
            }
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id_hocky = row.Cells[1].Value.ToString();
                string id_nghanh = row.Cells[2].Value.ToString();
                string ma_monhoc = row.Cells[3].Value.ToString();
                string ten_monhoc = row.Cells[4].Value.ToString();
                DateTime ngay_cham = Convert.ToDateTime(row.Cells[5].Value.ToString());
                DateTime ngay_ketthuc = Convert.ToDateTime(row.Cells[6].Value.ToString());
                using (Form_SuaThoiGianChamThi wd = new Form_SuaThoiGianChamThi(_id, id_hocky, id_nghanh, ma_monhoc, ten_monhoc, ngay_cham, ngay_ketthuc))
                {
                    wd.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataTimeExams(txtSearch.Text);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            LoadDataTimeExams();
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

            dataTable.Columns.Add("Hoc ky");
            dataTable.Columns.Add("Ma Nghanh");
            dataTable.Columns.Add("Ma Mon Hoc");
            dataTable.Columns.Add("Ten Mon Hoc");
            dataTable.Columns.Add("Ngay Thi");
            dataTable.Columns.Add("Ngay Ket Thuc");

            dataTable = ListExtension.AddDataToDatatable(studentScoreModels, dataTable);
            pdfGrid.DataSource = dataTable;
            // Định dạng bảng
            // Sự kiện để tùy chỉnh kiểu của từng ô cụ thể
            pdfGrid.BeginCellLayout += PdfGrid_BeginCellLayout;

            pdfGrid.Draw(page, new PointF(10, 10));
            MemoryStream stream = new MemoryStream();
            //Save the document
            document.Save("QuanLyThoiGianChamThi.pdf");
            //Close the document
            document.Close(true);
            System.Diagnostics.Process.Start("QuanLyThoiGianChamThi.pdf");
        }

        private static void PdfGrid_BeginCellLayout(object sender, PdfGridBeginCellLayoutEventArgs args)
        {
            // Đặt font cho ô trong bảng
            args.Style.Font = new PdfTrueTypeFont(new Font("Arial Unicode MS", 12), true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadDataTimeExams(txtSearch.Text);
        }
    }
}
