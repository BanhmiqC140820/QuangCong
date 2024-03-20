namespace MathBasic
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            label1 = new Label();
            label2 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            label3 = new Label();
            rtbKetqua = new RichTextBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("VNI-Baybuom", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(478, 35);
            label1.TabIndex = 0;
            label1.Text = "TÍnh toán cơ bản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 78);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Số thứ nhất";
            // 
            // txt1
            // 
            txt1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt1.Location = new Point(94, 79);
            txt1.Name = "txt1";
            txt1.Size = new Size(410, 23);
            txt1.TabIndex = 0;
            // 
            // txt2
            // 
            txt2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt2.Location = new Point(93, 120);
            txt2.Name = "txt2";
            txt2.Size = new Size(411, 23);
            txt2.TabIndex = 1;
            // 
            // btnCong
            // 
            btnCong.Anchor = AnchorStyles.Top;
            btnCong.BackColor = Color.Coral;
            btnCong.BackgroundImageLayout = ImageLayout.Center;
            btnCong.Location = new Point(93, 165);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(75, 23);
            btnCong.TabIndex = 2;
            btnCong.Tag = "+";
            btnCong.Text = "Cộng";
            btnCong.UseVisualStyleBackColor = false;
            btnCong.Click += process_click;
            // 
            // btnTru
            // 
            btnTru.Anchor = AnchorStyles.Top;
            btnTru.BackColor = SystemColors.ActiveCaption;
            btnTru.Location = new Point(199, 165);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(75, 23);
            btnTru.TabIndex = 3;
            btnTru.Tag = "-";
            btnTru.Text = "Trừ";
            btnTru.UseVisualStyleBackColor = false;
            btnTru.Click += process_click;
            // 
            // btnNhan
            // 
            btnNhan.Anchor = AnchorStyles.Top;
            btnNhan.BackColor = Color.YellowGreen;
            btnNhan.Location = new Point(320, 165);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(75, 23);
            btnNhan.TabIndex = 4;
            btnNhan.Tag = "*";
            btnNhan.Text = "Nhân";
            btnNhan.UseVisualStyleBackColor = false;
            btnNhan.Click += process_click;
            // 
            // btnChia
            // 
            btnChia.Anchor = AnchorStyles.Top;
            btnChia.BackColor = Color.FromArgb(192, 192, 0);
            btnChia.Location = new Point(429, 165);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(75, 23);
            btnChia.TabIndex = 5;
            btnChia.Tag = "/";
            btnChia.Text = "Chia";
            btnChia.UseVisualStyleBackColor = false;
            btnChia.Click += process_click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 128);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Số thứ hai";
            // 
            // rtbKetqua
            // 
            rtbKetqua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbKetqua.BackColor = Color.AntiqueWhite;
            rtbKetqua.Location = new Point(93, 234);
            rtbKetqua.Name = "rtbKetqua";
            rtbKetqua.Size = new Size(411, 96);
            rtbKetqua.TabIndex = 6;
            rtbKetqua.Text = "";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 237);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 10;
            label4.Text = "Kết quả";

            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(499, 401);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Tac gia";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(rtbKetqua);
            Controls.Add(label3);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt1;
        private TextBox txt2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Label label3;
        private RichTextBox rtbKetqua;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}