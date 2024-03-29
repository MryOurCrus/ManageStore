﻿using System;
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
            if(Login.permission != "admin")
            {
                userList.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                NhanvienMenubt.Enabled = false;
            }    
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

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Employee();

            frm.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new BillManage();
            frm.Show();
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Bill();
            frm.Show();
        }


        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Customers();
            frm.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ThongKe();
            frm.Show();
        }

        private void userList_Click(object sender, EventArgs e)
        {
            Form frm = new UserMN();
            frm.Show();
        }
    }
}
