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
    public partial class showDeptHistory : MetroFramework.Forms.MetroForm
    {
        BL.Dept_class dpt = new BL.Dept_class();
        BL.orderClass order = new BL.orderClass();
        public showDeptHistory()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                PL.showInvoice frm = new showInvoice();
                //Pass two variables   int customerid  and invoice id
                DataTable Dt = order.showOrderinfo(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[4].Value.ToString()));
                try
                {
                    frm.invID.Text = Dt.Rows[0][0].ToString();
                    frm.cusname.Text = Dt.Rows[0][6].ToString();
                    frm.bunifuDatepicker1.Value = Convert.ToDateTime(Dt.Rows[0][2]);
                    frm.txttotal.Text = string.Format("{0:n}", Convert.ToInt32(Dt.Rows[0][3]));
                    frm.salesman.Text = Dt.Rows[0][4].ToString();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nهذه الفاتورة لا تحتوي على مواد مباعة ");
                }
            }
            catch (Exception ex)
            {
            }
                MessageBox.Show(this.dataGridView1.CurrentRow.Cells[4].Value.ToString()
                    ,"الملاحظات",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
