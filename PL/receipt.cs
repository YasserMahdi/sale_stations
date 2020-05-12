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
    public partial class receipt : MetroFramework.Forms.MetroForm
    {
        BL.CashBox.GetCash get = new BL.CashBox.GetCash();
        public receipt()
        {
            InitializeComponent();
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = get.GetReceipt();
        }
    }
}
