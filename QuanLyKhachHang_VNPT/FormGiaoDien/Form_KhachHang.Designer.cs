namespace QuanLyKhachHang_VNPT.FormGiaoDien
{
    partial class Form_KhachHang
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtv_khachhang = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.dt_namsinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_khachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cb_gioitinh);
            this.panel1.Controls.Add(this.txt_sdt);
            this.panel1.Controls.Add(this.dt_namsinh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_diachi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_tenkh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_makh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(142, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 670);
            this.panel1.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_email.Location = new System.Drawing.Point(200, 272);
            this.txt_email.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(169, 26);
            this.txt_email.TabIndex = 182;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 272);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 181;
            this.label8.Text = "Email";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 150;
            // 
            // NgaySINH
            // 
            this.NgaySINH.DataPropertyName = "NGAYSINH";
            this.NgaySINH.HeaderText = "Ngày sinh";
            this.NgaySINH.MinimumWidth = 6;
            this.NgaySINH.Name = "NgaySINH";
            this.NgaySINH.Width = 125;
            // 
            // GioiTINH
            // 
            this.GioiTINH.DataPropertyName = "GIOITINH";
            this.GioiTINH.HeaderText = "Giới tính";
            this.GioiTINH.MinimumWidth = 6;
            this.GioiTINH.Name = "GioiTINH";
            this.GioiTINH.Width = 125;
            // 
            // DiaCHI
            // 
            this.DiaCHI.DataPropertyName = "DiaCHI";
            this.DiaCHI.HeaderText = "Địa chỉ";
            this.DiaCHI.MinimumWidth = 6;
            this.DiaCHI.Name = "DiaCHI";
            this.DiaCHI.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 200;
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
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.MinimumWidth = 6;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtv_khachhang);
            this.groupBox1.Location = new System.Drawing.Point(7, 362);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1027, 263);
            this.groupBox1.TabIndex = 180;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_gioitinh.Location = new System.Drawing.Point(200, 162);
            this.cb_gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(169, 24);
            this.cb_gioitinh.TabIndex = 179;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 45);
            this.label5.TabIndex = 178;
            this.label5.Text = " Khách Hàng";
            // 
            // txt_sdt
            // 
            this.txt_sdt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_sdt.Location = new System.Drawing.Point(781, 232);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(178, 26);
            this.txt_sdt.TabIndex = 177;
            // 
            // dt_namsinh
            // 
            this.dt_namsinh.CustomFormat = "dd/MM/yyyy";
            this.dt_namsinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_namsinh.Location = new System.Drawing.Point(778, 160);
            this.dt_namsinh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dt_namsinh.Name = "dt_namsinh";
            this.dt_namsinh.Size = new System.Drawing.Size(178, 22);
            this.dt_namsinh.TabIndex = 176;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(591, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 175;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(591, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 174;
            this.label4.Text = "Số điện thoại";
            // 
            // txt_diachi
            // 
            this.txt_diachi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_diachi.Location = new System.Drawing.Point(200, 232);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(169, 26);
            this.txt_diachi.TabIndex = 173;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 172;
            this.label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 171;
            this.label7.Text = "Giới Tính";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_tenkh.Location = new System.Drawing.Point(777, 99);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_tenkh.Multiline = true;
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(178, 26);
            this.txt_tenkh.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(591, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 169;
            this.label2.Text = "Tên khách hàng";
            // 
            // txt_makh
            // 
            this.txt_makh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_makh.Location = new System.Drawing.Point(200, 99);
            this.txt_makh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_makh.Multiline = true;
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(169, 26);
            this.txt_makh.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 167;
            this.label1.Text = "Mã khách hàng";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDong.Image = global::QuanLyKhachHang_VNPT.Properties.Resources.close;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(768, 296);
            this.btnDong.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(107, 51);
            this.btnDong.TabIndex = 166;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSua.Image = global::QuanLyKhachHang_VNPT.Properties.Resources.update;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(559, 296);
            this.btnSua.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 51);
            this.btnSua.TabIndex = 165;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnXoa.Image = global::QuanLyKhachHang_VNPT.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(292, 296);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 51);
            this.btnXoa.TabIndex = 164;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnThem.Image = global::QuanLyKhachHang_VNPT.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(72, 296);
            this.btnThem.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 51);
            this.btnThem.TabIndex = 163;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 76);
            this.panel2.TabIndex = 183;
            // 
            // Form_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 733);
            this.Controls.Add(this.panel1);
            this.Name = "Form_KhachHang";
            this.Text = "KhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_khachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_email;
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
        public System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_sdt;
        public System.Windows.Forms.DateTimePicker dt_namsinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
    }
}