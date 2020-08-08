using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sale_stations.PL.stock
{
    public partial class Category : MetroFramework.Forms.MetroForm
    {
        private string flag;
        public Category()
        {
            InitializeComponent();
            flag = "add";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PL.stock.Categories.InsertCategory frm = new Categories.InsertCategory();
            frm.ShowDialog();
            BL.CategoriesClass Category = new BL.CategoriesClass();
            this.dataGridView1.DataSource = Category.alInfo();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            BL.CategoriesClass Category = new BL.CategoriesClass();
            this.dataGridView1.DataSource = Category.alInfo();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PL.FetchMatirial frm = new FetchMatirial("by category",
                Convert.ToInt16(this.dataGridView1.CurrentRow.Cells[0].Value), 
                this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.stock.Categories.InsertCategory ins = new Categories.InsertCategory("update",
                this.dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            ins.ShowDialog();
            BL.CategoriesClass Category = new BL.CategoriesClass();
            this.dataGridView1.DataSource = Category.alInfo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.CategoriesClass Category = new BL.CategoriesClass();
            
            if (MessageBox.Show("تنبية , حذف الفئة يؤدي الى حذف جميع المواد المدرجة تحتها", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Category.DeletCat(Convert.ToInt16(this.dataGridView1.CurrentRow.Cells[0].Value));
            }
            this.dataGridView1.DataSource = Category.alInfo();
        }
    }
}
