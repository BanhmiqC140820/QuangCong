namespace QuanLy
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnHam = new PictureBox();
            slidebar = new FlowLayoutPanel();
            pnDashboard = new Panel();
            button1 = new Button();
            menuContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            menu = new Button();
            panel7 = new Panel();
            button6 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            MenuTransition = new System.Windows.Forms.Timer(components);
            SlidebarTrantions = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            slidebar.SuspendLayout();
            pnDashboard.SuspendLayout();
            menuContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 34);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(948, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 12);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "CODDING IDEASS";
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(10, 4);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(21, 24);
            btnHam.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // slidebar
            // 
            slidebar.BackColor = SystemColors.Desktop;
            slidebar.Controls.Add(pnDashboard);
            slidebar.Controls.Add(menuContainer);
            slidebar.Controls.Add(panel5);
            slidebar.Controls.Add(panel6);
            slidebar.Dock = DockStyle.Left;
            slidebar.FlowDirection = FlowDirection.TopDown;
            slidebar.Location = new Point(0, 34);
            slidebar.Name = "slidebar";
            slidebar.Size = new Size(209, 545);
            slidebar.TabIndex = 1;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(button1);
            pnDashboard.Location = new Point(3, 3);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(206, 45);
            pnDashboard.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-5, -17);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(223, 74);
            button1.TabIndex = 4;
            button1.Text = "           Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = SystemColors.Desktop;
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(panel7);
            menuContainer.Controls.Add(panel4);
            menuContainer.Location = new Point(3, 54);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(206, 45);
            menuContainer.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(menu);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 45);
            panel3.TabIndex = 4;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.Desktop;
            menu.ForeColor = SystemColors.ButtonHighlight;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(-5, -8);
            menu.Name = "menu";
            menu.Padding = new Padding(10, 0, 0, 0);
            menu.Size = new Size(223, 65);
            menu.TabIndex = 4;
            menu.Text = "           Menu";
            menu.TextAlign = ContentAlignment.MiddleLeft;
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(button6);
            panel7.Location = new Point(0, 45);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(210, 45);
            panel7.TabIndex = 6;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Desktop;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-5, -8);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(223, 65);
            button6.TabIndex = 4;
            button6.Text = "           Sub Menu 2";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(0, 90);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(210, 45);
            panel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Desktop;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-5, -8);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(223, 65);
            button3.TabIndex = 4;
            button3.Text = "           Sub Menu 1";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 105);
            panel5.Name = "panel5";
            panel5.Size = new Size(206, 45);
            panel5.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Desktop;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-5, -14);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(223, 74);
            button4.TabIndex = 4;
            button4.Text = "           About";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 156);
            panel6.Name = "panel6";
            panel6.Size = new Size(206, 45);
            panel6.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Desktop;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-5, -20);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(223, 74);
            button5.TabIndex = 4;
            button5.Text = "           Dashboard";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // MenuTransition
            // 
            MenuTransition.Interval = 10;
            MenuTransition.Tick += MenuTransition_Tick;
            // 
            // SlidebarTrantions
            // 
            SlidebarTrantions.Interval = 10;
            SlidebarTrantions.Tick += SlidebarTrantions_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1087, 579);
            Controls.Add(slidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            slidebar.ResumeLayout(false);
            pnDashboard.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel slidebar;
        private Panel pnDashboard;
        private Button button1;
        private Panel panel3;
        private Button menu;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private FlowLayoutPanel menuContainer;
        private Panel panel7;
        private Button button6;
        private Panel panel4;
        private Button button3;
        private System.Windows.Forms.Timer MenuTransition;
        private System.Windows.Forms.Timer SlidebarTrantions;
    }
}