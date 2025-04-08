using DA_1BanTuiSach.DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.BLL
{
    public class MauSacBLL
    {
        private List<MauSac> ds = new List<MauSac>();
        public MauSac GetMauSacById(int id) => ds.FirstOrDefault(x => x.MaMauSac == id);
    }
}
