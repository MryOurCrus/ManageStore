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
    public partial class PrintBill : Form
    {
        public PrintBill()
        {
            InitializeComponent();
        }
        public void printBill(string tkh, string sdt, string mahd, string masp, string sl, string date, string price)
        {
            label9.Text = tkh;
            label10.Text = sdt;
            label11.Text = mahd;
            label12.Text = masp;
            label13.Text = sl;
            label14.Text = date;
            label15.Text = price;
        }
    }
}
