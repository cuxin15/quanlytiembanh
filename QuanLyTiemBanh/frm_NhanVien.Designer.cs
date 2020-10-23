namespace QuanLyTiemBanh
{
	partial class frm_NhanVien
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox_nhanvien = new System.Windows.Forms.PictureBox();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.textBox_vitri = new System.Windows.Forms.TextBox();
			this.textBox_luong = new System.Windows.Forms.TextBox();
			this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
			this.button_browser_image = new System.Windows.Forms.Button();
			this.dataGridView_nhanvien = new System.Windows.Forms.DataGridView();
			this.msnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.luongtheogio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_Them = new System.Windows.Forms.Button();
			this.button_Sua = new System.Windows.Forms.Button();
			this.button_Xoa = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_nhanvien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(341, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "NHÂN VIÊN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên nhân viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(86, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày sinh";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(86, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Vị trí";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(86, 256);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Lương theo giờ";
			// 
			// pictureBox_nhanvien
			// 
			this.pictureBox_nhanvien.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox_nhanvien.Location = new System.Drawing.Point(472, 110);
			this.pictureBox_nhanvien.Name = "pictureBox_nhanvien";
			this.pictureBox_nhanvien.Size = new System.Drawing.Size(143, 163);
			this.pictureBox_nhanvien.TabIndex = 5;
			this.pictureBox_nhanvien.TabStop = false;
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(211, 105);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(165, 22);
			this.textBox_name.TabIndex = 6;
			// 
			// textBox_vitri
			// 
			this.textBox_vitri.Location = new System.Drawing.Point(211, 210);
			this.textBox_vitri.Name = "textBox_vitri";
			this.textBox_vitri.Size = new System.Drawing.Size(165, 22);
			this.textBox_vitri.TabIndex = 8;
			// 
			// textBox_luong
			// 
			this.textBox_luong.Location = new System.Drawing.Point(211, 256);
			this.textBox_luong.Name = "textBox_luong";
			this.textBox_luong.Size = new System.Drawing.Size(165, 22);
			this.textBox_luong.TabIndex = 9;
			// 
			// dateTimePicker_ngaysinh
			// 
			this.dateTimePicker_ngaysinh.CustomFormat = "dd/MM/yyyy";
			this.dateTimePicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(211, 161);
			this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
			this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(165, 22);
			this.dateTimePicker_ngaysinh.TabIndex = 10;
			// 
			// button_browser_image
			// 
			this.button_browser_image.Location = new System.Drawing.Point(639, 110);
			this.button_browser_image.Name = "button_browser_image";
			this.button_browser_image.Size = new System.Drawing.Size(75, 38);
			this.button_browser_image.TabIndex = 11;
			this.button_browser_image.Text = "Duyệt";
			this.button_browser_image.UseVisualStyleBackColor = true;
			// 
			// dataGridView_nhanvien
			// 
			this.dataGridView_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msnv,
            this.name,
            this.ngaysinh,
            this.vitri,
            this.luongtheogio});
			this.dataGridView_nhanvien.Location = new System.Drawing.Point(12, 397);
			this.dataGridView_nhanvien.Name = "dataGridView_nhanvien";
			this.dataGridView_nhanvien.RowTemplate.Height = 24;
			this.dataGridView_nhanvien.Size = new System.Drawing.Size(776, 150);
			this.dataGridView_nhanvien.TabIndex = 12;
			// 
			// msnv
			// 
			this.msnv.HeaderText = "Mã số";
			this.msnv.Name = "msnv";
			// 
			// name
			// 
			this.name.HeaderText = "Tên";
			this.name.Name = "name";
			// 
			// ngaysinh
			// 
			this.ngaysinh.HeaderText = "Ngày sinh";
			this.ngaysinh.Name = "ngaysinh";
			// 
			// vitri
			// 
			this.vitri.HeaderText = "Vị trí";
			this.vitri.Name = "vitri";
			// 
			// luongtheogio
			// 
			this.luongtheogio.HeaderText = "Lương theo giờ";
			this.luongtheogio.Name = "luongtheogio";
			// 
			// button_Them
			// 
			this.button_Them.Location = new System.Drawing.Point(71, 328);
			this.button_Them.Name = "button_Them";
			this.button_Them.Size = new System.Drawing.Size(126, 38);
			this.button_Them.TabIndex = 13;
			this.button_Them.Text = "Thêm";
			this.button_Them.UseVisualStyleBackColor = true;
			// 
			// button_Sua
			// 
			this.button_Sua.Location = new System.Drawing.Point(223, 328);
			this.button_Sua.Name = "button_Sua";
			this.button_Sua.Size = new System.Drawing.Size(120, 38);
			this.button_Sua.TabIndex = 14;
			this.button_Sua.Text = "Sửa";
			this.button_Sua.UseVisualStyleBackColor = true;
			// 
			// button_Xoa
			// 
			this.button_Xoa.Location = new System.Drawing.Point(373, 328);
			this.button_Xoa.Name = "button_Xoa";
			this.button_Xoa.Size = new System.Drawing.Size(129, 38);
			this.button_Xoa.TabIndex = 15;
			this.button_Xoa.Text = "Xoá";
			this.button_Xoa.UseVisualStyleBackColor = true;
			// 
			// frm_NhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 559);
			this.Controls.Add(this.button_Xoa);
			this.Controls.Add(this.button_Sua);
			this.Controls.Add(this.button_Them);
			this.Controls.Add(this.dataGridView_nhanvien);
			this.Controls.Add(this.button_browser_image);
			this.Controls.Add(this.dateTimePicker_ngaysinh);
			this.Controls.Add(this.textBox_luong);
			this.Controls.Add(this.textBox_vitri);
			this.Controls.Add(this.textBox_name);
			this.Controls.Add(this.pictureBox_nhanvien);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frm_NhanVien";
			this.Text = "frm_NhanVien";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_nhanvien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox_nhanvien;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.TextBox textBox_vitri;
		private System.Windows.Forms.TextBox textBox_luong;
		private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
		private System.Windows.Forms.Button button_browser_image;
		private System.Windows.Forms.DataGridView dataGridView_nhanvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn msnv;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn vitri;
		private System.Windows.Forms.DataGridViewTextBoxColumn luongtheogio;
		private System.Windows.Forms.Button button_Them;
		private System.Windows.Forms.Button button_Sua;
		private System.Windows.Forms.Button button_Xoa;
	}
}