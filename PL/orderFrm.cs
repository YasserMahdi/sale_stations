using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sale_stations.PL
{
    public partial class orderFrm : Form
    {

        BL.orderClass ord = new BL.orderClass();
        BL.CustomerClass cusobject = new BL.CustomerClass();
        DataTable dt = new DataTable();
        string totalamount;
        string rRemaining;
        DataTable SmashingData;



        void calculateAmount()
        {
            if (txtQuantity.Text != string.Empty && txtSellingPrice.Text != string.Empty)

                try
                {

                    txtTotalPrice.Text = string.Format("{0:n0}", Convert.ToDouble(((Convert.ToDouble(txtSellingPrice.Text) * Convert.ToInt32(txtQuantity.Text))).ToString()));
                }
                catch (Exception ex)
                {
                    return;
                }
        }

        void clearBoxes()
        {
            txtPurchasingPrice.Clear();
            txtServiceName.Clear();
            txtSellingPrice.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();
        }

        void createColumns()
        {
            dt.Columns.Add("Column1"); // 
            dt.Columns.Add("Column2");// 
            dt.Columns.Add("Column3");//   
            dt.Columns.Add("Column4");//  
            dt.Columns.Add("Column5");//    


            this.dataGridView1.DataSource = dt;
        }


        void resizeDVGcolumns()
        {
            this.dataGridView1.RowHeadersWidth = 90;
            this.dataGridView1.Columns[0].Width = 170;
            this.dataGridView1.Columns[1].Width = 400;
            //this.dataGridView1.Columns["Column1"].Width = 160;



        }


        public orderFrm()
        {
            InitializeComponent();


        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtServiceName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPurchasingPrice.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSellingPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtQuantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                txtQuantity.Focus();
            }
            catch
            {
                return;
            }
        }

        // for summation total price after deleting one Row or more from dataGrindView
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            txttotal.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[4].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //get the last order

            int lasto = Convert.ToInt32(ord.getLastInvoiceForPrint().Rows[0][0]);

          
                //try
                //{
                //   REPORT.product_minu rpt = new REPORT.product_minu();
                //    REPORT.frmReport frm = new REPORT.frmReport();
                //    rpt.SetDataSource(ord.getOrdrrDetails(lasto));
                //    frm.crystalReportViewer1.ReportSource = rpt;

                //    frm.ShowDialog();
                //    frm.crystalReportViewer1.PrintReport();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

            
           
               
               
            


        }


        private void button1_Click(object sender, EventArgs e)
        {

            listCustomer cus = new listCustomer();
            cus.ShowDialog();
            try
            {

                //this.cusNo.Text = cus.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.cusname.Text = cus.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.phone.Text = cus.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception)
            {
                return;
            }


        }

        private void orderFrm_Load(object sender, EventArgs e)
        {
            invoiceNo.Text = ord.getSequenceInvoice().Rows[0][0].ToString();
            createColumns();
            this.bunifuDatepicker1.Value = DateTime.Now;
            resizeDVGcolumns();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            try
            {
                this.invoiceNo.Text = null; ;
                this.salesman.Text = null;
                //this.cusNo.Clear();
                this.cusname.Text = null;
                this.phone.Text = null;
                this.txttotal.Clear();
                this.dataGridView1.DataSource = null;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("الرجاء غلق النافذه و فتحها مرة اخرى");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            invoiceNo.Text = ord.getSequenceInvoice().Rows[0][0].ToString();

            // cheack values is set or not 
            if (invoiceNo.Text == string.Empty)
            {
                MessageBox.Show("Receipt Number does not exist", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (salesman.Text == string.Empty)
            {
                MessageBox.Show("Enter the name of the seller", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cusname.Text == string.Empty)
            {
                MessageBox.Show("Enter the customer name", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("The menu is empty", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Check the customer name if it already exists
                DataTable Dt = cusobject.getCustomerName(cusname.Text);
                if (Dt.Rows.Count < 1)
                {
                    if (MessageBox.Show("This customer does not exist, do you want to store his information", " Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        // get new ID for New Customer
                        DataTable DtName = cusobject.getCustomerID();
                        cusobject.insertCus(Convert.ToInt32(DtName.Rows[0][0]), cusname.Text, phone.Text);


                        // save informations of the head of invoicev
                        ord.add_order(Convert.ToInt32(invoiceNo.Text),cusname.Text,Convert.ToDouble(txttotal.Text),salesman.Text);

                        //save products info 

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {


                            ord.add_order_detail(Convert.ToInt32(invoiceNo.Text), 
                                Convert.ToString(dataGridView1.Rows[i].Cells[0].Value),
                                Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value), 
                                Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value), 
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                                Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value));

                        }


                        MessageBox.Show("Saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Operation canceled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                // if there is no debt on the invoice 
                else
                {
                    // If the client name already exists, fetch its ID
                    DataTable DtName = cusobject.gitCustomerIdByName(cusname.Text);

                    //To store or modify the phone number
                    cusobject.updateOrinsertCustomerPhoneNumber(Convert.ToInt32(DtName.Rows[0][0]), phone.Text);


                    // save informations of the head of invoice

                    ord.add_order(Convert.ToInt32(invoiceNo.Text), cusname.Text, Convert.ToDouble(txttotal.Text), salesman.Text);



                    //save products info 
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {



                        ord.add_order_detail(Convert.ToInt32(invoiceNo.Text),
                            Convert.ToString(dataGridView1.Rows[i].Cells[0].Value),
                            Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value),
                            Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value),
                            Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                            Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value));


                    }

                    MessageBox.Show("Saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


            }


            invoiceNo.Text = ord.getSequenceInvoice().Rows[0][0].ToString();
            BL.Report rpt = new BL.Report();
            double Monthly_disbursements = 0.0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                Monthly_disbursements += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) *
                    Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

            }

            rpt.set_new_month();
            DataTable lastMonth = rpt.sel_last_month();
            rpt.set_Revenue(Convert.ToInt32(lastMonth.Rows[0][0]), Convert.ToDouble(totalamount));
            rpt.set_Disbursements(Convert.ToInt32(lastMonth.Rows[0][0]), Monthly_disbursements);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtServiceName.Text)
                        {
                            MessageBox.Show("This service already exists in the invoice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " out ");
                }
                DataRow r = dt.NewRow();



                string Priceformatted = string.Format("{0:n0}", Convert.ToDouble(txtSellingPrice.Text));
                //string amountformatted = string.Format("{0:n0}", Convert.ToDouble(matAmaunt.Text));

                r[0] = txtServiceName.Text;
                r[1] = txtPurchasingPrice.Text;
                r[2] = Priceformatted;
                r[3] = txtQuantity.Text;
                r[4] = txtTotalPrice.Text;
                dt.Rows.Add(r);

                //dataGridView1.Columns["سعر البيع"].DefaultCellStyle.Format = "N2";
                dataGridView1.DataSource = dt;
                clearBoxes();

        
                totalamount = (from DataGridViewRow row in dataGridView1.Rows
                               where row.Cells[4].FormattedValue.ToString() != string.Empty
                               select (Convert.ToDouble(row.Cells[4].FormattedValue))).Sum().ToString();

                txttotal.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));




            }
        }

        private void txtSellingPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSellingPrice.Text != string.Empty)
            {
                txtQuantity.Focus();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.listCustomer frm = new listCustomer();
            frm.ShowDialog();
            try
            {
                if (frm.State == "sel")
                {
                    cusname.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    phone.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                cusname.Text = null;
                phone.Text = null;
            }
        }
    }
}
