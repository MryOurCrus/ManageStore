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
        }
        SqlConnection conn = new SqlConnection(StringConn.connectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        void HienThi()
        {
            cmd.CommandText = "select * from sanpham";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            table.Clear();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO sanpham VALUES(N'" + tb_masp.Text + "', N'" + tb_tensp.Text + "',N'" + tb_giaban.Text + "')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE sanpham SET masp=N'" + tb_masp.Text + "',tensp=N'" + tb_tensp.Text + "',giaban=N'" + tb_giaban.Text +
                "' WHERE masp= N'" + tb_masp.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM sanpham WHERE masp=N'" + tb_masp.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
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
    }
}
