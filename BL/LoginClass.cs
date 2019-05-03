using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace sale_stations.BL
{
    class LoginClass
    {
        public DataTable login(string username, string PWD)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[0].Value = username;

            param[1] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            accessobject.open();


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("validation_login", param);
            accessobject.close();

            return Dt;

        }

    }
}
