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
            addMaterial.Show();
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
        

        private void button3_Click(object sender, EventArgs e)
        {
            PL.fetchCustomer ftch = new PL.fetchCustomer();
            ftch.ShowDialog();
        }

        private void استعادةنسخةاحياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Resore rst = new Resore();
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

        private void اضافةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.insertCustomer frm = new insertCustomer();
        }

        private void استعلامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.fetchCustomer frm = new fetchCustomer();
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
            PL.Resore frm = new Resore();
            frm.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void استعلامعنالزبائنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fetchCustomer frm = new fetchCustomer();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PL.FetchMatirial ftch = new PL.FetchMatirial();
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
            PL.deptForm frm = new PL.deptForm();
            frm.ShowDialog();
        }

        private void اجماليالديونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.stats frm = new stats();
            frm.ShowDialog();
        }

        private void القوائمالمدفوعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.listDirOrder frm = new listDirOrder();
            frm.ShowDialog();
        }

        private void القوائمالغيرمسددةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.listOrders frm = new listOrders();
            frm.ShowDialog();
        }

        private void اضافةزبونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.insertCustomer frm = new insertCustomer();
            frm.ShowDialog();
        }

        private void الارباحوالخسائرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BL.profits frm = new BL.profits();
            frm.ShowDialog();
        }

        private void تشغيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.countProfit = "run";
            MessageBox.Show("تم تشغيل عملية حساب الارباح", "حساب الارباح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ايقافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.countProfit = "stop";
            MessageBox.Show("تم ايقاف تشغيل عملية حساب الارباح", "حساب الارباح", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void اعداداتالاتصالToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
