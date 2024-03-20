namespace QlCoffee
{
    partial class FormKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKH));
            txtSDT = new MaskedTextBox();
            label7 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            maKHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hovatenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaChiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sDTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            txtTimKiem = new ToolStripTextBox();
            toolStripButton4 = new ToolStripButton();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtTenKH = new TextBox();
            label2 = new Label();
            txtMaKH = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(498, 130);
            txtSDT.Mask = "(+84) 000-000-000";
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(234, 23);
            txtSDT.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(264, 6);
            label7.Name = "label7";
            label7.Size = new Size(300, 45);
            label7.TabIndex = 27;
            label7.Text = "Quản lý khách hàng";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new Point(40, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 201);
            panel1.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maKHDataGridViewTextBoxColumn, hovatenDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn, sDTDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(721, 176);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            maKHDataGridViewTextBoxColumn.Width = 75;
            // 
            // hovatenDataGridViewTextBoxColumn
            // 
            hovatenDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            sDTDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(QLCoffee.Model.Customer);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripButton2, toolStripButton1, txtTimKiem, toolStripButton4 });
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
            // txtTimKiem
            // 
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(150, 25);
            txtTimKiem.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(76, 22);
            toolStripButton4.Text = "Tìm kiếm";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(121, 179);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 23;
            label5.Text = "email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmail.Location = new Point(170, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 23);
            txtEmail.TabIndex = 22;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(407, 133);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 21;
            label4.Text = "Số điện thoại";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDiaChi.Location = new Point(498, 91);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(234, 23);
            txtDiaChi.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(407, 95);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 19;
            label3.Text = "Địa chỉ";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(170, 133);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(202, 23);
            txtTenKH.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 137);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 17;
            label2.Text = "Tên khách hàng";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(170, 95);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(202, 23);
            txtMaKH.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 99);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 15;
            label1.Text = "Mã khách hàng";
            // 
            // FormKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSDT);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtDiaChi);
            Controls.Add(label3);
            Controls.Add(txtTenKH);
            Controls.Add(label2);
            Controls.Add(txtMaKH);
            Controls.Add(label1);
            Name = "FormKH";
            Text = "FormKH";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtSDT;
        private Label label7;
        private Panel panel1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton toolStripButton4;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtDiaChi;
        private Label label3;
        private TextBox txtTenKH;
        private Label label2;
        private TextBox txtMaKH;
        private Label label1;
        private DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hovatenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
    }
}