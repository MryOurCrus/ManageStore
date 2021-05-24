using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System;
namespace Code
{
    class Connections
    {
        //Tạo kết nối với cơ sở dữ liệu
        public SqlConnection cn = new SqlConnection();
        public void Ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = StringConn.connectionString;
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }


        public DataTable XemDL(string sql)
        {
            Ketnoi();

            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;

            // Ngatketnoi();
        }

        //Phương thức truy vấn dữ liệu: Insert, Update, Delete
        public SqlCommand ThucThiDl(string sql)
        {
            Ketnoi();

            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();

            return cm;

            // Ngatketnoi();
        }
    }
}

