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
    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void config_Load(object sender, EventArgs e)
        {
            txtServer.Text = Properties.Settings.Default.server;
            txtDatabase.Text = Properties.Settings.Default.database;
        }
    }
}
