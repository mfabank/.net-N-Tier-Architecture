using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFABooks.BusinessLogicLayer;
using MFABooks.dbConnection;
using System.Data.SqlClient;
using MFABooks.PocosLayer;

namespace MFABooks.PresantationLayer.BookDetails
{
    public partial class BookDetailsUpdate : Form
    {
        private BooksDetailsBLL _booksDetailsBLL;
        public BookDetailsUpdate()
        {
            InitializeComponent();
            _booksDetailsBLL = new BooksDetailsBLL();
        }

        public void ShowList()
        {
            DatabaseConnection newConnect = new DatabaseConnection();
            SqlCommand query = new SqlCommand("Select * from BookDetails", newConnect.connection);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();  //Sorguya göre tablonun şeklini belirliyor.
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }

        private void BookDetailsUpdate_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                authorName_textbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                bookDetails_textbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            BooksDetailsPOCO booksDetails = new BooksDetailsPOCO();
            booksDetails = _booksDetailsBLL.bookDetailUpdate(textBox1.Text, authorName_textbox.Text, bookDetails_textbox.Text);

            MessageBox.Show("Güncelleme işlemi başarılı.");
            ShowList();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            AnaMenu loginScreen = new AnaMenu();
            this.Hide();
            loginScreen.Show();
        }
    }
}
