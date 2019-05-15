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
    public partial class MainForm : Form
    {
        public MainForm()
        {
          
            InitializeComponent();
            
            
        }

        private void btnstore_Click(object sender, EventArgs e)
        {
            PL.insertMaterial addMaterial = new PL.insertMaterial();
            addMaterial.ShowDialog();
        }

        private void btnsuplier_Click(object sender, EventArgs e)
        {
            PL.suppliers suplier = new PL.suppliers();
            suplier.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.insertCustomer insCus = new PL.insertCustomer();
            insCus.ShowDialog();
        }

        private void btndept_Click(object sender, EventArgs e)
        {
            PL.deptForm dpt = new PL.deptForm();
            dpt.ShowDialog();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ستكون التقارير متاحه في الاصدارات القادمة", "التقارير", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuppilerQuerye_Click(object sender, EventArgs e)
        {
            PL.fetchSupplier ftch = new PL.fetchSupplier();
            ftch.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.fetchCustomer ftch = new PL.fetchCustomer();
            ftch.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PL.FetchMatirial ftch = new PL.FetchMatirial();
            ftch.ShowDialog();
           
        }

        private void btninvoive_Click(object sender, EventArgs e)
        {
            PL.orderFrm ord = new PL.orderFrm();
            ord.Show();
        }

        private void استعادةنسخةاحياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.login logFrm = new PL.login();
            logFrm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
