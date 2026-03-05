namespace lab04_bai4_bai_5
{
    partial class FrmThaotacso
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
            components = new System.ComponentModel.Container();
            btXoaphantucuoi = new Button();
            btXoaphantudau = new Button();
            btXoaphantudangchon = new Button();
            btLecuoi = new Button();
            btChonchandau = new Button();
            btTang2 = new Button();
            btKetthuc = new Button();
            lstKetqua = new ListBox();
            btCapnhat = new Button();
            txtSonguyen = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btXoaphantucuoi
            // 
            btXoaphantucuoi.BackColor = SystemColors.ActiveCaption;
            btXoaphantucuoi.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btXoaphantucuoi.Location = new Point(292, 303);
            btXoaphantucuoi.Name = "btXoaphantucuoi";
            btXoaphantucuoi.Size = new Size(187, 29);
            btXoaphantucuoi.TabIndex = 21;
            btXoaphantucuoi.Text = "Xóa phần tử cuối";
            btXoaphantucuoi.UseVisualStyleBackColor = false;
            // 
            // btXoaphantudau
            // 
            btXoaphantudau.BackColor = SystemColors.ActiveCaption;
            btXoaphantudau.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btXoaphantudau.Location = new Point(292, 260);
            btXoaphantudau.Name = "btXoaphantudau";
            btXoaphantudau.Size = new Size(187, 29);
            btXoaphantudau.TabIndex = 20;
            btXoaphantudau.Text = "Xóa phần tử đầu";
            btXoaphantudau.UseVisualStyleBackColor = false;
            // 
            // btXoaphantudangchon
            // 
            btXoaphantudangchon.BackColor = SystemColors.ActiveCaption;
            btXoaphantudangchon.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btXoaphantudangchon.Location = new Point(292, 216);
            btXoaphantudangchon.Name = "btXoaphantudangchon";
            btXoaphantudangchon.Size = new Size(187, 29);
            btXoaphantudangchon.TabIndex = 19;
            btXoaphantudangchon.Text = "Xóa phần tử đang chọn";
            btXoaphantudangchon.UseVisualStyleBackColor = false;
            // 
            // btLecuoi
            // 
            btLecuoi.BackColor = SystemColors.ActiveCaption;
            btLecuoi.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLecuoi.Location = new Point(292, 169);
            btLecuoi.Name = "btLecuoi";
            btLecuoi.Size = new Size(187, 29);
            btLecuoi.TabIndex = 18;
            btLecuoi.Text = "chọn số lẻ cuối";
            btLecuoi.UseVisualStyleBackColor = false;
            // 
            // btChonchandau
            // 
            btChonchandau.BackColor = SystemColors.ActiveCaption;
            btChonchandau.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btChonchandau.Location = new Point(292, 120);
            btChonchandau.Name = "btChonchandau";
            btChonchandau.Size = new Size(187, 29);
            btChonchandau.TabIndex = 17;
            btChonchandau.Text = "Chọn số chẵn đầu";
            btChonchandau.UseVisualStyleBackColor = false;
            // 
            // btTang2
            // 
            btTang2.BackColor = SystemColors.ActiveCaption;
            btTang2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTang2.Location = new Point(292, 68);
            btTang2.Name = "btTang2";
            btTang2.Size = new Size(187, 29);
            btTang2.TabIndex = 16;
            btTang2.Text = "Tăng mỗi phần tử lên 2";
            btTang2.UseVisualStyleBackColor = false;
            // 
            // btKetthuc
            // 
            btKetthuc.BackColor = Color.Red;
            btKetthuc.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKetthuc.Location = new Point(218, 347);
            btKetthuc.Name = "btKetthuc";
            btKetthuc.Size = new Size(94, 29);
            btKetthuc.TabIndex = 15;
            btKetthuc.Text = "Kết thúc";
            btKetthuc.UseVisualStyleBackColor = false;
            btKetthuc.Click += btKetthuc_Click;
            // 
            // lstKetqua
            // 
            lstKetqua.BackColor = SystemColors.Info;
            lstKetqua.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstKetqua.ForeColor = SystemColors.WindowText;
            lstKetqua.FormattingEnabled = true;
            lstKetqua.Location = new Point(22, 68);
            lstKetqua.Name = "lstKetqua";
            lstKetqua.Size = new Size(220, 264);
            lstKetqua.TabIndex = 14;
            // 
            // btCapnhat
            // 
            btCapnhat.BackColor = SystemColors.ActiveCaption;
            btCapnhat.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCapnhat.Location = new Point(395, 12);
            btCapnhat.Name = "btCapnhat";
            btCapnhat.Size = new Size(94, 29);
            btCapnhat.TabIndex = 13;
            btCapnhat.Text = "Cập nhật";
            btCapnhat.UseVisualStyleBackColor = false;
            // 
            // txtSonguyen
            // 
            txtSonguyen.BackColor = SystemColors.Info;
            txtSonguyen.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSonguyen.Location = new Point(170, 12);
            txtSonguyen.Name = "txtSonguyen";
            txtSonguyen.Size = new Size(198, 28);
            txtSonguyen.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 11;
            label1.Text = "Nhập số nguyên";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmThaotacso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(btXoaphantucuoi);
            Controls.Add(btXoaphantudau);
            Controls.Add(btXoaphantudangchon);
            Controls.Add(btLecuoi);
            Controls.Add(btChonchandau);
            Controls.Add(btTang2);
            Controls.Add(btKetthuc);
            Controls.Add(lstKetqua);
            Controls.Add(btCapnhat);
            Controls.Add(txtSonguyen);
            Controls.Add(label1);
            Name = "FrmThaotacso";
            Text = "FrmThaotacso";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btXoaphantucuoi;
        private Button btXoaphantudau;
        private Button btXoaphantudangchon;
        private Button btLecuoi;
        private Button btChonchandau;
        private Button btTang2;
        private Button btKetthuc;
        private ListBox lstKetqua;
        private Button btCapnhat;
        private TextBox txtSonguyen;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}