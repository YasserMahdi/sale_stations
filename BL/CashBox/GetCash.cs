using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL.CashBox
{
    class GetCash
    {
        public DataTable sel_all_month()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("sel_all_month", null);
            accessobject.close();

            return Dt;

        }

        public DataTable sel_chas(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("sel_chas", param);
            accessobject.close();

            return Dt;

        }

        internal object GetReceipt()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("get_all_receipt", null);
            accessobject.close();

            return Dt;
        }

        public DataTable sel_sumation(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@mnth", SqlDbType.Int);
            param[0].Value = id;


            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("sel_sumation", param);
            accessobject.close();

            foreach (DataRow row in Dt.Rows)
            {
                try
                {
                    row["amount"] = String.Format("{0:n0}", Convert.ToDouble(row["amount"]));
                }
                catch (Exception ex)
                {

                }
            }

            return Dt;

        }
    }
}
