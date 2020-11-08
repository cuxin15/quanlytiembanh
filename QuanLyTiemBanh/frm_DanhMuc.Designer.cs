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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxMabanh = new System.Windows.Forms.TextBox();
			this.textBoxTenbanh = new System.Windows.Forms.TextBox();
			this.textBoxGia = new System.Windows.Forms.TextBox();
			this.dataGridViewDanhmuc = new System.Windows.Forms.DataGridView();
			this.buttonThem = new System.Windows.Forms.Button();
			this.buttonSua = new System.Windows.Forms.Button();
			this.buttonXoa = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhmuc)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã bánh";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên bánh";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Giá";
			// 
			// textBoxMabanh
			// 
			this.textBoxMabanh.Enabled = false;
			this.textBoxMabanh.Location = new System.Drawing.Point(185, 51);
			this.textBoxMabanh.Name = "textBoxMabanh";
			this.textBoxMabanh.Size = new System.Drawing.Size(150, 22);
			this.textBoxMabanh.TabIndex = 3;
			// 
			// textBoxTenbanh
			// 
			this.textBoxTenbanh.Location = new System.Drawing.Point(185, 115);
			this.textBoxTenbanh.Name = "textBoxTenbanh";
			this.textBoxTenbanh.Size = new System.Drawing.Size(150, 22);
			this.textBoxTenbanh.TabIndex = 4;
			// 
			// textBoxGia
			// 
			this.textBoxGia.Location = new System.Drawing.Point(185, 181);
			this.textBoxGia.Name = "textBoxGia";
			this.textBoxGia.Size = new System.Drawing.Size(150, 22);
			this.textBoxGia.TabIndex = 5;
			// 
			// dataGridViewDanhmuc
			// 
			this.dataGridViewDanhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDanhmuc.Location = new System.Drawing.Point(12, 247);
			this.dataGridViewDanhmuc.Name = "dataGridViewDanhmuc";
			this.dataGridViewDanhmuc.RowTemplate.Height = 24;
			this.dataGridViewDanhmuc.Size = new System.Drawing.Size(776, 191);
			this.dataGridViewDanhmuc.TabIndex = 6;
			this.dataGridViewDanhmuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhmuc_CellClick);
			// 
			// buttonThem
			// 
			this.buttonThem.Location = new System.Drawing.Point(456, 52);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new System.Drawing.Size(123, 49);
			this.buttonThem.TabIndex = 7;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
			// 
			// buttonSua
			// 
			this.buttonSua.Location = new System.Drawing.Point(456, 107);
			this.buttonSua.Name = "buttonSua";
			this.buttonSua.Size = new System.Drawing.Size(123, 49);
			this.buttonSua.TabIndex = 8;
			this.buttonSua.Text = "Sửa";
			this.buttonSua.UseVisualStyleBackColor = true;
			this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
			// 
			// buttonXoa
			// 
			this.buttonXoa.Location = new System.Drawing.Point(456, 168);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new System.Drawing.Size(123, 49);
			this.buttonXoa.TabIndex = 9;
			this.buttonXoa.Text = "Xoá";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
			// 
			// frm_DanhMuc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonXoa);
			this.Controls.Add(this.buttonSua);
			this.Controls.Add(this.buttonThem);
			this.Controls.Add(this.dataGridViewDanhmuc);
			this.Controls.Add(this.textBoxGia);
			this.Controls.Add(this.textBoxTenbanh);
			this.Controls.Add(this.textBoxMabanh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frm_DanhMuc";
			this.Text = "frm_DanhMuc";
			this.Load += new System.EventHandler(this.frm_DanhMuc_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhmuc)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxMabanh;
		private System.Windows.Forms.TextBox textBoxTenbanh;
		private System.Windows.Forms.TextBox textBoxGia;
		private System.Windows.Forms.DataGridView dataGridViewDanhmuc;
		private System.Windows.Forms.Button buttonThem;
		private System.Windows.Forms.Button buttonSua;
		private System.Windows.Forms.Button buttonXoa;
	}
}