using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sale_stations.PL
{
    public partial class fetchCustomer : Form
    {
        BL.CustomerClass CusObject = new BL.CustomerClass();
        bool cheak = false;
        public fetchCustomer()
        {
            InitializeComponent();
            BL.CustomerClass fetch = new BL.CustomerClass();
            
            comboBox1.DataSource = fetch.getCustomerNmae();
            comboBox1.DisplayMember = "customer_name";
            comboBox1.ValueMember = "customer_no";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader SDR = CusObject.getinformation();
            while (SDR.Read())
            {
                if(true)
                textBox1.Text = (SDR["customer_no"].ToString());
                textBox2.Text = (SDR["phone"].ToString());
            }

        }
    }
}
