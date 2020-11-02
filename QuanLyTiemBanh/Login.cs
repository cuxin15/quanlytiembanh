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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void button_login_Click(object sender, EventArgs e)
		{
			GenericDatabase genericDatabase = new GenericDatabase();
			int ex = (int)genericDatabase.NonQuerySQL(string.Format("Select COUNT(*) from THONGTINTAIKHOA where taikhoan='{0}' AND matkhau='{1}'", textBox_TaiKhoan.Text, textBox_MatKhau.Text));
			if (ex == 1)
			{
				button_login.Text = "Dang nhap thanh cong";
			}
			else
			{
				button_login.Text = "Có thể tên tài khoản hoặc mật khẩu không đúng";
			}
		}
	}
}
