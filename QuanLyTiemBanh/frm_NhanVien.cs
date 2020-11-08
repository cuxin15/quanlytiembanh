using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemBanh
{
	public partial class frm_NhanVien : Form
	{
		string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\IMAGES\\";
		GenericDatabase genericDatabase = new GenericDatabase();
		public frm_NhanVien()
		{
			InitializeComponent();
		}

		private void button_Them_Click(object sender, EventArgs e)
		{
			String tennhanvien = textBox_name.Text;
			String vitri = textBox_vitri.Text;
			int luong = int.Parse(textBox_luong.Text);
            String sql = String.Format("Insert into NHANVIEN values('{0}','{1}','{2}')",tennhanvien,vitri,luong);
			int result = genericDatabase.NonQuerySQL(sql);
            if (result >0)
            {
				MessageBox.Show("Luu thanh cong");
				frm_NhanVien_Load(null, null);
			}
            else
            {
				MessageBox.Show("Them that bai");
            }
			
        }

        private void pictureBox_nhanvien_Click(object sender, EventArgs e)
        {
			OpenFileDialog open = new OpenFileDialog();
			open.Title = "Hãy chọn ảnh ";
			open.Filter = "PNG|*.png|JPG|*.jpg|Tất cả|*.*";
			if (open.ShowDialog() == DialogResult.OK)
			{
				pictureBox_nhanvien.Image = Image.FromFile(open.FileName);
			}
		}

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
			dataGridView_nhanvien.DataSource = genericDatabase.LoadTable("select * from NHANVIEN");
        }

        private void dataGridView_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			textBox_name.Text = dataGridView_nhanvien.CurrentRow.Cells["HOTEN"].Value.ToString();
			textBox_luong.Text = dataGridView_nhanvien.CurrentRow.Cells["LUONGTHEOGIO"].Value.ToString();
			textBox_vitri.Text = dataGridView_nhanvien.CurrentRow.Cells["VITRI"].Value.ToString();
		}

        private void button_Sua_Click(object sender, EventArgs e)
        {
			String tennhanvien = textBox_name.Text;
			String vitri = textBox_vitri.Text;
			int luong = int.Parse(textBox_luong.Text);
			int msnv = int.Parse(dataGridView_nhanvien.CurrentRow.Cells["MSNV"].Value.ToString());
			String sql = String.Format("update NHANVIEN values HOTEN = '{0}',VITRI = '{1}',LUONGTHEOGIO = {2} where MSNV = {3}", tennhanvien, vitri, luong, msnv);
			int result = genericDatabase.NonQuerySQL(sql);
			if (result > 0)
			{
				MessageBox.Show("Cap nhat thanh cong");
				frm_NhanVien_Load(null,null);
			}
			else
			{
				MessageBox.Show("Cap nhat that bai");
			}
		}

        private void button_Xoa_Click(object sender, EventArgs e)
        {
			int msnv = int.Parse(dataGridView_nhanvien.CurrentRow.Cells["MSNV"].Value.ToString());
			DialogResult dr = MessageBox.Show("Ban chac chan muon xoa?","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
				string sql = "delete from NHANVIEN where MSNV = "+ msnv;
				genericDatabase.NonQuerySQL(sql);
            }
			frm_NhanVien_Load(null, null);
        }
    }
}
