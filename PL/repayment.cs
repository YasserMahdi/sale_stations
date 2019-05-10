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
        public repayment()
        {
            InitializeComponent();
            comboBox1.DataSource = dpt.getCustomerName();
            comboBox1.DisplayMember = "customer_name";
            comboBox1.ValueMember = "customer_no";
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("No Item is Selected");
            }
            else
            {
                MessageBox.Show("Item Selected is:" + comboBox1.Text);
            }
        }
    }
}
