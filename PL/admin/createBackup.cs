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
    public partial class createBackup : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS;database=sales_stations;integrated security=true");
        SqlCommand cmd;
        public createBackup()
        {
            InitializeComponent();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textpath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = textpath.Text + "\\BACKUP" + DateTime.Now.ToShortDateString().Replace('/', '-')
                + DateTime.Now.ToLongDateString().Replace('/', '-');
                string query = "Backup Database sales_stations to Disk='" + filename + ".bak'";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تم انشاء النسخة الاحتياطية");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
