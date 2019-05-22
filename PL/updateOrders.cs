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
    public partial class updateOrders : Form
    {
        DataTable Dt;


        BL.orderClass order = new BL.orderClass();
        public updateOrders()
        {
            InitializeComponent();
            
            
        }

        private void updateOrders_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMatShow_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = order.showOrderDit(Convert.ToInt32(invoiceNo.Text));
        }
    }
}
