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
    public partial class Order : Form
    {


        public Order()
        {
            InitializeComponent();

        }

        private void joke_but_Click(object sender, EventArgs e)
        {
            joke_but.Text = "ЖРИ ЧТО ДАЮТ!!!";
            joke_but.Enabled = false;
        }

        private void ok_but_Click(object sender, EventArgs e)
        {
            List<int> a = new List<int>();
            a.Add(Program.cntORD);
            a.Add(0);
            a.Add(Convert.ToInt32(burger1.Value));
            a.Add(Convert.ToInt32(burger2.Value));
            a.Add(Convert.ToInt32(burger3.Value));
            a.Add(Convert.ToInt32(potato.Value));
            a.Add(Convert.ToInt32(drink1.Value));
            a.Add(Convert.ToInt32(drink2.Value));
            Program.ord.Add(a);
            Program.cntORD++;
            Order_popup pop =new Order_popup();
            pop.ShowDialog();
        }
    }
}
