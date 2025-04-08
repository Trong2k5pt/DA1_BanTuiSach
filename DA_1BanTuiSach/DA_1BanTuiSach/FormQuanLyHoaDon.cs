using DA_1BanTuiSach.BLL;
using DA_1BanTuiSach.DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DA_1BanTuiSach
{
    public partial class FormQuanLyHoaDon : Form
    {
        private HoaDonBLL hoaDonBLL = new HoaDonBLL();
        private HoaDonChiTietBLL hoaDonChiTietBLL = new HoaDonChiTietBLL();
        private SanPhamChiTietBLL sanPhamChiTietBLL = new SanPhamChiTietBLL();

        private List<HoaDon> danhSachHoaDon = new List<HoaDon>();

        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            this.Load += FormQuanLyHoaDon_Load;
            this.btnTimKiem.Click += btnTimKiem_Click;
            this.dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            this.btnCapNhatKhach.Click += btnCapNhatKhach_Click;
        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;
            LoadDanhSachHoaDon();
        }

        private void LoadDanhSachHoaDon()
        {
            danhSachHoaDon = hoaDonBLL.GetAllHoaDonDaThanhToan();

            foreach (var hd in danhSachHoaDon)
            {
                if (hd.TongTien == 0)
                {
                    var tong = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(hd.MaHoaDon)
                                .Sum(ct => ct.SoLuongSanPham * ct.Gia);
                    hd.TongTien = tong;
                }
            }

            dgvHoaDon.DataSource = danhSachHoaDon.Select(hd => new
            {
                hd.MaHoaDon,
                hd.MaHoaDonHienThi,
                hd.TenKhachHang,
                hd.SoDienThoai,
                NgayThanhToan = hd.NgayLapHoaDon,
                hd.TongTien
            }).ToList();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var ketQua = danhSachHoaDon
                .Where(hd => hd.NgayLapHoaDon.Date >= tuNgay &&
                             hd.NgayLapHoaDon.Date <= denNgay &&
                            (hd.TenKhachHang.ToLower().Contains(keyword) ||
                             hd.SoDienThoai.Contains(keyword)))
                .Select(hd => new
                {
                    hd.MaHoaDon,
                    hd.MaHoaDonHienThi,
                    hd.TenKhachHang,
                    hd.SoDienThoai,
                    NgayThanhToan = hd.NgayLapHoaDon,
                    hd.TongTien
                }).ToList();

            dgvHoaDon.DataSource = ketQua;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maHD = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells["MaHoaDon"].Value);
                var hoaDon = danhSachHoaDon.FirstOrDefault(h => h.MaHoaDon == maHD);
                if (hoaDon == null) return;

                lblMaHD.Text = "Mã HĐ: " + hoaDon.MaHoaDonHienThi;
                lblNgay.Text = "Ngày: " + hoaDon.NgayLapHoaDon.ToString("dd/MM/yyyy");
                lblKhach.Text = "Khách hàng: " + hoaDon.TenKhachHang;
                lblNhanVien.Text = "Nhân viên: NV0" + hoaDon.MaNhanVien;
                lblTongTien.Text = "Tổng tiền: " + hoaDon.TongTien.ToString("N0") + " VND";

                txtSuaTenKH.Text = hoaDon.TenKhachHang;
                txtSuaSDT.Text = hoaDon.SoDienThoai;

                var chiTietList = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(maHD);
                var data = chiTietList.Select(hdct =>
                {
                    var spct = sanPhamChiTietBLL.GetSanPhamChiTietById(hdct.MaSanPhamChiTiet);
                    return new
                    {
                        hdct.TenSanPham,
                        hdct.SoLuongSanPham,
                        hdct.Gia,
                        ThanhTien = hdct.SoLuongSanPham * hdct.Gia,
                        spct.TenMau,
                        spct.Size,
                        spct.ChatLieu,
                        spct.KieuDang
                    };
                }).ToList();

                dgvChiTietHoaDon.DataSource = data;
                
            }
        }

        private void btnCapNhatKhach_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) return;

            int maHD = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["MaHoaDon"].Value);
            string tenMoi = txtSuaTenKH.Text.Trim();
            string sdtMoi = txtSuaSDT.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenMoi) || string.IsNullOrWhiteSpace(sdtMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên và SĐT.");
                return;
            }

            hoaDonBLL.UpdateThongTinKhachHang(maHD, tenMoi, sdtMoi);
            MessageBox.Show("Cập nhật thông tin khách hàng thành công!");

            LoadDanhSachHoaDon();
        }
    }
}
