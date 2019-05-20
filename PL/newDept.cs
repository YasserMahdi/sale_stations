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
    public partial class newDept : Form
    {
        BL.Dept_class dpt = new BL.Dept_class();
       
        listCustomer cus = new listCustomer();
        public newDept()
        {
            InitializeComponent();
            cus.ShowDialog();
            

            this.txtNo.Text = cus.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = cus.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Dt = new DataTable();
                Dt = dpt.cheackDept(Convert.ToInt32(txtNo.Text));
                if (Dt.Rows.Count < 1)//Check for no old debt
                {
                    dpt.insertNewDept(Convert.ToInt32(txtNo.Text), Convert.ToInt32(txtDept.Text));
                    MessageBox.Show("تمت عملية الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.txtNo.Clear();
                    this.txtName.Clear();
                    this.txtDept.Clear();


                }
                else //If there is an old debt it will be combined with the current debt
                {

                    if (MessageBox.Show("لم يقم هذا الزبون بتسديد دينه السابق هل ترغب في اضافة دين جديد له ", "الديون", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        dpt.updateOrderDepts(Convert.ToInt32(txtNo.Text), Convert.ToInt32(txtDept.Text));
                        MessageBox.Show("تمت الاضافة", "الدبون", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("تم الغاء العملية", "الديون", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.txtNo.Clear();
                    this.txtName.Clear();
                    this.txtDept.Clear();
                    

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
