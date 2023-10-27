using QuanLyKhachHang_VNPT.KetNoiSQL;
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
    public partial class Form_DangNhap : Form
    {
        LopDungChung lopDungChung = new LopDungChung();
        public Form_DangNhap()
        {
            InitializeComponent();
        }
        int dem = 0;
        string now = DateTime.Now.ToShortDateString();
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tentaikhoan.Text == string.Empty)
                {
                    MessageBox.Show("Tên tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_tentaikhoan.Focus();
                    return;
                }
                if (txt_matkhau.Text == string.Empty)
                {
                    MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_matkhau.Focus();
                    return;
                }
                else
                {
                    string sql = "SELECT COUNT(*) FROM NGUOIDUNG WHERE TenDangNhap = '" + txt_tentaikhoan.Text + "'AND MatKhau = '" + txt_matkhau.Text + "'";
                    int kq = (int)lopDungChung.ExcuteScalar(sql);
                    if (kq >= 1)
                    {
                        Form_TrangChu main = new Form_TrangChu();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        txt_tentaikhoan.Text = "";
                        txt_matkhau.Text = "";
                        dem++;
                        MessageBox.Show("Đăng nhập thất bại,mời bạn nhập lại");
                        if (dem == 3)
                        {
                            MessageBox.Show("Bạn đã nhập sai 3 lần");
                            Application.Exit();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn thoát khỏi chương trình hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
