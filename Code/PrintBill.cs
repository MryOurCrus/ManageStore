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
        public void printBill(string tkh, string sdt, string mahd, string masp, string date, string price,string sl)
        {
            label9.Text = tkh;
            label10.Text = sdt;
            label11.Text = mahd;
            label12.Text = masp;
            label14.Text = date;
            label15.Text = price;
            label7.Text = sl;
        }
    }
}
