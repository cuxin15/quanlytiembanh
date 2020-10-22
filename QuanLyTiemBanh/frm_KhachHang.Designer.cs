namespace QuanLyTiemBanh
{
    partial class frm_KhachHang
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
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_QLKhachHang = new System.Windows.Forms.DataGridView();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_CapNhat = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(163, 104);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(169, 22);
            this.txt_HoTen.TabIndex = 2;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(163, 155);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(169, 22);
            this.txt_DiaChi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(163, 209);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(169, 22);
            this.txt_SDT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // dataGridView_QLKhachHang
            // 
            this.dataGridView_QLKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QLKhachHang.Location = new System.Drawing.Point(64, 379);
            this.dataGridView_QLKhachHang.Name = "dataGridView_QLKhachHang";
            this.dataGridView_QLKhachHang.RowHeadersWidth = 51;
            this.dataGridView_QLKhachHang.RowTemplate.Height = 24;
            this.dataGridView_QLKhachHang.Size = new System.Drawing.Size(582, 150);
            this.dataGridView_QLKhachHang.TabIndex = 7;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(64, 263);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(120, 65);
            this.button_Them.TabIndex = 8;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            // 
            // button_CapNhat
            // 
            this.button_CapNhat.Location = new System.Drawing.Point(298, 263);
            this.button_CapNhat.Name = "button_CapNhat";
            this.button_CapNhat.Size = new System.Drawing.Size(120, 65);
            this.button_CapNhat.TabIndex = 9;
            this.button_CapNhat.Text = "Cập nhật";
            this.button_CapNhat.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(526, 263);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(120, 65);
            this.button_Xoa.TabIndex = 10;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 541);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_CapNhat);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.dataGridView_QLKhachHang);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_KhachHang";
            this.Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_QLKhachHang;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_CapNhat;
        private System.Windows.Forms.Button button_Xoa;
    }
}