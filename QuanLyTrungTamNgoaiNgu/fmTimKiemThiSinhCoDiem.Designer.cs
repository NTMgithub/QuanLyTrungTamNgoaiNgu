
namespace QuanLyTrungTamNgoaiNgu
{
    partial class fmTimKiemThiSinhCoDiem
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
            this.dataGridViewbangDiemThiSinh = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.MaDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBaoDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbangDiemThiSinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewbangDiemThiSinh
            // 
            this.dataGridViewbangDiemThiSinh.AllowUserToAddRows = false;
            this.dataGridViewbangDiemThiSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbangDiemThiSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDangKy,
            this.SoBaoDanh,
            this.HoTen,
            this.MAPHONG,
            this.DiemNghe,
            this.DiemNoi,
            this.DiemDoc,
            this.DiemViet});
            this.dataGridViewbangDiemThiSinh.Location = new System.Drawing.Point(25, 389);
            this.dataGridViewbangDiemThiSinh.Name = "dataGridViewbangDiemThiSinh";
            this.dataGridViewbangDiemThiSinh.RowHeadersWidth = 51;
            this.dataGridViewbangDiemThiSinh.RowTemplate.Height = 24;
            this.dataGridViewbangDiemThiSinh.Size = new System.Drawing.Size(1378, 295);
            this.dataGridViewbangDiemThiSinh.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 66);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(590, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý điểm thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(25, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonTimKiem);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(27, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 103);
            this.panel2.TabIndex = 13;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonTimKiem.Location = new System.Drawing.Point(561, 50);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(130, 38);
            this.buttonTimKiem.TabIndex = 15;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBoxSoDienThoai);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(296, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(247, 75);
            this.panel9.TabIndex = 14;
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(13, 40);
            this.textBoxSoDienThoai.MaximumSize = new System.Drawing.Size(300, 35);
            this.textBoxSoDienThoai.MinimumSize = new System.Drawing.Size(120, 28);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(216, 28);
            this.textBoxSoDienThoai.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(13, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập số điện thoại";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxHoTen);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(22, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 75);
            this.panel3.TabIndex = 13;
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxHoTen.Location = new System.Drawing.Point(13, 40);
            this.textBoxHoTen.MaximumSize = new System.Drawing.Size(300, 35);
            this.textBoxHoTen.MinimumSize = new System.Drawing.Size(120, 28);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(216, 28);
            this.textBoxHoTen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(22, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1380, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "_________________ Bảng điểm của thí sinh ________________________________________" +
    "________________________________________________________________________________" +
    "_______________\r\n";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel14.Controls.Add(this.label2);
            this.panel14.Controls.Add(this.panel2);
            this.panel14.Controls.Add(this.label5);
            this.panel14.Controls.Add(this.dataGridViewbangDiemThiSinh);
            this.panel14.Location = new System.Drawing.Point(3, 77);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1422, 694);
            this.panel14.TabIndex = 9;
            // 
            // MaDangKy
            // 
            this.MaDangKy.DataPropertyName = "MADK";
            this.MaDangKy.HeaderText = "Mã Đăng Ký";
            this.MaDangKy.MinimumWidth = 6;
            this.MaDangKy.Name = "MaDangKy";
            this.MaDangKy.Width = 125;
            // 
            // SoBaoDanh
            // 
            this.SoBaoDanh.DataPropertyName = "SBD";
            this.SoBaoDanh.HeaderText = "Số Báo Danh";
            this.SoBaoDanh.MinimumWidth = 6;
            this.SoBaoDanh.Name = "SoBaoDanh";
            this.SoBaoDanh.Width = 135;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HOTEN";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // MAPHONG
            // 
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "Mã phòng";
            this.MAPHONG.MinimumWidth = 6;
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.Width = 125;
            // 
            // DiemNghe
            // 
            this.DiemNghe.DataPropertyName = "DIEMNGHE";
            this.DiemNghe.HeaderText = "Điểm nghe";
            this.DiemNghe.MinimumWidth = 6;
            this.DiemNghe.Name = "DiemNghe";
            this.DiemNghe.Width = 105;
            // 
            // DiemNoi
            // 
            this.DiemNoi.DataPropertyName = "DIEMNOI";
            this.DiemNoi.HeaderText = "Điểm nói";
            this.DiemNoi.MinimumWidth = 6;
            this.DiemNoi.Name = "DiemNoi";
            this.DiemNoi.Width = 95;
            // 
            // DiemDoc
            // 
            this.DiemDoc.DataPropertyName = "DIEMDOC";
            this.DiemDoc.HeaderText = "Điểm đọc";
            this.DiemDoc.MinimumWidth = 6;
            this.DiemDoc.Name = "DiemDoc";
            this.DiemDoc.Width = 95;
            // 
            // DiemViet
            // 
            this.DiemViet.DataPropertyName = "DIEMVIET";
            this.DiemViet.HeaderText = "Điểm viết";
            this.DiemViet.MinimumWidth = 6;
            this.DiemViet.Name = "DiemViet";
            this.DiemViet.Width = 95;
            // 
            // fmTimKiemThiSinhCoDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 777);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel14);
            this.Name = "fmTimKiemThiSinhCoDiem";
            this.Text = "fmTimKiemThiSinhCoDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbangDiemThiSinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewbangDiemThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBaoDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemViet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel14;
    }
}