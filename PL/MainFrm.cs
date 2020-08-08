using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.PL
{
    public partial class MainFrm : MetroFramework.Forms.MetroForm
    {
        

        
        public MainFrm()
        {
            //Thread t = new Thread( new ThreadStart(Loading));
            //t.Start();
            InitializeComponent();
            //DataBaseLoad();
            //t.Abort();
        }

        //private void Loading()
        //{
        //    SplashScreen frm = new SplashScreen();
        //    Application.Run(frm);
        //}

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            PL.orderFrm frm = PL.orderFrm.GetInstance();
            frm.ShowDialog();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            PL.fetchCustomer frm = new PL.fetchCustomer();
            frm.ShowDialog();
        }

        private void ImgBtnInventory_Click(object sender, EventArgs e)
        {
            PL.stock.Category frm = new stock.Category();
            //PL.FetchMatirial frm = new FetchMatirial();
            frm.ShowDialog();
        }

        private void BtnDebt_Click(object sender, EventArgs e)
        {
            PL.deptForm frm = new deptForm();
            frm.ShowDialog();
        }

        private void Btnoffer_Click(object sender, EventArgs e)
        {
            PL.stock.Offer frm = new stock.Offer();
            frm.ShowDialog();
        }

        private void BtnWarehouse_Click(object sender, EventArgs e)
        {
            PL.stock.Warehouse_Entry frm = new stock.Warehouse_Entry();
            frm.ShowDialog();
        }

        private void اجماليالديونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.stats frm = new stats();
            frm.ShowDialog();
        }

        private void اضافةزبونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.insertCustomer frm = new insertCustomer();
            frm.ShowDialog();
        }

        private void استعلامعنالزبائنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.fetchCustomer frm = new fetchCustomer();
            frm.ShowDialog();
        }

        private void الايصالاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.receipt frm = new receipt();
            frm.ShowDialog();
        }

        private void القيودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.CashBox.Box frm = new CashBox.Box();
            frm.ShowDialog();
        }

        

        private void انشاءنسخةاحتياToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.createBackup frm = new createBackup();
            frm.ShowDialog();
        }

        private void استعادةالنسخةالاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Resore frm = new Resore();
            frm.ShowDialog();
        }

        private void BtnStatistic_Click(object sender, EventArgs e)
        {
            PL.FetchMatirial MissingItems = new FetchMatirial("Missing");
            MissingItems.ShowDialog();
        }

        private void Btnlately_Click(object sender, EventArgs e)
        {
            PL.invoice.InvoiceReturn frm = new invoice.InvoiceReturn();
            frm.ShowDialog();
        }

        private void القوائمالمدفوعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.listOrders frm = new listOrders();
            frm.ShowDialog();
        }
    }
}
