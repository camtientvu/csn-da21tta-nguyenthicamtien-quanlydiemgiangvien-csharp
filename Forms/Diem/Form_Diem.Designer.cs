namespace WaterAndPower.Forms.Diem
{
    partial class Form_Diem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Diem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_nghanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_qt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_qt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_thi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_thi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_chot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dpk_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.txt_tenmh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_diemqt1 = new System.Windows.Forms.TextBox();
            this.txt_diemqt2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_diemthi1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_diemthi2 = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label_lop = new System.Windows.Forms.Label();
            this.label_nghanh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tensv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_monhoc = new System.Windows.Forms.ComboBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.cb_nghanh = new System.Windows.Forms.ComboBox();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 566);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách điểm quá trình";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ma_nghanh,
            this.ma_lop,
            this.ma_sv,
            this.ten_sv,
            this.ma_mh,
            this.ten_mh,
            this.diem_qt1,
            this.diem_qt2,
            this.diem_thi1,
            this.diem_thi2,
            this.ngay_chot});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1068, 541);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ma_nghanh
            // 
            this.ma_nghanh.HeaderText = "Nghành học";
            this.ma_nghanh.Name = "ma_nghanh";
            this.ma_nghanh.Width = 90;
            // 
            // ma_lop
            // 
            this.ma_lop.HeaderText = "Mã lớp";
            this.ma_lop.Name = "ma_lop";
            this.ma_lop.Width = 80;
            // 
            // ma_sv
            // 
            this.ma_sv.HeaderText = "Mã sinh viên";
            this.ma_sv.Name = "ma_sv";
            this.ma_sv.Width = 95;
            // 
            // ten_sv
            // 
            this.ten_sv.HeaderText = "Tên sinh viên";
            this.ten_sv.Name = "ten_sv";
            // 
            // ma_mh
            // 
            this.ma_mh.HeaderText = "Mã môn học";
            this.ma_mh.Name = "ma_mh";
            this.ma_mh.Width = 90;
            // 
            // ten_mh
            // 
            this.ten_mh.HeaderText = "Tên môn học";
            this.ten_mh.Name = "ten_mh";
            this.ten_mh.Width = 95;
            // 
            // diem_qt1
            // 
            this.diem_qt1.HeaderText = "Điểm QT 1";
            this.diem_qt1.Name = "diem_qt1";
            this.diem_qt1.Width = 85;
            // 
            // diem_qt2
            // 
            this.diem_qt2.HeaderText = "Điểm QT 2";
            this.diem_qt2.Name = "diem_qt2";
            this.diem_qt2.Width = 85;
            // 
            // diem_thi1
            // 
            this.diem_thi1.HeaderText = "Điểm thi lần 1";
            this.diem_thi1.Name = "diem_thi1";
            this.diem_thi1.Width = 95;
            // 
            // diem_thi2
            // 
            this.diem_thi2.HeaderText = "Điểm thi lần 2";
            this.diem_thi2.Name = "diem_thi2";
            this.diem_thi2.Width = 95;
            // 
            // ngay_chot
            // 
            this.ngay_chot.HeaderText = "Ngày chốt";
            this.ngay_chot.Name = "ngay_chot";
            this.ngay_chot.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 144;
            this.label2.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 143;
            this.label4.Text = "Mã môn học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 142;
            this.label6.Text = "Tên môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 149;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // dpk_ngayketthuc
            // 
            this.dpk_ngayketthuc.Location = new System.Drawing.Point(172, 330);
            this.dpk_ngayketthuc.Name = "dpk_ngayketthuc";
            this.dpk_ngayketthuc.Size = new System.Drawing.Size(207, 20);
            this.dpk_ngayketthuc.TabIndex = 150;
            // 
            // txt_tenmh
            // 
            this.txt_tenmh.Location = new System.Drawing.Point(172, 177);
            this.txt_tenmh.Name = "txt_tenmh";
            this.txt_tenmh.Size = new System.Drawing.Size(207, 20);
            this.txt_tenmh.TabIndex = 152;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 22);
            this.label7.TabIndex = 154;
            this.label7.Text = "Điểm quá trình 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 153;
            this.label1.Text = "Điểm quá trình 2";
            // 
            // txt_diemqt1
            // 
            this.txt_diemqt1.Location = new System.Drawing.Point(172, 209);
            this.txt_diemqt1.Name = "txt_diemqt1";
            this.txt_diemqt1.Size = new System.Drawing.Size(207, 20);
            this.txt_diemqt1.TabIndex = 156;
            // 
            // txt_diemqt2
            // 
            this.txt_diemqt2.Location = new System.Drawing.Point(172, 240);
            this.txt_diemqt2.Name = "txt_diemqt2";
            this.txt_diemqt2.Size = new System.Drawing.Size(207, 20);
            this.txt_diemqt2.TabIndex = 158;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 159;
            this.label9.Text = "Điểm thi lần 1";
            // 
            // txt_diemthi1
            // 
            this.txt_diemthi1.Location = new System.Drawing.Point(172, 271);
            this.txt_diemthi1.Name = "txt_diemthi1";
            this.txt_diemthi1.Size = new System.Drawing.Size(207, 20);
            this.txt_diemthi1.TabIndex = 160;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 22);
            this.label8.TabIndex = 161;
            this.label8.Text = "Điểm thi lần 2";
            // 
            // txt_diemthi2
            // 
            this.txt_diemthi2.Location = new System.Drawing.Point(172, 301);
            this.txt_diemthi2.Name = "txt_diemthi2";
            this.txt_diemthi2.Size = new System.Drawing.Size(207, 20);
            this.txt_diemthi2.TabIndex = 162;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(195, 518);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(186, 41);
            this.btn_back.TabIndex = 163;
            this.btn_back.Text = "     Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(6, 518);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(184, 41);
            this.btn_save.TabIndex = 164;
            this.btn_save.Text = "     Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label_lop
            // 
            this.label_lop.AutoSize = true;
            this.label_lop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lop.ForeColor = System.Drawing.Color.White;
            this.label_lop.Location = new System.Drawing.Point(15, 57);
            this.label_lop.Name = "label_lop";
            this.label_lop.Size = new System.Drawing.Size(43, 22);
            this.label_lop.TabIndex = 165;
            this.label_lop.Text = "Lớp";
            // 
            // label_nghanh
            // 
            this.label_nghanh.AutoSize = true;
            this.label_nghanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nghanh.ForeColor = System.Drawing.Color.White;
            this.label_nghanh.Location = new System.Drawing.Point(15, 29);
            this.label_nghanh.Name = "label_nghanh";
            this.label_nghanh.Size = new System.Drawing.Size(74, 22);
            this.label_nghanh.TabIndex = 167;
            this.label_nghanh.Text = "Nghành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 169;
            this.label3.Text = "Tên sinh viên";
            // 
            // txt_tensv
            // 
            this.txt_tensv.Location = new System.Drawing.Point(172, 116);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(207, 20);
            this.txt_tensv.TabIndex = 170;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(195, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 41);
            this.button1.TabIndex = 175;
            this.button1.Text = "     Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(6, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 41);
            this.button2.TabIndex = 176;
            this.button2.Text = "     Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_monhoc
            // 
            this.cb_monhoc.FormattingEnabled = true;
            this.cb_monhoc.Location = new System.Drawing.Point(172, 146);
            this.cb_monhoc.Name = "cb_monhoc";
            this.cb_monhoc.Size = new System.Drawing.Size(207, 21);
            this.cb_monhoc.TabIndex = 177;
            this.cb_monhoc.SelectedIndexChanged += new System.EventHandler(this.cb_monhoc_SelectedIndexChanged);
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(172, 57);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(207, 21);
            this.cb_lop.TabIndex = 179;
            // 
            // cb_nghanh
            // 
            this.cb_nghanh.FormattingEnabled = true;
            this.cb_nghanh.Location = new System.Drawing.Point(172, 30);
            this.cb_nghanh.Name = "cb_nghanh";
            this.cb_nghanh.Size = new System.Drawing.Size(207, 21);
            this.cb_nghanh.TabIndex = 180;
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(172, 89);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(207, 20);
            this.txt_masv.TabIndex = 181;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_masv);
            this.groupBox2.Controls.Add(this.cb_nghanh);
            this.groupBox2.Controls.Add(this.cb_lop);
            this.groupBox2.Controls.Add(this.cb_monhoc);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_tensv);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_nghanh);
            this.groupBox2.Controls.Add(this.label_lop);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.btn_back);
            this.groupBox2.Controls.Add(this.txt_diemthi2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_diemthi1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_diemqt2);
            this.groupBox2.Controls.Add(this.txt_diemqt1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_tenmh);
            this.groupBox2.Controls.Add(this.dpk_ngayketthuc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1098, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 565);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // Form_Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1497, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Diem";
            this.Text = "Form_Diem";
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Form_Diem_ControlAdded);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_nghanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_qt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_qt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_thi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_thi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_chot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpk_ngayketthuc;
        private System.Windows.Forms.TextBox txt_tenmh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_diemqt1;
        private System.Windows.Forms.TextBox txt_diemqt2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_diemthi1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_diemthi2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label_lop;
        private System.Windows.Forms.Label label_nghanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tensv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_monhoc;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.ComboBox cb_nghanh;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}