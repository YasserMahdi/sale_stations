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


            foreach (DataRow row in Dt.Rows)
            {
                row["قيمة الدين"] = String.Format("{0:n0}", Convert.ToDouble(row["قيمة الدين"]));
            }


            return Dt;

        }

        public DataTable PrintRep(string CutomerId ,string CustomerName , double Amount , string Note)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@iD", SqlDbType.Int);
            param[0].Value = CutomerId;

            param[1] = new SqlParameter("@cus_name", SqlDbType.NVarChar,50);
            param[1].Value = CustomerName;

            param[2] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[2].Value = Amount;

            param[3] = new SqlParameter("@note", SqlDbType.NVarChar,128);
            param[3].Value = CutomerId;

            param[4] = new SqlParameter("@r_date", SqlDbType.DateTime);
            param[4].Value = DateTime.Now;

            dt = DAL.selectData("print_rep", param);
            DAL.close();    

    

            return dt;

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
            foreach (DataRow row in Dt.Rows)
            {
                try
                {
                    row["قيمة الدين"] = String.Format("{0:n0}", Convert.ToDouble(row["قيمة الدين"]));
                }
                catch (Exception ex)
                {
                    
                }
            }

            return Dt;

        }

        public string Now()
        {
            return DateTime.Now.ToString();
        }

        public string RemainingDebt(string text)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@customer_id", SqlDbType.NVarChar,10);
            param[0].Value = text;


            dt = DAL.selectData("remaining_debt", param);
            DAL.close();



            return dt.Rows[0][0].ToString();
        }

        public string ReceiptNo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();

            //  DataRow Dr ;
            Dt = accessobject.selectData("receiptno", null);
            //  DataTable DtF = Dt;
            accessobject.close();




            return Dt.Rows[0][0].ToString() ;
        }



        /// <summary>
        /// not uses right now
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>


        public void setOrderDepts(int customerid, double dept,string identity)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[0].Value = customerid;

            param[1] = new SqlParameter("@depts", SqlDbType.Money);
            param[1].Value = dept;

            param[2] = new SqlParameter("@dateOfDept", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;

            param[3] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            param[3].Value = identity;

            DAL.Executecmd("setOrderDepts", param);
            DAL.close();
        }


        public void setZeroDepts(int customerid, double dept, string identity)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[0].Value = customerid;

            param[1] = new SqlParameter("@depts", SqlDbType.Money);
            param[1].Value = dept;

            param[2] = new SqlParameter("@dateOfDept", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;

            param[3] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[3].Value = identity;

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

        public void deletCustomerDepts(int customerID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value = customerID;

            DAL.Executecmd("deletCustomerDepts", param);
            DAL.close();
        }

        
        public void insertNewDept(int customerID, int dept)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[0].Value = customerID;

            param[1] = new SqlParameter("@depts", SqlDbType.Money);
            param[1].Value = dept;

            param[2] = new SqlParameter("@dateOfDept", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;

            param[3] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            param[3].Value = " ";



            DAL.Executecmd("setOrderDepts", param);
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

        public void repayment(int cusID, double rep ,string Note)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value = cusID;

            param[1] = new SqlParameter("@rep", SqlDbType.Money);
            param[1].Value = rep;

            param[2] = new SqlParameter("@dateOfDept", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;

            param[3] = new SqlParameter("@note", SqlDbType.NVarChar,128);
            param[3].Value = Note;


            DAL.Executecmd("repayment", param);
            DAL.close();
        }


        public DataTable getDeptHistory(int customerID)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value =Convert.ToInt32( customerID);

            accessobject.open();


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getDeptHistory", param);
            accessobject.close();

            foreach (DataRow row in Dt.Rows)
            {
                try
                {
                    row["قيمة الدين"] = String.Format("{0:n0}", Convert.ToDouble(row["قيمة الدين"]));
                }
                catch (Exception ex)
                {

                }
            }


            return Dt;

        }


        public DataTable sumOfDepts()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("sumOfDepts", null);
            accessobject.close();

            return Dt;

        }

        public DataTable printDeptInfo(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@iD", SqlDbType.Int);
            param[0].Value =id;

            dt = DAL.selectData("printDeptInfo", param);
            DAL.close();

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    row["اجمالي الديون"] = String.Format("{0:n0}", Convert.ToDouble(row["اجمالي الديون"]));
                }
                catch (Exception ex)
                {

                }
            }

            return dt;
        }

        public DataTable printALLdebt()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
        


            dt = DAL.selectData("printALLdebt",null);
            DAL.close();

            return dt;
        }


        public DataTable GetFinalDebtForReceipt(string Cid)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cid", SqlDbType.NVarChar,50);
            param[0].Value = Cid;


            dt = DAL.selectData("get_final_debt_for_receipt", param);
            DAL.close();

            return dt;
        }




    }



}
