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
        Connections conn = new Connections();
        public Bill()
        {
            InitializeComponent();
            
        }
        
        void HienThi()
        {
            dataGridView1.DataSource = conn.XemDL("select * from hoadonra");
            //txtPrice.Text = Convert.ToString(conn.XemDL("select giaban from sanpham where masp='" + cb_MSP.Text + "'").Rows[0][0]);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //cmd.CommandText = ;
            //cmd.Connection = conn;
            //cmd.ExecuteNonQuery();
            try
            {
                conn.ThucThiDl("INSERT INTO hoadonra(mahdr,masp,soluong,thanhtien,ngayban,manv)   VALUES(N'" + tb_MHD.Text + "', N'" + cb_MSP.Text + "'," + nud_SL.Value + "," + txtPrice.Text + " ,'" + dateTimePicker3.Value.ToShortDateString() + "' , N'" + txtNV.Text + "')");
                conn.ThucThiDl("INSERT INTO khachhang(makh,tenkh,diachi,sdt,mahdr)  VALUES('" + tb_MHD.Text + "', N'" + txtKhach.Text + "',N'" + txtAddr.Text + "','" + txtPhone.Text + "' ,'" + tb_MHD.Text + "')");
                //MessageBox.Show("Thêm thành công");
                PrintBill prbill = new PrintBill();
                prbill.printBill(txtKhach.Text, txtPhone.Text, tb_MHD.Text, cb_MSP.Text, nud_SL.Value.ToString(), dateTimePicker3.Value.ToShortDateString(), txtPrice.Text);
                prbill.Show();
                HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cmd.CommandText = ;
            //cmd.Connection = conn;
            //da.SelectCommand = cmd;table.Clear();
            //da.Fill(table);
            dataGridView1.DataSource = conn.XemDL("SELECT * From hoadonra where hoadonra.ngayban>='" + dateTimePicker1.Value.ToShortDateString() + "'and hoadonra.ngayban<='" + dateTimePicker2.Value.ToShortDateString()+"'");
            HienThi();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            
            DataTable dt = conn.XemDL("select masp from sanpham");
            cb_MSP.DisplayMember = "masp";
            cb_MSP.ValueMember = "masp";
            cb_MSP.DataSource = dt;
            txtNV.Text = Login.nameNV;
            HienThi();
        }

        private void cb_MSP_SelectedValueChanged(object sender, EventArgs e)
        {
            txtPrice.Text = Convert.ToString(Convert.ToInt32(conn.XemDL("select giaban from sanpham where masp='" + cb_MSP.Text + "'").Rows[0][0])*nud_SL.Value);
        }

        private void nud_SL_ValueChanged(object sender, EventArgs e)
        {
            txtPrice.Text = Convert.ToString(Convert.ToInt32(conn.XemDL("select giaban from sanpham where masp='" + cb_MSP.Text + "'").Rows[0][0]) * nud_SL.Value);
        }
    }
}
