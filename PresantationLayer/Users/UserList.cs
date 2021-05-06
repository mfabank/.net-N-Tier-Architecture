using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MFABooks.dbConnection;
using MFABooks.PresantationLayer;

namespace MFABooks.PresantationLayer.Users
{ 
    public partial class UserList : Form
{

    public SqlCommand query;
    public UserList()
    {
        InitializeComponent();
    }

    public void ShowList()
    {

        DataTable dataTable = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter(query);
        adapter.Fill(dataTable);
        BindingSource bindingSource = new BindingSource();  //Sorguya göre tablonun şeklini belirliyor.
        bindingSource.DataSource = dataTable;
        dataGridView1.DataSource = bindingSource;

    }

        public string select_userName;
        public string select_firstName;
        public string select_lastName;
        public string select_aGe;
        public string select_gender;


        private void UserList_Load(object sender, EventArgs e)
    {

        DatabaseConnection newConnect = new DatabaseConnection();
        query = new SqlCommand("Select * from Users", newConnect.connection);

        ShowList();

   
        check_1.Enabled = false;
        check2.Enabled = false;
        check3.Enabled = false;
        check4.Enabled = false;
        check5.Enabled = false;


        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            this.Hide();
            anaMenu.Show();


        }

        private void radio_btn1_CheckedChanged(object sender, EventArgs e)
        {
            
            check_1.Enabled = false;
            check2.Enabled = false;
            check3.Enabled = false;
            check4.Enabled = false;
            check5.Enabled = false;
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {

                        
            check_1.Enabled = true;
            check2.Enabled = true;
            check3.Enabled = true;
            check4.Enabled = true;
            check5.Enabled = true;
        }

        private void showlist_btn_Click(object sender, EventArgs e)
        {
            if (radio_btn1.Checked == true) {
                DatabaseConnection newConnect = new DatabaseConnection();
                query = new SqlCommand("Select * from Users",newConnect.connection);
                ShowList();
            }

            if (radio2.Checked == true) {
                if (check_1.Checked == true) {
                    select_userName = "username,";   
                } else {

                    select_userName = "";
                }

                if (check2.Checked == true) {
                    select_firstName = "firstname,";
                } else {
                    select_firstName = "";
                }

                if (check3.Checked == true) {
                    select_lastName = "lastname,";
                } else {
                    select_lastName = "";
                }

                if (check4.Checked == true) {
                    select_aGe = "age,";
                } else {
                    select_aGe = "";
                }

                if (check5.Checked == true)
                {
                    select_gender = "gender";
                }
                else
                {
                    select_gender = "";
                }

                DatabaseConnection newConnect = new DatabaseConnection();
                query = new SqlCommand("Select " + select_userName + select_firstName + select_lastName + select_aGe + select_gender
                    + " from users" ,newConnect.connection);
                ShowList();
            }
        }
    }
}
