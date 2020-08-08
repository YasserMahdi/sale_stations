using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sale_stations.PL.stock
{
    public partial class Warehouse_Entry : MetroFramework.Forms.MetroForm
    {
        DataTable Dt;
        DataTable NullColumn;
        DataRow ProductFlag;
        public Warehouse_Entry()
        {
            InitializeComponent();
        }

        void createColumns()
        {
            try
            {
                NullColumn = new DataTable();
                NullColumn.Columns.Add("Column1"); //رقم المادة
                NullColumn.Columns.Add("Column2");// اسم المادة
                NullColumn.Columns.Add("Column3");//  price
                NullColumn.Columns.Add("Column4");// 
                NullColumn.Columns.Add("Column5");//  qte
                NullColumn.Columns.Add("Column6");//  qte

            }
            catch
            {
                return;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null)
            {
                //say you want to do a search when user types 3 or more chars
                if (t.Text.Length >= 5)
                {
                    BL.DataModel model = new BL.DataModel();
                    Dt =  model.ItemSuggestions(t.Text);
                    warehouseControl2.Visible = true;
                    dataGridView2.Visible = true;
                    dataGridView2.DataSource = Dt;
                    

                }
            }
        }

        private void Warehouse_Entry_Load(object sender, EventArgs e)
        {
            warehouseControl2.Visible = false;
            dataGridView2.Visible = false;
            createColumns();

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            ProductFlag = NullColumn.NewRow();
            ProductFlag[0] = dataGridView2.CurrentRow.Cells[0].Value;
            ProductFlag[1] = dataGridView2.CurrentRow.Cells[1].Value;
            ProductFlag[2] = dataGridView2.CurrentRow.Cells[2].Value;
            ProductFlag[3] = dataGridView2.CurrentRow.Cells[3].Value;
            ProductFlag[4] = dataGridView2.CurrentRow.Cells[4].Value;
            ProductFlag[5] = dataGridView2.CurrentRow.Cells[5].Value;
            this.TxtName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            warehouseControl2.Visible = false;
            dataGridView2.Visible = false;

        }

        private void TxtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductFlag[4] =Convert.ToInt16( ProductFlag[4]) +Convert.ToInt16( TxtQte.Text);
                NullColumn.Rows.Add(ProductFlag);
                dataGridView1.DataSource= NullColumn;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BL.wharehouse wharehows = new BL.wharehouse();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                wharehows.WharehowsEntry(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)
                    , Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value)
                    , Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                //ord.add_order_detail(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(invoiceNo.Text),
                //    Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString()));
               

            }
            MessageBox.Show("تمت عملية الادخال المخزني", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
