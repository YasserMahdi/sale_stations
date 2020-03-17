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

        public void add_order(int customerID, string inv_no, string saleman, double total_ammount, double dept , string CustomerName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@inv_no", SqlDbType.Int);
            param[0].Value =Convert.ToInt32(inv_no);
          
            param[1] = new SqlParameter("@inv_date", SqlDbType.DateTime);
            param[1].Value = DateTime.Now;

            param[2] = new SqlParameter("@salesman", SqlDbType.NVarChar, 50);
            param[2].Value = saleman;

            param[3] = new SqlParameter("@customer_iD", SqlDbType.Int);
            param[3].Value = customerID;

            param[4] = new SqlParameter("@total_amount", SqlDbType.Money);
            param[4].Value = total_ammount;

            param[5] = new SqlParameter("@dept", SqlDbType.Money);
            param[5].Value = dept;


            param[6] = new SqlParameter("@name", SqlDbType.NVarChar,50);
            param[6].Value = CustomerName;





            DAL.Executecmd("add_order", param);
            DAL.close();
        }

        public void add_order_detail(int mat_no,string Name, int order_no, int qte, double price ,double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = mat_no;

            param[1] = new SqlParameter("@mat_name", SqlDbType.NVarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@order_no", SqlDbType.Int);
            param[2].Value = order_no;

            param[3] = new SqlParameter("@qte", SqlDbType.Int);
            param[3].Value = qte;

            param[4] = new SqlParameter("@price", SqlDbType.Money);
            param[4].Value = price;

            param[5] = new SqlParameter("@amount", SqlDbType.Money);
            param[5].Value =Convert.ToDouble(amount);





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

        // for printing orders

        public DataTable getOrdrrDetails(int order_id )
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

        public DataTable PrintOrder(int order_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = @order_id;


            dt = DAL.selectData("print_order", param);
            DAL.close();

            foreach (DataRow row in dt.Rows)
            {
                try
                {

                    row["السعر الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["السعر الكلي"]));
                    row["المبلغ الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الكلي"]));
                    row["سعر المفرد"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر المفرد"]));
                     
                    row["الدين الحالي"] = String.Format("{0:n0}", Convert.ToDouble(row["الدين الحالي"]));
                     
                    row["المبلغ الواصل"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الواصل"]));
                }
                catch (Exception ex)
                {

                }
            }
            return dt;
        }

        public DataTable getDirOrdrrDetails(int order_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = @order_id;
            dt = DAL.selectData("get_dir_order_details", param);
            DAL.close();

            //foreach (DataRow row in dt.Rows)
            //{
            //    try
            //    {

            //        row["السعر الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["السعر الكلي"]));
            //        row["المبلغ الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الكلي"]));
            //        row["سعر المفرد"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر المفرد"]));
            //        row["الدين السابق"] = String.Format("{0:n0}", Convert.ToDouble(row["الدين السابق"]));
            //        row["الدين الحالي"] = String.Format("{0:n0}", Convert.ToDouble(row["الدين الحالي"]));
            //        row["اجمالي الديون"] = String.Format("{0:n0}", Convert.ToDouble(row["اجمالي الديون"]));
            //        row["المبلغ الواصل"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الواصل"]));
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}
            return dt;
        }

        // also for printing orders
        public DataTable getDirOrdrrDetails(int order_id, int name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = @order_id;

            param[1] = new SqlParameter("@cus_id", SqlDbType.Int);
            param[1].Value = name;

            dt = DAL.selectData("getDirOrdrrDetails", param);
            DAL.close();

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                   

                    row["سعر المفرد"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر المفرد"]));
                    row["السعر الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["السعر الكلي"]));
                    row["المبلغ الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الكلي"]));
                    row["الدين السابق"] = String.Format("{0:n0}", Convert.ToDouble(row["الدين السابق"]));

                }
                catch (Exception ex)
                {

                }
            }
            return dt;
        }



        public DataTable getDirOrdrrDetailsWithoutDebt (int order_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = @order_id;


            dt = DAL.selectData("getDirOrdrrDetailsWithoutDebt", param);
            DAL.close();

            foreach (DataRow row in dt.Rows)
            {
                try
                {


                    row["سعر المفرد"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر المفرد"]));
                    row["السعر الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["السعر الكلي"]));
                    row["المبلغ الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الكلي"]));
                    row["الدين السابق"] = String.Format("{0:n0}", Convert.ToDouble(row["الدين السابق"]));

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


        public DataTable listDirOrder()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("listDirOrder", null);
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


        public DataTable searchDirOrders(string reference)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@reference", SqlDbType.NVarChar, 64);
            param[0].Value = reference;

            Dt = accessobject.selectData("searchDirOrders", param);
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
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@customerID", SqlDbType.Int);
            param[0].Value = customerId;

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

        public DataTable showDirInvoiceDit(int invID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@invID", SqlDbType.Int);
            param[0].Value = invID;

            dt = DAL.selectData("showDirInvoiceDit", param);
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


        public void dir_add_order(string customername, string inv_no, string saleman, double total_ammount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@inviD", SqlDbType.Int);
            param[0].Value = Convert.ToInt32(inv_no);

            param[1] = new SqlParameter("@customerName", SqlDbType.NVarChar, 50);
            param[1].Value = customername;

            param[2] = new SqlParameter("@saleman", SqlDbType.NVarChar,50);
            param[2].Value = saleman;

            param[3] = new SqlParameter("@invDate", SqlDbType.DateTime);
            param[3].Value = DateTime.Now;

            param[4] = new SqlParameter("@totalamaount", SqlDbType.Money);
            param[4].Value = total_ammount;



            DAL.Executecmd("dir_add_order", param);
            DAL.close();
        }

        public void dir_add_order_detail(int mat_no,string Name, int order_no, int qte, double price, double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@matNo", SqlDbType.Int);
            param[0].Value = mat_no;

            param[1] = new SqlParameter("@inviD", SqlDbType.Int);
            param[1].Value = order_no;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.Money);
            param[3].Value = price;

            param[4] = new SqlParameter("@amount", SqlDbType.Money);
            param[4].Value = amount;

            param[5] = new SqlParameter("@mat_name", SqlDbType.NVarChar,50);
            param[5].Value = Name;





            DAL.Executecmd("dir_add_order_det", param);
            DAL.close();
        }

        public void add_out_detail(string mat_name, int order_no, int qte, double price, double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@mat_name", SqlDbType.NVarChar,50);
            param[0].Value = mat_name;

            param[1] = new SqlParameter("@invo", SqlDbType.Int);
            param[1].Value = order_no;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.Money);
            param[3].Value = price;

            param[4] = new SqlParameter("@amount", SqlDbType.Money);
            param[4].Value = Convert.ToDouble(amount);





            DAL.Executecmd("add_out_det", param);
            DAL.close();
        }



    }
}
