using System;
using System.Windows.Forms;

namespace lab04_bai4_bai_5
{
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            InitializeComponent();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            lstBandau.Items.Add(txtHoten.Text);
            txtHoten.Text = "";
            txtHoten.Focus();
        }


        private void btTraisangphai_Click_1(object sender, EventArgs e)
        {
            int n = lstBandau.SelectedItems.Count;

            for (int i = 0; i < n; i++)
                lstKetqua.Items.Add(lstBandau.SelectedItems[i].ToString());

            for (int j = n - 1; j >= 0; j--)
                lstBandau.Items.Remove(lstBandau.SelectedItems[j]);
        }

        private void btTatcatraisangphai_Click_1(object sender, EventArgs e)
        {
            foreach (var item in lstBandau.Items)
                lstKetqua.Items.Add(item.ToString());

            lstBandau.Items.Clear();
        }

        private void btPhaisangtrai_Click_1(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count;

            for (int i = 0; i < n; i++)
                lstBandau.Items.Add(lstKetqua.SelectedItems[i].ToString());

            for (int j = n - 1; j >= 0; j--)
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[j]);
        }

        private void btTatcaphaisangtrai_Click_1(object sender, EventArgs e)
        {
            foreach (var item in lstKetqua.Items)
                lstBandau.Items.Add(item.ToString());

            lstKetqua.Items.Clear();
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            while (lstBandau.SelectedItems.Count > 0)
                lstBandau.Items.Remove(lstBandau.SelectedItems[0]);
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
