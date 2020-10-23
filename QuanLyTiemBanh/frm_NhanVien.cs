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
			pictureBox_nhanvien.SizeMode = PictureBoxSizeMode.AutoSize;
		}
	}
}
