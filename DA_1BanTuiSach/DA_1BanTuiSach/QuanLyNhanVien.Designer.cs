namespace DA_1BanTuiSach
{
	partial class QuanLyNhanVien
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtTimkiem = new System.Windows.Forms.TextBox();
			this.btnTimkiem = new System.Windows.Forms.Button();
			this.btnLammoi = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.rbNghilam = new System.Windows.Forms.RadioButton();
			this.rbLam = new System.Windows.Forms.RadioButton();
			this.cbGt = new System.Windows.Forms.ComboBox();
			this.txtMk = new System.Windows.Forms.TextBox();
			this.txtTk = new System.Windows.Forms.TextBox();
			this.txtSdt = new System.Windows.Forms.TextBox();
			this.txtDiachi = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtTennv = new System.Windows.Forms.TextBox();
			this.txtmaNv = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(60, 380);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1155, 277);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh Sách Nhân Viên";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 20);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1149, 254);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// txtTimkiem
			// 
			this.txtTimkiem.Location = new System.Drawing.Point(793, 259);
			this.txtTimkiem.Name = "txtTimkiem";
			this.txtTimkiem.Size = new System.Drawing.Size(230, 24);
			this.txtTimkiem.TabIndex = 24;
			// 
			// btnTimkiem
			// 
			this.btnTimkiem.AutoSize = true;
			this.btnTimkiem.Location = new System.Drawing.Point(1042, 255);
			this.btnTimkiem.Name = "btnTimkiem";
			this.btnTimkiem.Size = new System.Drawing.Size(81, 28);
			this.btnTimkiem.TabIndex = 23;
			this.btnTimkiem.Text = "Tìm Kiếm";
			this.btnTimkiem.UseVisualStyleBackColor = true;
			this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
			// 
			// btnLammoi
			// 
			this.btnLammoi.Location = new System.Drawing.Point(1042, 197);
			this.btnLammoi.Name = "btnLammoi";
			this.btnLammoi.Size = new System.Drawing.Size(75, 23);
			this.btnLammoi.TabIndex = 22;
			this.btnLammoi.Text = "Làm Mới";
			this.btnLammoi.UseVisualStyleBackColor = true;
			this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(1042, 151);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 21;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(1042, 104);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 20;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(1042, 58);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 19;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// rbNghilam
			// 
			this.rbNghilam.AutoSize = true;
			this.rbNghilam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNghilam.Location = new System.Drawing.Point(916, 198);
			this.rbNghilam.Name = "rbNghilam";
			this.rbNghilam.Size = new System.Drawing.Size(92, 22);
			this.rbNghilam.TabIndex = 18;
			this.rbNghilam.TabStop = true;
			this.rbNghilam.Text = "Nghỉ Làm";
			this.rbNghilam.UseVisualStyleBackColor = true;
			// 
			// rbLam
			// 
			this.rbLam.AutoSize = true;
			this.rbLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbLam.Location = new System.Drawing.Point(831, 198);
			this.rbLam.Name = "rbLam";
			this.rbLam.Size = new System.Drawing.Size(76, 22);
			this.rbLam.TabIndex = 17;
			this.rbLam.TabStop = true;
			this.rbLam.Text = "Đi Làm";
			this.rbLam.UseVisualStyleBackColor = true;
			// 
			// cbGt
			// 
			this.cbGt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbGt.FormattingEnabled = true;
			this.cbGt.Location = new System.Drawing.Point(524, 195);
			this.cbGt.Name = "cbGt";
			this.cbGt.Size = new System.Drawing.Size(136, 26);
			this.cbGt.TabIndex = 16;
			// 
			// txtMk
			// 
			this.txtMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMk.Location = new System.Drawing.Point(831, 123);
			this.txtMk.Name = "txtMk";
			this.txtMk.Size = new System.Drawing.Size(139, 24);
			this.txtMk.TabIndex = 15;
			// 
			// txtTk
			// 
			this.txtTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTk.Location = new System.Drawing.Point(831, 57);
			this.txtTk.Name = "txtTk";
			this.txtTk.Size = new System.Drawing.Size(139, 24);
			this.txtTk.TabIndex = 14;
			// 
			// txtSdt
			// 
			this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSdt.Location = new System.Drawing.Point(524, 123);
			this.txtSdt.Name = "txtSdt";
			this.txtSdt.Size = new System.Drawing.Size(136, 24);
			this.txtSdt.TabIndex = 13;
			// 
			// txtDiachi
			// 
			this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiachi.Location = new System.Drawing.Point(524, 58);
			this.txtDiachi.Name = "txtDiachi";
			this.txtDiachi.Size = new System.Drawing.Size(136, 24);
			this.txtDiachi.TabIndex = 12;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(168, 197);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(185, 24);
			this.txtEmail.TabIndex = 11;
			// 
			// txtTennv
			// 
			this.txtTennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTennv.Location = new System.Drawing.Point(168, 123);
			this.txtTennv.Name = "txtTennv";
			this.txtTennv.Size = new System.Drawing.Size(185, 24);
			this.txtTennv.TabIndex = 10;
			// 
			// txtmaNv
			// 
			this.txtmaNv.Enabled = false;
			this.txtmaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmaNv.Location = new System.Drawing.Point(168, 58);
			this.txtmaNv.Name = "txtmaNv";
			this.txtmaNv.Size = new System.Drawing.Size(185, 24);
			this.txtmaNv.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(693, 197);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 18);
			this.label9.TabIndex = 8;
			this.label9.Text = "Trạng Thái";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(693, 123);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 18);
			this.label8.TabIndex = 7;
			this.label8.Text = "Mật Khẩu";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(693, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 18);
			this.label7.TabIndex = 6;
			this.label7.Text = "Tài Khoản";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(403, 197);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Giới Tính";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(403, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Số Điện Thoại";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(403, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Địa Chỉ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(52, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(48, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên Nhân Viên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã Nhân Viên";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTimkiem);
			this.groupBox1.Controls.Add(this.btnTimkiem);
			this.groupBox1.Controls.Add(this.btnLammoi);
			this.groupBox1.Controls.Add(this.btnXoa);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.rbNghilam);
			this.groupBox1.Controls.Add(this.rbLam);
			this.groupBox1.Controls.Add(this.cbGt);
			this.groupBox1.Controls.Add(this.txtMk);
			this.groupBox1.Controls.Add(this.txtTk);
			this.groupBox1.Controls.Add(this.txtSdt);
			this.groupBox1.Controls.Add(this.txtDiachi);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtTennv);
			this.groupBox1.Controls.Add(this.txtmaNv);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(60, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1155, 304);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin Nhân Viên";
			// 
			// QuanLyNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1274, 693);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "QuanLyNhanVien";
			this.Text = "QuanLyNhanVien";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyNhanVien_FormClosing);
			this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtTimkiem;
		private System.Windows.Forms.Button btnTimkiem;
		private System.Windows.Forms.Button btnLammoi;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.RadioButton rbNghilam;
		private System.Windows.Forms.RadioButton rbLam;
		private System.Windows.Forms.ComboBox cbGt;
		private System.Windows.Forms.TextBox txtMk;
		private System.Windows.Forms.TextBox txtTk;
		private System.Windows.Forms.TextBox txtSdt;
		private System.Windows.Forms.TextBox txtDiachi;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtTennv;
		private System.Windows.Forms.TextBox txtmaNv;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}