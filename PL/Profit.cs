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
    public partial class Profit : Form
    {
        BL.Report rpt = new BL.Report();
        public Profit()
        {
            InitializeComponent();
        }

        private void Profit_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource= rpt.get_profits();
        }
    }
}
