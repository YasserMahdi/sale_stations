using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class Report
    {
        public void set_new_month()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@year", SqlDbType.Int);
            param[0].Value = DateTime.Now.Year;

            param[1] = new SqlParameter("@month", SqlDbType.Int);
            param[1].Value = DateTime.Now.Month;

            param[2] = new SqlParameter("@date_of_insert", SqlDbType.Date);
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

        public void set_Revenue( int id , double mny)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@mny", SqlDbType.Money);
            param[1].Value = mny;


            accessobject.open();


            accessobject.Executecmd("set_Revenue", param);
            accessobject.close();


        }

        public void set_Disbursements(int id, double mny)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@mny", SqlDbType.Money);
            param[1].Value = mny;


            accessobject.open();


            accessobject.Executecmd("set_Disbursements", param);
            accessobject.close();


        }

        public DataTable get_purchasing_price(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("id", SqlDbType.Int);
            param[0].Value = id;

            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("get_purchasing_price", param);
            accessobject.close();

            return Dt;
        }

        public DataTable get_profits()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("get_profits", null);
            accessobject.close();


            foreach (DataRow row in Dt.Rows)
            {
                try
                {
                    row["الارباح"] = String.Format("{0:n0}", Convert.ToDouble(row["الارباح"]));
                }
                catch (Exception ex)
                {

                }
            }


            return Dt;
        }


    }
}
