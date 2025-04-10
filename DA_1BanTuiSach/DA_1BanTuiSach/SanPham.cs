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
    public partial class SanPham : Form
    {
        private SqlConnection connection;

        public SanPham()
        {
			InitializeComponent();
			string connectionString = "Data Source=ANH2005\\SQLEXPRESS;Initial Catalog=QL02;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
			connection = new SqlConnection(connectionString);
			dgvSanPham.CellClick += dgvSanPham_CellContentClick;
			txtTimKiemSanPham.TextChanged += txtTimKiemSanPham_TextChanged;
			txtTimKiemSanPhamChiTiet.TextChanged += txtTimKiemSanPhamChiTiet_TextChanged;
			dgvSanPhamChiTiet.CellClick += dgvSanPhamChiTiet_CellContentClick; // Sự kiện cho dgv sản phẩm chi tiết  
			LoadMauSacComboBox();  // Load màu sắc vào combo box  
			LoadSanPhamChiTietData(); // Load dữ liệu sản phẩm chi tiết  
			LoadSanPhamComboBox();
		}
		private void LoadData()
		{
			connection.Open();
			string query = "SELECT * FROM SanPham";
			SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
			DataTable table = new DataTable();
			adapter.Fill(table);
			dgvSanPham.DataSource = table;
			connection.Close();
		}

		private void SanPham_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			string maSanPham = txtMaSanPham.Text;
			string tenSanPham = txtTenSanPham.Text;
			string kieuDang = txtKieuDang.Text;
			string size = txtSize.Text;
			string chatLieu = txtChatLieu.Text;

			connection.Open();
			string query = "INSERT INTO SanPham ( tenSanPham, kieuDang, size, chatLieu) VALUES ( @tenSanPham, @kieuDang, @size, @chatLieu)";
			SqlCommand command = new SqlCommand(query, connection);
			
			command.Parameters.AddWithValue("@tenSanPham", tenSanPham);
			command.Parameters.AddWithValue("@kieuDang", kieuDang);
			command.Parameters.AddWithValue("@size", size);
			command.Parameters.AddWithValue("@chatLieu", chatLieu);
			command.ExecuteNonQuery();
			connection.Close();

			LoadData();
			ClearFields();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string maSanPham = txtMaSanPham.Text;
			string tenSanPham = txtTenSanPham.Text;
			string kieuDang = txtKieuDang.Text;
			string size = txtSize.Text;
			string chatLieu = txtChatLieu.Text;

			connection.Open();
			string query = "UPDATE SanPham SET tenSanPham = @tenSanPham, kieuDang = @kieuDang, size = @size, chatLieu = @chatLieu WHERE maSanPham = @maSanPham";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@maSanPham", maSanPham);
			command.Parameters.AddWithValue("@tenSanPham", tenSanPham);
			command.Parameters.AddWithValue("@kieuDang", kieuDang);
			command.Parameters.AddWithValue("@size", size);
			command.Parameters.AddWithValue("@chatLieu", chatLieu);
			command.ExecuteNonQuery();
			connection.Close();

			LoadData();
			ClearFields();
		}
		private void ClearFields()
		{
			txtMaSanPham.Clear();
			txtTenSanPham.Clear();
			txtKieuDang.Clear();
			txtSize.Clear();
			txtChatLieu.Clear();
		}

		private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0) // Kiểm tra xem có dòng nào được chọn không  
				{
					DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
					txtMaSanPham.Text = row.Cells["maSanPham"].Value.ToString();
					txtTenSanPham.Text = row.Cells["tenSanPham"].Value.ToString();
					txtKieuDang.Text = row.Cells["kieuDang"].Value.ToString();
					txtSize.Text = row.Cells["size"].Value.ToString();
					txtChatLieu.Text = row.Cells["chatLieu"].Value.ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
			}
		}
		

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
			{
				MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
				return;
			}

			string maSanPham = txtMaSanPham.Text;

			connection.Open();
			string query = "DELETE FROM SanPham WHERE maSanPham = @maSanPham";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@maSanPham", maSanPham);
			command.ExecuteNonQuery();
			connection.Close();

			LoadData();
			ClearFields();
			MessageBox.Show("Sản phẩm đã được xóa thành công.");
		}

		

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		// san pham chi tiet
		private void LoadSanPhamChiTietData()
		{
			string query = "SELECT * FROM SanPhamChiTiet";
			SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
			DataTable table = new DataTable();
			adapter.Fill(table);
			dgvSanPhamChiTiet.DataSource = table; // Hiển thị dữ liệu lên DataGridView  
		}

		private void LoadMauSacComboBox()
		{
			string query = "SELECT maMauSac, tenMau FROM MauSac";
			SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			cbbMauSac.DataSource = dt;
			cbbMauSac.DisplayMember = "tenMau";
			cbbMauSac.ValueMember = "maMauSac";
		}
		private void LoadSanPhamComboBox()
		{
			string query = "SELECT maSanPham, tenSanPham FROM SanPham";
			SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			cbbMaSanPham.DataSource = dataTable; // Thay đổi tên nếu cần  
			cbbMaSanPham.DisplayMember = "maSanPham";
			cbbMaSanPham.ValueMember = "maSanPham";
		}

		private void btnThemSanPhamChiTiet_Click(object sender, EventArgs e)
		{
			string tenSanPhamChiTiet = txtTenSanPhamChiTiet.Text;
			decimal giaSanPham = decimal.Parse(txtGiaSanPham.Text);
			int soLuong = int.Parse(txtSoLuong.Text);
			int trangThai = rdbtConHang.Checked ? 1 : 0; // Cập nhật trạng thái  
			string maSanPham = cbbMaSanPham.SelectedValue.ToString();
			string maMauSac = cbbMauSac.SelectedValue.ToString();

			string query = "INSERT INTO SanPhamChiTiet (tenSanPhamChiTiet, giaSanPham, soLuong, trangThai, maSanPham, maMauSac) VALUES (@tenSanPhamChiTiet, @giaSanPham, @soLuong, @trangThai, @maSanPham, @maMauSac)";
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@tenSanPhamChiTiet", tenSanPhamChiTiet);
				command.Parameters.AddWithValue("@giaSanPham", giaSanPham);
				command.Parameters.AddWithValue("@soLuong", soLuong);
				command.Parameters.AddWithValue("@trangThai", trangThai); // Sửa ở đây  
				command.Parameters.AddWithValue("@maSanPham", maSanPham);
				command.Parameters.AddWithValue("@maMauSac", maMauSac);

				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}

			LoadSanPhamChiTietData();
			ClearChiTietFields(); // Xoá các trường nhập liệu của sản phẩm chi tiết 
		}

		private void btnSuaSanPhamChiTiet_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaSanPhamChiTiet.Text))
			{
				MessageBox.Show("Vui lòng chọn sản phẩm chi tiết để sửa.");
				return;
			}

			string maSanPhamChiTiet = txtMaSanPhamChiTiet.Text;
			string tenSanPhamChiTiet = txtTenSanPhamChiTiet.Text;
			decimal giaSanPham = decimal.Parse(txtGiaSanPham.Text);
			int soLuong = int.Parse(txtSoLuong.Text);
			int trangThai = rdbtConHang.Checked ? 1 : 0; // Cập nhật trạng thái  
			string maSanPham = cbbMaSanPham.SelectedValue.ToString();
			string maMauSac = cbbMauSac.SelectedValue.ToString();

			string query = "UPDATE SanPhamChiTiet SET tenSanPhamChiTiet = @tenSanPhamChiTiet, giaSanPham = @giaSanPham, soLuong = @soLuong, trangThai = @trangThai, maSanPham = @maSanPham, maMauSac = @maMauSac WHERE maSanPhamChiTiet = @maSanPhamChiTiet";
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@maSanPhamChiTiet", maSanPhamChiTiet);
				command.Parameters.AddWithValue("@tenSanPhamChiTiet", tenSanPhamChiTiet);
				command.Parameters.AddWithValue("@giaSanPham", giaSanPham);
				command.Parameters.AddWithValue("@soLuong", soLuong);
				command.Parameters.AddWithValue("@trangThai", trangThai); // Sửa ở đây  
				command.Parameters.AddWithValue("@maSanPham", maSanPham);
				command.Parameters.AddWithValue("@maMauSac", maMauSac);

				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}

			LoadSanPhamChiTietData();
			ClearChiTietFields(); // Xoá các trường nhập liệu của sản phẩm chi tiết  
		}

		private void btnXoaSanPhamChiTiet_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaSanPhamChiTiet.Text))
			{
				MessageBox.Show("Vui lòng chọn sản phẩm chi tiết để xóa.");
				return;
			}

			string maSanPhamChiTiet = txtMaSanPhamChiTiet.Text;

			string query = "DELETE FROM SanPhamChiTiet WHERE maSanPhamChiTiet = @maSanPhamChiTiet";
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@maSanPhamChiTiet", maSanPhamChiTiet);

				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();

				LoadSanPhamChiTietData(); // Tải lại dữ liệu sản phẩm chi tiết  
				ClearChiTietFields(); // Xóa các trường nhập liệu của sản phẩm chi tiết  
				MessageBox.Show("Sản phẩm chi tiết đã được xóa thành công.");
			}

		}

		private void ClearChiTietFields()
		{
			txtMaSanPhamChiTiet.Clear();
			txtTenSanPhamChiTiet.Clear();
			txtGiaSanPham.Clear();
			txtSoLuong.Clear();
			cbbMaSanPham.SelectedIndex = -1;
			cbbMauSac.SelectedIndex = -1;
			rdbtConHang.Checked = false; // Đặt lại trạng thái  
			rdbtHetHang.Checked = false; // Đặt lại trạng thái
		}

		private void btnClearSanPhamChiTiet_Click(object sender, EventArgs e)
		{
			ClearChiTietFields();
		}

		private void dgvSanPhamChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0) // Kiểm tra xem có dòng nào được chọn không  
				{
					DataGridViewRow row = dgvSanPhamChiTiet.Rows[e.RowIndex];
					txtMaSanPhamChiTiet.Text = row.Cells["maSanPhamChiTiet"].Value.ToString();
					txtTenSanPhamChiTiet.Text = row.Cells["tenSanPhamChiTiet"].Value.ToString();
					txtGiaSanPham.Text = row.Cells["giaSanPham"].Value.ToString();
					txtSoLuong.Text = row.Cells["soLuong"].Value.ToString();
					// Cập nhật cho màu sắc và trạng thái nếu có  
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
			}
		}

		private void txtTimKiemSanPham_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtTimKiemSanPham.Text.Trim();

			string query = "SELECT * FROM SanPham WHERE " +
						   "maSanPham LIKE @keyword OR " +
						   "tenSanPham LIKE @keyword OR " +
						   "kieuDang LIKE @keyword OR " +
						   "size LIKE @keyword OR " +
						   "chatLieu LIKE @keyword";

			using (SqlCommand command = new SqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

				try
				{
					connection.Open();
					SqlDataAdapter adapter = new SqlDataAdapter(command);
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
					dgvSanPham.DataSource = dataTable;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connection.Close(); // Quan trọng để không khóa kết nối
				}
			}
		}

		private void txtTimKiemSanPhamChiTiet_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtTimKiemSanPhamChiTiet.Text.Trim(); // Lấy giá trị từ ô tìm kiếm  

			// Tạo câu lệnh SQL với điều kiện tìm kiếm  
			string query = "SELECT * FROM SanPhamChiTiet WHERE " +
						   "maSanPhamChiTiet LIKE @keyword OR " +
						   "tenSanPhamChiTiet LIKE @keyword OR " +
						   "giaSanPham LIKE @keyword OR " +
						   "soLuong LIKE @keyword OR " +
						   "trangThai LIKE @keyword";

			using (SqlConnection connection = new SqlConnection("Data Source=ANH2005\\SQLEXPRESS;Initial Catalog=QL02;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

					try
					{
						connection.Open(); // Mở kết nối đến cơ sở dữ liệu  
						SqlDataAdapter adapter = new SqlDataAdapter(command);
						DataTable dataTable = new DataTable();
						adapter.Fill(dataTable);
						dgvSanPhamChiTiet.DataSource = dataTable; // Hiển thị kết quả lên DataGridView  
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}
