using DA_1BanTuiSach.BLL;
using DA_1BanTuiSach.DTO.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

public class SanPhamChiTietBLL
{
    public List<SanPhamChiTietView> GetAllSanPhamChiTiets()
    {
        var list = new List<SanPhamChiTietView>();
        using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand(@"SELECT  
                                spct.maSanPhamChiTiet,
                                spct.maSanPham,
                                spct.tenSanPhamChiTiet,
                                spct.giaSanPham,
                                spct.soLuong,
                                spct.trangThai,
                                sp.size,
                                sp.chatLieu,
                                sp.kieuDang,
                                ms.tenMau
                            FROM SanPhamChiTiet spct
                            INNER JOIN SanPham sp ON spct.maSanPham = sp.maSanPham
                            INNER JOIN MauSac ms ON spct.maMauSac = ms.maMauSac", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new SanPhamChiTietView
                {
                    MaSanPhamChiTiet = (int)reader["maSanPhamChiTiet"],
                    MaSanPham = (int)reader["maSanPham"],                         // ✅ Thêm dòng này
                    TenSanPhamChiTiet = reader["tenSanPhamChiTiet"].ToString(),
                    GiaSanPham = (decimal)reader["giaSanPham"],
                    SoLuong = (int)reader["soLuong"],
                    TrangThai = (bool)reader["trangThai"],
                    Size = reader["size"].ToString(),
                    ChatLieu = reader["chatLieu"].ToString(),
                    KieuDang = reader["kieuDang"].ToString(),
                    TenMau = reader["tenMau"].ToString()
                });
            }
        }
        return list;
    }

    public SanPhamChiTietView GetSanPhamChiTietById(int id)
    {
        using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand(@"SELECT  
                                spct.maSanPhamChiTiet,
                                spct.maSanPham,
                                spct.tenSanPhamChiTiet,
                                spct.giaSanPham,
                                spct.soLuong,
                                spct.trangThai,
                                sp.size,
                                sp.chatLieu,
                                sp.kieuDang,
                                ms.tenMau
                            FROM SanPhamChiTiet spct
                            INNER JOIN SanPham sp ON spct.maSanPham = sp.maSanPham
                            INNER JOIN MauSac ms ON spct.maMauSac = ms.maMauSac
                            WHERE spct.maSanPhamChiTiet = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new SanPhamChiTietView
                {
                    MaSanPhamChiTiet = (int)reader["maSanPhamChiTiet"],
                    MaSanPham = (int)reader["maSanPham"],                         // ✅ Thêm dòng này
                    TenSanPhamChiTiet = reader["tenSanPhamChiTiet"].ToString(),
                    GiaSanPham = (decimal)reader["giaSanPham"],
                    SoLuong = (int)reader["soLuong"],
                    TrangThai = (bool)reader["trangThai"],
                    Size = reader["size"].ToString(),
                    ChatLieu = reader["chatLieu"].ToString(),
                    KieuDang = reader["kieuDang"].ToString(),
                    TenMau = reader["tenMau"].ToString()
                };
            }
            return null;
        }
    }

    public void Update(SanPhamChiTiet spct)
    {
        using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand("UPDATE SanPhamChiTiet SET soLuong = @sl WHERE maSanPhamChiTiet = @id", conn);
            cmd.Parameters.AddWithValue("@sl", spct.SoLuong);
            cmd.Parameters.AddWithValue("@id", spct.MaSanPhamChiTiet);
            cmd.ExecuteNonQuery();
        }
    }
}
