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
        public string state ="add";
        BL.MaterialClass Mat = new BL.MaterialClass();
        public insertMaterial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (state =="add")
                {
                    Mat.insertMtr(Convert.ToDouble(noMtr.Text), nameMtr.Text, Convert.ToDouble(buyCost.Text), Convert.ToDouble(saleCost.Text), Convert.ToInt32(qte.Text));
                    //MessageBox.Show("تمت الاضافة بناح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.noMtr.Clear();
                    this.nameMtr.Clear();
                    this.buyCost.Clear();
                    this.saleCost.Clear();
                    this.qte.Clear();
                }
                else
                {
                    Mat.updateMtr(Convert.ToInt32(noMtr.Text), nameMtr.Text, Convert.ToDouble(buyCost.Text), Convert.ToDouble(saleCost.Text), Convert.ToInt32(qte.Text));
                    MessageBox.Show("تمت التحديث بناح", "التحديث ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.noMtr.Clear();
                    this.nameMtr.Clear();
                    this.buyCost.Clear();
                    this.saleCost.Clear();
                    this.qte.Clear();
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ادخل معلومات صحيحة", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void noMtr_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = Mat.verifyProduct(Convert.ToInt32(noMtr.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقاً", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
