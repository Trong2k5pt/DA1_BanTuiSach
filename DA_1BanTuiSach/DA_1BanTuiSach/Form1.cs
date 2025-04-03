using System;
using DA_1BanTuiSach.DTO.Model;
using DA_1BanTuiSach.BLL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DA_1BanTuiSach
{
    public partial class Form1 : Form
    {
        private KhachHangBLL khachHangBLL = new KhachHangBLL();
        private HoaDonBLL hoaDonBLL = new HoaDonBLL();
        private HoaDonChiTietBLL hoaDonChiTietBLL = new HoaDonChiTietBLL();
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamChiTietBLL sanPhamChiTietBLL = new SanPhamChiTietBLL();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            button2.Click += BtnTimKiemKH_Click;
            button1.Click += BtnTaoHoaDon_Click;
            comboBox1.SelectedIndexChanged += ComboBoxHoaDon_SelectedIndexChanged;
            button3.Click += BtnThanhToan_Click;
            button4.Click += BtnHuyHoaDon_Click;
            textBox5.TextChanged += TxtTimKiemSP_TextChanged;
            dataGridView2.CellDoubleClick += DataGridView2_CellDoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "MaHoaDon";
            comboBox1.ValueMember = "MaHoaDon";
            LoadData_cbbHoaDonCho();
            LoadData_dgvSanPhamChiTiet(sanPhamChiTietBLL.GetAllSanPhamChiTiets());
        }

        private void BtnTimKiemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng.");
                return;
            }

            var khachHang = khachHangBLL.GetKhachHangBySDT(textBox3.Text.Trim());

            if (khachHang != null)
            {
                textBox1.Text = khachHang.SoDienThoai;
                textBox2.Text = khachHang.TenKhachHang;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng. Vui lòng kiểm tra lại.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }


        private void BtnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng trước.");
                return;
            }

            HoaDon hoaDon = new HoaDon
            {
                TenKhachHang = textBox2.Text,
                SoDienThoai = textBox1.Text,
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
            comboBox1.SelectedValue = maHDMoi;
        }


        private void ComboBoxHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hoaDon = comboBox1.SelectedItem as HoaDon;
            if (hoaDon != null)
            {
                textBox1.Text = hoaDon.SoDienThoai;
                textBox2.Text = hoaDon.TenKhachHang;
                LoadData_dgvHoaDonChiTiet(hoaDon.MaHoaDon);
                label7.Text = TinhTongTienHoaDon(hoaDon.MaHoaDon).ToString("N0") + " VND";
            }
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            var hoaDon = comboBox1.SelectedItem as HoaDon;
            if (hoaDon == null) return;

            decimal tongTien = TinhTongTienHoaDon(hoaDon.MaHoaDon);
            if (!decimal.TryParse(textBox4.Text, out decimal tienKhachDua) || tienKhachDua < tongTien)
            {
                MessageBox.Show("Tiền khách đưa không hợp lệ hoặc không đủ.");
                return;
            }

            decimal tienThua = tienKhachDua - tongTien;
            label10.Text = tienThua.ToString("N0") + " VND";

            hoaDon.TrangThai = true;
            hoaDon.TongTien = tongTien;
            hoaDon.PhuongThucThanhToan = "Tiền mặt";
            hoaDonBLL.UpdateTrangThai(hoaDon.MaHoaDon, true);

            MessageBox.Show("Thanh toán thành công!");
            ClearFormAfterPayment();

            // Load lại hóa đơn chờ vào combobox
            LoadData_cbbHoaDonCho();
            dataGridView1.DataSource = null;
        }
        private void ClearFormAfterPayment()
        {
            // Clear TextBoxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            // Clear Labels
            label7.Text = "0 VND";
            label10.Text = "0 VND";

            // Clear DataGridView giỏ hàng
            dataGridView1.DataSource = null;

            // Reset ComboBox hóa đơn đang chọn
            comboBox1.SelectedItem = null;
        }
        private void LoadData_dgvHoaDonChiTiet(int maHoaDon)
        {
            var list = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            dataGridView1.DataSource = list.Select(hdct => new
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
            var hoaDon = comboBox1.SelectedItem as HoaDon;
            if (hoaDon == null) return;

            var listHDCT = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(hoaDon.MaHoaDon);

            foreach (var hdct in listHDCT)
            {
                // Lấy thông tin sản phẩm chi tiết bằng SanPhamChiTietBLL (không phải SanPhamChiTietView)
                var spctView = sanPhamChiTietBLL.GetSanPhamChiTietById(hdct.MaSanPhamChiTiet);

                if (spctView != null)
                {
                    // Tạo đối tượng SanPhamChiTiet để update số lượng trong DB
                    var spctToUpdate = new SanPhamChiTiet
                    {
                        MaSanPhamChiTiet = spctView.MaSanPhamChiTiet,
                        SoLuong = spctView.SoLuong + hdct.SoLuongSanPham // Cộng lại số lượng khi hủy
                    };

                    // Update lại kho
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
            var listSPTimKiem = sanPhamBLL.GetAllSanPhams()
                .Where(sp => sp.TenSanPham.ToLower().Contains(textBox5.Text.ToLower())).ToList();

            var listSPCT = sanPhamChiTietBLL.GetAllSanPhamChiTiets()
                .Where(spct => listSPTimKiem.Any(sp => sp.MaSanPham == spct.MaSanPham)).ToList();

            LoadData_dgvSanPhamChiTiet(listSPCT);
        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.SelectedItem is HoaDon hoaDon && e.RowIndex >= 0)
            {
                var spct = (SanPhamChiTiet)dataGridView2.Rows[e.RowIndex].DataBoundItem;
                int soLuong = 1;

                if (spct.SoLuong < soLuong)
                {
                    MessageBox.Show("Không đủ hàng tồn kho");
                    return;
                }

                var hdct = hoaDonChiTietBLL.GetByHoaDonAndCT(hoaDon.MaHoaDon, spct.MaSanPhamChiTiet);

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
                        MaSanPhamChiTiet = spct.MaSanPhamChiTiet,
                        TenSanPham = spct.TenSanPhamChiTiet,
                        Gia = spct.GiaSanPham,
                        SoLuongSanPham = soLuong,
                        TrangThai = true
                    });
                }

                spct.SoLuong -= soLuong;
                sanPhamChiTietBLL.Update(spct);
                LoadData_dgvHoaDonChiTiet(hoaDon.MaHoaDon);
                LoadData_dgvSanPhamChiTiet(sanPhamChiTietBLL.GetAllSanPhamChiTiets());
            }
        }

        private void LoadData_cbbHoaDonCho()
        {
            var list = hoaDonBLL.GetAllHoaDonChos();
            comboBox1.DataSource = null;
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "MaHoaDonHienThi";
            comboBox1.ValueMember = "MaHoaDon";
        }



        private void LoadData_dgvSanPhamChiTiet(List<SanPhamChiTietView> list)
        {
            dataGridView2.DataSource = list.Select(x => new
            {
                x.MaSanPhamChiTiet,
                x.TenSanPhamChiTiet,
                MauSac = x.TenMau,
                x.Size,
                ChatLieu = x.ChatLieu,
                KieuDang = x.KieuDang,
                Gia = x.GiaSanPham,
                SoLuongTon = x.SoLuong,
                TrangThai = x.TrangThai ? "Còn hàng" : "Hết hàng"
            }).ToList();
        }


        private void LoadData_dgvSanPhamChiTiet(List<SanPhamChiTiet> list)
        {
            dataGridView2.DataSource = list;
        }

        private decimal TinhTongTienHoaDon(int maHoaDon)
        {
            var list = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            return list.Sum(x => x.SoLuongSanPham * x.Gia);
        }
    }
}
