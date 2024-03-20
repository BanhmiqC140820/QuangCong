namespace _20T1020084
{
    partial class FormSanPham
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
            label1 = new Label();
            label2 = new Label();
            txtMasanpham = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtTensanpham = new TextBox();
            dtpNSX = new DateTimePicker();
            dtpNHH = new DateTimePicker();
            txtGianhap = new TextBox();
            txtGiaban = new TextBox();
            txtSoluongnhap = new TextBox();
            picAvt = new PictureBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnCapnhat = new Button();
            tableDssp = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            sanPhamBindingSource1 = new BindingSource(components);
            sanPhamBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)picAvt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableDssp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(292, 7);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 0;
            label1.Text = "Danh sách sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 53);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã sản phẩm";
            // 
            // txtMasanpham
            // 
            txtMasanpham.Location = new Point(137, 51);
            txtMasanpham.Margin = new Padding(3, 2, 3, 2);
            txtMasanpham.Name = "txtMasanpham";
            txtMasanpham.Size = new Size(444, 23);
            txtMasanpham.TabIndex = 2;
            txtMasanpham.TextChanged += txtMasanpham_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 90);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 3;
            label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 126);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày sản xuất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 126);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 5;
            label5.Text = "Ngày hết hạn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 164);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 6;
            label6.Text = "Giá nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 200);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 7;
            label7.Text = "Giá bán";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 236);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 8;
            label8.Text = "Số lượng nhập";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(645, 122);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 9;
            label9.Text = "AVT";
            // 
            // txtTensanpham
            // 
            txtTensanpham.Location = new Point(137, 88);
            txtTensanpham.Margin = new Padding(3, 2, 3, 2);
            txtTensanpham.Name = "txtTensanpham";
            txtTensanpham.Size = new Size(444, 23);
            txtTensanpham.TabIndex = 10;
            // 
            // dtpNSX
            // 
            dtpNSX.CustomFormat = "dd/MM/yyyy";
            dtpNSX.Format = DateTimePickerFormat.Custom;
            dtpNSX.Location = new Point(137, 122);
            dtpNSX.Margin = new Padding(3, 2, 3, 2);
            dtpNSX.Name = "dtpNSX";
            dtpNSX.Size = new Size(167, 23);
            dtpNSX.TabIndex = 11;
            // 
            // dtpNHH
            // 
            dtpNHH.CustomFormat = "dd/MM/yyyy";
            dtpNHH.Format = DateTimePickerFormat.Custom;
            dtpNHH.Location = new Point(415, 122);
            dtpNHH.Margin = new Padding(3, 2, 3, 2);
            dtpNHH.Name = "dtpNHH";
            dtpNHH.Size = new Size(167, 23);
            dtpNHH.TabIndex = 12;
            // 
            // txtGianhap
            // 
            txtGianhap.BackColor = Color.White;
            txtGianhap.Location = new Point(137, 162);
            txtGianhap.Margin = new Padding(3, 2, 3, 2);
            txtGianhap.Name = "txtGianhap";
            txtGianhap.Size = new Size(444, 23);
            txtGianhap.TabIndex = 13;
            // 
            // txtGiaban
            // 
            txtGiaban.Location = new Point(137, 197);
            txtGiaban.Margin = new Padding(3, 2, 3, 2);
            txtGiaban.Name = "txtGiaban";
            txtGiaban.Size = new Size(444, 23);
            txtGiaban.TabIndex = 14;
            // 
            // txtSoluongnhap
            // 
            txtSoluongnhap.Location = new Point(137, 234);
            txtSoluongnhap.Margin = new Padding(3, 2, 3, 2);
            txtSoluongnhap.Name = "txtSoluongnhap";
            txtSoluongnhap.Size = new Size(444, 23);
            txtSoluongnhap.TabIndex = 15;
            // 
            // picAvt
            // 
            picAvt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picAvt.BorderStyle = BorderStyle.FixedSingle;
            picAvt.Location = new Point(695, 51);
            picAvt.Margin = new Padding(3, 2, 3, 2);
            picAvt.Name = "picAvt";
            picAvt.Size = new Size(190, 148);
            picAvt.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvt.TabIndex = 16;
            picAvt.TabStop = false;
            picAvt.Click += picAvt_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(137, 274);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(321, 274);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Location = new Point(499, 274);
            btnCapnhat.Margin = new Padding(3, 2, 3, 2);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(82, 22);
            btnCapnhat.TabIndex = 19;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // tableDssp
            // 
            tableDssp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableDssp.AutoGenerateColumns = false;
            tableDssp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDssp.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            tableDssp.DataSource = sanPhamBindingSource1;
            tableDssp.Location = new Point(22, 309);
            tableDssp.Margin = new Padding(3, 2, 3, 2);
            tableDssp.Name = "tableDssp";
            tableDssp.RowHeadersWidth = 51;
            tableDssp.RowTemplate.Height = 29;
            tableDssp.Size = new Size(861, 141);
            tableDssp.TabIndex = 20;
            tableDssp.CellClick += tableDssp_CellClick;
            tableDssp.CellContentClick += tableDssp_CellContentClick;
            tableDssp.RowHeaderMouseDoubleClick += tableDssp_RowHeaderMouseDoubleClick;
            tableDssp.SelectionChanged += tableDssp_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MaSanPham";
            dataGridViewTextBoxColumn1.HeaderText = "MaSanPham";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TenSanPham";
            dataGridViewTextBoxColumn2.HeaderText = "TenSanPham";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "NgaySanXuat";
            dataGridViewTextBoxColumn3.HeaderText = "NgaySanXuat";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "NgayHetHan";
            dataGridViewTextBoxColumn4.HeaderText = "NgayHetHan";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "GiaNhap";
            dataGridViewTextBoxColumn5.HeaderText = "GiaNhap";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "GiaBan";
            dataGridViewTextBoxColumn6.HeaderText = "GiaBan";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "SoLuongNhap";
            dataGridViewTextBoxColumn7.HeaderText = "SoLuongNhap";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "HinhDaiDien";
            dataGridViewTextBoxColumn8.HeaderText = "HinhDaiDien";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // sanPhamBindingSource1
            // 
            sanPhamBindingSource1.DataSource = typeof(Model.SanPham);
            // 
            // sanPhamBindingSource
            // 
            sanPhamBindingSource.CurrentChanged += sanPhamBindingSource_CurrentChanged;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 472);
            Controls.Add(tableDssp);
            Controls.Add(btnCapnhat);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(picAvt);
            Controls.Add(txtSoluongnhap);
            Controls.Add(txtGiaban);
            Controls.Add(txtGianhap);
            Controls.Add(dtpNHH);
            Controls.Add(dtpNSX);
            Controls.Add(txtTensanpham);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMasanpham);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSanPham";
            Text = "FormSanPham";
            ((System.ComponentModel.ISupportInitialize)picAvt).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableDssp).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMasanpham;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtTensanpham;
        private DateTimePicker dtpNSX;
        private DateTimePicker dtpNHH;
        private TextBox txtGianhap;
        private TextBox txtGiaban;
        private TextBox txtSoluongnhap;
        private PictureBox picAvt;
        private Button btnThem;
        private Button btnXoa;
        private Button btnCapnhat;
        private DataGridView tableDssp;
        private DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySanXuatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hinhDaiDienDataGridViewTextBoxColumn;
        private BindingSource sanPhamBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BindingSource sanPhamBindingSource1;
    }
}