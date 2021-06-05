using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        Connections conn = new Connections();
        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.XemDL("SELECT * FROM khachhang");
        }
    }
}
