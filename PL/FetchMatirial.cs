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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = mtr.searchProduct(textSearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                mtr.deletMatirials(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف", "عملية الحذف",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.dataGridView1.DataSource = mtr.getMatirialInfo();
            }
            else
            {
                MessageBox.Show("تم الغاء عمليةالحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.insertMaterial frm = new PL.insertMaterial();

            frm.state = "update";
            frm.noMtr.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.nameMtr.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.buyCost.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.saleCost.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.qte.Text= this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تحديث المنتوج : " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.button1.Text = "تحديث";
            this.dataGridView1.DataSource = mtr.getMatirialInfo();


            frm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
