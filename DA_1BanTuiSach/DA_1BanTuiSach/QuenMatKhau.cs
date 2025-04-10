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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DA_1BanTuiSach
{
    public partial class QuenMatKhau: Form
    {
		SqlConnection conn;
		public QuenMatKhau()
        {
            InitializeComponent();
			connect();
		}

		public void connect()
		{
			string connectionString = "Data Source=ANH2005\\SQLEXPRESS;Initial Catalog=QL02;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
			conn = new SqlConnection(connectionString);
			conn.Open();
			
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			try
			{
				string email = txtEnv.Text.Trim();
				string taiKhoan = txtTknv.Text.Trim();
				string newPassword = txtMkm.Text.Trim();

				if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(taiKhoan) || string.IsNullOrWhiteSpace(newPassword))
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string query = "SELECT COUNT(*) FROM NhanVien WHERE email = @Email AND taiKhoan = @TaiKhoan";

				// Kiểm tra xem kết nối đã mở chưa trước khi mở
				if (conn.State != ConnectionState.Open)
				{
					conn.Open();
				}

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@Email", email);
					cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

					int count = (int)cmd.ExecuteScalar();

					if (count == 1) // Nếu tìm thấy tài khoản hợp lệ
					{
						string updateQuery = "UPDATE NhanVien SET matKhau = @NewPassword WHERE email = @Email AND taiKhoan = @TaiKhoan";
						using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
						{
							updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
							updateCmd.Parameters.AddWithValue("@Email", email);
							updateCmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
							updateCmd.ExecuteNonQuery();

							txtEnv.Clear();
							txtMkm.Clear();
							txtTknv.Clear();

							MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else
					{
						MessageBox.Show("Email hoặc tài khoản không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				// Đảm bảo kết nối luôn được đóng sau khi thực hiện xong
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
			}
		}

		private void linkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide(); // Ẩn form hiện tại
			DangNhap form1 = new DangNhap();

			// Khi form1 đóng, form hiện tại sẽ hiện lại
			form1.FormClosed += (s, args) => this.Show();

			form1.Show();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void QuenMatKhau_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
