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
    public partial class repayment : MetroFramework.Forms.MetroForm
    {
        public string state = "null";
        BL.Dept_class dpt = new BL.Dept_class();
        BL.RepamentClass rep = new BL.RepamentClass();

        public int temp;

        void PrintRep()
        {
            //dpt.PrintRep();
        }
        public repayment()
        {
            InitializeComponent();



        }

        private void btnRep_Click(object sender, EventArgs e)
        {

            try
            {
                if (temp == 0)
                {
                    MessageBox.Show("لا يوجد دين", "السداد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (temp < Convert.ToInt32(txtRep.Text))
                {

                    MessageBox.Show(" تم ادخال مبلغ اكبر من قيمة الدين", "السداد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    rep.processOnDebtRepaymentForInvoice(Convert.ToInt32(txtNo.Text), Convert.ToDouble(txtRep.Text));

                    dpt.repayment(Convert.ToInt32(txtNo.Text), Convert.ToDouble(txtRep.Text), TxtNote.Text);
                    MessageBox.Show(txtName.Text + " تم تحديث حالة الدين الخاصة بـ ", "سداد الديون ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    state = "update";


                }


                try
                {
                    if (MessageBox.Show("هل تريد طباعة الايصال", "الطباعه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        REPORT.receipt rpt = new REPORT.receipt();
                        REPORT.frmReport frm = new REPORT.frmReport();
                        //rpt.SetDataSource(dpt.PrintRep(this.txtNo.Text
                        //    , this.txtName.Text, Convert.ToDouble(this.txtRep.Text), this.TxtNote.Text));
                        Offers ds = new Offers();
                        DataRow dr = ds.Tables[1].NewRow();
                        dr["id"] = dpt.ReceiptNo();
                        dr["name"] = this.txtName.Text.ToString();
                        dr["recived"] = this.txtRep.Text.ToString();
                        dr["remaning"] = dpt.RemainingDebt(txtNo.Text);
                        dr["date"] = dpt.Now();
                        dr["note"] = TxtNote.Text;
                        ds.Tables[1].Rows.Add(dr);
                        rpt.SetDataSource(ds.Tables[1]);
                        frm.crystalReportViewer1.ReportSource = rpt;

                        frm.ShowDialog();
                        //frm.crystalReportViewer1.PrintReport();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtRep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }

        }
    }
}
