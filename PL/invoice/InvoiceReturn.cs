using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sale_stations.PL.invoice
{
    public partial class InvoiceReturn : MetroFramework.Forms.MetroForm
    {
        BL.InvoiceReturnClass ReturnCls = new BL.InvoiceReturnClass();
        BL.orderClass order = new BL.orderClass();
        public InvoiceReturn()
        {
            InitializeComponent();
        }

        private void InvoiceReturn_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource=ReturnCls.ShowLast10Invoice();
            }
            catch
            {

            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null)
            {
                //say you want to do a search when user types 3 or more chars
                if (t.Text.Length >= 3)
                {
                    this.dataGridView1.DataSource = ReturnCls.Search(this.TxtSearch.Text);


                }
            }
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                PL.invoice.InvoiveReturnFrm frm = new PL.invoice.InvoiveReturnFrm();
                //Pass two variables   int customerid  and invoice id
                //DataTable Dt = ReturnCls.showOrderinfoForReturn(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[1].Value), Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                try
                {
                    frm.invID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    frm.cusname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    frm.bunifuDatepicker1.Value = Convert.ToDateTime(
                        this.dataGridView1.CurrentRow.Cells[3].Value
                        );
                    frm.txttotal.Text = string.Format("{0:n}", Convert.ToDouble(
                        this.dataGridView1.CurrentRow.Cells[4].Value
                        ));
                    frm.salesman.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nهذه الفاتورة لا تحتوي على مواد مباعة ");
                }
                frm.ShowDialog();

                try
                {
                    this.dataGridView1.DataSource = ReturnCls.ShowLast10Invoice();
                }
                catch
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
