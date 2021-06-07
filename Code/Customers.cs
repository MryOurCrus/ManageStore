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
        void HienThi()
        {
            dataGridView1.DataSource = conn.XemDL("select * from khachhang");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMAKH.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTENKH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDIACHI.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            conn.ThucThiDl("DELETE FROM khachhang WHERE makh='" + txtMAKH.Text + "'");
            txtMAKH.Text = "";
            txtTENKH.Text = "";
            txtDIACHI.Text = "";
            txtSDT.Text = "";
            HienThi();
        }

        private void btUPDATE_Click(object sender, EventArgs e)
        {
            conn.ThucThiDl("UPDATE khachhang SET tenkh=N'" + txtTENKH.Text + "',diachi='" + txtDIACHI.Text + "',sdt=N'" + txtSDT.Text+"' WHERE makh= N'" + txtMAKH.Text + "'");
            HienThi();
        }
    }
}
