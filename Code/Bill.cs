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
            //dataGridView1.DataSource = conn.XemDL("select * from hoadonra");


        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.ThucThiDl("INSERT INTO hoadonra(mahdr,masp,soluong,thanhtien,ngayban,manv)   VALUES(N'" + tb_MHD.Text + "', N'" + tbTong.Text + "'," + txtSLSP.Text + "," + txtTongTien.Text + " ,'" + dateTimePicker3.Value.ToShortDateString() + "' , N'" + txtNV.Text + "')");
                conn.ThucThiDl("INSERT INTO khachhang(makh,tenkh,diachi,sdt,mahdr)  VALUES('" + tb_MHD.Text + "', N'" + txtKhach.Text + "',N'" + txtAddr.Text + "','" + txtPhone.Text + "' ,'" + tb_MHD.Text + "')");
                //MessageBox.Show("Thêm thành công");
                PrintBill prbill = new PrintBill();
                prbill.printBill(txtKhach.Text, txtPhone.Text, tb_MHD.Text, tbTong.Text, dateTimePicker3.Value.ToShortDateString(), txtTongTien.Text, txtSLSP.Text);
                prbill.Show();
                //HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void cb_MSP_SelectedValueChanged(object sender, EventArgs e)
        {
            txtPrice.Text = Convert.ToString(Convert.ToInt32(conn.XemDL("select giaban from sanpham where masp='" + cb_MSP.Text + "'").Rows[0][0])*nud_SL.Value);
        }

        private void nud_SL_ValueChanged(object sender, EventArgs e)
        {
            txtPrice.Text = Convert.ToString(Convert.ToInt32(conn.XemDL("select giaban from sanpham where masp='" + cb_MSP.Text + "'").Rows[0][0]) * nud_SL.Value);
        }

        int sl = 0;
        private void btThemSP_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(cb_MSP.Text, nud_SL.Value, txtPrice.Text);
            sl++;
            if (sl != 0) {
                tbTong.Text = DSSLDGV().ToString();
                txtTongTien.Text = tinhTongTienDGV().ToString();
                txtSLSP.Text = tinhTongSLDGV().ToString();
            };
            

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sl != 0)
                {
                    foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                    {
                        if (oneCell.Selected)
                            dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        
                    }
                };

                sl--;
                if (sl != 0)
                {
                    tbTong.Text = DSSLDGV().ToString();
                    txtTongTien.Text = tinhTongTienDGV().ToString();
                    txtSLSP.Text = tinhTongSLDGV().ToString();
                };
            }
            catch (Exception ) {

                    MessageBox.Show("Mời chọn sp cần xóa");
            };
            
        }
        int tinhTongSLDGV()
        {
            int tong = 0;
            for (int i = 0; i < sl; i++)
            {
                tong += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            };

            return tong;
        }
        int tinhTongTienDGV()
        {
            int tong=0;
            for (int i=0; i<sl; i++)
            {
                tong+=Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            };
            
            return tong;
        }
        string DSSLDGV()
        {
            string sosp="";
            for (int i = 0; i < sl; i++)
            {
                sosp = sosp + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value)+",";
            };

            return sosp;
        }
        int index = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
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

        private void Bill_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Ngatketnoi();
        }
    }
}
