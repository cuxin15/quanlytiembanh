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
	public partial class frm_BanHang : Form
	{
		GenericDatabase genericDatabase = new GenericDatabase();
		public frm_BanHang()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void frm_BanHang_Load(object sender, EventArgs e)
		{
			String sql = "select * from DANHMUCBANH";
			DataTable tb = genericDatabase.LoadTable(sql);
			dataGridView_chonbanh.DataSource = tb;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{

		}
	}
}
