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
        public string state = "null";
        BL.Dept_class dpt = new BL.Dept_class();
        BL.CustomerClass CUS = new BL.CustomerClass();

       
        public newDept()
        {
            InitializeComponent();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Dt = new DataTable();
                DataTable DtName = CUS.gitCustomerIdByName(txtName.Text);
                Dt = dpt.cheackDept(Convert.ToInt32(DtName.Rows[0][0]));
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
                        /*
                        dpt.updateOrderDepts(Convert.ToInt32(DtName.Rows[0][0]), Convert.ToInt32(txtDept.Text));
                        MessageBox.Show("تمت الاضافة", "الدبون", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        */

                        dpt.insertNewDept(Convert.ToInt32(txtNo.Text), Convert.ToInt32(txtDept.Text));
                        MessageBox.Show("تمت عملية الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.txtNo.Clear();
                        this.txtName.Clear();
                        this.txtDept.Clear();

                    }
                    else
                    {
                        MessageBox.Show("تم الغاء العملية", "الديون", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.txtNo.Clear();
                    this.txtName.Clear();
                    this.txtDept.Clear();
                    
                    

                }
                state = "update";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
