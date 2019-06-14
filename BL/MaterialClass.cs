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
        public void insertMtr(Double noMtr,string nameMtr, Double buyPrice, Double salePrice,int quantity)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = noMtr;

            param[1] = new SqlParameter("@mat_name", SqlDbType.VarChar, 50);
            param[1].Value = nameMtr;

            param[2] = new SqlParameter("@mat_buy_price", SqlDbType.Money);
            param[2].Value = buyPrice;

            param[3] = new SqlParameter("@mat_sale_price", SqlDbType.Money);
            param[3].Value = salePrice;

            param[4] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[4].Value = quantity;

            DAL.Executecmd("insertMatirials", param);
            DAL.close();
        }

        public DataTable getMatirialInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getMatirialInfo", null);
            accessobject.close();

            return Dt;

        }

        public DataTable searchProduct(string mat_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("mat_name", SqlDbType.NVarChar, 50);
            param[0].Value = mat_name;
            dt = DAL.selectData("searchProduct", param);
            DAL.close();
            return dt;
        }


        public void deletMatirials(int noMtr)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = noMtr;
            DAL.Executecmd("deletMatirials", param);
            DAL.close();
        }


        public DataTable verifyProduct(int mat_no)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@mat_no", SqlDbType.NVarChar, 50);
            param[0].Value = mat_no;
            dt = DAL.selectData("virifyProduct", param);
            DAL.close();
            return dt;
        }

        public void updateMtr(int noMtr, string nameMtr, Double buyPrice, Double salePrice, int quantity)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = noMtr;

            param[1] = new SqlParameter("@mat_name", SqlDbType.VarChar, 50);
            param[1].Value = nameMtr;

            param[2] = new SqlParameter("@mat_buy_price", SqlDbType.Money);
            param[2].Value = buyPrice;

            param[3] = new SqlParameter("@mat_sale_price", SqlDbType.Money);
            param[3].Value = salePrice;

            param[4] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[4].Value = quantity;

            DAL.Executecmd("updateMatirial", param);
            DAL.close();
        }

        public DataTable printMaterials()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("printMaterials", null);
            accessobject.close();

            return Dt;

        }


    }
}
