using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang_VNPT.KetNoiSQL
{
    internal class KhachHang
    {
        LopDungChung lopchung = new LopDungChung();
        public int ThemKH(string makh, string tenkh, DateTime ngaysinh, string gioitinh, string diachi, string sdt ,string email)
        {
            string sql = "Insert into KHACHHANG values(N'" + makh + "',N'" + tenkh + "',N'" + ngaysinh.ToString() + "',N'" + gioitinh + "',N'" + diachi + "',N'" + sdt + "','"+email+"')";
            return lopchung.ThemXoaSua(sql);
        }

        public int Suakh(string makh, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string sdt,string email)
        {
            string sql = "UPDATE KHACHHANG SET TENKHACHHANG=N'"+hoten+"',NGAYSINH='"+ngaysinh.ToString()+"',GIOTINH=N'"+gioitinh+"',DIACHI=N'"+diachi+"',SODIENTHOAI='"+sdt+"',EMAIL='"+email+"' WHERE MAKHACHHANG='"+makh+"'";
            return lopchung.ThemXoaSua(sql);
        }

        public int Xoakh(string makh)
        {
            string sql = "Delete KHACHHANG where MAKHACHHANG = N'" + makh + "'";
            return lopchung.ThemXoaSua(sql);

        }

        public DataTable Loadkh()
        {
            string sql = "Select * from KHACHHANG";
            return lopchung.LoadDuLieu(sql);

        }
    }
}
