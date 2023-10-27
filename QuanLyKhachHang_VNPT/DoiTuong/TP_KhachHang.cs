using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachHang_VNPT.DoiTuong
{
    internal class TP_KhachHang
    {
        KetNoiSQL.KhachHang khachhang = new KetNoiSQL.KhachHang();
        FormGiaoDien.Form_KhachHang frm_khachhang;
        FormGiaoDien.Form_HoaDon frm_hoadon;

        public TP_KhachHang(FormGiaoDien.Form_KhachHang kh)
        {
            frm_khachhang = kh;
        }

        public TP_KhachHang(FormGiaoDien.Form_HoaDon hd)
        {
            frm_hoadon = hd;
        }

        public void Luukh()
        {
            int ketqua = khachhang.ThemKH
                (
                    frm_khachhang.txt_makh.Text,
                    frm_khachhang.txt_tenkh.Text,
                    frm_khachhang.dt_namsinh.Value,
                    frm_khachhang.cb_gioitinh.Text,
                    frm_khachhang.txt_diachi.Text,
                    frm_khachhang.txt_sdt.Text,
                    frm_khachhang.txt_email.Text
                );
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
        }

        public void suakh()
        {
            int ketqua = khachhang.Suakh
                (
                    frm_khachhang.txt_makh.Text,
                    frm_khachhang.txt_tenkh.Text,
                    frm_khachhang.dt_namsinh.Value,
                    frm_khachhang.cb_gioitinh.Text,
                    frm_khachhang.txt_diachi.Text,
                    frm_khachhang.txt_sdt.Text,
                    frm_khachhang.txt_email.Text
                );
            if (ketqua >= 1)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bai");
        }

        public void xoakh()
        {
            int ketqua = khachhang.Xoakh(frm_khachhang.txt_makh.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
        }

        public void loadkh()
        {
            frm_khachhang.dtv_khachhang.DataSource = khachhang.Loadkh();
        }

    }
}
