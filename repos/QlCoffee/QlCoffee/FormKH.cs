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
    public partial class FormKH : Form
    {
        public FormKH()
        {
            InitializeComponent();
            txtMaKH.ReadOnly = true;
            loaddata();
        }
        void loaddata()
        {
            var db = new CoffeDB();
            var ls = db.Customers.Select(e => new Customer
            {
                MaKH = e.MaKH,
                Hovaten = e.Hovaten,
                DiaChi = e.DiaChi,
                SDT = e.SDT,
                Email = e.Email,
            }).ToList();
            customerBindingSource.DataSource = ls;
        }
        void resetValue()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenKH.Text))
            {
                var db = new CoffeDB();
                var obj = new Customer
                {
                    MaKH = Customer.TaoMaKH(),
                    Hovaten = txtTenKH.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text,
                    TenDN = txtEmail.Text,
                    Pass = txtEmail.Text,
                };
                db.Customers.Add(obj);
                db.SaveChanges();
                txtMaKH.Text = obj.MaKH;
                loaddata();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selKH = customerBindingSource.Current as Customer;

            if (selKH != null)
            {
                txtMaKH.Text = selKH.MaKH;
                txtTenKH.Text = selKH.Hovaten;
                txtDiaChi.Text = selKH?.DiaChi;
                txtEmail.Text = selKH?.Email;
                txtSDT.Text = selKH?.SDT;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenKH.Text))
            {
                var db = new CoffeDB();
                var obj = db.Customers.Where(e => e.MaKH == txtMaKH.Text).FirstOrDefault();
                if (obj != null)
                {
                    obj.Hovaten = txtTenKH.Text;
                    obj.SDT = txtSDT.Text;
                    obj.DiaChi = txtDiaChi.Text;
                    obj.Email = txtEmail.Text;
                }
                db.SaveChanges();
                loaddata();
                resetValue();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var selKH = customerBindingSource.Current as Customer;
            if (selKH != null)
            {
                var db = new CoffeDB();
                db.Customers.Remove(selKH);
                db.SaveChanges();
                loaddata();
                resetValue();
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            var db = new CoffeDB();

            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                var lschange = db.Customers.Where(t => (t.Hovaten.ToLower().Contains(txtTimKiem.Text.ToLower()))).ToList();
                customerBindingSource.DataSource = lschange;
        
            }
            else
            {
                loaddata();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selKH = customerBindingSource.Current as Customer;

            if (selKH != null)
            {
                txtMaKH.Text = selKH.MaKH;
                txtTenKH.Text = selKH.Hovaten;
                txtDiaChi.Text = selKH?.DiaChi;
                txtEmail.Text = selKH?.Email;
                txtSDT.Text = selKH?.SDT;
            }
        }
    }
}
