using DA_1BanTuiSach.DTO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.BLL
{
    public class SanPhamBLL
    {
        public List<SanPham> GetAllSanPhams()
        {
            var list = new List<SanPham>();
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM SanPham", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SanPham
                    {
                        MaSanPham = (int)reader["maSanPham"],
                        TenSanPham = reader["tenSanPham"].ToString(),
                        Size = reader["size"].ToString(),
                        ChatLieu = reader["chatLieu"].ToString(),
                        KieuDang = reader["kieuDang"].ToString()
                    });
                }
            }
            return list;
        }

        public SanPham GetSanPhamById(int id) => GetAllSanPhams().FirstOrDefault(x => x.MaSanPham == id);
    }
}
