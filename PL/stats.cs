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
    public partial class stats : MetroFramework.Forms.MetroForm
    {
        BL.Dept_class dpt = new BL.Dept_class();
        DataTable Dt;
        public stats()
        {
            InitializeComponent();
            Dt = dpt.sumOfDepts();
            try
            {
                string dptformatted = string.Format("{0:n0}", Convert.ToDouble(Dt.Rows[0][0].ToString()));
                txtSumDpt.Text = dptformatted;
            }
            catch(Exception ex)
            {
                return;
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.listOrders frm = new listOrders();
            frm.ShowDialog();

        }

        private void stats_Load(object sender, EventArgs e)
        {

        }

        
    }
}
