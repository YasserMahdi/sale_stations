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
    
    public partial class insertMaterial : Form
    {
        BL.MaterialClass insMat = new BL.MaterialClass();
        public insertMaterial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insMat.insertMtr(Convert.ToInt32(noMtr.Text),nameMtr.Text,Convert.ToInt32(saleCost.Text),Convert.ToInt32(buyCost.Text),Convert.ToInt32(qte.Text));
            MessageBox.Show("تمت الاضافة بناح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
