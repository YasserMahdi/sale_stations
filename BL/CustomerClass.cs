using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace sale_stations.BL
{
    class CustomerClass
    {
        public void insertCus(int CustomerNo, string name, string phone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@CustomerNo", SqlDbType.Int);
            param[0].Value = CustomerNo;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[1].Value = name;

            param[2] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[2].Value = phone;



            DAL.Executecmd("insertCustomer", param);
            DAL.close();
        }

        //function to fetch a customer information from the Databast
        public DataTable getCustomerInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getCustomerInfo", null);
            accessobject.close();

            return Dt;

        }

      
    }
}
