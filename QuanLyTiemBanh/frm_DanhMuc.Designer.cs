namespace QuanLyTiemBanh
{
	partial class frm_DanhMuc
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
			this.dataGridView_danhmuc = new System.Windows.Forms.DataGridView();
			this.label_name = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.textBox_gia = new System.Windows.Forms.TextBox();
			this.pictureBox_banh = new System.Windows.Forms.PictureBox();
			this.button_browser = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhmuc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_banh)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_danhmuc
			// 
			this.dataGridView_danhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_danhmuc.Location = new System.Drawing.Point(12, 288);
			this.dataGridView_danhmuc.Name = "dataGridView_danhmuc";
			this.dataGridView_danhmuc.RowTemplate.Height = 24;
			this.dataGridView_danhmuc.Size = new System.Drawing.Size(776, 150);
			this.dataGridView_danhmuc.TabIndex = 0;
			// 
			// label_name
			// 
			this.label_name.AutoSize = true;
			this.label_name.Location = new System.Drawing.Point(60, 74);
			this.label_name.Name = "label_name";
			this.label_name.Size = new System.Drawing.Size(33, 17);
			this.label_name.TabIndex = 1;
			this.label_name.Text = "Tên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Giá";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(121, 71);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(170, 22);
			this.textBox_name.TabIndex = 3;
			// 
			// textBox_gia
			// 
			this.textBox_gia.Location = new System.Drawing.Point(121, 138);
			this.textBox_gia.Name = "textBox_gia";
			this.textBox_gia.Size = new System.Drawing.Size(170, 22);
			this.textBox_gia.TabIndex = 4;
			// 
			// pictureBox_banh
			// 
			this.pictureBox_banh.Location = new System.Drawing.Point(431, 44);
			this.pictureBox_banh.Name = "pictureBox_banh";
			this.pictureBox_banh.Size = new System.Drawing.Size(171, 194);
			this.pictureBox_banh.TabIndex = 5;
			this.pictureBox_banh.TabStop = false;
			// 
			// button_browser
			// 
			this.button_browser.Location = new System.Drawing.Point(609, 44);
			this.button_browser.Name = "button_browser";
			this.button_browser.Size = new System.Drawing.Size(102, 49);
			this.button_browser.TabIndex = 6;
			this.button_browser.Text = "Duyệt";
			this.button_browser.UseVisualStyleBackColor = true;
			// 
			// frm_DanhMuc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button_browser);
			this.Controls.Add(this.pictureBox_banh);
			this.Controls.Add(this.textBox_gia);
			this.Controls.Add(this.textBox_name);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label_name);
			this.Controls.Add(this.dataGridView_danhmuc);
			this.Name = "frm_DanhMuc";
			this.Text = "Danh mục sản phẩm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhmuc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_banh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_danhmuc;
		private System.Windows.Forms.Label label_name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.TextBox textBox_gia;
		private System.Windows.Forms.PictureBox pictureBox_banh;
		private System.Windows.Forms.Button button_browser;
	}
}