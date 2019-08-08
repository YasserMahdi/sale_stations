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
    public partial class listCustomer : Form
    {
        BL.CustomerClass cus = new BL.CustomerClass();
        public string State;
        public listCustomer()
        {
            InitializeComponent();

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            {
                DataTable dt = new DataTable();
                dt = cus.searchCustomer(searchbox.Text);
                this.dataGridView1.DataSource = dt;
            }
        }

        private void listCustomer_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.State = "sel";
            this.Close();
        }



        private void listCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            return;
        }

        private void listCustomer_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cus.getCustomerInfo();
        }
    }
}
