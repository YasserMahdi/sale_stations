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
    
    public partial class insertMaterial : MetroFramework.Forms.MetroForm
    {
        public string state ="add";
        public string isUpdate = "false";
        public string caseOf = "null";
        public int Identity;
        public string CatName;
        BL.MaterialClass Mat = new BL.MaterialClass();
        public insertMaterial()
        {
            InitializeComponent();
        }

        public insertMaterial(int identity,string CatName)
        {
            InitializeComponent();
            this.Identity = identity;
            this.CatName = CatName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (state =="add")
                {
                    Mat.insertMtr(Convert.ToDouble(noMtr.Text), nameMtr.Text, Convert.ToDouble(buyCost.Text), Convert.ToDouble(saleCost.Text), Convert.ToInt32(qte.Text),Identity);
                    //MessageBox.Show("تمت الاضافة بناح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.noMtr.Clear();
                    this.nameMtr.Clear();
                    this.buyCost.Clear();
                    this.saleCost.Clear();
                    this.qte.Clear();
                    caseOf = "insert";



                    try
                    {
                        this.noMtr.Text = Mat.AutoIncrease().Rows[0][0].ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    Mat.updateMtr(Convert.ToInt32(noMtr.Text), nameMtr.Text, Convert.ToDouble(buyCost.Text), Convert.ToDouble(saleCost.Text), Convert.ToInt32(qte.Text),Identity);
                    MessageBox.Show("تمت التحديث بناح", "التحديث ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.noMtr.Clear();
                    this.nameMtr.Clear();
                    this.buyCost.Clear();
                    this.saleCost.Clear();
                    this.qte.Clear();
                    this.isUpdate = "true";
                    
                  
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ادخل معلومات صحيحة " + ex.Message, "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void noMtr_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                try
                {
                    if (noMtr.Text.Equals(null))
                    {
                        DataTable dt = new DataTable();
                        dt = Mat.verifyProduct(Convert.ToInt32(noMtr.Text));
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("هذا المعرف موجود مسبقاً", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void insertMaterial_Load(object sender, EventArgs e)
        {
            try
            {
                if (state == "add")
                {
                    this.noMtr.Text = Mat.AutoIncrease().Rows[0][0].ToString();
                    this.TxtCategory.Text = CatName;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nameMtr_TextChanged(object sender, EventArgs e)
        {

        }

        private void buyCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void saleCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void qte_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void noMtr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
