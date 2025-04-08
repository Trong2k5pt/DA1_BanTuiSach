using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.DTO.Model
{
    public class SanPhamChiTietView
    {
        public int MaSanPhamChiTiet { get; set; }
        public int MaSanPham { get; set; }
        public string TenSanPhamChiTiet { get; set; }
        public decimal GiaSanPham { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
        public string Size { get; set; }
        public string ChatLieu { get; set; }
        public string KieuDang { get; set; }
        public string TenMau { get; set; }
    }
}
