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
    public partial class listMatirial: MetroFramework.Forms.MetroForm
    {
        BL.MaterialClass mat = new BL.MaterialClass();
        DataTable DT = new DataTable();
        public listMatirial()
        {
            InitializeComponent();
            DT = mat.getMatirialInfo();
            this.dataGridView1.DataSource = DT;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                
                PL.orderFrm frm = PL.orderFrm.GetInstance();
                frm.clearBoxes();
                frm.matno.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.matName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.matPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.matQte.Focus();

            }
            catch
            {
               

            }
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = mat.searchProduct(txtSearch.Text);
            this.dataGridView1.DataSource = dt;
        }
    }
}
