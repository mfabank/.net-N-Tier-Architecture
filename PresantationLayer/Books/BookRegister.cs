using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFABooks.PresantationLayer;
using MFABooks.BusinessLogicLayer;
using MFABooks.dbConnection;
using System.Data.SqlClient;
using MFABooks.PocosLayer;

namespace MFABooks.PresantationLayer.Books
{
    public partial class BookRegister : Form
    {
        private BooksBLL _booksBLL;
        public BookRegister()
        {
            InitializeComponent();
            _booksBLL = new BooksBLL();
        }
        public void ShowList()
        {
            DatabaseConnection newConnect = new DatabaseConnection();
            SqlCommand query = new SqlCommand("Select * from Books", newConnect.connection);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();  //Sorguya göre tablonun şeklini belirliyor.
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }
        private void BookRegister_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            AnaMenu loginScreen = new AnaMenu();
            this.Hide();
            loginScreen.Show();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            BooksPOCO books = new BooksPOCO();
            books = _booksBLL.bookRegister(textBox1.Text, author_textbox.Text, nameofbook_textbox.Text, Convert.ToInt32(pagecount_textbox.Text), typeofbook_textbox.Text);
            MessageBox.Show("Veriler Eklendi");
            ShowList();
        }
    }
}
