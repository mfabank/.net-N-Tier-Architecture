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
    
    public partial class UserUpdate : Form
    {
        private UsersBLL _usersBLL;
        public UserUpdate()
        {
            InitializeComponent();
            _usersBLL = new UsersBLL();
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            UsersPoco users = new UsersPoco();
            users = _usersBLL.userUpdate(textBox1.Text, username_textbox.Text, password_textbox.Text, firstname_textbox.Text, lastname_textbox.Text, Convert.ToInt32(age_textbox.Text), Convert.ToString(gender_combobox.Text));

            MessageBox.Show("Güncelleme işlemi başarılı.");
            ShowList();
        }

        private void UserUpdate_Load(object sender, EventArgs e)
        {
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
