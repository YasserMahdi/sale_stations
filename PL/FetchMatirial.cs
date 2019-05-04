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
    public partial class FetchMatirial : Form
    {
        BL.MaterialClass mtr = new BL.MaterialClass();
        public FetchMatirial()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = mtr.getMatirialInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = mtr.searchProduct(textSearch.Text);
            this.dataGridView1.DataSource = dt;
        }
    }
}
