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

namespace MFABooks.PresantationLayer.Books
{
    public partial class BookDelete : Form
    {
        private BooksBLL _booksBll;
        public BookDelete()
        {
            InitializeComponent();
            _booksBll = new BooksBLL();
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
        private void BookDelete_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            BooksPOCO deleteBook = new BooksPOCO();
            deleteBook = _booksBll.deleteBook(textBox1.Text);
            MessageBox.Show("Silme işlemi başarılı");
            ShowList();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            author_textbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nameofbook_textbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            pagecount_textbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            typeofbook_textbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            AnaMenu loginScreen = new AnaMenu();
            this.Hide();
            loginScreen.Show();
        }
    }
}
