using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sale_stations.PL
{
    public partial class Recovery : Form
    {
        SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS;database=master;integrated security=true");
        SqlCommand cmd;
        public Recovery()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            try
            {
                
                string query = "ALTER Database AUTO_SALES SET OFFLINE WITH ROLLBACK IMMEDIATE ; Restore Database AUTO_SALES from Disk='" + textpath.Text + "'";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تم استعادة النسخة الاحتياطية");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textpath.Text = openFileDialog1.FileName;
            }
        }
    }
}
