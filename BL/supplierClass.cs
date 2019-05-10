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

     

        public DataTable getSupplierlInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getSupplierlInfo", null);
            accessobject.close();

            return Dt;

        }

        public DataTable searchSupplier(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            dt = DAL.selectData("searchSupplier", param);
            DAL.close();
            return dt;
        }

        public void deletSupplier(int noMtr)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@supplier_no", SqlDbType.Int);
            param[0].Value = noMtr;
            DAL.Executecmd("deletSupplier", param);
            DAL.close();
        }
    }
}
