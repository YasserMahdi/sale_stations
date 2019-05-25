using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sale_stations.PL
{
    public partial class stats : Form
    {
        public stats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.deptForm frm = new deptForm();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.listOrders frm = new listOrders();
            frm.ShowDialog();
        }
    }
}
