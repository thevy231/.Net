namespace lab_03
{
    public partial class FormMayTinh : Form
    {
        public FormMayTinh()
        {
            InitializeComponent();
        }

        private void bttCong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            txtKetqua.Text = (n + m).ToString();
        }

        private void bttTru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            txtKetqua.Text = (n - m).ToString();
        }

        private void bttNhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            txtKetqua.Text = (n * m).ToString();
        }

        private void bttChia_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            if (m == 0)
            {
                MessageBox.Show("Không thể chia cho 0");
                return;
            }
            txtKetqua.Text = ((double)n / m).ToString();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = "";
            txtSom.Text = "";
            txtKetqua.Text = "";
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
