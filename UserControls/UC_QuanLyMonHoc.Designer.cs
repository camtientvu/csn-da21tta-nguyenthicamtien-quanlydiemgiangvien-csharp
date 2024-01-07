namespace WaterAndPower.UserControls
{
    partial class UC_QuanLyMonHoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QuanLyMonHoc));
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_nghanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_nghanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_kt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai_thi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai_cham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_nghanh = new System.Windows.Forms.ComboBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_examtime = new System.Windows.Forms.Button();
            this.btn_examinationtime = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(223, 0);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 57);
            this.btn_delete.TabIndex = 85;
            this.btn_delete.Text = "     Xóa";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(110, 0);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(109, 57);
            this.btn_edit.TabIndex = 82;
            this.btn_edit.Text = "     Sửa";
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(106, 57);
            this.btn_add.TabIndex = 81;
            this.btn_add.Text = "     Thêm";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1379, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 27);
            this.txtSearch.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1151, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 86;
            this.label5.Text = "Tìm kiếm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1692, 506);
            this.panel1.TabIndex = 89;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_nghanh,
            this.ten_nghanh,
            this.id_hocky,
            this.ma_mh,
            this.ten_mh,
            this.ngay_kt,
            this.trang_thai_thi,
            this.trang_thai_cham});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1692, 506);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ma_nghanh
            // 
            this.ma_nghanh.HeaderText = "Mã nghành";
            this.ma_nghanh.Name = "ma_nghanh";
            this.ma_nghanh.ReadOnly = true;
            // 
            // ten_nghanh
            // 
            this.ten_nghanh.HeaderText = "Tên nghành";
            this.ten_nghanh.Name = "ten_nghanh";
            this.ten_nghanh.ReadOnly = true;
            // 
            // id_hocky
            // 
            this.id_hocky.HeaderText = "Học kỳ";
            this.id_hocky.Name = "id_hocky";
            this.id_hocky.ReadOnly = true;
            // 
            // ma_mh
            // 
            this.ma_mh.HeaderText = "Mã môn học";
            this.ma_mh.Name = "ma_mh";
            this.ma_mh.ReadOnly = true;
            // 
            // ten_mh
            // 
            this.ten_mh.HeaderText = "Tên môn học";
            this.ten_mh.Name = "ten_mh";
            this.ten_mh.ReadOnly = true;
            // 
            // ngay_kt
            // 
            this.ngay_kt.HeaderText = "Ngày kết thúc";
            this.ngay_kt.Name = "ngay_kt";
            this.ngay_kt.ReadOnly = true;
            // 
            // trang_thai_thi
            // 
            this.trang_thai_thi.HeaderText = "Trạng thái thi";
            this.trang_thai_thi.Name = "trang_thai_thi";
            this.trang_thai_thi.ReadOnly = true;
            // 
            // trang_thai_cham
            // 
            this.trang_thai_cham.HeaderText = "Trạng thái chấm";
            this.trang_thai_cham.Name = "trang_thai_cham";
            this.trang_thai_cham.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1554, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 57);
            this.button1.TabIndex = 90;
            this.button1.Text = "     Tìm kiếm";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_nghanh
            // 
            this.cb_nghanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_nghanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nghanh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nghanh.FormattingEnabled = true;
            this.cb_nghanh.Items.AddRange(new object[] {
            "Work Id",
            "Work Tilte",
            "Contractor Name",
            "CA Cost",
            "Work Done",
            "Amount Paid",
            "Now To be Paid",
            "Work to be Done"});
            this.cb_nghanh.Location = new System.Drawing.Point(1233, 18);
            this.cb_nghanh.Name = "cb_nghanh";
            this.cb_nghanh.Size = new System.Drawing.Size(140, 25);
            this.cb_nghanh.TabIndex = 91;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Image = ((System.Drawing.Image)(resources.GetObject("btn_load.Image")));
            this.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load.Location = new System.Drawing.Point(971, 0);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(158, 57);
            this.btn_load.TabIndex = 92;
            this.btn_load.Text = "     Load dữ liệu";
            this.btn_load.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Image = ((System.Drawing.Image)(resources.GetObject("btn_report.Image")));
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(808, 0);
            this.btn_report.Margin = new System.Windows.Forms.Padding(2);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(159, 57);
            this.btn_report.TabIndex = 93;
            this.btn_report.Text = "     Xuất báo cáo";
            this.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_examtime
            // 
            this.btn_examtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_examtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_examtime.FlatAppearance.BorderSize = 0;
            this.btn_examtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_examtime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examtime.ForeColor = System.Drawing.Color.White;
            this.btn_examtime.Image = ((System.Drawing.Image)(resources.GetObject("btn_examtime.Image")));
            this.btn_examtime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_examtime.Location = new System.Drawing.Point(331, 0);
            this.btn_examtime.Margin = new System.Windows.Forms.Padding(2);
            this.btn_examtime.Name = "btn_examtime";
            this.btn_examtime.Size = new System.Drawing.Size(223, 57);
            this.btn_examtime.TabIndex = 94;
            this.btn_examtime.Text = "      Thiết lập thời gian thi";
            this.btn_examtime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_examtime.UseVisualStyleBackColor = false;
            this.btn_examtime.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_examinationtime
            // 
            this.btn_examinationtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_examinationtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_examinationtime.FlatAppearance.BorderSize = 0;
            this.btn_examinationtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_examinationtime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examinationtime.ForeColor = System.Drawing.Color.White;
            this.btn_examinationtime.Image = ((System.Drawing.Image)(resources.GetObject("btn_examinationtime.Image")));
            this.btn_examinationtime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_examinationtime.Location = new System.Drawing.Point(558, 0);
            this.btn_examinationtime.Margin = new System.Windows.Forms.Padding(2);
            this.btn_examinationtime.Name = "btn_examinationtime";
            this.btn_examinationtime.Size = new System.Drawing.Size(246, 57);
            this.btn_examinationtime.TabIndex = 95;
            this.btn_examinationtime.Text = "     Thiết lập thời gian chấm";
            this.btn_examinationtime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_examinationtime.UseVisualStyleBackColor = false;
            this.btn_examinationtime.Click += new System.EventHandler(this.btn_examinationtime_Click);
            // 
            // UC_QuanLyMonHoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.btn_examinationtime);
            this.Controls.Add(this.btn_examtime);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.cb_nghanh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Name = "UC_QuanLyMonHoc";
            this.Size = new System.Drawing.Size(1700, 571);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_nghanh;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_examtime;
        private System.Windows.Forms.Button btn_examinationtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_nghanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_nghanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_hocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_kt;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai_thi;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai_cham;
    }
}
