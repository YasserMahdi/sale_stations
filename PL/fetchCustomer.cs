﻿using System;
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
    public partial class fetchCustomer : Form
    {
        BL.CustomerClass cus =new BL.CustomerClass();
        public fetchCustomer()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cus.getCustomerInfo();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cus.searchCustomer(searchbox.Text);
            this.dataGridView1.DataSource = dt;
        }
    }
}
