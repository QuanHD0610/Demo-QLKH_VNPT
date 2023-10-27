namespace QuanLyKhachHang_VNPT.FormGiaoDien
{
    partial class Form_PhanHoi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtv_khachhang = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_thoihan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnloc = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_dongia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_mota);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_thoihan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_madv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_tendv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnloc);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(142, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 721);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(227, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 250;
            this.label4.Text = "Ngày phản hồi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(705, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 243;
            this.label8.Text = "Tình trạng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtv_khachhang);
            this.groupBox1.Location = new System.Drawing.Point(143, 431);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1027, 263);
            this.groupBox1.TabIndex = 242;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dtv_khachhang
            // 
            this.dtv_khachhang.AllowUserToOrderColumns = true;
            this.dtv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.NgaySINH,
            this.GioiTINH,
            this.DiaCHI,
            this.SoDienThoai,
            this.Email});
            this.dtv_khachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtv_khachhang.Location = new System.Drawing.Point(4, 19);
            this.dtv_khachhang.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_khachhang.Name = "dtv_khachhang";
            this.dtv_khachhang.RowHeadersWidth = 51;
            this.dtv_khachhang.Size = new System.Drawing.Size(1019, 240);
            this.dtv_khachhang.TabIndex = 0;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.FillWeight = 125F;
            this.MaKhachHang.HeaderText = "Mã dịch vụ";
            this.MaKhachHang.MinimumWidth = 6;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 125;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên dịch vụ";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 150;
            // 
            // NgaySINH
            // 
            this.NgaySINH.DataPropertyName = "NGAYSINH";
            this.NgaySINH.HeaderText = "Mô tả";
            this.NgaySINH.MinimumWidth = 6;
            this.NgaySINH.Name = "NgaySINH";
            this.NgaySINH.Width = 125;
            // 
            // GioiTINH
            // 
            this.GioiTINH.DataPropertyName = "GIOITINH";
            this.GioiTINH.HeaderText = "Đơn giá";
            this.GioiTINH.MinimumWidth = 6;
            this.GioiTINH.Name = "GioiTINH";
            this.GioiTINH.Width = 125;
            // 
            // DiaCHI
            // 
            this.DiaCHI.DataPropertyName = "DiaCHI";
            this.DiaCHI.HeaderText = "Thời hạn";
            this.DiaCHI.MinimumWidth = 6;
            this.DiaCHI.Name = "DiaCHI";
            this.DiaCHI.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Tốc độ truyền";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Dung Lượng";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(705, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 246;
            this.label3.Text = "Trả lời";
            // 
            // txt_dongia
            // 
            this.txt_dongia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_dongia.Location = new System.Drawing.Point(394, 230);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_dongia.Multiline = true;
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(169, 26);
            this.txt_dongia.TabIndex = 245;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(227, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 244;
            this.label7.Text = "Mã Khách Hàng";
            // 
            // txt_mota
            // 
            this.txt_mota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_mota.Location = new System.Drawing.Point(875, 220);
            this.txt_mota.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(178, 26);
            this.txt_mota.TabIndex = 247;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(394, 315);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 26);
            this.textBox1.TabIndex = 251;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.White;
            this.btn_timkiem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_timkiem.Image = global::QuanLyKhachHang_VNPT.Properties.Resources.search;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(843, 369);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 51);
            this.btn_timkiem.TabIndex = 248;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 45);
            this.label5.TabIndex = 241;
            this.label5.Text = "Phản hồi";
            // 
            // txt_thoihan
            // 
            this.txt_thoihan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_thoihan.Location = new System.Drawing.Point(394, 275);
            this.txt_thoihan.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_thoihan.Multiline = true;
            this.txt_thoihan.Name = "txt_thoihan";
            this.txt_thoihan.Size = new System.Drawing.Size(169, 26);
            this.txt_thoihan.TabIndex = 240;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(227, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 239;
            this.label6.Text = "Ngày nhận";
            // 
            // txt_madv
            // 
            this.txt_madv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_madv.Location = new System.Drawing.Point(394, 180);
            this.txt_madv.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_madv.Multiline = true;
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(169, 26);
            this.txt_madv.TabIndex = 236;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(227, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 235;
            this.label1.Text = "Mã Phản Hồi";
            // 
            // txt_tendv
            // 
            this.txt_tendv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_tendv.Location = new System.Drawing.Point(875, 180);
            this.txt_tendv.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_tendv.Multiline = true;
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(178, 26);
            this.txt_tendv.TabIndex = 238;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(707, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 237;
            this.label2.Text = "Nội dung";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDong.Image = global::QuanLyKhachHang_VNPT.Properties.Resources.close;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(984, 369);
            this.btnDong.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(107, 51);
            this.btnDong.TabIndex = 234;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // btnloc
            // 
            this.btnloc.BackColor = System.Drawing.Color.White;
            this.btnloc.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnloc.Image = global::QuanLyKhachHang_VNPT.Properties.Resources.update;
            this.btnloc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnloc.Location = new System.Drawing.Point(575, 369);
            this.btnloc.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(235, 51);
            this.btnloc.TabIndex = 233;
            this.btnloc.Text = "Ý kiến khách hàng chưa trả lời";
            this.btnloc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnloc.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLuu.Image = global::QuanLyKhachHang_VNPT.Properties.Resources.delete;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(423, 369);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 51);
            this.btnLuu.TabIndex = 232;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnThem.Image = global::QuanLyKhachHang_VNPT.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(205, 369);
            this.btnThem.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 51);
            this.btnThem.TabIndex = 231;
            this.btnThem.Text = "Thêm phản hồi";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(875, 275);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 249;
            // 
            // Form_PhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 754);
            this.Controls.Add(this.panel1);
            this.Name = "Form_PhanHoi";
            this.Text = "PhanHoi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_khachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dtv_khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_mota;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_thoihan;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}