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
    public partial class receipt : MetroFramework.Forms.MetroForm
    {
        BL.CashBox.GetCash get = new BL.CashBox.GetCash();
        public receipt()
        {
            InitializeComponent();
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = get.GetReceipt();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد طباعة الايصال", "الطباعه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                REPORT.receipt rpt = new REPORT.receipt();
                REPORT.frmReport frm = new REPORT.frmReport();
                //rpt.SetDataSource(dpt.PrintRep(this.txtNo.Text
                //    , this.txtName.Text, Convert.ToDouble(this.txtRep.Text), this.TxtNote.Text));
                Offers ds = new Offers();
                DataRow dr = ds.Tables[1].NewRow();
                dr["id"] = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dr["name"] = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dr["recived"] = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dr["remaning"] = null;
                dr["date"] = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dr["note"] = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                ds.Tables[1].Rows.Add(dr);
                rpt.SetDataSource(ds.Tables[1]);
                frm.crystalReportViewer1.ReportSource = rpt;

                frm.ShowDialog();
                //frm.crystalReportViewer1.PrintReport();
            }
        }
    }
}
