using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL.CashBox.retrive
{
    class order
    {

        public void DeleteItem(string inv_no)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@inv_no", SqlDbType.Int);
            param[0].Value = Convert.ToInt32(inv_no);
 


            DAL.Executecmd("delete_item", param);
            DAL.close();
        }

    }
}
