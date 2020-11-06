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
	public partial class frm_NguyenLieu : Form
	{
		GenericDatabase gen = new GenericDatabase();
		public frm_NguyenLieu()
		{
			InitializeComponent();
		}

		private void frm_NguyenLieu_Load(object sender, EventArgs e)
		{
			string sql = "select * from NGUYENLIEU";
			DataTable table = gen.LoadTable(sql);
			dataGrid.DataSource = table;
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			int msnl = int.Parse(textBox_msnl.Text);
			string name = textBox_tennguyenlieu.Text;
			string donvitinh = textBox_donvi.Text;
			int soluong = int.Parse(textBox_soluong.Text);
			string date_nhap = dateTimePicker_ngaynhap.Value.ToString("MM-dd-yyyy");
			string date_capnhat = DateTime.Today.ToString("MM-dd-yyyy");
			string sql = String.Format("insert into NGUYENLIEU values('{0}','{1}','{2}','{3}','{4}','{5}')", msnl, name, donvitinh, soluong, date_nhap, date_capnhat);
			int output = gen.NonQuerySQL(sql);
			if (output>=1)
			{
				MessageBox.Show("Thành công", "Thông báo");
			}
			frm_NguyenLieu_Load(null, null);
		}

		private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
