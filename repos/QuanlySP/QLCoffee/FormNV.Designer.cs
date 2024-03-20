namespace QLCoffee
{
    partial class FormNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNV));
            label1 = new Label();
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dtpNgaySinh = new DateTimePicker();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            maNVDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hovatenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaChiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sDTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaysinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nhanVienBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripButton4 = new ToolStripButton();
            label7 = new Label();
            txtSDT = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhanVienBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 93);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(155, 89);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(202, 23);
            txtMaNV.TabIndex = 1;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(155, 127);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(202, 23);
            txtTenNV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 131);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(392, 89);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDiaChi.Location = new Point(483, 85);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(234, 23);
            txtDiaChi.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(392, 127);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 6;
            label4.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmail.Location = new Point(483, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 23);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(392, 169);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 173);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 10;
            label6.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(155, 169);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(202, 23);
            dtpNgaySinh.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new Point(25, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 201);
            panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maNVDataGridViewTextBoxColumn, hovatenDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn, sDTDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, ngaysinhDataGridViewTextBoxColumn });
            dataGridView1.DataSource = nhanVienBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(721, 176);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            maNVDataGridViewTextBoxColumn.FillWeight = 50F;
            maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // hovatenDataGridViewTextBoxColumn
            // 
            hovatenDataGridViewTextBoxColumn.DataPropertyName = "Hovaten";
            hovatenDataGridViewTextBoxColumn.HeaderText = "Hovaten";
            hovatenDataGridViewTextBoxColumn.Name = "hovatenDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            diaChiDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            sDTDataGridViewTextBoxColumn.FillWeight = 125F;
            sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.FillWeight = 125F;
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
            ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngaysinh";
            ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // nhanVienBindingSource
            // 
            nhanVienBindingSource.DataSource = typeof(Model.NhanVien);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripButton2, toolStripButton1, toolStripTextBox1, toolStripButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(721, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(60, 22);
            toolStripButton3.Text = "Delete";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(65, 22);
            toolStripButton2.Text = "Update";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(49, 22);
            toolStripButton1.Text = "Add";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(150, 25);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(76, 22);
            toolStripButton4.Text = "Tìm kiếm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(249, 0);
            label7.Name = "label7";
            label7.Size = new Size(274, 45);
            label7.TabIndex = 13;
            label7.Text = "Quản lý nhân viên";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(483, 124);
            txtSDT.Mask = "(+84) 000-000-000";
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(234, 23);
            txtSDT.TabIndex = 14;
            // 
            // FormNV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 450);
            Controls.Add(txtSDT);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtDiaChi);
            Controls.Add(label3);
            Controls.Add(txtTenNV);
            Controls.Add(label2);
            Controls.Add(txtMaNV);
            Controls.Add(label1);
            Name = "FormNV";
            Text = "FormNV";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhanVienBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private Label label2;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpNgaySinh;
        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource nhanVienBindingSource;
        private DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hovatenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton toolStripButton4;
        private Label label7;
        private MaskedTextBox txtSDT;
    }
}