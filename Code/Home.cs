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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePass frm = new ChangePass();
            frm.Show();
        }

        
    }
}
