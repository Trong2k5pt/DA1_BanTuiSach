using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_1BanTuiSach
{
    public partial class KhuyenMai : Form
    {
        private SqlConnection connection;
        public KhuyenMai()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-SEL9RHK;Initial Catalog=QL02;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            connection = new SqlConnection(connectionString);

            dgvKhuyenMai.CellClick += new DataGridViewCellEventHandler(dgvKhuyenMai_CellContentClick);

            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM KhuyenMai"; // Thay đổi tên bảng nếu cần  
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvKhuyenMai.DataSource = dataTable;

                MessageBox.Show("Tải dữ liệu thành công! Số bản ghi: " + dataTable.Rows.Count); // Thêm thông báo  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE KhuyenMai SET tenKhuyenMai = @tenKhuyenMai, ngayBatDau = @ngayBatDau, ngayKetThuc = @ngayKetThuc, sanPhamGiamGia = @sanPhamGiamGia, mucGiamGia = @mucGiamGia, trangThai = @trangThai WHERE maKhuyenMai = @maKhuyenMai";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Gán giá trị vào các tham số
                command.Parameters.AddWithValue("@maKhuyenMai", txtmaKhuyenMai.Text); // Mã khuyến mãi làm điều kiện sửa
                command.Parameters.AddWithValue("@tenKhuyenMai", txtTenTruongTrinh.Text);
                command.Parameters.AddWithValue("@ngayBatDau", dtpBatDau.Value);
                command.Parameters.AddWithValue("@ngayKetThuc", dtpKetThuc.Value);
                command.Parameters.AddWithValue("@sanPhamGiamGia", txtsanPhamGiamGia.Text);
                command.Parameters.AddWithValue("@mucGiamGia", decimal.Parse(txtMucGiamGia.Text)); // Chuyển đổi sang decimal
                command.Parameters.AddWithValue("@trangThai", rdbtDangHoatDong.Checked ? 1 : 0);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Thực hiện câu lệnh SQL
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật khuyến mãi thành công!");
                        LoadData(); // Tải lại dữ liệu sau khi sửa
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã khuyến mãi để sửa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa khuyến mãi: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Đóng kết nối
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM KhuyenMai WHERE maKhuyenMai = @maKhuyenMai";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Gán giá trị cho tham số maKhuyenMai
                command.Parameters.AddWithValue("@maKhuyenMai", txtmaKhuyenMai.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Thực hiện câu lệnh DELETE
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa khuyến mãi thành công!");
                        LoadData(); // Tải lại dữ liệu sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã khuyến mãi để xóa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khuyến mãi: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Đóng kết nối
                }
            }

        }

		private void dgvKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhuyenMai.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ dòng được chọn lên các điều khiển
                txtmaKhuyenMai.Text = row.Cells["maKhuyenMai"].Value.ToString();
                txtTenTruongTrinh.Text = row.Cells["tenKhuyenMai"].Value.ToString();
                dtpBatDau.Value = DateTime.Parse(row.Cells["ngayBatDau"].Value.ToString());
                dtpKetThuc.Value = DateTime.Parse(row.Cells["ngayKetThuc"].Value.ToString());
                txtsanPhamGiamGia.Text = row.Cells["sanPhamGiamGia"].Value.ToString();
                txtMucGiamGia.Text = row.Cells["mucGiamGia"].Value.ToString();

                // Xử lý trạng thái (RadioButton)
                string trangThai = row.Cells["trangThai"].Value.ToString();
                if (trangThai == "1") // Đang Hoạt Động
                {
                    rdbtDangHoatDong.Checked = true;
                }
                else // Ngừng Hoạt Động
                {
                    rdbtNgungHoatDong.Checked = true;
                }
            }


        }

        private void btnThem_Click_1(object sender, EventArgs e)
		{
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtsanPhamGiamGia.Text) ||
                string.IsNullOrWhiteSpace(txtTenTruongTrinh.Text) ||
                string.IsNullOrWhiteSpace(txtMucGiamGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!\nVui lòng điền Sản Phẩm Giảm Giá, Tên Chương Trình và Mức Giảm Giá.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng xử lý nếu thông tin không hợp lệ
            }

            // Nếu thông tin hợp lệ, tiếp tục thêm
            string query = "INSERT INTO KhuyenMai (tenKhuyenMai, ngayBatDau, ngayKetThuc, sanPhamGiamGia, mucGiamGia, trangThai) " +
                           "VALUES (@tenKhuyenMai, @ngayBatDau, @ngayKetThuc, @sanPhamGiamGia, @mucGiamGia, @trangThai)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@tenKhuyenMai", txtTenTruongTrinh.Text);
                command.Parameters.AddWithValue("@ngayBatDau", dtpBatDau.Value);
                command.Parameters.AddWithValue("@ngayKetThuc", dtpKetThuc.Value);
                command.Parameters.AddWithValue("@sanPhamGiamGia", txtsanPhamGiamGia.Text);
                command.Parameters.AddWithValue("@mucGiamGia", decimal.Parse(txtMucGiamGia.Text)); // Chuyển đổi sang decimal
                command.Parameters.AddWithValue("@trangThai", rdbtDangHoatDong.Checked ? 1 : 0);

                try
                {
                    connection.Open();
                    var result = command.ExecuteNonQuery(); // Thực thi câu lệnh SQL
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Cập nhật lại DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không có bản ghi nào được thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm khuyến mãi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text; // Lấy giá trị từ ô tìm kiếm

            // Tạo câu lệnh SQL với điều kiện tìm kiếm
            string query = "SELECT * FROM KhuyenMai WHERE " +
                           "maKhuyenMai LIKE @keyword OR " +
                           "tenKhuyenMai LIKE @keyword OR " +
                           "sanPhamGiamGia LIKE @keyword OR " +
                           "mucGiamGia LIKE @keyword OR " +
                           "trangThai LIKE @keyword";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvKhuyenMai.DataSource = dataTable; // Hiển thị kết quả lên DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
