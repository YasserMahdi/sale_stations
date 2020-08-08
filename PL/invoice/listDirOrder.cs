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
    
    public partial class listDirOrder : MetroFramework.Forms.MetroForm
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PL.showDirInvoice frm = new showDirInvoice();
            frm.invID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.cusname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.salesman.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txttotal.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.ShowDialog();
        }

        private void listDirOrder_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
