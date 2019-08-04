using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sale_stations.BL
{
    public partial class profits : Form
    {
        BL.Report rpt = new Report();
        public profits()
        {
            InitializeComponent();
        }

        private void profits_Load(object sender, EventArgs e)
        {
            this.bunifuCustomDataGrid1.DataSource = rpt.get_profits();

        }
    }
}
