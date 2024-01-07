using Pharmonics19._1.Helpers;
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

namespace WaterAndPower.Forms
{
    public partial class Form_TrangChu : Form
    {
        int panelWidth;
        bool Hidden;
        private QuyenHeThongDao _quyenHeThongDao;
        private List<QuyenHeThongModel> models;
        public Form_TrangChu()
        {
            InitializeComponent();
            _quyenHeThongDao = new QuyenHeThongDao(ConnectionString.connectionStr);
            models = new List<QuyenHeThongModel>();
            XuLyQuyenCuaTaiKhoan();
            panelWidth = panelLeft.Width;
            Hidden = false;
            UC_TrangChu ass = new UC_TrangChu(panelContainer.Height, panelContainer.Width);
            addControls(ass);
        }

        public void XuLyQuyenCuaTaiKhoan()
        {
            Common.UserCommon.models = _quyenHeThongDao.LayTatCaQuyenHeThongTheoIdTaiKhoan(Common.UserCommon.id_taikhoan);
            models = _quyenHeThongDao.LayTatCaQuyenHeThongTheoIdTaiKhoan(Common.UserCommon.id_taikhoan);
            if(models.Count > 0)
            {
                btn_taikhoan.Enabled = false;
                btn_monhoc.Enabled = false;
                btn_sinhvien.Enabled = false;
                btn_thoigianradethi.Enabled = false;
                btn_thoigianchamthi.Enabled = false;
                var isAdmin = models.FirstOrDefault(x => x.code.Contains("ADMIN-SYS"));

                if (isAdmin == null)
                {
                    foreach (var model in models)
                    {
                        if (model.code.Contains("ACCOUNT-SYS"))
                        {
                            btn_taikhoan.Enabled = true;
                        }
                        if (model.code.Contains("SUBJECT-SYS"))
                        {
                            btn_monhoc.Enabled = true;
                        }
                        if (model.code.Contains("STUDENT-SYS"))
                        {
                            btn_sinhvien.Enabled = true;
                        }
                        if (model.code.Contains("TIME-SYS"))
                        {
                            btn_thoigianradethi.Enabled = true;
                            btn_thoigianchamthi.Enabled = true;
                        }
                    }
                }
                else
                {
                    btn_taikhoan.Enabled = true;
                    btn_monhoc.Enabled = true;
                    btn_sinhvien.Enabled = true;
                    btn_thoigianradethi.Enabled = true;
                    btn_thoigianchamthi.Enabled = true;
                }
            }
            else
            {
                btn_taikhoan.Enabled = false;
                btn_monhoc.Enabled = false;
                btn_sinhvien.Enabled = false;
                btn_thoigianradethi.Enabled = false;
                btn_thoigianchamthi.Enabled = false;
            }
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void slidePanel(Button btn)
        {
            panelSide.Height = btn.Height;
            panelSide.Top = btn.Top;
        }

        private void addControls(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }


        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Dashboard";
            slidePanel(btnDashboard);
            UC_TrangChu ass = new UC_TrangChu(panelContainer.Height, panelContainer.Width);
            addControls(ass);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 55)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void BtnJobs_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý môn học";
            slidePanel(btn_monhoc);
            UC_QuanLyMonHoc ass = new UC_QuanLyMonHoc(panelContainer.Height,panelContainer.Width, Common.UserCommon.id_taikhoan);
            addControls(ass);
        }

        private void BtnAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void BtnContractors_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý sinh viên";
            slidePanel(btn_sinhvien);
            UC_SinhVien ass = new UC_SinhVien(panelContainer.Height, panelContainer.Width, Common.UserCommon.id_taikhoan);
            addControls(ass);
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thời gian ra đề thi";
            slidePanel(btn_thoigianradethi);
            UC_QuanLyThoiGianThi ass = new UC_QuanLyThoiGianThi(panelContainer.Height, panelContainer.Width);
            addControls(ass);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thời gian chấm thi";
            slidePanel(btn_thoigianchamthi);
            UC_QuanLyThoiGianChamThi ass = new UC_QuanLyThoiGianChamThi(panelContainer.Height, panelContainer.Width);
            addControls(ass);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Settings";
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Tài khoản";
            slidePanel(btn_taikhoan);
            UC_TaiKhoanQuyen ass = new UC_TaiKhoanQuyen(panelContainer.Height, panelContainer.Width);
            addControls(ass);
        }
    }
}
