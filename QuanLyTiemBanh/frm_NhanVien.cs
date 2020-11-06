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
	public partial class frm_NhanVien : Form
	{
		GenericDatabase genericDatabase = new GenericDatabase();
		public frm_NhanVien()
		{
			InitializeComponent();
		}

		private void button_browser_image_Click(object sender, EventArgs e)
		{
			OpenFileDialog image_nhanvien = new OpenFileDialog();
			image_nhanvien.ShowDialog();
			string path_image = image_nhanvien.FileName;
			textBox_luong.Text = path_image;
			pictureBox_nhanvien.Image = Image.FromFile(path_image);
			pictureBox_nhanvien.SizeMode = PictureBoxSizeMode.Zoom;
		}

		private void button_Them_Click(object sender, EventArgs e)
		{
			String tennhanvien = textBox_name.Text;
			String vitri = textBox_vitri.Text;
			int luong = int.Parse(textBox_luong.Text);
			//String sql = String.Format("Insert into NHANVIEN values('{0}','{1}','{2}','{3}','{4}')");
		}
	}
}
