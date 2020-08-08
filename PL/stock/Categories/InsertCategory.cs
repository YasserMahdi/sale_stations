using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sale_stations.PL.stock.Categories
{
    public partial class InsertCategory : MetroFramework.Forms.MetroForm
    {
        private string flag;
        private string CatID;
        private string CatName;
        public InsertCategory()
        {
            InitializeComponent();
            flag = "add";
        }

        public InsertCategory(string state,string id,string name)
        {
            InitializeComponent();
            flag = state;
            this.CatID = id;
            this.CatName = name;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(flag == "add")
            {
                BL.CategoriesClass Category = new BL.CategoriesClass();
                Category.InsCat(this.TxtName.Text);
                MessageBox.Show("تمت الاضافة بنجاح", " الاضافة ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtName.Text = null;
            }
            else
            {
                BL.CategoriesClass Category = new BL.CategoriesClass();
                Category.UpdateCat(this.TxtName.Text, Convert.ToInt16(TxtNo.Text));
                MessageBox.Show("تمت التعديل بنجاح", " التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtName.Text = null;
            }

        }

        private void InsertCategory_Load(object sender, EventArgs e)
        {
            if(flag == "update")
            {
                this.TxtName.Text = CatName;
                this.TxtNo.Text = CatID;
            }
        }
    }
}
