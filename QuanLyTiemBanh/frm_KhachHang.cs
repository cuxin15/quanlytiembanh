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
    public partial class frm_KhachHang : Form
    {
        GenericDatabase genericDatabase = new GenericDatabase();
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into KhachHang values('{0}','{1}',{2})",txt_HoTen.Text,txt_SDT.Text,txt_DiaChi.Text);
            int result = genericDatabase.NonQuerySQL(query);
            if (result >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            frm_KhachHang_Load(null, null);
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            string query = "select * from KhachHang";
            genericDatabase.LoadTable(query);
        }

        private void dataGridView_QLKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKhachHang.Text = ""+dataGridView_QLKhachHang.CurrentRow.Cells["MAKHACHHANG"].Value;
            txt_HoTen.Text = dataGridView_QLKhachHang.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_SDT.Text = dataGridView_QLKhachHang.CurrentRow.Cells["SDT"].Value.ToString();
            txt_DiaChi.Text = dataGridView_QLKhachHang.CurrentRow.Cells["DIACHI"].Value.ToString();
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            string query = string.Format("update KhachHang set HOTEN ='{0},SDT ='{1},DIACHI ='{2}'",txt_HoTen.Text,txt_SDT.Text,txt_DiaChi.Text);
            int result = genericDatabase.NonQuerySQL(query);
            if (result >= 1)
                MessageBox.Show("Cập nhật thành công");
            else
                MessageBox.Show("Cập nhật thất bại");
            frm_KhachHang_Load(null, null);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn tiếp tục xóa?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string query = string.Format("delete from KhachHang where MAKHACHHANG = {0}",int.Parse(txt_MaKhachHang.Text));
                genericDatabase.NonQuerySQL(query);
            }
            frm_KhachHang_Load(null, null);
        }
    }
    }
