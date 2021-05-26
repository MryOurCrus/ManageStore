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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Connections conn = new Connections();

        public static string permission = "";

        private void btLogin_Click(object sender, EventArgs e)
        {

            string ten = userName.Text.Trim();
            string mk = password.Text.Trim();
            string sql = "select * from taikhoan where tentk='" + ten + "' and mk='" + mk + "' ";

            if (ten != "" || mk != "")
            {

                if (conn.XemDL(sql).Rows.Count != 0)
                {
                    Login.permission = Convert.ToString(conn.XemDL("select quyen from taikhoan where tentk='" + ten + "' and mk='" + mk + "' ").Rows[0][0].ToString().Trim());
                    MessageBox.Show(Login.permission);
                    this.Hide();
                    Home frm = new Home();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userName.Text = "";
                    password.Text = "";
                    userName.Focus();
                }

            }

            else
            {
                MessageBox.Show("bạn chưa nhập tài khoản và mật khẩu !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("chắc không?", "trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }


    }
}
