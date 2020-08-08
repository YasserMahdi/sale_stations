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
    public partial class insertMatfFromInov : MetroFramework.Forms.MetroForm
    {
        BL.MaterialClass Mat = new BL.MaterialClass();
        public insertMatfFromInov()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mat.insertMtr(Convert.ToDouble(noMtr.Text), nameMtr.Text, Convert.ToDouble(buyCost.Text),
            //    Convert.ToDouble(saleCost.Text), Convert.ToInt32(qte.Text));
            //this.Close();
        }
    }
}
