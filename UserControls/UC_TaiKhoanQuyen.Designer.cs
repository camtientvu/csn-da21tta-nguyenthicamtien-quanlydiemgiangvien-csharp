namespace WaterAndPower.UserControls
{
    partial class UC_TaiKhoanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TaiKhoanQuyen));
            this.btn_xemquyen = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_dangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mat_khau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_tao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lan_cuoi_dangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ganmonhoctk = new System.Windows.Forms.Button();
            this.btn_quyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xemquyen
            // 
            this.btn_xemquyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_xemquyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xemquyen.FlatAppearance.BorderSize = 0;
            this.btn_xemquyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xemquyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemquyen.ForeColor = System.Drawing.Color.White;
            this.btn_xemquyen.Image = ((System.Drawing.Image)(resources.GetObject("btn_xemquyen.Image")));
            this.btn_xemquyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xemquyen.Location = new System.Drawing.Point(602, 3);
            this.btn_xemquyen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xemquyen.Name = "btn_xemquyen";
            this.btn_xemquyen.Size = new System.Drawing.Size(213, 57);
            this.btn_xemquyen.TabIndex = 114;
            this.btn_xemquyen.Text = "     Xem quyền của tài khoản";
            this.btn_xemquyen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xemquyen.UseVisualStyleBackColor = false;
            this.btn_xemquyen.Click += new System.EventHandler(this.btn_xemdiemquatrinh_Click);
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
            this.btn_add.Location = new System.Drawing.Point(4, 3);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(106, 57);
            this.btn_add.TabIndex = 104;
            this.btn_add.Text = "     Thêm";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1197, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 27);
            this.txtSearch.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1115, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 107;
            this.label5.Text = "Tìm kiếm:";
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
            this.btn_delete.Location = new System.Drawing.Point(224, 2);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(110, 57);
            this.btn_delete.TabIndex = 106;
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
            this.btn_edit.Location = new System.Drawing.Point(114, 2);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(106, 57);
            this.btn_edit.TabIndex = 105;
            this.btn_edit.Text = "     Sửa";
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
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
            this.btn_report.Location = new System.Drawing.Point(338, 2);
            this.btn_report.Margin = new System.Windows.Forms.Padding(2);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(128, 57);
            this.btn_report.TabIndex = 112;
            this.btn_report.Text = "     Báo cáo";
            this.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
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
            this.btn_load.Location = new System.Drawing.Point(470, 3);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(128, 57);
            this.btn_load.TabIndex = 111;
            this.btn_load.Text = "     Load lại";
            this.btn_load.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
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
            this.button1.Location = new System.Drawing.Point(1372, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 57);
            this.button1.TabIndex = 110;
            this.button1.Text = "     Tìm kiếm";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten_dangnhap,
            this.mat_khau,
            this.email,
            this.ngay_tao,
            this.lan_cuoi_dangnhap,
            this.trang_thai});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1523, 506);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ma
            // 
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // ten_dangnhap
            // 
            this.ten_dangnhap.HeaderText = "Tên đăng nhập";
            this.ten_dangnhap.Name = "ten_dangnhap";
            this.ten_dangnhap.ReadOnly = true;
            // 
            // mat_khau
            // 
            this.mat_khau.HeaderText = "Mật khẩu";
            this.mat_khau.Name = "mat_khau";
            this.mat_khau.ReadOnly = true;
            this.mat_khau.Visible = false;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // ngay_tao
            // 
            this.ngay_tao.HeaderText = "Ngày tạo";
            this.ngay_tao.Name = "ngay_tao";
            this.ngay_tao.ReadOnly = true;
            // 
            // lan_cuoi_dangnhap
            // 
            this.lan_cuoi_dangnhap.HeaderText = "Ngày đăng nhập gần đây";
            this.lan_cuoi_dangnhap.Name = "lan_cuoi_dangnhap";
            this.lan_cuoi_dangnhap.ReadOnly = true;
            // 
            // trang_thai
            // 
            this.trang_thai.HeaderText = "Trạng thái";
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(4, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1523, 506);
            this.panel1.TabIndex = 109;
            // 
            // btn_ganmonhoctk
            // 
            this.btn_ganmonhoctk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_ganmonhoctk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ganmonhoctk.FlatAppearance.BorderSize = 0;
            this.btn_ganmonhoctk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ganmonhoctk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ganmonhoctk.ForeColor = System.Drawing.Color.White;
            this.btn_ganmonhoctk.Image = ((System.Drawing.Image)(resources.GetObject("btn_ganmonhoctk.Image")));
            this.btn_ganmonhoctk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ganmonhoctk.Location = new System.Drawing.Point(819, 3);
            this.btn_ganmonhoctk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ganmonhoctk.Name = "btn_ganmonhoctk";
            this.btn_ganmonhoctk.Size = new System.Drawing.Size(157, 57);
            this.btn_ganmonhoctk.TabIndex = 115;
            this.btn_ganmonhoctk.Text = "     Gán môn học";
            this.btn_ganmonhoctk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ganmonhoctk.UseVisualStyleBackColor = false;
            this.btn_ganmonhoctk.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_quyen
            // 
            this.btn_quyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_quyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quyen.FlatAppearance.BorderSize = 0;
            this.btn_quyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quyen.ForeColor = System.Drawing.Color.White;
            this.btn_quyen.Image = ((System.Drawing.Image)(resources.GetObject("btn_quyen.Image")));
            this.btn_quyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quyen.Location = new System.Drawing.Point(980, 2);
            this.btn_quyen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_quyen.Name = "btn_quyen";
            this.btn_quyen.Size = new System.Drawing.Size(117, 57);
            this.btn_quyen.TabIndex = 116;
            this.btn_quyen.Text = "     Quyền";
            this.btn_quyen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quyen.UseVisualStyleBackColor = false;
            this.btn_quyen.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // UC_TaiKhoanQuyen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.btn_quyen);
            this.Controls.Add(this.btn_ganmonhoctk);
            this.Controls.Add(this.btn_xemquyen);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_TaiKhoanQuyen";
            this.Size = new System.Drawing.Size(1531, 571);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xemquyen;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ganmonhoctk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_dangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn mat_khau;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_tao;
        private System.Windows.Forms.DataGridViewTextBoxColumn lan_cuoi_dangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai;
        private System.Windows.Forms.Button btn_quyen;
    }
}
