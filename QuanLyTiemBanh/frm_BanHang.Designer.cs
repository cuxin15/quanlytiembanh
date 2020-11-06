namespace QuanLyTiemBanh
{
	partial class frm_BanHang
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
			this.dataGridView_chonbanh = new System.Windows.Forms.DataGridView();
			this.buttonTim = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_chonbanh)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_chonbanh
			// 
			this.dataGridView_chonbanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_chonbanh.Location = new System.Drawing.Point(10, 75);
			this.dataGridView_chonbanh.Name = "dataGridView_chonbanh";
			this.dataGridView_chonbanh.RowTemplate.Height = 24;
			this.dataGridView_chonbanh.Size = new System.Drawing.Size(944, 445);
			this.dataGridView_chonbanh.TabIndex = 0;
			// 
			// buttonTim
			// 
			this.buttonTim.Location = new System.Drawing.Point(225, 30);
			this.buttonTim.Name = "buttonTim";
			this.buttonTim.Size = new System.Drawing.Size(75, 23);
			this.buttonTim.TabIndex = 1;
			this.buttonTim.Text = "Tìm";
			this.buttonTim.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(10, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(209, 22);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(793, 527);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(160, 49);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// frm_BanHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 591);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonTim);
			this.Controls.Add(this.dataGridView_chonbanh);
			this.Name = "frm_BanHang";
			this.Text = "Chọn bánh";
			this.Load += new System.EventHandler(this.frm_BanHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_chonbanh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_chonbanh;
		private System.Windows.Forms.Button buttonTim;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonOK;
	}
}