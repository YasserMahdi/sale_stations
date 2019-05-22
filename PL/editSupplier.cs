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
    public partial class editSupplier : Form
    {
        public string state = "null";
        BL.SupplierClass supp = new BL.SupplierClass();
        public editSupplier()
        {
            InitializeComponent();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            supp.updateSupplierInfo(Convert.ToInt32(textBoxNO.Text),textBoxNmae.Text,textBoxPhone.Text,textBoxAddress.Text);
            MessageBox.Show("تم التحديث بنجاح", "التحديث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.textBoxNO.Clear();
            this.textBoxNmae.Clear();
            this.textBoxPhone.Clear();
            this.textBoxAddress.Clear();


            state = "update";
        }
    }
}
