
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
            this.dateTimePickerNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_TenKhoaThi = new System.Windows.Forms.TextBox();
            this.dataGridViewKhoaThi = new System.Windows.Forms.DataGridView();
            this.MaKhoaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoaThi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoi.Location = new System.Drawing.Point(280, 183);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(146, 42);
            this.btnTaoMoi.TabIndex = 6;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dateTimePickerNgayThi);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Location = new System.Drawing.Point(171, 105);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(365, 51);
            this.panel12.TabIndex = 5;
            // 
            // dateTimePickerNgayThi
            // 
            this.dateTimePickerNgayThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNgayThi.CustomFormat = "";
            this.dateTimePickerNgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayThi.Location = new System.Drawing.Point(143, 13);
            this.dateTimePickerNgayThi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateTimePickerNgayThi.Name = "dateTimePickerNgayThi";
            this.dateTimePickerNgayThi.Size = new System.Drawing.Size(212, 28);
            this.dateTimePickerNgayThi.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(13, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày thi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(649, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "_____________Danh sách khóa thi hiện có______________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khóa thi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_TenKhoaThi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(171, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 51);
            this.panel2.TabIndex = 6;
            // 
            // textBox_TenKhoaThi
            // 
            this.textBox_TenKhoaThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenKhoaThi.Location = new System.Drawing.Point(143, 13);
            this.textBox_TenKhoaThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TenKhoaThi.Name = "textBox_TenKhoaThi";
            this.textBox_TenKhoaThi.Size = new System.Drawing.Size(210, 27);
            this.textBox_TenKhoaThi.TabIndex = 7;
            // 
            // dataGridViewKhoaThi
            // 
            this.dataGridViewKhoaThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhoaThi.ColumnHeadersHeight = 35;
            this.dataGridViewKhoaThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoaThi,
            this.TenKhoaThi,
            this.NgayThi});
            this.dataGridViewKhoaThi.Location = new System.Drawing.Point(25, 277);
            this.dataGridViewKhoaThi.Name = "dataGridViewKhoaThi";
            this.dataGridViewKhoaThi.RowHeadersWidth = 51;
            this.dataGridViewKhoaThi.RowTemplate.Height = 24;
            this.dataGridViewKhoaThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhoaThi.Size = new System.Drawing.Size(632, 225);
            this.dataGridViewKhoaThi.TabIndex = 0;
            // 
            // MaKhoaThi
            // 
            this.MaKhoaThi.DataPropertyName = "MAKHOATHI";
            this.MaKhoaThi.HeaderText = "Mã Khoá Thi";
            this.MaKhoaThi.MinimumWidth = 6;
            this.MaKhoaThi.Name = "MaKhoaThi";
            // 
            // TenKhoaThi
            // 
            this.TenKhoaThi.DataPropertyName = "TENKHOATHI";
            this.TenKhoaThi.HeaderText = "Tên Khóa Thi";
            this.TenKhoaThi.MinimumWidth = 6;
            this.TenKhoaThi.Name = "TenKhoaThi";
            // 
            // NgayThi
            // 
            this.NgayThi.DataPropertyName = "NGAYTHI";
            this.NgayThi.HeaderText = "Ngày Thi";
            this.NgayThi.MinimumWidth = 6;
            this.NgayThi.Name = "NgayThi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 66);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(226, 44);
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
            this.panel14.Location = new System.Drawing.Point(0, 56);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1161, 710);
            this.panel14.TabIndex = 9;
            // 
            // fmLapKhoaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel14);
            this.Name = "fmLapKhoaThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập khóa thi | App quản lý trung tâm ngoại ngữ";
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