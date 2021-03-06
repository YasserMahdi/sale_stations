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
    public partial class insertCustomer : Form
    {
        BL.CustomerClass insCus = new BL.CustomerClass();
        public insertCustomer()
        {
            InitializeComponent();
            textBoxNO.Text = insCus.getCustomerID().Rows[0][0].ToString();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
         
                insCus.insertCus(Convert.ToInt32(textBoxNO.Text), textBoxNmae.Text, textBoxPhone.Text);
                MessageBox.Show("تمت الاضافة بناح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNO.Clear();
                textBoxNmae.Clear();
                textBoxPhone.Clear();
                textBoxNO.Text = insCus.getCustomerID().Rows[0][0].ToString();
            }
            catch (Exception sqlEx)
            {
                MessageBox.Show("الرجاء ادخال معلومات صحيحة", "عملية الاضافة" + sqlEx.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            

        }
    }
}
