namespace lab06
{
    partial class frmQuanlisinhvien
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
            txtMaSV = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            btCapnhat = new Button();
            btXoa = new Button();
            btThoat = new Button();
            label3 = new Label();
            txtTimkiem = new TextBox();
            btTimkiem = new Button();
            label4 = new Label();
            lvDanhSach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btPhai = new Button();
            btTrai = new Button();
            btTatcatraisangphai = new Button();
            btTatcatraisangtrai = new Button();
            lvDaChon = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // txtMaSV
            // 
            txtMaSV.BackColor = SystemColors.Info;
            txtMaSV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaSV.Location = new Point(12, 47);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(204, 30);
            txtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 22);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = SystemColors.Info;
            txtHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(274, 47);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(225, 30);
            txtHoTen.TabIndex = 3;
            // 
            // btCapnhat
            // 
            btCapnhat.BackColor = Color.LightCoral;
            btCapnhat.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCapnhat.Location = new Point(554, 42);
            btCapnhat.Name = "btCapnhat";
            btCapnhat.Size = new Size(103, 35);
            btCapnhat.TabIndex = 4;
            btCapnhat.Text = "cập nhật";
            btCapnhat.UseVisualStyleBackColor = false;
            btCapnhat.Click += btCapnhat_Click;
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.LightCoral;
            btXoa.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btXoa.Location = new Point(679, 42);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(103, 35);
            btXoa.TabIndex = 5;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click_1;
            // 
            // btThoat
            // 
            btThoat.BackColor = Color.LightCoral;
            btThoat.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThoat.Location = new Point(808, 42);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(103, 35);
            btThoat.TabIndex = 6;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(167, 22);
            label3.TabIndex = 7;
            label3.Text = "Danh sách sinh viên";
            // 
            // txtTimkiem
            // 
            txtTimkiem.BackColor = SystemColors.Info;
            txtTimkiem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimkiem.Location = new Point(344, 109);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(278, 30);
            txtTimkiem.TabIndex = 8;
            // 
            // btTimkiem
            // 
            btTimkiem.BackColor = Color.LightCoral;
            btTimkiem.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTimkiem.Location = new Point(235, 106);
            btTimkiem.Name = "btTimkiem";
            btTimkiem.Size = new Size(103, 35);
            btTimkiem.TabIndex = 9;
            btTimkiem.Text = "Tìm kiếm";
            btTimkiem.UseVisualStyleBackColor = false;
           
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(744, 119);
            label4.Name = "label4";
            label4.Size = new Size(157, 22);
            label4.TabIndex = 10;
            label4.Text = "Danh sách đã chọn";
            // 
            // lvDanhSach
            // 
            lvDanhSach.BackColor = SystemColors.Info;
            lvDanhSach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvDanhSach.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvDanhSach.Location = new Point(12, 156);
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(351, 282);
            lvDanhSach.TabIndex = 11;
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "MSV";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Họ và tên";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // btPhai
            // 
            btPhai.BackColor = Color.LightCoral;
            btPhai.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btPhai.Location = new Point(410, 172);
            btPhai.Name = "btPhai";
            btPhai.Size = new Size(103, 35);
            btPhai.TabIndex = 12;
            btPhai.Text = ">";
            btPhai.UseVisualStyleBackColor = false;
            btPhai.Click += btPhai_Click;
            // 
            // btTrai
            // 
            btTrai.BackColor = Color.LightCoral;
            btTrai.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTrai.Location = new Point(410, 229);
            btTrai.Name = "btTrai";
            btTrai.Size = new Size(103, 35);
            btTrai.TabIndex = 13;
            btTrai.Text = "<";
            btTrai.UseVisualStyleBackColor = false;
            btTrai.Click += btTrai_Click_1;
            // 
            // btTatcatraisangphai
            // 
            btTatcatraisangphai.BackColor = Color.LightCoral;
            btTatcatraisangphai.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTatcatraisangphai.Location = new Point(410, 287);
            btTatcatraisangphai.Name = "btTatcatraisangphai";
            btTatcatraisangphai.Size = new Size(103, 35);
            btTatcatraisangphai.TabIndex = 14;
            btTatcatraisangphai.Text = ">>";
            btTatcatraisangphai.UseVisualStyleBackColor = false;
            btTatcatraisangphai.Click += btTatcatraisangphai_Click;
            // 
            // btTatcatraisangtrai
            // 
            btTatcatraisangtrai.BackColor = Color.LightCoral;
            btTatcatraisangtrai.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTatcatraisangtrai.Location = new Point(410, 347);
            btTatcatraisangtrai.Name = "btTatcatraisangtrai";
            btTatcatraisangtrai.Size = new Size(103, 35);
            btTatcatraisangtrai.TabIndex = 15;
            btTatcatraisangtrai.Text = "<<";
            btTatcatraisangtrai.UseVisualStyleBackColor = false;
            // 
            // lvDaChon
            // 
            lvDaChon.BackColor = SystemColors.Info;
            lvDaChon.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            lvDaChon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvDaChon.Location = new Point(563, 145);
            lvDaChon.Name = "lvDaChon";
            lvDaChon.Size = new Size(351, 282);
            lvDaChon.TabIndex = 16;
            lvDaChon.UseCompatibleStateImageBehavior = false;
            lvDaChon.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "STT";
            columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "MSV";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Họ và tên";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 150;
            // 
            // frmQuanlisinhvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 450);
            Controls.Add(lvDaChon);
            Controls.Add(btTatcatraisangtrai);
            Controls.Add(btTatcatraisangphai);
            Controls.Add(btTrai);
            Controls.Add(btPhai);
            Controls.Add(lvDanhSach);
            Controls.Add(label4);
            Controls.Add(btTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(label3);
            Controls.Add(btThoat);
            Controls.Add(btXoa);
            Controls.Add(btCapnhat);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(txtMaSV);
            Controls.Add(label1);
            Name = "frmQuanlisinhvien";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaSV;
        private Label label2;
        private TextBox txtHoTen;
        private Button btCapnhat;
        private Button btXoa;
        private Button btThoat;
        private Label label3;
        private TextBox txtTimkiem;
        private Button btTimkiem;
        private Label label4;
        private ListView lvDanhSach;
        private Button btPhai;
        private Button btTrai;
        private Button btTatcatraisangphai;
        private Button btTatcatraisangtrai;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lvDaChon;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
