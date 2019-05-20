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
    public partial class repayment : Form
    {
        BL.Dept_class dpt = new BL.Dept_class();
        listCustomer lst = new listCustomer();
        public repayment()
        {
            InitializeComponent();
            lst.ShowDialog();
            txtNo.Text = lst.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = lst.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            
        }

        private void btnRep_Click(object sender, EventArgs e)
        {

        }
    }
}
