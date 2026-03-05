namespace lab_03
{
    partial class FormUocBoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rdBSCNN = new RadioButton();
            rdUSCLN = new RadioButton();
            groupBox3 = new GroupBox();
            bttThoat = new Button();
            bttBoqua = new Button();
            bttTim = new Button();
            txtKetqua = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB.Location = new Point(79, 83);
            txtB.Name = "txtB";
            txtB.Size = new Size(450, 38);
            txtB.TabIndex = 3;
            txtB.TextAlign = HorizontalAlignment.Center;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtA.Location = new Point(79, 32);
            txtA.Name = "txtA";
            txtA.Size = new Size(450, 38);
            txtA.TabIndex = 2;
            txtA.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 90);
            label2.Name = "label2";
            label2.Size = new Size(27, 31);
            label2.TabIndex = 1;
            label2.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(29, 31);
            label1.TabIndex = 0;
            label1.Text = "A";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdBSCNN);
            groupBox2.Controls.Add(rdUSCLN);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(627, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(161, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn tìm";
            // 
            // rdBSCNN
            // 
            rdBSCNN.AutoSize = true;
            rdBSCNN.Location = new Point(11, 77);
            rdBSCNN.Name = "rdBSCNN";
            rdBSCNN.Size = new Size(97, 32);
            rdBSCNN.TabIndex = 1;
            rdBSCNN.TabStop = true;
            rdBSCNN.Text = "BSCNN";
            rdBSCNN.UseVisualStyleBackColor = true;
            rdBSCNN.CheckedChanged += rdBSCNN_CheckedChanged;
            // 
            // rdUSCLN
            // 
            rdUSCLN.AutoSize = true;
            rdUSCLN.Location = new Point(11, 39);
            rdUSCLN.Name = "rdUSCLN.";
            rdUSCLN.Size = new Size(94, 32);
            rdUSCLN.TabIndex = 0;
            rdUSCLN.TabStop = true;
            rdUSCLN.Text = "USCLN";
            rdUSCLN.UseVisualStyleBackColor = true;
            rdUSCLN.CheckedChanged += rdUSCLN_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bttThoat);
            groupBox3.Controls.Add(bttBoqua);
            groupBox3.Controls.Add(bttTim);
            groupBox3.Controls.Add(txtKetqua);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(28, 205);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(723, 143);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả";
            // 
            // bttThoat
            // 
            bttThoat.Location = new Point(469, 100);
            bttThoat.Name = "bttThoat";
            bttThoat.Size = new Size(94, 37);
            bttThoat.TabIndex = 3;
            bttThoat.Text = "Thoát";
            bttThoat.UseVisualStyleBackColor = true;
            bttThoat.Click += bttThoat_Click;
            // 
            // bttBoqua
            // 
            bttBoqua.Location = new Point(319, 100);
            bttBoqua.Name = "bttBoqua";
            bttBoqua.Size = new Size(94, 37);
            bttBoqua.TabIndex = 2;
            bttBoqua.Text = "Bỏ qua";
            bttBoqua.UseVisualStyleBackColor = true;
            bttBoqua.Click += bttBoqua_Click;
            // 
            // bttTim
            // 
            bttTim.Location = new Point(167, 100);
            bttTim.Name = "bttTim";
            bttTim.Size = new Size(94, 37);
            bttTim.TabIndex = 1;
            bttTim.Text = "Tìm";
            bttTim.UseVisualStyleBackColor = true;
            bttTim.Click += bttTim_Click;
            // 
            // txtKetqua
            // 
            txtKetqua.BackColor = SystemColors.Info;
            txtKetqua.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKetqua.Location = new Point(79, 33);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.Size = new Size(625, 47);
            txtKetqua.TabIndex = 0;
            txtKetqua.TextAlign = HorizontalAlignment.Center;
            // 
            // FormUocBoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 360);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormUocBoi";
            Text = "FormUocBoi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtB;
        private TextBox txtA;
        private GroupBox groupBox2;
        private RadioButton rdBSCNN;
        private RadioButton rdUSCLN;
        private GroupBox groupBox3;
        private TextBox txtKetqua;
        private Button bttThoat;
        private Button bttBoqua;
        private Button bttTim;
    }
}