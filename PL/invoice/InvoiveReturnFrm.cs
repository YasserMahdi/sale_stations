using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sale_stations.PL.invoice
{
    public partial class InvoiveReturnFrm : MetroFramework.Forms.MetroForm
    {
        BL.orderClass order = new BL.orderClass();
        BL.InvoiceReturnClass ReturnCls = new BL.InvoiceReturnClass();
        public InvoiveReturnFrm()
        {
            InitializeComponent();
        }

        private void InvoiveReturnFrm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = order.showOrderDit(Convert.ToInt32(invID.Text));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {


                        ReturnCls.OrderCancel(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));

                    }
                    ReturnCls.OrderHeadCancel(Convert.ToInt64(this.invID.Text));

                    MessageBox.Show("تم الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dataGridView1.DataSource = order.showOrderDit(Convert.ToInt32(invID.Text));
                    this.txttotal.Text = "0.00";


                }
                else
                {
                    MessageBox.Show("تم الغاء عمليةالحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
