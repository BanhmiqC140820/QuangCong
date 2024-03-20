namespace MathBasic
{
    partial class FormLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLopHoc));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numTietTu = new NumericUpDown();
            txtLophoc = new TextBox();
            txtPhonghoc = new TextBox();
            txtGV = new TextBox();
            GridSV = new DataGridView();
            maSinhVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaySinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gIOITINHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            queQuanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noiSinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sinhVienBindingSource = new BindingSource(components);
            label6 = new Label();
            label7 = new Label();
            numTietDen = new NumericUpDown();
            btnTaoDS = new Button();
            btnLuuDS = new Button();
            btnNapFile = new Button();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tsbtnUpdate = new ToolStripButton();
            btnXoaSV = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)numTietTu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridSV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sinhVienBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTietDen).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 0;
            label1.Text = "Lớp học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 65);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Lớp học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 68);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Phòng học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 109);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Giáo viên";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 109);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Tiết học";
            // 
            // numTietTu
            // 
            numTietTu.Location = new Point(474, 107);
            numTietTu.Name = "numTietTu";
            numTietTu.Size = new Size(83, 23);
            numTietTu.TabIndex = 3;
            // 
            // txtLophoc
            // 
            txtLophoc.Location = new Point(128, 62);
            txtLophoc.Name = "txtLophoc";
            txtLophoc.Size = new Size(233, 23);
            txtLophoc.TabIndex = 0;
            // 
            // txtPhonghoc
            // 
            txtPhonghoc.Location = new Point(474, 65);
            txtPhonghoc.Name = "txtPhonghoc";
            txtPhonghoc.Size = new Size(233, 23);
            txtPhonghoc.TabIndex = 1;
            // 
            // txtGV
            // 
            txtGV.Location = new Point(128, 105);
            txtGV.Name = "txtGV";
            txtGV.Size = new Size(233, 23);
            txtGV.TabIndex = 2;
            // 
            // GridSV
            // 
            GridSV.AllowUserToAddRows = false;
            GridSV.AllowUserToDeleteRows = false;
            GridSV.AutoGenerateColumns = false;
            GridSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridSV.Columns.AddRange(new DataGridViewColumn[] { maSinhVienDataGridViewTextBoxColumn, hoDataGridViewTextBoxColumn, tenDataGridViewTextBoxColumn, ngaySinhDataGridViewTextBoxColumn, gIOITINHDataGridViewTextBoxColumn, queQuanDataGridViewTextBoxColumn, noiSinhDataGridViewTextBoxColumn });
            GridSV.DataSource = sinhVienBindingSource;
            GridSV.Dock = DockStyle.Fill;
            GridSV.Location = new Point(0, 25);
            GridSV.Name = "GridSV";
            GridSV.ReadOnly = true;
            GridSV.RowTemplate.Height = 25;
            GridSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridSV.Size = new Size(918, 112);
            GridSV.TabIndex = 9;
            GridSV.CellDoubleClick += GridSV_CellDoubleClick;
            // 
            // maSinhVienDataGridViewTextBoxColumn
            // 
            maSinhVienDataGridViewTextBoxColumn.DataPropertyName = "MaSinhVien";
            maSinhVienDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            maSinhVienDataGridViewTextBoxColumn.Name = "maSinhVienDataGridViewTextBoxColumn";
            maSinhVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoDataGridViewTextBoxColumn
            // 
            hoDataGridViewTextBoxColumn.DataPropertyName = "ho";
            hoDataGridViewTextBoxColumn.HeaderText = "Họ";
            hoDataGridViewTextBoxColumn.Name = "hoDataGridViewTextBoxColumn";
            hoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            tenDataGridViewTextBoxColumn.DataPropertyName = "ten";
            tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIOITINHDataGridViewTextBoxColumn
            // 
            gIOITINHDataGridViewTextBoxColumn.DataPropertyName = "GIOITINH";
            gIOITINHDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            gIOITINHDataGridViewTextBoxColumn.Name = "gIOITINHDataGridViewTextBoxColumn";
            gIOITINHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            queQuanDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            queQuanDataGridViewTextBoxColumn.HeaderText = "Quê Quán";
            queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            queQuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noiSinhDataGridViewTextBoxColumn
            // 
            noiSinhDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh";
            noiSinhDataGridViewTextBoxColumn.HeaderText = "Nơi sinh";
            noiSinhDataGridViewTextBoxColumn.Name = "noiSinhDataGridViewTextBoxColumn";
            noiSinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinhVienBindingSource
            // 
            sinhVienBindingSource.DataSource = typeof(Models.SinhVien);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(45, 135);
            label6.Name = "label6";
            label6.Size = new Size(155, 21);
            label6.TabIndex = 10;
            label6.Text = "Danh sách sinh viên :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(572, 109);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 11;
            label7.Text = "den";
            // 
            // numTietDen
            // 
            numTietDen.Location = new Point(620, 107);
            numTietDen.Name = "numTietDen";
            numTietDen.Size = new Size(87, 23);
            numTietDen.TabIndex = 4;
            // 
            // btnTaoDS
            // 
            btnTaoDS.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTaoDS.Location = new Point(728, 420);
            btnTaoDS.Name = "btnTaoDS";
            btnTaoDS.Size = new Size(98, 32);
            btnTaoDS.TabIndex = 6;
            btnTaoDS.Text = "Tạo danh sách";
            btnTaoDS.UseVisualStyleBackColor = true;
            btnTaoDS.Click += btnTaoDS_Click;
            // 
            // btnLuuDS
            // 
            btnLuuDS.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuuDS.Location = new Point(609, 420);
            btnLuuDS.Name = "btnLuuDS";
            btnLuuDS.Size = new Size(98, 32);
            btnLuuDS.TabIndex = 5;
            btnLuuDS.Text = "Lưu danh sách";
            btnLuuDS.UseVisualStyleBackColor = true;
            btnLuuDS.Click += btnLuuDS_Click;
            // 
            // btnNapFile
            // 
            btnNapFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNapFile.Location = new Point(847, 420);
            btnNapFile.Name = "btnNapFile";
            btnNapFile.Size = new Size(98, 32);
            btnNapFile.TabIndex = 7;
            btnNapFile.Text = "Nạp từ file";
            btnNapFile.UseVisualStyleBackColor = true;
            btnNapFile.Click += btnNapFile_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(GridSV);
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new Point(45, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 137);
            panel1.TabIndex = 12;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, tsbtnUpdate, btnXoaSV });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(918, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(108, 22);
            toolStripButton1.Text = "Thêm Sinh viên";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tsbtnUpdate
            // 
            tsbtnUpdate.Image = (Image)resources.GetObject("tsbtnUpdate.Image");
            tsbtnUpdate.ImageTransparentColor = Color.Magenta;
            tsbtnUpdate.Name = "tsbtnUpdate";
            tsbtnUpdate.Size = new Size(75, 22);
            tsbtnUpdate.Text = "Cập nhật";
            tsbtnUpdate.Click += toolStripButton2_Click;
            // 
            // btnXoaSV
            // 
            btnXoaSV.Image = (Image)resources.GetObject("btnXoaSV.Image");
            btnXoaSV.ImageTransparentColor = Color.Magenta;
            btnXoaSV.Name = "btnXoaSV";
            btnXoaSV.Size = new Size(97, 22);
            btnXoaSV.Text = "Xóa sinh viên";
            btnXoaSV.Click += btnXoaSV_Click;
            // 
            // FormLopHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 476);
            Controls.Add(panel1);
            Controls.Add(btnNapFile);
            Controls.Add(btnLuuDS);
            Controls.Add(btnTaoDS);
            Controls.Add(numTietDen);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtGV);
            Controls.Add(txtPhonghoc);
            Controls.Add(txtLophoc);
            Controls.Add(numTietTu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLopHoc";
            Text = "v";
            Load += FormLopHoc_Load;
            ((System.ComponentModel.ISupportInitialize)numTietTu).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridSV).EndInit();
            ((System.ComponentModel.ISupportInitialize)sinhVienBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTietDen).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numTietTu;
        private TextBox txtLophoc;
        private TextBox txtPhonghoc;
        private TextBox txtGV;
        private DataGridView GridSV;
        private Label label6;
        private Label label7;
        private NumericUpDown numTietDen;
        private Button btnTaoDS;
        private Button btnLuuDS;
        private Button btnNapFile;
        private BindingSource sinhVienBindingSource;
        private DataGridViewTextBoxColumn maSinhVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noiSinhDataGridViewTextBoxColumn;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton tsbtnUpdate;
        private ToolStripButton btnXoaSV;
    }
}