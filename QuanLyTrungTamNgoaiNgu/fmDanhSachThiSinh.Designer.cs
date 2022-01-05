
namespace QuanLyTrungTamNgoaiNgu
{
    partial class fmDanhSachThiSinh
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxKhoaThi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBaoDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(39, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Danh sách phòng thi hiện có";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lập phòng thi cho các khóa thi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 66);
            this.panel1.TabIndex = 6;
            // 
            // textBoxMaPhong
            // 
            this.textBoxMaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxMaPhong.Location = new System.Drawing.Point(127, 9);
            this.textBoxMaPhong.MaximumSize = new System.Drawing.Size(300, 35);
            this.textBoxMaPhong.MinimumSize = new System.Drawing.Size(200, 32);
            this.textBoxMaPhong.Name = "textBoxMaPhong";
            this.textBoxMaPhong.Size = new System.Drawing.Size(220, 32);
            this.textBoxMaPhong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phòng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimKiem.Location = new System.Drawing.Point(987, 29);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(130, 38);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxKhoaThi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(25, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 51);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // comboBoxKhoaThi
            // 
            this.comboBoxKhoaThi.FormattingEnabled = true;
            this.comboBoxKhoaThi.Location = new System.Drawing.Point(127, 13);
            this.comboBoxKhoaThi.MaximumSize = new System.Drawing.Size(220, 0);
            this.comboBoxKhoaThi.MinimumSize = new System.Drawing.Size(220, 0);
            this.comboBoxKhoaThi.Name = "comboBoxKhoaThi";
            this.comboBoxKhoaThi.Size = new System.Drawing.Size(220, 24);
            this.comboBoxKhoaThi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khóa";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBoxMaPhong);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(476, 24);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(356, 51);
            this.panel7.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenThiSinh,
            this.SoBaoDanh,
            this.MaPhong,
            this.TrinhDo,
            this.Khoa});
            this.dataGridView1.Location = new System.Drawing.Point(25, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 545);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel14.Controls.Add(this.label5);
            this.panel14.Controls.Add(this.btnTimKiem);
            this.panel14.Controls.Add(this.panel3);
            this.panel14.Controls.Add(this.dataGridView1);
            this.panel14.Controls.Add(this.panel7);
            this.panel14.Location = new System.Drawing.Point(1, 72);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1161, 694);
            this.panel14.TabIndex = 7;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // TenThiSinh
            // 
            this.TenThiSinh.FillWeight = 125F;
            this.TenThiSinh.HeaderText = "Tên Thí Sinh";
            this.TenThiSinh.MinimumWidth = 6;
            this.TenThiSinh.Name = "TenThiSinh";
            this.TenThiSinh.Width = 125;
            // 
            // SoBaoDanh
            // 
            this.SoBaoDanh.FillWeight = 125F;
            this.SoBaoDanh.HeaderText = "Số Báo Danh";
            this.SoBaoDanh.MinimumWidth = 6;
            this.SoBaoDanh.Name = "SoBaoDanh";
            this.SoBaoDanh.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.FillWeight = 125F;
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // TrinhDo
            // 
            this.TrinhDo.FillWeight = 125F;
            this.TrinhDo.HeaderText = "Trình Độ";
            this.TrinhDo.MinimumWidth = 6;
            this.TrinhDo.Name = "TrinhDo";
            this.TrinhDo.Width = 125;
            // 
            // Khoa
            // 
            this.Khoa.FillWeight = 125F;
            this.Khoa.HeaderText = "Khóa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.Width = 125;
            // 
            // fmDanhSachThiSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel14);
            this.Name = "fmDanhSachThiSinh";
            this.Text = "fmDanhSachThiSinh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxKhoaThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBaoDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.Panel panel14;
    }
}