namespace QLCoffee
{
    partial class FormCoffe
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
            txtTenSP = new TextBox();
            label1 = new Label();
            Maloai = new Label();
            cbbLoai = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            txtMota = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nupSL = new NumericUpDown();
            nupGia = new NumericUpDown();
            label5 = new Label();
            txtXuatXu = new TextBox();
            pbxSP = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)nupSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxSP).BeginInit();
            SuspendLayout();
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(154, 69);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(234, 23);
            txtTenSP.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 73);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 2;
            label1.Text = "Tên sản phẩm";
            // 
            // Maloai
            // 
            Maloai.AutoSize = true;
            Maloai.Location = new Point(422, 73);
            Maloai.Name = "Maloai";
            Maloai.Size = new Size(85, 15);
            Maloai.TabIndex = 3;
            Maloai.Text = "Loại Sản phẩm";
            // 
            // cbbLoai
            // 
            cbbLoai.FormattingEnabled = true;
            cbbLoai.Location = new Point(529, 69);
            cbbLoai.Name = "cbbLoai";
            cbbLoai.Size = new Size(234, 23);
            cbbLoai.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(526, 373);
            button2.Name = "button2";
            button2.Size = new Size(106, 33);
            button2.TabIndex = 5;
            button2.Text = "đồng ý";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(657, 373);
            button1.Name = "button1";
            button1.Size = new Size(106, 33);
            button1.TabIndex = 6;
            button1.Text = "hủy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtMota
            // 
            txtMota.Location = new Point(154, 205);
            txtMota.Multiline = true;
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(234, 106);
            txtMota.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 213);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 119);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 9;
            label3.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 119);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 11;
            label4.Text = "Số lương";
            // 
            // nupSL
            // 
            nupSL.Location = new Point(530, 115);
            nupSL.Name = "nupSL";
            nupSL.Size = new Size(233, 23);
            nupSL.TabIndex = 13;
            // 
            // nupGia
            // 
            nupGia.Location = new Point(154, 115);
            nupGia.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupGia.Name = "nupGia";
            nupGia.Size = new Size(233, 23);
            nupGia.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 158);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 16;
            label5.Text = "Xuât xứ";
            // 
            // txtXuatXu
            // 
            txtXuatXu.Location = new Point(154, 154);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(234, 23);
            txtXuatXu.TabIndex = 15;
            // 
            // pbxSP
            // 
            pbxSP.BorderStyle = BorderStyle.Fixed3D;
            pbxSP.Location = new Point(529, 158);
            pbxSP.Name = "pbxSP";
            pbxSP.Size = new Size(234, 153);
            pbxSP.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxSP.TabIndex = 17;
            pbxSP.TabStop = false;
            pbxSP.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 162);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 18;
            label6.Text = "Ảnh sản phẩm";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(302, 9);
            label7.Name = "label7";
            label7.Size = new Size(205, 37);
            label7.TabIndex = 19;
            label7.Text = "Thêm sản phẩm";
            // 
            // FormCoffe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 416);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pbxSP);
            Controls.Add(label5);
            Controls.Add(txtXuatXu);
            Controls.Add(nupGia);
            Controls.Add(nupSL);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMota);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(cbbLoai);
            Controls.Add(Maloai);
            Controls.Add(label1);
            Controls.Add(txtTenSP);
            Name = "FormCoffe";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nupSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTenSP;
        private Label label1;
        private Label Maloai;
        private ComboBox cbbLoai;
        private Button button2;
        private Button button1;
        private TextBox txtMota;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown nupSL;
        private NumericUpDown nupGia;
        private Label label5;
        private TextBox txtXuatXu;
        private PictureBox pbxSP;
        private Label label6;
        private Label label7;
    }
}