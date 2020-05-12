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
    public partial class fetchCustomer : MetroFramework.Forms.MetroForm
    {
        BL.CustomerClass cus =new BL.CustomerClass();
        editCustomer frm = new editCustomer();
        
        public fetchCustomer()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cus.getCustomerInfo();
            

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cus.searchCustomer(searchbox.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                editCustomer edCus = new editCustomer();
                edCus.textBoxNO.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                edCus.textBoxNmae.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                edCus.textBoxPhone.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                edCus.ShowDialog();
                if (edCus.state == "update")
                {
                    this.dataGridView1.DataSource = cus.getCustomerInfo();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    cus.deletCustomer(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            insertCustomer frm = new insertCustomer();
            frm.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PL.customer.AccountStatement account = new customer.AccountStatement(
                this.dataGridView1.CurrentRow.Cells[0].Value.ToString()
                );
            account.ShowDialog();
        }
    }
}
