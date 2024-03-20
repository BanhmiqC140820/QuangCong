using System.Data.SqlClient;


namespace QuanLyCofffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void LoadSp()
        {
            var db = new Model1();
            var ls = db.Coffes.Select(Coffe => new Coffe()).ToList();
        }
        private void button1_Click(object sender, EventArgs e, List<Coffe> ls)
        {
            var db = new Model1();
            var ls1 = db.Coffes.Select(Coffe => new Coffe()).ToList();
            foreach (var c in ls1)
            {
                String output = "output=" + c.TenSanPHam;
                MessageBox.Show(output);
            }
        }
    }
}