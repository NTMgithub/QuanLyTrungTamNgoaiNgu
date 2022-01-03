
namespace QuanLyTrungTamNgoaiNgu
{
    partial class fmLapPhongThi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.comboBoxTrinhDo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxKhoaThi = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxMaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLapNhanh = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPhong,
            this.NgayThi,
            this.TrinhDo});
            this.dataGridView1.Location = new System.Drawing.Point(25, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTaoMoi.Location = new System.Drawing.Point(37, 13);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(130, 38);
            this.btnTaoMoi.TabIndex = 6;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxTrinhDo
            // 
            this.comboBoxTrinhDo.FormattingEnabled = true;
            this.comboBoxTrinhDo.Location = new System.Drawing.Point(127, 13);
            this.comboBoxTrinhDo.MaximumSize = new System.Drawing.Size(220, 0);
            this.comboBoxTrinhDo.MinimumSize = new System.Drawing.Size(220, 0);
            this.comboBoxTrinhDo.Name = "comboBoxTrinhDo";
            this.comboBoxTrinhDo.Size = new System.Drawing.Size(220, 24);
            this.comboBoxTrinhDo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trình độ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxTrinhDo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 51);
            this.panel2.TabIndex = 6;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxKhoaThi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(487, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 51);
            this.panel3.TabIndex = 6;
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
            this.panel7.Location = new System.Drawing.Point(25, 127);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(356, 51);
            this.panel7.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 66);
            this.panel1.TabIndex = 4;
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
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel14.Controls.Add(this.label5);
            this.panel14.Controls.Add(this.panel4);
            this.panel14.Controls.Add(this.panel3);
            this.panel14.Controls.Add(this.panel2);
            this.panel14.Controls.Add(this.dataGridView1);
            this.panel14.Controls.Add(this.panel7);
            this.panel14.Location = new System.Drawing.Point(0, 72);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1161, 694);
            this.panel14.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(26, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Danh sách phòng thi hiện có";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLapNhanh);
            this.panel4.Controls.Add(this.btnTaoMoi);
            this.panel4.Location = new System.Drawing.Point(944, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 146);
            this.panel4.TabIndex = 7;
            // 
            // btnLapNhanh
            // 
            this.btnLapNhanh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLapNhanh.Location = new System.Drawing.Point(37, 95);
            this.btnLapNhanh.Name = "btnLapNhanh";
            this.btnLapNhanh.Size = new System.Drawing.Size(130, 38);
            this.btnLapNhanh.TabIndex = 7;
            this.btnLapNhanh.Text = "Lập nhanh";
            this.btnLapNhanh.UseVisualStyleBackColor = false;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 320;
            // 
            // NgayThi
            // 
            this.NgayThi.HeaderText = "Ngày Thi";
            this.NgayThi.MinimumWidth = 6;
            this.NgayThi.Name = "NgayThi";
            this.NgayThi.Width = 320;
            // 
            // TrinhDo
            // 
            this.TrinhDo.HeaderText = "Trình Độ";
            this.TrinhDo.MinimumWidth = 6;
            this.TrinhDo.Name = "TrinhDo";
            this.TrinhDo.Width = 320;
            // 
            // fmLapPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel14);
            this.Name = "fmLapPhongThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmLapPhongThi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.ComboBox comboBoxTrinhDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxKhoaThi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLapNhanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhDo;
    }
}