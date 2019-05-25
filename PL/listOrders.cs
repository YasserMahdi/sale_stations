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
            this.dataGridView1.DataSource = order.serachOrders();
            txtSearch.Focus();


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // text box search 
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
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PL.updateOrders frm = new updateOrders();
                DataTable Dt = order.showOrderinfo(this.dataGridView1.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                try
                {
                    frm.invoiceNo.Text = Dt.Rows[0][0].ToString();
                    frm.cusname.Text = Dt.Rows[0][6].ToString();
                    frm.txtDate.Text = Dt.Rows[0][2].ToString();
                    frm.txttotal.Text = Dt.Rows[0][3].ToString();
                    frm.salesman.Text = Dt.Rows[0][4].ToString();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nهذه الفاتورة لا تحتوي على مواد مباعة ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }
    }
}
