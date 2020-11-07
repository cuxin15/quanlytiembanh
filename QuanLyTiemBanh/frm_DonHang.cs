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
		DataTable tb = new DataTable();
        public frm_DonHang()
        {
            InitializeComponent();
        }

        public void LoadDataGrid(DataTable d)
        {
			this.tb = d;
            dataGridView_DonHang.DataSource = d;
        }
        public void Load_Combo()
        {
            comboBox_KhachHang.DataSource = genericDatabase.LoadTable("select * from KhachHang");
            comboBox_KhachHang.ValueMember = "MAKHACHHANG";
            comboBox_KhachHang.DisplayMember = "MAKHACHHANG";
        }

        private void frm_DonHang_Load(object sender, EventArgs e)
        {
			// TODO: This line of code loads data into the 'database1DataSet5.NHANVIEN' table. You can move, or remove it, as needed.
			this.nHANVIENTableAdapter2.Fill(this.database1DataSet5.NHANVIEN);
			// TODO: This line of code loads data into the 'database1DataSet4.NHANVIEN' table. You can move, or remove it, as needed.
			this.nHANVIENTableAdapter1.Fill(this.database1DataSet4.NHANVIEN);
			// TODO: This line of code loads data into the 'database1DataSet3.NHANVIEN' table. You can move, or remove it, as needed.
			// TODO: This line of code loads data into the 'database1DataSet2.KhachHang' table. You can move, or remove it, as needed.
			this.khachHangTableAdapter.Fill(this.database1DataSet2.KhachHang);
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
			float giamgia, tientratruoc;
			float tongtien = 0;
			if (textBox_GiamGia.Text == "")
			{
				giamgia = 0;
			}
			else
			{
				giamgia = float.Parse(textBox_GiamGia.Text);
			}

			if (textBox_TienCoc.Text == "")
			{
				tientratruoc = 0;
			}
			else
			{
				tientratruoc = float.Parse(textBox_TienCoc.Text);
			}
            int msdh = (int)genericDatabase.QuerySQL("select max(msdh) from DonHang");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                int gia = int.Parse(tb.Rows[i]["GIA"].ToString());
                int soluong = int.Parse(tb.Rows[i]["SOLUONG"].ToString());
                tongtien += (gia*soluong);
            }
            textBox_TongTien.Text = "" + tongtien;
            textBox_SoTienConLai.Text = "" + (tongtien - tientratruoc);
        }

        private void button_TaoHoaDon_Click(object sender, EventArgs e)
        {
            string query1 = string.Format("insert into DonHang values({0},'{1}',{2},'{3}',{4})", 
                int.Parse(comboBox_KhachHang.SelectedValue.ToString()),
				dateTimePicker_NgayDat.Value.ToString(),
				int.Parse(textBox_TienCoc.Text), 
                dateTimePicker_NgayNhan.Value.ToString(),
				int.Parse(comboBox_NhanVien.SelectedValue.ToString()));
            genericDatabase.NonQuerySQL(query1);
            int msdh = (int)genericDatabase.QuerySQL("select max(msdh) from DonHang");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                int msb = int.Parse(tb.Rows[i]["MSB"].ToString());
                int soluong = int.Parse(tb.Rows[i]["SOLUONG"].ToString());
                string query2 = string.Format("insert into CHITIETDONHANG values({0},{1},{2})", msdh, msb, soluong);
				genericDatabase.NonQuerySQL(query2);
			}
			MessageBox.Show("Thành Công");
        }

        private void btn_ChonBanh_Click(object sender, EventArgs e)
        {
            frm_ChonBanh formBanh = new frm_ChonBanh(this);
            formBanh.Show();
        }
    }
}
