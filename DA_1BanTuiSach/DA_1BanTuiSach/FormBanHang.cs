using System;
using System.Drawing;
using System.Drawing.Printing;
using DA_1BanTuiSach.DTO.Model;
using DA_1BanTuiSach.BLL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DA_1BanTuiSach
{
    public partial class FormBanHang : Form
    {
        private KhachHangBLL khachHangBLL = new KhachHangBLL();
        private HoaDonBLL hoaDonBLL = new HoaDonBLL();
        private HoaDonChiTietBLL hoaDonChiTietBLL = new HoaDonChiTietBLL();
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamChiTietBLL sanPhamChiTietBLL = new SanPhamChiTietBLL();
        private PrintDocument printDocument = new PrintDocument();
        private HoaDon currentHoaDonToPrint;
        

        public FormBanHang()
        {
            InitializeComponent();
            Load += FormBanHang_Load;
            btnTimKH.Click += BtnTimKiemKH_Click;
            btnTaoHoaDon.Click += BtnTaoHoaDon_Click;
            cbbChonHoaDon.SelectedIndexChanged += ComboBoxHoaDon_SelectedIndexChanged;
            btnThanhToan.Click += BtnThanhToan_Click;
            btnHuy.Click += BtnHuyHoaDon_Click;
            txtTimSanPham.TextChanged += TxtTimKiemSP_TextChanged;
            dtgvSanPhamChiTiet.CellDoubleClick += DataGridView2_CellDoubleClick;
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            cbbChonHoaDon.DisplayMember = "MaHoaDon";
            cbbChonHoaDon.ValueMember = "MaHoaDon";
            LoadData_cbbHoaDonCho();
            LoadData_dgvSanPhamChiTiet(sanPhamChiTietBLL.GetAllSanPhamChiTiets());
            dtgvSanPhamChiTiet.AutoGenerateColumns = true;

        }

        private void BtnTimKiemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKH.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng.");
                return;
            }

            var khachHang = khachHangBLL.GetKhachHangBySDT(txtTimKH.Text.Trim());

            if (khachHang != null)
            {
                txtSoDienThoai.Text = khachHang.SoDienThoai;
                txtTenKH.Text = khachHang.TenKhachHang;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng. Vui lòng kiểm tra lại.");
                txtSoDienThoai.Clear();
                txtTenKH.Clear();
            }
        }


        private void BtnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng trước.");
                return;
            }

            HoaDon hoaDon = new HoaDon
            {
                TenKhachHang = txtTenKH.Text,
                SoDienThoai = txtSoDienThoai.Text,
                NgayLapHoaDon = DateTime.Now,
                PhuongThucThanhToan = "",
                TongTien = 0,
                TongTienTamTinh = 0,
                TrangThai = false,
                MaKhachHang = 1,
                MaNhanVien = 1
            };

            int maHDMoi = hoaDonBLL.TaoHoaDonCho(hoaDon);
            hoaDon.MaHoaDon = maHDMoi;

            MessageBox.Show($"Tạo hóa đơn {hoaDon.MaHoaDonHienThi} thành công!");

            LoadData_cbbHoaDonCho();
            cbbChonHoaDon.SelectedValue = maHDMoi;
        }


        private void ComboBoxHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hoaDon = cbbChonHoaDon.SelectedItem as HoaDon;
            if (hoaDon != null)
            {
                txtSoDienThoai.Text = hoaDon.SoDienThoai;
                txtTenKH.Text = hoaDon.TenKhachHang;
                LoadData_dgvHoaDonChiTiet(hoaDon.MaHoaDon);
                lblTongTien.Text = TinhTongTienHoaDon(hoaDon.MaHoaDon).ToString("N0") + " VND";
            }
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            var hoaDon = cbbChonHoaDon.SelectedItem as HoaDon;
            if (hoaDon == null) return;

            decimal tongTien = TinhTongTienHoaDon(hoaDon.MaHoaDon);
            if (!decimal.TryParse(txtTienKhachDua.Text, out decimal tienKhachDua) || tienKhachDua < tongTien)
            {
                MessageBox.Show("Tiền khách đưa không hợp lệ hoặc không đủ.");
                return;
            }

            decimal tienThua = tienKhachDua - tongTien;
            lblTienThua.Text = tienThua.ToString("N0") + " VND";

            hoaDon.TrangThai = true;
            hoaDon.TongTien = tongTien;
            hoaDon.PhuongThucThanhToan = "Tiền mặt";
            hoaDonBLL.UpdateTrangThai(hoaDon.MaHoaDon, true);
            InHoaDon(hoaDon);

            MessageBox.Show("Thanh toán thành công!");
            ClearFormAfterPayment();

            // Load lại hóa đơn chờ vào combobox
            LoadData_cbbHoaDonCho();
            dtgvHoaDon.DataSource = null;
        }
        private void ClearFormAfterPayment()
        {
            // Clear TextBoxes
            txtSoDienThoai.Clear();
            txtTenKH.Clear();
            txtTimKH.Clear();
            txtTienKhachDua.Clear();
            txtTimSanPham.Clear();

            // Clear Labels
            lblTongTien.Text = "0 VND";
            lblTienThua.Text = "0 VND";

            // Clear DataGridView giỏ hàng
            dtgvHoaDon.DataSource = null;

            // Reset ComboBox hóa đơn đang chọn
            cbbChonHoaDon.SelectedItem = null;
        }
        private void LoadData_dgvHoaDonChiTiet(int maHoaDon)
        {
            var list = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            dtgvHoaDon.DataSource = list.Select(hdct => new
            {
                hdct.MaHoaDonChiTiet,   // Mã hóa đơn chi tiết
                hdct.MaHoaDon,          // Mã hóa đơn
                hdct.MaSanPhamChiTiet,
                hdct.TenSanPham,
                hdct.Gia,
                hdct.SoLuongSanPham,
                ThanhTien = hdct.Gia * hdct.SoLuongSanPham,
                MauSac = sanPhamChiTietBLL.GetSanPhamChiTietById(hdct.MaSanPhamChiTiet).TenMau,
                Size = sanPhamChiTietBLL.GetSanPhamChiTietById(hdct.MaSanPhamChiTiet).Size,
                ChatLieu = sanPhamChiTietBLL.GetSanPhamChiTietById(hdct.MaSanPhamChiTiet).ChatLieu,
                KieuDang = sanPhamChiTietBLL.GetSanPhamChiTietById(hdct.MaSanPhamChiTiet).KieuDang
            }).ToList();
        }



        private void BtnHuyHoaDon_Click(object sender, EventArgs e)
        {
            var hoaDon = cbbChonHoaDon.SelectedItem as HoaDon;
            if (hoaDon == null) return;

            var listHDCT = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(hoaDon.MaHoaDon);

            foreach (var hdct in listHDCT)
            {
                
                var spctView = sanPhamChiTietBLL.GetSanPhamChiTietById(hdct.MaSanPhamChiTiet);

                if (spctView != null)
                {
                    
                    var spctToUpdate = new SanPhamChiTiet
                    {
                        MaSanPhamChiTiet = spctView.MaSanPhamChiTiet,
                        SoLuong = spctView.SoLuong + hdct.SoLuongSanPham 
                    };

                    
                    sanPhamChiTietBLL.Update(spctToUpdate);
                }
            }

            hoaDonBLL.UpdateTrangThai(hoaDon.MaHoaDon, true);
            MessageBox.Show("Hóa đơn đã được hủy và sản phẩm đã được hoàn lại kho.");
            ClearFormAfterPayment();
            LoadData_cbbHoaDonCho();
            LoadData_dgvSanPhamChiTiet(sanPhamChiTietBLL.GetAllSanPhamChiTiets());
        }


        private void TxtTimKiemSP_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimSanPham.Text.ToLower();

            var list = sanPhamChiTietBLL.GetAllSanPhamChiTiets()
                .Where(spct =>
                    spct.TenSanPhamChiTiet.ToLower().Contains(keyword) ||
                    spct.MaSanPhamChiTiet.ToString().Contains(keyword) ||
                    spct.TenMau.ToLower().Contains(keyword) ||
                    spct.Size.ToLower().Contains(keyword) ||
                    spct.ChatLieu.ToLower().Contains(keyword) ||
                    spct.KieuDang.ToLower().Contains(keyword)
                ).ToList();

            LoadData_dgvSanPhamChiTiet(list);
        }


        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbbChonHoaDon.SelectedItem is HoaDon hoaDon && e.RowIndex >= 0)
            {
                var spctView = (SanPhamChiTietView)dtgvSanPhamChiTiet.Rows[e.RowIndex].DataBoundItem;
                int soLuong = 1;

                if (spctView.SoLuong < soLuong)
                {
                    MessageBox.Show("Không đủ hàng tồn kho");
                    return;
                }

                var hdct = hoaDonChiTietBLL.GetByHoaDonAndCT(hoaDon.MaHoaDon, spctView.MaSanPhamChiTiet);

                if (hdct != null)
                {
                    hdct.SoLuongSanPham += soLuong;
                    hoaDonChiTietBLL.Update(hdct);
                }
                else
                {
                    hoaDonChiTietBLL.Insert(new HoaDonChiTiet
                    {
                        MaHoaDon = hoaDon.MaHoaDon,
                        MaSanPhamChiTiet = spctView.MaSanPhamChiTiet,
                        TenSanPham = spctView.TenSanPhamChiTiet,
                        Gia = spctView.GiaSanPham,
                        SoLuongSanPham = soLuong,
                        TrangThai = true
                    });
                }

                // Cập nhật tồn kho
                var spctUpdate = new SanPhamChiTiet
                {
                    MaSanPhamChiTiet = spctView.MaSanPhamChiTiet,
                    SoLuong = spctView.SoLuong - soLuong
                };
                sanPhamChiTietBLL.Update(spctUpdate);

                LoadData_dgvHoaDonChiTiet(hoaDon.MaHoaDon);
                LoadData_dgvSanPhamChiTiet(sanPhamChiTietBLL.GetAllSanPhamChiTiets());
            }
        }


        private void LoadData_cbbHoaDonCho()
        {
            var list = hoaDonBLL.GetAllHoaDonChos();
            cbbChonHoaDon.DataSource = null;
            cbbChonHoaDon.DataSource = list;
            cbbChonHoaDon.DisplayMember = "MaHoaDonHienThi";
            cbbChonHoaDon.ValueMember = "MaHoaDon";
        }



        private void InHoaDon(HoaDon hoaDon)
        {
            currentHoaDonToPrint = hoaDon;
            printDocument.PrintPage -= printDocument_PrintPage;
            printDocument.PrintPage += printDocument_PrintPage;


            using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
            {
                previewDialog.Document = printDocument;
                previewDialog.Width = 800;
                previewDialog.Height = 600;
                previewDialog.ShowDialog();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            int pageWidth = e.PageBounds.Width;
            int x = 10;
            int y = 20;

            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 11);
            Font thanksFont = new Font("Arial", 11, FontStyle.Bold);

            StringFormat centerAlign = new StringFormat();
            centerAlign.Alignment = StringAlignment.Center;

            // ===== Header =====
            g.DrawString("SHOP TÚI XÁCH 4T-TS", titleFont, Brushes.Black, pageWidth / 2, y, centerAlign); y += 30;
            g.DrawString("Đ/c: 123 Trịnh Văn Bô, Hà Nội", regularFont, Brushes.Black, pageWidth / 2, y, centerAlign); y += 20;
            g.DrawString("Hotline: 0988 123 456", regularFont, Brushes.Black, pageWidth / 2, y, centerAlign); y += 30;

            g.DrawString("HÓA ĐƠN BÁN HÀNG", headerFont, Brushes.Black, pageWidth / 2, y, centerAlign); y += 30;

            g.DrawString($"Mã HĐ : {currentHoaDonToPrint.MaHoaDonHienThi}", regularFont, Brushes.Black, x, y); y += 20;
            g.DrawString($"Ngày  : {DateTime.Now:dd/MM/yyyy HH:mm}", regularFont, Brushes.Black, x, y); y += 20;
            g.DrawString($"Khách : {currentHoaDonToPrint.TenKhachHang}", regularFont, Brushes.Black, x, y); y += 20;
            g.DrawString($"SĐT   : {currentHoaDonToPrint.SoDienThoai}", regularFont, Brushes.Black, x, y); y += 25;

            g.DrawLine(Pens.Black, x, y, pageWidth - x, y); y += 10;

            // ===== Bảng sản phẩm =====
            int colTenSP = x;
            int colSL = colTenSP + 200;
            int colDG = colSL + 40;
            int colTT = colDG + 70;

            g.DrawString("Tên SP", headerFont, Brushes.Black, colTenSP, y);
            g.DrawString("SL", headerFont, Brushes.Black, colSL, y);
            g.DrawString("ĐG", headerFont, Brushes.Black, colDG, y);
            g.DrawString("TT", headerFont, Brushes.Black, colTT, y);
            y += 25;

            var list = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(currentHoaDonToPrint.MaHoaDon);
            foreach (var item in list)
            {
                // Xử lý xuống dòng nếu tên dài
                string tenSP = item.TenSanPham;
                SizeF textSize = g.MeasureString(tenSP, regularFont);
                float textHeight = textSize.Height;
                int heightPerLine = (int)textHeight + 2;

                // Vẽ tên sản phẩm trong ô rộng 190px
                RectangleF rectTenSP = new RectangleF(colTenSP, y, 190, heightPerLine * 2);
                g.DrawString(tenSP, regularFont, Brushes.Black, rectTenSP);

                g.DrawString(item.SoLuongSanPham.ToString(), regularFont, Brushes.Black, colSL, y);
                g.DrawString(item.Gia.ToString("N0"), regularFont, Brushes.Black, colDG, y);
                g.DrawString((item.Gia * item.SoLuongSanPham).ToString("N0"), regularFont, Brushes.Black, colTT, y);

                y += heightPerLine * 2;
            }

            g.DrawLine(Pens.Black, x, y, pageWidth - x, y); y += 10;

            decimal tongTien = currentHoaDonToPrint.TongTien;
            g.DrawString("Tổng tiền:", headerFont, Brushes.Black, x, y);
            g.DrawString($"{tongTien:N0} VND", headerFont, Brushes.Black, colDG, y);
            y += 30;

            g.DrawString("CẢM ƠN VÀ HẸN GẶP LẠI QUÝ KHÁCH!", thanksFont, Brushes.Black, pageWidth / 2, y, centerAlign);
        }




        private void LoadData_dgvSanPhamChiTiet(List<SanPhamChiTietView> list)
        {
            dtgvSanPhamChiTiet.DataSource = list;
        }

        private decimal TinhTongTienHoaDon(int maHoaDon)
        {
            var list = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            return list.Sum(x => x.SoLuongSanPham * x.Gia);
        }

       
    }
}
