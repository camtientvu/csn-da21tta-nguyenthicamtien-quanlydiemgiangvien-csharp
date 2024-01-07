using Pharmonics19._1.Helpers;
using ProjectManage.Common;
using ProjectManage.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterAndPower.Common;

namespace WaterAndPower.Forms
{
    public partial class Form_DangNhap : Form
    {
        private DangNhapDao _dao;
        public Form_DangNhap()
        {
            InitializeComponent();
            _dao = new DangNhapDao(ConnectionString.connectionStr);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private bool isFormValid()
        {
            if (txtUserName.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để chống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool isLoginDetailsCorrect()
        {
            bool isExist = _dao.KiemTraTaiKhoanDangNhap(txtUserName.Text, MD5Extension.MD5Hash(txtPassword.Text));
            if (isExist)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                if (isLoginDetailsCorrect())
                {
                    string[] UserData = new string[2];
                    UserData[0] = txtUserName.Text;
                    UserData[1] = txtPassword.Text;
                    Helper.UserData = UserData;

                    using (Form_TrangChu fd = new Form_TrangChu())
                    {
                        fd.ShowDialog();
                    }
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact with System Administrator: info@csharpui.com","Forgot Password?",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void TxtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.BtnLogin_Click(sender, e);
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
