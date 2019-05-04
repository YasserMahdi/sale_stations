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
    public partial class suppliers : Form
    {
        BL.SupplierClass insertSpr = new BL.SupplierClass();
        public suppliers()
        {
            InitializeComponent();
        }

        private void suppliers_Load(object sender, EventArgs e)
        {

        }

        private void btnSavaSupplier_Click(object sender, EventArgs e)
        {
  
            try
            {
                insertSpr.insertSpr(Int32.Parse(supplierTxtBox.Text), txtName.Text, txtPhone.Text, txtAddress.Text);
                MessageBox.Show("تمت الاضافة بناح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception sqlEx)
            {
                MessageBox.Show("الرجاء ادخال معلومات صحيحة", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
    }
}
