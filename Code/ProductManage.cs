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

namespace Code
{
    public partial class ProductManage : Form
    {
        public ProductManage()
        {
            InitializeComponent();
            HienThi();
            if (Login.permission != "admin") {
                bt_add.Enabled = false;
                bt_delete.Enabled = false;
                bt_update.Enabled = false;
                tb_masp.Enabled = false;
                tb_tensp.Enabled = false;
                tb_giaban.Enabled = false;
            }
        }
        Connections conn = new Connections();
        
        void HienThi()
        {
            
            dataGridView1.DataSource = conn.XemDL("select * from sanpham");
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            
            conn.ThucThiDl("INSERT INTO sanpham VALUES(N'" + tb_masp.Text + "', N'" + tb_tensp.Text + "',N'" + tb_giaban.Text + "')");
            HienThi();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            
            conn.ThucThiDl("UPDATE sanpham SET masp=N'" + tb_masp.Text + "',tensp=N'" + tb_tensp.Text + "',giaban=N'" + tb_giaban.Text +
                "' WHERE masp= N'" + tb_masp.Text + "'");
            HienThi();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            
            conn.ThucThiDl("DELETE FROM sanpham WHERE masp=N'" + tb_masp.Text + "'");
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home frm = new Home();
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_masp.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_tensp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_giaban.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = conn.XemDL("SELECT * From sanpham where sanpham.tensp Like N'%" + tb_findname.Text+"%'");
        }

        private void ProductManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Ngatketnoi();
        }
    }
}
