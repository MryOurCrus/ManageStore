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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();

        }
        Connections conn = new Connections();
        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = conn.XemDL("Select * from hoadonra where ngayban between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value+"'");
        }
    }
}
