namespace MathBasic
{
    partial class FormSV
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaSV = new TextBox();
            txtHo = new TextBox();
            txtTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cbbGioitinh = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            txtNoiSinh = new TextBox();
            txtQueQuan = new TextBox();
            btn_Dangky = new Button();
            btn_BoQua = new Button();
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 2;
            label3.Text = "Ho:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 96);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 3;
            label4.Text = "Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 140);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(424, 140);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 5;
            label6.Text = "Giới Tính";
            // 
            // txtMaSV
            // 
            txtMaSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaSV.Location = new Point(101, 52);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(687, 23);
            txtMaSV.TabIndex = 6;
            // 
            // txtHo
            // 
            txtHo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHo.Location = new Point(101, 88);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(266, 23);
            txtHo.TabIndex = 7;
            // 
            // txtTen
            // 
            txtTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTen.Location = new Point(519, 88);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(269, 23);
            txtTen.TabIndex = 8;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(107, 132);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(260, 23);
            dtpNgaySinh.TabIndex = 9;
            // 
            // cbbGioitinh
            // 
            cbbGioitinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbGioitinh.FormattingEnabled = true;
            cbbGioitinh.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cbbGioitinh.Location = new Point(517, 132);
            cbbGioitinh.Name = "cbbGioitinh";
            cbbGioitinh.Size = new Size(271, 23);
            cbbGioitinh.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 190);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 11;
            label7.Text = "Nơi sinh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 232);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 12;
            label8.Text = "Quê Quán";
            // 
            // txtNoiSinh
            // 
            txtNoiSinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNoiSinh.Location = new Point(101, 182);
            txtNoiSinh.Name = "txtNoiSinh";
            txtNoiSinh.Size = new Size(687, 23);
            txtNoiSinh.TabIndex = 13;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQueQuan.Location = new Point(101, 224);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(687, 23);
            txtQueQuan.TabIndex = 14;
            // 
            // btn_Dangky
            // 
            btn_Dangky.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Dangky.BackColor = SystemColors.Highlight;
            btn_Dangky.ForeColor = SystemColors.Control;
            btn_Dangky.Location = new Point(580, 546);
            btn_Dangky.Name = "btn_Dangky";
            btn_Dangky.Size = new Size(99, 40);
            btn_Dangky.TabIndex = 15;
            btn_Dangky.Text = "Đồng ý";
            btn_Dangky.UseVisualStyleBackColor = false;
            btn_Dangky.Click += btn_Dangky_Click;
            // 
            // btn_BoQua
            // 
            btn_BoQua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_BoQua.Location = new Point(689, 546);
            btn_BoQua.Name = "btn_BoQua";
            btn_BoQua.Size = new Size(99, 40);
            btn_BoQua.TabIndex = 16;
            btn_BoQua.Text = "Bỏ qua";
            btn_BoQua.UseVisualStyleBackColor = true;
            btn_BoQua.Click += btn_BoQua_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 274);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 18;
            label10.Text = "avatar";
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Location = new Point(12, 413);
            label11.Name = "label11";
            label11.Size = new Size(776, 1);
            label11.TabIndex = 19;
            label11.Text = "label11";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(101, 274);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_BoQua;
            ClientSize = new Size(800, 598);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btn_BoQua);
            Controls.Add(btn_Dangky);
            Controls.Add(txtQueQuan);
            Controls.Add(txtNoiSinh);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbbGioitinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(txtMaSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSV";
            Text = "Thông tin sinh viên";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaSV;
        private TextBox txtHo;
        private TextBox txtTen;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cbbGioitinh;
        private Label label7;
        private Label label8;
        private TextBox txtNoiSinh;
        private TextBox txtQueQuan;
        private Button btn_Dangky;
        private Button btn_BoQua;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
    }
}