using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class SupplierClass
    {
        // function to insert a matirial in the Databast
        public void insertSpr(int supplierNo,string name,string phone,string address)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@No", SqlDbType.Int);
            param[0].Value = supplierNo;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar,50);
            param[1].Value = name;

            param[2] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[2].Value = phone;

            param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 50);
            param[3].Value = address;

            
            DAL.Executecmd("insertSupliers", param);
            DAL.close();
        }

        //function to fetch a supplier name from the Databast
        public DataTable getSupplierNmae()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getSupplierNmae", null);
            accessobject.close();

            return Dt;

        }
    }
}
