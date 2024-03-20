namespace QuanLy
{
    public partial class Form1 : Form
    {
        Dashboard dashboard;
        public Form1()
        {
            InitializeComponent();
        }
        bool MenuExpand = false;
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (MenuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height == 145)
                {
                    MenuTransition.Stop();
                    MenuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 45)
                {
                    MenuTransition.Stop();
                    MenuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }
        bool SildebarExpand = true;
        private void SlidebarTrantions_Tick(object sender, EventArgs e)
        {
            if (SildebarExpand)
            {
                slidebar.Width -= 5;
                if (slidebar.Width <= 43)
                {
                    SildebarExpand = false;
                    SlidebarTrantions.Stop();
                }

            }
            else
            {
                slidebar.Width += 5;
                if (slidebar.Width >= 209)
                {
                    SildebarExpand = true;
                    SlidebarTrantions.Stop();

                    pnDashboard.Width = slidebar.Width;
                    panel5.Width = slidebar.Width;
                    panel6.Width = slidebar.Width;
                    menuContainer.Width = slidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            SlidebarTrantions.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard=new Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.FormBorderStyle = FormBorderStyle.None;
                dashboard.ShowInTaskbar = false;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard=null;
        }
    }
}