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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(@"Data Source=ANH2005\SQLEXPRESS;Initial Catalog=QL02;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
			try
			{
				conn.Open();
				string tk = textBox1.Text.Trim();
				string mk = textBox2.Text.Trim(); // Chưa mã hóa, cần băm (hash) mật khẩu nếu CSDL đã lưu hash

				string sql = "SELECT * FROM NhanVien WHERE taiKhoan = @tk AND matKhau = @mk";

				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@tk", tk);
					cmd.Parameters.AddWithValue("@mk", mk); // Nên sử dụng mật khẩu đã hash

					using (SqlDataReader rdr = cmd.ExecuteReader())
					{
						if (rdr.Read())
						{
							MessageBox.Show("Đăng Nhập Thành Công");
							Form2 form2 = new Form2();
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

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			Form3 form3 = new Form3();
			form3.Show();
			form3.FormClosed += (s, args) => this.Show();
		}
	}
}
