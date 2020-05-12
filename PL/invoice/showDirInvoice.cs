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
        Int32 temp;
        double OldPrice;
        double debt;
        string CusId;
        BL.orderClass order = new BL.orderClass();
        BL.CustomerClass cusobject = new BL.CustomerClass();
        string state;
        public showDirInvoice()
        {
            InitializeComponent();
        }

        public showDirInvoice(string state,string Total,string debt,string CusId)
        {
            InitializeComponent();
            this.state = state;
            this.txttotal.Text = Total;
            this.OldPrice = Convert.ToDouble(Total);
            this.debt = Convert.ToDouble(debt);
            this.CusId = CusId;
        }

        private void showDirInvoice_Load(object sender, EventArgs e)
        {

            this.dataGridView1.DataSource = order.showOrderDit(Convert.ToInt32(invID.Text));

            string totalamount = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[3].FormattedValue.ToString() != string.Empty
                                  select (Convert.ToDouble(row.Cells[3].FormattedValue))).Sum().ToString();

            txttotal.Text = totalamount;
            temp = Convert.ToInt32(txttotal.Text);
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

            if (this.dataGridView1.SelectedRows.Count >= 0)
            {
                if (e.KeyChar == 8)
                {

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }

            string totalamount = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[3].FormattedValue.ToString() != string.Empty
                                  select (Convert.ToDouble(row.Cells[3].FormattedValue))).Sum().ToString();

            txttotal.Text = totalamount;
            temp = Convert.ToInt32(txttotal.Text);
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //int lasto = Convert.ToInt32(order.getLastInvoiceForPrint().Rows[0][0]);

            //DataTable DtName = cusobject.gitCustomerIdByName(cusname.Text);
            //int lastN = Convert.ToInt32(DtName.Rows[0][0]);

            //REPORT.printDirSale rpt = new REPORT.printDirSale();
            //REPORT.frmReport frm = new REPORT.frmReport();
            //rpt.SetDataSource(order.getDirOrdrrDetails(lasto, lastN));
            //frm.crystalReportViewer1.ReportSource = rpt;
            //frm.ShowDialog();
            //frm.crystalReportViewer1.PrintReport();
            if (state == "pull")
            {
                try
                {
                    BL.CashBox.retrive.order RetriveOrder = new BL.CashBox.retrive.order();
                    RetriveOrder.DeleteItem(this.invID.Text);

                    BL.orderClass save = new BL.orderClass();

                    // cheack values is set or not 
                    if (invID.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال رقم القائمة", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (salesman.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال اسم البائع", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cusname.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال معلومات الزبون", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dataGridView1.Rows.Count < 1)
                    {
                        MessageBox.Show("الرجاء ادخال المواد", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        // get new ID for New Customer
                       // DataTable DtName = cusobject.getCustomerID();
                        

                        // s informations of the head of invoicev
                        save.update_order(this.invID.Text, Convert.ToDouble(temp),OldPrice - debt,CusId,debt);

                        //ReSave products info 

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {


                            save.add_order_detail(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(invID.Text),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString()));

                        }
                        int FinalFunds = temp - Convert.ToInt16(txttotal.Text);




                    }

                    MessageBox.Show("الارجاع", "تم الارجاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message," " ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    REPORT.product_minu rpt = new REPORT.product_minu();
                    REPORT.frmReport frm = new REPORT.frmReport();
                    rpt.SetDataSource(order.getOrdrrDetails(Convert.ToInt32(invID.Text)));
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    //frm.crystalReportViewer1.PrintReport();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            string totalamount = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[3].FormattedValue.ToString() != string.Empty
                                  select (Convert.ToDouble(row.Cells[3].FormattedValue))).Sum().ToString();

            txttotal.Text = totalamount;
            temp = Convert.ToInt32(txttotal.Text);
        }
    }
}
