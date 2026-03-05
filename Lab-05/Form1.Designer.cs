namespace Lab_05_SuDungListBox_Quan_Li_Tien_Phong_Kham
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            bttThemDS = new Button();
            label7 = new Label();
            txtTotal = new TextBox();
            bttThoat = new Button();
            bttCaculator = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            chkXRay = new CheckBox();
            chkWhitening = new CheckBox();
            chkClean = new CheckBox();
            label1 = new Label();
            txtKhachHang = new TextBox();
            groupBox2 = new GroupBox();
            bttXoaKhachhang = new Button();
            bttLoad = new Button();
            bttLuufile = new Button();
            listBoxCustomer = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bttThemDS);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(bttThoat);
            groupBox1.Controls.Add(bttCaculator);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(chkXRay);
            groupBox1.Controls.Add(chkWhitening);
            groupBox1.Controls.Add(chkClean);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtKhachHang);
            groupBox1.Location = new Point(25, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 382);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lí thanh toán";
            // 
            // bttThemDS
            // 
            bttThemDS.Location = new Point(196, 249);
            bttThemDS.Name = "bttThemDS";
            bttThemDS.Size = new Size(153, 39);
            bttThemDS.TabIndex = 15;
            bttThemDS.Text = "Thêm vào danh sách";
            bttThemDS.UseVisualStyleBackColor = true;
            bttThemDS.Click += bttThemDS_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 201);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 14;
            label7.Text = "Tổng tiền";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Info;
            txtTotal.Location = new Point(112, 201);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(237, 27);
            txtTotal.TabIndex = 13;
            // 
            // bttThoat
            // 
            bttThoat.BackColor = Color.Transparent;
            bttThoat.Location = new Point(93, 309);
            bttThoat.Name = "bttThoat";
            bttThoat.Size = new Size(164, 39);
            bttThoat.TabIndex = 12;
            bttThoat.Text = "Thoát";
            bttThoat.UseVisualStyleBackColor = false;
            bttThoat.Click += bttThoat_Click;
            // 
            // bttCaculator
            // 
            bttCaculator.Location = new Point(11, 249);
            bttCaculator.Name = "bttCaculator";
            bttCaculator.Size = new Size(137, 39);
            bttCaculator.TabIndex = 11;
            bttCaculator.Text = "Tính tổng tiền";
            bttCaculator.UseVisualStyleBackColor = true;
            bttCaculator.Click += bttCaculator_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 169);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 10;
            label6.Text = "300,000 ₫";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 139);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 9;
            label5.Text = "650,000 ₫";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 103);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 8;
            label4.Text = "2,500,000 ₫";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 73);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "500,000 ₫";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(112, 163);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(126, 27);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 167);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Trám răng";
            // 
            // chkXRay
            // 
            chkXRay.AutoSize = true;
            chkXRay.Location = new Point(6, 133);
            chkXRay.Name = "chkXRay";
            chkXRay.Size = new Size(154, 24);
            chkXRay.TabIndex = 4;
            chkXRay.Text = "X-quang hình răng";
            chkXRay.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            chkWhitening.AutoSize = true;
            chkWhitening.Location = new Point(6, 103);
            chkWhitening.Name = "chkWhitening";
            chkWhitening.Size = new Size(93, 24);
            chkWhitening.TabIndex = 3;
            chkWhitening.Text = "Tẩy trắng";
            chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkClean
            // 
            chkClean.AutoSize = true;
            chkClean.Location = new Point(6, 73);
            chkClean.Name = "chkClean";
            chkClean.Size = new Size(85, 24);
            chkClean.TabIndex = 2;
            chkClean.Text = "Cạo vôi ";
            chkClean.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên Khách Hàng";
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(128, 32);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(236, 27);
            txtKhachHang.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bttXoaKhachhang);
            groupBox2.Controls.Add(bttLoad);
            groupBox2.Controls.Add(bttLuufile);
            groupBox2.Controls.Add(listBoxCustomer);
            groupBox2.Location = new Point(413, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 387);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // bttXoaKhachhang
            // 
            bttXoaKhachhang.BackColor = Color.Cornsilk;
            bttXoaKhachhang.Location = new Point(14, 309);
            bttXoaKhachhang.Name = "bttXoaKhachhang";
            bttXoaKhachhang.Size = new Size(134, 39);
            bttXoaKhachhang.TabIndex = 15;
            bttXoaKhachhang.Text = "Xóa khách hàng";
            bttXoaKhachhang.UseVisualStyleBackColor = false;
            bttXoaKhachhang.Click += bttXoaKhachhang_Click;
            // 
            // bttLoad
            // 
            bttLoad.BackColor = Color.Honeydew;
            bttLoad.Location = new Point(257, 309);
            bttLoad.Name = "bttLoad";
            bttLoad.Size = new Size(88, 39);
            bttLoad.TabIndex = 14;
            bttLoad.Text = "Load File";
            bttLoad.UseVisualStyleBackColor = false;
            // 
            // bttLuufile
            // 
            bttLuufile.BackColor = Color.LemonChiffon;
            bttLuufile.Location = new Point(154, 309);
            bttLuufile.Name = "bttLuufile";
            bttLuufile.Size = new Size(88, 39);
            bttLuufile.TabIndex = 13;
            bttLuufile.Text = "Lưu File";
            bttLuufile.UseVisualStyleBackColor = false;
            bttLuufile.Click += bttLuufile_Click;
            // 
            // listBoxCustomer
            // 
            listBoxCustomer.FormattingEnabled = true;
            listBoxCustomer.Location = new Point(14, 44);
            listBoxCustomer.Name = "listBoxCustomer";
            listBoxCustomer.Size = new Size(331, 244);
            listBoxCustomer.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtKhachHang;
        private GroupBox groupBox2;
        private CheckBox chkXRay;
        private CheckBox chkWhitening;
        private CheckBox chkClean;
        private Label label2;
        private Button bttThoat;
        private Button bttCaculator;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private ListBox listBoxCustomer;
        private Button bttThemDS;
        private Label label7;
        private TextBox txtTotal;
        private Button bttLoad;
        private Button bttLuufile;
        private Button bttXoaKhachhang;
    }
}
