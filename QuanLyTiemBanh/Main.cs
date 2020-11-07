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
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void khachhangToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["frm_KhachHang"] == null)
			{
				frm_KhachHang kh = new frm_KhachHang();
				kh.MdiParent = this;
				kh.Show();
			}
			else
			{
				Application.OpenForms["frm_KhachHang"].Activate();
			}
		}

		private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
		{
            
		}

		private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["frm_KhachHang"] == null)
			{
				frm_KhachHang kh = new frm_KhachHang();
				kh.MdiParent = this;
				kh.Show();
			}
			else
			{
				Application.OpenForms["frm_KhachHang"].Activate();
			}
		}

		private void nhanVienToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (Application.OpenForms["frm_NhanVien"] == null)
			{
				frm_NhanVien nv = new frm_NhanVien();
				nv.MdiParent = this;
				nv.Show();
			}
			else
			{
				Application.OpenForms["frm_NhanVien"].Activate();
			}
		}

		private void donHangToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["frm_DonHang"] == null)
			{
				frm_DonHang nv = new frm_DonHang();
				nv.MdiParent = this;
				nv.Show();
			}
			else
			{
				Application.OpenForms["frm_DonHang"].Activate();
			}
		}
	}
}
