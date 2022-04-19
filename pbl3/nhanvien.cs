﻿using System;
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
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();

        }
        Form form = null;
        private void showform(Form subform)
        {
            if (form != null) form.Close();
            form = subform;
            subform.TopLevel = false;
            subform.FormBorderStyle = FormBorderStyle.None;
            pnxuly.Controls.Add(subform);
            pnxuly.Tag = subform;
            subform.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            showform(new infor());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            showform(new customer());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            showform(new ticket());
        }
    }
}
