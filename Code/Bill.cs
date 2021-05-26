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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            var cmd0 = new SqlCommand("select masp from sanpham", conn);
            var dr = cmd0.ExecuteReader();
            DataTable dvt = new DataTable();
            dvt.Load(dr); cb_MSP.DisplayMember = "masp"; cb_MSP.DataSource = dvt;
            var cmd1 = new SqlCommand("select manv from nhanvien", conn);
            var drr = cmd1.ExecuteReader();
            DataTable nvt = new DataTable();
            nvt.Load(drr); cb_MNV.DisplayMember = "manv"; cb_MNV.DataSource = nvt;
        }
        SqlConnection conn = new SqlConnection(StringConn.connectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        void HienThi()
        {
            cmd.CommandText = "select * from hoadonra";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            table.Clear();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO hoadonra(mahdr,masp,soluong,manv) VALUES(N'" + tb_MHD.Text + "',N'" + cb_MSP.Text + "'," + nud_SL.Value + "',N'" + cb_MNV.Text + "')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * From hoadonra where hoadonra.ngayban>=" + dateTimePicker1.Text + "and hoadonra.ngayban<=" + dateTimePicker2.Text;
            cmd.Connection = conn;
            da.SelectCommand = cmd;table.Clear();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
