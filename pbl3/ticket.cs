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
    public partial class ticket : Form
    {
        public ticket()
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
            panelticket.Controls.Add(subform);
            panelticket.Tag = subform;
            subform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showform(new addticket());
        }
    }
}
