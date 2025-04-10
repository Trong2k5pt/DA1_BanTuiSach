using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_1BanTuiSach
{
    public partial class QuanLyNhanVien: Form
    {
		SqlConnection conn;
		public QuanLyNhanVien()
        {
            InitializeComponent();
			connect();
			hienthi();
		}
		public void connect()
		{
			string connectionString = "Data Source=ANH2005\\SQLEXPRESS;Initial Catalog=QL02;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
			conn = new SqlConnection(connectionString);
			conn.Open();
			
		}
		public void hienthi()
		{
			string sql = "SELECT * FROM NhanVien";
			SqlCommand cmd = new SqlCommand(sql, conn);
			SqlDataReader rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(rdr);
			dataGridView1.DataSource = dt;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				if ( // Mã nhân viên
					string.IsNullOrWhiteSpace(txtTennv.Text) ||   // Tên nhân viên
					string.IsNullOrWhiteSpace(txtSdt.Text) ||   // Số điện thoại
					string.IsNullOrWhiteSpace(txtEmail.Text) ||   // Email
					string.IsNullOrWhiteSpace(txtDiachi.Text) ||   // Địa chỉ
					string.IsNullOrWhiteSpace(txtTk.Text) ||   // Tài khoản
					string.IsNullOrWhiteSpace(txtMk.Text) ||  // Mật khẩu
					rbLam.Checked == false && rbNghilam.Checked == false)// Trạng thái

				{
					MessageBox.Show("Không được để trống bất kỳ ô nào!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string soDienThoai = txtSdt.Text.Trim();
				Regex regexSDT = new Regex(@"^0\d{9}$");
				if (!regexSDT.IsMatch(soDienThoai))
				{
					MessageBox.Show("Số điện thoại không hợp lệ! Phải bắt đầu bằng số 0 và có đúng 10 số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return; // Dừng việc thêm vào CSDL
				}
				// Kiểm tra email hợp lệ
				string email = txtEmail.Text.Trim();
				Regex regexEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@gmail\.com$");
				if (!regexEmail.IsMatch(email))
				{
					MessageBox.Show("Email phải có đuôi @gmail.com!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Kiểm tra tài khoản trùng
				string taiKhoan = txtTk.Text.Trim();
				string sqlCheckTaiKhoan = "SELECT COUNT(*) FROM NhanVien WHERE taiKhoan = @taiKhoan";

				using (SqlCommand cmdCheck = new SqlCommand(sqlCheckTaiKhoan, conn))
				{
					cmdCheck.Parameters.AddWithValue("@taiKhoan", taiKhoan);
					int countTaiKhoan = (int)cmdCheck.ExecuteScalar();
					if (countTaiKhoan > 0)
					{
						MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tài khoản khác.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}

				// Kiểm tra email trùng
				string sqlCheckEmail = "SELECT COUNT(*) FROM NhanVien WHERE email = @email";

				using (SqlCommand cmdCheckEmail = new SqlCommand(sqlCheckEmail, conn))
				{
					cmdCheckEmail.Parameters.AddWithValue("@email", email);
					int countEmail = (int)cmdCheckEmail.ExecuteScalar();
					if (countEmail > 0)
					{
						MessageBox.Show("Email đã tồn tại. Vui lòng sử dụng email khác.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}
				string gioiTinh = cbGt.SelectedItem.ToString();
				string sql = "INSERT INTO NhanVien(tenNhanVien, soDienThoai, gioiTinh, email, diaChi, taiKhoan, matKhau, trangThai) VALUES(@tenNhanVien, @soDienThoai, @gioiTinh, @email, @diaChi, @taiKhoan, @matKhau, @trangThai)";
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@tenNhanVien", txtTennv.Text);
					cmd.Parameters.AddWithValue("@soDienThoai", txtSdt.Text);
					cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
					cmd.Parameters.AddWithValue("@email", txtEmail.Text);
					cmd.Parameters.AddWithValue("@diaChi", txtDiachi.Text);
					cmd.Parameters.AddWithValue("@taiKhoan", txtTk.Text);
					cmd.Parameters.AddWithValue("@matKhau", txtMk.Text);
					cmd.Parameters.AddWithValue("@trangThai", rbLam.Checked ? 1 : 0);
					cmd.ExecuteNonQuery();
					DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (result == DialogResult.No) return;
					MessageBox.Show("Thêm thành công");
					hienthi();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void QuanLyNhanVien_Load(object sender, EventArgs e)
		{
			cbGt.Items.Add("Nam");
			cbGt.Items.Add("Nữ");
			cbGt.SelectedIndex = 0;
		}

		private void QuanLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (conn != null && conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				txtmaNv.Text = row.Cells["maNhanVien"].Value.ToString();
				txtTennv.Text = row.Cells["tenNhanVien"].Value.ToString();
				txtSdt.Text = row.Cells["soDienThoai"].Value.ToString();
				txtEmail.Text = row.Cells["email"].Value.ToString();
				txtDiachi.Text = row.Cells["diaChi"].Value.ToString();
				txtTk.Text = row.Cells["taiKhoan"].Value.ToString();
				txtMk.Text = row.Cells["matKhau"].Value.ToString();
				string gioitinh = row.Cells["gioiTinh"].Value.ToString();
				cbGt.SelectedItem = gioitinh;
				int trangthai = Convert.ToInt32(row.Cells["trangThai"].Value);
				if (trangthai == 1)
				{
					rbLam.Checked = true;
					rbNghilam.Checked = false;
				}
				else
				{
					rbLam.Checked = false;
					rbNghilam.Checked = true;
				}
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				string maNhanVien = txtmaNv.Text.Trim();
				string email = txtEmail.Text.Trim();
				string taiKhoan = txtTk.Text.Trim();
				Regex regexEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@gmail\.com$");
				if (!regexEmail.IsMatch(email))
				{
					MessageBox.Show("Email phải có đuôi @gmail.com!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				string sqlCheckEmail = "SELECT COUNT(*) FROM NhanVien WHERE email = @email AND maNhanVien <> @maNhanVien";
				using (SqlCommand cmdCheckEmail = new SqlCommand(sqlCheckEmail, conn))
				{
					cmdCheckEmail.Parameters.AddWithValue("@email", email);
					cmdCheckEmail.Parameters.AddWithValue("@maNhanVien", maNhanVien);
					int countEmail = (int)cmdCheckEmail.ExecuteScalar();
					if (countEmail > 0)
					{
						MessageBox.Show("Email đã tồn tại. Vui lòng sử dụng email khác.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}

				// Kiểm tra tài khoản đã tồn tại nhưng không phải của nhân viên hiện tại
				string sqlCheckTaiKhoan = "SELECT COUNT(*) FROM NhanVien WHERE taiKhoan = @taiKhoan AND maNhanVien <> @maNhanVien";
				using (SqlCommand cmdCheckTaiKhoan = new SqlCommand(sqlCheckTaiKhoan, conn))
				{
					cmdCheckTaiKhoan.Parameters.AddWithValue("@taiKhoan", taiKhoan);
					cmdCheckTaiKhoan.Parameters.AddWithValue("@maNhanVien", maNhanVien);
					int countTaiKhoan = (int)cmdCheckTaiKhoan.ExecuteScalar();
					if (countTaiKhoan > 0)
					{
						MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tài khoản khác.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}

				string gioiTinh = cbGt.SelectedItem.ToString();
				string sqlUdate = "UPDATE NhanVien SET tenNhanVien = @tenNhanVien, soDienThoai = @soDienThoai, gioiTinh = @gioiTinh, email = @email, diaChi = @diaChi, taiKhoan = @taiKhoan, matKhau = @matKhau, trangThai = @trangThai WHERE maNhanVien = @maNhanVien";
				using (SqlCommand cmd = new SqlCommand(sqlUdate, conn))
				{
					cmd.Parameters.AddWithValue("@maNhanVien", txtmaNv.Text);
					cmd.Parameters.AddWithValue("@tenNhanVien", txtTennv.Text);
					cmd.Parameters.AddWithValue("@soDienThoai", txtSdt.Text);
					cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
					cmd.Parameters.AddWithValue("@email", txtEmail.Text);
					cmd.Parameters.AddWithValue("@diaChi", txtDiachi.Text);
					cmd.Parameters.AddWithValue("@trangThai", rbLam.Checked ? 1 : 0);
					cmd.Parameters.AddWithValue("@taiKhoan", txtTk.Text);
					cmd.Parameters.AddWithValue("@matKhau", txtMk.Text);
					cmd.ExecuteNonQuery();
					DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (result == DialogResult.No) return;
					MessageBox.Show("Sửa thành công");
					hienthi();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell != null)
			{
				int index = dataGridView1.CurrentCell.RowIndex;
				string maNhanVien = dataGridView1.Rows[index].Cells["maNhanVien"].Value?.ToString();

				if (string.IsNullOrEmpty(maNhanVien))
				{
					MessageBox.Show("Không thể xóa! Mã nhân viên không hợp lệ.");
					return;
				}

				// Xác nhận trước khi xóa
				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.No) return;

				// Xóa nhân viên trong database
				string sqlDelete = "DELETE FROM NhanVien WHERE maNhanVien = @maNhanVien";
				using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
				{
					cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
					if (conn.State != ConnectionState.Open) conn.Open();
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Xóa thành công");

				// Cập nhật giao diện
				if (dataGridView1.DataSource is BindingSource bindingSource)
				{
					bindingSource.RemoveCurrent();
				}
				else
				{
					hienthi();
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một nhân viên để xóa.");
			}
		}

		private void btnLammoi_Click(object sender, EventArgs e)
		{
			txtMk.Clear();
			txtTennv.Clear();
			txtSdt.Clear();
			txtEmail.Clear();
			txtDiachi.Clear();
			txtTk.Clear();
			txtmaNv.Clear();
			txtTimkiem.Clear();
			cbGt.SelectedIndex = 0;
			rbLam.Checked = false;
			rbNghilam.Checked = false;
			hienthi();
		}

		private void btnTimkiem_Click(object sender, EventArgs e)
		{
			string timkiem = txtTimkiem.Text.Trim();
			if (timkiem.Length == 0)
			{
				MessageBox.Show("Nhập từ khóa cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string sql = "SELECT * FROM NhanVien WHERE maNhanVien LIKE @timKiem OR tenNhanVien LIKE @timKiem OR soDienThoai LIKE @timKiem";
			SqlCommand cmd = new SqlCommand(sql, conn);
			// Sử dụng '%' để tìm kiếm gần đúng cho tên nhân viên và số điện thoại
			cmd.Parameters.AddWithValue("@timKiem", "%" + timkiem + "%");

			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				hienthi();
			}
			else
			{
				dataGridView1.DataSource = dt;
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
