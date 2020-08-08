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
        public void insertMtr(Double noMtr,string nameMtr, Double buyPrice, Double salePrice,int quantity,int Identity)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

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

            param[5] = new SqlParameter("@identity", SqlDbType.Int);
            param[5].Value = Identity;

            DAL.Executecmd("insertMatirials", param);
            DAL.close();
        }

        public DataTable GetOneGategory(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cat_id", SqlDbType.Int);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_by_cat", param);
            DAL.close();
            return Dt;
        }

        public DataTable getMatirialInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getMatirialInfo", null);
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

        public DataTable searchProduct(string mat_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("mat_name", SqlDbType.NVarChar, 50);
            param[0].Value = mat_name;
            Dt = DAL.selectData("searchProduct", param);
            DAL.close();

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

        public void updateMtr(int noMtr, string nameMtr, Double buyPrice, Double salePrice, int quantity,int identity)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

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

            param[5] = new SqlParameter("@identity", SqlDbType.Int);
            param[5].Value =identity ;

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

        public DataTable getLastMatNo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getLastMatNo", null);
            accessobject.close();


            return Dt;

        }


        public DataTable cheackMatName(string mat_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = mat_name;
            dt = DAL.selectData("cheackMatName", param);
            DAL.close();
            return dt;
        }

        public DataTable getMatValueByName(string mat_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = mat_name;
            dt = DAL.selectData("getMatValueByName", param);
            DAL.close();
            return dt;
        }

        public DataTable getSuggest(string txtSearch)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 50);
            param[0].Value = txtSearch;
            dt = DAL.selectData("getSuggest", param);
            DAL.close();
            return dt;
        }

        public DataTable AutoIncrease()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
             
            dt = DAL.selectData("auto_increase", null);
            DAL.close();
            return dt;
        }
    }
}
