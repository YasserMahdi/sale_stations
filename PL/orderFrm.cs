using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Globalization;

namespace sale_stations.PL
{
    public partial class orderFrm : Form
    {

        BL.orderClass ord = new BL.orderClass();
        BL.Dept_class dpt = new BL.Dept_class();
        BL.CustomerClass cusobject = new BL.CustomerClass();
        DataTable dt = new DataTable();

        void calculateAmount()
        {
            if(matQte.Text != string.Empty && matPrice.Text != string.Empty)
            matAmaunt.Text = (Convert.ToDouble(matPrice.Text) * Convert.ToInt32(matQte.Text)).ToString();
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
            dt.Columns.Add("رقم المادة");
            dt.Columns.Add("اسم المادة");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("سعر البيع");
            dt.Columns.Add("المبلغ");

            dataGridView1.DataSource = dt;
        }
        


        void resizeDVGcolumns()
        {
            this.dataGridView1.RowHeadersWidth =90;
            //this.dataGridView1.Columns[0].Width=108;
            
            

        }
        public orderFrm()
        {
            InitializeComponent();
            createColumns();
            resizeDVGcolumns();
            invoiceNo.Text = ord.getLastInvoice().Rows[0][0].ToString();



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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8  && e.KeyChar !=Convert.ToChar( System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void matQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
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
                    if (ord.verifyQte(Convert.ToInt32(matno.Text), Convert.ToInt32(matQte.Text)).Rows.Count < 1)
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataRow r = dt.NewRow();
              
                r[0] = matno.Text;
                r[1] = matName.Text;
                r[2] = matQte.Text;
                r[3] = matPrice.Text;
                r[4] = matAmaunt.Text;

                dt.Rows.Add(r);
                dataGridView1.DataSource = dt;
                clearBoxes();
                btn_browse.Focus();

                txttotal.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[4].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

                
                
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
                if (Convert.ToInt32(remainingAmount.Text) > 0)
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

                        DataTable Dt = cusobject.getCustomerName(cusname.Text);
                        if (Dt.Rows.Count < 1)
                        {
                            if (MessageBox.Show("هذا الزبون غير موجود هل تريد اضافته", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                DataTable DtName = cusobject.getCustomerID();
                                cusobject.insertCus(Convert.ToInt32(DtName.Rows[0][0]), cusname.Text, phone.Text);
                                // save informations of the head of invoice
                                ord.add_order(Convert.ToInt32(DtName.Rows[0][0]), invoiceNo.Text, salesman.Text, Convert.ToDouble(txttotal.Text), Convert.ToDouble(remainingAmount.Text));



                                //save products info 
                                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                                {
                                    ord.add_order_detail(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(invoiceNo.Text),
                                        Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                                }

                                // get the value of dept

                                DataTable DtForCheack = dpt.cheackDept(Convert.ToInt32(DtName.Rows[0][0]));
                                if (DtForCheack.Rows.Count > 0)//Check for old debt ,
                                                               //If there is an old debt it will be combined with the current debt
                                {
                                    dpt.updateOrderDepts(Convert.ToInt32(DtName.Rows[0][0]), Convert.ToDouble(remainingAmount.Text));
                                    // this for test -> MessageBox.Show("old dept is update");

                                }
                                if (DtForCheack.Rows.Count <= 0)

                                    dpt.setOrderDepts(Convert.ToInt32(DtName.Rows[0][0]), Convert.ToDouble(remainingAmount.Text));
                                // this for test -> MessageBox.Show("new dept inserted");



                                MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else
                            {
                                MessageBox.Show("تم الغاء العملية", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        else
                        {
                            DataTable DtName = cusobject.gitCustomerIdByName(cusname.Text);


                            cusobject.updateOrinsertCustomerPhoneNumber(Convert.ToInt32(DtName.Rows[0][0]), phone.Text);


                            // save informations of the head of invoice

                            ord.add_order(Convert.ToInt32(DtName.Rows[0][0]), invoiceNo.Text, salesman.Text, Convert.ToDouble(txttotal.Text), Convert.ToDouble(remainingAmount.Text));



                            //save products info 
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                ord.add_order_detail(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(invoiceNo.Text),
                                    Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                            }

                            //save the value of dept 

                            DataTable DtForCheack = dpt.cheackDept(Convert.ToInt32(DtName.Rows[0][0]));

                            if (DtForCheack.Rows.Count > 0)//Check for old debt ,
                                                           //If there is an old debt it will be combined with the current debt
                            {
                                dpt.updateOrderDepts(Convert.ToInt32(DtName.Rows[0][0]), Convert.ToDouble(remainingAmount.Text));
                                // this for test -> MessageBox.Show("old dept is update");

                            }
                            if (DtForCheack.Rows.Count <= 0)

                                dpt.setOrderDepts(Convert.ToInt32(DtName.Rows[0][0]), Convert.ToDouble(remainingAmount.Text));
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
                            ord.dir_add_order(cusname.Text, invoiceNo.Text, salesman.Text, Convert.ToDouble(txttotal.Text));

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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //get the last order

            int lasto =Convert.ToInt32( ord.getLastInvoiceForPrint().Rows[0][0]);
            string state =ord.getLastInvoiceForPrint().Rows[0][1].ToString();
            if (state == "NO")
            {
                REPORT.product_minu rpt = new REPORT.product_minu();
                REPORT.frmReport frm = new REPORT.frmReport();
                rpt.SetDataSource(ord.getOrdrrDetails(lasto));
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.ShowDialog();
                // frm.crystalReportViewer1.PrintReport();
            }
            else if(state == "YES")
            {
                REPORT.printDirSale rpt = new REPORT.printDirSale();
                REPORT.frmReport frm = new REPORT.frmReport();
                rpt.SetDataSource(ord.getDirOrdrrDetails(lasto));
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.ShowDialog();


            }
        }

        private void AmountReceived_KeyPress(object sender, KeyPressEventArgs e)
        {


            // (Convert.ToString(Convert.ToInt32(txttotal.Text) - Convert.ToInt32(AmountReceived.Text)))
            // procdure for compute dept
            try
            {
                int received = new int();
                int total = Convert.ToInt32(txttotal.Text);
                string rec = AmountReceived.Text;
                Int32.TryParse(rec, out received);
                int ramaning = total - received;

                if (e.KeyChar == 13)
                {
                    remainingAmount.Text = Convert.ToString(ramaning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            catch(ArgumentNullException)
            {
                MessageBox.Show("الرجاء غلق النافذه و فتحها مرة اخرى");
            }
        }

        private void cusname_KeyPress(object sender, KeyPressEventArgs e)
        {

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
