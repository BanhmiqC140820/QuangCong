using QLCoffee.DTO;
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

namespace QLCoffee
{
    public partial class FormLoai : Form
    {
        LoaiDTO loai;
        public FormLoai(LoaiDTO loai = null)
        {
            InitializeComponent();
            this.loai = loai;
            if (loai != null)
            {
                textBox1.Text = loai.TenLoai;
                label1.Text = "Cập nhật loại";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loai != null)
            {
                if(!string.IsNullOrEmpty(textBox1.Text))
                {
                    var db= new CoffeDB();
                    var obj = db.Loais.Where(e => e.MaLoai == loai.MaLoai).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.TenLoai=textBox1.Text;
                        db.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                if(!string.IsNullOrEmpty (textBox1.Text))
                {
                    var db = new CoffeDB();
                    var obj = new Loai
                    {
                        MaLoai=Loai.TaoMaLoai(),
                        TenLoai=textBox1.Text
                    };
                    db.Loais.Add(obj);
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
