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
    public partial class listCustomer : MetroFramework.Forms.MetroForm
    {
        BL.CustomerClass cus = new BL.CustomerClass();
        public listCustomer()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cus.getCustomerInfo();
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

        private void listCustomer_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                PL.orderFrm frm = PL.orderFrm.GetInstance();
                //this.cusNo.Text = cus.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.TxtCustomerID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.cusname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.phone.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception)
            {
                return;
            }
            this.Close();
        }

        private void listCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
                
        }

        private void listCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            return;
        }
    }
}
