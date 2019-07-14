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
    
    public partial class listDirOrder : Form
    {
        BL.orderClass ORD = new BL.orderClass();
        public listDirOrder()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = ORD.listDirOrder();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // text box search 
                DataTable dt = new DataTable();
                dt = ORD.searchDirOrders(txtSearch.Text);
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
