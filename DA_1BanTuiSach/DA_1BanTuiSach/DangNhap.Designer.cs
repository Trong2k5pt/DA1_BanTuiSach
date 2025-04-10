namespace DA_1BanTuiSach
{
	partial class DangNhap
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
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.txtMk = new System.Windows.Forms.TextBox();
			this.txtTk = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.AutoSize = true;
			this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap.Location = new System.Drawing.Point(107, 255);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(104, 32);
			this.btnDangNhap.TabIndex = 0;
			this.btnDangNhap.Text = "Đăng Nhập";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.AutoSize = true;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(310, 255);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(84, 32);
			this.btnThoat.TabIndex = 1;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Controls.Add(this.txtMk);
			this.groupBox1.Controls.Add(this.txtTk);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnDangNhap);
			this.groupBox1.Controls.Add(this.btnThoat);
			this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(636, 329);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(494, 322);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " ";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(160, 197);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(125, 20);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Quên Mật Khẩu";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// txtMk
			// 
			this.txtMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMk.Location = new System.Drawing.Point(160, 164);
			this.txtMk.Name = "txtMk";
			this.txtMk.PasswordChar = '?';
			this.txtMk.Size = new System.Drawing.Size(234, 27);
			this.txtMk.TabIndex = 5;
			// 
			// txtTk
			// 
			this.txtTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTk.Location = new System.Drawing.Point(160, 81);
			this.txtTk.Name = "txtTk";
			this.txtTk.Size = new System.Drawing.Size(234, 27);
			this.txtTk.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(68, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Mật Khẩu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(64, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tài Khoản";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(775, 188);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 42);
			this.label1.TabIndex = 7;
			this.label1.Text = "Đăng Nhập";
			// 
			// DangNhap
			// 
			this.AcceptButton = this.btnDangNhap;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::DA_1BanTuiSach.Properties.Resources._2c99941c7922c3a861c2ce1bb41ad3dc;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1647, 876);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Location = new System.Drawing.Point(262, 71);
			this.Name = "DangNhap";
			this.Text = "DangNhap";
			this.Load += new System.EventHandler(this.DangNhap_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TextBox txtMk;
		private System.Windows.Forms.TextBox txtTk;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}