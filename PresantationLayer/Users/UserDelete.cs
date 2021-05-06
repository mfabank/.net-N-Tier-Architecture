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

namespace MFABooks.PresantationLayer.Users
{
    public partial class UserDelete : Form
    {
        private UsersBLL _usersBll;
        public UserDelete()
        {
            InitializeComponent();
            _usersBll = new UsersBLL();
        }

        public void ShowList()
        {
            DatabaseConnection newConnect = new DatabaseConnection();
            SqlCommand query = new SqlCommand("Select * from Users", newConnect.connection);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();  //Sorguya göre tablonun şeklini belirliyor.
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            UsersPoco deleteUser = new UsersPoco();
            deleteUser = _usersBll.deleteUser(textBox1.Text);
            MessageBox.Show("Silme işlemi başarılı");
            ShowList();
        }

        private void UserDelete_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            username_textbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            password_textbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            firstname_textbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lastname_textbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            age_textbox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            gender_combobox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            AnaMenu loginScreen = new AnaMenu();
            this.Hide();
            loginScreen.Show();
        }
    }
}
