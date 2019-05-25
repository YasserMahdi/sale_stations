using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class Dept_class
    {
        public DataTable getDeptInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            
          //  DataRow Dr ;
            Dt = accessobject.selectData("getDeptInfo", null);
          //  DataTable DtF = Dt;
            accessobject.close();
            
            
            


            return Dt;

        }

        public DataTable searchCusForDeptList( string name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("searchCusForDeptList", param);
            accessobject.close();

            return Dt;

        }

        //function to fetch a cutomer name from the Databast
        public DataTable getCustomerName()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getCustomerName", null);
            accessobject.close();

            return Dt;

        }

        /// <summary>
        /// not uses right now
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable selectID( DataTable name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Customer_name)", SqlDbType.NVarChar,50);
            param[0].Value = name;

            
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("selectID", null);
            accessobject.close();

            return Dt;

        }

        public void setOrderDepts(int customerid, double dept)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[0].Value = customerid;

            param[1] = new SqlParameter("@depts", SqlDbType.Money);
            param[1].Value = dept;

            param[2] = new SqlParameter("@dateOfDept", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;

            DAL.Executecmd("setOrderDepts", param);
            DAL.close();
        }


        public DataTable cheackDept(int customerID)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[0].Value = customerID;

            accessobject.open();


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("cheackDept", param);
            accessobject.close();

            return Dt;

        }

        public void updateOrderDepts(int customerid, double dept)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3]; 
            param[0] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[0].Value = customerid;

            param[1] = new SqlParameter("@depts", SqlDbType.Money);
            param[1].Value = dept;

            param[2] = new SqlParameter("@dateOfDept", SqlDbType.DateTime);
            param[2].Value =DateTime.Now;



            DAL.Executecmd("updateOrderDepts", param);
            DAL.close();
        }

        public void deletCustomerDepts(int customerID, int dept)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value = customerID;

            param[1] = new SqlParameter("@dept", SqlDbType.Int);
            param[1].Value = dept;



            DAL.Executecmd("deletCustomerDepts", param);
            DAL.close();
        }


        public void insertNewDept(int customerID, int dept)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value = customerID;

            param[1] = new SqlParameter("@dept", SqlDbType.Int);
            param[1].Value = dept;

            param[2] = new SqlParameter("@DateT", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;



            DAL.Executecmd("insertNewDept", param);
            DAL.close();
        }

        public void updateSumDebt(int customerID, int dept)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value = customerID;

            param[1] = new SqlParameter("@dept", SqlDbType.Int);
            param[1].Value = dept;



            DAL.Executecmd("updateSumDebt", param);
            DAL.close();
        }
        /*
        public DataTable debtRepayment(int customerID)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value = customerID;

            accessobject.open();


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("debtRepayment", param);
            accessobject.close();

            return Dt;

        }

        public void updateDeptInOrderTable(int invID, int dept,string isCashed)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@invID", SqlDbType.Int);
            param[0].Value = invID;

            param[1] = new SqlParameter("@orderDept", SqlDbType.Int);
            param[1].Value = dept;

            param[2] = new SqlParameter("@isCashed", SqlDbType.NVarChar,32);
            param[2].Value = isCashed;



            DAL.Executecmd("REP", param);
            DAL.close();
        }
        */

        public void updateDeptInDeptTable(int invID, double rep,double dept , String dateT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value = invID;

            param[1] = new SqlParameter("@rep", SqlDbType.Money);
            param[1].Value = rep;

            param[2] = new SqlParameter("@dept", SqlDbType.Money);
            param[2].Value = dept;

            param[3] = new SqlParameter("@dateOfDept", SqlDbType.DateTime);
            param[3].Value =Convert.ToDateTime( dateT);





            DAL.Executecmd("insertREP", param);
            DAL.close();
        }


        public DataTable getDeptHistory(string customerID)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value =Convert.ToInt32( customerID);

            accessobject.open();


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getDeptHistory", param);
            accessobject.close();

            return Dt;

        }




    }



}
