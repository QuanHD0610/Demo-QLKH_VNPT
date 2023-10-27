using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachHang_VNPT.DoiTuong
{
    internal class TP_HoaDon
    {

        KetNoiSQL.HoaDon hoaDon = new KetNoiSQL.HoaDon();
        FormGiaoDien.Form_HoaDon frm_hoadon;
        FormGiaoDien.Form_ThongKe frm_thongke;

        public TP_HoaDon(FormGiaoDien.Form_HoaDon hd)
        {
            frm_hoadon = hd;
        }

        public TP_HoaDon(FormGiaoDien.Form_ThongKe tk)
        {
            frm_thongke = tk;
        }

        public void themhd()
        {
            int ketqua = hoaDon.ThemHD
                (
                    frm_hoadon.txt_mahd.Text,
                    frm_hoadon.cb_manv.SelectedValue.ToString(),
                    frm_hoadon.dt_ngayban.Value,
                    frm_hoadon.cb_makh.SelectedValue.ToString(),
                    frm_hoadon.cb_mahang.SelectedValue.ToString(),
                    frm_hoadon.txt_soluong.Text,
                    frm_hoadon.txt_dongia.Text,
                    frm_hoadon.txt_thanhtien.Text
                );
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");

        }

        public void suahd()
        {
            int ketqua = hoaDon.SuaHD
                (
                    frm_hoadon.txt_mahd.Text,
                    frm_hoadon.cb_manv.SelectedValue.ToString(),
                    frm_hoadon.dt_ngayban.Value,
                    frm_hoadon.cb_makh.SelectedValue.ToString(),
                    frm_hoadon.cb_mahang.SelectedValue.ToString(),
                    frm_hoadon.txt_soluong.Text,
                    frm_hoadon.txt_dongia.Text,
                    frm_hoadon.txt_thanhtien.Text
                );
            if (ketqua >= 1)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
        }

        public void xoahd()
        {
            int ketqua = hoaDon.XoaHD(frm_hoadon.txt_mahd.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
        }

        public void loadhd()
        {
            frm_hoadon.dtv_hd.DataSource = hoaDon.LoadHD();
        }

        public void loadtk()
        {
            frm_thongke.dgv_thongke.DataSource = hoaDon.LoadHD();
        }
    }
}

