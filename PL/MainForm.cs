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

  
        private void button2_Click(object sender, EventArgs e)
        {
            PL.insertCustomer insCus = new PL.insertCustomer();
            insCus.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.fetchCustomer ftch = new PL.fetchCustomer();
            ftch.ShowDialog();
        }

        private void استعادةنسخةاحياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Recovery rst = new Recovery();
            rst.ShowDialog();
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

        private void btnqueryinvoice_Click(object sender, EventArgs e)
        {
            PL.listOrders frm = new listOrders();
            frm.Show();
        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.createBackup frm = new createBackup();
            frm.ShowDialog();
        }



        private void انشاءنسخةاحتياToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.createBackup frm = new createBackup();
            frm.ShowDialog();
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void استعادةالنسخةالاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Recovery frm = new Recovery();
            frm.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            PL.fetchCustomer ftch = new PL.fetchCustomer();
            ftch.Show();
        }

        private void btnInvoive_Click_1(object sender, EventArgs e)
        {
            PL.orderFrm ord = new PL.orderFrm();

            ord.Show();
        }

        private void bntReport_Click(object sender, EventArgs e)
        {
            PL.listOrders frm = new listOrders();
            frm.ShowDialog();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            PL.listOrders frm = new listOrders();
            frm.ShowDialog();
        }

        private void الرئيسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Profit frm = new Profit();
            frm.ShowDialog();
        }

        private void connectionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.config frm = new config();
            frm.ShowDialog();
        }
    }
}
