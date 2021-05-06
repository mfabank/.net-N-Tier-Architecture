using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFABooks.PocosLayer
{
    class UsersPoco
    {
        private string _userID { get; set; }
        private string _username { get; set; }
        private string _password { get; set; }
        private string _firstname { get; set; }
        private string _lastname { get; set; }
        private int _age { get; set; }
        private string _gender { get; set; }
       

        public UsersPoco() { 
        
        }

        public string userID {
            get {
                return _userID;
            }

            set {
                _userID = value;
            }
        }
        public string userName
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }
        public string passWord
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
        public string firstName
        {
            get
            {
                return _firstname;
            }

            set
            {
                _firstname = value;
            }
        }
        public string lastName
        {
            get
            {
                return _lastname;
            }

            set
            {
                _lastname = value;
            }
        }
        public int age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }
        public string gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

    }
}
