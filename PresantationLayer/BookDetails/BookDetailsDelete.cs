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
    public partial class BookDetailsDelete : Form
    {
        private BooksDetailsBLL _booksdetailsBll;
        public BookDetailsDelete()
        {
            InitializeComponent();
            _booksdetailsBll = new BooksDetailsBLL();
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
        private void BookDetailsDelete_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            BooksDetailsPOCO deleteBook = new BooksDetailsPOCO();
            deleteBook = _booksdetailsBll.deleteBook(textBox1.Text);
            MessageBox.Show("Silme işlemi başarılı");
            ShowList();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            authorName_textbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bookDetails_textbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            AnaMenu loginScreen = new AnaMenu();
            this.Hide();
            loginScreen.Show();
        }
    }
}
