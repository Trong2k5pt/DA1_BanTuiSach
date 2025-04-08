using DA_1BanTuiSach.DTO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1BanTuiSach.BLL
{
    public class HoaDonBLL
    {
        public int TaoHoaDonCho(HoaDon hd)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                // Insert hóa đơn mới và lấy mã vừa tạo
                var cmd = new SqlCommand(@"
            INSERT INTO HoaDon (tenKhachHang, soDienThoai, ngayLapHoaDon, phuongThucThanhToan, tongTienTamTinh, tongTien, trangThai, maKhuyenMai, maKhachHang, maNhanVien)
            VALUES (@tenKH, @sdt, @ngay, '', 0, 0, 0, NULL, @maKH, @maNV);
            SELECT SCOPE_IDENTITY();", conn);

                cmd.Parameters.AddWithValue("@tenKH", hd.TenKhachHang);
                cmd.Parameters.AddWithValue("@sdt", hd.SoDienThoai);
                cmd.Parameters.AddWithValue("@ngay", hd.NgayLapHoaDon);
                cmd.Parameters.AddWithValue("@maKH", hd.MaKhachHang);
                cmd.Parameters.AddWithValue("@maNV", hd.MaNhanVien);

                int newId = Convert.ToInt32(cmd.ExecuteScalar());

                // Update maHoaDonHienThi với format HD + số thứ tự
                string maHDHienThi = "HD" + newId.ToString("D5"); // VD: HD00001

                var updateCmd = new SqlCommand("UPDATE HoaDon SET maHoaDonHienThi = @maHDHT WHERE maHoaDon = @maHD", conn);
                updateCmd.Parameters.AddWithValue("@maHDHT", maHDHienThi);
                updateCmd.Parameters.AddWithValue("@maHD", newId);
                updateCmd.ExecuteNonQuery();

                return newId;
            }
        }


        public List<HoaDon> GetAllHoaDonChos()
        {
            var list = new List<HoaDon>();
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM HoaDon WHERE trangThai = 0", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new HoaDon
                    {
                        MaHoaDon = (int)reader["maHoaDon"],
                        MaHoaDonHienThi = reader["maHoaDonHienThi"].ToString(),
                        TenKhachHang = reader["tenKhachHang"].ToString(),
                        SoDienThoai = reader["soDienThoai"].ToString(),
                        NgayLapHoaDon = (DateTime)reader["ngayLapHoaDon"],
                        MaKhachHang = (int)reader["maKhachHang"],
                        MaNhanVien = (int)reader["maNhanVien"],
                    });
                }
            }
            return list;
        }

        public List<HoaDon> GetAllHoaDonDaThanhToan()
        {
            var list = new List<HoaDon>();
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM HoaDon WHERE trangThai = 1", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new HoaDon
                    {
                        MaHoaDon = (int)reader["maHoaDon"],
                        MaHoaDonHienThi = reader["maHoaDonHienThi"].ToString(),
                        TenKhachHang = reader["tenKhachHang"].ToString(),
                        SoDienThoai = reader["soDienThoai"].ToString(),
                        NgayLapHoaDon = (DateTime)reader["ngayLapHoaDon"],
                        TongTien = (decimal)reader["tongTien"],
                        MaKhachHang = (int)reader["maKhachHang"],
                        MaNhanVien = (int)reader["maNhanVien"],
                    });
                }
            }
            return list;
        }
        public void UpdateThongTinKhachHang(int maHoaDon, string tenKH, string soDT)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE HoaDon SET tenKhachHang = @ten, soDienThoai = @sdt WHERE maHoaDon = @ma", conn);
                cmd.Parameters.AddWithValue("@ten", tenKH);
                cmd.Parameters.AddWithValue("@sdt", soDT);
                cmd.Parameters.AddWithValue("@ma", maHoaDon);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTrangThai(int maHoaDon, bool trangThai)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE HoaDon SET trangThai = @tt WHERE maHoaDon = @id", conn);
                cmd.Parameters.AddWithValue("@tt", trangThai);
                cmd.Parameters.AddWithValue("@id", maHoaDon);
                cmd.ExecuteNonQuery();
            }
        }
    }

}
