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
            ChangePass frm = new ChangePass();
            frm.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProductManage frm = new ProductManage();
            frm.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Bill frm = new Bill();
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Customer();

            frm.Show();
        }
    }
}
