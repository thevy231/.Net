namespace Lab_05_SuDungListBox_Quan_Li_Tien_Phong_Kham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GetPay()
        {
            // 1. Kiem tra ten khach hang
            if (string.IsNullOrWhiteSpace(txtKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng !", "Thông báo");
                return;
            }

            //2. tính toán
            double total = 0;
            if (chkClean.Checked) total += 500000;
            if (chkWhitening.Checked) total += 2500000;
            if (chkXRay.Checked) total += 650000;

            total += ((int)numericUpDown1.Value * 300000);

            txtTotal.Text = total.ToString();
        }
        private void bttCaculator_Click(object sender, EventArgs e)
        {
            GetPay();
        }

        private void bttThemDS_Click(object sender, EventArgs e)
        {
            string info = txtKhachHang.Text + " - " + txtTotal.Text;
            listBoxCustomer.Items.Add(info);
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn thoát không", "Thông báo");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttXoaKhachhang_Click(object sender, EventArgs e)
        {
            if (listBoxCustomer.SelectedIndex != -1)
            {
                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult dr = MessageBox.Show(
                    "Bạn có muốn xóa khách hàng đã chọn hay không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    // Xóa mục tại vị trí đang chọn
                    listBoxCustomer.Items.RemoveAt(listBoxCustomer.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn một khách hàng từ danh sách để xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void bttLuufile_Click(object sender, EventArgs e)
        {

        }
    }
}
