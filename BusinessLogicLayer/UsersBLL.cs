using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFABooks.DateAccessObjectLayer;
using MFABooks.PocosLayer;
using System.Data;


namespace MFABooks.BusinessLogicLayer
{
    class UsersBLL
    {
        private UsersDAO _usersDAO;

        public UsersBLL() {
            _usersDAO = new UsersDAO();
        }

        public UsersPoco getQuery(string username,string password) {

            UsersPoco usersLogin = new UsersPoco();
            DataTable dataTable = new DataTable();
            dataTable = _usersDAO.SearchUserNameAndPassword(username,password);

            foreach (DataRow dr in dataTable.Rows) {
                usersLogin.userName = dr["username"].ToString();
                usersLogin.passWord = dr["passwrd"].ToString();
            }

            return usersLogin;
        }

        public UsersPoco userRegister(string usersID, string userName, string passWrd, string firstName, string lastName, int ageInfo, string gendeR) {

            UsersPoco registerUser = new UsersPoco();
            DataTable dataTable = new DataTable();

            _usersDAO.insertUsers(usersID,userName,passWrd,firstName,lastName,ageInfo,gendeR);

            foreach (DataRow dr in dataTable.Rows) {

                dr["id"] = registerUser.userID;
                dr["username"] = registerUser.userName;
                dr["passwrd"] = registerUser.passWord;
                dr["firstname"] = registerUser.firstName;
                dr["lastname"] = registerUser.lastName;
                dr["age"] = registerUser.age;
                dr["gender"] = registerUser.gender;


            }

            return registerUser;
        }

        public UsersPoco userUpdate(string usersID, string userName, string passWrd, string firstName, string lastName, int ageInfo, string gendeR) {

            UsersPoco updateUser = new UsersPoco();
            DataTable dataTable = new DataTable();

            _usersDAO.updateUser(usersID, userName, passWrd, firstName, lastName, ageInfo, gendeR);

            foreach (DataRow dr in dataTable.Rows) {

              
                dr["username"] = updateUser.userName;
                dr["passwrd"] = updateUser.passWord;
                dr["firstname"] = updateUser.firstName;
                dr["lastname"] = updateUser.lastName;
                dr["age"] = updateUser.age;
                dr["gender"] = updateUser.gender;

            }

            return updateUser;
        }

        public UsersPoco deleteUser(string userID) {

            UsersPoco userDelete = new UsersPoco();
            DataTable dataTable = new DataTable();

            _usersDAO.deleteUser(Convert.ToString(userID));

            return userDelete;


        }
    }

}
