using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.DTO.Model
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public string MaHoaDonHienThi { get; set; } // Thêm vào để hiển thị
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public decimal TongTienTamTinh { get; set; }
        public decimal TongTien { get; set; }
        public bool TrangThai { get; set; }
        public int MaKhachHang { get; set; }
        public int MaNhanVien { get; set; }
    }

}
