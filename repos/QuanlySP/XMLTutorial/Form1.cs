using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Xml;
using System.Xml.Linq;


namespace XMLTutorial
{
    public partial class Form1 : Form
    {
        string filename = "book.xml";
        string folder = Path.Combine(Application.StartupPath, "data");
        public Form1()
        {
            InitializeComponent();
        }

        private void loadxml()
        {
           
            string filePath = Path.Combine(folder, filename);
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);


            List<Book> books = new List<Book>();
            // Populate DataTable from XML
            foreach (XmlNode bookNode in doc.SelectNodes("/bookstore/book"))
            {
                books.Add(new Book()
                {
                    Title= bookNode.SelectSingleNode("title").InnerText,
                    Author = bookNode.SelectSingleNode("author").InnerText,
                    Year = bookNode.SelectSingleNode("year").InnerText,
                    Price = double.Parse(bookNode.SelectSingleNode("price").InnerText),
                    Category = bookNode.Attributes["category"].Value
            });

            }

            // Set DataTable as the data source for DataGridView
            bookBindingSource.DataSource = books;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadxml();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(folder, filename);
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlElement newBookElement = doc.CreateElement("book");
            newBookElement.SetAttribute("category", txt_category.Text);

            XmlElement titleElement = doc.CreateElement("title");
            titleElement.InnerText = txt_title.Text;
            newBookElement.AppendChild(titleElement);

            XmlElement authorElement = doc.CreateElement("author");
            authorElement.InnerText = txt_author.Text;
            newBookElement.AppendChild(authorElement);

            XmlElement yearElement = doc.CreateElement("year");
            yearElement.InnerText = txt_year.Text.ToString();
            newBookElement.AppendChild(yearElement);

            XmlElement priceElement = doc.CreateElement("price");
            priceElement.InnerText = txt_price.Text.ToString();
            newBookElement.AppendChild(priceElement);

            // Thêm sách mới vào phần tử gốc
            XmlNode bookstoreNode = doc.SelectSingleNode("/bookstore");
            bookstoreNode.AppendChild(newBookElement);

            // Lưu lại tệp XML
            doc.Save(filePath);

            loadxml();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selBook = bookBindingSource.Current as Book;
            if (selBook != null)
            {
                txt_author.Text = selBook.Author;
                txt_category.Text = selBook.Category;
                txt_price.Text = selBook.Price.ToString();
                txt_title.Text = selBook.Title;
                txt_year.Text = selBook.Year;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(folder, filename);
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode bookNode = doc.SelectSingleNode($"/bookstore/book[title='{txt_title.Text}']");
            if (bookNode != null)
            {
                // Xóa sách khỏi cây XML
                XmlNode parent = bookNode.ParentNode;
                parent.RemoveChild(bookNode);

                // Lưu lại tệp XML
                doc.Save(filePath);
            }
            else
            {
                MessageBox.Show("Book not found in XML.");
            }
            loadxml();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(folder, filename);
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            var selBook = bookBindingSource.Current as Book;

            XmlNode bookNode = doc.SelectSingleNode($"/bookstore/book[title='{selBook.Title}']");
            if (bookNode != null)
            {
                // Chỉnh sửa thông tin sách
                bookNode.Attributes["category"].Value = txt_category.Text;
                bookNode.SelectSingleNode("title").InnerText = txt_title.Text;
                bookNode.SelectSingleNode("author").InnerText = txt_author.Text;
                bookNode.SelectSingleNode("year").InnerText = txt_year.Text;
                bookNode.SelectSingleNode("price").InnerText = txt_price.Text;

                // Lưu lại tệp XML
                doc.Save(filePath);
            }
            else
            {
                MessageBox.Show("Book not found in XML.");
            }
            loadxml();
        }
    }


}
