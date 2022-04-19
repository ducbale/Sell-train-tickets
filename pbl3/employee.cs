using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
            label1.Text = "duong tri duc";
        }

       

        private void ticket_Click(object sender, EventArgs e)
        {
            Cticket n = new Cticket();
            n.Show();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            customer f = new customer();
            f.Show();
        }

        private void infor_Click(object sender, EventArgs e)
        {
            account f = new account();
            f.Show();
        }
    }
}
