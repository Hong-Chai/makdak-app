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
    public partial class Admin : Form
    {
        int curORD = -1;
        public Admin()
        {
            InitializeComponent();
            rerfr();
        }

        private void rerfr()
        {
            stat_compain.Text = Convert.ToString(Program.complainCNT);
            stat_today.Text = Convert.ToString(Program.cntORD);
            if (Program.cntORD != 0) {
                stat_new.Text = "";
                stat_inwork.Text = "";
                for (int i = 0; i < Program.cntORD; i++)
                {
                   if (Program.ord[i][1] == 0)
                    {
                        stat_new.Text+= Program.ord[i][0] + " ";
                    }
                   else if (Program.ord[i][1] == 1) { 
                        stat_inwork.Text+= Program.ord[i][0] +" ";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rerfr();
        }

        private void ord_find_Click(object sender, EventArgs e)
        {
            if (ord_choise.Value < Program.cntORD && ord_choise.Value >= 0)
            {
                burger1.Value = Program.ord[Convert.ToInt32(ord_choise.Value)][2];
                burger2.Value = Program.ord[Convert.ToInt32(ord_choise.Value)][3];
                burger3.Value = Program.ord[Convert.ToInt32(ord_choise.Value)][4];
                potato.Value = Program.ord[Convert.ToInt32(ord_choise.Value)][5];
                drink1.Value = Program.ord[Convert.ToInt32(ord_choise.Value)][6];
                drink2.Value = Program.ord[Convert.ToInt32(ord_choise.Value)][7];
                ord_box.Visible = true;
                curORD = Program.ord[Convert.ToInt32(ord_choise.Value)][0];
                if (Program.ord[curORD][1] == 0)
                {
                    radio_new.Checked = true;
                }
                else if (Program.ord[curORD][1] == 1)
                {
                    radio_work.Checked = true;
                }
                else
                {
                    radio_arch.Checked = true;
                }
            }
            else
            {
                ord_box.Visible = false;
            }

        }

        private void but_change_mode_Click(object sender, EventArgs e)
        {
            if(radio_new.Checked)
            {
                Program.ord[curORD][1] = 0;
            }
            else if(radio_work.Checked)
            {
                Program.ord[curORD][1] = 1;
            }
            else
            {
                Program.ord[curORD][1] = 2;
            }
        }
    }
}
