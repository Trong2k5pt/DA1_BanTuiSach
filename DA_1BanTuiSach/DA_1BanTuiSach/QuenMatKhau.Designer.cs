namespace DA_1BanTuiSach
{
	partial class QuenMatKhau
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
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.linkDangNhap = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMkm = new System.Windows.Forms.TextBox();
			this.txtTknv = new System.Windows.Forms.TextBox();
			this.txtEnv = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnThoat
			// 
			this.btnThoat.AutoSize = true;
			this.btnThoat.Location = new System.Drawing.Point(603, 460);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 28);
			this.btnThoat.TabIndex = 19;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.AutoSize = true;
			this.btnXacNhan.Location = new System.Drawing.Point(487, 460);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(83, 28);
			this.btnXacNhan.TabIndex = 18;
			this.btnXacNhan.Text = "Xác Nhận";
			this.btnXacNhan.UseVisualStyleBackColor = true;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// linkDangNhap
			// 
			this.linkDangNhap.AutoSize = true;
			this.linkDangNhap.Location = new System.Drawing.Point(487, 409);
			this.linkDangNhap.Name = "linkDangNhap";
			this.linkDangNhap.Size = new System.Drawing.Size(82, 18);
			this.linkDangNhap.TabIndex = 17;
			this.linkDangNhap.TabStop = true;
			this.linkDangNhap.Text = "Đăng Nhập";
			this.linkDangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDangNhap_LinkClicked);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(487, 360);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 18);
			this.label4.TabIndex = 16;
			this.label4.Text = "Mật Khẩu Mới";
			// 
			// txtMkm
			// 
			this.txtMkm.Location = new System.Drawing.Point(487, 382);
			this.txtMkm.Name = "txtMkm";
			this.txtMkm.Size = new System.Drawing.Size(191, 24);
			this.txtMkm.TabIndex = 15;
			// 
			// txtTknv
			// 
			this.txtTknv.Location = new System.Drawing.Point(490, 318);
			this.txtTknv.Name = "txtTknv";
			this.txtTknv.Size = new System.Drawing.Size(188, 24);
			this.txtTknv.TabIndex = 14;
			// 
			// txtEnv
			// 
			this.txtEnv.Location = new System.Drawing.Point(490, 255);
			this.txtEnv.Name = "txtEnv";
			this.txtEnv.Size = new System.Drawing.Size(188, 24);
			this.txtEnv.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(487, 297);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 18);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tài Khoản Nhân Viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(487, 234);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 18);
			this.label2.TabIndex = 11;
			this.label2.Text = "Email Nhân Viên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(469, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(258, 38);
			this.label1.TabIndex = 10;
			this.label1.Text = "Quên Mật Khẩu";
			// 
			// QuenMatKhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1197, 633);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXacNhan);
			this.Controls.Add(this.linkDangNhap);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMkm);
			this.Controls.Add(this.txtTknv);
			this.Controls.Add(this.txtEnv);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "QuenMatKhau";
			this.Text = "QuenMatKhau";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.LinkLabel linkDangNhap;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMkm;
		private System.Windows.Forms.TextBox txtTknv;
		private System.Windows.Forms.TextBox txtEnv;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}