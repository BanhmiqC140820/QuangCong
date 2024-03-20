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
    public partial class ArticleEdit : Form
    {
        ArticlesDTO article;
        public ArticleEdit(ArticlesDTO article = null)
        {
            InitializeComponent();
            LoadCategory();
            if (article != null)
            {
                this.Text = "Cập nhật bài viết";
            }
        }
        private void LoadCategory()
        {
            var db = new BlogDB();
            var ls = db.Categories.Select(e => new CategoryDTO
            {
                ID = e.id,
                Name = e.name,
            }).ToList();
            comboBox1.DataSource = ls;
            comboBox1.DisplayMember = "Display";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selCat = comboBox1.SelectedItem as CategoryDTO;
            int id = comboBox1.SelectedIndex;
            MessageBox.Show(selCat.Name + "  " + id);
            if (article == null)
            {
                var obj = new Article
                {
                    Title = textBox1.Text,
                    IdCategory = selCat.ID,
                    Content = textBox1.Text,
                    DateCreated = DateTime.Now,
                };
                var db = new BlogDB();
                MessageBox.Show(obj.IdCategory + "  " + obj.Title);
                db.Articles.Add(obj);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                var db = new BlogDB();
                var obj = db.Articles.Where(t => t.Id == article.Id).FirstOrDefault();
                if (obj != null)
                {
                    obj.Title = textBox1.Text;
                    obj.IdCategory = id + 1;
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
