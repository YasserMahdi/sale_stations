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
    public partial class FetchMatirial : Form
    {
        BL.MaterialClass mtr = new BL.MaterialClass();
        public FetchMatirial()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = mtr.getMatirialInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    mtr.deletMatirials(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dataGridView1.DataSource = mtr.getMatirialInfo();
                }
                else
                {
                    MessageBox.Show("تم الغاء عمليةالحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PL.insertMaterial frm = new PL.insertMaterial();

                frm.state = "update";
                frm.noMtr.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.nameMtr.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.buyCost.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.saleCost.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.qte.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.Text = "تحديث المنتوج : " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.button1.Text = "تحديث";
                frm.ShowDialog();
                if (frm.isUpdate == "true")
                {
                    this.dataGridView1.DataSource = mtr.getMatirialInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            PL.insertMaterial frm = new insertMaterial();
            frm.ShowDialog();
            if(frm.caseOf == "insert")
            {
                this.dataGridView1.DataSource = mtr.getMatirialInfo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                REPORT.printMaterials rep = new REPORT.printMaterials();
                REPORT.frmReport frm = new REPORT.frmReport();
                rep.SetDataSource(mtr.printMaterials());
                frm.crystalReportViewer1.ReportSource = rep;
                //frm.Show();
                frm.crystalReportViewer1.PrintReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textSearch_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
