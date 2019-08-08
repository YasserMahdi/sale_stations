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
        public DataTable getSequenceInvoice()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getSequenceInvoice", null);
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

        public void add_order(int inv_no, string customerName, double total,  string seller)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@inv_no", SqlDbType.Int);
            param[0].Value =Convert.ToInt32(inv_no);
          
            param[1] = new SqlParameter("@inv_date", SqlDbType.DateTime);
            param[1].Value = DateTime.Now;

            param[2] = new SqlParameter("@seller", SqlDbType.NVarChar, 50);
            param[2].Value = seller;

            param[3] = new SqlParameter("@customer_name", SqlDbType.NVarChar,50);
            param[3].Value = customerName;

            param[4] = new SqlParameter("@total", SqlDbType.Money);
            param[4].Value = total;
            
          


            DAL.Executecmd("add_order", param);
            DAL.close();
        }

        public void add_order_detail(int order_no, string ServiceName, double PurchasingPrice, double sellingPrice, int qte,double amount )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@ServiceName", SqlDbType.NVarChar,50);
            param[0].Value = ServiceName;

            param[1] = new SqlParameter("@order_no", SqlDbType.Int);
            param[1].Value = order_no;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@PurchasingPrice", SqlDbType.Money);
            param[3].Value = PurchasingPrice;

            param[4] = new SqlParameter("@sellingPrice", SqlDbType.Money);
            param[4].Value = sellingPrice;

            param[5] = new SqlParameter("@amount", SqlDbType.Money);
            param[5].Value =Convert.ToDouble(amount);





            DAL.Executecmd("add_order_detail", param);
            DAL.close();
        }

        
        // for printing orders

        public DataTable getOrdrrDetails(int order_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = @order_id;
            dt = DAL.selectData("getOrdrrDetails", param);
            DAL.close();

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    
                    row["السعر الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["السعر الكلي"]));
                    row["المبلغ الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الكلي"]));
                    row["سعر المفرد"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر المفرد"]));
                    row["الدين السابق"] = String.Format("{0:n0}", Convert.ToDouble(row["الدين السابق"]));
                    row["الدين الحالي"] = String.Format("{0:n0}", Convert.ToDouble(row["الدين الحالي"]));
                    row["اجمالي الديون"] = String.Format("{0:n0}", Convert.ToDouble(row["اجمالي الديون"]));
                    row["المبلغ الواصل"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الواصل"]));
                }
                catch (Exception ex)
                {

                }
            }
            return dt;
        }

        
        public DataTable serachOrders()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("serachOrders", null);
            accessobject.close();

            foreach (DataRow row in Dt.Rows)
            {
                try
                {
                    row["المبلغ الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الكلي"]));
                }
                catch (Exception ex)
                {

                }
            }
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
            foreach (DataRow row in Dt.Rows)
            {
                try
                {
                    row["المبلغ الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الكلي"]));
                }
                catch (Exception ex)
                {

                }
            }


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

        public DataTable showOrderinfo(int customerId, int invID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = invID;

            dt = DAL.selectData("showOrderinfo", param);
            DAL.close();
            return dt;
        }

        public DataTable showOrderDit( int invID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = invID;

            dt = DAL.selectData("showOrderDit", param);
            DAL.close();

            foreach (DataRow row in dt.Rows)
            {
                try
                {

                    row["سعر البيع"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر البيع"]));
                    row["المبلغ"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ"]));

                }
                catch (Exception ex)
                {

                }
            }
            return dt;
        }


        


    }
}
