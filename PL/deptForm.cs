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
        public deptForm()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = dpt.getDeptInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PL.repayment rpt = new PL.repayment();
            rpt.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PL.newDept dpt = new PL.newDept();
            dpt.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
