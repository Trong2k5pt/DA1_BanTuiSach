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
    public partial class DangNhap: Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(@"Data Source=ANH2005\SQLEXPRESS;Initial Catalog=QL02;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
			try
			{
				conn.Open();
				string tk = txtTk.Text.Trim();
				string mk = txtMk.Text.Trim(); // Chưa mã hóa, cần băm (hash) mật khẩu nếu CSDL đã lưu hash

				string sql = "SELECT * FROM NhanVien WHERE taiKhoan = @tk AND matKhau = @mk";

				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@tk", tk);
					cmd.Parameters.AddWithValue("@mk", mk); // Nên sử dụng mật khẩu đã hash

					using (SqlDataReader rdr = cmd.ExecuteReader())
					{
						if (rdr.Read())
						{
							
							Menu form2 = new DA_1BanTuiSach.Menu();
							form2.Show();
							form2.FormClosed += (s, args) => this.Show();
							this.Hide();
						}
						else
						{
							MessageBox.Show("Đăng Nhập Thất Bại");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi Kết Nối: " + ex.Message);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			QuenMatKhau form3 = new QuenMatKhau();
			form3.Show();
			form3.FormClosed += (s, args) => this.Show();
		}

		private void DangNhap_Load(object sender, EventArgs e)
		{

		}
	}
}
