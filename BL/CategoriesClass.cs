using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class CategoriesClass
    {
        public void InsCat(string CatName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

 
            param[0] = new SqlParameter("@cat_name", SqlDbType.VarChar, 50);
            param[0].Value = CatName;

 
            DAL.Executecmd("insert_cat", param);
            DAL.close();
        }

        public void  UpdateCat(string CatName,int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@cat_name", SqlDbType.VarChar, 50);
            param[0].Value = CatName;
            param[1] = new SqlParameter("@cat_id", SqlDbType.Int);
            param[1].Value = id;


            DAL.Executecmd("update_cat", param);
            DAL.close();
        }

        public DataTable alInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("category_all_info", null);
            accessobject.close();
 


            return Dt;

        }

        public DataTable searchCategory(string cat_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("cat_name", SqlDbType.NVarChar, 50);
            param[0].Value = cat_name;
            Dt = DAL.selectData("search_in_category", param);
            DAL.close();
 

            return Dt;
        }


        public void DeletCat(int CatNo)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cat_no", SqlDbType.Int);
            param[0].Value = CatNo;
            DAL.Executecmd("delete_category", param);
            DAL.close();
        }

    }
}
