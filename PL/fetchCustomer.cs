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
    public partial class fetchCustomer : Form
    {
        BL.CustomerClass cus =new BL.CustomerClass();
        editCustomer frm = new editCustomer();
        
        public fetchCustomer()
        {
            InitializeComponent();

        }


        private void searchbox_OnValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cus.searchCustomer(searchbox.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            insertCustomer frm = new insertCustomer();
            frm.ShowDialog();
            this.dataGridView1.DataSource = cus.getCustomerInfo();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    cus.deleteCustomer(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dataGridView1.DataSource = cus.getCustomerInfo();
                }
                else
                {
                    MessageBox.Show("تم الغاء عمليةالحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PL.editCustomer frm = new editCustomer();
            frm.ShowDialog();
            this.dataGridView1.DataSource = cus.getCustomerInfo();
        }

        private void fetchCustomer_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = cus.getCustomerInfo();
        }
    }
}
