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
            string connectionString = "Data Source=DESKTOP-SEL9RHK;Initial Catalog=QL01;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
        }
    }
}
