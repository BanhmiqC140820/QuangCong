namespace QlCoffee
{
    partial class MenuHome
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
            button1 = new Button();
            button2 = new Button();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripSanPham = new ToolStripMenuItem();
            toolStripLoai = new ToolStripMenuItem();
            toolStripNV = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripQLHD = new ToolStripMenuItem();
            toolStripHoaDon = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem13 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            thôngKêNămToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            label1 = new Label();
            lbNgay = new Label();
            lbThang = new Label();
            label4 = new Label();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(622, 402);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(713, 402);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem7, toolStripMenuItem3, toolStripMenuItem9, toolStripMenuItem10, toolStripMenuItem11 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.DropDownItems.AddRange(new ToolStripItem[] { toolStripSanPham, toolStripLoai, toolStripNV, toolStripMenuItem2 });
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(74, 20);
            toolStripMenuItem7.Text = "Danh mục";
            // 
            // toolStripSanPham
            // 
            toolStripSanPham.Name = "toolStripSanPham";
            toolStripSanPham.Size = new Size(192, 22);
            toolStripSanPham.Text = "Quản lý sản phẩm";
            toolStripSanPham.Click += toolStripMenuItem8_Click;
            // 
            // toolStripLoai
            // 
            toolStripLoai.Name = "toolStripLoai";
            toolStripLoai.Size = new Size(192, 22);
            toolStripLoai.Text = "Quản lý loại sản phẩm";
            toolStripLoai.Click += toolStripMenuItem1_Click;
            // 
            // toolStripNV
            // 
            toolStripNV.Name = "toolStripNV";
            toolStripNV.Size = new Size(192, 22);
            toolStripNV.Text = "Quản lý nhân viên";
            toolStripNV.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripQLHD, toolStripHoaDon });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(65, 20);
            toolStripMenuItem3.Text = "Hóa đơn";
            // 
            // toolStripQLHD
            // 
            toolStripQLHD.Name = "toolStripQLHD";
            toolStripQLHD.Size = new Size(162, 22);
            toolStripQLHD.Text = "Quản lý hóa đơn";
            toolStripQLHD.Click += toolStripMenuItem12_Click;
            // 
            // toolStripHoaDon
            // 
            toolStripHoaDon.Name = "toolStripHoaDon";
            toolStripHoaDon.Size = new Size(162, 22);
            toolStripHoaDon.Text = "Tạo hóa đơn";
            toolStripHoaDon.Click += toolStripHoaDon_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem13 });
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(68, 20);
            toolStripMenuItem9.Text = "Tìm kiếm";
            // 
            // toolStripMenuItem13
            // 
            toolStripMenuItem13.Name = "toolStripMenuItem13";
            toolStripMenuItem13.Size = new Size(120, 22);
            toolStripMenuItem13.Text = "Hóa đơn";
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, thôngKêNămToolStripMenuItem });
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(61, 20);
            toolStripMenuItem10.Text = "Báo cáo";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(157, 22);
            toolStripMenuItem1.Text = "Thông kê tháng";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click_1;
            // 
            // thôngKêNămToolStripMenuItem
            // 
            thôngKêNămToolStripMenuItem.Name = "thôngKêNămToolStripMenuItem";
            thôngKêNămToolStripMenuItem.Size = new Size(157, 22);
            thôngKêNămToolStripMenuItem.Text = "Thông kê năm";
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(62, 20);
            toolStripMenuItem11.Text = "Trợ giúp";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 63);
            label1.Name = "label1";
            label1.Size = new Size(246, 39);
            label1.TabIndex = 3;
            label1.Text = "Doanh thu hôm nay: ";
            // 
            // lbNgay
            // 
            lbNgay.BackColor = SystemColors.MenuHighlight;
            lbNgay.BorderStyle = BorderStyle.Fixed3D;
            lbNgay.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgay.Location = new Point(289, 63);
            lbNgay.Name = "lbNgay";
            lbNgay.Size = new Size(246, 39);
            lbNgay.TabIndex = 5;
            // 
            // lbThang
            // 
            lbThang.BackColor = SystemColors.MenuHighlight;
            lbThang.BorderStyle = BorderStyle.Fixed3D;
            lbThang.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbThang.Location = new Point(289, 114);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(246, 39);
            lbThang.TabIndex = 7;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Window;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 114);
            label4.Name = "label4";
            label4.Size = new Size(246, 39);
            label4.TabIndex = 6;
            label4.Text = "Doanh thu Tháng:";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(192, 22);
            toolStripMenuItem2.Text = "Quản lý khách hàng";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click_1;
            // 
            // MenuHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbThang);
            Controls.Add(label4);
            Controls.Add(lbNgay);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            Name = "MenuHome";
            Text = "MenuHome";
            FormClosed += MenuHome_FormClosed;
            Load += MenuHome_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripNV;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripSanPham;
        private ToolStripMenuItem toolStripLoai;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripQLHD;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem13;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private ToolStripMenuItem toolStripHoaDon;
        private Label label1;
        private Label lbNgay;
        private Label lbThang;
        private Label label4;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem thôngKêNămToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}