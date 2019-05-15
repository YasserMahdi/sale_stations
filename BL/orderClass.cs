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

        public void add_order(string inv_no, string inv_desc,string date, string saleman, string customer_id , int total_ammount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@inv_no", SqlDbType.Int);
            param[0].Value =Convert.ToInt32(inv_no);

            param[1] = new SqlParameter("@inv_desc", SqlDbType.NVarChar, 64);
            param[1].Value = inv_desc;

            param[2] = new SqlParameter("@inv_date", SqlDbType.Date);
            param[2].Value = Convert.ToDateTime(date);

            param[3] = new SqlParameter("@salesman", SqlDbType.NVarChar, 50);
            param[3].Value = saleman;

            param[4] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[4].Value = Convert.ToInt32(customer_id);

            param[5] = new SqlParameter("@total_amount", SqlDbType.Int);
            param[5].Value = total_ammount;


            DAL.Executecmd("add_order", param);
            DAL.close();
        }

        public void add_order_detail(int mat_no, int order_no, int qte, double price ,int amount )
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
    }
}
