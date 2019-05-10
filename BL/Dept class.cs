using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class Dept_class
    {
        public DataTable getDeptInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getDeptInfo", null);
            accessobject.close();

            return Dt;

        }

        //function to fetch a cutomer name from the Databast
        public DataTable getCustomerName()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getCustomerName", null);
            accessobject.close();

            return Dt;

        }

        /// <summary>
        /// not uses right now
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable selectID( DataTable name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Customer_name)", SqlDbType.NVarChar,50);
            param[0].Value = name;

            
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("selectID", null);
            accessobject.close();

            return Dt;

        }

    }
   


}
