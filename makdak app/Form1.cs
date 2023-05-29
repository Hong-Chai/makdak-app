using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makdak_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pass_confirm_but_Click(object sender, EventArgs e)
        {
            if (pass_input.Text == "20000rub")
            {
                groupBox_admin.Visible = true;
            }
        }

        private void leave_rus_Click(object sender, EventArgs e)
        {
            logo.Image = makdak_app.Properties.Resources.vkusnologo;
            leave_rus.Text = "-- NO DATA --";
            leave_rus.Enabled = false;
        }

        private void complainZINA_but_Click(object sender, EventArgs e)
        {
             complain cmp = new complain();
            cmp.Show();
        }

        private void order_but_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void admin_men_but_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
