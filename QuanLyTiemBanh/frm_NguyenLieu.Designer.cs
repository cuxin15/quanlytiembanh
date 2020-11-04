namespace QuanLyTiemBanh
{
	partial class frm_NguyenLieu
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.textBox_msnl = new System.Windows.Forms.TextBox();
            this.textBox_tennguyenlieu = new System.Windows.Forms.TextBox();
            this.textBox_donvi = new System.Windows.Forms.TextBox();
            this.textBox_soluong = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.MASONL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycapnhatgannhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số nguyên liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nguyên liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày nhập";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASONL,
            this.TEN,
            this.donvitinh,
            this.soluong,
            this.ngaynhap,
            this.ngaycapnhatgannhat});
            this.dataGrid.Location = new System.Drawing.Point(12, 376);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(776, 150);
            this.dataGrid.TabIndex = 5;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // textBox_msnl
            // 
            this.textBox_msnl.Location = new System.Drawing.Point(214, 62);
            this.textBox_msnl.Name = "textBox_msnl";
            this.textBox_msnl.Size = new System.Drawing.Size(159, 22);
            this.textBox_msnl.TabIndex = 7;
            // 
            // textBox_tennguyenlieu
            // 
            this.textBox_tennguyenlieu.Location = new System.Drawing.Point(214, 119);
            this.textBox_tennguyenlieu.Name = "textBox_tennguyenlieu";
            this.textBox_tennguyenlieu.Size = new System.Drawing.Size(159, 22);
            this.textBox_tennguyenlieu.TabIndex = 8;
            // 
            // textBox_donvi
            // 
            this.textBox_donvi.Location = new System.Drawing.Point(214, 180);
            this.textBox_donvi.Name = "textBox_donvi";
            this.textBox_donvi.Size = new System.Drawing.Size(159, 22);
            this.textBox_donvi.TabIndex = 9;
            // 
            // textBox_soluong
            // 
            this.textBox_soluong.Location = new System.Drawing.Point(214, 236);
            this.textBox_soluong.Name = "textBox_soluong";
            this.textBox_soluong.Size = new System.Drawing.Size(159, 22);
            this.textBox_soluong.TabIndex = 10;
            // 
            // dateTimePicker_ngaynhap
            // 
            this.dateTimePicker_ngaynhap.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaynhap.Location = new System.Drawing.Point(547, 62);
            this.dateTimePicker_ngaynhap.Name = "dateTimePicker_ngaynhap";
            this.dateTimePicker_ngaynhap.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_ngaynhap.TabIndex = 11;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(174, 301);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(118, 41);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(327, 301);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(118, 41);
            this.button_edit.TabIndex = 13;
            this.button_edit.Text = "Sửa";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(486, 301);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(118, 41);
            this.button_delete.TabIndex = 14;
            this.button_delete.Text = "Xoá";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // MASONL
            // 
            this.MASONL.DataPropertyName = "MASONL";
            this.MASONL.HeaderText = "Mã số nguyên liệu";
            this.MASONL.MinimumWidth = 6;
            this.MASONL.Name = "MASONL";
            this.MASONL.Width = 125;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên nguyên liệu";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            this.TEN.Width = 125;
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đơn vị tính";
            this.donvitinh.MinimumWidth = 6;
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Width = 125;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày Nhập";
            this.ngaynhap.MinimumWidth = 6;
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Width = 125;
            // 
            // ngaycapnhatgannhat
            // 
            this.ngaycapnhatgannhat.DataPropertyName = "ngaycapnhatgannhat";
            this.ngaycapnhatgannhat.HeaderText = "Ngày cập nhật gần nhất";
            this.ngaycapnhatgannhat.MinimumWidth = 6;
            this.ngaycapnhatgannhat.Name = "ngaycapnhatgannhat";
            this.ngaycapnhatgannhat.Width = 125;
            // 
            // frm_NguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dateTimePicker_ngaynhap);
            this.Controls.Add(this.textBox_soluong);
            this.Controls.Add(this.textBox_donvi);
            this.Controls.Add(this.textBox_tennguyenlieu);
            this.Controls.Add(this.textBox_msnl);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_NguyenLieu";
            this.Text = "frm_NguyenLieu";
            this.Load += new System.EventHandler(this.frm_NguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.TextBox textBox_msnl;
		private System.Windows.Forms.TextBox textBox_tennguyenlieu;
		private System.Windows.Forms.TextBox textBox_donvi;
		private System.Windows.Forms.TextBox textBox_soluong;
		private System.Windows.Forms.DateTimePicker dateTimePicker_ngaynhap;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_edit;
		private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASONL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycapnhatgannhat;
    }
}