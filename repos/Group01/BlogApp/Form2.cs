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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadCategory();
        }
        void LoadCategory()
        {
            var db = new BlogDB();
            var ls = db.Categories
                  .OrderBy(e => e.name).Select(e => new CategoryDTO
                  {
                      ID = e.id,
                      Name = e.name,
                      AmountArticles = e.Articles.Count(),
                  }).ToList();
            categoryDTOBindingSource.DataSource = ls;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            var selcat = categoryDTOBindingSource.Current as CategoryDTO;
            if (selcat != null)
            {
                var rs = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new BlogDB();
                    var obj = db.Categories.Where(t => t.id == selcat.ID).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Categories.Remove(obj);
                        db.SaveChanges();
                        LoadCategory();
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selcat1 = categoryDTOBindingSource.CurrencyManager;
            var selcat = categoryDTOBindingSource.Current as CategoryDTO;
            if (selcat != null)
            {
                var f = new EditCategory(selcat);
                if (f.ShowDialog() == DialogResult.OK)
                    LoadCategory();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var f = new EditCategory();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCategory();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var selcat= categoryDTOBindingSource.Current as CategoryDTO; 
            if (selcat != null) {
                var f= new EditCategory(selcat);
                if (f.ShowDialog() == DialogResult.OK)
                    LoadCategory();
            }
        }
    }
}
