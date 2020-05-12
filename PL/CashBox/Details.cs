using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sale_stations.PL.CashBox
{
    public partial class Details : MetroFramework.Forms.MetroForm
    {
        string Month;
        public Details()
        {
            InitializeComponent();
        }
        public Details(string Mnth)
        {
            InitializeComponent();
            Month = Mnth;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            try
            {
                BL.CashBox.GetCash get = new BL.CashBox.GetCash();
                this.bunifuCustomDataGrid1.DataSource = get.sel_chas(Convert.ToInt32(Month));

                this.textBox1.Text = get.sel_sumation(Convert.ToInt16(Month)).Rows[0][0].ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
