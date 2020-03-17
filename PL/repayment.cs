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
                dpt.repayment(Convert.ToInt32(txtNo.Text), Convert.ToDouble(txtRep.Text), TxtNote.Text);
                MessageBox.Show(txtName.Text + " تم تحديث حالة الدين الخاصة بـ ", "سداد الديون ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                state = "update";
                //if (MessageBox.Show("تمت عملية السداد بنجاح هل تريد طباعة وصل قبض", "الطباعه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{

                //}

                try
                {
                    if (MessageBox.Show("تم حفظ الفاتورة و الدين هل تريد طباعة الفاتورة", "الطباعه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        REPORT.Pay rpt = new REPORT.Pay();
                        REPORT.frmReport frm = new REPORT.frmReport();
                        rpt.SetDataSource(dpt.PrintRep(this.txtNo.Text
                            , this.txtName.Text, Convert.ToDouble(this.txtRep.Text), this.TxtNote.Text));
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
