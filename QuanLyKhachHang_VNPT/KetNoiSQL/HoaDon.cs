using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang_VNPT.KetNoiSQL
{
    internal class HoaDon
    {
        LopDungChung lopchung = new LopDungChung();

        public int ThemHD(string mahd, string manv, DateTime ngayban, string makh, string mahh, string soluong, string dongia, string thanhtien)
        {
            string sql = "Insert into HOADON values(N'" + mahd + "',N'" + manv + "',N'" + ngayban.ToString() + "',N'" + makh + "',N'" + mahh + "',N'" + soluong + "',N'" + dongia + "',N'" + thanhtien + "')";
            return lopchung.ThemXoaSua(sql);
        }

        public int SuaHD(string mahd, string manv, DateTime ngayban, string makh, string mah, string soluong, string dongia, string thanhtien)
        {
            string sql = "Update HOADON set MANV =N'" + manv + "',NGAYBAN = N'" + ngayban.ToString() + "',MAKH = N'" + makh + "',MAHH = N'" + mah + "',SOLUONG = N'" + soluong + "',DONGIA = N'" + dongia + "',THANHTIEN = N'" + thanhtien + "' where MAHD = N'" + mahd + "'";
            return lopchung.ThemXoaSua(sql);
        }

        public int XoaHD(string mahd)
        {
            string sql = "Delete HOADON where MAHD = N'" + mahd + "'";
            return lopchung.ThemXoaSua(sql);
        }

        public DataTable LoadHD()
        {
            string sql = "Select * from HOADON";
            return lopchung.LoadDuLieu(sql);
        }
    }
}
