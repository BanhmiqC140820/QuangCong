namespace QLCoffee
{
    partial class FormHoaDon
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
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            cbxMaNV = new ComboBox();
            cbxKH = new ComboBox();
            button2 = new Button();
            txtTenKH = new TextBox();
            txtDiachi = new TextBox();
            txtSDT = new TextBox();
            dtpNgayBan = new DateTimePicker();
            cbxNV = new ComboBox();
            txtMaHD = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            button1 = new Button();
            btnLuuHD = new Button();
            btnThanhToan = new Button();
            label16 = new Label();
            label15 = new Label();
            dataGridView1 = new DataGridView();
            maSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tensanphamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongMuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            donGiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thanhTienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            chiTietHDDTOBindingSource = new BindingSource(components);
            txtMaSP = new TextBox();
            btnSua = new Button();
            btnThem = new Button();
            numbericGia = new NumericUpDown();
            numericSL = new NumericUpDown();
            cbxSP = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHDDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numbericGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSL).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 34);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(297, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 30);
            label2.TabIndex = 0;
            label2.Text = "Hóa đơn bán hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 178);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxMaNV);
            groupBox1.Controls.Add(cbxKH);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(dtpNgayBan);
            groupBox1.Controls.Add(cbxNV);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 178);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thôn tin chung";
            // 
            // cbxMaNV
            // 
            cbxMaNV.FormattingEnabled = true;
            cbxMaNV.Location = new Point(113, 87);
            cbxMaNV.Name = "cbxMaNV";
            cbxMaNV.Size = new Size(231, 23);
            cbxMaNV.TabIndex = 20;
            cbxMaNV.SelectedIndexChanged += cbxMaNV_SelectedIndexChanged;
            // 
            // cbxKH
            // 
            cbxKH.FormattingEnabled = true;
            cbxKH.Location = new Point(508, 29);
            cbxKH.Name = "cbxKH";
            cbxKH.Size = new Size(230, 23);
            cbxKH.TabIndex = 19;
            cbxKH.SelectedIndexChanged += cbxKH_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(507, 149);
            button2.Name = "button2";
            button2.Size = new Size(231, 23);
            button2.TabIndex = 18;
            button2.Text = "Thêm khách hàng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(507, 57);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(231, 23);
            txtTenKH.TabIndex = 17;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(507, 85);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(231, 23);
            txtDiachi.TabIndex = 16;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(507, 111);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(231, 23);
            txtSDT.TabIndex = 14;
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            dtpNgayBan.Format = DateTimePickerFormat.Custom;
            dtpNgayBan.Location = new Point(113, 56);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(231, 23);
            dtpNgayBan.TabIndex = 12;
            dtpNgayBan.Value = new DateTime(2024, 1, 2, 0, 0, 0, 0);
            // 
            // cbxNV
            // 
            cbxNV.FormattingEnabled = true;
            cbxNV.Location = new Point(113, 116);
            cbxNV.Name = "cbxNV";
            cbxNV.Size = new Size(231, 23);
            cbxNV.TabIndex = 11;
            cbxNV.SelectedIndexChanged += cbxNV_SelectedIndexChanged;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(113, 26);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(231, 23);
            txtMaHD.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(394, 29);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 4;
            label7.Text = "Mã khách hàng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(394, 119);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 7;
            label8.Text = "SDT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(394, 59);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 5;
            label9.Text = "Tên khách hàng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(394, 89);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 6;
            label10.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 29);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 0;
            label3.Text = "Mã hóa đơn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 119);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 3;
            label6.Text = "Tên nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 59);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 1;
            label4.Text = "ngày bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 89);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 2;
            label5.Text = "Mã nhân viên";
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 212);
            panel4.Name = "panel4";
            panel4.Size = new Size(770, 368);
            panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnLuuHD);
            groupBox2.Controls.Add(btnThanhToan);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(txtMaSP);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(numbericGia);
            groupBox2.Controls.Add(numericSL);
            groupBox2.Controls.Add(cbxSP);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(770, 368);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(597, 339);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 16;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLuuHD
            // 
            btnLuuHD.Location = new Point(469, 339);
            btnLuuHD.Name = "btnLuuHD";
            btnLuuHD.Size = new Size(122, 23);
            btnLuuHD.TabIndex = 15;
            btnLuuHD.Text = "Lưu hóa đơn";
            btnLuuHD.UseVisualStyleBackColor = true;
            btnLuuHD.Click += btnLuuHD_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(314, 339);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(149, 23);
            btnThanhToan.TabIndex = 14;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += button1_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(658, 313);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 13;
            label16.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(589, 313);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 12;
            label15.Text = "Tổng tiên :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maSanPhamDataGridViewTextBoxColumn, tensanphamDataGridViewTextBoxColumn, soLuongMuaDataGridViewTextBoxColumn, donGiaDataGridViewTextBoxColumn, thanhTienDataGridViewTextBoxColumn, Delete });
            dataGridView1.DataSource = chiTietHDDTOBindingSource;
            dataGridView1.Location = new Point(23, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 10;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(715, 192);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            maSanPhamDataGridViewTextBoxColumn.HeaderText = "MaSanPham";
            maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            // 
            // tensanphamDataGridViewTextBoxColumn
            // 
            tensanphamDataGridViewTextBoxColumn.DataPropertyName = "Tensanpham";
            tensanphamDataGridViewTextBoxColumn.HeaderText = "Tensanpham";
            tensanphamDataGridViewTextBoxColumn.Name = "tensanphamDataGridViewTextBoxColumn";
            // 
            // soLuongMuaDataGridViewTextBoxColumn
            // 
            soLuongMuaDataGridViewTextBoxColumn.DataPropertyName = "SoLuongMua";
            soLuongMuaDataGridViewTextBoxColumn.HeaderText = "SoLuongMua";
            soLuongMuaDataGridViewTextBoxColumn.Name = "soLuongMuaDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            thanhTienDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            Delete.FillWeight = 50F;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // chiTietHDDTOBindingSource
            // 
            chiTietHDDTOBindingSource.DataSource = typeof(DTO.ChiTietHDDTO);
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(120, 30);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(195, 23);
            txtMaSP.TabIndex = 10;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(629, 67);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 23);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa thông tin";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button4_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(629, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 23);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm thông tin";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button3_Click;
            // 
            // numbericGia
            // 
            numbericGia.Location = new Point(421, 66);
            numbericGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numbericGia.Name = "numbericGia";
            numbericGia.Size = new Size(198, 23);
            numbericGia.TabIndex = 7;
            // 
            // numericSL
            // 
            numericSL.Location = new Point(423, 30);
            numericSL.Name = "numericSL";
            numericSL.Size = new Size(196, 23);
            numericSL.TabIndex = 6;
            numericSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxSP
            // 
            cbxSP.FormattingEnabled = true;
            cbxSP.Location = new Point(120, 64);
            cbxSP.Name = "cbxSP";
            cbxSP.Size = new Size(195, 23);
            cbxSP.TabIndex = 5;
            cbxSP.SelectedIndexChanged += cbxSP_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(350, 68);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 3;
            label14.Text = "Đơn giá";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 67);
            label13.Name = "label13";
            label13.Size = new Size(80, 15);
            label13.TabIndex = 2;
            label13.Text = "Tên sản phẩm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(350, 33);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 1;
            label12.Text = "Số lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 33);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 0;
            label11.Text = "Mã sản phẩm";
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 580);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FormHoaDon";
            Text = "Hóa đơn";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHDDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numbericGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSL).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private GroupBox groupBox1;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtDiachi;
        private TextBox txtSDT;
        private DateTimePicker dtpNgayBan;
        private ComboBox cbxNV;
        private TextBox txtMaHD;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtTenKH;
        private Button button2;
        private Panel panel4;
        private GroupBox groupBox2;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label12;
        private NumericUpDown numbericGia;
        private NumericUpDown numericSL;
        private ComboBox cbxSP;
        private Button btnThem;
        private TextBox txtMaSP;
        private Button btnSua;
        private ComboBox cbxKH;
        private DataGridView dataGridView1;
        private BindingSource chiTietHDDTOBindingSource;
        private Label label16;
        private Label label15;
        private Button btnThanhToan;
        private Button btnLuuHD;
        private ComboBox cbxMaNV;
        private DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tensanphamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongMuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Delete;
        private Button button1;
    }
}