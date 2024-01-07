namespace WaterAndPower.Forms.SinhVien
{
    partial class Form_SuaSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SuaSinhVien));
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.cb_nghanh = new System.Windows.Forms.ComboBox();
            this.ckb_trangthai = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dpk_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.ckb_nu = new System.Windows.Forms.CheckBox();
            this.ckb_nam = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_saveandupdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.txt_tensv = new System.Windows.Forms.TextBox();
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
            this.dpk_ngaytao = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(285, 210);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(207, 21);
            this.cb_lop.TabIndex = 265;
            // 
            // cb_nghanh
            // 
            this.cb_nghanh.FormattingEnabled = true;
            this.cb_nghanh.Location = new System.Drawing.Point(285, 185);
            this.cb_nghanh.Name = "cb_nghanh";
            this.cb_nghanh.Size = new System.Drawing.Size(207, 21);
            this.cb_nghanh.TabIndex = 264;
            this.cb_nghanh.SelectedIndexChanged += new System.EventHandler(this.cb_nghanh_SelectedIndexChanged);
            // 
            // ckb_trangthai
            // 
            this.ckb_trangthai.AutoSize = true;
            this.ckb_trangthai.Location = new System.Drawing.Point(285, 271);
            this.ckb_trangthai.Name = "ckb_trangthai";
            this.ckb_trangthai.Size = new System.Drawing.Size(15, 14);
            this.ckb_trangthai.TabIndex = 263;
            this.ckb_trangthai.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(128, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 262;
            this.label8.Text = "Lớp học:";
            // 
            // dpk_ngaysinh
            // 
            this.dpk_ngaysinh.Location = new System.Drawing.Point(285, 159);
            this.dpk_ngaysinh.Name = "dpk_ngaysinh";
            this.dpk_ngaysinh.Size = new System.Drawing.Size(207, 20);
            this.dpk_ngaysinh.TabIndex = 261;
            // 
            // ckb_nu
            // 
            this.ckb_nu.AutoSize = true;
            this.ckb_nu.Location = new System.Drawing.Point(339, 136);
            this.ckb_nu.Name = "ckb_nu";
            this.ckb_nu.Size = new System.Drawing.Size(40, 17);
            this.ckb_nu.TabIndex = 260;
            this.ckb_nu.Text = "Nữ";
            this.ckb_nu.UseVisualStyleBackColor = true;
            this.ckb_nu.CheckedChanged += new System.EventHandler(this.ckb_nu_CheckedChanged);
            // 
            // ckb_nam
            // 
            this.ckb_nam.AutoSize = true;
            this.ckb_nam.Location = new System.Drawing.Point(285, 136);
            this.ckb_nam.Name = "ckb_nam";
            this.ckb_nam.Size = new System.Drawing.Size(48, 17);
            this.ckb_nam.TabIndex = 259;
            this.ckb_nam.Text = "Nam";
            this.ckb_nam.UseVisualStyleBackColor = true;
            this.ckb_nam.CheckedChanged += new System.EventHandler(this.ckb_nam_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(128, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 258;
            this.label7.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(128, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 257;
            this.label3.Text = "Nghành học:";
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
            this.btn_saveandupdate.Location = new System.Drawing.Point(379, 320);
            this.btn_saveandupdate.Name = "btn_saveandupdate";
            this.btn_saveandupdate.Size = new System.Drawing.Size(153, 41);
            this.btn_saveandupdate.TabIndex = 256;
            this.btn_saveandupdate.Text = "     Lưu";
            this.btn_saveandupdate.UseVisualStyleBackColor = true;
            this.btn_saveandupdate.Click += new System.EventHandler(this.btn_saveandupdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(128, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 255;
            this.label5.Text = "Trạng thái:";
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(285, 81);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(207, 20);
            this.txt_masv.TabIndex = 254;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Location = new System.Drawing.Point(285, 107);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(207, 20);
            this.txt_tensv.TabIndex = 253;
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
            this.btn_back.Location = new System.Drawing.Point(538, 320);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(153, 41);
            this.btn_back.TabIndex = 252;
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
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 249;
            this.label6.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(128, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 250;
            this.label4.Text = "Tên sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(128, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 251;
            this.label2.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(271, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 248;
            this.label1.Text = "Sửa thông tin sinh viên";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 247;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(697, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 357);
            this.panel4.TabIndex = 246;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 357);
            this.panel3.TabIndex = 245;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 10);
            this.panel2.TabIndex = 244;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 10);
            this.panel1.TabIndex = 243;
            // 
            // dpk_ngaytao
            // 
            this.dpk_ngaytao.Location = new System.Drawing.Point(285, 237);
            this.dpk_ngaytao.Name = "dpk_ngaytao";
            this.dpk_ngaytao.Size = new System.Drawing.Size(207, 20);
            this.dpk_ngaytao.TabIndex = 267;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(128, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 22);
            this.label9.TabIndex = 266;
            this.label9.Text = "Ngày nhập học";
            // 
            // Form_SuaSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 377);
            this.Controls.Add(this.dpk_ngaytao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_lop);
            this.Controls.Add(this.cb_nghanh);
            this.Controls.Add(this.ckb_trangthai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dpk_ngaysinh);
            this.Controls.Add(this.ckb_nu);
            this.Controls.Add(this.ckb_nam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_saveandupdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_masv);
            this.Controls.Add(this.txt_tensv);
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
            this.Name = "Form_SuaSinhVien";
            this.Text = "Form_SuaSinhVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_SuaSinhVien_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.ComboBox cb_nghanh;
        private System.Windows.Forms.CheckBox ckb_trangthai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpk_ngaysinh;
        private System.Windows.Forms.CheckBox ckb_nu;
        private System.Windows.Forms.CheckBox ckb_nam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_saveandupdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.TextBox txt_tensv;
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
        private System.Windows.Forms.DateTimePicker dpk_ngaytao;
        private System.Windows.Forms.Label label9;
    }
}