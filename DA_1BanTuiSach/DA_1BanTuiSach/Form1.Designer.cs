﻿namespace DA_1BanTuiSach
{
    partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(107, 255);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "Đăng Nhập";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(310, 255);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 32);
			this.button2.TabIndex = 1;
			this.button2.Text = "Thoát";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(432, 202);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(494, 322);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin Đăng Nhập";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(160, 197);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(111, 18);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Quên Mật Khẩu";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(160, 164);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '?';
			this.textBox2.Size = new System.Drawing.Size(234, 24);
			this.textBox2.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(160, 81);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(234, 24);
			this.textBox1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(68, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Mật Khẩu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(64, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tài Khoản";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(404, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 42);
			this.label1.TabIndex = 4;
			this.label1.Text = "Đăng Nhập";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DA_1BanTuiSach.Properties.Resources._363963286_293256773357106_1565876528714835516_n;
			this.pictureBox1.Location = new System.Drawing.Point(78, 245);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(258, 228);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1061, 597);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Đăng Nhập";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}

