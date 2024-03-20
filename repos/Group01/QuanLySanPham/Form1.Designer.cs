namespace QuanLySanPham
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbTenSanPham = new Label();
            lb = new Label();
            lbNgayNhap = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbNgayHetHan = new Label();
            lbGiasNhap = new Label();
            LbGiaBan = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // lbTenSanPham
            // 
            lbTenSanPham.AutoSize = true;
            lbTenSanPham.Location = new Point(179, 40);
            lbTenSanPham.Name = "lbTenSanPham";
            lbTenSanPham.Size = new Size(80, 15);
            lbTenSanPham.TabIndex = 1;
            lbTenSanPham.Text = "Tên sản phẩm";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(68, 71);
            lb.Name = "lb";
            lb.Size = new Size(65, 15);
            lb.TabIndex = 2;
            lb.Text = "Ngày nhập";
            // 
            // lbNgayNhap
            // 
            lbNgayNhap.AutoSize = true;
            lbNgayNhap.Location = new Point(179, 71);
            lbNgayNhap.Name = "lbNgayNhap";
            lbNgayNhap.Size = new Size(38, 15);
            lbNgayNhap.TabIndex = 3;
            lbNgayNhap.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 101);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày hết hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 135);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 5;
            label5.Text = "Giá Nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 173);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 6;
            label6.Text = "Giá Bán";
            // 
            // lbNgayHetHan
            // 
            lbNgayHetHan.AutoSize = true;
            lbNgayHetHan.Location = new Point(179, 101);
            lbNgayHetHan.Name = "lbNgayHetHan";
            lbNgayHetHan.Size = new Size(38, 15);
            lbNgayHetHan.TabIndex = 7;
            lbNgayHetHan.Text = "label7";
            // 
            // lbGiasNhap
            // 
            lbGiasNhap.AutoSize = true;
            lbGiasNhap.Location = new Point(179, 135);
            lbGiasNhap.Name = "lbGiasNhap";
            lbGiasNhap.Size = new Size(38, 15);
            lbGiasNhap.TabIndex = 8;
            lbGiasNhap.Text = "label8";
            // 
            // LbGiaBan
            // 
            LbGiaBan.AutoSize = true;
            LbGiaBan.Location = new Point(179, 173);
            LbGiaBan.Name = "LbGiaBan";
            LbGiaBan.Size = new Size(38, 15);
            LbGiaBan.TabIndex = 9;
            LbGiaBan.Text = "label9";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(68, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 163);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 450);
            Controls.Add(pictureBox1);
            Controls.Add(LbGiaBan);
            Controls.Add(lbGiasNhap);
            Controls.Add(lbNgayHetHan);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbNgayNhap);
            Controls.Add(lb);
            Controls.Add(lbTenSanPham);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbTenSanPham;
        private Label lb;
        private Label lbNgayNhap;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbNgayHetHan;
        private Label lbGiasNhap;
        private Label LbGiaBan;
        private PictureBox pictureBox1;
    }
}