using DA_1BanTuiSach.DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.BLL
{
    public class KhuyenMaiBLL
    {
        private List<KhuyenMai> ds = new List<KhuyenMai>();
        public List<KhuyenMai> GetAll() => ds;
        //public KhuyenMai GetById(int id) => ds.FirstOrDefault(x => x.MaKhuyenMai == id);
    }
}
