using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyKhachHang_VNPT.KetNoiSQL
{
    internal class LopDungChung
    {
        SqlConnection conn;
        string ketNoiSQL = @"Data Source=DESKTOP-F109BTE;Initial Catalog=QUANLYKHACHHANG;Integrated Security=True";

        public LopDungChung()
        {
            conn = new SqlConnection(ketNoiSQL);
        }


        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(ketNoiSQL);
            return conn;
        }


        public void Mo()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }


        public void Dong()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }


        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            int ketqua = comm.ExecuteNonQuery();
            Dong();
            return ketqua;
        }


        public object ExcuteScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            object ketqua = comm.ExecuteScalar();
            Dong();
            return ketqua;
        }

        public DataTable LoadDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
