namespace lab_03
{
    partial class FormMayTinh
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSon = new TextBox();
            txtSom = new TextBox();
            txtKetqua = new TextBox();
            bttCong = new Button();
            bttTru = new Button();
            bttNhan = new Button();
            bttChia = new Button();
            bttXoa = new Button();
            bttThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 28);
            label1.Name = "label1";
            label1.Size = new Size(646, 68);
            label1.TabIndex = 0;
            label1.Text = "Thực hiện các phép tính";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 116);
            label2.Name = "label2";
            label2.Size = new Size(72, 33);
            label2.TabIndex = 1;
            label2.Text = "Số N";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 181);
            label3.Name = "label3";
            label3.Size = new Size(77, 33);
            label3.TabIndex = 2;
            label3.Text = "Số M";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 238);
            label4.Name = "label4";
            label4.Size = new Size(101, 33);
            label4.TabIndex = 3;
            label4.Text = "Kết quả";
            // 
            // txtSon
            // 
            txtSon.BackColor = SystemColors.Info;
            txtSon.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSon.Location = new Point(214, 116);
            txtSon.Name = "txtSon";
            txtSon.Size = new Size(470, 39);
            txtSon.TabIndex = 4;
            txtSon.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSom
            // 
            txtSom.BackColor = SystemColors.Info;
            txtSom.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSom.Location = new Point(214, 181);
            txtSom.Name = "txtSom";
            txtSom.Size = new Size(470, 39);
            txtSom.TabIndex = 5;
            txtSom.TextAlign = HorizontalAlignment.Right;
            // 
            // txtKetqua
            // 
            txtKetqua.BackColor = SystemColors.Info;
            txtKetqua.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKetqua.Location = new Point(214, 238);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.ReadOnly = true;
            txtKetqua.Size = new Size(470, 39);
            txtKetqua.TabIndex = 6;
            txtKetqua.TextAlign = HorizontalAlignment.Right;
            // 
            // bttCong
            // 
            bttCong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttCong.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttCong.Location = new Point(39, 312);
            bttCong.Name = "bttCong";
            bttCong.Size = new Size(94, 29);
            bttCong.TabIndex = 7;
            bttCong.Text = "+";
            bttCong.UseVisualStyleBackColor = true;
            bttCong.Click += bttCong_Click;
            // 
            // bttTru
            // 
            bttTru.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttTru.Location = new Point(169, 312);
            bttTru.Name = "bttTru";
            bttTru.Size = new Size(94, 29);
            bttTru.TabIndex = 8;
            bttTru.Text = "-";
            bttTru.UseVisualStyleBackColor = true;
            bttTru.Click += bttTru_Click;
            // 
            // bttNhan
            // 
            bttNhan.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttNhan.Location = new Point(298, 312);
            bttNhan.Name = "bttNhan";
            bttNhan.Size = new Size(94, 29);
            bttNhan.TabIndex = 9;
            bttNhan.Text = "*";
            bttNhan.UseVisualStyleBackColor = true;
            bttNhan.Click += bttNhan_Click;
            // 
            // bttChia
            // 
            bttChia.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttChia.Location = new Point(418, 312);
            bttChia.Name = "bttChia";
            bttChia.Size = new Size(94, 29);
            bttChia.TabIndex = 10;
            bttChia.Text = "/";
            bttChia.UseVisualStyleBackColor = true;
            bttChia.Click += bttChia_Click;
            // 
            // bttXoa
            // 
            bttXoa.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttXoa.Location = new Point(537, 312);
            bttXoa.Name = "bttXoa";
            bttXoa.Size = new Size(94, 29);
            bttXoa.TabIndex = 11;
            bttXoa.Text = "Xóa";
            bttXoa.UseVisualStyleBackColor = true;
            bttXoa.Click += bttXoa_Click;
            // 
            // bttThoat
            // 
            bttThoat.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttThoat.Location = new Point(671, 312);
            bttThoat.Name = "bttThoat";
            bttThoat.Size = new Size(94, 29);
            bttThoat.TabIndex = 12;
            bttThoat.Text = "Thoát";
            bttThoat.UseVisualStyleBackColor = true;
            bttThoat.Click += bttThoat_Click;
            // 
            // fromMayTinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 412);
            Controls.Add(bttThoat);
            Controls.Add(bttXoa);
            Controls.Add(bttChia);
            Controls.Add(bttNhan);
            Controls.Add(bttTru);
            Controls.Add(bttCong);
            Controls.Add(txtKetqua);
            Controls.Add(txtSom);
            Controls.Add(txtSon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fromMayTinh";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSon;
        private TextBox txtSom;
        private TextBox txtKetqua;
        private Button bttCong;
        private Button bttTru;
        private Button bttNhan;
        private Button bttChia;
        private Button bttXoa;
        private Button bttThoat;
    }
}
