namespace DA_1BanTuiSach
{
	partial class KhachHang
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
			this.DanhSach_KhachHang = new System.Windows.Forms.GroupBox();
			this.data_viewKH = new System.Windows.Forms.DataGridView();
			this.bt_timkiem = new System.Windows.Forms.Button();
			this.tb_timkiem = new System.Windows.Forms.TextBox();
			this.lb_timkiemkhachhang = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tb_gioitinh = new System.Windows.Forms.TextBox();
			this.bt_sua = new System.Windows.Forms.Button();
			this.bt_them = new System.Windows.Forms.Button();
			this.tb_trangthai = new System.Windows.Forms.TextBox();
			this.tb_email = new System.Windows.Forms.TextBox();
			this.tb_diachi = new System.Windows.Forms.TextBox();
			this.tb_sdt = new System.Windows.Forms.TextBox();
			this.tb_tenKH = new System.Windows.Forms.TextBox();
			this.tb_maKH = new System.Windows.Forms.TextBox();
			this.lb_makhachhang = new System.Windows.Forms.Label();
			this.lb_trangthaikhachhang = new System.Windows.Forms.Label();
			this.lb_emailkhachhang = new System.Windows.Forms.Label();
			this.lb_diachikhachhang = new System.Windows.Forms.Label();
			this.lb_sodienthoaikhachhang = new System.Windows.Forms.Label();
			this.lb_tenkhachhang = new System.Windows.Forms.Label();
			this.lb_gioitinhkhachhang = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lb_thongtinkhachhang = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DanhSach_KhachHang.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.data_viewKH)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// DanhSach_KhachHang
			// 
			this.DanhSach_KhachHang.Controls.Add(this.data_viewKH);
			this.DanhSach_KhachHang.Location = new System.Drawing.Point(12, 284);
			this.DanhSach_KhachHang.Name = "DanhSach_KhachHang";
			this.DanhSach_KhachHang.Size = new System.Drawing.Size(742, 221);
			this.DanhSach_KhachHang.TabIndex = 35;
			this.DanhSach_KhachHang.TabStop = false;
			this.DanhSach_KhachHang.Text = "Danh Sách Khách Hàng";
			// 
			// data_viewKH
			// 
			this.data_viewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data_viewKH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.data_viewKH.Location = new System.Drawing.Point(3, 16);
			this.data_viewKH.Name = "data_viewKH";
			this.data_viewKH.Size = new System.Drawing.Size(736, 202);
			this.data_viewKH.TabIndex = 3;
			this.data_viewKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_viewKH_CellClick);
			// 
			// bt_timkiem
			// 
			this.bt_timkiem.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_timkiem.Location = new System.Drawing.Point(520, 240);
			this.bt_timkiem.Name = "bt_timkiem";
			this.bt_timkiem.Size = new System.Drawing.Size(75, 29);
			this.bt_timkiem.TabIndex = 32;
			this.bt_timkiem.Text = "Tìm kiếm";
			this.bt_timkiem.UseVisualStyleBackColor = false;
			this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
			// 
			// tb_timkiem
			// 
			this.tb_timkiem.Location = new System.Drawing.Point(311, 246);
			this.tb_timkiem.Name = "tb_timkiem";
			this.tb_timkiem.Size = new System.Drawing.Size(184, 20);
			this.tb_timkiem.TabIndex = 33;
			// 
			// lb_timkiemkhachhang
			// 
			this.lb_timkiemkhachhang.AutoSize = true;
			this.lb_timkiemkhachhang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_timkiemkhachhang.Location = new System.Drawing.Point(162, 252);
			this.lb_timkiemkhachhang.Name = "lb_timkiemkhachhang";
			this.lb_timkiemkhachhang.Size = new System.Drawing.Size(126, 15);
			this.lb_timkiemkhachhang.TabIndex = 34;
			this.lb_timkiemkhachhang.Text = "Tìm kiếm khách hàng";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tb_gioitinh);
			this.groupBox1.Controls.Add(this.bt_sua);
			this.groupBox1.Controls.Add(this.bt_them);
			this.groupBox1.Controls.Add(this.tb_trangthai);
			this.groupBox1.Controls.Add(this.tb_email);
			this.groupBox1.Controls.Add(this.tb_diachi);
			this.groupBox1.Controls.Add(this.tb_sdt);
			this.groupBox1.Controls.Add(this.tb_tenKH);
			this.groupBox1.Controls.Add(this.tb_maKH);
			this.groupBox1.Controls.Add(this.lb_makhachhang);
			this.groupBox1.Controls.Add(this.lb_trangthaikhachhang);
			this.groupBox1.Controls.Add(this.lb_emailkhachhang);
			this.groupBox1.Controls.Add(this.lb_diachikhachhang);
			this.groupBox1.Controls.Add(this.lb_sodienthoaikhachhang);
			this.groupBox1.Controls.Add(this.lb_tenkhachhang);
			this.groupBox1.Controls.Add(this.lb_gioitinhkhachhang);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(742, 191);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			// 
			// tb_gioitinh
			// 
			this.tb_gioitinh.Location = new System.Drawing.Point(160, 96);
			this.tb_gioitinh.Name = "tb_gioitinh";
			this.tb_gioitinh.Size = new System.Drawing.Size(184, 26);
			this.tb_gioitinh.TabIndex = 20;
			// 
			// bt_sua
			// 
			this.bt_sua.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_sua.Location = new System.Drawing.Point(408, 158);
			this.bt_sua.Name = "bt_sua";
			this.bt_sua.Size = new System.Drawing.Size(75, 29);
			this.bt_sua.TabIndex = 19;
			this.bt_sua.Text = "Sửa";
			this.bt_sua.UseVisualStyleBackColor = false;
			this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
			// 
			// bt_them
			// 
			this.bt_them.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.bt_them.Location = new System.Drawing.Point(299, 158);
			this.bt_them.Name = "bt_them";
			this.bt_them.Size = new System.Drawing.Size(75, 29);
			this.bt_them.TabIndex = 17;
			this.bt_them.Text = "Thêm";
			this.bt_them.UseVisualStyleBackColor = false;
			this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
			// 
			// tb_trangthai
			// 
			this.tb_trangthai.Location = new System.Drawing.Point(453, 126);
			this.tb_trangthai.Name = "tb_trangthai";
			this.tb_trangthai.Size = new System.Drawing.Size(184, 26);
			this.tb_trangthai.TabIndex = 16;
			// 
			// tb_email
			// 
			this.tb_email.Location = new System.Drawing.Point(453, 91);
			this.tb_email.Name = "tb_email";
			this.tb_email.Size = new System.Drawing.Size(184, 26);
			this.tb_email.TabIndex = 15;
			// 
			// tb_diachi
			// 
			this.tb_diachi.Location = new System.Drawing.Point(453, 57);
			this.tb_diachi.Name = "tb_diachi";
			this.tb_diachi.Size = new System.Drawing.Size(184, 26);
			this.tb_diachi.TabIndex = 14;
			// 
			// tb_sdt
			// 
			this.tb_sdt.Location = new System.Drawing.Point(453, 25);
			this.tb_sdt.Name = "tb_sdt";
			this.tb_sdt.Size = new System.Drawing.Size(184, 26);
			this.tb_sdt.TabIndex = 13;
			// 
			// tb_tenKH
			// 
			this.tb_tenKH.Location = new System.Drawing.Point(160, 57);
			this.tb_tenKH.Name = "tb_tenKH";
			this.tb_tenKH.Size = new System.Drawing.Size(184, 26);
			this.tb_tenKH.TabIndex = 10;
			// 
			// tb_maKH
			// 
			this.tb_maKH.Location = new System.Drawing.Point(160, 25);
			this.tb_maKH.Name = "tb_maKH";
			this.tb_maKH.Size = new System.Drawing.Size(184, 26);
			this.tb_maKH.TabIndex = 9;
			// 
			// lb_makhachhang
			// 
			this.lb_makhachhang.AutoSize = true;
			this.lb_makhachhang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_makhachhang.Location = new System.Drawing.Point(33, 31);
			this.lb_makhachhang.Name = "lb_makhachhang";
			this.lb_makhachhang.Size = new System.Drawing.Size(89, 15);
			this.lb_makhachhang.TabIndex = 8;
			this.lb_makhachhang.Text = "Mã khách hàng";
			// 
			// lb_trangthaikhachhang
			// 
			this.lb_trangthaikhachhang.AutoSize = true;
			this.lb_trangthaikhachhang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_trangthaikhachhang.Location = new System.Drawing.Point(363, 132);
			this.lb_trangthaikhachhang.Name = "lb_trangthaikhachhang";
			this.lb_trangthaikhachhang.Size = new System.Drawing.Size(63, 15);
			this.lb_trangthaikhachhang.TabIndex = 7;
			this.lb_trangthaikhachhang.Text = "Trạng thái";
			// 
			// lb_emailkhachhang
			// 
			this.lb_emailkhachhang.AutoSize = true;
			this.lb_emailkhachhang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_emailkhachhang.Location = new System.Drawing.Point(363, 102);
			this.lb_emailkhachhang.Name = "lb_emailkhachhang";
			this.lb_emailkhachhang.Size = new System.Drawing.Size(39, 15);
			this.lb_emailkhachhang.TabIndex = 6;
			this.lb_emailkhachhang.Text = "Email";
			// 
			// lb_diachikhachhang
			// 
			this.lb_diachikhachhang.AutoSize = true;
			this.lb_diachikhachhang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_diachikhachhang.Location = new System.Drawing.Point(363, 68);
			this.lb_diachikhachhang.Name = "lb_diachikhachhang";
			this.lb_diachikhachhang.Size = new System.Drawing.Size(46, 15);
			this.lb_diachikhachhang.TabIndex = 5;
			this.lb_diachikhachhang.Text = "Địa chỉ";
			// 
			// lb_sodienthoaikhachhang
			// 
			this.lb_sodienthoaikhachhang.AutoSize = true;
			this.lb_sodienthoaikhachhang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_sodienthoaikhachhang.Location = new System.Drawing.Point(363, 31);
			this.lb_sodienthoaikhachhang.Name = "lb_sodienthoaikhachhang";
			this.lb_sodienthoaikhachhang.Size = new System.Drawing.Size(78, 15);
			this.lb_sodienthoaikhachhang.TabIndex = 4;
			this.lb_sodienthoaikhachhang.Text = "Số điện thoại";
			// 
			// lb_tenkhachhang
			// 
			this.lb_tenkhachhang.AutoSize = true;
			this.lb_tenkhachhang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tenkhachhang.Location = new System.Drawing.Point(33, 74);
			this.lb_tenkhachhang.Name = "lb_tenkhachhang";
			this.lb_tenkhachhang.Size = new System.Drawing.Size(95, 15);
			this.lb_tenkhachhang.TabIndex = 2;
			this.lb_tenkhachhang.Text = "Tên Khách Hàng";
			// 
			// lb_gioitinhkhachhang
			// 
			this.lb_gioitinhkhachhang.AutoSize = true;
			this.lb_gioitinhkhachhang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_gioitinhkhachhang.Location = new System.Drawing.Point(33, 107);
			this.lb_gioitinhkhachhang.Name = "lb_gioitinhkhachhang";
			this.lb_gioitinhkhachhang.Size = new System.Drawing.Size(60, 15);
			this.lb_gioitinhkhachhang.TabIndex = 1;
			this.lb_gioitinhkhachhang.Text = "Giới Tính";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(33, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 13);
			this.label2.TabIndex = 0;
			// 
			// lb_thongtinkhachhang
			// 
			this.lb_thongtinkhachhang.AutoSize = true;
			this.lb_thongtinkhachhang.Font = new System.Drawing.Font("Cambria", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_thongtinkhachhang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lb_thongtinkhachhang.Location = new System.Drawing.Point(222, 3);
			this.lb_thongtinkhachhang.Name = "lb_thongtinkhachhang";
			this.lb_thongtinkhachhang.Size = new System.Drawing.Size(346, 37);
			this.lb_thongtinkhachhang.TabIndex = 30;
			this.lb_thongtinkhachhang.Text = "Thông Tin Khách Hàng";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(193, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 29;
			this.label1.Text = "label1";
			// 
			// KhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 517);
			this.Controls.Add(this.DanhSach_KhachHang);
			this.Controls.Add(this.bt_timkiem);
			this.Controls.Add(this.tb_timkiem);
			this.Controls.Add(this.lb_timkiemkhachhang);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lb_thongtinkhachhang);
			this.Controls.Add(this.label1);
			this.Name = "KhachHang";
			this.Text = "KhachHang";
			this.Load += new System.EventHandler(this.KhachHang_Load);
			this.DanhSach_KhachHang.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.data_viewKH)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox DanhSach_KhachHang;
		private System.Windows.Forms.DataGridView data_viewKH;
		private System.Windows.Forms.Button bt_timkiem;
		private System.Windows.Forms.TextBox tb_timkiem;
		private System.Windows.Forms.Label lb_timkiemkhachhang;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tb_gioitinh;
		private System.Windows.Forms.Button bt_sua;
		private System.Windows.Forms.Button bt_them;
		private System.Windows.Forms.TextBox tb_trangthai;
		private System.Windows.Forms.TextBox tb_email;
		private System.Windows.Forms.TextBox tb_diachi;
		private System.Windows.Forms.TextBox tb_sdt;
		private System.Windows.Forms.TextBox tb_tenKH;
		private System.Windows.Forms.Label lb_trangthaikhachhang;
		private System.Windows.Forms.Label lb_emailkhachhang;
		private System.Windows.Forms.Label lb_diachikhachhang;
		private System.Windows.Forms.Label lb_sodienthoaikhachhang;
		private System.Windows.Forms.Label lb_tenkhachhang;
		private System.Windows.Forms.Label lb_gioitinhkhachhang;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lb_thongtinkhachhang;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_maKH;
		private System.Windows.Forms.Label lb_makhachhang;
	}
}