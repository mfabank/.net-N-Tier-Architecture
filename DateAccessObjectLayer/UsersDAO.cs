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
    class UsersDAO
    {
        private DatabaseConnection connect;

        public UsersDAO() {
            connect = new DatabaseConnection();
        }

        public DataTable SearchUserNameAndPassword(string username,string password) {
            string query = string.Format("Select * From Users where username = @username and passwrd = @passwrd");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@username",SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);
            sqlParameters[1] = new SqlParameter("@passwrd",SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(password);


            return connect.executeSelectQuery(query,sqlParameters);
        }
        public bool insertUsers(string usersID, string userName, string passWrd, string firstName, string lastName, int ageInfo, string gendeR)
        {
            string query = string.Format("insert into Users(id,username,passwrd,firstname,lastname,age,gender) " +
                "values (@id,@username,@passwrd,@firstname,@lastname,@age,@gender) ");

            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter("@id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(usersID);
            sqlParameters[1] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(userName);
            sqlParameters[2] = new SqlParameter("@passwrd", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(passWrd);
            sqlParameters[3] = new SqlParameter("@firstname", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(firstName);
            sqlParameters[4] = new SqlParameter("@lastname", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(lastName);
            sqlParameters[5] = new SqlParameter("@age", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(ageInfo);
            sqlParameters[6] = new SqlParameter("@gender", SqlDbType.VarChar);
            sqlParameters[6].Value = Convert.ToString(gendeR);

            return connect.executeInsertQuery(query, sqlParameters);
        }

        public bool updateUser(string usersID, string userName, string passWrd, string firstName, string lastName, int ageInfo, string gendeR)
        {
            string query = string.Format("Update Users set username = @username, passwrd=@passwrd, " +
                "firstname=@firstname, lastname=@lastname, age=@age, gender=@gender where id = '" + usersID + "'");


            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(userName);
            sqlParameters[1] = new SqlParameter("@passwrd", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(passWrd);
            sqlParameters[2] = new SqlParameter("@firstname", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(firstName);
            sqlParameters[3] = new SqlParameter("@lastname", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(lastName);
            sqlParameters[4] = new SqlParameter("@age", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(ageInfo);
            sqlParameters[5] = new SqlParameter("@gender", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(gendeR);

            return connect.executeUpdateQuery(query,sqlParameters);
        }

        public bool deleteUser(string userID) {

            string query = string.Format("Delete from Users where id = '" + userID + "'");

            return connect.executeDeleteQuery(query);
            
        }

      

    }
}
