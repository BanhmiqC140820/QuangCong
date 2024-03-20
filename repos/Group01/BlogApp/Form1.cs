using BlogApp.DTO;
using BlogApp.Models;

namespace BlogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //?? d? liêu danh m?c lên cbbdanhmuc
            //B1: Lấy dữ liệu danh tục từ DB
            var db = new BlogDB();
            var ls = db.Categories
                .Select(e => new CategoryDTO
                {
                    ID = e.id,
                    Name = e.name,
                    AmountArticles = e.Articles.Count(),

                }).ToList();

            //B2: đổ dữ liệu vào cbbDanhMuc
            cbbDanhMuc.DataSource = ls;
            cbbDanhMuc.DisplayMember = "Display";
        }

        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = cbbDanhMuc.SelectedItem as CategoryDTO;
            if (selectedCategory != null)
            {
                var db = new BlogDB();
                var ls = db.Articles.Where(t => t.IdCategory == selectedCategory.ID).Select(t => new ArticlesDTO
                {
                    Id = t.Id,
                    IDCategory = t.IdCategory,
                    Title = t.Title,
                    Content = t.Content,
                }).ToList();
                label3.Text = ls.Count().ToString();
                articlesDTOBindingSource.DataSource = ls;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var f = new ArticleEdit();
            var selectedCategory = cbbDanhMuc.SelectedItem as CategoryDTO;
            if (f.ShowDialog() == DialogResult.OK)
            {
                var db = new BlogDB();
                var ls = db.Articles.Where(t => t.IdCategory == selectedCategory.ID).Select(t => new ArticlesDTO
                {
                    Id = t.Id,
                    IDCategory = t.IdCategory,
                    Title = t.Title,
                    Content = t.Content,
                }).ToList();
                label3.Text = ls.Count().ToString();
                articlesDTOBindingSource.DataSource = ls;

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var selArt = articlesDTOBindingSource.Current as ArticlesDTO;
            if (selArt != null)
            {
                var f= new ArticleEdit(selArt);
                if(ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}