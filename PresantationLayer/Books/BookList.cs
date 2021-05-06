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

namespace MFABooks.PresantationLayer.Books
{
    public partial class BookList : Form
    {
        public SqlCommand query;
        public BookList()
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

        public string select_author;
        public string select_nameOfBook;
        public string select_pageCounts;
        public string select_typeOfBook;



        private void BookList_Load(object sender, EventArgs e)
        {
            DatabaseConnection newConnect = new DatabaseConnection();
            query = new SqlCommand("Select * from Books", newConnect.connection);

            ShowList();


            check_1.Enabled = false;
            check2.Enabled = false;
            check3.Enabled = false;
            check4.Enabled = false;
       
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
  
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            check_1.Enabled = true;
            check2.Enabled = true;
            check3.Enabled = true;
            check4.Enabled = true;

        }

        private void showlist_btn_Click(object sender, EventArgs e)
        {
            if (radio_btn1.Checked == true)
            {
                DatabaseConnection newConnect = new DatabaseConnection();
                query = new SqlCommand("Select * from Books", newConnect.connection);
                ShowList();
            }

            if (radio2.Checked == true)
            {
                if (check_1.Checked == true)
                {
                    select_author = "author,";
                }
                else
                {
                    select_author = "";
                }

                if (check2.Checked == true)
                {
                    select_nameOfBook = "nameOfBook,";
                }
                else
                {
                    select_nameOfBook = "";
                }

                if (check3.Checked == true)
                {
                    select_pageCounts = "pageCounts,";
                }
                else
                {
                    select_pageCounts = "";
                }

                if (check4.Checked == true)
                {
                    select_typeOfBook = "typeOfBook,";
                }
                else
                {
                    select_typeOfBook = "";
                }

                DatabaseConnection newConnect = new DatabaseConnection();
                query = new SqlCommand("Select " + select_author + select_nameOfBook + select_pageCounts + select_typeOfBook
                    + " from books", newConnect.connection);
                ShowList();
            }
        }
    }

}