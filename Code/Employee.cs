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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            if(Login.permission != "admin")
            {
                bt_add.Enabled = false;
                bt_delete.Enabled = false;
                bt_update.Enabled = false;
                txtMANV.Enabled = false;
                txtDIACHI.Enabled = false;
                txtSDT.Enabled = false;
                txtTENNV.Enabled = false;
                cbbGIOITINH.Enabled = false;
                dtpNGAYSINH.Enabled = false;
            }    
        }
        Connections conn = new Connections();
        void HienThi()
        {
            dataGridView1.DataSource = conn.XemDL("select * from nhanvien");
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.XemDL("SELECT * from nhanvien");
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Ngatketnoi();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            conn.ThucThiDl("insert into nhanvien values ('"+txtMANV.Text+"',N'"+txtTENNV.Text+"','"+dtpNGAYSINH.Value.ToShortDateString()+"',N'"+txtDIACHI.Text+"','"+cbbGIOITINH.Text+"','"+txtSDT.Text+"')");
            txtMANV.Text = "";
            txtTENNV.Text = "";
            dtpNGAYSINH.Text = "";
            txtDIACHI.Text = "";
            cbbGIOITINH.Text = "";
            txtSDT.Text = "";
            HienThi();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            conn.ThucThiDl("UPDATE nhanvien SET hoten=N'" + txtTENNV.Text + "',ngaysinh='" + dtpNGAYSINH.Value.ToShortDateString() + "',diachi=N'" + txtDIACHI.Text + "',gioitinh=N'"+cbbGIOITINH.Text+ "',sodienthoai=N'"+txtSDT.Text+
                "' WHERE manv= N'" + txtMANV.Text + "'");
            txtMANV.Text = "";
            txtTENNV.Text = "";
            dtpNGAYSINH.Text = "";
            txtDIACHI.Text = "";
            cbbGIOITINH.Text = "";
            txtSDT.Text = "";
            HienThi();
            
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            conn.ThucThiDl("DELETE FROM nhanvien WHERE manv='" + txtMANV.Text + "'");
            txtMANV.Text = "";
            txtTENNV.Text = "";
            dtpNGAYSINH.Text = "";
            txtDIACHI.Text = "";
            cbbGIOITINH.Text = "";
            txtSDT.Text = "";
            HienThi();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMANV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTENNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNGAYSINH.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDIACHI.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbbGIOITINH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.XemDL("SELECT * From nhanvien where nhanvien.hoten Like N'%" + tb_findname.Text + "%'");
        }
    }
}
