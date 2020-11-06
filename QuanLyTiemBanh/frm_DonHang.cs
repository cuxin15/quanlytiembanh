using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemBanh
{
    public partial class frm_DonHang : Form
    {
        GenericDatabase genericDatabase = new GenericDatabase();
        public frm_DonHang()
        {
            InitializeComponent();
        }

        public void Load_Combo()
        {
            comboBox_KhachHang.DataSource = genericDatabase.LoadTable("select * from KhachHang");
            comboBox_KhachHang.ValueMember = "MAKHACHHANG";
            comboBox_KhachHang.DisplayMember = "MAKHACHHANG";
        }

        private void frm_DonHang_Load(object sender, EventArgs e)
        {
            Load_Combo();
        }

        private void comboBox_KhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mskh = int.Parse(comboBox_KhachHang.SelectedValue.ToString());
            textBox_TenKH.Text = (string)genericDatabase.QuerySQL("select HOTEN from KhachHang where MAKHACHHANG = " + mskh);
            textBox_DiaChiKH.Text = (string)genericDatabase.QuerySQL("select DIACHI from KhachHang where MAKHACHHANG = " + mskh);
            textBox_SDTKH.Text = (string)genericDatabase.QuerySQL("select SDT from KhachHang where MAKHACHHANG = " + mskh);
        }

        private void button_ThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void button_TaoHoaDon_Click(object sender, EventArgs e)
        {
            string query1 = string.Format("insert into DonHang values({0},{1},{2},{3},{4})", 
                int.Parse(comboBox_KhachHang.SelectedValue.ToString()), dateTimePicker_NgayDat.Value, int.Parse(textBox_TienCoc.Text), 
                dateTimePicker_NgayNhan.Value, int.Parse(comboBox_NhanVien.SelectedValue.ToString()));
            genericDatabase.NonQuerySQL(query1);
            int msdh = (int)genericDatabase.QuerySQL("select max(msdh) from DonHang");
            for (int i = 0; i <= dataGridView_DonHang.Rows.Count; i++)
            {
                int msb = int.Parse(dataGridView_DonHang.Rows[i].Cells["msb"].ToString());
                int soluong = int.Parse(dataGridView_DonHang.Rows[i].Cells["soluong"].ToString());
                string query2 = string.Format("insert into ChiTietDonHang values({0},{1},{2})", msdh, msb, soluong);
            }
        }
    }
}
