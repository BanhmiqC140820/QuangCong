namespace QLCoffee
{
    partial class FormQLHD
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            maHDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maHDSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maKHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maNVDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayMuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tongTienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            daMuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoaDonBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            dateTuNgay = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 28);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 0;
            label1.Text = "Quản lý hóa đơn";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 232);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maHDDataGridViewTextBoxColumn, maHDSDataGridViewTextBoxColumn, maKHDataGridViewTextBoxColumn, maNVDataGridViewTextBoxColumn, ngayMuaDataGridViewTextBoxColumn, tongTienDataGridViewTextBoxColumn, daMuaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = hoaDonBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 232);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            maHDDataGridViewTextBoxColumn.Width = 50;
            // 
            // maHDSDataGridViewTextBoxColumn
            // 
            maHDSDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maHDSDataGridViewTextBoxColumn.DataPropertyName = "MaHDS";
            maHDSDataGridViewTextBoxColumn.HeaderText = "MaHDS";
            maHDSDataGridViewTextBoxColumn.Name = "maHDSDataGridViewTextBoxColumn";
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // ngayMuaDataGridViewTextBoxColumn
            // 
            ngayMuaDataGridViewTextBoxColumn.DataPropertyName = "NgayMua";
            ngayMuaDataGridViewTextBoxColumn.HeaderText = "NgayMua";
            ngayMuaDataGridViewTextBoxColumn.Name = "ngayMuaDataGridViewTextBoxColumn";
            ngayMuaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            tongTienDataGridViewTextBoxColumn.Width = 150;
            // 
            // daMuaDataGridViewTextBoxColumn
            // 
            daMuaDataGridViewTextBoxColumn.DataPropertyName = "DaMua";
            daMuaDataGridViewTextBoxColumn.HeaderText = "DaMua";
            daMuaDataGridViewTextBoxColumn.Name = "daMuaDataGridViewTextBoxColumn";
            daMuaDataGridViewTextBoxColumn.Width = 75;
            // 
            // hoaDonBindingSource
            // 
            hoaDonBindingSource.DataSource = typeof(Model.HoaDon);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 117);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Từ ngày :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 117);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Đến ngày :";
            // 
            // dateTuNgay
            // 
            dateTuNgay.CustomFormat = "dd/MM/yyyy";
            dateTuNgay.Format = DateTimePickerFormat.Custom;
            dateTuNgay.Location = new Point(99, 113);
            dateTuNgay.Name = "dateTuNgay";
            dateTuNgay.Size = new Size(96, 23);
            dateTuNgay.TabIndex = 4;
            dateTuNgay.Value = new DateTime(2024, 1, 2, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(322, 113);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(96, 23);
            dateTimePicker2.TabIndex = 5;
            dateTimePicker2.Value = new DateTime(2024, 1, 2, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Location = new Point(687, 408);
            button1.Name = "button1";
            button1.Size = new Size(86, 30);
            button1.TabIndex = 6;
            button1.Text = "Tạo hóa đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(452, 113);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 7;
            button2.Text = "Xem";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormQLHD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTuNgay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormQLHD";
            Text = "Quản lý hóa đơn";
            FormClosed += FormQLHD_FormClosed;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource hoaDonBindingSource;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTuNgay;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maHDSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayMuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn daMuaDataGridViewTextBoxColumn;
        private Button button2;
    }
}