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
    public partial class fetchSupplier : Form
    {
        BL.SupplierClass sup = new BL.SupplierClass();

        public fetchSupplier()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = sup.getSupplierlInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = sup.searchSupplier(searchbox.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                sup.deletSupplier(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.dataGridView1.DataSource = sup.getSupplierlInfo();
            }
            else
            {
                MessageBox.Show("تم الغاء عمليةالحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editSupplier edSupp = new editSupplier();
            edSupp.textBoxNO.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            edSupp.textBoxNmae.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            edSupp.textBoxPhone.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            edSupp.textBoxAddress.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            edSupp.ShowDialog();
            if(edSupp.state == "update")
            {
                this.dataGridView1.DataSource = sup.getSupplierlInfo();
            }
        }
    }
}
