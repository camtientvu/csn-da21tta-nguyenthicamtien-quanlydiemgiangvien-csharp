namespace WaterAndPower.Forms.TaiKhoan
{
    partial class Form_SuaTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SuaTaiKhoan));
            this.ckb_trangthai = new System.Windows.Forms.CheckBox();
            this.dpk_ngaytao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_saveandupdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tendn = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.dpk_ngaydangnhap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ckb_trangthai
            // 
            this.ckb_trangthai.AutoSize = true;
            this.ckb_trangthai.Location = new System.Drawing.Point(285, 219);
            this.ckb_trangthai.Name = "ckb_trangthai";
            this.ckb_trangthai.Size = new System.Drawing.Size(15, 14);
            this.ckb_trangthai.TabIndex = 288;
            this.ckb_trangthai.UseVisualStyleBackColor = true;
            // 
            // dpk_ngaytao
            // 
            this.dpk_ngaytao.Location = new System.Drawing.Point(285, 159);
            this.dpk_ngaytao.Name = "dpk_ngaytao";
            this.dpk_ngaytao.Size = new System.Drawing.Size(207, 20);
            this.dpk_ngaytao.TabIndex = 286;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(128, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 283;
            this.label7.Text = "Email:";
            // 
            // btn_saveandupdate
            // 
            this.btn_saveandupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveandupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveandupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveandupdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveandupdate.ForeColor = System.Drawing.Color.Black;
            this.btn_saveandupdate.Image = ((System.Drawing.Image)(resources.GetObject("btn_saveandupdate.Image")));
            this.btn_saveandupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveandupdate.Location = new System.Drawing.Point(286, 287);
            this.btn_saveandupdate.Name = "btn_saveandupdate";
            this.btn_saveandupdate.Size = new System.Drawing.Size(153, 41);
            this.btn_saveandupdate.TabIndex = 281;
            this.btn_saveandupdate.Text = "     Lưu";
            this.btn_saveandupdate.UseVisualStyleBackColor = true;
            this.btn_saveandupdate.Click += new System.EventHandler(this.btn_saveandupdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(128, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 280;
            this.label5.Text = "Trạng thái:";
            // 
            // txt_tendn
            // 
            this.txt_tendn.Location = new System.Drawing.Point(285, 81);
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(207, 20);
            this.txt_tendn.TabIndex = 279;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(285, 107);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(207, 20);
            this.txt_matkhau.TabIndex = 278;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(445, 287);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(153, 41);
            this.btn_back.TabIndex = 277;
            this.btn_back.Text = "     Quay lại";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(128, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 274;
            this.label6.Text = "Ngày tạo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(128, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 275;
            this.label4.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(128, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 276;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(216, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 273;
            this.label1.Text = "Sửa thông tin tài khoản";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 272;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(604, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 324);
            this.panel4.TabIndex = 271;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 324);
            this.panel3.TabIndex = 270;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 10);
            this.panel2.TabIndex = 269;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 10);
            this.panel1.TabIndex = 268;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(285, 132);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(207, 20);
            this.txt_email.TabIndex = 293;
            // 
            // dpk_ngaydangnhap
            // 
            this.dpk_ngaydangnhap.Location = new System.Drawing.Point(285, 187);
            this.dpk_ngaydangnhap.Name = "dpk_ngaydangnhap";
            this.dpk_ngaydangnhap.Size = new System.Drawing.Size(207, 20);
            this.dpk_ngaydangnhap.TabIndex = 295;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(128, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 294;
            this.label3.Text = "Ngày đăng nhập:";
            // 
            // Form_SuaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 344);
            this.Controls.Add(this.dpk_ngaydangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.ckb_trangthai);
            this.Controls.Add(this.dpk_ngaytao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_saveandupdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tendn);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_SuaTaiKhoan";
            this.Text = "Form_SuaTaiKhoan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_SuaTaiKhoan_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckb_trangthai;
        private System.Windows.Forms.DateTimePicker dpk_ngaytao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_saveandupdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tendn;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.DateTimePicker dpk_ngaydangnhap;
        private System.Windows.Forms.Label label3;
    }
}