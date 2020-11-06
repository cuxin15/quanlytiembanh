namespace QuanLyTiemBanh
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.donHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nguyenLieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.danhMucSanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachHangToolStripMenuItem,
            this.nhanVienToolStripMenuItem,
            this.donHangToolStripMenuItem,
            this.nguyenLieuToolStripMenuItem,
            this.danhMucSanPhamToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// khachHangToolStripMenuItem
			// 
			this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
			this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
			this.khachHangToolStripMenuItem.Text = "Khách hàng";
			this.khachHangToolStripMenuItem.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click);
			// 
			// nhanVienToolStripMenuItem
			// 
			this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
			this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
			this.nhanVienToolStripMenuItem.Text = "Nhân viên";
			this.nhanVienToolStripMenuItem.Click += new System.EventHandler(this.nhanVienToolStripMenuItem_Click_1);
			// 
			// donHangToolStripMenuItem
			// 
			this.donHangToolStripMenuItem.Name = "donHangToolStripMenuItem";
			this.donHangToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
			this.donHangToolStripMenuItem.Text = "Đơn hàng";
			this.donHangToolStripMenuItem.Click += new System.EventHandler(this.donHangToolStripMenuItem_Click);
			// 
			// nguyenLieuToolStripMenuItem
			// 
			this.nguyenLieuToolStripMenuItem.Name = "nguyenLieuToolStripMenuItem";
			this.nguyenLieuToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
			this.nguyenLieuToolStripMenuItem.Text = "Nguyên liệu";
			// 
			// danhMucSanPhamToolStripMenuItem
			// 
			this.danhMucSanPhamToolStripMenuItem.Name = "danhMucSanPhamToolStripMenuItem";
			this.danhMucSanPhamToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
			this.danhMucSanPhamToolStripMenuItem.Text = "Danh mục sản phẩm";
			this.danhMucSanPhamToolStripMenuItem.Click += new System.EventHandler(this.danhMucSanPhamToolStripMenuItem_Click_1);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Main";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem donHangToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nguyenLieuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem danhMucSanPhamToolStripMenuItem;
	}
}