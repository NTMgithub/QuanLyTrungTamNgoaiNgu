
namespace QuanLyTrungTamNgoaiNgu
{
    partial class fmLapKhoaThi
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
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewKhoaThi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dateTimePickerNgayThi = new System.Windows.Forms.DateTimePicker();
            this.MaKhoaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_TenKhoaThi = new System.Windows.Forms.TextBox();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoaThi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTaoMoi.Location = new System.Drawing.Point(1135, 49);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(146, 48);
            this.btnTaoMoi.TabIndex = 6;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dateTimePickerNgayThi);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Location = new System.Drawing.Point(499, 40);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(400, 64);
            this.panel12.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(15, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(29, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Danh sách khóa thi hiện có";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khoá Thi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_TenKhoaThi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 64);
            this.panel2.TabIndex = 6;
            // 
            // dataGridViewKhoaThi
            // 
            this.dataGridViewKhoaThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoaThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoaThi,
            this.TenKhoaThi,
            this.NgayThi});
            this.dataGridViewKhoaThi.Location = new System.Drawing.Point(28, 335);
            this.dataGridViewKhoaThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewKhoaThi.Name = "dataGridViewKhoaThi";
            this.dataGridViewKhoaThi.RowHeadersWidth = 51;
            this.dataGridViewKhoaThi.RowTemplate.Height = 24;
            this.dataGridViewKhoaThi.Size = new System.Drawing.Size(1253, 520);
            this.dataGridViewKhoaThi.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 82);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(558, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lập khóa thi";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel14.Controls.Add(this.btnTaoMoi);
            this.panel14.Controls.Add(this.label5);
            this.panel14.Controls.Add(this.panel12);
            this.panel14.Controls.Add(this.panel2);
            this.panel14.Controls.Add(this.dataGridViewKhoaThi);
            this.panel14.Location = new System.Drawing.Point(0, 90);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1306, 868);
            this.panel14.TabIndex = 9;
            // 
            // dateTimePickerNgayThi
            // 
            this.dateTimePickerNgayThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNgayThi.CustomFormat = "";
            this.dateTimePickerNgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayThi.Location = new System.Drawing.Point(138, 16);
            this.dateTimePickerNgayThi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateTimePickerNgayThi.Name = "dateTimePickerNgayThi";
            this.dateTimePickerNgayThi.Size = new System.Drawing.Size(247, 32);
            this.dateTimePickerNgayThi.TabIndex = 7;
            // 
            // MaKhoaThi
            // 
            this.MaKhoaThi.DataPropertyName = "MAKHOATHI";
            this.MaKhoaThi.HeaderText = "Mã Khoá Thi";
            this.MaKhoaThi.MinimumWidth = 6;
            this.MaKhoaThi.Name = "MaKhoaThi";
            this.MaKhoaThi.Width = 310;
            // 
            // TenKhoaThi
            // 
            this.TenKhoaThi.DataPropertyName = "TENKHOATHI";
            this.TenKhoaThi.HeaderText = "Tên Khóa Thi";
            this.TenKhoaThi.MinimumWidth = 6;
            this.TenKhoaThi.Name = "TenKhoaThi";
            this.TenKhoaThi.Width = 310;
            // 
            // NgayThi
            // 
            this.NgayThi.DataPropertyName = "NGAYTHI";
            this.NgayThi.HeaderText = "Ngày Thi";
            this.NgayThi.MinimumWidth = 6;
            this.NgayThi.Name = "NgayThi";
            this.NgayThi.Width = 310;
            // 
            // textBox_TenKhoaThi
            // 
            this.textBox_TenKhoaThi.Location = new System.Drawing.Point(161, 16);
            this.textBox_TenKhoaThi.Name = "textBox_TenKhoaThi";
            this.textBox_TenKhoaThi.Size = new System.Drawing.Size(236, 26);
            this.textBox_TenKhoaThi.TabIndex = 7;
            // 
            // fmLapKhoaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 964);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel14);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmLapKhoaThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmLapKhoaThi";
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoaThi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewKhoaThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoaThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThi;
        private System.Windows.Forms.TextBox textBox_TenKhoaThi;
    }
}