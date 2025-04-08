using System;
using System.Windows.Forms;

namespace DA_1BanTuiSach
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormQuanLyHoaDon()); // Đổi thành form chính của bạn nếu không phải FormBanHang
        }
    }
}
