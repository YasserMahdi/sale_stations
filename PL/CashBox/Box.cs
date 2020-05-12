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
    public partial class Box : MetroFramework.Forms.MetroForm
    {
        public Box()
        {
            InitializeComponent();
        }

        private void Box_Load(object sender, EventArgs e)
        {
            try
            {
                BL.CashBox.GetCash get = new BL.CashBox.GetCash();
                this.bunifuCustomDataGrid1.DataSource = get.sel_all_month();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            PL.CashBox.Details frm = new Details(this.bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();

        }
    }
}
