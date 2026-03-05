using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_03
{
    public partial class FormUocBoi : Form
    {
        public FormUocBoi()
        {
            InitializeComponent();
        }
        private int timUSCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        private int timBSCNN(int a, int b)
        {
            return (a * b) / timUSCLN(a, b);
        }
        private void bttTim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            if (rdUSCLN.Checked)
            {
                txtKetqua.Text = timUSCLN(a, b).ToString();
            }
            else if (rdBSCNN.Checked)
            {
                txtKetqua.Text = timBSCNN(a, b).ToString();
            }
        }

        private void rdUSCLN_CheckedChanged(object sender, EventArgs e)
        {
        

        }

        private void rdBSCNN_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void bttBoqua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetqua.Text = "";
            rdBSCNN.Checked = false;
            rdUSCLN.Checked = false;
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo");
            Close();
        }
    }
}
