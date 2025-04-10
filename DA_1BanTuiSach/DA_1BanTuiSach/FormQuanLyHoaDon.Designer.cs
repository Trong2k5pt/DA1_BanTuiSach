using System.Windows.Forms;

namespace DA_1BanTuiSach
{
    partial class FormQuanLyHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        // KHAI BÁO CONTROL
        private System.Windows.Forms.GroupBox grpLocHoaDon;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox grpDanhSachHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;

        private System.Windows.Forms.GroupBox grpChiTietHoaDon;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTongTien;
       
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        // Khai báo control
        private System.Windows.Forms.Label lblSuaTenKH;
        private System.Windows.Forms.Label lblSuaSDT;
        private System.Windows.Forms.TextBox txtSuaTenKH;
        private System.Windows.Forms.TextBox txtSuaSDT;
        private System.Windows.Forms.Button btnCapNhatKhach;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
			this.grpLocHoaDon = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.grpDanhSachHoaDon = new System.Windows.Forms.GroupBox();
			this.dgvHoaDon = new System.Windows.Forms.DataGridView();
			this.grpChiTietHoaDon = new System.Windows.Forms.GroupBox();
			this.lblMaHD = new System.Windows.Forms.Label();
			this.lblNgay = new System.Windows.Forms.Label();
			this.lblKhach = new System.Windows.Forms.Label();
			this.lblNhanVien = new System.Windows.Forms.Label();
			this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.lblSuaTenKH = new System.Windows.Forms.Label();
			this.lblSuaSDT = new System.Windows.Forms.Label();
			this.txtSuaTenKH = new System.Windows.Forms.TextBox();
			this.txtSuaSDT = new System.Windows.Forms.TextBox();
			this.btnCapNhatKhach = new System.Windows.Forms.Button();
			this.grpLocHoaDon.SuspendLayout();
			this.grpDanhSachHoaDon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
			this.grpChiTietHoaDon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
			this.SuspendLayout();
			// 
			// grpLocHoaDon
			// 
			this.grpLocHoaDon.Controls.Add(this.label1);
			this.grpLocHoaDon.Controls.Add(this.dtpTuNgay);
			this.grpLocHoaDon.Controls.Add(this.label2);
			this.grpLocHoaDon.Controls.Add(this.dtpDenNgay);
			this.grpLocHoaDon.Controls.Add(this.label3);
			this.grpLocHoaDon.Controls.Add(this.txtTimKiem);
			this.grpLocHoaDon.Controls.Add(this.btnTimKiem);
			this.grpLocHoaDon.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpLocHoaDon.Location = new System.Drawing.Point(8, 8);
			this.grpLocHoaDon.Margin = new System.Windows.Forms.Padding(2);
			this.grpLocHoaDon.Name = "grpLocHoaDon";
			this.grpLocHoaDon.Padding = new System.Windows.Forms.Padding(2);
			this.grpLocHoaDon.Size = new System.Drawing.Size(453, 312);
			this.grpLocHoaDon.TabIndex = 0;
			this.grpLocHoaDon.TabStop = false;
			this.grpLocHoaDon.Text = "Lọc hóa đơn";
			this.grpLocHoaDon.Enter += new System.EventHandler(this.grpLocHoaDon_Enter);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 41);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ ngày:";
			// 
			// dtpTuNgay
			// 
			this.dtpTuNgay.Location = new System.Drawing.Point(130, 41);
			this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(2);
			this.dtpTuNgay.Name = "dtpTuNgay";
			this.dtpTuNgay.Size = new System.Drawing.Size(286, 32);
			this.dtpTuNgay.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 109);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Đến ngày:";
			// 
			// dtpDenNgay
			// 
			this.dtpDenNgay.Location = new System.Drawing.Point(130, 109);
			this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(2);
			this.dtpDenNgay.Name = "dtpDenNgay";
			this.dtpDenNgay.Size = new System.Drawing.Size(286, 32);
			this.dtpDenNgay.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(15, 174);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 28);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên/SĐT Khách:";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(130, 174);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(286, 32);
			this.txtTimKiem.TabIndex = 5;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(147, 238);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(136, 50);
			this.btnTimKiem.TabIndex = 6;
			this.btnTimKiem.Text = "Tìm kiếm";
			// 
			// grpDanhSachHoaDon
			// 
			this.grpDanhSachHoaDon.Controls.Add(this.dgvHoaDon);
			this.grpDanhSachHoaDon.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpDanhSachHoaDon.Location = new System.Drawing.Point(479, 11);
			this.grpDanhSachHoaDon.Margin = new System.Windows.Forms.Padding(2);
			this.grpDanhSachHoaDon.Name = "grpDanhSachHoaDon";
			this.grpDanhSachHoaDon.Padding = new System.Windows.Forms.Padding(2);
			this.grpDanhSachHoaDon.Size = new System.Drawing.Size(1157, 309);
			this.grpDanhSachHoaDon.TabIndex = 1;
			this.grpDanhSachHoaDon.TabStop = false;
			this.grpDanhSachHoaDon.Text = "Danh sách hóa đơn đã thanh toán";
			// 
			// dgvHoaDon
			// 
			this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvHoaDon.Location = new System.Drawing.Point(2, 27);
			this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
			this.dgvHoaDon.Name = "dgvHoaDon";
			this.dgvHoaDon.Size = new System.Drawing.Size(1153, 280);
			this.dgvHoaDon.TabIndex = 0;
			// 
			// grpChiTietHoaDon
			// 
			this.grpChiTietHoaDon.Controls.Add(this.lblMaHD);
			this.grpChiTietHoaDon.Controls.Add(this.lblNgay);
			this.grpChiTietHoaDon.Controls.Add(this.lblKhach);
			this.grpChiTietHoaDon.Controls.Add(this.lblNhanVien);
			this.grpChiTietHoaDon.Controls.Add(this.dgvChiTietHoaDon);
			this.grpChiTietHoaDon.Controls.Add(this.lblTongTien);
			this.grpChiTietHoaDon.Controls.Add(this.lblSuaTenKH);
			this.grpChiTietHoaDon.Controls.Add(this.lblSuaSDT);
			this.grpChiTietHoaDon.Controls.Add(this.txtSuaTenKH);
			this.grpChiTietHoaDon.Controls.Add(this.txtSuaSDT);
			this.grpChiTietHoaDon.Controls.Add(this.btnCapNhatKhach);
			this.grpChiTietHoaDon.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpChiTietHoaDon.Location = new System.Drawing.Point(11, 341);
			this.grpChiTietHoaDon.Margin = new System.Windows.Forms.Padding(2);
			this.grpChiTietHoaDon.Name = "grpChiTietHoaDon";
			this.grpChiTietHoaDon.Padding = new System.Windows.Forms.Padding(2);
			this.grpChiTietHoaDon.Size = new System.Drawing.Size(1634, 530);
			this.grpChiTietHoaDon.TabIndex = 2;
			this.grpChiTietHoaDon.TabStop = false;
			this.grpChiTietHoaDon.Text = "Chi tiết hóa đơn";
			// 
			// lblMaHD
			// 
			this.lblMaHD.Location = new System.Drawing.Point(67, 49);
			this.lblMaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMaHD.Name = "lblMaHD";
			this.lblMaHD.Size = new System.Drawing.Size(226, 36);
			this.lblMaHD.TabIndex = 0;
			this.lblMaHD.Text = "Mã HĐ:";
			this.lblMaHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblNgay
			// 
			this.lblNgay.Location = new System.Drawing.Point(325, 49);
			this.lblNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNgay.Name = "lblNgay";
			this.lblNgay.Size = new System.Drawing.Size(246, 39);
			this.lblNgay.TabIndex = 1;
			this.lblNgay.Text = "Ngày:";
			this.lblNgay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblKhach
			// 
			this.lblKhach.Location = new System.Drawing.Point(658, 49);
			this.lblKhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblKhach.Name = "lblKhach";
			this.lblKhach.Size = new System.Drawing.Size(340, 39);
			this.lblKhach.TabIndex = 2;
			this.lblKhach.Text = "Khách hàng:";
			this.lblKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblNhanVien
			// 
			this.lblNhanVien.Location = new System.Drawing.Point(1047, 49);
			this.lblNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNhanVien.Name = "lblNhanVien";
			this.lblNhanVien.Size = new System.Drawing.Size(526, 45);
			this.lblNhanVien.TabIndex = 3;
			this.lblNhanVien.Text = "Nhân viên:";
			this.lblNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvChiTietHoaDon
			// 
			this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvChiTietHoaDon.Location = new System.Drawing.Point(4, 112);
			this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(2);
			this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
			this.dgvChiTietHoaDon.Size = new System.Drawing.Size(1630, 332);
			this.dgvChiTietHoaDon.TabIndex = 4;
			// 
			// lblTongTien
			// 
			this.lblTongTien.Location = new System.Drawing.Point(67, 463);
			this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(328, 49);
			this.lblTongTien.TabIndex = 5;
			this.lblTongTien.Text = "Tổng tiền:";
			this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSuaTenKH
			// 
			this.lblSuaTenKH.Location = new System.Drawing.Point(463, 463);
			this.lblSuaTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSuaTenKH.Name = "lblSuaTenKH";
			this.lblSuaTenKH.Size = new System.Drawing.Size(107, 46);
			this.lblSuaTenKH.TabIndex = 6;
			this.lblSuaTenKH.Text = "Tên mới:";
			this.lblSuaTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSuaSDT
			// 
			this.lblSuaSDT.Location = new System.Drawing.Point(884, 463);
			this.lblSuaSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSuaSDT.Name = "lblSuaSDT";
			this.lblSuaSDT.Size = new System.Drawing.Size(134, 41);
			this.lblSuaSDT.TabIndex = 7;
			this.lblSuaSDT.Text = "SĐT mới:";
			this.lblSuaSDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSuaTenKH
			// 
			this.txtSuaTenKH.Location = new System.Drawing.Point(574, 472);
			this.txtSuaTenKH.Margin = new System.Windows.Forms.Padding(2);
			this.txtSuaTenKH.Name = "txtSuaTenKH";
			this.txtSuaTenKH.Size = new System.Drawing.Size(229, 32);
			this.txtSuaTenKH.TabIndex = 8;
			// 
			// txtSuaSDT
			// 
			this.txtSuaSDT.Location = new System.Drawing.Point(1013, 468);
			this.txtSuaSDT.Margin = new System.Windows.Forms.Padding(2);
			this.txtSuaSDT.Name = "txtSuaSDT";
			this.txtSuaSDT.Size = new System.Drawing.Size(229, 32);
			this.txtSuaSDT.TabIndex = 9;
			// 
			// btnCapNhatKhach
			// 
			this.btnCapNhatKhach.Location = new System.Drawing.Point(1326, 463);
			this.btnCapNhatKhach.Margin = new System.Windows.Forms.Padding(2);
			this.btnCapNhatKhach.Name = "btnCapNhatKhach";
			this.btnCapNhatKhach.Size = new System.Drawing.Size(220, 39);
			this.btnCapNhatKhach.TabIndex = 10;
			this.btnCapNhatKhach.Text = "Cập nhật KH";
			// 
			// FormQuanLyHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1647, 876);
			this.Controls.Add(this.grpLocHoaDon);
			this.Controls.Add(this.grpDanhSachHoaDon);
			this.Controls.Add(this.grpChiTietHoaDon);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormQuanLyHoaDon";
			this.Text = "Quản lý hóa đơn";
			this.Load += new System.EventHandler(this.FormQuanLyHoaDon_Load_1);
			this.grpLocHoaDon.ResumeLayout(false);
			this.grpLocHoaDon.PerformLayout();
			this.grpDanhSachHoaDon.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
			this.grpChiTietHoaDon.ResumeLayout(false);
			this.grpChiTietHoaDon.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
			this.ResumeLayout(false);

        }


        #endregion
    }
}
