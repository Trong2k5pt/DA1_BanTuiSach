using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.DTO.Model
{
    public class KhuyenMai
    {
        public int MaKhuyenMai { get; set; }
        public string TenKhuyenMai { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal? MucGiamGiaToiDa { get; set; }
        public string LoaiGiamGia { get; set; }
        public string DieuKien { get; set; }
        public decimal MucGiamGia { get; set; }
        public bool TrangThai { get; set; }
    }
}
