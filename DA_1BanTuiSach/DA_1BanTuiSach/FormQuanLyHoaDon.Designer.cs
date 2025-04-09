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
           

            // Thêm mới
            this.lblSuaTenKH = new System.Windows.Forms.Label();
            this.lblSuaSDT = new System.Windows.Forms.Label();
            this.txtSuaTenKH = new System.Windows.Forms.TextBox();
            this.txtSuaSDT = new System.Windows.Forms.TextBox();
            this.btnCapNhatKhach = new System.Windows.Forms.Button();

            // === grpLocHoaDon ===
            this.grpLocHoaDon.Controls.Add(this.label1);
            this.grpLocHoaDon.Controls.Add(this.dtpTuNgay);
            this.grpLocHoaDon.Controls.Add(this.label2);
            this.grpLocHoaDon.Controls.Add(this.dtpDenNgay);
            this.grpLocHoaDon.Controls.Add(this.label3);
            this.grpLocHoaDon.Controls.Add(this.txtTimKiem);
            this.grpLocHoaDon.Controls.Add(this.btnTimKiem);
            this.grpLocHoaDon.Location = new System.Drawing.Point(10, 10);
            this.grpLocHoaDon.Size = new System.Drawing.Size(450, 200);
            this.grpLocHoaDon.Text = "Lọc hóa đơn";

            // Các label và điều khiển lọc
            this.label1.Text = "Từ ngày:";
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.dtpTuNgay.Location = new System.Drawing.Point(140, 25);

            this.label2.Text = "Đến ngày:";
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.dtpDenNgay.Location = new System.Drawing.Point(140, 65);

            this.label3.Text = "Tên/SĐT Khách:";
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.txtTimKiem.Location = new System.Drawing.Point(140, 105);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Location = new System.Drawing.Point(253, 104);

            // === grpDanhSachHoaDon ===
            this.grpDanhSachHoaDon.Controls.Add(this.dgvHoaDon);
            this.grpDanhSachHoaDon.Location = new System.Drawing.Point(470, 10);
            this.grpDanhSachHoaDon.Size = new System.Drawing.Size(1000, 200);
            this.grpDanhSachHoaDon.Text = "Danh sách hóa đơn đã thanh toán";

            this.dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.Dock = DockStyle.Fill;

            // === grpChiTietHoaDon ===
            this.grpChiTietHoaDon.Controls.Add(this.lblMaHD);
            this.grpChiTietHoaDon.Controls.Add(this.lblNgay);
            this.grpChiTietHoaDon.Controls.Add(this.lblKhach);
            this.grpChiTietHoaDon.Controls.Add(this.lblNhanVien);
            this.grpChiTietHoaDon.Controls.Add(this.dgvChiTietHoaDon);
            this.grpChiTietHoaDon.Controls.Add(this.lblTongTien);
            

            // Thêm mới vào group
            this.grpChiTietHoaDon.Controls.Add(this.lblSuaTenKH);
            this.grpChiTietHoaDon.Controls.Add(this.lblSuaSDT);
            this.grpChiTietHoaDon.Controls.Add(this.txtSuaTenKH);
            this.grpChiTietHoaDon.Controls.Add(this.txtSuaSDT);
            this.grpChiTietHoaDon.Controls.Add(this.btnCapNhatKhach);

            this.grpChiTietHoaDon.Location = new System.Drawing.Point(10, 220);
            this.grpChiTietHoaDon.Size = new System.Drawing.Size(1460, 500);
            this.grpChiTietHoaDon.Text = "Chi tiết hóa đơn";

            // Các label chính
            this.lblMaHD.Location = new System.Drawing.Point(20, 30);
            this.lblMaHD.Text = "Mã HĐ:";
            this.lblNgay.Location = new System.Drawing.Point(250, 30);
            this.lblNgay.Text = "Ngày:";
            this.lblKhach.Location = new System.Drawing.Point(500, 30);
            this.lblKhach.Text = "Khách hàng:";
            this.lblNhanVien.Location = new System.Drawing.Point(800, 30);
            this.lblNhanVien.Text = "Nhân viên:";

            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(20, 60);
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(1410, 300);
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.lblTongTien.Location = new System.Drawing.Point(20, 380);
            this.lblTongTien.Text = "Tổng tiền:";
           

            // Các điều khiển cập nhật khách
            this.lblSuaTenKH.Text = "Tên mới:";
            this.lblSuaTenKH.Location = new System.Drawing.Point(130, 420);
            this.lblSuaTenKH.Size = new System.Drawing.Size(80, 23);

            this.txtSuaTenKH.Location = new System.Drawing.Point(210, 420);
            this.txtSuaTenKH.Size = new System.Drawing.Size(150, 22);

            this.lblSuaSDT.Text = "SĐT mới:";
            this.lblSuaSDT.Location = new System.Drawing.Point(380, 420);
            this.lblSuaSDT.Size = new System.Drawing.Size(80, 23);

            this.txtSuaSDT.Location = new System.Drawing.Point(460, 420);
            this.txtSuaSDT.Size = new System.Drawing.Size(150, 22);

            this.btnCapNhatKhach.Text = "Cập nhật KH";
            this.btnCapNhatKhach.Location = new System.Drawing.Point(630, 418);
            this.btnCapNhatKhach.Size = new System.Drawing.Size(100, 26);

            // === Form ===
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.grpLocHoaDon);
            this.Controls.Add(this.grpDanhSachHoaDon);
            this.Controls.Add(this.grpChiTietHoaDon);
            this.Text = "Quản lý hóa đơn";
        }


        #endregion
    }
}
