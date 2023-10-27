using QuanLyKhachHang_VNPT.KetNoiSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachHang_VNPT.FormGiaoDien
{
    public partial class Form_ThongKe : Form
    {
        LopDungChung lopchung = new LopDungChung();
        DoiTuong.TP_HoaDon tphd;
        public Form_ThongKe()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            lopchung.connection().Open();
            string sql = "SELECT * FROM HOADON WHERE 1=1";
            if ((dt_timetruoc.Text != "") && (dt_timesau.Text != ""))
            {
                sql = sql + " AND NGAYBAN >= '" + dt_timetruoc.Text + "' AND NGAYBAN <= '" + dt_timesau.Text + "'";
            }
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, lopchung.connection());
            da.Fill(ds);
            lopchung.connection().Close();
            dgv_thongke.DataSource = ds.Tables[0];
            dgv_thongke.Refresh();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            tphd.loadtk();
        }

        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            int sc = dgv_thongke.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgv_thongke.Rows[i].Cells["ThanhTIEN"].Value.ToString());
            txt_tong.Text = thanhtien.ToString();
        }
    }
}
