using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sale_stations.BL
{
    class RepamentClass
    {
        public void processOnDebtRepaymentForInvoice(int cus_id, double mny)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            // select all unpaid invoice 
            DataTable Dt_not_paid_invo = this.sel_nto_paid_innvoice(cus_id);



            foreach (DataRow row in Dt_not_paid_invo.Rows)
            {
                double total = Convert.ToDouble(row["total_amount"]);
                double debt = Convert.ToDouble(row["dept"]);

                //Checking if the invoice price is equal to the current payment

                if ((total-(total - debt)) <= mny)
                {
                    mny -= (Convert.ToDouble(row["dept"]));
                    row["dept"] = Convert.ToDouble(0);
                    row["isCashed"] = "Yes";
                   
                }
                //Checking if the invoice price is more than the current payment
                // so , i have to subtract the client payment from current total price of the invoice

                else if ((total-(total - debt)) > mny && mny != 0)
                {
                    double temp = Convert.ToDouble(row["dept"]);
                    temp -= mny;
                    row["dept"] = Convert.ToDouble(temp);
                    mny = 0;
                }
            }


            foreach (DataRow row in Dt_not_paid_invo.Rows)
            {
                if (row["isCashed"].Equals("Yes"))
                {
                    // Store paid invoices
                    this.DebtRepaymentForInvoice(Convert.ToInt32(row["inv_id"]), Convert.ToDouble(row["dept"]),
                        Convert.ToString(row["isCashed"]));
                }
                else if (row["isCashed"].Equals("NO") && Convert.ToDouble(row["dept"]) > 0)
                {
                    // Store unpaid invoices 
                    this.DebtRepaymentForInvoice(Convert.ToInt32(row["inv_id"]), Convert.ToDouble(row["dept"]),
                        Convert.ToString(row["isCashed"]));
                }
            }


        }

        public DataTable sel_nto_paid_innvoice(int cus_id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = cus_id;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("sel_nto_paid_innvoice", param);
            accessobject.close();

            return Dt;

        }

        public DataTable DebtRepaymentForInvoice(int inv_id, double recived, string isCashed)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = inv_id;

            param[1] = new SqlParameter("@mny", SqlDbType.Money);
            param[1].Value = recived;

            param[2] = new SqlParameter("@isCashed", SqlDbType.NVarChar, 10);
            param[2].Value = isCashed;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("DebtRepaymentForInvoice", param);
            accessobject.close();

            return Dt;

        }

        public DataTable GetFinalValueOfDebt(int cus_id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = cus_id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("get_final_debt", param);
            accessobject.close();

            return Dt;

        }
    }
}
