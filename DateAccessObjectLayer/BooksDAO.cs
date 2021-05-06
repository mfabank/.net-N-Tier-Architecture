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
    class BooksDAO
    {
        private DatabaseConnection connect;

        public BooksDAO()
        {
            connect = new DatabaseConnection();
        }

        public bool insertBooks(string booksID, string authorName, string nameOfBook, int pageCount, string typeOfBook)
        {
            string query = string.Format("insert into Books(id,author,nameOfBook,pageCounts,typeOfBook) " +
                "values (@id,@author,@nameOfBook,@pageCounts,@typeOfBook) ");

            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(booksID);
            sqlParameters[1] = new SqlParameter("@author", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(authorName);
            sqlParameters[2] = new SqlParameter("@nameOfBook", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(nameOfBook);
            sqlParameters[3] = new SqlParameter("@pageCounts", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(pageCount);
            sqlParameters[4] = new SqlParameter("@typeOfBook", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(typeOfBook);



            return connect.executeInsertQuery(query, sqlParameters);
        }

        public bool updateBooks(string booksID, string authorName, string nameOfBook, int pageCount, string typeOfBook)
        {
            string query = string.Format("Update Books set author = @author, nameOfBook=@nameOfBook, " +
                "pageCounts=@pageCounts, typeOfBook=@typeOfBook where id = '" + booksID + "'");

            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(booksID);
            sqlParameters[1] = new SqlParameter("@author", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(authorName);
            sqlParameters[2] = new SqlParameter("@nameOfBook", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(nameOfBook);
            sqlParameters[3] = new SqlParameter("@pageCounts", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(pageCount);
            sqlParameters[4] = new SqlParameter("@typeOfBook", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(typeOfBook);



            return connect.executeUpdateQuery(query, sqlParameters);
        }

        public bool deleteBook(string bookID)
        {

            string query = string.Format("Delete from Books where id = '" + bookID + "'");

            return connect.executeDeleteQuery(query);

        }



    }
}
