using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace sale_stations.DAL
{
    class DataAccessLayer
    {
        SqlConnection connectobject;
        public DataAccessLayer()
        {
            connectobject = new SqlConnection(@"server=.\SQLEXPRESS;database=sales_stations;integrated security=true");
        }

        public void open()
        {
            if (connectobject.State != ConnectionState.Open)
            {
                connectobject.Open();
            }
        }
        public void close()
        {
            if (connectobject.State == ConnectionState.Open)
            {
                connectobject.Close();
            }
        }
        // methode to read data from database
        public DataTable selectData(string stored_procedure, SqlParameter[] parametersars)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = connectobject;
            if (parametersars != null)
            {
                for (int i = 0; i < parametersars.Length; ++i)
                {

                    sqlcmd.Parameters.Add(parametersars[i]);
                }

            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        //Methode to Insert , Update and Delet Data from Database
        public void Executecmd(string stored_procedure, SqlParameter[] parametersars)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = connectobject;
            if (parametersars != null)
            {
                for (int i = 0; i < parametersars.Length; ++i)
                {

                    sqlcmd.Parameters.Add(parametersars[i]);
                }
            }
            sqlcmd.ExecuteNonQuery();
        }

        public SqlDataReader readData(string tablename)
        {
            connectobject.Open();
            SqlDataReader DataReader = null;
            SqlCommand Command = new SqlCommand("select * from " + tablename ,connectobject);
            DataReader = Command.ExecuteReader();
            return DataReader;
            connectobject.Close();
        }
    }

}
