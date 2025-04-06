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
	public partial class KhachHang : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		string str = "Data Source=TINHLV\\SQLEXPRESS;Initial Catalog=QL02;Integrated Security=True;TrustServerCertificate=True ";
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
				tb_maKH.Text = row.Cells["maKhachHang"].Value.ToString();
				tb_tenKH.Text = row.Cells["tenKhachHang"].Value.ToString();
				tb_gioitinh.Text = row.Cells["gioiTinh"].Value.ToString();
				tb_sdt.Text = row.Cells["soDienThoai"].Value.ToString();
				tb_diachi.Text = row.Cells["diachi"].Value.ToString();
				tb_email.Text = row.Cells["email"].Value.ToString();
				tb_trangthai.Text = row.Cells["trangThai"].Value.ToString();
			}
		}

		private void bt_them_Click(object sender, EventArgs e)
		{
			try
			{
				string sql = "INSERT INTO KhachHang(tenKhachHang, soDienThoai, gioiTinh, email, diaChi, trangThai) VALUES (@tenKhachHang, @soDienThoai, @gioiTinh, @email, @diaChi, @trangThai)";
				using (SqlCommand cmd = new SqlCommand(sql, con))
				{
					cmd.Parameters.AddWithValue("@tenKhachHang", tb_tenKH.Text);
					cmd.Parameters.AddWithValue("@soDienThoai", tb_sdt.Text);
					cmd.Parameters.AddWithValue("@gioiTinh", tb_gioitinh.Text);
					cmd.Parameters.AddWithValue("@email", tb_email.Text);
					cmd.Parameters.AddWithValue("@diaChi", tb_diachi.Text);
					cmd.Parameters.AddWithValue("@trangThai", tb_trangthai.Text);
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
					cmd.Parameters.AddWithValue("@maKhachHang", tb_maKH.Text);
					cmd.Parameters.AddWithValue("@tenKhachHang", tb_tenKH.Text);
					cmd.Parameters.AddWithValue("@soDienThoai", tb_sdt.Text);
					cmd.Parameters.AddWithValue("@gioiTinh", tb_gioitinh.Text);
					cmd.Parameters.AddWithValue("@email", tb_email.Text);
					cmd.Parameters.AddWithValue("@diaChi", tb_diachi.Text);
					cmd.Parameters.AddWithValue("@trangThai", tb_trangthai.Text);
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
	}
}
