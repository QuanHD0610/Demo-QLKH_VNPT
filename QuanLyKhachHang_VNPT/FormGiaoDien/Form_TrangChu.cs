using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachHang_VNPT.FormGiaoDien
{
    public partial class Form_TrangChu : Form
    {
        public Form_TrangChu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pan_Main.Controls.Add(childform);
            pan_Main.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_KhachHang());
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_HoaDon());
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_DichVu());
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_ThongKe());
        }

        private void btn_BaoTri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_BaoTri());
        }

        private void btn_PhanHoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_PhanHoi());
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_KhuyenMai());    
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_DangNhap form_DangNhap = new Form_DangNhap();
            form_DangNhap.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
