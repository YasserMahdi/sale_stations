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
        BL.SupplierClass sup = new BL.SupplierClass();

        public fetchSupplier()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = sup.getSupplierlInfo();
        }
    }
}
