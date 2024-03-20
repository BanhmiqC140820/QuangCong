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

namespace QlCoffee
{
    public partial class FormPrint : Form
    {
        HoaDon hd;
        public FormPrint(HoaDon hd)
        {
            InitializeComponent();
            loaddata(hd);
            this.hd = hd;
        }
        void loaddata(HoaDon hd)
        {
             if(hd != null) {
                var db = new CoffeDB();
                var lsChiTietHD = db.ChiTietHDs.Join(
                db.Coffes,
                ChiTietHD => ChiTietHD.MaSanPham,
                Coffe => Coffe.MaSanPham,
                (ChiTietHD, Coffe) => new ChiTietHDDTO
                {
                    MaChiTietHD = ChiTietHD.MaChiTietHD,
                    MaSanPham = Coffe.MaSanPham,
                    Tensanpham = Coffe.TenSanPHam,
                    SoLuongMua = ChiTietHD.SoLuongMua,
                    DonGia = Coffe.Gia,
                    ThanhTien = Coffe.Gia * ChiTietHD.SoLuongMua,
                    MaHD = ChiTietHD.MaHD,
                }
                ).Where(ChiTietHD => ChiTietHD.MaHD == hd.MaHD).ToList();
                lbMaHD.Text = "Mã hóa đơn: " + hd.MaHDS;
                lbNgayBan.Text = "Ngày bán: " + hd.NgayMua;
                lbTongTien.Text = "Tông tiền: " + hd.TongTien;
                chiTietHDDTOBindingSource.DataSource = lsChiTietHD;
            }
        }
        private int mRow = 0;
        private bool newPage = true;


        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            printPreviewDialog.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Dictionary<System.Windows.Forms.Label, Point> labelsLocations = new Dictionary<Label, Point>
            {
                {label1, new Point(280,150) },
                {lbMaHD, new Point( 75,230) },
                {lbNgayBan, new Point( 75,250) },
                {lbTongTien, new Point( 75,270) }
            };

            foreach (var lb in labelsLocations)
            {
                Label key = lb.Key;
                System.Windows.Forms.Label lb1 = lb.Key;
                Point location = lb.Value;
                String text = lb1.Text;
                e.Graphics.DrawString(text, lb1.Font, Brushes.Black, location);
            }

            int pageWidth = e.MarginBounds.Width;
            int totalHeaderWidth = 0;

            DataGridViewRow headerRow = dataGridView1.Rows[0];

            // Calculate the total width of visible header cells
            foreach (DataGridViewCell headerCell in headerRow.Cells)
            {
                if (headerCell.Visible)
                {
                    totalHeaderWidth += headerCell.Size.Width;
                }
            }

            // Calculate the starting X coordinate to center the header row
            int startX = 75;
            int y = 370;

            foreach (DataGridViewCell headerCell in headerRow.Cells)
            {
                if (headerCell.Visible)
                {
                    Rectangle headerRect = new Rectangle(startX, y, headerCell.Size.Width, headerCell.Size.Height);
                    e.Graphics.FillRectangle(Brushes.LightGray, headerRect);
                    e.Graphics.DrawRectangle(Pens.Black, headerRect);
                    e.Graphics.DrawString(dataGridView1.Columns[headerCell.ColumnIndex].HeaderText,
                        dataGridView1.Font, Brushes.Black, headerRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    startX += headerRect.Width;
                }

            }
            y += dataGridView1.Rows[0].Height;
            int n = dataGridView1.RowCount;

            for (int i = mRow; i < n; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                startX = 75;
                foreach (DataGridViewCell Cell in row.Cells)
                {
                    if (Cell.Visible)
                    {
                        Rectangle cellRect = new Rectangle(startX, y, Cell.Size.Width, Cell.Size.Height);
                        e.Graphics.DrawRectangle(Pens.Black, cellRect);
                        e.Graphics.DrawString(Cell.FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, cellRect, new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center,

                        });
                        startX += cellRect.Width;
                    }

                }
                y += row.Height;
            }

            mRow = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
