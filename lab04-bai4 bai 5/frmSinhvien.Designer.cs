namespace lab04_bai4_bai_5
{
    partial class frmSinhvien
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
            label1 = new Label();
            label2 = new Label();
            btCapnhat = new Button();
            txtHoten = new TextBox();
            lstBandau = new ListBox();
            lstKetqua = new ListBox();
            btTraisangphai = new Button();
            btPhaisangtrai = new Button();
            btTatcatraisangphai = new Button();
            btTatcaphaisangtrai = new Button();
            btXoa = new Button();
            btKetthuc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 37);
            label1.Name = "label1";
            label1.Size = new Size(367, 35);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH SINH VIÊN ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 105);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // btCapnhat
            // 
            btCapnhat.BackColor = Color.LightCoral;
            btCapnhat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCapnhat.Location = new Point(533, 96);
            btCapnhat.Name = "btCapnhat";
            btCapnhat.Size = new Size(108, 35);
            btCapnhat.TabIndex = 4;
            btCapnhat.Text = "Cập nhật";
            btCapnhat.UseVisualStyleBackColor = false;
            btCapnhat.Click += btCapnhat_Click;
            // 
            // txtHoten
            // 
            txtHoten.BackColor = SystemColors.Info;
            txtHoten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoten.Location = new Point(148, 96);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(363, 34);
            txtHoten.TabIndex = 5;
            txtHoten.TextChanged += txtHoten_TextChanged;
            // 
            // lstBandau
            // 
            lstBandau.BackColor = SystemColors.Info;
            lstBandau.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBandau.FormattingEnabled = true;
            lstBandau.Location = new Point(33, 169);
            lstBandau.Name = "lstBandau";
            lstBandau.Size = new Size(211, 244);
            lstBandau.TabIndex = 6;
            // 
            // lstKetqua
            // 
            lstKetqua.BackColor = SystemColors.Info;
            lstKetqua.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstKetqua.FormattingEnabled = true;
            lstKetqua.Location = new Point(461, 169);
            lstKetqua.Name = "lstKetqua";
            lstKetqua.Size = new Size(213, 244);
            lstKetqua.TabIndex = 7;
            // 
            // btTraisangphai
            // 
            btTraisangphai.BackColor = Color.LightCoral;
            btTraisangphai.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTraisangphai.Location = new Point(250, 228);
            btTraisangphai.Name = "btTraisangphai";
            btTraisangphai.Size = new Size(94, 29);
            btTraisangphai.TabIndex = 8;
            btTraisangphai.Text = ">";
            btTraisangphai.UseVisualStyleBackColor = false;
            btTraisangphai.Click += btTraisangphai_Click_1;
            // 
            // btPhaisangtrai
            // 
            btPhaisangtrai.BackColor = Color.LightCoral;
            btPhaisangtrai.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btPhaisangtrai.Location = new Point(361, 228);
            btPhaisangtrai.Name = "btPhaisangtrai";
            btPhaisangtrai.Size = new Size(94, 29);
            btPhaisangtrai.TabIndex = 9;
            btPhaisangtrai.Text = "<";
            btPhaisangtrai.UseVisualStyleBackColor = false;
            btPhaisangtrai.Click += btPhaisangtrai_Click_1;
            // 
            // btTatcatraisangphai
            // 
            btTatcatraisangphai.BackColor = Color.LightCoral;
            btTatcatraisangphai.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTatcatraisangphai.Location = new Point(250, 284);
            btTatcatraisangphai.Name = "btTatcatraisangphai";
            btTatcatraisangphai.Size = new Size(94, 29);
            btTatcatraisangphai.TabIndex = 10;
            btTatcatraisangphai.Text = ">>";
            btTatcatraisangphai.UseVisualStyleBackColor = false;
            btTatcatraisangphai.Click += btTatcatraisangphai_Click_1;
            // 
            // btTatcaphaisangtrai
            // 
            btTatcaphaisangtrai.BackColor = Color.LightCoral;
            btTatcaphaisangtrai.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTatcaphaisangtrai.Location = new Point(361, 284);
            btTatcaphaisangtrai.Name = "btTatcaphaisangtrai";
            btTatcaphaisangtrai.Size = new Size(94, 29);
            btTatcaphaisangtrai.TabIndex = 11;
            btTatcaphaisangtrai.Text = "<<";
            btTatcaphaisangtrai.UseVisualStyleBackColor = false;
            btTatcaphaisangtrai.Click += btTatcaphaisangtrai_Click_1;
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.LightCoral;
            btXoa.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btXoa.Location = new Point(78, 419);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(94, 29);
            btXoa.TabIndex = 12;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click_1;
            // 
            // btKetthuc
            // 
            btKetthuc.BackColor = Color.LightCoral;
            btKetthuc.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKetthuc.Location = new Point(533, 422);
            btKetthuc.Name = "btKetthuc";
            btKetthuc.Size = new Size(94, 29);
            btKetthuc.TabIndex = 13;
            btKetthuc.Text = "Kết thúc";
            btKetthuc.UseVisualStyleBackColor = false;
            btKetthuc.Click += btKetthuc_Click;
            // 
            // frmSinhvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(699, 463);
            Controls.Add(btKetthuc);
            Controls.Add(btXoa);
            Controls.Add(btTatcaphaisangtrai);
            Controls.Add(btTatcatraisangphai);
            Controls.Add(btPhaisangtrai);
            Controls.Add(btTraisangphai);
            Controls.Add(lstKetqua);
            Controls.Add(lstBandau);
            Controls.Add(txtHoten);
            Controls.Add(btCapnhat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSinhvien";
            Text = "frmSinhvien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btCapnhat;
        private TextBox txtHoten;
        private ListBox lstBandau;
        private ListBox lstKetqua;
        private Button btTraisangphai;
        private Button btPhaisangtrai;
        private Button btTatcatraisangphai;
        private Button btTatcaphaisangtrai;
        private Button btXoa;
        private Button btKetthuc;
    }
}