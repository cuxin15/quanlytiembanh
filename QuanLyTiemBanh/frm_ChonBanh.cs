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
	public partial class frm_ChonBanh : Form
	{
		GenericDatabase genericDatabase = new GenericDatabase();
		DataTable tableBanh = new DataTable();
		frm_DonHang parent;

		public frm_ChonBanh(frm_DonHang parent)
		{
			InitializeComponent();
			tableBanh.Columns.Add("MSB", typeof(int));
			tableBanh.Columns.Add("TENBANH", typeof(string));
			tableBanh.Columns.Add("GIA", typeof(int));
			tableBanh.Columns.Add("SOLUONG", typeof(int));
			this.parent = parent;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button_them_Click(object sender, EventArgs e)
		{
			string sql = String.Format("insert into DANHMUCBANH values('','','')");
		}

		private void buttonThems_Click(object sender, EventArgs e)
		{
			int masobanh = (int) comboBoxBanh.SelectedValue;
			String tenbanh = comboBoxBanh.GetItemText(comboBoxBanh.SelectedItem);
			int soluong = int.Parse(textBoxSoluong.Text.ToString());
			int giaBanh = this.giaBanh(masobanh);

			if (tableBanh.Rows.Count > 0)
			{
				int tontai = isExistBanh(masobanh);
				if (tontai != -1)
				{
					tableBanh.Rows[tontai].SetField(1, tenbanh);
					tableBanh.Rows[tontai].SetField(2, giaBanh);
					tableBanh.Rows[tontai].SetField(3, soluong);
					dataGridView_danhmuc.DataSource = tableBanh;
					return;
				}
				else
				{
					tableBanh.Rows.Add(masobanh, tenbanh, giaBanh, soluong);
					dataGridView_danhmuc.DataSource = tableBanh;
				}
			}
			else
			{
				tableBanh.Rows.Add(masobanh, tenbanh, giaBanh, soluong);
				dataGridView_danhmuc.DataSource = tableBanh;
			}
		}

		private int tongTien(int msb, int soluongbanh)
		{
			String sql = String.Format("select GIA from DANHMUCBANH where MSB = {0}", msb);
			int giabanh = (int) genericDatabase.QuerySQL(sql);
			return giabanh*soluongbanh;
		}

		private int giaBanh(int msb)
		{
			String sql = String.Format("select GIA from DANHMUCBANH where MSB = {0}", msb);
			int giabanh = (int)genericDatabase.QuerySQL(sql);
			return giabanh;
		}

		private int isExistBanh(int msb)
		{
			for(int i=0; i<tableBanh.Rows.Count; ++i)
			{
				int msbUser = (int) tableBanh.Rows[i][0];
				if (msbUser == msb)
				{
					return i;
				}
			}
			return -1;
		}

		private void frm_ChonBanh_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database1DataSet1.DANHMUCBANH' table. You can move, or remove it, as needed.
			this.dANHMUCBANHTableAdapter1.Fill(this.database1DataSet1.DANHMUCBANH);

		}

		private DataTable buttonOK_Click(object sender, EventArgs e)
		{
			return new DataTable();
		}
	}
}
