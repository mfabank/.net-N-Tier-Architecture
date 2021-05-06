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
    public partial class BookUpdate : Form
    {
        private BooksBLL _booksBLL;
        public BookUpdate()
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

        private void BookUpdate_Load(object sender, EventArgs e)
        {
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
            AnaMenu anaMenu = new AnaMenu();
            this.Hide();
            anaMenu.Show();
        }

        private void delete_btn_Click_1(object sender, EventArgs e)
        {
            BooksPOCO booksUpdate = new BooksPOCO();
            booksUpdate = _booksBLL.bookUpdate(textBox1.Text, author_textbox.Text, nameofbook_textbox.Text, Convert.ToInt32(pagecount_textbox.Text), Convert.ToString(typeofbook_textbox.Text));

            MessageBox.Show("Güncelleme işlemi başarılı.");
            ShowList();
        }
    }
}
