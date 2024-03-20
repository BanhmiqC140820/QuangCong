namespace QuanLySanPham
{
    partial class FormSP
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
            components = new System.ComponentModel.Container();
            tableDssp = new DataGridView();
            maSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaySanXuatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayHetHanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaBanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hinhDaiDienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sanPhamBindingSource = new BindingSource(components);
            btnCapnhat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtSoluongnhap = new TextBox();
            txtGiaban = new TextBox();
            txtGianhap = new TextBox();
            dtpNHH = new DateTimePicker();
            dtpNSX = new DateTimePicker();
            txtTensanpham = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMasanpham = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            txtTimKiem = new TextBox();
            label10 = new Label();
            picAvt = new PictureBox();
            button1 = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)tableDssp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvt).BeginInit();
            SuspendLayout();
            // 
            // tableDssp
            // 
            tableDssp.AutoGenerateColumns = false;
            tableDssp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDssp.Columns.AddRange(new DataGridViewColumn[] { maSanPhamDataGridViewTextBoxColumn, tenSanPhamDataGridViewTextBoxColumn, ngaySanXuatDataGridViewTextBoxColumn, ngayHetHanDataGridViewTextBoxColumn, giaNhapDataGridViewTextBoxColumn, giaBanDataGridViewTextBoxColumn, soLuongNhapDataGridViewTextBoxColumn, hinhDaiDienDataGridViewTextBoxColumn });
            tableDssp.DataSource = sanPhamBindingSource;
            tableDssp.Dock = DockStyle.Bottom;
            tableDssp.Location = new Point(0, 309);
            tableDssp.Margin = new Padding(3, 2, 3, 2);
            tableDssp.Name = "tableDssp";
            tableDssp.RowHeadersWidth = 51;
            tableDssp.RowTemplate.Height = 29;
            tableDssp.Size = new Size(957, 141);
            tableDssp.TabIndex = 41;
            tableDssp.CellClick += tableDssp_CellClick;
            tableDssp.CellDoubleClick += tableDssp_CellDoubleClick;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            maSanPhamDataGridViewTextBoxColumn.HeaderText = "MaSanPham";
            maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham";
            tenSanPhamDataGridViewTextBoxColumn.HeaderText = "TenSanPham";
            tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            // 
            // ngaySanXuatDataGridViewTextBoxColumn
            // 
            ngaySanXuatDataGridViewTextBoxColumn.DataPropertyName = "NgaySanXuat";
            ngaySanXuatDataGridViewTextBoxColumn.HeaderText = "NgaySanXuat";
            ngaySanXuatDataGridViewTextBoxColumn.Name = "ngaySanXuatDataGridViewTextBoxColumn";
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            ngayHetHanDataGridViewTextBoxColumn.HeaderText = "NgayHetHan";
            ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            giaNhapDataGridViewTextBoxColumn.HeaderText = "GiaNhap";
            giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // soLuongNhapDataGridViewTextBoxColumn
            // 
            soLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNhap";
            soLuongNhapDataGridViewTextBoxColumn.HeaderText = "SoLuongNhap";
            soLuongNhapDataGridViewTextBoxColumn.Name = "soLuongNhapDataGridViewTextBoxColumn";
            // 
            // hinhDaiDienDataGridViewTextBoxColumn
            // 
            hinhDaiDienDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hinhDaiDienDataGridViewTextBoxColumn.DataPropertyName = "HinhDaiDien";
            hinhDaiDienDataGridViewTextBoxColumn.HeaderText = "HinhDaiDien";
            hinhDaiDienDataGridViewTextBoxColumn.Name = "hinhDaiDienDataGridViewTextBoxColumn";
            // 
            // sanPhamBindingSource
            // 
            sanPhamBindingSource.DataSource = typeof(Model.SanPham);
            // 
            // btnCapnhat
            // 
            btnCapnhat.Location = new Point(446, 271);
            btnCapnhat.Margin = new Padding(3, 2, 3, 2);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(82, 22);
            btnCapnhat.TabIndex = 40;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(268, 271);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(84, 271);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 38;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtSoluongnhap
            // 
            txtSoluongnhap.Location = new Point(130, 232);
            txtSoluongnhap.Margin = new Padding(3, 2, 3, 2);
            txtSoluongnhap.Name = "txtSoluongnhap";
            txtSoluongnhap.Size = new Size(444, 23);
            txtSoluongnhap.TabIndex = 36;
            // 
            // txtGiaban
            // 
            txtGiaban.Location = new Point(130, 195);
            txtGiaban.Margin = new Padding(3, 2, 3, 2);
            txtGiaban.Name = "txtGiaban";
            txtGiaban.Size = new Size(444, 23);
            txtGiaban.TabIndex = 35;
            // 
            // txtGianhap
            // 
            txtGianhap.BackColor = Color.White;
            txtGianhap.Location = new Point(130, 160);
            txtGianhap.Margin = new Padding(3, 2, 3, 2);
            txtGianhap.Name = "txtGianhap";
            txtGianhap.Size = new Size(444, 23);
            txtGianhap.TabIndex = 34;
            // 
            // dtpNHH
            // 
            dtpNHH.CustomFormat = "dd/MM/yyyy";
            dtpNHH.Format = DateTimePickerFormat.Custom;
            dtpNHH.Location = new Point(408, 120);
            dtpNHH.Margin = new Padding(3, 2, 3, 2);
            dtpNHH.Name = "dtpNHH";
            dtpNHH.Size = new Size(167, 23);
            dtpNHH.TabIndex = 33;
            // 
            // dtpNSX
            // 
            dtpNSX.CustomFormat = "dd/MM/yyyy";
            dtpNSX.Format = DateTimePickerFormat.Custom;
            dtpNSX.Location = new Point(130, 120);
            dtpNSX.Margin = new Padding(3, 2, 3, 2);
            dtpNSX.Name = "dtpNSX";
            dtpNSX.Size = new Size(167, 23);
            dtpNSX.TabIndex = 32;
            // 
            // txtTensanpham
            // 
            txtTensanpham.Location = new Point(130, 86);
            txtTensanpham.Margin = new Padding(3, 2, 3, 2);
            txtTensanpham.Name = "txtTensanpham";
            txtTensanpham.Size = new Size(444, 23);
            txtTensanpham.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 237);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 29;
            label8.Text = "Số lượng nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 200);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 28;
            label7.Text = "Giá bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 162);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 27;
            label6.Text = "Giá nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 124);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 26;
            label5.Text = "Ngày hết hạn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 126);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 25;
            label4.Text = "Ngày sản xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 91);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 24;
            label3.Text = "Tên sản phẩm";
            // 
            // txtMasanpham
            // 
            txtMasanpham.Location = new Point(130, 49);
            txtMasanpham.Margin = new Padding(3, 2, 3, 2);
            txtMasanpham.Name = "txtMasanpham";
            txtMasanpham.Size = new Size(444, 23);
            txtMasanpham.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 51);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 22;
            label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(253, 2);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 21;
            label1.Text = "Danh sách sản phẩm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(594, 168);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 42;
            label9.Text = "AVT";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(656, 49);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(198, 23);
            txtTimKiem.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(594, 51);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 46;
            label10.Text = "Tìm kiếm";
            // 
            // picAvt
            // 
            picAvt.BorderStyle = BorderStyle.FixedSingle;
            picAvt.Location = new Point(656, 120);
            picAvt.Name = "picAvt";
            picAvt.Size = new Size(198, 129);
            picAvt.TabIndex = 47;
            picAvt.TabStop = false;
            picAvt.Click += picAvt_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(859, 49);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 48;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(594, 271);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 22);
            btnReset.TabIndex = 49;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // FormSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 450);
            Controls.Add(btnReset);
            Controls.Add(button1);
            Controls.Add(picAvt);
            Controls.Add(label10);
            Controls.Add(txtTimKiem);
            Controls.Add(label9);
            Controls.Add(tableDssp);
            Controls.Add(btnCapnhat);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtSoluongnhap);
            Controls.Add(txtGiaban);
            Controls.Add(txtGianhap);
            Controls.Add(dtpNHH);
            Controls.Add(dtpNSX);
            Controls.Add(txtTensanpham);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMasanpham);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSP";
            Text = "FormSP";
            ((System.ComponentModel.ISupportInitialize)tableDssp).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableDssp;
        private Button btnCapnhat;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtSoluongnhap;
        private TextBox txtGiaban;
        private TextBox txtGianhap;
        private DateTimePicker dtpNHH;
        private DateTimePicker dtpNSX;
        private TextBox txtTensanpham;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtMasanpham;
        private Label label2;
        private Label label1;
        private BindingSource sanPhamBindingSource;
        private Label label9;
        private DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySanXuatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hinhDaiDienDataGridViewTextBoxColumn;
        private TextBox txtTimKiem;
        private Label label10;
        private PictureBox picAvt;
        private Button button1;
        private Button btnReset;
    }
}