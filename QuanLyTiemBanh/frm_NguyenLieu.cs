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
		GenericDatabase genericDatabase = new GenericDatabase();
		public frm_NguyenLieu()
		{
			InitializeComponent();
		}

		private void frm_NguyenLieu_Load(object sender, EventArgs e)
		{
			string query = "select * from NguyenLieu";
			dataGrid.DataSource = genericDatabase.LoadTable(query);
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			string query = string.Format("insert into NguyenLieu values('{0}','{1}','{2}',{3},'{4}')", textBox_tennguyenlieu.Text, textBox_donvi.Text, float.Parse(textBox_soluong.Text), dateTimePicker_ngaynhap.Value, DateTime.Now.Date);
			int result = genericDatabase.NonQuerySQL(query);
			if (result >= 1)
				MessageBox.Show("Thêm thành công");
			else
				MessageBox.Show("Thêm thất bại");
			frm_NguyenLieu_Load(null, null);
		}

		private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox_msnl.Text = "" + dataGrid.CurrentRow.Cells["MASONL"].Value;
			textBox_tennguyenlieu.Text = dataGrid.CurrentRow.Cells["TEN"].Value.ToString();
			textBox_donvi.Text = dataGrid.CurrentRow.Cells["DONVITINH"].Value.ToString();
			textBox_soluong.Text = dataGrid.CurrentRow.Cells["SOLUONG"].Value.ToString();
			dateTimePicker_ngaynhap.Text = dataGrid.CurrentRow.Cells["NGAYNHAP"].Value.ToString();
		}

        private void button_edit_Click(object sender, EventArgs e)
        {
			string query = string.Format("update NguyenLieu set TEN = '{0}',DONVITINH = '{1}', SOLUONG = {2}, NGAYNHAP = '{3}' where MASONL = {4}", textBox_tennguyenlieu.Text, textBox_donvi.Text, float.Parse(textBox_soluong.Text), dateTimePicker_ngaynhap.Value, int.Parse(textBox_msnl.Text));
			int result = genericDatabase.NonQuerySQL(query);
			if (result >= 1)
				MessageBox.Show("Cập nhật thành công");
			else
				MessageBox.Show("Cập nhật thất bại");
			frm_NguyenLieu_Load(null, null);
		}

        private void button_delete_Click(object sender, EventArgs e)
        {
			DialogResult dr = MessageBox.Show("Bạn muốn tiếp tục xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dr == DialogResult.Yes)
			{
				string query = string.Format("delete from KhachHang where MASONL = {0}", int.Parse(textBox_msnl.Text));
				genericDatabase.NonQuerySQL(query);
			}
			frm_NguyenLieu_Load(null, null);
		}
    }
}
