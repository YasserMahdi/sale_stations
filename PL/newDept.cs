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
    public partial class newDept : Form
    {
        BL.Dept_class dpt = new BL.Dept_class();
        public newDept()
        {
            InitializeComponent();
            comboBox1.DataSource = dpt.getCustomerName();
            comboBox1.DisplayMember = "customer_name";
            comboBox1.ValueMember = "customer_no";


        }
    }
}
