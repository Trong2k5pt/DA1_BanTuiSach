using DA_1BanTuiSach.DTO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.BLL
{
    public class KhachHangBLL
    {
        public KhachHang GetKhachHangBySDT(string sdt)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM KhachHang WHERE soDienThoai = @sdt", conn);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new KhachHang
                    {
                        //MaKhachHang = (int)reader["maKhachHang"],
                        //TenKhachHang = reader["tenKhachHang"].ToString(),
                        //GioiTinh = (bool)reader["gioiTinh"],
                        //SoDienThoai = reader["soDienThoai"].ToString(),
                        //Email = reader["email"].ToString(),
                        //DiaChi = reader["diaChi"].ToString(),
                        //TrangThai = (bool)reader["trangThai"]
                    };
                }
            }
            return null;
        }
    }

}
