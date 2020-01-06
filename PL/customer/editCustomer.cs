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
    
    public partial class editCustomer : MetroFramework.Forms.MetroForm
    {
        public string state = "null";
        BL.CustomerClass customer = new BL.CustomerClass();
        BL.CustomerClass cus = new BL.CustomerClass();
        public editCustomer()
        {
            InitializeComponent();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            customer.updateCustomerInfo(Convert.ToInt32(textBoxNO.Text), textBoxNmae.Text,textBoxPhone.Text);
            MessageBox.Show(" تم التحديث بنجاح"," التحديث",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            state = "update";
        }
    }
}
