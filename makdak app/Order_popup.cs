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
    public partial class Order_popup : Form
    {
        public Order_popup()
        {
            InitializeComponent();
            labelcnt.Text = "0"+Convert.ToString(Program.cntORD - 1);
        }
    }
}
