using BlogApp.DTO;
using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogApp
{
    public partial class EditCategory : Form
    {
        CategoryDTO category;
        public EditCategory(CategoryDTO category = null)
        {
            InitializeComponent();
            this.category = category;
            if (category != null)
            {
                textBox1.Text = category.Name;
                label1.Text = "Cập nhật";
            }
            else { label1.Text = "Thêm mới"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                var obj = new Category
                {
                    name = textBox1.Text,
                };
                var db = new BlogDB();
                db.Categories.Add(obj);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                var db = new BlogDB();
                var obj = db.Categories.Where(t => t.id == category.ID).FirstOrDefault();
                if (obj != null)
                {
                    obj.name = textBox1.Text;
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
