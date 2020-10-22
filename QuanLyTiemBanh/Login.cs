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
			string strcnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\truon\source\repos\QuanLyTiemBanh\QuanLyTiemBanh\Database1.mdf;Integrated Security=True";
			SqlConnection conn = new SqlConnection(strcnn);
			conn.Open();
			string strcmm = string.Format("Select COUNT(*) from THONGTINTAIKHOA where taikhoa='{0}' AND matkhau='{1}'",textBox1.Text, textBox2.Text);
			SqlCommand cmm = new SqlCommand(strcmm, conn);
			int ex = (int) cmm.ExecuteScalar();
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
