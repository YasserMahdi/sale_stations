using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class orderClass
    {
        public DataTable getLastInvoice()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getLastInvoice", null);
            accessobject.close();

            return Dt;

        }

        public DataTable getLastInvoiceForPrint()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getLastInvoiceForPrint", null);
            accessobject.close();

            return Dt;

        }

        public void add_order(int customerID, string inv_no, string saleman, double total_ammount, double dept)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@inv_no", SqlDbType.Int);
            param[0].Value =Convert.ToInt32(inv_no);

            param[1] = new SqlParameter("@isCashed", SqlDbType.NVarChar, 32);
            if (dept == 0)
            {
                param[1].Value = "YES";
            }
            else
            {
                param[1].Value = "NO";
            }
           

            param[2] = new SqlParameter("@inv_date", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;

            param[3] = new SqlParameter("@salesman", SqlDbType.NVarChar, 50);
            param[3].Value = saleman;

            param[4] = new SqlParameter("@customer_iD", SqlDbType.Int);
            param[4].Value = customerID;

            param[5] = new SqlParameter("@total_amount", SqlDbType.Money);
            param[5].Value = total_ammount;

            param[6] = new SqlParameter("@dept", SqlDbType.Money);
            param[6].Value = dept;
            
          


            DAL.Executecmd("add_order", param);
            DAL.close();
        }

        public void add_order_detail(int mat_no, int order_no, int qte, double price ,double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = mat_no;

            param[1] = new SqlParameter("@order_no", SqlDbType.Int);
            param[1].Value = order_no;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.Money);
            param[3].Value = price;

            param[4] = new SqlParameter("@amount", SqlDbType.Money);
            param[4].Value =Convert.ToDouble(amount);





            DAL.Executecmd("add_order_detail", param);
            DAL.close();
        }

        public DataTable verifyQte(int mat_no,int qte)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = mat_no;

            param[1] = new SqlParameter("@qte_enterd", SqlDbType.Int);
            param[1].Value = qte;

            dt = DAL.selectData("verifyQte", param);
            DAL.close();
            return dt;
        }

        public DataTable getOrdrrDetails(int order_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = @order_id;
            dt = DAL.selectData("getOrdrrDetails", param);
            DAL.close();
            return dt;
        }
        public DataTable serachOrders()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("serachOrders", null);
            accessobject.close();
            return Dt;

        }

        public DataTable seach_single_oerder(string reference)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@reference", SqlDbType.NVarChar,64);
            param[0].Value = reference;

            Dt = accessobject.selectData("seach_single_oerder", param);
            accessobject.close();

            return Dt;

        }

        public DataTable getNotCashedOrder()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getNotCashedOrder", null);
            accessobject.close();
            return Dt;

        }

        public DataTable showOrderinfo(string customerName, int invID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@customerName", SqlDbType.NVarChar,50);
            param[0].Value = customerName;

            param[1] = new SqlParameter("@invID", SqlDbType.Int);
            param[1].Value = invID;

            dt = DAL.selectData("showOrderinfo", param);
            DAL.close();
            return dt;
        }

        public DataTable showOrderDit( int invID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@invID", SqlDbType.Int);
            param[0].Value = invID;

            dt = DAL.selectData("showOrderDit", param);
            DAL.close();
            return dt;
        }


    }
}
