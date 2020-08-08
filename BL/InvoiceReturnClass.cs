using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class InvoiceReturnClass
    {
        public DataTable ShowLast10Invoice()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("show_last_10_invoce", null);
            accessobject.close();

            return Dt;

        }

        public DataTable Search(string Txt)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txt", SqlDbType.VarChar, 50);
            param[0].Value = Txt;

            accessobject.open();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("search_through_order_tbl", param);
            accessobject.close();

            return Dt;

        }

        public DataTable showOrderinfoForReturn(int customerId, int invID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value = customerId;

            param[1] = new SqlParameter("@invID", SqlDbType.Int);
            param[1].Value = invID;

            dt = DAL.selectData("show_order_for_return", param);
            DAL.close();
            return dt;
        }

        public void OrderCancel(Int64 oid,Int32 qte)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@oid", SqlDbType.BigInt);
            param[0].Value = oid;

            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = qte;


            DAL.Executecmd("order_cancel", param);
            DAL.close();

        }

        public void OrderHeadCancel(Int64 oid)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@oid", SqlDbType.BigInt);
            param[0].Value = oid;


            DAL.Executecmd("order_head_cancel", param);
            DAL.close();

        }

    }
}
