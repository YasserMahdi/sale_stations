using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace sale_stations.BL
{
    class CustomerClass
    {
        public void insertCus(int CustomerNo, string name, string phone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@CustomerNo", SqlDbType.Int);
            param[0].Value = CustomerNo;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[1].Value = name;

            param[2] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[2].Value = phone;



            DAL.Executecmd("insertCustomer", param);
            DAL.close();
        }

        //function to fetch a customer information from the Databast
        public DataTable getCustomerInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getCustomerInfo", null);
            accessobject.close();

            return Dt;

        }

        public DataTable searchCustomer(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            dt = DAL.selectData("searchCustomer", param);
            DAL.close();
            return dt;
        }

        public void deletCustomer(int cus_no)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cus_no", SqlDbType.Int);
            param[0].Value = cus_no;
            DAL.Executecmd("deletCustomer", param);
            DAL.close();
        }

        public DataTable getCustomerID()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getCustomerID", null);
            accessobject.close();

            return Dt;

        }

           public void updateCustomerInfo(int CustomerNo, string name, string phone)
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DAL.open();
                SqlParameter[] param = new SqlParameter[3];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = CustomerNo;

                param[1] = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
                param[1].Value = name;

                param[2] = new SqlParameter("@PHONE", SqlDbType.NVarChar,50);
                param[2].Value = phone;



                DAL.Executecmd("updateCustomerInfo", param);
                DAL.close();
            }
        public DataTable getCustomerName (string name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar,50);
            param[0].Value = name; 
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getCustomerName", param);
            accessobject.close();

            return Dt;

        }

        public DataTable selectID(DataTable name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Customer_name)", SqlDbType.NVarChar, 50);
            param[0].Value = name;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("selectID", null);
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

        public DataTable gitCustomerIdByName(string name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar,50);
            param[0].Value = name;
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("gitCustomerIdByName", param);
            accessobject.close();

            return Dt;

        }

        public DataTable getPhoneByName(string name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getPhoneByName", param);
            accessobject.close();

            return Dt;

        }
        public void updateOrinsertCustomerPhoneNumber(int customerid,string phone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value = customerid;

            param[1] = new SqlParameter("@phone", SqlDbType.NVarChar,50);
            param[1].Value = phone;

            DAL.Executecmd("updateOrinsertCustomerPhoneNumber", param);
            DAL.close();
        }


    }
}
