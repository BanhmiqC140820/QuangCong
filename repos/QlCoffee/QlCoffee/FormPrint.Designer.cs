namespace QlCoffee
{
    partial class FormPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrint));
            dataGridView1 = new DataGridView();
            tensanphamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongMuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            thanhTienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            chiTietHDDTOBindingSource = new BindingSource(components);
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button1 = new Button();
            label1 = new Label();
            lbNgayBan = new Label();
            lbTongTien = new Label();
            lbMaHD = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHDDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tensanphamDataGridViewTextBoxColumn, soLuongMuaDataGridViewTextBoxColumn, DonGia, thanhTienDataGridViewTextBoxColumn });
            dataGridView1.DataSource = chiTietHDDTOBindingSource;
            dataGridView1.Location = new Point(12, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(715, 291);
            dataGridView1.TabIndex = 0;
            // 
            // tensanphamDataGridViewTextBoxColumn
            // 
            tensanphamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tensanphamDataGridViewTextBoxColumn.DataPropertyName = "Tensanpham";
            tensanphamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            tensanphamDataGridViewTextBoxColumn.Name = "tensanphamDataGridViewTextBoxColumn";
            // 
            // soLuongMuaDataGridViewTextBoxColumn
            // 
            soLuongMuaDataGridViewTextBoxColumn.DataPropertyName = "SoLuongMua";
            soLuongMuaDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            soLuongMuaDataGridViewTextBoxColumn.Name = "soLuongMuaDataGridViewTextBoxColumn";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            DonGia.Width = 120;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            thanhTienDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            thanhTienDataGridViewTextBoxColumn.Width = 150;
            // 
            // chiTietHDDTOBindingSource
            // 
            chiTietHDDTOBindingSource.DataSource = typeof(QLCoffee.DTO.ChiTietHDDTO);
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // button1
            // 
            button1.Location = new Point(652, 486);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(395, 61);
            label1.TabIndex = 2;
            label1.Text = "Hóa đơn bán hàng";
            label1.Click += label1_Click;
            // 
            // lbNgayBan
            // 
            lbNgayBan.AutoSize = true;
            lbNgayBan.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbNgayBan.Location = new Point(183, 94);
            lbNgayBan.Name = "lbNgayBan";
            lbNgayBan.Size = new Size(84, 25);
            lbNgayBan.TabIndex = 3;
            lbNgayBan.Text = "ngayBan";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbTongTien.Location = new Point(179, 123);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(88, 25);
            lbTongTien.TabIndex = 6;
            lbTongTien.Text = "TongTien";
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbMaHD.Location = new Point(185, 68);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(59, 25);
            lbMaHD.TabIndex = 8;
            lbMaHD.Text = "mahd";
            // 
            // button2
            // 
            button2.Location = new Point(562, 486);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormPrint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 524);
            Controls.Add(button2);
            Controls.Add(lbMaHD);
            Controls.Add(lbTongTien);
            Controls.Add(lbNgayBan);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "FormPrint";
            Text = "In hóa đơn";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHDDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button1;
        private BindingSource chiTietHDDTOBindingSource;
        private Label label1;
        private Label lbNgayBan;
        private Label lbTongTien;
        private Label lbMaHD;
        private DataGridViewTextBoxColumn tensanphamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongMuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private Button button2;
    }
}