using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL.CashBox
{
    class SetCash
    {
        public void Set(int amount , DateTime dat, string id, string mnthid)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@amount", SqlDbType.Int);
            param[0].Value = amount;

            param[1] = new SqlParameter("@dat", SqlDbType.DateTime);
            param[1].Value = dat;

            param[2] = new SqlParameter("@id", SqlDbType.BigInt);
            param[2].Value = Convert.ToInt64(id);


            param[3] = new SqlParameter("@mnthid", SqlDbType.Int);
            param[3].Value = Convert.ToInt32(mnthid);





            accessobject.open();


            accessobject.Executecmd("set_cash", param);
            accessobject.close();


        }

        public void Set(int amount , DateTime dat, string mnthid)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@amount", SqlDbType.Int);
            param[0].Value = amount;

            param[1] = new SqlParameter("@dat", SqlDbType.DateTime);
            param[1].Value = dat;


            param[2] = new SqlParameter("@mnthid", SqlDbType.Int);
            param[2].Value = Convert.ToInt32(mnthid);





            accessobject.open();


            accessobject.Executecmd("set_cash_form_rep", param);
            accessobject.close();


        }
    }
}
