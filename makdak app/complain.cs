using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace makdak_app
{
    public partial class complain : Form
    {
        Timer t = new Timer();
        public complain()
        {
            InitializeComponent();

            t.Interval = 100;
            t.Tick += prog_bar_plus1;
            t.Start();
        }


        private void prog_bar_plus1(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                Program.complainCNT++;
                t.Stop();
                label1.Visible = true; label2.Visible = true;
                label3.Visible = false;
                progressBar1.Visible= false;
            }
            else
            {
                progressBar1.Value++;
            }
        }

    }
}
