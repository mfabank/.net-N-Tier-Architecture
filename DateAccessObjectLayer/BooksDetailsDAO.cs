using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MFABooks.dbConnection;

namespace MFABooks.DateAccessObjectLayer
{
    class BooksDetailsDAO
    {
        private DatabaseConnection connect;

        public BooksDetailsDAO() {
            connect = new DatabaseConnection();
        }

        public bool insertBooksDetails(string booksDetailsID, string authorName, string bookDetails)
        {
            string query = string.Format("insert into BookDetails(id,authorName,bookDetails) " +
                "values(@id,@authorName,@bookDetails)");

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(booksDetailsID);
            sqlParameters[1] = new SqlParameter("@authorName", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(authorName);
            sqlParameters[2] = new SqlParameter("@bookDetails", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(bookDetails);


            return connect.executeInsertQuery(query, sqlParameters);
        }

        public bool updateBooksDetails(string booksDetailsID, string authorName, string bookDetails)
        {
            string query = string.Format("Update BookDetails set authorName = @authorName, bookDetails=@bookDetails " +
                "where id = '" + booksDetailsID + "'");

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(booksDetailsID);
            sqlParameters[1] = new SqlParameter("@authorName", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(authorName);
            sqlParameters[2] = new SqlParameter("@bookDetails", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(bookDetails);


            return connect.executeUpdateQuery(query, sqlParameters);
        }

        public bool deleteBookDetails(string bookDetailsID)
        {

            string query = string.Format("Delete from BookDetails where id = '" + bookDetailsID + "'");

            return connect.executeDeleteQuery(query);

        }

    }
}
