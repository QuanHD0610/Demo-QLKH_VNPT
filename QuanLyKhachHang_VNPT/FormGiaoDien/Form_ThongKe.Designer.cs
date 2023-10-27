namespace QuanLyKhachHang_VNPT.FormGiaoDien
{
    partial class Form_ThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.btn_tinhtong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dt_timesau = new System.Windows.Forms.DateTimePicker();
            this.btn_load = new System.Windows.Forms.Button();
            this.dt_timetruoc = new System.Windows.Forms.DateTimePicker();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_thongke);
            this.panel1.Controls.Add(this.txt_tong);
            this.panel1.Controls.Add(this.btn_tinhtong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(142, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 611);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(786, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 125;
            this.label1.Text = "VNĐ";
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Location = new System.Drawing.Point(42, 287);
            this.dgv_thongke.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.RowHeadersWidth = 51;
            this.dgv_thongke.Size = new System.Drawing.Size(803, 254);
            this.dgv_thongke.TabIndex = 120;
            // 
            // txt_tong
            // 
            this.txt_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tong.Location = new System.Drawing.Point(566, 209);
            this.txt_tong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(219, 32);
            this.txt_tong.TabIndex = 124;
            // 
            // btn_tinhtong
            // 
            this.btn_tinhtong.BackColor = System.Drawing.Color.Transparent;
            this.btn_tinhtong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhtong.Location = new System.Drawing.Point(578, 130);
            this.btn_tinhtong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tinhtong.Name = "btn_tinhtong";
            this.btn_tinhtong.Size = new System.Drawing.Size(188, 51);
            this.btn_tinhtong.TabIndex = 123;
            this.btn_tinhtong.Text = "Tính tổng";
            this.btn_tinhtong.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(306, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 28);
            this.label2.TabIndex = 122;
            this.label2.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dt_timesau);
            this.groupBox3.Controls.Add(this.btn_load);
            this.groupBox3.Controls.Add(this.dt_timetruoc);
            this.groupBox3.Controls.Add(this.btnTimkiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(42, 105);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(451, 148);
            this.groupBox3.TabIndex = 121;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo thời gian";
            // 
            // dt_timesau
            // 
            this.dt_timesau.CustomFormat = "MM/dd/yyyy";
            this.dt_timesau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timesau.Location = new System.Drawing.Point(239, 32);
            this.dt_timesau.Margin = new System.Windows.Forms.Padding(4);
            this.dt_timesau.Name = "dt_timesau";
            this.dt_timesau.Size = new System.Drawing.Size(197, 32);
            this.dt_timesau.TabIndex = 85;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Transparent;
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load.Location = new System.Drawing.Point(239, 79);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(199, 59);
            this.btn_load.TabIndex = 86;
            this.btn_load.Text = "Tìm tất cả hóa đơn";
            this.btn_load.UseVisualStyleBackColor = false;
            // 
            // dt_timetruoc
            // 
            this.dt_timetruoc.CustomFormat = "MM/dd/yyyy";
            this.dt_timetruoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timetruoc.Location = new System.Drawing.Point(8, 32);
            this.dt_timetruoc.Margin = new System.Windows.Forms.Padding(4);
            this.dt_timetruoc.Name = "dt_timetruoc";
            this.dt_timetruoc.Size = new System.Drawing.Size(184, 32);
            this.dt_timetruoc.TabIndex = 84;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(0, 78);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTimkiem.Size = new System.Drawing.Size(193, 59);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            // 
            // Form_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 668);
            this.Controls.Add(this.panel1);
            this.Name = "Form_ThongKe";
            this.Text = "Form_ThongKe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.Button btn_tinhtong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dt_timesau;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DateTimePicker dt_timetruoc;
        private System.Windows.Forms.Button btnTimkiem;
    }
}