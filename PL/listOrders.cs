using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sale_stations.PL
{
    public partial class listOrders : Form
    {
        BL.orderClass order = new BL.orderClass();
        public listOrders()
        {

            InitializeComponent();
            this.button3.Enabled = false;
            this.dataGridView1.DataSource = order.serachOrders();
            txtSearch.Focus();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = order.seach_single_oerder(txtSearch.Text);
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.dataGridView1.DataSource= order.getNotCashedOrder();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.dataGridView1.DataSource = order.serachOrders();
            
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.button3.Enabled = true;
        }
    }
}
