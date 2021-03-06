﻿namespace QuanLyTiemBanh
{
	partial class frm_ChonBanh
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView_danhmuc = new System.Windows.Forms.DataGridView();
			this.buttonOK = new System.Windows.Forms.Button();
			this.dANHMUCBANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.database1DataSet = new QuanLyTiemBanh.Database1DataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSoluong = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dANHMUCBANHTableAdapter = new QuanLyTiemBanh.Database1DataSetTableAdapters.DANHMUCBANHTableAdapter();
			this.buttonThem = new System.Windows.Forms.Button();
			this.buttonXoa = new System.Windows.Forms.Button();
			this.dANHMUCBANHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.database1DataSet1 = new QuanLyTiemBanh.Database1DataSet1();
			this.dANHMUCBANHTableAdapter1 = new QuanLyTiemBanh.Database1DataSet1TableAdapters.DANHMUCBANHTableAdapter();
			this.MSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TENBANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.listBoxBanh = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhmuc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dANHMUCBANHBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dANHMUCBANHBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_danhmuc
			// 
			this.dataGridView_danhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_danhmuc.Location = new System.Drawing.Point(496, 93);
			this.dataGridView_danhmuc.Name = "dataGridView_danhmuc";
			this.dataGridView_danhmuc.RowTemplate.Height = 24;
			this.dataGridView_danhmuc.Size = new System.Drawing.Size(663, 327);
			this.dataGridView_danhmuc.TabIndex = 0;
			this.dataGridView_danhmuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_danhmuc_CellClick);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(1017, 446);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(142, 59);
			this.buttonOK.TabIndex = 7;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// dANHMUCBANHBindingSource
			// 
			this.dANHMUCBANHBindingSource.DataMember = "DANHMUCBANH";
			this.dANHMUCBANHBindingSource.DataSource = this.database1DataSet;
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Bánh";
			// 
			// textBoxSoluong
			// 
			this.textBoxSoluong.Location = new System.Drawing.Point(322, 143);
			this.textBoxSoluong.Name = "textBoxSoluong";
			this.textBoxSoluong.Size = new System.Drawing.Size(142, 22);
			this.textBoxSoluong.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(319, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 17);
			this.label2.TabIndex = 11;
			this.label2.Text = "Số lượng";
			// 
			// dANHMUCBANHTableAdapter
			// 
			this.dANHMUCBANHTableAdapter.ClearBeforeFill = true;
			// 
			// buttonThem
			// 
			this.buttonThem.Location = new System.Drawing.Point(322, 201);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new System.Drawing.Size(142, 57);
			this.buttonThem.TabIndex = 12;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new System.EventHandler(this.buttonThems_Click);
			// 
			// buttonXoa
			// 
			this.buttonXoa.Location = new System.Drawing.Point(322, 279);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new System.Drawing.Size(142, 59);
			this.buttonXoa.TabIndex = 13;
			this.buttonXoa.Text = "Xoá";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
			// 
			// dANHMUCBANHBindingSource1
			// 
			this.dANHMUCBANHBindingSource1.DataMember = "DANHMUCBANH";
			this.dANHMUCBANHBindingSource1.DataSource = this.database1DataSet1;
			// 
			// database1DataSet1
			// 
			this.database1DataSet1.DataSetName = "Database1DataSet1";
			this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dANHMUCBANHTableAdapter1
			// 
			this.dANHMUCBANHTableAdapter1.ClearBeforeFill = true;
			// 
			// MSB
			// 
			this.MSB.DataPropertyName = "MSB";
			this.MSB.HeaderText = "Mã số bánh";
			this.MSB.Name = "MSB";
			// 
			// TENBANH
			// 
			this.TENBANH.DataPropertyName = "TENBANH";
			this.TENBANH.HeaderText = "Tên bánh";
			this.TENBANH.Name = "TENBANH";
			// 
			// listBoxBanh
			// 
			this.listBoxBanh.FormattingEnabled = true;
			this.listBoxBanh.ItemHeight = 16;
			this.listBoxBanh.Location = new System.Drawing.Point(15, 93);
			this.listBoxBanh.Name = "listBoxBanh";
			this.listBoxBanh.Size = new System.Drawing.Size(287, 324);
			this.listBoxBanh.TabIndex = 15;
			// 
			// frm_ChonBanh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1171, 517);
			this.Controls.Add(this.listBoxBanh);
			this.Controls.Add(this.buttonXoa);
			this.Controls.Add(this.buttonThem);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxSoluong);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.dataGridView_danhmuc);
			this.Name = "frm_ChonBanh";
			this.Text = "Chọn bánh";
			this.Load += new System.EventHandler(this.frm_ChonBanh_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhmuc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dANHMUCBANHBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dANHMUCBANHBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_danhmuc;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSoluong;
		private System.Windows.Forms.Label label2;
		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource dANHMUCBANHBindingSource;
		private Database1DataSetTableAdapters.DANHMUCBANHTableAdapter dANHMUCBANHTableAdapter;
		private System.Windows.Forms.Button buttonThem;
		private System.Windows.Forms.Button buttonXoa;
		private Database1DataSet1 database1DataSet1;
		private System.Windows.Forms.BindingSource dANHMUCBANHBindingSource1;
		private Database1DataSet1TableAdapters.DANHMUCBANHTableAdapter dANHMUCBANHTableAdapter1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MSB;
		private System.Windows.Forms.DataGridViewTextBoxColumn TENBANH;
		private System.Windows.Forms.ListBox listBoxBanh;
	}
}