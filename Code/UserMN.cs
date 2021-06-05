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
    public partial class UserMN : Form
    {
        public UserMN()
        {
            InitializeComponent();
            DataTable dt = conn.XemDL("select manv from nhanvien");
            cb_maNV.DisplayMember = "manv";
            cb_maNV.ValueMember = "manv";
            cb_maNV.DataSource = dt;
            HienThi();
        }
        void HienThi()
        {
            dataGridView1.DataSource = conn.XemDL("select tentk,quyen,manv from taikhoan");
        }
        Connections conn = new Connections();
        private void button1_Click(object sender, EventArgs e)
        {
            conn.ThucThiDl("insert into taikhoan values(N'"+tb_tentk.Text+"',N'"+tb_matkhau.Text+"',N'"+tb_quyen.Text+"',N'"+cb_maNV.Text+"')");
            HienThi();
        }

        private void tb_matkhau_TextChanged(object sender, EventArgs e)
        {
            this.tb_matkhau.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.ThucThiDl("delete from taikhoan where tentk=N'" + tb_tentk.Text+"'");
            HienThi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_tentk.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_quyen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_maNV.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
