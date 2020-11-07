using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
			DataColumn column;
			column = new DataColumn();
			//tableBanh.Columns.Add("MSB", typeof(int));
			//tableBanh.Columns.Add("TENBANH", typeof(string));
			//tableBanh.Columns.Add("GIA", typeof(int));
			//tableBanh.Columns.Add("SOLUONG", typeof(int));


			column.DataType = typeof(int);
			column.ColumnName = "MSB";
			tableBanh.Columns.Add(column);
			var key = new DataColumn[1];
			key[0] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "TENBANH";
			tableBanh.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(int);
			column.ColumnName = "GIA";
			tableBanh.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(int);
			column.ColumnName = "SOLUONG";
			tableBanh.Columns.Add(column);

			tableBanh.PrimaryKey = key;

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
			if (textBoxSoluong.Text == "")
			{
				MessageBox.Show("Vui lòng nhập số lượng");
			}
			else
			{
				DataRow row = ((DataRowView)listBoxBanh.SelectedItem).Row;
				if (tableBanh.Rows.Contains(row["MSB"]))
				{
					foreach (DataRow dr in tableBanh.Rows) // search whole table
					{
						if (dr["TENBANH"].ToString() == listBoxBanh.GetItemText(listBoxBanh.SelectedItem)) // if id==2
						{
							dr["SOLUONG"] = int.Parse(textBoxSoluong.Text);
							break;
						}
					}
					dataGridView_danhmuc.DataSource = tableBanh;
					textBoxSoluong.Text = "";
				}
				else
				{
					tableBanh.Rows.Add(row["MSB"], row["TENBANH"], row["GIA"], int.Parse(textBoxSoluong.Text));
					dataGridView_danhmuc.DataSource = tableBanh;
					textBoxSoluong.Text = "";
				}
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
			string sql = "select * from DANHMUCBANH";
			DataTable tb = genericDatabase.LoadTable(sql);
			listBoxBanh.DataSource = tb;
			listBoxBanh.DisplayMember = "TENBANH";
			listBoxBanh.ValueMember = "MSB";
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.parent.LoadDataGrid(tableBanh);
			Close();
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView_danhmuc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxSoluong.Text = dataGridView_danhmuc.CurrentRow.Cells["SOLUONG"].Value.ToString();
			string selectedItem = dataGridView_danhmuc.CurrentRow.Cells["TENBANH"].Value.ToString();
			for (int i = 0; i < listBoxBanh.Items.Count; i++)
			{
				if (listBoxBanh.GetItemText(listBoxBanh.Items[i]) == selectedItem)
				{
					listBoxBanh.SetSelected(i, true);
					break;
				}
			}
		}

		private void buttonXoa_Click(object sender, EventArgs e)
		{
			string tenbanh = dataGridView_danhmuc.CurrentRow.Cells["TENBANH"].Value.ToString();
			foreach (DataRow orow in tableBanh.Select())
			{
				if (orow["TENBANH"].ToString().Equals(tenbanh))
				{
					tableBanh.Rows.Remove(orow);
				}
			}
			tableBanh.AcceptChanges();
			dataGridView_danhmuc.DataSource = tableBanh;
			textBoxSoluong.Text = "";
		}

		private void buttonSua_Click(object sender, EventArgs e)
		{

		}
	}
}
