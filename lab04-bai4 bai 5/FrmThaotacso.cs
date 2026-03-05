using System;
using System.Windows.Forms;

namespace lab04_bai4_bai_5
{
    public partial class FrmThaotacso : Form
    {
        public FrmThaotacso()
        {
            InitializeComponent();
        }

        private void txtSonguyen_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0)
                if (!char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                    errorProvider1.SetError(ctr, "Vui lòng nhập số nguyên");
                else
                    errorProvider1.Clear();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Add(txtSonguyen.Text);
            txtSonguyen.Text = "";
            txtSonguyen.Focus();
        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstKetqua.Items.Count; i++)
            {
                int x = int.Parse(lstKetqua.Items[i].ToString()) + 2;
                lstKetqua.Items[i] = x.ToString();
            }
        }

        private void btChonchandau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstKetqua.Items.Count; i++)
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 0)
                {
                    lstKetqua.SelectedIndex = i;
                    break;
                }
        }

        private void btLecuoi_Click(object sender, EventArgs e)
        {
            for (int i = lstKetqua.Items.Count - 1; i >= 0; i--)
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 1)
                {
                    lstKetqua.SelectedIndex = i;
                    break;
                }
        }

        private void btXoaphantudangchon_Click(object sender, EventArgs e)
        {
            while (lstKetqua.SelectedItems.Count > 0)
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[0]);
        }

        private void btXoaphantudau_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.RemoveAt(0);
        }

        private void btXoaphantucuoi_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.RemoveAt(lstKetqua.Items.Count - 1);
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
