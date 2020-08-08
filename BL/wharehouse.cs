using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class wharehouse
    {
        public void WharehowsEntry(int noMtr,int quantity, int CatIdentity)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = noMtr;

            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = quantity;

            param[2] = new SqlParameter("@cat_id", SqlDbType.Int);
            param[2].Value = CatIdentity;
 

            DAL.Executecmd("wharehows_entry", param);
            DAL.close();
        }
 
        public DataTable WharehowsMissingItems()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("wharehows_missing_items", null);
            accessobject.close();

            return Dt;

        }
    }
}
