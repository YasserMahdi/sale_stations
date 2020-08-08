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
    public partial class Offer : MetroFramework.Forms.MetroForm
    {
        BL.MaterialClass mtr = new BL.MaterialClass();
        Offers ds = new Offers();
        DataTable dt = new DataTable();


        void createColumns()
        {
            try
            {
                dt.Columns.Add("id"); //رقم المادة
                dt.Columns.Add("name");// اسم المادة
                dt.Columns.Add("purchase");//  qte
                dt.Columns.Add("sale");// price
                dt.Columns.Add("qte");// total amount


                this.dataGridView1.DataSource = dt;
            }
            catch
            {
                return;
            }
        }


        public Offer()
        {
            InitializeComponent();
            createColumns();
        }


        private void Offer_Load(object sender, EventArgs e)
        {

            try
            {



                this.dataGridView1.DataSource = mtr.getMatirialInfo();

                //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                //chk.HeaderText = "pick";
                //chk.Name = "cheack box";
                //dataGridView1.Columns.Add(chk);
                
                //dataGridView1.CellContentClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if(Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value) == true) { 
        //    DataRow dr = ds.Tables[0].NewRow();
        //    dr["id"] = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //    dr["name"] = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    dr["price"] = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //    ds.Tables[0].Rows.Add(dr);
        //    }

        //}

        private void textSearch_OnValueChanged(object sender, EventArgs e)
        {
            try
            {

                this.dataGridView1.DataSource = mtr.searchProduct(this.textSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.Tables[0].Clear();
            REPORT.Offers rpt = new REPORT.Offers();
            REPORT.frmReport frm = new REPORT.frmReport();

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {


                DataRow dr = ds.Tables[0].NewRow();
                dr["id"] = this.dataGridView2.Rows[i].Cells[0].Value.ToString();
                dr["name"] = this.dataGridView2.Rows[i].Cells[1].Value.ToString();
                dr["price"] = this.dataGridView2.Rows[i].Cells[3].Value.ToString();
                ds.Tables[0].Rows.Add(dr);


            }


            rpt.SetDataSource(ds.Tables[0]);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r[0] = this.dataGridView1.CurrentRow.Cells[0].Value;
            r[1] = this.dataGridView1.CurrentRow.Cells[1].Value;
            r[2] = this.dataGridView1.CurrentRow.Cells[2].Value;
            r[3] = this.dataGridView1.CurrentRow.Cells[3].Value;
            r[4] = this.dataGridView1.CurrentRow.Cells[4].Value;
            dt.Rows.Add(r);
            dataGridView2.DataSource = dt;
        }
    }
}
