using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.DTO.Model
{
    public class HoaDonChiTiet
    {
        public int MaHoaDonChiTiet { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuongSanPham { get; set; }
        public decimal Gia { get; set; }
        public bool TrangThai { get; set; }
        public int MaHoaDon { get; set; }
        public int MaSanPhamChiTiet { get; set; }
    }
}
