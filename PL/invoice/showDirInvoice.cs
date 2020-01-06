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
    public partial class showDirInvoice : MetroFramework.Forms.MetroForm
    {
        BL.orderClass order = new BL.orderClass();
        public showDirInvoice()
        {
            InitializeComponent();
        }

        private void showDirInvoice_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = order.showDirInvoiceDit(Convert.ToInt32(invID.Text));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
 
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                if (e.KeyChar == 8)
                {

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }

            string totalamount = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[4].FormattedValue.ToString() != string.Empty
                                  select (Convert.ToDouble(row.Cells[4].FormattedValue))).Sum().ToString();

            txttotal.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
                    }
    }
}
