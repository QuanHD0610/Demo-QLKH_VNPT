namespace QuanLyKhachHang_VNPT.FormGiaoDien
{
    partial class Form_HoaDon
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_hienthihd = new System.Windows.Forms.Button();
            this.dtv_hd = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.btn_tinhtong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_ngayban = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_timkiemkh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VNĐ = new System.Windows.Forms.Label();
            this.SoLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_makh = new System.Windows.Forms.ComboBox();
            this.btn_timkiemnv = new System.Windows.Forms.Button();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.cb_mahang = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.ThanhTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_hd)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtv_hd);
            this.groupBox2.Controls.Add(this.btn_hienthihd);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_Exit);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.cb_mahang);
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.txt_tenhang);
            this.groupBox2.Location = new System.Drawing.Point(85, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1247, 459);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(661, 124);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(131, 52);
            this.btn_update.TabIndex = 99;
            this.btn_update.Text = "Sửa";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(897, 124);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(131, 52);
            this.btn_Exit.TabIndex = 100;
            this.btn_Exit.Text = "Đóng";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(366, 124);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 52);
            this.btn_delete.TabIndex = 101;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_hienthihd
            // 
            this.btn_hienthihd.BackColor = System.Drawing.Color.Transparent;
            this.btn_hienthihd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthihd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_hienthihd.Location = new System.Drawing.Point(17, 186);
            this.btn_hienthihd.Margin = new System.Windows.Forms.Padding(5);
            this.btn_hienthihd.Name = "btn_hienthihd";
            this.btn_hienthihd.Size = new System.Drawing.Size(197, 32);
            this.btn_hienthihd.TabIndex = 102;
            this.btn_hienthihd.Text = "Tìm kiếm tất cả hóa đơn";
            this.btn_hienthihd.UseVisualStyleBackColor = false;
            this.btn_hienthihd.Click += new System.EventHandler(this.btn_hienthihd_Click);
            // 
            // dtv_hd
            // 
            this.dtv_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_hd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.NgayBAN,
            this.MaKH});
            this.dtv_hd.Location = new System.Drawing.Point(17, 226);
            this.dtv_hd.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_hd.Name = "dtv_hd";
            this.dtv_hd.RowHeadersWidth = 51;
            this.dtv_hd.Size = new System.Drawing.Size(1195, 226);
            this.dtv_hd.TabIndex = 103;
            this.dtv_hd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_hd_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 120;
            // 
            // NgayBAN
            // 
            this.NgayBAN.DataPropertyName = "NgayBan";
            this.NgayBAN.HeaderText = "Ngày Bán";
            this.NgayBAN.MinimumWidth = 6;
            this.NgayBAN.Name = "NgayBAN";
            this.NgayBAN.Width = 120;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 120;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 120;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(1023, 782);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tongtien.Multiline = true;
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(171, 25);
            this.txt_tongtien.TabIndex = 87;
            this.txt_tongtien.TextChanged += new System.EventHandler(this.txt_tongtien_TextChanged);
            // 
            // btn_tinhtong
            // 
            this.btn_tinhtong.Location = new System.Drawing.Point(899, 779);
            this.btn_tinhtong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tinhtong.Name = "btn_tinhtong";
            this.btn_tinhtong.Size = new System.Drawing.Size(100, 28);
            this.btn_tinhtong.TabIndex = 86;
            this.btn_tinhtong.Text = "Tính tổng tiền";
            this.btn_tinhtong.UseVisualStyleBackColor = true;
            this.btn_tinhtong.Click += new System.EventHandler(this.btn_tinhtong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_tinhtong);
            this.panel1.Controls.Add(this.txt_tongtien);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.VNĐ);
            this.panel1.Location = new System.Drawing.Point(142, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 772);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(136, 33);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(5);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(185, 22);
            this.txt_mahd.TabIndex = 58;
            this.txt_mahd.TextChanged += new System.EventHandler(this.txt_mahd_TextChanged);
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Location = new System.Drawing.Point(813, 176);
            this.txt_dienthoai.Margin = new System.Windows.Forms.Padding(5);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(215, 22);
            this.txt_dienthoai.TabIndex = 60;
            this.txt_dienthoai.TextChanged += new System.EventHandler(this.txt_dienthoai_TextChanged);
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(136, 174);
            this.txt_tennv.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(185, 22);
            this.txt_tennv.TabIndex = 61;
            this.txt_tennv.TextChanged += new System.EventHandler(this.txt_tennv_TextChanged);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(813, 130);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(5);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(215, 22);
            this.txt_diachi.TabIndex = 62;
            this.txt_diachi.TextChanged += new System.EventHandler(this.txt_diachi_TextChanged);
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(813, 86);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(215, 22);
            this.txt_tenkh.TabIndex = 63;
            this.txt_tenkh.TextChanged += new System.EventHandler(this.txt_tenkh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(641, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 65;
            this.label2.Text = "Mã khách hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ngày bán";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dt_ngayban
            // 
            this.dt_ngayban.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayban.Location = new System.Drawing.Point(136, 86);
            this.dt_ngayban.Margin = new System.Windows.Forms.Padding(5);
            this.dt_ngayban.Name = "dt_ngayban";
            this.dt_ngayban.Size = new System.Drawing.Size(185, 22);
            this.dt_ngayban.TabIndex = 74;
            this.dt_ngayban.ValueChanged += new System.EventHandler(this.dt_ngayban_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(8, 129);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 22);
            this.label14.TabIndex = 89;
            this.label14.Text = "Mã nhân viên";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // btn_timkiemkh
            // 
            this.btn_timkiemkh.BackColor = System.Drawing.Color.White;
            this.btn_timkiemkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiemkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timkiemkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiemkh.Location = new System.Drawing.Point(1062, 31);
            this.btn_timkiemkh.Margin = new System.Windows.Forms.Padding(5);
            this.btn_timkiemkh.Name = "btn_timkiemkh";
            this.btn_timkiemkh.Size = new System.Drawing.Size(133, 49);
            this.btn_timkiemkh.TabIndex = 90;
            this.btn_timkiemkh.Text = "Tìm kiếm";
            this.btn_timkiemkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiemkh.UseVisualStyleBackColor = false;
            this.btn_timkiemkh.Click += new System.EventHandler(this.btn_timkiemkh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_timkiemkh);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dt_ngayban);
            this.groupBox1.Controls.Add(this.cb_manv);
            this.groupBox1.Controls.Add(this.btn_timkiemnv);
            this.groupBox1.Controls.Add(this.cb_makh);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.txt_dienthoai);
            this.groupBox1.Controls.Add(this.txt_mahd);
            this.groupBox1.Location = new System.Drawing.Point(85, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1247, 219);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "Mã hàng";
            this.MAHH.MinimumWidth = 6;
            this.MAHH.Name = "MAHH";
            this.MAHH.Width = 120;
            // 
            // VNĐ
            // 
            this.VNĐ.AutoSize = true;
            this.VNĐ.Location = new System.Drawing.Point(1214, 788);
            this.VNĐ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VNĐ.Name = "VNĐ";
            this.VNĐ.Size = new System.Drawing.Size(35, 16);
            this.VNĐ.TabIndex = 88;
            this.VNĐ.Text = "VNĐ";
            this.VNĐ.Click += new System.EventHandler(this.VNĐ_Click);
            // 
            // SoLUONG
            // 
            this.SoLUONG.DataPropertyName = "SoLUONG";
            this.SoLUONG.HeaderText = "Số lượng";
            this.SoLUONG.MinimumWidth = 6;
            this.SoLUONG.Name = "SoLUONG";
            this.SoLUONG.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mã hóa đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(639, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tên khách hàng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(5, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tên nhân viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(639, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 22);
            this.label10.TabIndex = 70;
            this.label10.Text = "Địa chỉ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(641, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 22);
            this.label12.TabIndex = 71;
            this.label12.Text = "Điện thoại";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cb_makh
            // 
            this.cb_makh.FormattingEnabled = true;
            this.cb_makh.Location = new System.Drawing.Point(813, 41);
            this.cb_makh.Margin = new System.Windows.Forms.Padding(5);
            this.cb_makh.Name = "cb_makh";
            this.cb_makh.Size = new System.Drawing.Size(215, 24);
            this.cb_makh.TabIndex = 72;
            this.cb_makh.SelectedIndexChanged += new System.EventHandler(this.cb_makh_SelectedIndexChanged);
            // 
            // btn_timkiemnv
            // 
            this.btn_timkiemnv.BackColor = System.Drawing.Color.White;
            this.btn_timkiemnv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiemnv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timkiemnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiemnv.Location = new System.Drawing.Point(342, 160);
            this.btn_timkiemnv.Margin = new System.Windows.Forms.Padding(5);
            this.btn_timkiemnv.Name = "btn_timkiemnv";
            this.btn_timkiemnv.Size = new System.Drawing.Size(137, 49);
            this.btn_timkiemnv.TabIndex = 86;
            this.btn_timkiemnv.Text = "Tìm kiếm";
            this.btn_timkiemnv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiemnv.UseVisualStyleBackColor = false;
            this.btn_timkiemnv.Click += new System.EventHandler(this.btn_timkiemnv_Click);
            // 
            // cb_manv
            // 
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(136, 129);
            this.cb_manv.Margin = new System.Windows.Forms.Padding(5);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(185, 24);
            this.cb_manv.TabIndex = 73;
            this.cb_manv.SelectedIndexChanged += new System.EventHandler(this.cb_manv_SelectedIndexChanged);
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Location = new System.Drawing.Point(136, 76);
            this.txt_tenhang.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(185, 22);
            this.txt_tenhang.TabIndex = 88;
            this.txt_tenhang.TextChanged += new System.EventHandler(this.txt_tenhang_TextChanged);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(627, 26);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(5);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(185, 22);
            this.txt_soluong.TabIndex = 89;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(967, 26);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(5);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(244, 22);
            this.txt_dongia.TabIndex = 90;
            this.txt_dongia.TextChanged += new System.EventHandler(this.txt_dongia_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(867, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 91;
            this.label7.Text = "Đơn giá";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(13, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 92;
            this.label8.Text = "Tên hàng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(532, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 22);
            this.label9.TabIndex = 93;
            this.label9.Text = "Số lượng";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(8, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 22);
            this.label11.TabIndex = 94;
            this.label11.Text = "Mã hàng";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(657, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 22);
            this.label13.TabIndex = 95;
            this.label13.Text = "Thành tiền";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(764, 78);
            this.txt_thanhtien.Margin = new System.Windows.Forms.Padding(5);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(244, 22);
            this.txt_thanhtien.TabIndex = 96;
            this.txt_thanhtien.TextChanged += new System.EventHandler(this.txt_thanhtien_TextChanged);
            // 
            // cb_mahang
            // 
            this.cb_mahang.FormattingEnabled = true;
            this.cb_mahang.Location = new System.Drawing.Point(136, 26);
            this.cb_mahang.Margin = new System.Windows.Forms.Padding(5);
            this.cb_mahang.Name = "cb_mahang";
            this.cb_mahang.Size = new System.Drawing.Size(185, 24);
            this.cb_mahang.TabIndex = 97;
            this.cb_mahang.SelectedIndexChanged += new System.EventHandler(this.cb_mahang_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(136, 124);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(136, 52);
            this.btn_add.TabIndex = 98;
            this.btn_add.Text = "Thêm";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // ThanhTIEN
            // 
            this.ThanhTIEN.DataPropertyName = "ThanhTIEN";
            this.ThanhTIEN.HeaderText = "Thành tiền";
            this.ThanhTIEN.MinimumWidth = 6;
            this.ThanhTIEN.Name = "ThanhTIEN";
            this.ThanhTIEN.Width = 130;
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "DonGIA";
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.MinimumWidth = 6;
            this.Dongia.Name = "Dongia";
            this.Dongia.Width = 125;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(590, 44);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(202, 46);
            this.label17.TabIndex = 84;
            this.label17.Text = "HÓA ĐƠN";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 725);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(142, 60);
            this.Name = "Form_HoaDon";
            this.Text = "HoaDon";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_hd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dtv_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.Button btn_hienthihd;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.ComboBox cb_mahang;
        public System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_dongia;
        public System.Windows.Forms.TextBox txt_soluong;
        public System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Button btn_tinhtong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_timkiemkh;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DateTimePicker dt_ngayban;
        public System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.Button btn_timkiemnv;
        public System.Windows.Forms.ComboBox cb_makh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_tenkh;
        public System.Windows.Forms.TextBox txt_diachi;
        public System.Windows.Forms.TextBox txt_tennv;
        public System.Windows.Forms.TextBox txt_dienthoai;
        public System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label VNĐ;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
    }
}