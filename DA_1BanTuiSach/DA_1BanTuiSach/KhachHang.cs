using System;
using System.CodeDom;
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
	public partial class KhachHang : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		string str = "Data Source=ANH2005\\SQLEXPRESS;Initial Catalog=QL02;Integrated Security=True;TrustServerCertificate=True ";
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable dt = new DataTable();

		void LoadData()
		{
			cmd = con.CreateCommand();
			cmd.CommandText = "select * from KhachHang";
			adapter.SelectCommand = cmd;
			dt.Clear();
			adapter.Fill(dt);
			data_viewKH.DataSource = dt;
		}
		public KhachHang()
		{
			InitializeComponent();
		}
		private void KhachHang_Load(object sender, EventArgs e)
		{
			con = new SqlConnection(str);
			con.Open();
			LoadData();
		}

		private void data_viewKH_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.data_viewKH.Rows[e.RowIndex];
				tb_makhachhang.Text = row.Cells["maKhachHang"].Value.ToString();
				tb_tenKH.Text = row.Cells["tenKhachHang"].Value.ToString();
				cbb_gioitinhKhachHang.Text = row.Cells["gioiTinh"].Value.ToString();
				tb_sdt.Text = row.Cells["soDienThoai"].Value.ToString();
				tb_diachi.Text = row.Cells["diachi"].Value.ToString();
				tb_email.Text = row.Cells["email"].Value.ToString();
				cbb_trangthaikhachhang.Text = row.Cells["trangthai"].Value.ToString();
				//string trangThai = row.Cells["trangThai"].Value.ToString();
				//if (trangThai == "True")
				//{
				//	cbb_trangthaikhachhang.Text = "Còn hoạt động";
				//}
				//else if (trangThai == "False")
				//{
				//	cbb_trangthaikhachhang.Text = "Không còn hoạt động";
				//}
				//else
				//{
				//	MessageBox.Show("Trạng thái không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	return;
				//}
			}
		}

		private void bt_them_Click(object sender, EventArgs e)
		{
			try
			{
				string sql = "INSERT INTO KhachHang(tenKhachHang, soDienThoai, gioiTinh, email, diaChi, trangThai) VALUES (@tenKhachHang, @soDienThoai, @gioiTinh, @email, @diaChi, @trangThai)";
				using (SqlCommand cmd = new SqlCommand(sql, con))
				{
					//cmd.Parameters.AddWithValue("@makhachHang", tb_makhachhang.Text);
					cmd.Parameters.AddWithValue("@tenKhachHang", tb_tenKH.Text);
					cmd.Parameters.AddWithValue("@soDienThoai", tb_sdt.Text);
					cmd.Parameters.AddWithValue("@gioiTinh", cbb_gioitinhKhachHang.Text);
					cmd.Parameters.AddWithValue("@email", tb_email.Text);
					cmd.Parameters.AddWithValue("@diaChi", tb_diachi.Text);
					cmd.Parameters.AddWithValue("@trangthai", cbb_trangthaikhachhang.Text);
					//string trangThai = cbb_trangthaikhachhang.Text;
					//if (trangThai.ToString() == "Còn hoạt động")
					//{
					//	cbb_trangthaikhachhang.Text = "True";
					//	cmd.Parameters.Add(trangThai);
					//}
					//else if (trangThai.ToString() == "Không còn hoạt động")
					//{
					//	cbb_trangthaikhachhang.Text = "False";
					//	cmd.Parameters.Add(trangThai);
					//}
					//else
					//{
					//	MessageBox.Show("Trạng thái không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					//	return;
					//}
					cmd.ExecuteNonQuery();
					MessageBox.Show("Thêm thành công");
					LoadData();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void bt_sua_Click(object sender, EventArgs e)
		{
			try
			{
				string sqlUdate = "UPDATE KhachHang SET tenKhachHang = @tenKhachHang, soDienThoai = @soDienThoai, gioiTinh = @gioiTinh, email = @email, diaChi = @diaChi, trangThai = @trangThai WHERE maKhachHang = @maKhachHang";
				using (SqlCommand cmd = new SqlCommand(sqlUdate, con))
				{
					cmd.Parameters.AddWithValue("@maKhachHang", tb_makhachhang.Text);
					cmd.Parameters.AddWithValue("@tenKhachHang", tb_tenKH.Text);
					cmd.Parameters.AddWithValue("@soDienThoai", tb_sdt.Text);
					cmd.Parameters.AddWithValue("@gioiTinh", cbb_gioitinhKhachHang.Text);
					cmd.Parameters.AddWithValue("@email", tb_email.Text);
					cmd.Parameters.AddWithValue("@diaChi", tb_diachi.Text);
					cmd.Parameters.AddWithValue("@trangThai", cbb_trangthaikhachhang.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Sửa thành công");
					LoadData();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}
		private void bt_timkiem_Click(object sender, EventArgs e)
		{
			string timkiem = tb_timkiem.Text.Trim();
			if (timkiem.Length == 0)
			{
				MessageBox.Show("Nhập từ khóa cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string sql = " SELECT * FROM KhachHang WHERE maKhachHang = @maKhachHang";
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@maKhachHang", timkiem);
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				LoadData();
			}
			else
			{
				data_viewKH.DataSource = dt;
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
