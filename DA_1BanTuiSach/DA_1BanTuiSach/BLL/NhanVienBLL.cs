using DA_1BanTuiSach.DTO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.BLL
{
    public class NhanVienBLL
    {
        public NhanVien DangNhap(string tk, string mk)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM NhanVien WHERE taiKhoan = @tk AND matKhau = @mk", conn);
                cmd.Parameters.AddWithValue("@tk", tk);
                cmd.Parameters.AddWithValue("@mk", mk);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new NhanVien
                    {
                        MaNhanVien = (int)reader["maNhanVien"],
                        TenNhanVien = reader["tenNhanVien"].ToString(),
                        TaiKhoan = reader["taiKhoan"].ToString(),
                        MatKhau = reader["matKhau"].ToString()
                    };
                }
            }
            return null;
        }
    }
}
