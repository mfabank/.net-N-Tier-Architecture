using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 

namespace MFABooks.dbConnection
{
    class DatabaseConnection
    {
        private SqlDataAdapter dataAdapter;
        public SqlConnection connection;
        public DatabaseConnection() {
            dataAdapter = new SqlDataAdapter();
            connection = new SqlConnection(@"Data Source=MFA;Initial Catalog=mfafinalproject;Integrated Security=True");
        }

        private SqlConnection openConnection () {

            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken) {

                connection.Open();                

            } 

            return connection;
        }

        public DataTable executeSelectQuery(String _query,SqlParameter[] sqlParameter) {

            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;

            DataSet ds = new DataSet();

            try{
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();

                dataAdapter.SelectCommand = myCommand;
                dataAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch(SqlException e) {
                Console.WriteLine("Hata : Connection.ExecuteSelectQuery - Query : " + _query + "\n Exeption ? " + e.StackTrace.ToString());
                return null;
            }
            finally {}

            return dataTable;           
            
        }
        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        {

            SqlCommand myCommand = new SqlCommand();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                dataAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine("Hata : Connection.ExecuteInsertQuery - Query : " + _query + "\n Exeption ? " + e.StackTrace.ToString());
                return false;
            }
            finally { }

            return true;
        }

        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {

            SqlCommand myCommand = new SqlCommand();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                dataAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();                
                
            }
            catch (SqlException e)
            {
                Console.WriteLine("Hata : Connection.ExecuteUpdateQuery - Query : " + _query + "\n Exeption ? " + e.StackTrace.ToString());
                return false;
            }
            finally { }

            return true;

        }

        public bool executeDeleteQuery(String _query)
        {

            SqlCommand myCommand = new SqlCommand();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                dataAdapter.DeleteCommand = myCommand;
                myCommand.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine("Hata : Connection.ExecuteDeleteQuery - Query : " + _query + "\n Exeption ? " + e.StackTrace.ToString());
                return false;
            }
            finally { }

            return true;
        }

    }
}
