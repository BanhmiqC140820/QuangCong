using MathBasic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathBasic
{
    public partial class FormLopHoc : Form
    {
        public FormLopHoc()
        {
            InitializeComponent();
            napfile();
        }
        void hienThiLop(LopHoc lopHoc)
        {
            txtLophoc.Text = lopHoc.TenLopHoc;
            txtPhonghoc.Text = lopHoc.PhongHoc;
            txtGV.Text = lopHoc.GiangVien;
            numTietTu.Value = lopHoc.TuTiet;
            numTietDen.Value = lopHoc.DenTiet;
            sinhVienBindingSource.DataSource = null;
            sinhVienBindingSource.DataSource = lopHoc.SinhViens;
        }
        void napfile()
        {
            if (File.Exists(filename))
            {
                var json = File.ReadAllText(filename);
                lophoc = LopHoc.Fromjson(json);
                hienThiLop(lophoc);
            }
        }
        LopHoc lophoc;
        string filename = "Lophoc.json";
        private void FormLopHoc_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            lophoc = LopHoc.GenerateLopHoc();
            hienThiLop(lophoc);
        }

        private void GridSV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var sinhvien = sinhVienBindingSource.Current as SinhVien;
            var formSV = new FormSV(sinhvien);
            formSV.ShowDialog();
        }

        private void btnLuuDS_Click(object sender, EventArgs e)
        {
            if (lophoc != null)
            {
                var json = lophoc.ToString();
                File.WriteAllText(filename, json);
                MessageBox.Show("đã lưu thành công", "Thông báo");
            }
        }

        private void btnNapFile_Click(object sender, EventArgs e)
        {
            napfile();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            var sinhvien = sinhVienBindingSource.Current as SinhVien;
            if (sinhvien != null)
            {
                lophoc.SinhViens.Remove(sinhvien);
                hienThiLop(lophoc);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var sinhvien = sinhVienBindingSource.Current as SinhVien;
            var formSV = new FormSV(sinhvien);
            formSV.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            var formSV = new FormSV(null);
            if (formSV.ShowDialog() == DialogResult.OK)
            {
                lophoc.SinhViens.Add(formSV.sinhvien);
                hienThiLop(lophoc);
            }
        }
    }
}
