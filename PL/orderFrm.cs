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
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            invoiceno.Text = ord.getLastInvoice().Rows[0][0].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listCustomer cus = new listCustomer();
            cus.ShowDialog();
            this.cusno.Text = cus.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.cusname.Text = cus.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.phone.Text = cus.dataGridView1.CurrentRow.Cells[2].Value.ToString();

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
                matPrice.Text = mat.dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
                for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if(dataGridView1.Rows[i].Cells[0].Value.ToString() == matno.Text)
                    {
                        MessageBox.Show("هذا المنتج موجود مسبقاً","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
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
    }
}
