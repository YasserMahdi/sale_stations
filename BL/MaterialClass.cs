using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class MaterialClass
    {
        public void insertMtr(int noMtr,string nameMtr,int buyPrice,int salePrice,int quantity)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = noMtr;

            param[1] = new SqlParameter("@mat_name", SqlDbType.VarChar, 50);
            param[1].Value = nameMtr;

            param[2] = new SqlParameter("@mat_buy_price", SqlDbType.VarChar, 50);
            param[2].Value = buyPrice;

            param[3] = new SqlParameter("@mat_sale_price", SqlDbType.VarChar, 50);
            param[3].Value = salePrice;

            param[4] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[4].Value = quantity;

            DAL.Executecmd("insertMatirials", param);
            DAL.close();
        }
    }
}
