namespace DA_1BanTuiSach
{
	partial class Form3
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
			this.txtEnv = new System.Windows.Forms.TextBox();
			this.txtTknv = new System.Windows.Forms.TextBox();
			this.txtMkm = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btnXn = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(416, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(258, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quên Mật Khẩu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(434, 217);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Email Nhân Viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(434, 280);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tài Khoản Nhân Viên";
			// 
			// txtEnv
			// 
			this.txtEnv.Location = new System.Drawing.Point(437, 238);
			this.txtEnv.Name = "txtEnv";
			this.txtEnv.Size = new System.Drawing.Size(188, 24);
			this.txtEnv.TabIndex = 3;
			// 
			// txtTknv
			// 
			this.txtTknv.Location = new System.Drawing.Point(437, 301);
			this.txtTknv.Name = "txtTknv";
			this.txtTknv.Size = new System.Drawing.Size(188, 24);
			this.txtTknv.TabIndex = 4;
			// 
			// txtMkm
			// 
			this.txtMkm.Location = new System.Drawing.Point(434, 365);
			this.txtMkm.Name = "txtMkm";
			this.txtMkm.Size = new System.Drawing.Size(191, 24);
			this.txtMkm.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(434, 343);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Mật Khẩu Mới";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(434, 392);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(82, 18);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Đăng Nhập";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// btnXn
			// 
			this.btnXn.AutoSize = true;
			this.btnXn.Location = new System.Drawing.Point(434, 443);
			this.btnXn.Name = "btnXn";
			this.btnXn.Size = new System.Drawing.Size(83, 28);
			this.btnXn.TabIndex = 8;
			this.btnXn.Text = "Xác Nhận";
			this.btnXn.UseVisualStyleBackColor = true;
			this.btnXn.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.AutoSize = true;
			this.btnThoat.Location = new System.Drawing.Point(550, 443);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 28);
			this.btnThoat.TabIndex = 9;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1071, 593);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXn);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMkm);
			this.Controls.Add(this.txtTknv);
			this.Controls.Add(this.txtEnv);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form3";
			this.Text = "Quên Mật Khẩu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEnv;
		private System.Windows.Forms.TextBox txtTknv;
		private System.Windows.Forms.TextBox txtMkm;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button btnXn;
		private System.Windows.Forms.Button btnThoat;
	}
}