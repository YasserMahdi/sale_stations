using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sale_stations.PL
{
    public partial class orderFrm : Form
    {

        BL.orderClass ord = new BL.orderClass();
        BL.Dept_class dpt = new BL.Dept_class();
        BL.CustomerClass cusobject = new BL.CustomerClass();
        BL.MaterialClass materials = new BL.MaterialClass();
        DataTable dt = new DataTable();
        string totalamount;
        string rRemaining;
        DataTable SmashingData;



        void calculateAmount()
        {
            if (matQte.Text != string.Empty && matPrice.Text != string.Empty)

                try
                {

                    matAmaunt.Text = string.Format("{0:n0}", Convert.ToDouble(((Convert.ToDouble(matPrice.Text) * Convert.ToInt32(matQte.Text))).ToString()));
                }
                catch (Exception ex)
                {
                    return;
                }
        }

        void clearBoxes()
        {
            matno.Clear();
            matName.Clear();
            matPrice.Clear();
            matQte.Clear();
            matAmaunt.Clear();
        }

        void createColumns()
        {
            dt.Columns.Add("Column1"); //رقم المادة
            dt.Columns.Add("Column2");// اسم المادة
            dt.Columns.Add("Column3");//  qte
            dt.Columns.Add("Column4");// price
            dt.Columns.Add("Column5");// total amount


            this.dataGridView1.DataSource = dt;
        }


        void resizeDVGcolumns()
        {
            this.dataGridView1.RowHeadersWidth = 90;
            //this.dataGridView1.Columns[1].Width = 408;
            //this.dataGridView1.Columns["Column1"].Width = 160;



        }

        void calculateDept()
        {
            try
            {


                if (AmountReceived.Text == string.Empty)
                {
                    remainingAmount.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));
                }
                else
                {
                    int rReceived;
                    int total = Convert.ToInt32(totalamount);
                    int.TryParse(AmountReceived.Text, out rReceived);
                    int ramaning = (total - rReceived);
                    rRemaining = ramaning.ToString();

                    remainingAmount.Text = String.Format("{0:n0}", ramaning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n Error in Text changed");
            }
        }

        public orderFrm()
        {
            InitializeComponent();

            createColumns();
            invoiceNo.Text = ord.getLastInvoice().Rows[0][0].ToString();
            resizeDVGcolumns();






        }

        private void button3_Click(object sender, EventArgs e)
        {

            invoiceNo.Text = ord.getLastInvoice().Rows[0][0].ToString();

        }



        private void button7_Click(object sender, EventArgs e)
        {
            PL.listMatirial mat = new listMatirial();
            mat.ShowDialog();
            try
            {
                clearBoxes();
                matno.Text = mat.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                matName.Text = mat.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                matPrice.Text = mat.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                matQte.Focus();

            }
            catch
            {
                mat.Close();

            }

        }
        private void matPrice_KeyPress(object sender, KeyPressEventArgs e)

        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void matQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void matPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void matQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //for vierify  if quantity more than zero 
                    DataTable CheckQte = new DataTable();
                    DataTable CheckName = materials.cheackMatName(this.matName.Text); 

                    //if statement to set value in checkQte datatabe
                    if (matno.Text != string.Empty)
                    {
                        CheckQte = ord.verifyQte(Convert.ToInt32(matno.Text), Convert.ToInt32(matQte.Text));
                    }

                    if (CheckName.Rows.Count <= 0)
                    {

                            PL.insertMatfFromInov frm = new insertMatfFromInov();
                            matno.Text = materials.getLastMatNo().Rows[0][0].ToString();
                            frm.noMtr.Text = matno.Text;
                            frm.nameMtr.Text = matName.Text;
                            frm.qte.Text = matQte.Text;
                            frm.saleCost.Text = string.Format("{0:n0}", Convert.ToDouble(matPrice.Text));
                            frm.buyCost.Text = Convert.ToString(0);
                            frm.ShowDialog();

                       
                    }
                    else if (Convert.ToInt32(CheckQte.Rows[0][4]) < Convert.ToInt32(matQte.Text))
                    {

                        MessageBox.Show("الكمية في المخزن غير كافية", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString() == matno.Text)
                            {
                                MessageBox.Show("هذا المنتج موجود مسبقاً", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            /*
                            if (ord.verifyQte(Convert.ToInt32(matno.Text),Convert.ToInt32(matQte.Text)).Rows.Count < 1)
                            {
                                MessageBox.Show("الكمية في المخزن غير كافية", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            */
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " out ");
                }
                DataRow r = dt.NewRow();
              
                

                string Priceformatted = string.Format("{0:n0}", Convert.ToDouble(matPrice.Text));
                //string amountformatted = string.Format("{0:n0}", Convert.ToDouble(matAmaunt.Text));

                r[0] = matno.Text;
                r[1] = matName.Text;
                r[2] = matQte.Text;
                r[3] = Priceformatted;
                r[4] = matAmaunt.Text;
                dt.Rows.Add(r);

                //dataGridView1.Columns["سعر البيع"].DefaultCellStyle.Format = "N2";
                dataGridView1.DataSource = dt;
                clearBoxes();
                btn_browse.Focus();

                /*
                  dt.Columns.Add("رقم المادة");
            dt.Columns.Add("اسم المادة");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("سعر البيع");
            dt.Columns.Add("المبلغ");
                 */

                totalamount = (from DataGridViewRow row in dataGridView1.Rows
                               where row.Cells[4].FormattedValue.ToString() != string.Empty
                               select (Convert.ToDouble(row.Cells[4].FormattedValue))).Sum().ToString();

                txttotal.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));




            }
        }

        private void matQte_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
        }

        private void matPrice_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void matPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && matPrice.Text != string.Empty)
            {
                matQte.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                matno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                matName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                matQte.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                matPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                matQte.Focus();
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                invoiceNo.Text = ord.getLastInvoice().Rows[0][0].ToString();



                if (Convert.ToInt32(rRemaining) > 0)
                {
                    // cheack values is set or not 
                    if (invoiceNo.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال رقم القائمة", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (salesman.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال اسم البائع", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cusname.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال معلومات الزبون", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dataGridView1.Rows.Count < 1)
                    {
                        MessageBox.Show("الرجاء ادخال المواد", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (remainingAmount.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال المبلغ الواصل", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        //Check the customer name if it already exists
                        DataTable Dt = cusobject.getCustomerName(cusname.Text);
                        if (Dt.Rows.Count < 1)
                        {
                            if (MessageBox.Show("هذا الزبون غير موجود هل تريد اضافته", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                // get new ID for New Customer
                                DataTable DtName = cusobject.getCustomerID();
                                cusobject.insertCus(Convert.ToInt32(DtName.Rows[0][0]), cusname.Text, phone.Text);


                                // save informations of the head of invoicev
                                ord.add_order(Convert.ToInt32(DtName.Rows[0][0]), invoiceNo.Text, salesman.Text, Convert.ToDouble(totalamount), Convert.ToDouble(rRemaining));

                                //save products info 

                                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                                {
                                    // if (dataGridView1.Rows[i].Cells[0].Value.ToString() == string.Empty)

                                    // ord.add_out_detail(dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(invoiceNo.Text),
                                    //   Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString())
                                    //   );

                                    ord.add_order_detail(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(invoiceNo.Text),
                                        Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString()));

                                }

                                // get the value of dept

                                //DataTable DtForCheack = dpt.cheackDept(Convert.ToInt32(DtName.Rows[0][0]));
                                //if (DtForCheack.Rows.Count > 0)//Check for old debt ,
                                //If there is an old debt it will be combined with the current debt
                                //{
                                //dpt.updateOrderDepts(Convert.ToInt32(DtName.Rows[0][0]), Convert.ToDouble(remainingAmount.Text));
                                // this for test -> MessageBox.Show("old dept is update");

                                //}
                                //if (DtForCheack.Rows.Count <= 0)

                                dpt.setOrderDepts(Convert.ToInt32(DtName.Rows[0][0]), Convert.ToDouble(rRemaining));
                                // this for test -> MessageBox.Show("new dept inserted");



                                MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else
                            {
                                MessageBox.Show("تم الغاء العملية", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                            ord.add_order(Convert.ToInt32(DtName.Rows[0][0]), invoiceNo.Text, salesman.Text, Convert.ToDouble(totalamount), Convert.ToDouble(rRemaining));



                            //save products info 
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                //  if (dataGridView1.Rows[i].Cells[0].Value.ToString() == string.Empty)

                                // ord.add_out_detail(dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(invoiceNo.Text),
                                //   Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value), 
                                //  Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString())
                                // );

                                ord.add_order_detail(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(invoiceNo.Text),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value),
                                Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString()));


                            }

                            //save the value of dept 


                            //DataTable DtForCheack = dpt.cheackDept(Convert.ToInt32(DtName.Rows[0][0]));

                            //if (DtForCheack.Rows.Count > 0)//Check for old debt ,
                            //If there is an old debt it will be combined with the current debt
                            // {
                            //dpt.updateOrderDepts(Convert.ToInt32(DtName.Rows[0][0]), Convert.ToDouble(remainingAmount.Text));
                            // this for test -> MessageBox.Show("old dept is update");

                            //  }
                            //if (DtForCheack.Rows.Count <= 0)
                            dpt.setOrderDepts(Convert.ToInt32(DtName.Rows[0][0]), Convert.ToDouble(rRemaining));
                            // this for test -> MessageBox.Show("new dept inserted");



                            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }


                    }
                }
                else
                {
                    // for saving order with out costomer imfo
                    if (invoiceNo.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال رقم القائمة", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (salesman.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال اسم البائع", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cusname.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال معلومات الزبون", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dataGridView1.Rows.Count < 1)
                    {
                        MessageBox.Show("الرجاء ادخال المواد", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (remainingAmount.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال المبلغ الواصل", " تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        try
                        {
                            ord.dir_add_order(cusname.Text, invoiceNo.Text, salesman.Text, Convert.ToDouble(totalamount));

                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                ord.dir_add_order_detail(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(invoiceNo.Text),
                                    Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                            }
                            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    // end
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError in Fisrt try");
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //get the last order

            int lasto = Convert.ToInt32(ord.getLastInvoiceForPrint().Rows[0][0]);
            string state = ord.getLastInvoiceForPrint().Rows[0][1].ToString();
            if (state == "NO")
            {
                try
                {
                    REPORT.product_minu rpt = new REPORT.product_minu();
                    REPORT.frmReport frm = new REPORT.frmReport();
                    rpt.SetDataSource(ord.getOrdrrDetails(lasto));
                    frm.crystalReportViewer1.ReportSource = rpt;
                    
                    frm.ShowDialog();
                    frm.crystalReportViewer1.PrintReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (state == "YES")
            {
                try
                {
                    DataTable DtName = cusobject.gitCustomerIdByName(cusname.Text);
                    int lastN = Convert.ToInt32(DtName.Rows[0][0]);

                    REPORT.printDirSale rpt = new REPORT.printDirSale();
                    REPORT.frmReport frm = new REPORT.frmReport();
                    rpt.SetDataSource(ord.getDirOrdrrDetails(lasto, lastN));
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    frm.crystalReportViewer1.PrintReport();

                }
                catch (Exception ex)
                {
                    REPORT.printDirSale rpt = new REPORT.printDirSale();
                    REPORT.frmReport frm = new REPORT.frmReport();
                    rpt.SetDataSource(ord.getDirOrdrrDetailsWithoutDebt(lasto));
                    frm.crystalReportViewer1.ReportSource = rpt;
                    //frm.ShowDialog();
                    frm.crystalReportViewer1.PrintReport();
                }
            }


        }

        private void AmountReceived_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void invoiceDesk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void salesman_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void invoiceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cusname_TextChanged(object sender, EventArgs e)
        {
            try
            {



                if (cusobject.getCustomerName(cusname.Text).Rows[0][0].ToString().Equals(cusname.Text))
                {

                    DataTable ID = cusobject.gitCustomerIdByName(cusname.Text);
                    DataTable dpt = cusobject.getDeptByID(Convert.ToInt32(ID.Rows[0][0]));
                    txtOldDept.Text = String.Format("{0:n0}", Convert.ToInt32(dpt.Rows[0][0]));



                }
                else
                {
                    return;
                }



            }
            catch (Exception ex)
            {
                txtOldDept.Clear();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cusNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void matAmaunt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void matno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void matPrice_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void matName_TextChanged(object sender, EventArgs e)
        {
            DataTable dt; 
            try
            {
                dt = materials.getMatValueByName(matName.Text);
                matno.Text = dt.Rows[0][0].ToString();
                matName.Text = dt.Rows[0][1].ToString();
                matPrice.Text = string.Format("{0:n0}", Convert.ToInt32(dt.Rows[0][3]));
                    


            }
            catch
            {
                matno.Clear();
                matPrice.Clear();
            }
        }

        private void matQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AmountReceived_TextChanged(object sender, EventArgs e)
        {
            try
            {

                calculateDept();
            }
            catch (Exception ex)
            {
                return;
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void remainingAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.invoiceNo.Clear();
                this.salesman.Clear();
                //this.cusNo.Clear();
                this.cusname.Clear();
                this.phone.Clear();
                this.txttotal.Clear();
                this.AmountReceived.Clear();
                this.remainingAmount.Clear();
                this.dataGridView1.DataSource = null;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("الرجاء غلق النافذه و فتحها مرة اخرى");
            }
        }

        private void cusname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (cusobject.getCustomerName(cusname.Text).Rows[0][0].ToString().Equals(cusname.Text))
                    {
                        DataTable ID = cusobject.gitCustomerIdByName(cusname.Text);
                        DataTable dpt = cusobject.getDeptByID(Convert.ToInt32(ID.Rows[0][0]));
                        txtOldDept.Text = dpt.Rows[0][0].ToString();



                    }
                    else
                    {
                        return;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("الاستعلام غير موجود");
            }
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
    }
}
