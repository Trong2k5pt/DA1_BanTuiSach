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
	public partial class ThongKe : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		string str = "Data Source=ANH2005\\SQLEXPRESS;Initial Catalog=QL02;Integrated Security=True;TrustServerCertificate=True ";
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable dt = new DataTable();
		public ThongKe()
		{
			InitializeComponent();
		}

		void LoadData()
		{
			cmd = con.CreateCommand();
			cmd.CommandText = "select * from HoaDon";
			adapter.SelectCommand = cmd;
			dt.Clear();
			adapter.Fill(dt);
			dtg_ViewDT.DataSource = dt;
		}

		private void ThongKe_Load(object sender, EventArgs e)
		{
			con = new SqlConnection(str);
			con.Open();
			LoadData();
		}
		private void dtg_ViewDT_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dtg_ViewDT.Rows[e.RowIndex];
				tb_mahoadondoanhthu.Text = row.Cells["maHoaDon"].Value.ToString();
				tb_ngaylaphoadontrongdoanhthu.Text = row.Cells["ngayLapHoaDon"].Value.ToString();
				tb_tenkhachhangdoanhthu.Text = row.Cells["tenKhachHang"].Value.ToString();
				tb_sdtkhachhangtrongdoanhthu.Text = row.Cells["soDienThoai"].Value.ToString();
				tb_tongtiendoanhthu.Text = row.Cells["tongTien"].Value.ToString();
				tb_phuongthucthanhtoandoanhthu.Text = row.Cells["phuongThucThanhToan"].Value.ToString();
			}
		}

		private void bt_timkiemdoanhthu_Click(object sender, EventArgs e)
		{
			string timkiem = tb_tìmkiemdoanhthu.Text.Trim();
			if (timkiem.Length == 0)
			{
				MessageBox.Show("Nhập từ khóa cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string sql = " SELECT * FROM HoaDon WHERE maHoaDon = @maHoaDon";
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@maHoaDon", timkiem);
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
				dtg_ViewDT.DataSource = dt;
			}
		}

		private void bt_xemdoanhthu_Click(object sender, EventArgs e)
		{
			DateTime ngayBatDau = dtp_ngaybatdau.Value.Date;
			DateTime ngayKetThuc = dtp_ngayketthuc.Value.Date;

			// Câu lệnh SQL lọc dữ liệu theo khoảng thời gian
			string sql = "SELECT * FROM HoaDon WHERE ngayLapHoaDon BETWEEN @ngayBatDau AND @ngayKetThuc";
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@ngayBatDau", ngayBatDau);
			cmd.Parameters.AddWithValue("@ngayKetThuc", ngayKetThuc);

			// Thực thi câu lệnh SQL và cập nhật DataGridView
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);

			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu trong khoảng thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				dtg_ViewDT.DataSource = dt;
			}
		}

		private void label11_Click(object sender, EventArgs e)
		{

		}
	}
}
