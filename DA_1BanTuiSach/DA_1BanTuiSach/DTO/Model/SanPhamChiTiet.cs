using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.DTO.Model
{
    public class SanPhamChiTiet
    {
        public int MaSanPhamChiTiet { get; set; }
        public string TenSanPhamChiTiet { get; set; }
        public decimal GiaSanPham { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
        public int MaSanPham { get; set; }
        public int MaMauSac { get; set; }
    }
}
