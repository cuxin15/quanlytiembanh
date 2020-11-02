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
			this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.khachhangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhanvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nguyenlieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.danhmucsanphamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(805, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// thêmToolStripMenuItem
			// 
			this.thêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachhangToolStripMenuItem,
            this.nhanvienToolStripMenuItem,
            this.nguyenlieuToolStripMenuItem,
            this.danhmucsanphamToolStripMenuItem});
			this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
			this.thêmToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
			this.thêmToolStripMenuItem.Text = "Thao tác";
			// 
			// khachhangToolStripMenuItem
			// 
			this.khachhangToolStripMenuItem.Name = "khachhangToolStripMenuItem";
			this.khachhangToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
			this.khachhangToolStripMenuItem.Text = "Khách hàng";
			this.khachhangToolStripMenuItem.Click += new System.EventHandler(this.khachhangToolStripMenuItem_Click);
			// 
			// nhanvienToolStripMenuItem
			// 
			this.nhanvienToolStripMenuItem.Name = "nhanvienToolStripMenuItem";
			this.nhanvienToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
			this.nhanvienToolStripMenuItem.Text = "Nhân viên";
			this.nhanvienToolStripMenuItem.Click += new System.EventHandler(this.nhanvienToolStripMenuItem_Click);
			// 
			// nguyenlieuToolStripMenuItem
			// 
			this.nguyenlieuToolStripMenuItem.Name = "nguyenlieuToolStripMenuItem";
			this.nguyenlieuToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
			this.nguyenlieuToolStripMenuItem.Text = "Nguyên liệu";
			this.nguyenlieuToolStripMenuItem.Click += new System.EventHandler(this.nguyenlieuToolStripMenuItem_Click);
			// 
			// danhmucsanphamToolStripMenuItem
			// 
			this.danhmucsanphamToolStripMenuItem.Name = "danhmucsanphamToolStripMenuItem";
			this.danhmucsanphamToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
			this.danhmucsanphamToolStripMenuItem.Text = "Danh mục sản phẩm";
			this.danhmucsanphamToolStripMenuItem.Click += new System.EventHandler(this.danhmucsanphamToolStripMenuItem_Click);
			// 
			// báoCáoToolStripMenuItem
			// 
			this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
			this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
			this.báoCáoToolStripMenuItem.Text = "Báo cáo";
			// 
			// hỗTrợToolStripMenuItem
			// 
			this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
			this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
			this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 472);
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
		private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem khachhangToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nhanvienToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nguyenlieuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem danhmucsanphamToolStripMenuItem;
	}
}