using DA_1BanTuiSach.DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_1BanTuiSach
{
	public partial class Menu : Form
	{
		private Form menu;

		//private DangNhap dangNhapForm;
		//private FormBanHang formBanHang;
		//private FormQuanLyHoaDon formQuanLyHoaDon;
		//private KhachHang khachHangForm;
		//private KhuyenMai khuyenMaiForm;
		//private QuanLyNhanVien QuanLyNhanVienForm;
		//private QuenMatKhau QuenMatKhauForm;
		//private SanPham sanPhamForm;
		//private ThongKe thongKeForm;
		public Menu()
		{
			InitializeComponent();

			//dangNhapForm = new DangNhap();
			//formBanHang = new FormBanHang();
			//formQuanLyHoaDon = new FormQuanLyHoaDon();
			//khachHangForm = new KhachHang();
			//khuyenMaiForm = new KhuyenMai();
			//QuanLyNhanVienForm = new QuanLyNhanVien();
			//QuenMatKhauForm = new QuenMatKhau();
			//sanPhamForm = new SanPham();
			//thongKeForm = new ThongKe();


		}

		private void OpenMenuForm(Form formcon)
		{
			if (menu != null)
			{
				menu.Close();
			}
			menu = formcon;
			formcon.TopLevel = false;
			formcon.FormBorderStyle = FormBorderStyle.None;
			formcon.Dock = DockStyle.Fill;

			pn_trangchu.Controls.Add(formcon);
			pn_trangchu.Tag = formcon;
			formcon.BringToFront();
			formcon.Show();
		}

		private void bt_thongkemenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_thongkemenu.Text;
			OpenMenuForm(new ThongKe());
		}

		private void bt_sanphammenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_sanphammenu.Text;
			OpenMenuForm(new SanPham());
		}

		private void bt_nhanvienmenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_nhanvienmenu.Text;
			OpenMenuForm(new QuanLyNhanVien());
		}

		private void bt_hoadonmenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_hoadonmenu.Text;
			OpenMenuForm(new FormQuanLyHoaDon());
		}

		private void bt_khachhangmenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_khachhangmenu.Text;
			OpenMenuForm(new KhachHang());
		}

		private void bt_khuyenmaimenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_khuyenmaimenu.Text;
			OpenMenuForm(new KhuyenMai());
		}

		private void bt_doimaukhaumenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_doimaukhaumenu.Text;
			OpenMenuForm(new QuenMatKhau());
		}

		private void bt_dangxuatmenu_Click(object sender, EventArgs e)
		{
			this.Hide(); // Ẩn form hiện tại
			DangNhap dangnhap= new DangNhap();

			// Khi form1 đóng, form hiện tại sẽ hiện lại
			dangnhap.FormClosed += (s, args) => this.Show();

			dangnhap.Show();
		}

		private void Menu_Load(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void bt_banhangmenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_banhangmenu.Text;
			OpenMenuForm(new FormBanHang());
		}
	}
}
