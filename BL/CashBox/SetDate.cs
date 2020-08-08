using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL.CashBox
{
    class SetDate
    {

        public void set_new_month()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@year", SqlDbType.Int);
            param[0].Value = DateTime.Now.Year;

            param[1] = new SqlParameter("@month", SqlDbType.Int);
            param[1].Value = DateTime.Now.Month;

            param[2] = new SqlParameter("@date_of_insert", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;

            accessobject.open();


            accessobject.Executecmd("set_new_month", param);
            accessobject.close();


        }


        public DataTable sel_last_month()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("sel_last_month", null);
            accessobject.close();

            return Dt;

        }
    }
}
