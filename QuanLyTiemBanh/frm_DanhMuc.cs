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
	public partial class frm_DanhMuc : Form
	{
		GenericDatabase genericDatabase = new GenericDatabase();
		public frm_DanhMuc()
		{
			InitializeComponent();
		}

		private void frm_DanhMuc_Load(object sender, EventArgs e)
		{
			string sql = "select * from DANHMUCBANH";
			DataTable tb = genericDatabase.LoadTable(sql);
			dataGridViewDanhmuc.DataSource = tb;
		}

		private void buttonThem_Click(object sender, EventArgs e)
		{
			string query = string.Format("insert into DANHMUCBANH values('{0}','{1}')", textBoxTenbanh.Text, textBoxGia.Text);
			int result = genericDatabase.NonQuerySQL(query);
			frm_DanhMuc_Load(null, null);
			if (result >= 1)
				MessageBox.Show("Thêm thành công");
			else
				MessageBox.Show("Thêm thất bại");
		}

		private void buttonSua_Click(object sender, EventArgs e)
		{
			string query = string.Format("update DANHMUCBANH set TENBANH ='{0}',GIA ='{1}' where MSB = {2}", textBoxTenbanh.Text, textBoxGia.Text, int.Parse(textBoxMabanh.Text));
			int result = genericDatabase.NonQuerySQL(query);
			frm_DanhMuc_Load(null, null);
			if (result >= 1)
				MessageBox.Show("Cập nhật thành công");
			else
				MessageBox.Show("Cập nhật thất bại");
		}

		private void dataGridViewDanhmuc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxMabanh.Text = "" + dataGridViewDanhmuc.CurrentRow.Cells["MSB"].Value;
			textBoxTenbanh.Text = dataGridViewDanhmuc.CurrentRow.Cells["TENBANH"].Value.ToString();
			textBoxGia.Text = dataGridViewDanhmuc.CurrentRow.Cells["GIA"].Value.ToString();
		}

		private void buttonXoa_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn muốn tiếp tục xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dr == DialogResult.Yes)
			{
				string query = string.Format("delete from DANHMUCBANH where MSB = {0}", int.Parse(textBoxMabanh.Text));
				genericDatabase.NonQuerySQL(query);
			}
			frm_DanhMuc_Load(null, null);
		}
	}
}
