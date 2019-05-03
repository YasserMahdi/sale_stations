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
    public partial class fetchSupplier : Form
    {
        public fetchSupplier()
        {
            InitializeComponent();
            BL.SupplierClass fetch = new BL.SupplierClass();
            comboBox1.DataSource = fetch.getSupplierNmae();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "NO";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
