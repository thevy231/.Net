namespace lab07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "Nguyễn Văn " + i.ToString();
                item.SubItems.Add("01/01/200" + i);
                item.SubItems.Add("Địa chỉ " + i.ToString());
                item.SubItems.Add("012345678" + i.ToString());

                lvDanhSachNhanVien.Items.Add(item);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbHoten.Text.Trim().Length > 0)
            {
                ListViewItem item = new ListViewItem();
                item.Text = tbHoten.Text;
                item.SubItems.Add(dtpNgaysinh.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(tbDiachi.Text);
                item.SubItems.Add(tbDienthoai.Text);

                lvDanhSachNhanVien.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ và tên trước khi thêm");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                // Hiển thị dialog xác nhận
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa nhân viên này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Nếu người dùng nhấn "Yes" mới xóa
                if (result == DialogResult.Yes)
                {
                    lvDanhSachNhanVien.Items.Remove(lvDanhSachNhanVien.SelectedItems[0]);

                    // Xóa dữ liệu trên form
                    tbHoten.Text = "";
                    dtpNgaysinh.Value = DateTime.Now;
                    tbDiachi.Text = "";
                    tbDienthoai.Text = "";
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn một nhân viên để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void chonMotDong(object sender, EventArgs e)
        {
            if (lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                try
                {
                    tbHoten.Text = lvDanhSachNhanVien.SelectedItems[0].SubItems[0].Text;

                    string ngayStr = lvDanhSachNhanVien.SelectedItems[0].SubItems[1].Text;

                    // Parse với CultureInfo
                    System.Globalization.CultureInfo cultureInfo =
                        new System.Globalization.CultureInfo("en-US");

                    if (DateTime.TryParseExact(
                        ngayStr,
                        "dd/MM/yyyy",
                        cultureInfo,
                        System.Globalization.DateTimeStyles.None,
                        out DateTime ngaySinh))
                    {
                        dtpNgaysinh.Value = ngaySinh;
                    }
                    else
                    {
                        MessageBox.Show("Định dạng ngày không hợp lệ: " + ngayStr);
                    }

                    tbDiachi.Text = lvDanhSachNhanVien.SelectedItems[0].SubItems[2].Text;
                    tbDienthoai.Text = lvDanhSachNhanVien.SelectedItems[0].SubItems[3].Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                lvDanhSachNhanVien.SelectedItems[0].SubItems[0].Text = tbHoten.Text;
                lvDanhSachNhanVien.SelectedItems[0].SubItems[1].Text = dtpNgaysinh.Value.ToString("dd/MM/yyyy");
                lvDanhSachNhanVien.SelectedItems[0].SubItems[2].Text = tbDiachi.Text;
                lvDanhSachNhanVien.SelectedItems[0].SubItems[3].Text = tbDienthoai.Text;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Bạn có chắc chắn muốn thoát ứng dụng?",
             "Xác nhận thoát",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2  // Mặc định chọn "No"
         );

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
