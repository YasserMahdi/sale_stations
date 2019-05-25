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
    public partial class showDeptHistory : Form
    {
        BL.Dept_class dpt = new BL.Dept_class();
        public showDeptHistory()
        {
            InitializeComponent();
            
        }
    }
}
