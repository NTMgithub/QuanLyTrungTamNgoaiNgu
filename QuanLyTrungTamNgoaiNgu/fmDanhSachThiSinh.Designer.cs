
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
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachThiSinh = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPhong = new System.Windows.Forms.ComboBox();
            this.TenThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBaoDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachThiSinh)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(19, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Danh sách phòng thi hiện có";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel14.Controls.Add(this.label5);
            this.panel14.Controls.Add(this.btnTimKiem);
            this.panel14.Controls.Add(this.panel3);
            this.panel14.Controls.Add(this.dataGridViewDanhSachThiSinh);
            this.panel14.Controls.Add(this.panel7);
            this.panel14.Location = new System.Drawing.Point(0, 70);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(933, 502);
            this.panel14.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimKiem.Location = new System.Drawing.Point(652, 238);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(130, 38);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxKhoa);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(537, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 51);
            this.panel3.TabIndex = 6;
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Location = new System.Drawing.Point(115, 13);
            this.comboBoxKhoa.MaximumSize = new System.Drawing.Size(220, 0);
            this.comboBoxKhoa.MinimumSize = new System.Drawing.Size(220, 0);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(220, 24);
            this.comboBoxKhoa.TabIndex = 1;
            this.comboBoxKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxKhoa_SelectedIndexChanged);
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
            // dataGridViewDanhSachThiSinh
            // 
            this.dataGridViewDanhSachThiSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachThiSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThiSinh,
            this.SoBaoDanh});
            this.dataGridViewDanhSachThiSinh.Location = new System.Drawing.Point(22, 46);
            this.dataGridViewDanhSachThiSinh.Name = "dataGridViewDanhSachThiSinh";
            this.dataGridViewDanhSachThiSinh.RowHeadersWidth = 51;
            this.dataGridViewDanhSachThiSinh.RowTemplate.Height = 24;
            this.dataGridViewDanhSachThiSinh.Size = new System.Drawing.Size(453, 433);
            this.dataGridViewDanhSachThiSinh.TabIndex = 0;
            this.dataGridViewDanhSachThiSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachThiSinh_CellContentClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.comboBoxPhong);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(537, 142);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(356, 51);
            this.panel7.TabIndex = 1;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách thi sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 61);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxPhong
            // 
            this.comboBoxPhong.FormattingEnabled = true;
            this.comboBoxPhong.Location = new System.Drawing.Point(115, 13);
            this.comboBoxPhong.MaximumSize = new System.Drawing.Size(220, 0);
            this.comboBoxPhong.MinimumSize = new System.Drawing.Size(220, 0);
            this.comboBoxPhong.Name = "comboBoxPhong";
            this.comboBoxPhong.Size = new System.Drawing.Size(220, 24);
            this.comboBoxPhong.TabIndex = 2;
            // 
            // TenThiSinh
            // 
            this.TenThiSinh.DataPropertyName = "HOTEN";
            this.TenThiSinh.HeaderText = "Tên Thí Sinh";
            this.TenThiSinh.MinimumWidth = 6;
            this.TenThiSinh.Name = "TenThiSinh";
            this.TenThiSinh.Width = 200;
            // 
            // SoBaoDanh
            // 
            this.SoBaoDanh.DataPropertyName = "SBD";
            this.SoBaoDanh.HeaderText = "Số Báo Danh";
            this.SoBaoDanh.MinimumWidth = 6;
            this.SoBaoDanh.Name = "SoBaoDanh";
            this.SoBaoDanh.Width = 200;
            // 
            // fmDanhSachThiSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 572);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Name = "fmDanhSachThiSinh";
            this.Text = "fmDanhSachThiSinh";
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachThiSinh)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachThiSinh;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBaoDanh;
    }
}