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
    public partial class showInvoice : Form
    {
        BL.orderClass order = new BL.orderClass();
        public showInvoice()
        {
            InitializeComponent();
        }

        private void showInvoice_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = order.showOrderDit(Convert.ToInt32(invID.Text));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                REPORT.product_minu rpt = new REPORT.product_minu();
                REPORT.frmReport frm = new REPORT.frmReport();
                rpt.SetDataSource(order.getOrdrrDetails(Convert.ToInt32(invID.Text)));
                frm.crystalReportViewer1.ReportSource = rpt;
                //frm.ShowDialog();
                frm.crystalReportViewer1.PrintReport();



                //frm.crystalReportViewer1.PrintReport();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
