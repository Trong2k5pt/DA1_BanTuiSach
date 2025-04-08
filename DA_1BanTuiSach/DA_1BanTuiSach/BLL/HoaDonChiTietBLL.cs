using DA_1BanTuiSach.DTO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.BLL
{
    public class HoaDonChiTietBLL
    {
        public HoaDonChiTiet GetByHoaDonAndCT(int maHoaDon, int maSanPhamChiTiet)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(@"SELECT TOP 1 * FROM HoaDonChiTiet 
                                   WHERE maHoaDon = @maHD AND maSanPhamChiTiet = @maSPCT", conn);
                cmd.Parameters.AddWithValue("@maHD", maHoaDon);
                cmd.Parameters.AddWithValue("@maSPCT", maSanPhamChiTiet);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new HoaDonChiTiet
                    {
                        MaHoaDonChiTiet = (int)reader["maHoaDonChiTiet"],
                        TenSanPham = reader["tenSanPham"].ToString(),
                        SoLuongSanPham = (int)reader["soLuongSanPham"],
                        Gia = (decimal)reader["gia"],
                        TrangThai = (bool)reader["trangThai"],
                        MaHoaDon = (int)reader["maHoaDon"],
                        MaSanPhamChiTiet = (int)reader["maSanPhamChiTiet"]
                    };
                }
            }
            return null;
        }
        public void Update(HoaDonChiTiet ct)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(@"UPDATE HoaDonChiTiet 
                                   SET soLuongSanPham = @sl, gia = @gia, tenSanPham = @tenSP, trangThai = @tt
                                   WHERE maHoaDonChiTiet = @maHDCT", conn);

                cmd.Parameters.AddWithValue("@sl", ct.SoLuongSanPham);
                cmd.Parameters.AddWithValue("@gia", ct.Gia);
                cmd.Parameters.AddWithValue("@tenSP", ct.TenSanPham);
                cmd.Parameters.AddWithValue("@tt", ct.TrangThai);
                cmd.Parameters.AddWithValue("@maHDCT", ct.MaHoaDonChiTiet);

                cmd.ExecuteNonQuery();
            }
        }

        public List<HoaDonChiTiet> GetAllHoaDonCTByMaHoaDon(int maHD)
        {
            var list = new List<HoaDonChiTiet>();
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM HoaDonChiTiet WHERE maHoaDon = @ma", conn);
                cmd.Parameters.AddWithValue("@ma", maHD);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new HoaDonChiTiet
                    {
                        MaHoaDonChiTiet = (int)reader["maHoaDonChiTiet"],
                        TenSanPham = reader["tenSanPham"].ToString(),
                        SoLuongSanPham = (int)reader["soLuongSanPham"],
                        Gia = (decimal)reader["gia"],
                        TrangThai = (bool)reader["trangThai"],
                        MaHoaDon = (int)reader["maHoaDon"],
                        MaSanPhamChiTiet = (int)reader["maSanPhamChiTiet"]
                    });
                }
            }
            return list;
        }

        public void Insert(HoaDonChiTiet ct)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(@"INSERT INTO HoaDonChiTiet (tenSanPham, soLuongSanPham, gia, trangThai, maHoaDon, maSanPhamChiTiet)
                VALUES (@tenSP, @sl, @gia, 1, @maHD, @maCT)", conn);

                cmd.Parameters.AddWithValue("@tenSP", ct.TenSanPham);
                cmd.Parameters.AddWithValue("@sl", ct.SoLuongSanPham);
                cmd.Parameters.AddWithValue("@gia", ct.Gia);
                cmd.Parameters.AddWithValue("@maHD", ct.MaHoaDon);
                cmd.Parameters.AddWithValue("@maCT", ct.MaSanPhamChiTiet);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
