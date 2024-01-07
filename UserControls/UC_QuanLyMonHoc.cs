using ProjectManage.Common;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WaterAndPower.Common;
using WaterAndPower.Dao;
using WaterAndPower.Forms.MonHoc;
using WaterAndPower.Forms.ThietLapThoiGianChamThi;
using WaterAndPower.Forms.ThietLapThoiGianThi;
using WaterAndPower.Model;

namespace WaterAndPower.UserControls
{
    public partial class UC_QuanLyMonHoc : UserControl
    {
        private DiemDao _scoreDao;
        private MonHocDao _subjectDao;
        private NghanhHocVaLopHocDao _majorDao;
        private ThietLapThoiGianThiDao _examTimeDao;
        private ThietLapThoiGianChamThiDao _examinationTimeDao;
        private List<MonHocModel> studentScoreModels = new List<MonHocModel>();
        private List<MonHocModel> monHocTaiKhoanModel = new List<MonHocModel>();
        private string ma_mohoc = "";
        private string _idtaikhoan = "";
        public UC_QuanLyMonHoc(int Height, int Width, string idtaikhoan)
        {
            this.Height = Height;
            this.Width = Width;
            InitializeComponent();
            panel1.Height = Height;
            panel1.Width = Width;
            _idtaikhoan = idtaikhoan;
            dataGridView1.Width = Width;
            dataGridView1.Height = Height;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_examtime.Enabled = false;
            btn_examinationtime.Enabled = false;
            //Khởi tạo đối tượng để kết nối sql (DAO)
            _scoreDao = new DiemDao(ConnectionString.connectionStr);
            _majorDao = new NghanhHocVaLopHocDao(ConnectionString.connectionStr);
            _examTimeDao = new ThietLapThoiGianThiDao(ConnectionString.connectionStr);
            _examinationTimeDao = new ThietLapThoiGianChamThiDao(ConnectionString.connectionStr);
            _subjectDao = new MonHocDao(ConnectionString.connectionStr);
            LayTatCaMonHoc();
            DoDuLieuVaoCombobox();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            using (Form_ThemMonHoc wd = new Form_ThemMonHoc())
            {
                wd.ShowDialog();
            }
        }

        /// <summary>
        /// Load dữ liệu lên datagridview
        /// </summary>
        public void LayTatCaMonHoc(string ma_nghanh = null, string ten_monhoc = null)
        {
            dataGridView1.Rows.Clear();
            monHocTaiKhoanModel = _subjectDao.LayTatCaMonHocTheoIdTaikhoan(_idtaikhoan);
            studentScoreModels = _subjectDao.LayTatCaMonHoc(ma_nghanh, ten_monhoc);
             if (studentScoreModels != null && studentScoreModels.Count > 0)
            {
                try
                {
                    foreach (var item in studentScoreModels)
                    {
                        foreach (var studentScoreModel in monHocTaiKhoanModel)
                        {
                            if(item.ma_monhoc == studentScoreModel.ma_monhoc)
                            {
                                DataGridViewRow newRow = new DataGridViewRow();
                                newRow.CreateCells(dataGridView1);
                                newRow.Cells[0].Value = item.ma_nghanh;
                                newRow.Cells[1].Value = item.ten_nghanh;
                                newRow.Cells[2].Value = item.id_hocky;
                                newRow.Cells[3].Value = item.ma_monhoc;
                                newRow.Cells[4].Value = item.ten_monhoc;
                                newRow.Cells[5].Value = item.ngay_ket_thuc;
                                newRow.Cells[6].Value = _examTimeDao.KiemTraThoiGianThi(item.ma_monhoc).Count() > 0 ? "Đã thi" : "Chưa thi";
                                newRow.Cells[7].Value = _examinationTimeDao.KiemTraThoiGianChamThi(item.ma_monhoc).Count() > 0 ? "Đã chấm" : "Chưa chấm";
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
                    ma_mohoc = row.Cells[3].Value.ToString();
                    bool trang_thai_thi = row.Cells[6].Value.ToString() == "Đã thi" ? true : false;
                    bool trang_thai_cham = row.Cells[7].Value.ToString() == "Đã chấm" ? true : false;
                    if (!trang_thai_thi)
                    {
                        btn_examtime.Enabled = true;
                    }
                    else
                    {
                        btn_examtime.Enabled = false;
                    }

                    if (!trang_thai_cham)
                    {
                        btn_examinationtime.Enabled = true;
                    }
                    else
                    {
                        btn_examinationtime.Enabled = false;
                    }
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
            if (ma_mohoc != null && ma_mohoc != "")
            {
                DialogResult dialogResult = MessageBox.Show("Việc xóa môn học sẽ xóa các bản ghi liên quan trong hệ thống, bạn có chắc muốn xóa bản ghi này?",
                    "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool success = true;
                    //Xóa các bản ghi liên quan trong bảng điểm
                    int deleteScores = _scoreDao.XoaDiemQuaMaMonHoc(ma_mohoc);
                    if (deleteScores != 1)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra khi xóa môn học này vui lòng thử lại sau", "Thông báo");
                        success = false;
                    }

                    //Xóa các bản ghi liên quan trong bảng thời gian chấm thi
                    int deleteExamTimes = _examTimeDao.XoaThoiGianThiQuaIdMonHoc(ma_mohoc);
                    if (deleteExamTimes != 1)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra khi xóa môn học này vui lòng thử lại sau", "Thông báo");
                        success = false;
                    }

                    //Xóa các bản ghi liên quan trong bảng thời gian ra đề thi
                    int deleteTimeMarks = _examinationTimeDao.XoaThoiGianChamThiQuaIdMonHoc(ma_mohoc);
                    if (deleteExamTimes != 1)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra khi xóa môn học này vui lòng thử lại sau", "Thông báo");
                        success = false;
                    }
                    int result = _subjectDao.XoaMonHoc(ma_mohoc);

                    if (result == 1)
                    {
                        success = true;
                        if (success)
                        {
                            MessageBox.Show("Xóa môn học thành công", "Thông báo");
                            LayTatCaMonHoc();
                            btn_delete.Enabled = false;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Hàm load tất cả các nghành học lên combobox
        /// </summary>
        private void DoDuLieuVaoCombobox()
        {
            cb_nghanh.Items.Clear();
            NghanhHocModel major = new NghanhHocModel()
            {
                ma_nghanh = "-1",
                ten_nghanh = "--Chọn nghành--"
            };
            cb_nghanh.Items.Add(major);
            cb_nghanh.ValueMember = "ma_nghanh";
            cb_nghanh.DisplayMember = "ten_nghanh";
            List<NghanhHocModel> list = _majorDao.LayTatCaNghanhHoc();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    cb_nghanh.Items.Add(item);
                }
                cb_nghanh.SelectedIndex = 0;
            }
        }


        /// <summary>
        /// Sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (ma_mohoc != null && ma_mohoc != "")
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string ten_monhoc = row.Cells[3].Value.ToString();
                string id_nghanh = row.Cells[0].Value.ToString();
                string id_hocky = row.Cells[2].Value.ToString();
                DateTime ngay_ket_thuc = Convert.ToDateTime(row.Cells[5].Value.ToString());
                bool trang_thai_thi = row.Cells[6].Value.ToString() == "Chưa thi" ? false : true;
                bool trang_thai_cham = row.Cells[7].Value.ToString() == "Chưa chấm" ? false : true;
                using (Form_SuaMonHoc wd = new Form_SuaMonHoc(ma_mohoc, ten_monhoc, id_nghanh, id_hocky, trang_thai_thi, ngay_ket_thuc))
                {
                    wd.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            var value = (NghanhHocModel)cb_nghanh.SelectedItem;
            LayTatCaMonHoc(value.ma_nghanh, txtSearch.Text);
        }

        /// <summary>
        /// Lấy lại data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_load_Click(object sender, EventArgs e)
        {
            cb_nghanh.SelectedIndex = 0;
            txtSearch.Text = String.Empty;
            LayTatCaMonHoc();
        }


        /// <summary>
        /// Thiết lập thời gian thi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (ma_mohoc != null && ma_mohoc != "")
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                bool trang_thai_thi = row.Cells[6].Value.ToString() == "Chưa thi" ? false : true;
                string ma_monhoc = row.Cells[3].Value.ToString();
                string ten_monhoc = row.Cells[4].Value.ToString();
                string id_nghanh = row.Cells[0].Value.ToString();
                string id_hocky = row.Cells[2].Value.ToString();

                using (Form_ThietLapThoiGianThi wd = new Form_ThietLapThoiGianThi(ma_monhoc, ten_monhoc, id_nghanh, id_hocky, trang_thai_thi))
                {
                    wd.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Thiết lập thời gian chấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_examinationtime_Click(object sender, EventArgs e)
        {
            if (ma_mohoc != null && ma_mohoc != "")
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                bool trang_thai_cham = row.Cells[7].Value.ToString() == "Chưa chấm" ? false : true;
                string ma_monhoc = row.Cells[3].Value.ToString();
                string ten_monhoc = row.Cells[4].Value.ToString();
                string id_nghanh = row.Cells[0].Value.ToString();
                string id_hocky = row.Cells[2].Value.ToString();

                using (Form_ThietLapThoiGianChamThi wd = new Form_ThietLapThoiGianChamThi(ma_monhoc, ten_monhoc, id_nghanh, id_hocky, trang_thai_cham))
                {
                    wd.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Xuất pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            dataTable.Columns.Add("Ma Nghanh");
            dataTable.Columns.Add("Ten Nghanh");
            dataTable.Columns.Add("Hoc Ky");
            dataTable.Columns.Add("Ma Mon Hoc");
            dataTable.Columns.Add("Ten Mon Hoc");
            dataTable.Columns.Add("Ngay Ket Thuc");

            dataTable = ListExtension.AddDataToDatatable(studentScoreModels, dataTable);
            pdfGrid.DataSource = dataTable;
            // Định dạng bảng
            // Sự kiện để tùy chỉnh kiểu của từng ô cụ thể
            pdfGrid.BeginCellLayout += PdfGrid_BeginCellLayout;

            pdfGrid.Draw(page, new PointF(10, 10));
            MemoryStream stream = new MemoryStream();
            //Save the document
            document.Save("QuanLyMonHoc.pdf");
            //Close the document
            document.Close(true);
            System.Diagnostics.Process.Start("QuanLyMonHoc.pdf");
        }

        private static void PdfGrid_BeginCellLayout(object sender, PdfGridBeginCellLayoutEventArgs args)
        {
            // Đặt font cho ô trong bảng
            args.Style.Font = new PdfTrueTypeFont(new Font("Arial Unicode MS", 12), true);
        }
    }
}
