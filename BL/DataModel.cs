using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class DataModel
    {
        // return suggestion based on user input
        public DataTable ItemSuggestions(string input)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@input", SqlDbType.NVarChar,50);
            param[0].Value = input;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("warehouse_suggestion", param);
            accessobject.close();

            foreach (DataRow row in Dt.Rows)
            {
                try
                {
                    row["سعر الشراء"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر الشراء"]));

                    row["سعر البيع"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر البيع"]));
                }
                catch (Exception ex)
                {
                    
                }
            }


            return Dt;

        }

        public DataTable CustomerNmaeSuggestions(string input)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@input", SqlDbType.NVarChar, 50);
            param[0].Value = input;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("customer_name_suggestion", param);
            accessobject.close();

            
            return Dt;

        }

        public  SqlDataReader CustomerSuggestion()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlDataReader dr = accessobject.reader("customer_name_suggestion",null);
            return dr; 
        }
    }
}
