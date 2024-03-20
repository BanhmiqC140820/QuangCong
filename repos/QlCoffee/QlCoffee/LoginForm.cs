using QLCoffee.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlCoffee
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public NhanVien nv;
        private void button1_Click(object sender, EventArgs e)
        {
            var db = new CoffeDB();
            var obj = db.UserAdmins.Where(t => (t.TenDN == textBox1.Text && t.Pass == textBox2.Text)).FirstOrDefault();
            if (obj != null)
            {
                var f = new MenuHome();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }
            else
            {
                var nv=db.NhanViens.Where(t => (t.TenDN==textBox1.Text && t.Pass==textBox2.Text)).FirstOrDefault();
                if (nv != null)
                {
                    var f = new MenuHome(nv);
                    f.Show();
                    this.Hide();
                    f.DangXuat += F_DangXuat;
                    return;
                }
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập");
            }
        }

        private void F_DangXuat(object? sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            (sender as MenuHome).isThoat = false;

            (sender as MenuHome).Close();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
