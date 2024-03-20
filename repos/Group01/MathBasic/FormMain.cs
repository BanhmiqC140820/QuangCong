namespace MathBasic
{
    public partial class FormMain : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public FormMain()
        {
            InitializeComponent();
        }
        private void process_click(object sender, EventArgs e)
        {
            double soThuNhat, soThuHai;
            if (!double.TryParse(txt1.Text, out soThuNhat))
            {
                errorProvider.SetError(txt1, "vui long nhập lại số thứ nhất :");
                txt1.Focus();
                return;
            }
            if (!double.TryParse(txt2.Text, out soThuHai))
            {
                errorProvider.SetError(txt2, "vui long nhập lại số thứ hai :");
                txt2.Focus();
                return;
            }
            Button button_click=(Button)sender;
            double kq;
            string ht;
            if(button_click!=null)
            {
                if (button_click.Tag is string tag)
                {
                    if (tag == "+")
                    {
                        kq = soThuNhat + soThuHai;
                        ht = $"{soThuNhat} + {soThuHai} = {kq}";
                        rtbKetqua.Text = ht;
                    }
                    if (tag == "-")
                    {
                        kq = soThuNhat - soThuHai;
                        ht = $"{soThuNhat} - {soThuHai} = {kq}";
                        rtbKetqua.Text = ht;
                    }
                    if (tag == "*")
                    {
                        kq = soThuNhat * soThuHai;
                        ht = $"{soThuNhat} * {soThuHai} = {kq}";
                        rtbKetqua.Text = ht;
                    }
                    if (tag == "/")
                    {
                        kq = soThuNhat / soThuHai;
                        ht = $"{soThuNhat} / {soThuHai} = {kq}";
                        rtbKetqua.Text = ht;
                    }
                }
            }

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new FormAuthor();
            f.ShowDialog();
        }
    }
}