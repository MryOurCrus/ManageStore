using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Code
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(StringConn.connectionString);
        private void btndoimk_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from taikhoan where tentk='" + userName.Text + "'and mk='" + currentPass.Text + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ErrorProvider errorProvider= new ErrorProvider();
 

            if (dt.Rows[0][0].ToString() == "1")
            {
                if (newPass.Text == confirmPass.Text)
                {
                    conn.Open();
                    string daa = "update taikhoan set mk='" + newPass.Text + "' where tentk='" + userName.Text + "' and mk='" + currentPass.Text + "'";
                    SqlCommand cmd = new SqlCommand(daa, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đổi mật khẩu thành công!", "thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    if (newPass.Text == "") { errorProvider.SetError(newPass, "bạn chưa điền mật khẩu"); }
                    if (confirmPass.Text != newPass.Text) { errorProvider.SetError(confirmPass, "mật khẩu nhập lại chưa đúng"); }                 
                }
            }
            else
            {
                errorProvider.SetError(userName, "tên người dùng không đúng");
                errorProvider.SetError(currentPass, "mật khẩu cũ không đúng");
            }

        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
