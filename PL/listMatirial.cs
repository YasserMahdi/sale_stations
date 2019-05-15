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
    public partial class listMatirial: Form
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
