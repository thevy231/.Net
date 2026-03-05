namespace lab07
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            dtpNgaysinh = new DateTimePicker();
            tbDiachi = new TextBox();
            tbDienthoai = new TextBox();
            tbHoten = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btThem = new Button();
            btXoa = new Button();
            btSua = new Button();
            btThoat = new Button();
            groupBox2 = new GroupBox();
            lvDanhSachNhanVien = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 44);
            label1.Name = "label1";
            label1.Size = new Size(362, 35);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgaysinh);
            groupBox1.Controls.Add(tbDiachi);
            groupBox1.Controls.Add(tbDienthoai);
            groupBox1.Controls.Add(tbHoten);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(30, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(745, 143);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaysinh.Format = DateTimePickerFormat.Custom;
            dtpNgaysinh.Location = new Point(100, 81);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(250, 27);
            dtpNgaysinh.TabIndex = 7;
            // 
            // tbDiachi
            // 
            tbDiachi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDiachi.Location = new Point(471, 78);
            tbDiachi.Name = "tbDiachi";
            tbDiachi.Size = new Size(228, 30);
            tbDiachi.TabIndex = 6;
            // 
            // tbDienthoai
            // 
            tbDienthoai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDienthoai.Location = new Point(471, 22);
            tbDienthoai.Name = "tbDienthoai";
            tbDienthoai.Size = new Size(228, 30);
            tbDienthoai.TabIndex = 5;
            // 
            // tbHoten
            // 
            tbHoten.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHoten.Location = new Point(100, 28);
            tbHoten.Name = "tbHoten";
            tbHoten.Size = new Size(228, 30);
            tbHoten.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(367, 88);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(367, 32);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 2;
            label4.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 88);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 33);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // btThem
            // 
            btThem.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThem.Location = new Point(381, 231);
            btThem.Name = "btThem";
            btThem.Size = new Size(94, 29);
            btThem.TabIndex = 2;
            btThem.Text = "Thêm ";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btXoa
            // 
            btXoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btXoa.Location = new Point(481, 231);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(94, 29);
            btXoa.TabIndex = 3;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSua.Location = new Point(581, 231);
            btSua.Name = "btSua";
            btSua.Size = new Size(94, 29);
            btSua.TabIndex = 4;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btThoat
            // 
            btThoat.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThoat.Location = new Point(681, 231);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvDanhSachNhanVien);
            groupBox2.Location = new Point(30, 290);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(745, 239);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chung";
            // 
            // lvDanhSachNhanVien
            // 
            lvDanhSachNhanVien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvDanhSachNhanVien.FullRowSelect = true;
            lvDanhSachNhanVien.GridLines = true;
            lvDanhSachNhanVien.Location = new Point(14, 26);
            lvDanhSachNhanVien.Name = "lvDanhSachNhanVien";
            lvDanhSachNhanVien.Size = new Size(719, 213);
            lvDanhSachNhanVien.TabIndex = 1;
            lvDanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            lvDanhSachNhanVien.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Họ tên";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ngày sinh";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Địa chỉ";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Điện thoại";
            columnHeader4.Width = 180;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 541);
            Controls.Add(groupBox2);
            Controls.Add(btThoat);
            Controls.Add(btSua);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dtpNgaysinh;
        private TextBox tbDiachi;
        private TextBox tbDienthoai;
        private TextBox tbHoten;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btThem;
        private Button btXoa;
        private Button btSua;
        private Button btThoat;
        private GroupBox groupBox2;
        private ListView lvDanhSachNhanVien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
