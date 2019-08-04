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
    public partial class deptForm : Form
    {
        BL.Dept_class dpt = new BL.Dept_class();
        BL.CustomerClass cus = new BL.CustomerClass();


        public deptForm()
        {
            InitializeComponent();
            
            
            this.dataGridView1.DataSource = dpt.getDeptInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                PL.repayment rpt = new PL.repayment();
                rpt.txtNo.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                rpt.txtName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                rpt.textDept.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                rpt.ShowDialog();
                if (rpt.state == "update")
                {

                    this.dataGridView1.DataSource = dpt.getDeptInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                PL.newDept frm = new PL.newDept();
                PL.listCustomer lstfrm = new listCustomer();
                lstfrm.dataGridView1.DataSource = cus.getCustomerInfo();
                lstfrm.ShowDialog();
                frm.txtNo.Text = lstfrm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtName.Text = lstfrm.dataGridView1.CurrentRow.Cells[1].Value.ToString();

                frm.ShowDialog();
                if (frm.state == "update")
                {
                    // DataRow query = from detQuery in dpt.getDeptInfo().AsEnumerable() where detQuery.Field(string)()


                    this.dataGridView1.DataSource = dpt.getDeptInfo();
                }
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
            try
            {
                if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    dpt.deletCustomerDepts(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dataGridView1.DataSource = dpt.getDeptInfo();


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

        private void deptForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dpt.searchCusForDeptList(txtSearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                showDeptHistory showDpt = new showDeptHistory();
                showDpt.dataGridView1.DataSource = dpt.getDeptHistory(Convert.ToInt32( this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                showDpt.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n \n لا يوجد ديون","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnPrintDeptInfo_Click(object sender, EventArgs e)
        {
            try
            {
                REPORT.printDeptInfo rep = new REPORT.printDeptInfo();
                REPORT.frmReport frm = new REPORT.frmReport();
                rep.SetDataSource( dpt.printDeptInfo(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value)));
                frm.crystalReportViewer1.ReportSource = rep;
                //frm.Show();
               frm.crystalReportViewer1.PrintReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                REPORT.printAllDebt rep = new REPORT.printAllDebt();
                REPORT.frmReport frm = new REPORT.frmReport();
                rep.SetDataSource(dpt.printALLdebt());
                frm.crystalReportViewer1.ReportSource = rep;
                //frm.Show();
                frm.crystalReportViewer1.PrintReport();

            }
            catch (Exception ex)
            {
                return;
            }
            
        }
    }
}
