using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sale_stations.PL.customer
{
    public partial class AccountStatement : MetroFramework.Forms.MetroForm
    {
        string Customer_id;
        public AccountStatement()
        {
            InitializeComponent();
        }

        public AccountStatement(string customer_id)
        {
            InitializeComponent();
            Customer_id = customer_id;
        }

        private void AccountStatement_Load(object sender, EventArgs e)
        {
            BL.orderClass order = new BL.orderClass();

            this.dataGridView1.DataSource = order.sel_all_invo_with_id(
                Convert.ToInt16(Customer_id)
                );
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PL.showDirInvoice frm = new showDirInvoice(
                "pull"
                , this.dataGridView1.CurrentRow.Cells[4].Value.ToString()
                , this.dataGridView1.CurrentRow.Cells[4].Value.ToString()
                                , this.dataGridView1.CurrentRow.Cells[1].Value.ToString()
                );
            frm.btnPrint.ButtonText = "ارجاع";
            frm.invID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.cusname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.salesman.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
      
           frm.ShowDialog();
        }
    }
}
