using System;
using System.Windows.Forms;

namespace lab06
{
    public partial class frmQuanlisinhvien : Form
    {
        int sttTrai = 1;
        int sttPhai = 1;

        public frmQuanlisinhvien()
        {
            InitializeComponent();
        }

        bool kiemTraMaSV(string ma)
        {
            for (int i = 0; i < lvDanhSach.Items.Count; i++)
            {
                if (lvDanhSach.Items[i].SubItems[1].Text == ma)
                { return false; }
            }

            for (int i = 0; i < lvDanhSach.Items.Count; i++)
            {
                if (lvDanhSach.Items[i].SubItems[1].Text == ma)
                { return true; }
            }
            return true;
        }



        private void btPhai_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lvDanhSach.Items.Count)
            {
                if (lvDanhSach.Items[i].Selected == true)
                {
                    ListViewItem li = lvDanhSach.Items[i];
                    lvDanhSach.Items.RemoveAt(i);
                    lvDaChon.Items.Add(li);
                }
                else
                {
                    i++;
                }
            }
            danhSoThuTu(lvDanhSach);
            danhSoThuTu(lvDaChon);
        }



        private void btTatCaTrai_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDaChon.Items)
            {
                ListViewItem newItem = new ListViewItem(sttTrai.ToString());
                newItem.SubItems.Add(item.SubItems[1].Text);
                newItem.SubItems.Add(item.SubItems[2].Text);

                lvDanhSach.Items.Add(newItem);
                sttTrai++;
            }
            lvDaChon.Items.Clear();
        }




        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" || txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
            }
            else if (kiemTraMaSV(txtMaSV.Text.Trim()) == false)
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại, vui lòng nhập lại!", "Thông báo");
                txtMaSV.SelectAll();
                txtMaSV.Focus();
            }
            else
            {
                int stt = lvDanhSach.Items.Count + 1;

                ListViewItem li = new ListViewItem(stt.ToString());
                li.SubItems.Add(txtMaSV.Text.Trim());
                li.SubItems.Add(txtHoTen.Text.Trim());

                lvDanhSach.Items.Add(li);

                txtMaSV.Text = "";
                txtHoTen.Text = "";
                txtMaSV.Focus();
            }

        }

        private void danhSoThuTu(ListView lv)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].Text = (i + 1).ToString();
            }
        }


        private void btXoa_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lvDanhSach.Items.Count)
            {
                if (lvDanhSach.Items[i].Selected == true)
                {
                    lvDanhSach.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
                danhSoThuTu(lvDanhSach);
            }
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(
            "Bạn có muốn thoát?",
            "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tim(ListView lv, string text)
        {
            text = text.ToUpper();
            for (int i = 0; i < lv.Items.Count; i++)
            {
                string maSV = lv.Items[i].SubItems[1].Text.ToUpper();
                string hoTen = lv.Items[i].SubItems[2].Text.ToUpper();
                if (maSV.Contains(text) || hoTen.Contains(text))
                {
                    lv.Items[i].Selected = true;
                    lv.Items[i].EnsureVisible();
                    lv.Items[i].Focused = true;
                }
                else
                {
                    lv.Items[i].Selected = false;
                }
            }
        }

        private void thucHienTim()
        {
            tim(lvDanhSach, txtTimkiem.Text);
            txtTimkiem.SelectAll();
            txtTimkiem.Focus();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                thucHienTim();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            thucHienTim();
        }


        private void btTrai_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lvDaChon.Items.Count)
            {
                if (lvDaChon.Items[i].Selected == true)
                {
                    ListViewItem li = lvDaChon.Items[i];
                    lvDaChon.Items.RemoveAt(i);
                    lvDanhSach.Items.Add(li);
                }
                else
                {
                    i++;
                }
            }
            danhSoThuTu(lvDaChon);
            danhSoThuTu(lvDanhSach);
        }

        private void btTatcatraisangphai_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDanhSach.Items)
            {
                ListViewItem newItem = new ListViewItem(sttPhai.ToString());
                newItem.SubItems.Add(item.SubItems[1].Text);
                newItem.SubItems.Add(item.SubItems[2].Text);

                lvDaChon.Items.Add(newItem);
                sttPhai++;
            }
            lvDanhSach.Items.Clear();
        }

        private void btTatcatraisangtrai_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDaChon.Items)
            {
                ListViewItem newItem = new ListViewItem(sttTrai.ToString());
                newItem.SubItems.Add(item.SubItems[1].Text);
                newItem.SubItems.Add(item.SubItems[2].Text);

                lvDanhSach.Items.Add(newItem);
                sttTrai++;
            }
            lvDaChon.Items.Clear();
        }
    }
}
